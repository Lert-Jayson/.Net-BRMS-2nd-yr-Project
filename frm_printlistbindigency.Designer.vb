<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_printlistbindigency
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_exit = New System.Windows.Forms.Button
        Me.crysview_indlist = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(1033, 12)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'crysview_indlist
        '
        Me.crysview_indlist.ActiveViewIndex = 0
        Me.crysview_indlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crysview_indlist.Location = New System.Drawing.Point(4, 41)
        Me.crysview_indlist.Name = "crysview_indlist"
        Me.crysview_indlist.ReportSource = "C:\Users\user\Documents\Visual Studio 2008\Projects\BRMS_PROJECT\BRMS_PROJECT\ind" & _
            "igencylist_report.rpt"
        Me.crysview_indlist.Size = New System.Drawing.Size(1112, 619)
        Me.crysview_indlist.TabIndex = 6
        '
        'frm_printlistbindigency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 690)
        Me.ControlBox = False
        Me.Controls.Add(Me.crysview_indlist)
        Me.Controls.Add(Me.btn_exit)
        Me.Name = "frm_printlistbindigency"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents crysview_indlist As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
