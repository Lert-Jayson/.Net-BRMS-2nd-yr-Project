Imports System.Windows.Forms
Imports System.Data.Odbc
Imports System.Security.Cryptography

Public Class frm_acclist
    Dim mycmd As New OdbcCommand
    Dim estat As String

    Private Sub frm_acclist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectMe()

        cb_position.Items.Add("ADMINISTRATION")
        cb_position.Items.Add("CAPTAIN")
        cb_position.Items.Add("SECRETARY")
        cb_position.Items.Add("KAGAWAD")
        cb_position.Items.Add("SK CHAIRMAIN")
        cb_position.Items.Add("SK KAGAWAD")

        Dim sid As Integer
        Dim cmd As New OdbcCommand("select ifnull(max(user_id),0) from user_tbl", con)
        sid = cmd.ExecuteScalar

        If sid > 0 Then
            Call get_eid()
        Else
            txt_eid.Text = 1
        End If
        txt_fname.Focus()


        Dim mycmd As New OdbcCommand("select user_id, fname, lname, address, contact, email, position, uname, status from user_tbl", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New System.Data.DataSet

        da.Fill(ds, "user_tbl")

        dg_userlist.DataSource = ds.Tables(0)
        dg_userlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg_userlist.RowsDefaultCellStyle.BackColor = Drawing.Color.Aqua
        dg_userlist.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Bisque
        dg_userlist.Refresh()

    End Sub
    Public Sub refreshMe()
        con.Close()

        Try
            con.Open()

            Dim mycmd As New OdbcCommand("select user_id, fname, lname, address, contact, email, position, uname, status from user_tbl", con)
            Dim da As New OdbcDataAdapter(mycmd)
            Dim ds As New System.Data.DataSet

            da.Fill(ds, "user_tbl")

            dg_userlist.DataSource = ds.Tables(0)
            dg_userlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dg_userlist.RowsDefaultCellStyle.BackColor = Drawing.Color.Aqua
            dg_userlist.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Bisque
            dg_userlist.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim e_id As String
        Dim efn As String
        Dim eln As String
        Dim e_adr As String
        Dim e_cont As String
        Dim e_email As String
        Dim e_pos As String
        Dim e_un As String
        Dim e_pw As String

        e_id = txt_eid.Text
        efn = txt_fname.Text.ToUpper.Trim
        eln = txt_lname.Text.ToUpper.Trim
        e_adr = txt_addr.Text.ToUpper.Trim
        e_cont = txt_cont.Text.ToUpper.Trim
        e_email = txt_email.Text
        e_pos = cb_position.SelectedItem
        e_un = txt_uname.Text
        e_pw = txt_pword.Text


        con.Close()
        Try
            con.Open()
            Dim dr As OdbcDataReader
            Dim cmd As New OdbcCommand("select * from user_tbl where fname = '" & efn & "' and lname = '" & eln & "'", con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Error: Duplicate Record." & " " & efn & " " & eln & " is already created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Else

                With mycmd
                    .Connection = con

                    .CommandText = "insert into user_tbl values (null,'" & efn & "','" & eln & "','" & e_adr & "','" & e_cont & "','" & e_email & "','" & e_pos & "','" & e_un & "',MD5('" & e_pw & "'),'" & estat & "')"
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Employee Information Added", "Add Account Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_eid.Clear()
                txt_fname.Clear()
                txt_lname.Clear()
                txt_addr.Clear()
                txt_cont.Clear()
                txt_email.Clear()
                cb_position.SelectedIndex = -1
                txt_uname.Clear()
                txt_pword.Clear()
                txt_confirm.Clear()

                refreshMe()

                Call get_eid()
                btn_save.Enabled = False
                txt_fname.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub get_eid()
        Dim da As New OdbcDataAdapter("select max(user_id) eid1 from user_tbl", con)
        Dim ds As New System.Data.DataSet
        da.Fill(ds)

        txt_eid.Text = ds.Tables(0).Rows(0).Item("eid1") + 1
    End Sub

    Private Function MD5(ByVal sPassword As String) As String
        Dim p As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(sPassword)
        bs = p.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Private Sub rad_Active_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_Active.CheckedChanged
        estat = "Active"
    End Sub

    Private Sub rad_NotActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_NotActive.CheckedChanged
        estat = "Not Active"
    End Sub

    Private Sub dg_userlist_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_userlist.CellContentClick
        Dim i As Integer
        i = dg_userlist.CurrentRow.Index
        txt_eid.Text = dg_userlist.Item(0, i).Value
        txt_fname.Text = dg_userlist.Item(1, i).Value
        txt_lname.Text = dg_userlist.Item(2, i).Value
        txt_addr.Text = dg_userlist.Item(3, i).Value
        txt_cont.Text = dg_userlist.Item(4, i).Value
        txt_email.Text = dg_userlist.Item(5, i).Value
        cb_position.Text = dg_userlist.Item(6, i).Value
        cb_position.SelectedValue = dg_userlist.Item(6, i).Value
        txt_uname.Text = dg_userlist.Item(7, i).Value

        txt_uname.Clear()
        txt_pword.Clear()
        txt_confirm.Clear()

        txt_uname.Enabled = False
        txt_pword.Enabled = False
        txt_confirm.Enabled = False
        btn_save.Enabled = False

    End Sub

    Private Sub txt_fname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_fname.KeyDown
        If e.KeyCode = 13 Then
            If txt_fname.Text = "" Then
                MessageBox.Show("Fill in First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_fname.Focus()
            Else
                txt_lname.Focus()
            End If
        End If
    End Sub

    Private Sub txt_lname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_lname.KeyDown
        If e.KeyCode = 13 Then
            If txt_lname.Text = "" Then
                MessageBox.Show("Fill in Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_lname.Focus()
            Else
                txt_addr.Focus()
            End If
        End If
    End Sub

    Private Sub txt_addr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_addr.KeyDown
        If e.KeyCode = 13 Then
            If txt_addr.Text = "" Then
                MessageBox.Show("Fill in your address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_addr.Focus()
            Else
                txt_cont.Focus()
            End If
        End If
    End Sub

    Private Sub txt_cont_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cont.KeyDown
        If e.KeyCode = 13 Then
            If txt_cont.Text = "" Then
                MessageBox.Show("Fill in your contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_cont.Focus()
            Else
                txt_email.Focus()
            End If
        End If
    End Sub

    Private Sub txt_email_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_email.KeyDown
        If e.KeyCode = 13 Then
            If txt_email.Text = "" Then
                MessageBox.Show("Fill in your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_email.Focus()
            Else
                cb_position.Focus()
            End If
        End If
    End Sub

    Private Sub cb_position_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_position.KeyDown
        If e.KeyCode = 13 Then
            If cb_position.Text = "" Then
                MessageBox.Show("Fill in your Position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cb_position.Focus()
            Else
                txt_uname.Focus()
            End If
        End If
    End Sub

    Private Sub txt_uname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_uname.KeyDown
        If e.KeyCode = 13 Then
            If txt_uname.Text = "" Then
                MessageBox.Show("Fill in your Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_uname.Focus()
            Else
                txt_pword.Focus()
            End If
        End If
    End Sub

    Private Sub txt_pword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pword.KeyDown
        If e.KeyCode = 13 Then
            If txt_pword.Text = "" Then
                MessageBox.Show("Fill in your Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_pword.Focus()
            Else
                txt_confirm.Focus()
            End If
        End If
    End Sub

    Private Sub txt_confirm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_confirm.KeyDown
        If e.KeyCode = 13 Then
            If txt_confirm.Text = "" Then
                MessageBox.Show("Fill in Cornformation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_confirm.Focus()

            ElseIf txt_pword.Text <> txt_confirm.Text Then
                MessageBox.Show("Password does not Match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                rad_Active.Focus()
            End If
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_uname.Clear()
        txt_pword.Clear()
        txt_confirm.Clear()
    End Sub
End Class