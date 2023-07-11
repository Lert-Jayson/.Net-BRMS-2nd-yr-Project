Imports System.Windows.Forms
Imports System.Data.Odbc

Public Class frm_complain
    Dim mycmd As New OdbcCommand


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frm_complain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectMe()

        txt_encoder.Text = username1
        txt_dof.Text = DateTime.Now.ToLongDateString()

        cb_remarks.Items.Add("SETTELED")
        cb_remarks.Items.Add("UNSETTELED")

        Dim sid As Integer
        Dim cmd As New OdbcCommand("select ifnull(max(comp_id),0) from comp_tbl", con)
        sid = cmd.ExecuteScalar

        If sid > 0 Then
            Call get_csid()
        Else
            txt_csid.Text = 1
        End If
        txt_complanant.Focus()

        Dim mycmd As New OdbcCommand("select * from comp_tbl", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New System.Data.DataSet

        da.Fill(ds, "comp_tbl")

        dg_complist.DataSource = ds.Tables(0)
        dg_complist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg_complist.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
        dg_complist.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
        dg_complist.Refresh()


        txt_complanant.Enabled = False
        txt_lname.Enabled = False
        txt_fname.Enabled = False
       
        txt_nofc.Enabled = False
        cb_remarks.Enabled = False
        txt_details.Enabled = False


        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_update.Enabled = False

        If usertype = "SK KAGAWAD" Or usertype = "SK CHAIRMAN" Or usertype = "CAPTAIN" Then
            btn_save.Enabled = False
            btn_edit.Enabled = False
            btn_update.Enabled = False
            btn_delete.Enabled = False
            btn_new.Enabled = False
            btn_srch.Enabled = False

        End If


    End Sub
    Public Sub refreshMe()
        con.Close()

        Try
            con.Open()

            Dim mycmd As New OdbcCommand("select * from comp_tbl", con)
            Dim da As New OdbcDataAdapter(mycmd)
            Dim ds As New System.Data.DataSet

            da.Fill(ds, "comp_tbl")

            dg_complist.DataSource = ds.Tables(0)
            dg_complist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dg_complist.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
            dg_complist.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
            dg_complist.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim csid As String
        Dim compl As String
        Dim lname As String
        Dim fname As String
        Dim dof As String
        Dim tof As String
        Dim nofc As String
        Dim remark As String
        Dim dtls As String
        Dim encod As String


        csid = txt_csid.Text
        compl = txt_complanant.Text.ToUpper.Trim
        lname = txt_lname.Text.ToUpper.Trim
        fname = txt_fname.Text.ToUpper.Trim
        dof = txt_dof.Text
        tof = txt_tof.Text
        nofc = txt_nofc.Text.ToUpper.Trim
        remark = cb_remarks.SelectedItem
        dtls = txt_details.Text.ToUpper.Trim
        encod = txt_encoder.Text.ToUpper.Trim

        con.Close()
        Try
            con.Open()
            Dim dr As OdbcDataReader
            Dim cmd As New OdbcCommand("select * from comp_tbl where fname = '" & fname & "' and lname = '" & lname & "'", con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Error: Duplicate Record." & " " & fname & " " & lname & " is already created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Else
                With mycmd
                    .Connection = con
                    .CommandText = "insert into comp_tbl values ('" & csid & "','" & compl & "','" & lname & "','" & fname & "','" & dof & "','" & tof & "','" & nofc & "','" & remark & "','" & dtls & "','" & encod & "')"
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Complaints Information Added", "Add Account Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                refreshMe()


                txt_csid.Clear()
                txt_complanant.Clear()
                txt_lname.Clear()
                txt_fname.Clear()
                txt_dof.Clear()
                txt_tof.Clear()
                txt_nofc.Clear()
                cb_remarks.SelectedIndex = -1
                txt_details.Clear()

                Call get_csid()

                txt_complanant.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

    End Sub

    Public Sub get_csid()
        Dim da1 As New OdbcDataAdapter("select max(comp_id) csid from comp_tbl", con)
        Dim ds1 As New System.Data.DataSet
        da1.Fill(ds1)

        txt_csid.Text = ds1.Tables(0).Rows(0).Item("csid") + 1
    End Sub

    Private Sub dg_complist_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_complist.CellContentClick
        Dim i As Integer
        i = dg_complist.CurrentRow.Index
        txt_csid.Text = dg_complist.Item(0, i).Value
        txt_complanant.Text = dg_complist.Item(1, i).Value
        txt_lname.Text = dg_complist.Item(2, i).Value
        txt_fname.Text = dg_complist.Item(3, i).Value
        txt_dof.Text = dg_complist.Item(4, i).Value
        txt_tof.Text = dg_complist.Item(5, i).Value
        txt_nofc.Text = dg_complist.Item(6, i).Value
        cb_remarks.Text = dg_complist.Item(7, i).Value
        cb_remarks.SelectedValue = dg_complist.Item(7, i).Value
        txt_details.Text = dg_complist.Item(8, i).Value


        txt_complanant.Enabled = False
        txt_lname.Enabled = False
        txt_fname.Enabled = False
       
        txt_nofc.Enabled = False
        cb_remarks.Enabled = False
        txt_details.Enabled = False


        btn_delete.Enabled = True
        btn_edit.Enabled = True
        btn_save.Enabled = False
        btn_update.Enabled = False

        If usertype = "SK KAGAWAD" Or usertype = "SK CHAIRMAN" Or usertype = "CAPTAIN" Then
            btn_save.Enabled = False
            btn_edit.Enabled = False
            btn_update.Enabled = False
            btn_delete.Enabled = False
            btn_new.Enabled = False

        End If

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim csid As String
        Dim compl As String
        Dim lname As String
        Dim fname As String
        Dim nofc As String
        Dim remark As String
        Dim dtls As String

        csid = txt_csid.Text
        compl = txt_complanant.Text.ToUpper.Trim
        lname = txt_lname.Text.ToUpper.Trim
        fname = txt_fname.Text.ToUpper.Trim
        nofc = txt_nofc.Text.ToUpper.Trim
        remark = cb_remarks.SelectedItem
        dtls = txt_details.Text.ToUpper.Trim


        con.Close()

        Try
            con.Open()

            With mycmd
                .Connection = con
                .CommandText = "update comp_tbl set comp_id = '" & csid & "', complainant = '" & compl & "', lname = '" & lname & "', fname = '" & fname & "', nature = '" & nofc & "',remarks = '" & remark & "',details = '" & dtls & "' where comp_id = '" & csid & "' "
                .ExecuteNonQuery()

            End With
            MessageBox.Show("Record is updated!", "Update Complaint Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshMe()

            txt_csid.Clear()
            txt_complanant.Clear()
            txt_lname.Clear()
            txt_fname.Clear()
            txt_dof.Clear()
            txt_tof.Clear()
            txt_nofc.Clear()
            cb_remarks.SelectedIndex = -1
            txt_details.Clear()


            txt_complanant.Enabled = False
            txt_lname.Enabled = False
            txt_fname.Enabled = False
            txt_nofc.Enabled = False
            cb_remarks.Enabled = False
            txt_details.Enabled = False


            btn_delete.Enabled = False
            btn_edit.Enabled = False
            btn_save.Enabled = False
            btn_update.Enabled = False
            btn_new.Enabled = True



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim id1 As String
        Dim result1 As New DialogResult

        id1 = txt_csid.Text

        con.Close()
        Try
            con.Open()
            result1 = MessageBox.Show("Are you sure you want to delete the record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result1 = System.Windows.Forms.DialogResult.Yes Then
                With mycmd
                    .Connection = con
                    .CommandText = "delete from comp_tbl where comp_id= '" & id1 & "'"
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Record is deleted!", "Delete Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                refreshMe()

                txt_csid.Clear()
                txt_complanant.Clear()
                txt_lname.Clear()
                txt_fname.Clear()
                txt_dof.Clear()
                txt_tof.Clear()
                txt_nofc.Clear()
                cb_remarks.SelectedIndex = -1
                txt_details.Clear()



            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        

        txt_complanant.Enabled = True
        txt_lname.Enabled = True
        txt_fname.Enabled = True
        txt_nofc.Enabled = True
        cb_remarks.Enabled = True
        txt_details.Enabled = True


        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_update.Enabled = True

    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click

        txt_complanant.Clear()
        txt_lname.Clear()
        txt_fname.Clear()
        txt_nofc.Clear()
        cb_remarks.SelectedIndex = -1
        txt_details.Clear()


        txt_complanant.Enabled = True
        txt_lname.Enabled = True
        txt_fname.Enabled = True
        txt_nofc.Enabled = True
        cb_remarks.Enabled = True
        txt_details.Enabled = True

        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = True
        btn_update.Enabled = False

       
    End Sub

    
    Private Sub txt_complanant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_complanant.KeyDown
        If e.KeyCode = 13 Then
            If txt_complanant.Text = "" Then
                MessageBox.Show("Fill in the Complanant's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_complanant.Focus()
            Else
                btn_srch.Focus()
            End If
        End If
    End Sub

    Private Sub txt_nofc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nofc.KeyDown
        If e.KeyCode = 13 Then
            If txt_nofc.Text = "" Then
                MessageBox.Show("Fill in the Nature of case.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_nofc.Focus()
            Else
                cb_remarks.Focus()
            End If
        End If
    End Sub

    Private Sub cb_remarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_remarks.KeyDown
        If e.KeyCode = 13 Then
            If cb_remarks.Text = "" Then
                MessageBox.Show("Fill in the Remarks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cb_remarks.Focus()
            Else
                txt_details.Focus()
            End If
        End If
    End Sub

    
    Private Sub txt_details_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_details.KeyDown
        If e.KeyCode = 13 Then
            If txt_details.Text = "" Then
                MessageBox.Show("Fill in the Details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_details.Focus()
            Else
                btn_save.Focus()
            End If
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
                Dim mycmd1 As New OdbcCommand("select * from comp_tbl where lname = '" & lname & "'", con)
                dr1 = mycmd1.ExecuteReader
                If dr1.HasRows Then
                    Dim mycmd2 As New OdbcCommand("select * from comp_tbl where lname = '" & lname & "'", con)
                    Dim da2 As New OdbcDataAdapter(mycmd2)
                    Dim ds2 As New System.Data.DataSet

                    da2.Fill(ds2, " comp_tbl")

                    dg_complist.DataSource = ds2.Tables(0)
                    dg_complist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dg_complist.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
                    dg_complist.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
                    dg_complist.Refresh()

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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txt_tof.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_srch.Click
        frm_Residents.Show()
        frm_Residents.btn_selectcomp.Show()
        frm_Residents.btn_new.Enabled = False
        frm_Residents.btn_print.Enabled = False
        frm_Residents.btn_edit.Enabled = False
        frm_Residents.btn_delete.Enabled = False
    End Sub
End Class