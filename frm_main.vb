Public Class frm_main

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_date.Text = DateTime.Now.ToLongDateString
        lbl_user.Text = "Hello , " & username1.ToUpper.Trim
        lbl_posit.Text = usertype.ToUpper.Trim

        If usertype = "SK KAGAWAD" Or usertype = "SK CHAIRMAN" Or usertype = "CAPTAIN" Then
            ManageUserToolStripMenuItem.Enabled = False

        End If

    End Sub

    Private Sub ManageUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUserToolStripMenuItem.Click
        frm_acclist.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim hlist As New frm_Residents
        hlist.Show()
    End Sub



    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim olist As New frm_brgyOfficials
        olist.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clearance.Click
        frm_brgyClearance.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frm_brgyIndigency.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_time.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub


    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        frm_complain.Show()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        frm_reports.Show()
    End Sub

    Private Sub btn_street_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_street.Click
        frm_street.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        End
    End Sub
End Class