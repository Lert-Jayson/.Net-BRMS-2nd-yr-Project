<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frrm_printbclearance
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
        Me.cviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(1037, 24)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 0
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'cviewer
        '
        Me.cviewer.ActiveViewIndex = 0
        Me.cviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cviewer.Location = New System.Drawing.Point(12, 69)
        Me.cviewer.Name = "cviewer"
        Me.cviewer.ReportSource = "C:\Users\user\Documents\Visual Studio 2008\Projects\BRMS_PROJECT\BRMS_PROJECT\cle" & _
            "arance_report.rpt"
        Me.cviewer.Size = New System.Drawing.Size(1112, 648)
        Me.cviewer.TabIndex = 1
        '
        'frrm_printbclearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.cviewer)
        Me.Controls.Add(Me.btn_exit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frrm_printbclearance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frrm_printbclearance"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents cviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
