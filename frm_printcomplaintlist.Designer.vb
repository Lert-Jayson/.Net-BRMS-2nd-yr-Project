<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_printcomplaintlist
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
        Me.crysview_complist = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(1029, 28)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'crysview_complist
        '
        Me.crysview_complist.ActiveViewIndex = 0
        Me.crysview_complist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crysview_complist.Location = New System.Drawing.Point(12, 80)
        Me.crysview_complist.Name = "crysview_complist"
        Me.crysview_complist.ReportSource = "C:\Users\user\Documents\Visual Studio 2008\Projects\BRMS_PROJECT\BRMS_PROJECT\com" & _
            "plist_report.rpt"
        Me.crysview_complist.Size = New System.Drawing.Size(1082, 536)
        Me.crysview_complist.TabIndex = 3
        '
        'frm_printcomplaintlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 690)
        Me.ControlBox = False
        Me.Controls.Add(Me.crysview_complist)
        Me.Controls.Add(Me.btn_exit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_printcomplaintlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_printcomplaintlist"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents crysview_complist As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
