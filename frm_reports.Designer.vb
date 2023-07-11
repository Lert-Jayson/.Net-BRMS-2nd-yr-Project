<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_reports))
        Me.btn_res = New System.Windows.Forms.Button
        Me.btn_bclear = New System.Windows.Forms.Button
        Me.btn_bind = New System.Windows.Forms.Button
        Me.btn_comp = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dg_reports = New System.Windows.Forms.DataGridView
        Me.btn_printRes = New System.Windows.Forms.Button
        Me.btn_exit = New System.Windows.Forms.Button
        Me.btn_printbclear = New System.Windows.Forms.Button
        Me.btn_printnind = New System.Windows.Forms.Button
        Me.btn_printcomp = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cb_rlistgender = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lbl_title = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_reports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_res
        '
        Me.btn_res.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_res.Location = New System.Drawing.Point(6, 33)
        Me.btn_res.Name = "btn_res"
        Me.btn_res.Size = New System.Drawing.Size(227, 38)
        Me.btn_res.TabIndex = 1
        Me.btn_res.Text = "List of Residents"
        Me.btn_res.UseVisualStyleBackColor = True
        '
        'btn_bclear
        '
        Me.btn_bclear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bclear.Location = New System.Drawing.Point(6, 86)
        Me.btn_bclear.Name = "btn_bclear"
        Me.btn_bclear.Size = New System.Drawing.Size(227, 38)
        Me.btn_bclear.TabIndex = 2
        Me.btn_bclear.Text = "List of Barangay Clearance"
        Me.btn_bclear.UseVisualStyleBackColor = True
        '
        'btn_bind
        '
        Me.btn_bind.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bind.Location = New System.Drawing.Point(6, 143)
        Me.btn_bind.Name = "btn_bind"
        Me.btn_bind.Size = New System.Drawing.Size(227, 38)
        Me.btn_bind.TabIndex = 3
        Me.btn_bind.Text = "List of Barangay Indigency"
        Me.btn_bind.UseVisualStyleBackColor = True
        '
        'btn_comp
        '
        Me.btn_comp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_comp.Location = New System.Drawing.Point(6, 202)
        Me.btn_comp.Name = "btn_comp"
        Me.btn_comp.Size = New System.Drawing.Size(227, 38)
        Me.btn_comp.TabIndex = 4
        Me.btn_comp.Text = "List of Complaints"
        Me.btn_comp.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_bind)
        Me.GroupBox1.Controls.Add(Me.btn_comp)
        Me.GroupBox1.Controls.Add(Me.btn_res)
        Me.GroupBox1.Controls.Add(Me.btn_bclear)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 264)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List"
        '
        'dg_reports
        '
        Me.dg_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_reports.Location = New System.Drawing.Point(322, 159)
        Me.dg_reports.Margin = New System.Windows.Forms.Padding(2)
        Me.dg_reports.Name = "dg_reports"
        Me.dg_reports.Size = New System.Drawing.Size(709, 413)
        Me.dg_reports.TabIndex = 6
        '
        'btn_printRes
        '
        Me.btn_printRes.Location = New System.Drawing.Point(322, 72)
        Me.btn_printRes.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_printRes.Name = "btn_printRes"
        Me.btn_printRes.Size = New System.Drawing.Size(96, 37)
        Me.btn_printRes.TabIndex = 7
        Me.btn_printRes.Text = "Print"
        Me.btn_printRes.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(863, 0)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(58, 27)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_printbclear
        '
        Me.btn_printbclear.Location = New System.Drawing.Point(424, 72)
        Me.btn_printbclear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_printbclear.Name = "btn_printbclear"
        Me.btn_printbclear.Size = New System.Drawing.Size(96, 37)
        Me.btn_printbclear.TabIndex = 9
        Me.btn_printbclear.Text = "Print"
        Me.btn_printbclear.UseVisualStyleBackColor = True
        '
        'btn_printnind
        '
        Me.btn_printnind.Location = New System.Drawing.Point(525, 72)
        Me.btn_printnind.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_printnind.Name = "btn_printnind"
        Me.btn_printnind.Size = New System.Drawing.Size(96, 37)
        Me.btn_printnind.TabIndex = 10
        Me.btn_printnind.Text = "Print"
        Me.btn_printnind.UseVisualStyleBackColor = True
        '
        'btn_printcomp
        '
        Me.btn_printcomp.Location = New System.Drawing.Point(626, 72)
        Me.btn_printcomp.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_printcomp.Name = "btn_printcomp"
        Me.btn_printcomp.Size = New System.Drawing.Size(96, 37)
        Me.btn_printcomp.TabIndex = 11
        Me.btn_printcomp.Text = "Print"
        Me.btn_printcomp.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1052, 68)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(408, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reports"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 586)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1052, 54)
        Me.Panel2.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_rlistgender)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(31, 343)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 229)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Demographics"
        '
        'cb_rlistgender
        '
        Me.cb_rlistgender.FormattingEnabled = True
        Me.cb_rlistgender.Location = New System.Drawing.Point(59, 187)
        Me.cb_rlistgender.Name = "cb_rlistgender"
        Me.cb_rlistgender.Size = New System.Drawing.Size(121, 27)
        Me.cb_rlistgender.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "List of Residents by gender"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(6, 33)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(227, 38)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "List of Residents by street"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(6, 86)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(227, 38)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "List of Residents with occupation"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.lbl_title)
        Me.Panel3.Location = New System.Drawing.Point(322, 114)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(709, 51)
        Me.Panel3.TabIndex = 15
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(108, 12)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(0, 31)
        Me.lbl_title.TabIndex = 0
        '
        'frm_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_printcomp)
        Me.Controls.Add(Me.btn_printnind)
        Me.Controls.Add(Me.btn_printbclear)
        Me.Controls.Add(Me.btn_printRes)
        Me.Controls.Add(Me.dg_reports)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg_reports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_res As System.Windows.Forms.Button
    Friend WithEvents btn_bclear As System.Windows.Forms.Button
    Friend WithEvents btn_bind As System.Windows.Forms.Button
    Friend WithEvents btn_comp As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_reports As System.Windows.Forms.DataGridView
    Friend WithEvents btn_printRes As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_printbclear As System.Windows.Forms.Button
    Friend WithEvents btn_printnind As System.Windows.Forms.Button
    Friend WithEvents btn_printcomp As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cb_rlistgender As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_title As System.Windows.Forms.Label
End Class
