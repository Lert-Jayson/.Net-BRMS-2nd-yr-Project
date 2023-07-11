Imports System.Windows.Forms
Imports System.Data.Odbc

Public Class frm_brgyOfficials
    Dim mycmd As New OdbcCommand


    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub frm_brgyOfficials_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectMe()

        cb_pos.Items.Add("CAPTAIN")
        cb_pos.Items.Add("SECRETARY")
        cb_pos.Items.Add("KAGAWAD")
        cb_pos.Items.Add("SK CHAIRMAIN")
        cb_pos.Items.Add("SK KAGAWAD")

        Dim sid As Integer
        Dim cmd As New OdbcCommand("select ifnull(max(official_id),0) from off_tbl", con)
        sid = cmd.ExecuteScalar

        If sid > 0 Then
            Call get_oid()
        Else
            txt_oid.Text = 1
        End If
        txt_fname.Focus()

        Dim mycmd As New OdbcCommand("select official_id, fname, lname, mname, age, bday, position, status from off_tbl", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New System.Data.DataSet

        da.Fill(ds, "off_tbl")

        dg_olist.DataSource = ds.Tables(0)
        dg_olist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg_olist.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
        dg_olist.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
        dg_olist.Refresh()

        txt_lname.Enabled = False
        txt_fname.Enabled = False
        txt_mname.Enabled = False
        txt_age.Enabled = False
        dtp_dob.Enabled = False
        cb_pos.Enabled = False
        rad_active.Enabled = False
        rad_notactive.Enabled = False

        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False









    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim oid As String
        Dim fname As String
        Dim lname As String
        Dim mname As String
        Dim age As String
        Dim dob As String
        Dim pos As String
        Dim stat As String

        oid = txt_oid.Text
        fname = txt_fname.Text.ToUpper.Trim
        lname = txt_lname.Text.ToUpper.Trim
        mname = txt_mname.Text.ToUpper.Trim
        age = txt_age.Text
        dob = dtp_dob.Text
        pos = cb_pos.SelectedItem
        stat = txt_stat.Text

        con.Close()

        Try
            con.Open()
            Dim dr As OdbcDataReader
            Dim cmd As New OdbcCommand("select * from off_tbl where fname = '" & fname & "' and lname = '" & lname & "'", con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Error: Duplicate Record." & " " & fname & " " & lname & " is already created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Else

                With mycmd
                    .Connection = con

                    .CommandText = "insert into off_tbl values ('" & oid & "','" & fname & "','" & lname & "','" & mname & "','" & age & "','" & dob & "','" & pos & "','" & stat & "')"
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Official Information Added", "Add Account Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_age.Clear()
                txt_lname.Clear()
                txt_mname.Clear()
                txt_fname.Clear()
                cb_pos.SelectedIndex = -1
                txt_stat.Clear()
                rad_active.Checked = False
                rad_notactive.Checked = False

                refreshMe()




                Call get_oid()

                txt_fname.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try


    End Sub
    Public Sub get_oid()
        Dim da As New OdbcDataAdapter("select max(official_id) oid1 from off_tbl", con)
        Dim ds As New System.Data.DataSet
        da.Fill(ds)

        txt_oid.Text = ds.Tables(0).Rows(0).Item("oid1") + 1
    End Sub

    Private Sub rad_active_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_active.CheckedChanged
        txt_stat.Text = "ACTIVE"
    End Sub

    Private Sub rad_notactive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_notactive.CheckedChanged
        txt_stat.Text = "NOT ACTIVE"
    End Sub
    Public Sub refreshMe()
        con.Close()

        Try
            con.Open()

            Dim mycmd As New OdbcCommand("select * from off_tbl", con)
            Dim da As New OdbcDataAdapter(mycmd)
            Dim ds As New System.Data.DataSet

            da.Fill(ds, "off_tbl")

            dg_olist.DataSource = ds.Tables(0)
            dg_olist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dg_olist.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
            dg_olist.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
            dg_olist.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dg_olist_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_olist.CellContentClick
        Dim i As Integer
        i = dg_olist.CurrentRow.Index
        txt_oid.Text = dg_olist.Item(0, i).Value
        txt_lname.Text = dg_olist.Item(1, i).Value
        txt_fname.Text = dg_olist.Item(2, i).Value
        txt_mname.Text = dg_olist.Item(3, i).Value
        txt_age.Text = dg_olist.Item(4, i).Value
        dtp_dob.Text = dg_olist.Item(5, i).Value
        cb_pos.Text = dg_olist.Item(6, i).Value
        cb_pos.SelectedValue = dg_olist.Item(6, i).Value
        txt_stat.Text = dg_olist.Item(7, i).Value

        txt_lname.Enabled = False
        txt_fname.Enabled = False
        txt_mname.Enabled = False
        txt_age.Enabled = False
        dtp_dob.Enabled = False
        cb_pos.Enabled = False
        rad_active.Enabled = False
        rad_notactive.Enabled = False

        btn_delete.Enabled = True
        btn_edit.Enabled = True
        btn_update.Enabled = False
        btn_save.Enabled = False

        If usertype = "SK KAGAWAD" Or usertype = "SK CHAIRMAN" Or usertype = "CAPTAIN" Then
            btn_save.Enabled = False
            btn_edit.Enabled = False
            btn_update.Enabled = False
            btn_delete.Enabled = False
            btn_new.Enabled = False

        End If
    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        If txt_search.Text = "" Then
            MessageBox.Show("Fill in Last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_search.Focus()
        Else
            Dim lname As String
            lname = txt_search.Text.Trim
            con.Close()

            Try
                con.Open()

                Dim dr1 As OdbcDataReader
                Dim mycmd1 As New OdbcCommand("select * from off_tbl where lname = '" & lname & "'", con)
                dr1 = mycmd1.ExecuteReader
                If dr1.HasRows Then
                    Dim mycmd2 As New OdbcCommand("select * from off_tbl where lname = '" & lname & "'", con)
                    Dim da2 As New OdbcDataAdapter(mycmd2)
                    Dim ds2 As New System.Data.DataSet

                    da2.Fill(ds2, " resident_tbl")

                    dg_olist.DataSource = ds2.Tables(0)
                    dg_olist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dg_olist.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
                    dg_olist.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
                    dg_olist.Refresh()

                    txt_search.Clear()

                Else
                    MessageBox.Show("No records found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
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
                txt_mname.Focus()
            End If
        End If
    End Sub


    Private Sub txt_age_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_age.KeyDown
        If e.KeyCode = 13 Then
            If txt_age.Text = "" Then
                MessageBox.Show("Fill in Age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_age.Focus()
            Else
                dtp_dob.Focus()
            End If
        End If
    End Sub

    Private Sub cb_pos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_pos.KeyDown
        If e.KeyCode = 13 Then
            If cb_pos.Text = "" Then
                MessageBox.Show("Fill in Position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cb_pos.Focus()
            Else
                rad_active.Focus()
            End If
        End If
    End Sub

    Private Sub txt_mname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_mname.KeyDown
        If e.KeyCode = 13 Then
            If txt_mname.Text = "" Then
                MessageBox.Show("Fill in Middle name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_mname.Focus()
            Else
                txt_age.Focus()
            End If
        End If
    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click
        txt_lname.Enabled = True
        txt_fname.Enabled = True
        txt_mname.Enabled = True
        txt_age.Enabled = True
        dtp_dob.Enabled = True
        cb_pos.Enabled = True
        rad_active.Enabled = True
        rad_notactive.Enabled = True

        txt_age.Clear()
        txt_lname.Clear()
        txt_mname.Clear()
        txt_fname.Clear()
        cb_pos.SelectedIndex = -1
        txt_stat.Clear()
        rad_active.Checked = False
        rad_notactive.Checked = False

        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_update.Enabled = False
        btn_save.Enabled = True
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        txt_lname.Enabled = True
        txt_fname.Enabled = True
        txt_mname.Enabled = True
        txt_age.Enabled = True
        dtp_dob.Enabled = True
        cb_pos.Enabled = True
        rad_active.Enabled = True
        rad_notactive.Enabled = True

        btn_update.Enabled = True
        btn_edit.Enabled = False
        btn_delete.Enabled = False

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim oid1 As String
        Dim fname1 As String
        Dim lname1 As String
        Dim mname1 As String
        Dim age1 As String
        Dim dob1 As String
        Dim pos1 As String
        Dim stat1 As String


        oid1 = txt_oid.Text
        fname1 = txt_fname.Text.ToUpper.Trim
        lname1 = txt_lname.Text.ToUpper.Trim
        mname1 = txt_mname.Text.ToUpper.Trim
        age1 = txt_age.Text
        dob1 = dtp_dob.Text
        pos1 = cb_pos.SelectedItem
        stat1 = txt_stat.Text


        con.Close()

        Try
            con.Open()

            With mycmd
                .Connection = con
                .CommandText = "update off_tbl set official_id = '" & oid1 & "', fname = '" & fname1 & "', lname = '" & lname1 & "', mname = '" & mname1 & "', age = '" & age1 & "',bday = '" & dob1 & "',position = '" & pos1 & "',status = '" & stat1 & "' where official_id = '" & oid1 & "' "
                .ExecuteNonQuery()

            End With

            MessageBox.Show("Record is updated!", "Update Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshMe()

            txt_age.Clear()
            txt_lname.Clear()
            txt_mname.Clear()
            txt_fname.Clear()
            cb_pos.SelectedIndex = -1
            txt_stat.Clear()
            rad_active.Checked = False
            rad_notactive.Checked = False


            txt_lname.Enabled = False
            txt_fname.Enabled = False
            txt_mname.Enabled = False
            txt_age.Enabled = False
            dtp_dob.Enabled = False
            cb_pos.Enabled = False
            rad_active.Enabled = False
            rad_notactive.Enabled = False

            btn_save.Enabled = False
            btn_edit.Enabled = False
            btn_delete.Enabled = False
            btn_exit.Enabled = True
            btn_update.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()

        End Try

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim id1 As String
        Dim result1 As New DialogResult

        id1 = txt_oid.Text

        con.Close()
        Try
            con.Open()
            result1 = MessageBox.Show("Are you sure you want to delete the record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result1 = System.Windows.Forms.DialogResult.Yes Then
                With mycmd
                    .Connection = con
                    .CommandText = "delete from off_tbl where official_id= '" & id1 & "'"
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Record is deleted!", "Delete Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                refreshMe()

                txt_age.Clear()
                txt_lname.Clear()
                txt_mname.Clear()
                txt_fname.Clear()
                cb_pos.SelectedIndex = -1
                txt_stat.Clear()
                rad_active.Checked = False
                rad_notactive.Checked = False


                btn_save.Enabled = False
                btn_edit.Enabled = False
                btn_delete.Enabled = False
                btn_exit.Enabled = True

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_update.Enabled = False
        btn_exit.Enabled = True

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        If usertype = "SK KAGAWAD" Or usertype = "SK CHAIRMAN" Or usertype = "CAPTAIN" Then
            btn_save.Enabled = False
            btn_edit.Enabled = False
            btn_update.Enabled = False
            btn_delete.Enabled = False
            btn_new.Enabled = False

        End If
    End Sub

End Class