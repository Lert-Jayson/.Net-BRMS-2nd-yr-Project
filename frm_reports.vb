Imports System.Windows.Forms
Imports System.Data.Odbc
Imports System.Data.DataSet
Imports System.Data.DataTable

Public Class frm_reports
    Dim mycmd As New OdbcCommand

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectMe()

        btn_printRes.Hide()
        btn_printbclear.Hide()
        btn_printnind.Hide()
        btn_printcomp.Hide()


        cb_rlistgender.Items.Add("MALE")
        cb_rlistgender.Items.Add("FEMALE")

    End Sub

    Private Sub btn_res_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_res.Click

        Dim mycmd As New OdbcCommand("select * from resident_tbl", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New System.Data.DataSet

        da.Fill(ds, "resident_tbl")

        dg_reports.DataSource = ds.Tables(0)
        dg_reports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg_reports.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
        dg_reports.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
        dg_reports.Refresh()

        btn_printRes.Show()
        btn_printbclear.Hide()
        btn_printnind.Hide()
        btn_printcomp.Hide()


        lbl_title.Text = "List of Residents"

    End Sub

    Private Sub btn_bclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bclear.Click

        Dim mycmd1 As New OdbcCommand("select * from clr_tbl", con)
        Dim da1 As New OdbcDataAdapter(mycmd1)
        Dim ds1 As New System.Data.DataSet

        da1.Fill(ds1, "clr_tbl")

        dg_reports.DataSource = ds1.Tables(0)
        dg_reports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg_reports.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
        dg_reports.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
        dg_reports.Refresh()

        btn_printRes.Hide()
        btn_printbclear.Show()
        btn_printnind.Hide()
        btn_printcomp.Hide()

        lbl_title.Text = "List of Barangay Clearances"
    End Sub

    Private Sub btn_bind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bind.Click
        Dim mycmd2 As New OdbcCommand("select * from ind_tbl", con)
        Dim da2 As New OdbcDataAdapter(mycmd2)
        Dim ds2 As New System.Data.DataSet

        da2.Fill(ds2, "ind_tbl")

        dg_reports.DataSource = ds2.Tables(0)
        dg_reports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg_reports.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
        dg_reports.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
        dg_reports.Refresh()

        btn_printRes.Hide()
        btn_printbclear.Hide()
        btn_printnind.Show()
        btn_printcomp.Hide()

        lbl_title.Text = "List of Barangay Indigencies"
    End Sub

    Private Sub btn_comp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_comp.Click

        Dim mycmd3 As New OdbcCommand("select * from comp_tbl", con)
        Dim da3 As New OdbcDataAdapter(mycmd3)
        Dim ds3 As New System.Data.DataSet

        da3.Fill(ds3, "comp_tbl")

        dg_reports.DataSource = ds3.Tables(0)
        dg_reports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg_reports.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
        dg_reports.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
        dg_reports.Refresh()

        btn_printRes.Hide()
        btn_printbclear.Hide()
        btn_printnind.Hide()
        btn_printcomp.Show()

        lbl_title.Text = "List of Complaints"
    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_printRes.Click

        Dim rlist_rpt As New residentlist_report
        Dim da As New OdbcDataAdapter
        Dim ds As New residentDS



        con.Close()

        Try
            con.Open()
            rlist_rpt.Load(System.Windows.Forms.Application.StartupPath & "\\residentlist_report.rpt")
            da = New OdbcDataAdapter("select lname, fname, age, bday, sex, civilstat , citizen , occup, hnum, street from resident_tbl", con)
            da.Fill(ds, "Resident")
            rlist_rpt.SetDataSource(ds)
            frm_printresidentlist.CrystalReportViewer1.ReportSource = rlist_rpt
            frm_printresidentlist.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_printbclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_printbclear.Click
        Dim clrlist_rpt As New clearancelist_report
        Dim da1 As New OdbcDataAdapter
        Dim ds1 As New residentDS



        con.Close()

        Try
            con.Open()
            clrlist_rpt.Load(System.Windows.Forms.Application.StartupPath & "\\clearancelist_report.rpt")
            da1 = New OdbcDataAdapter("select lname, fname, age, civilstat , hnum, street, purpose, dategiven, givenby from clr_tbl", con)
            da1.Fill(ds1, "Clearance")
            clrlist_rpt.SetDataSource(ds1)
            frm_printlistbclearance.crysview_clrlist.ReportSource = clrlist_rpt
            frm_printlistbclearance.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim mycmd As New OdbcCommand("select street, count(house_id) as 'No. of Residents' from resident_tbl group by street", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New System.Data.DataSet

        da.Fill(ds, "resident_tbl")

        dg_reports.DataSource = ds.Tables(0)
        dg_reports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg_reports.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
        dg_reports.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
        dg_reports.Refresh()

        lbl_title.Text = "List of Residents by Street"

        btn_printbclear.Hide()
        btn_printcomp.Hide()
        btn_printnind.Hide()
        btn_printRes.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim mycmd As New OdbcCommand("select  street, count(house_id) as 'No. of Residents' from resident_tbl where occup <> 'N/A' group by street", con)
        Dim da1 As New OdbcDataAdapter(mycmd)
        Dim ds1 As New System.Data.DataSet

        da1.Fill(ds1, "resident_tbl")

        dg_reports.DataSource = ds1.Tables(0)
        dg_reports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg_reports.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
        dg_reports.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
        dg_reports.Refresh()

        lbl_title.Text = "List of Residents with Occupation"

        btn_printbclear.Hide()
        btn_printcomp.Hide()
        btn_printnind.Hide()
        btn_printRes.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mycmd As New OdbcCommand("select  street, count(house_id) as 'No. of Residents' from resident_tbl where sex = '" & cb_rlistgender.SelectedItem & "' group by street", con)
        Dim da1 As New OdbcDataAdapter(mycmd)
        Dim ds1 As New System.Data.DataSet

        da1.Fill(ds1, "resident_tbl")

        dg_reports.DataSource = ds1.Tables(0)
        dg_reports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg_reports.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
        dg_reports.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
        dg_reports.Refresh()

        lbl_title.Text = "List of Residents by Gender"

        btn_printbclear.Hide()
        btn_printcomp.Hide()
        btn_printnind.Hide()
        btn_printRes.Hide()

    End Sub

    Private Sub btn_printnind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_printnind.Click
        Dim indlist_rpt As New indigencylist_report
        Dim da2 As New OdbcDataAdapter
        Dim ds2 As New bindigencyDS


        con.Close()

        Try
            con.Open()
            indlist_rpt.Load(System.Windows.Forms.Application.StartupPath & "\\indigency_report.rpt")
            da2 = New OdbcDataAdapter("select lname, fname, age, civilstat , hnum, street, purpose, dategiven, givenby from ind_tbl", con)
            da2.Fill(ds2, "Indigency")
            indlist_rpt.SetDataSource(ds2)
            frm_printlistbindigency.crysview_indlist.ReportSource = indlist_rpt
            frm_printlistbindigency.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub btn_printcomp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_printcomp.Click
        Dim complist_rpt As New complist_report
        Dim da3 As New OdbcDataAdapter
        Dim ds3 As New complistDS


        con.Close()

        Try
            con.Open()
            complist_rpt.Load(System.Windows.Forms.Application.StartupPath & "\\complaintlist_report.rpt")
            da3 = New OdbcDataAdapter("select complainant, lname, fname, dof, tof , nature, remarks, details, encoder from comp_tbl", con)
            da3.Fill(ds3, "Complaints")
            complist_rpt.SetDataSource(ds3)
            frm_printcomplaintlist.crysview_complist.ReportSource = complist_rpt
            frm_printcomplaintlist.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
End Class