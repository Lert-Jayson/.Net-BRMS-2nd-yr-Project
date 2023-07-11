<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_printlistbclearance
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
        Me.crysview_clrlist = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btn_exit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'crysview_clrlist
        '
        Me.crysview_clrlist.ActiveViewIndex = 0
        Me.crysview_clrlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crysview_clrlist.Location = New System.Drawing.Point(12, 49)
        Me.crysview_clrlist.Name = "crysview_clrlist"
        Me.crysview_clrlist.ReportSource = "C:\Users\user\Documents\Visual Studio 2008\Projects\BRMS_PROJECT\BRMS_PROJECT\cle" & _
            "arancelist_report.rpt"
        Me.crysview_clrlist.Size = New System.Drawing.Size(1112, 630)
        Me.crysview_clrlist.TabIndex = 3
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(1049, 12)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 4
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frm_printlistbclearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.crysview_clrlist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_printlistbclearance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crysview_clrlist As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_exit As System.Windows.Forms.Button
End Class
