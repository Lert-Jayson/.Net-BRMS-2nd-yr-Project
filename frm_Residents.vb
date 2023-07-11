Imports System.Windows.Forms
Imports System.Data.Odbc
Imports System.Data.DataSet
Imports System.Data.DataTable

Public Class frm_Residents
    Dim mycmd As New OdbcCommand


    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub frm_Residents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectMe()


        cb_ext.Items.Add("N/A")
        cb_ext.Items.Add("JR")
        cb_ext.Items.Add("SR")

        cb_civil.Items.Add("SINGLE")
        cb_civil.Items.Add("MARRIED")
        cb_civil.Items.Add("SEPERATED")
        cb_civil.Items.Add("WIDOW")

        btn_selectBC.Hide()
        btn_selectIND.Hide()
        btn_selectcomp.Hide()


        Dim mycmd As New OdbcCommand("select * from resident_tbl", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New System.Data.DataSet

        da.Fill(ds, "resident_tbl")

        dg_rlist.DataSource = ds.Tables(0)
        dg_rlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg_rlist.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
        dg_rlist.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
        dg_rlist.Refresh()

        Dim sid As Integer
        Dim cmd As New OdbcCommand("select ifnull(max(house_id),0) from resident_tbl", con)
        sid = cmd.ExecuteScalar

        If sid > 0 Then
            Call get_rid()
        Else
            txt_rid.Text = 1
        End If
        txt_fname.Focus()

        txt_lname.Enabled = False
        txt_fname.Enabled = False
        txt_mname.Enabled = False
        cb_ext.Enabled = False
        txt_age.Enabled = False
        dtp_bday.Enabled = False
        txt_pob.Enabled = False
        rad_male.Enabled = False
        rad_female.Enabled = False
        cb_civil.Enabled = False
        txt_citizen.Enabled = False
        txt_occupation.Enabled = False
        txt_hnum.Enabled = False
        cb_street.Enabled = False

        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
        btn_print.Enabled = False
        btn_exit.Enabled = True
        btn_new.Enabled = True


        Dim mycmd2 As New OdbcCommand("select street from street_tbl order by street asc", con)
        Dim da1 As New OdbcDataAdapter(mycmd2)
        Dim dt As New System.Data.DataTable
        Dim st As Integer
        st = 0

        da1.Fill(dt)
        While st <> dt.Rows.Count
            cb_street.Items.Add(dt.Rows.Item(st).Item("street"))
            st += 1
        End While

        If usertype = "SK KAGAWAD" Or usertype = "SK CHAIRMAN" Or usertype = "CAPTAIN" Then
            btn_save.Enabled = False
            btn_edit.Enabled = False
            btn_update.Enabled = False
            btn_delete.Enabled = False
            btn_print.Enabled = False
            btn_new.Enabled = False

        End If

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim rid As String
        Dim hlname As String
        Dim hfname As String
        Dim hmname As String
        Dim hext As String
        Dim age As String
        Dim dob As Date
        Dim hpob As String
        Dim civil As String
        Dim hcitiz As String
        Dim hocc As String
        Dim hnum As String
        Dim hstreet As String
        Dim sx As String

        rid = txt_rid.Text
        hlname = txt_lname.Text.ToUpper.Trim
        hfname = txt_fname.Text.ToUpper.Trim
        hmname = txt_mname.Text.ToUpper.Trim
        hext = cb_ext.SelectedItem
        age = txt_age.Text
        dob = dtp_bday.Text
        hpob = txt_pob.Text.ToUpper.Trim
        civil = cb_civil.SelectedItem
        hcitiz = txt_citizen.Text.ToUpper.Trim
        hocc = txt_occupation.Text.ToUpper.Trim
        hnum = txt_hnum.Text
        hstreet = cb_street.SelectedItem
        sx = txt_sx.Text.ToUpper.Trim

        con.Close()

        Try
            con.Open()
            Dim dr As OdbcDataReader
            Dim cmd As New OdbcCommand("select * from resident_tbl where lname = '" & hlname & "' and fname = '" & hfname & "'", con)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                MessageBox.Show("Error: Duplicate Record." & " " & hlname & " " & hfname & " is already created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()

            Else

                With mycmd
                    .Connection = con

                    .CommandText = "insert into resident_tbl values ('" & rid & "','" & hlname & "','" & hfname & "','" & hmname & "','" & hext & "','" & age & "','" & dob & "','" & hpob & "','" & sx & "','" & civil & "','" & hcitiz & "','" & hocc & "','" & hnum & "','" & hstreet & "')"
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Resident Information Added", "Add Resident Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_rid.Clear()
                txt_lname.Clear()
                txt_fname.Clear()
                txt_mname.Clear()
                txt_age.Clear()
                txt_sx.Clear()
                cb_ext.Text = "N/A"
                txt_pob.Clear()
                cb_civil.SelectedIndex = -1
                txt_citizen.Text = "FILIPINO"
                txt_occupation.Text = "N/A"
                txt_hnum.Clear()
                cb_street.SelectedIndex = -1

                rad_male.Checked = False
                rad_female.Checked = False


                refreshMe()

                Call get_rid()

                txt_fname.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()


            txt_lname.Enabled = False
            txt_fname.Enabled = False
            txt_mname.Enabled = False
            cb_ext.Enabled = False
            txt_age.Enabled = False
            dtp_bday.Enabled = False
            txt_pob.Enabled = False
            rad_male.Enabled = False
            rad_female.Enabled = False
            cb_civil.Enabled = False
            txt_citizen.Enabled = False
            txt_occupation.Enabled = False
            txt_hnum.Enabled = False
            cb_street.Enabled = False

        End Try
    End Sub
    Public Sub get_rid()
        Dim da As New OdbcDataAdapter("select max(house_id) rid1 from resident_tbl", con)
        Dim ds As New System.Data.DataSet
        da.Fill(ds)

        txt_rid.Text = ds.Tables(0).Rows(0).Item("rid1") + 1
    End Sub

    Private Sub rad_male_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_male.CheckedChanged
        txt_sx.Text = "MALE"
    End Sub

    Private Sub rad_female_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_female.CheckedChanged
        txt_sx.Text = "FEMALE"
    End Sub

    Public Sub refreshMe()
        con.Close()

        Try
            con.Open()

            Dim mycmd1 As New OdbcCommand("select * from resident_tbl", con)
            Dim da1 As New OdbcDataAdapter(mycmd1)
            Dim ds1 As New System.Data.DataSet

            da1.Fill(ds1, "resident_tbl")

            dg_rlist.DataSource = ds1.Tables(0)
            dg_rlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dg_rlist.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
            dg_rlist.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
            dg_rlist.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub txt_lname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_lname.KeyDown
        If e.KeyCode = 13 Then
            If txt_lname.Text = "" Then
                MessageBox.Show("Fill in Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_lname.Focus()
            Else
                txt_fname.Focus()
            End If
        End If
    End Sub

    Private Sub txt_fname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_fname.KeyDown
        If e.KeyCode = 13 Then
            If txt_fname.Text = "" Then
                MessageBox.Show("Fill in First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_fname.Focus()
            Else
                txt_mname.Focus()
            End If
        End If
    End Sub

    Private Sub txt_mname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_mname.KeyDown
        If e.KeyCode = 13 Then
            If txt_mname.Text = "" Then
                MessageBox.Show("Fill in Middle Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_mname.Focus()
            Else
                cb_ext.Focus()
            End If
        End If
    End Sub

    Private Sub cb_ext_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_ext.KeyDown
        If e.KeyCode = 13 Then
            If cb_ext.Text = "" Then
                MessageBox.Show("Fill in Extention.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cb_ext.Focus()
            Else
                txt_age.Focus()
            End If
        End If
    End Sub

    Private Sub txt_age_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_age.KeyDown
        If e.KeyCode = 13 Then
            If txt_age.Text = "" Then
                MessageBox.Show("Fill in Age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_age.Focus()
            Else
                dtp_bday.Focus()
            End If
        End If
    End Sub

    Private Sub txt_pob_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pob.KeyDown
        If e.KeyCode = 13 Then
            If txt_pob.Text = "" Then
                MessageBox.Show("Fill in Place of Birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_pob.Focus()
            Else
                rad_male.Focus()
            End If
        End If
    End Sub

    Private Sub cb_civil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_civil.KeyDown
        If e.KeyCode = 13 Then
            If cb_civil.Text = "" Then
                MessageBox.Show("Fill in Civil Status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cb_civil.Focus()
            Else
                txt_citizen.Focus()
            End If
        End If
    End Sub

    Private Sub txt_hnum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_hnum.KeyDown
        If e.KeyCode = 13 Then
            If txt_hnum.Text = "" Then
                MessageBox.Show("Fill in House Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_hnum.Focus()
            Else
                cb_street.Focus()
            End If
        End If
    End Sub

    Private Sub txt_street_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = 13 Then
            If cb_street.Text = "" Then
                MessageBox.Show("Fill in Street.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cb_street.Focus()
            Else
                btn_save.Focus()
            End If
        End If
    End Sub

    Private Sub dg_rlist_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_rlist.CellContentClick
        Dim i As Integer
        i = dg_rlist.CurrentRow.Index
        txt_rid.Text = dg_rlist.Item(0, i).Value
        txt_lname.Text = dg_rlist.Item(1, i).Value
        txt_fname.Text = dg_rlist.Item(2, i).Value
        txt_mname.Text = dg_rlist.Item(3, i).Value
        cb_ext.Text = dg_rlist.Item(4, i).Value
        cb_ext.SelectedValue = dg_rlist.Item(4, i).Value
        txt_age.Text = dg_rlist.Item(5, i).Value
        dtp_bday.Text = dg_rlist.Item(6, i).Value
        txt_pob.Text = dg_rlist.Item(7, i).Value

        txt_sx.Text = dg_rlist.Item(8, i).Value
        cb_civil.Text = dg_rlist.Item(9, i).Value
        cb_civil.SelectedItem = dg_rlist.Item(9, i).Value

        txt_citizen.Text = dg_rlist.Item(10, i).Value
        txt_occupation.Text = dg_rlist.Item(11, i).Value
        txt_hnum.Text = dg_rlist.Item(12, i).Value
        cb_street.Text = dg_rlist.Item(13, i).Value
        cb_street.SelectedItem = dg_rlist.Item(13, i).Value


        txt_lname.Enabled = False
        txt_fname.Enabled = False
        txt_mname.Enabled = False
        cb_ext.Enabled = False
        txt_age.Enabled = False
        dtp_bday.Enabled = False
        txt_pob.Enabled = False
        rad_male.Enabled = False
        rad_female.Enabled = False
        cb_civil.Enabled = False
        txt_citizen.Enabled = False
        txt_occupation.Enabled = False
        txt_hnum.Enabled = False
        cb_street.Enabled = False

        btn_save.Enabled = False
        btn_edit.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = True
        btn_exit.Enabled = True
        btn_new.Enabled = True
        btn_print.Enabled = True

        If usertype = "SK KAGAWAD" Or usertype = "SK CHAIRMAN" Or usertype = "CAPTAIN" Then
            btn_save.Enabled = False
            btn_edit.Enabled = False
            btn_update.Enabled = False
            btn_delete.Enabled = False
            btn_print.Enabled = False
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
                Dim mycmd1 As New OdbcCommand("select * from resident_tbl where lname = '" & lname & "'", con)
                dr1 = mycmd1.ExecuteReader
                If dr1.HasRows Then
                    Dim mycmd2 As New OdbcCommand("select * from resident_tbl where lname = '" & lname & "'", con)
                    Dim da2 As New OdbcDataAdapter(mycmd2)
                    Dim ds2 As New System.Data.DataSet

                    da2.Fill(ds2, " resident_tbl")

                    dg_rlist.DataSource = ds2.Tables(0)
                    dg_rlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dg_rlist.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
                    dg_rlist.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
                    dg_rlist.Refresh()

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

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        txt_lname.Enabled = True
        txt_fname.Enabled = True
        txt_mname.Enabled = True
        cb_ext.Enabled = True
        txt_age.Enabled = True
        dtp_bday.Enabled = True
        txt_pob.Enabled = True
        rad_male.Enabled = True
        rad_female.Enabled = True
        cb_civil.Enabled = True
        txt_citizen.Enabled = True
        txt_occupation.Enabled = True
        txt_hnum.Enabled = True
        cb_street.Enabled = True

        btn_save.Enabled = False
        btn_update.Enabled = True
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_exit.Enabled = True

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim rid1 As String
        Dim hlname1 As String
        Dim hfname1 As String
        Dim hmname1 As String
        Dim hext1 As String
        Dim age1 As String
        Dim dob1 As Date
        Dim hpob1 As String
        Dim civil1 As String
        Dim hcitiz1 As String
        Dim hocc1 As String
        Dim hnum1 As String
        Dim hstreet1 As String
        Dim sx1 As String

        rid1 = txt_rid.Text
        hlname1 = txt_lname.Text.ToUpper.Trim
        hfname1 = txt_fname.Text.ToUpper.Trim
        hmname1 = txt_mname.Text.ToUpper.Trim
        hext1 = cb_ext.SelectedItem
        age1 = txt_age.Text
        dob1 = dtp_bday.Text
        hpob1 = txt_pob.Text.ToUpper.Trim
        civil1 = cb_civil.SelectedItem
        hcitiz1 = txt_citizen.Text.ToUpper.Trim
        hocc1 = txt_occupation.Text.ToUpper.Trim
        hnum1 = txt_hnum.Text
        hstreet1 = cb_street.SelectedItem
        sx1 = txt_sx.Text.ToUpper.Trim

        con.Close()

        Try
            con.Open()

            With mycmd
                .Connection = con
                .CommandText = "update resident_tbl set house_id = '" & rid1 & "', lname = '" & hlname1 & "', fname = '" & hfname1 & "', mname = '" & hmname1 & "', ext = '" & hext1 & "',age = '" & age1 & "',bday = '" & dob1 & "',pob = '" & hpob1 & "',sex = '" & sx1 & "',civilstat = '" & civil1 & "',citizen = '" & hcitiz1 & "',occup = '" & hocc1 & "',hnum = '" & hnum1 & "',street = '" & hstreet1 & "' where house_id = '" & rid1 & "' "
                .ExecuteNonQuery()

            End With

            MessageBox.Show("Record is updated!", "Update Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshMe()

            txt_rid.Clear()
            txt_lname.Clear()
            txt_fname.Clear()
            txt_mname.Clear()
            cb_ext.SelectedIndex = -1
            txt_pob.Clear()
            cb_civil.SelectedItem = -1
            txt_citizen.Clear()
            txt_occupation.Clear()
            txt_hnum.Clear()
            cb_street.SelectedItem = -1

            rad_male.Checked = False
            rad_female.Checked = False

            txt_lname.Enabled = False
            txt_fname.Enabled = False
            txt_mname.Enabled = False
            cb_ext.Enabled = False
            txt_age.Enabled = False
            dtp_bday.Enabled = False
            txt_pob.Enabled = False
            rad_male.Enabled = False
            rad_female.Enabled = False
            cb_civil.Enabled = False
            txt_citizen.Enabled = False
            txt_occupation.Enabled = False
            txt_hnum.Enabled = False
            cb_street.Enabled = False

            btn_save.Enabled = False
            btn_edit.Enabled = False
            btn_delete.Enabled = False
            btn_update.Enabled = False
            btn_print.Enabled = False
            btn_new.Enabled = True
            btn_exit.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()

        End Try

    End Sub

    Private Sub txt_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click
        txt_lname.Enabled = True
        txt_fname.Enabled = True
        txt_mname.Enabled = True
        cb_ext.Enabled = True
        txt_age.Enabled = True
        dtp_bday.Enabled = True
        txt_pob.Enabled = True
        rad_male.Enabled = True
        rad_female.Enabled = True
        cb_civil.Enabled = True
        txt_citizen.Enabled = True
        txt_citizen.Text = "FILIPINO"
        txt_occupation.Enabled = True
        txt_hnum.Enabled = True
        cb_street.Enabled = True

        btn_save.Enabled = True
        btn_edit.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
        btn_exit.Enabled = True


        txt_lname.Clear()
        txt_fname.Clear()
        txt_mname.Clear()
        cb_ext.SelectedIndex = -1
        txt_pob.Clear()
        cb_civil.SelectedItem = -1

        txt_hnum.Clear()
        cb_street.SelectedItem = -1

        rad_male.Checked = False
        rad_female.Checked = False

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        Dim id1 As String
        Dim result1 As New DialogResult

        id1 = txt_rid.Text

        con.Close()
        Try
            con.Open()

            result1 = MessageBox.Show("Are you sure you want to delete the record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result1 = System.Windows.Forms.DialogResult.Yes Then
                With mycmd
                    .Connection = con
                    .CommandText = "delete from resident_tbl where house_id= '" & id1 & "'"
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Record is deleted!", "Delete Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                refreshMe()

                txt_rid.Clear()
                txt_lname.Clear()
                txt_fname.Clear()
                txt_mname.Clear()
                cb_ext.SelectedIndex = -1
                txt_pob.Clear()
                cb_civil.SelectedItem = -1
                txt_citizen.Clear()
                txt_occupation.Clear()
                txt_hnum.Clear()
                cb_street.SelectedItem = -1

                rad_male.Checked = False
                rad_female.Checked = False

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        btn_new.Enabled = True
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_update.Enabled = False
        btn_exit.Enabled = True



    End Sub


    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = 13 Then
            If txt_search.Text = "" Then
                MessageBox.Show("Fill in Last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_age.Focus()
            Else
                btn_search.Focus()
            End If
        End If
    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click

        Dim res_rep As New CrystalReport1

        res_rep.SetParameterValue("lname", txt_lname.Text)
        res_rep.SetParameterValue("fname", txt_fname.Text)
        res_rep.SetParameterValue("mname", txt_mname.Text)
        res_rep.SetParameterValue("ext", cb_ext.SelectedItem)
        res_rep.SetParameterValue("age", txt_age.Text)
        res_rep.SetParameterValue("dob", dtp_bday.Text)
        res_rep.SetParameterValue("pob", txt_pob.Text)
        res_rep.SetParameterValue("sex", txt_sx.Text)
        res_rep.SetParameterValue("civil", cb_civil.SelectedItem)
        res_rep.SetParameterValue("citiz", txt_citizen.Text)
        res_rep.SetParameterValue("occup", txt_occupation.Text)
        res_rep.SetParameterValue("hnum", txt_hnum.Text)
        res_rep.SetParameterValue("street", cb_street.Text)

        frm_printIndivRes.CrystalReportViewer1.ReportSource = res_rep


        frm_printIndivRes.ShowDialog()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_selectBC.Click
        With frm_brgyClearance

            Dim i As Integer
            i = dg_rlist.CurrentRow.Index

            .txt_lname.Text = dg_rlist.Item(1, i).Value
            .txt_fname.Text = dg_rlist.Item(2, i).Value
            .txt_age.Text = dg_rlist.Item(5, i).Value
            .txt_civil.Text = dg_rlist.Item(9, i).Value
            .txt_hnum.Text = dg_rlist.Item(12, i).Value
            .txt_street.Text = dg_rlist.Item(13, i).Value
        End With

        Me.Close()
    End Sub

    Private Sub btn_selectIND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_selectIND.Click
        With frm_brgyIndigency
            Dim i As Integer
            i = dg_rlist.CurrentRow.Index

            .txt_lname.Text = dg_rlist.Item(1, i).Value
            .txt_fname.Text = dg_rlist.Item(2, i).Value
            .txt_age.Text = dg_rlist.Item(5, i).Value
            .txt_civil.Text = dg_rlist.Item(9, i).Value
            .txt_hnum.Text = dg_rlist.Item(12, i).Value
            .txt_street.Text = dg_rlist.Item(13, i).Value
        End With
        Me.Close()

    End Sub

    Private Sub txt_citizen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_citizen.KeyDown
        If e.KeyCode = 13 Then
            If txt_citizen.Text = "" Then
                MessageBox.Show("Fill in Citizenship.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_citizen.Focus()
            Else
                txt_occupation.Focus()
            End If
        End If
    End Sub

    Private Sub txt_occupation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_occupation.KeyDown
        If e.KeyCode = 13 Then
            If txt_occupation.Text = "" Then
                MessageBox.Show("Fill in Occupation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_occupation.Focus()
            Else
                txt_hnum.Focus()
            End If
        End If
    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        con.Close()

        Try
            con.Open()

            Dim mycmd1 As New OdbcCommand("select * from resident_tbl", con)
            Dim da1 As New OdbcDataAdapter(mycmd1)
            Dim ds1 As New System.Data.DataSet

            da1.Fill(ds1, "resident_tbl")

            dg_rlist.DataSource = ds1.Tables(0)
            dg_rlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dg_rlist.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
            dg_rlist.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
            dg_rlist.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btn_selectcomp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_selectcomp.Click
        With frm_complain
            Dim i As Integer
            i = dg_rlist.CurrentRow.Index

            .txt_lname.Text = dg_rlist.Item(1, i).Value
            .txt_fname.Text = dg_rlist.Item(2, i).Value
        End With
        Me.Close()
    End Sub
End Class