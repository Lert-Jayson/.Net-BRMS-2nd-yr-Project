Imports System.Windows.Forms
Imports System.Data.Odbc

Public Class frm_brgyClearance
    Dim mycmd As New OdbcCommand

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub frm_brgyClearance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_cid.Hide()
        connectMe()

        txt_givenby.Text = username1
        txt_capt.Text = "Capt. Sean William Cañaveral"

        btn_print.Enabled = False
        btn_save.Enabled = False

        

        Dim sid As Integer
        Dim cmd As New OdbcCommand("select ifnull(max(clr_id),0) from clr_tbl", con)
        sid = cmd.ExecuteScalar

        If sid > 0 Then
            Call get_cid()
        Else
            txt_cid.Text = 1
        End If
        txt_lname.Focus()

        Dim mycmd As New OdbcCommand("select * from clr_tbl", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New System.Data.DataSet

        da.Fill(ds, "clr_tbl")

        dg_bc.DataSource = ds.Tables(0)
        dg_bc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg_bc.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
        dg_bc.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
        dg_bc.Refresh()

        If usertype = "SK KAGAWAD" Or usertype = "SK CHAIRMAN" Or usertype = "CAPTAIN" Then
            btn_save.Enabled = False
            btn_print.Enabled = False
            btn_search.Enabled = False

        End If

    End Sub
    Public Sub refreshMe()
        con.Close()

        Try
            con.Open()

            Dim mycmd As New OdbcCommand("select * from clr_tbl", con)
            Dim da As New OdbcDataAdapter(mycmd)
            Dim ds As New System.Data.DataSet

            da.Fill(ds, "clr_tbl")

            dg_bc.DataSource = ds.Tables(0)
            dg_bc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dg_bc.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
            dg_bc.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
            dg_bc.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim cid As String
        Dim lname As String
        Dim fname As String
        Dim age As String
        Dim civil As String
        Dim hnum As String
        Dim street As String
        Dim purp As String
        Dim dte As Date
        Dim given As String
        Dim cap As String

        cid = txt_cid.Text
        lname = txt_lname.Text.ToUpper.Trim
        fname = txt_fname.Text.ToUpper.Trim
        age = txt_age.Text
        civil = txt_civil.Text
        hnum = txt_hnum.Text.ToUpper.Trim
        street = txt_street.Text
        purp = txt_purpose.Text.ToUpper.Trim
        dte = dtp_dg.Text
        given = txt_givenby.Text.ToUpper.Trim
        cap = txt_capt.Text.ToUpper.Trim

        con.Close()



        con.Open()
        Dim dr1 As OdbcDataReader
        Dim cmd1 As New OdbcCommand("select * from comp_tbl where lname = '" & lname & "' and fname = '" & fname & "'", con)
        dr1 = cmd1.ExecuteReader
        If dr1.HasRows Then
            MessageBox.Show("This person " & " " & lname & ", " & fname & "  has a Unsettled record.", "Complaints info", MessageBoxButtons.OK, MessageBoxIcon.Error)


            btn_print.Enabled = False
            btn_save.Enabled = False
            txt_lname.Clear()
            txt_fname.Clear()
            txt_age.Clear()
            txt_civil.Clear()
            txt_hnum.Clear()
            txt_street.Clear()
            txt_purpose.Clear()

        Else

            Try
                Dim dr As OdbcDataReader
                Dim cmd As New OdbcCommand("select * from clr_tbl where fname = '" & fname & "' and lname = '" & lname & "'", con)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MessageBox.Show("Error: Duplicate Record." & " " & fname & " " & lname & " is already created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                Else
                    With mycmd
                        .Connection = con

                        .CommandText = "insert into clr_tbl values ('" & cid & "','" & lname & "','" & fname & "','" & age & "','" & civil & "','" & hnum & "','" & street & "','" & purp & "','" & dte & "','" & given & "','" & cap & "')"
                        .ExecuteNonQuery()
                    End With
                    MessageBox.Show("Barangay Clearance Information Added", "Add Account Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    refreshMe()
                    txt_lname.Clear()
                    txt_fname.Clear()
                    txt_age.Clear()
                    txt_civil.Clear()
                    txt_hnum.Clear()
                    txt_street.Clear()
                    txt_purpose.Clear()

                    Call get_cid()

                    txt_lname.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try

        End If
       

    End Sub
    Public Sub get_cid()
        Dim da As New OdbcDataAdapter("select max(clr_id) cid1 from clr_tbl", con)
        Dim ds As New System.Data.DataSet
        da.Fill(ds)

        txt_cid.Text = ds.Tables(0).Rows(0).Item("cid1") + 1
    End Sub
    Private Sub dg_bc_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_bc.CellContentClick
        Dim i As Integer
        i = dg_bc.CurrentRow.Index
        txt_cid.Text = dg_bc.Item(0, i).Value
        txt_lname.Text = dg_bc.Item(1, i).Value
        txt_fname.Text = dg_bc.Item(2, i).Value
        txt_age.Text = dg_bc.Item(3, i).Value
        txt_civil.Text = dg_bc.Item(4, i).Value
        txt_hnum.Text = dg_bc.Item(5, i).Value
        txt_street.Text = dg_bc.Item(6, i).Value
        txt_purpose.Text = dg_bc.Item(7, i).Value
        dtp_dg.Text = dg_bc.Item(8, i).Value
        txt_givenby.Text = dg_bc.Item(9, i).Value
        txt_capt.Text = dg_bc.Item(10, i).Value

        btn_print.Enabled = True

        If usertype = "SK KAGAWAD" Or usertype = "SK CHAIRMAN" Or usertype = "CAPTAIN" Then
            btn_save.Enabled = False
            btn_print.Enabled = False
            btn_search.Enabled = False

        End If

    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        Dim clr_rep As New clearance_report

        clr_rep.SetParameterValue("lname", txt_lname.Text)
        clr_rep.SetParameterValue("fname", txt_fname.Text)
        clr_rep.SetParameterValue("age", txt_age.Text)
        clr_rep.SetParameterValue("civil", txt_civil.Text)
        clr_rep.SetParameterValue("addr", txt_hnum.Text)
        clr_rep.SetParameterValue("street", txt_street.Text)
        clr_rep.SetParameterValue("purp", txt_purpose.Text)
        
        frrm_printbclearance.cviewer.ReportSource = clr_rep


        frrm_printbclearance.ShowDialog()
    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        frm_Residents.Show()
        frm_Residents.btn_selectBC.Show()
        frm_Residents.btn_new.Enabled = False
        frm_Residents.btn_print.Enabled = False
        frm_Residents.btn_edit.Enabled = False
        frm_Residents.btn_delete.Enabled = False



    End Sub

    
    Private Sub btn_srch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_srch.Click
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
                Dim mycmd1 As New OdbcCommand("select * from clr_tbl where lname = '" & lname & "'", con)
                dr1 = mycmd1.ExecuteReader
                If dr1.HasRows Then
                    Dim mycmd2 As New OdbcCommand("select * from clr_tbl where lname = '" & lname & "'", con)
                    Dim da2 As New OdbcDataAdapter(mycmd2)
                    Dim ds2 As New System.Data.DataSet

                    da2.Fill(ds2, " clr_tbl")

                    dg_bc.DataSource = ds2.Tables(0)
                    dg_bc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dg_bc.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
                    dg_bc.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
                    dg_bc.Refresh()

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

    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = 13 Then
            If txt_search.Text = "" Then
                MessageBox.Show("Fill in the search box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_search.Focus()
            Else
                btn_srch.Focus()
            End If
        End If
    End Sub

  
   
    Private Sub txt_purpose_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_purpose.KeyDown
        If e.KeyCode = 13 Then
            If txt_purpose.Text = "" Then
                MessageBox.Show("Enter your Purpose.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_purpose.Focus()
            Else
                btn_save.Enabled = True
                btn_save.Focus()
            End If
        End If
    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        con.Close()

        Try
            con.Open()

            Dim mycmd As New OdbcCommand("select * from clr_tbl", con)
            Dim da As New OdbcDataAdapter(mycmd)
            Dim ds As New System.Data.DataSet

            da.Fill(ds, "clr_tbl")

            dg_bc.DataSource = ds.Tables(0)
            dg_bc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dg_bc.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
            dg_bc.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
            dg_bc.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
End Class