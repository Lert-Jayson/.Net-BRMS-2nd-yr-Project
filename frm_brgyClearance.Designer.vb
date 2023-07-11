<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_brgyClearance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_brgyClearance))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_civil = New System.Windows.Forms.TextBox
        Me.txt_street = New System.Windows.Forms.TextBox
        Me.txt_hnum = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_givenby = New System.Windows.Forms.TextBox
        Me.txt_cid = New System.Windows.Forms.TextBox
        Me.btn_search = New System.Windows.Forms.Button
        Me.txt_capt = New System.Windows.Forms.TextBox
        Me.txt_fname = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtp_dg = New System.Windows.Forms.DateTimePicker
        Me.txt_lname = New System.Windows.Forms.TextBox
        Me.txt_purpose = New System.Windows.Forms.TextBox
        Me.txt_age = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_save = New System.Windows.Forms.Button
        Me.dg_bc = New System.Windows.Forms.DataGridView
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_search = New System.Windows.Forms.TextBox
        Me.btn_srch = New System.Windows.Forms.Button
        Me.btn_print = New System.Windows.Forms.Button
        Me.btn_refresh = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_bc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1034, 124)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(295, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List of Barangay Clearance"
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(947, 12)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 39)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_civil)
        Me.GroupBox2.Controls.Add(Me.txt_street)
        Me.GroupBox2.Controls.Add(Me.txt_hnum)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_givenby)
        Me.GroupBox2.Controls.Add(Me.txt_cid)
        Me.GroupBox2.Controls.Add(Me.btn_search)
        Me.GroupBox2.Controls.Add(Me.txt_capt)
        Me.GroupBox2.Controls.Add(Me.txt_fname)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dtp_dg)
        Me.GroupBox2.Controls.Add(Me.txt_lname)
        Me.GroupBox2.Controls.Add(Me.txt_purpose)
        Me.GroupBox2.Controls.Add(Me.txt_age)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 407)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'txt_civil
        '
        Me.txt_civil.Enabled = False
        Me.txt_civil.Location = New System.Drawing.Point(152, 149)
        Me.txt_civil.Name = "txt_civil"
        Me.txt_civil.Size = New System.Drawing.Size(234, 20)
        Me.txt_civil.TabIndex = 16
        '
        'txt_street
        '
        Me.txt_street.Enabled = False
        Me.txt_street.Location = New System.Drawing.Point(152, 224)
        Me.txt_street.Name = "txt_street"
        Me.txt_street.Size = New System.Drawing.Size(234, 20)
        Me.txt_street.TabIndex = 15
        '
        'txt_hnum
        '
        Me.txt_hnum.Enabled = False
        Me.txt_hnum.Location = New System.Drawing.Point(152, 188)
        Me.txt_hnum.Name = "txt_hnum"
        Me.txt_hnum.Size = New System.Drawing.Size(234, 20)
        Me.txt_hnum.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Street"
        '
        'txt_givenby
        '
        Me.txt_givenby.Enabled = False
        Me.txt_givenby.Location = New System.Drawing.Point(152, 335)
        Me.txt_givenby.Name = "txt_givenby"
        Me.txt_givenby.Size = New System.Drawing.Size(234, 20)
        Me.txt_givenby.TabIndex = 12
        '
        'txt_cid
        '
        Me.txt_cid.Enabled = False
        Me.txt_cid.Location = New System.Drawing.Point(152, 14)
        Me.txt_cid.Name = "txt_cid"
        Me.txt_cid.Size = New System.Drawing.Size(47, 20)
        Me.txt_cid.TabIndex = 10
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(392, 39)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(63, 20)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'txt_capt
        '
        Me.txt_capt.Enabled = False
        Me.txt_capt.Location = New System.Drawing.Point(152, 370)
        Me.txt_capt.Name = "txt_capt"
        Me.txt_capt.Size = New System.Drawing.Size(234, 20)
        Me.txt_capt.TabIndex = 7
        '
        'txt_fname
        '
        Me.txt_fname.Enabled = False
        Me.txt_fname.Location = New System.Drawing.Point(152, 75)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(234, 20)
        Me.txt_fname.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Purpose:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Last Name:"
        '
        'dtp_dg
        '
        Me.dtp_dg.CustomFormat = "yyyy/MM/dd"
        Me.dtp_dg.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_dg.Location = New System.Drawing.Point(152, 300)
        Me.dtp_dg.Name = "dtp_dg"
        Me.dtp_dg.Size = New System.Drawing.Size(200, 20)
        Me.dtp_dg.TabIndex = 3
        '
        'txt_lname
        '
        Me.txt_lname.Enabled = False
        Me.txt_lname.Location = New System.Drawing.Point(152, 40)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(234, 20)
        Me.txt_lname.TabIndex = 1
        '
        'txt_purpose
        '
        Me.txt_purpose.Location = New System.Drawing.Point(152, 265)
        Me.txt_purpose.Name = "txt_purpose"
        Me.txt_purpose.Size = New System.Drawing.Size(234, 20)
        Me.txt_purpose.TabIndex = 1
        '
        'txt_age
        '
        Me.txt_age.Enabled = False
        Me.txt_age.Location = New System.Drawing.Point(152, 110)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(78, 20)
        Me.txt_age.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Brgy. Captain:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Given by:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Date Given:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "House Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Civil Status:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name:"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(142, 91)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(81, 47)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'dg_bc
        '
        Me.dg_bc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_bc.Location = New System.Drawing.Point(483, 219)
        Me.dg_bc.Name = "dg_bc"
        Me.dg_bc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_bc.Size = New System.Drawing.Size(541, 328)
        Me.dg_bc.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(649, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "(Enter the Last name to search)"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(568, 174)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(353, 20)
        Me.txt_search.TabIndex = 20
        '
        'btn_srch
        '
        Me.btn_srch.Location = New System.Drawing.Point(927, 160)
        Me.btn_srch.Name = "btn_srch"
        Me.btn_srch.Size = New System.Drawing.Size(95, 47)
        Me.btn_srch.TabIndex = 19
        Me.btn_srch.Text = "Search"
        Me.btn_srch.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(280, 91)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(81, 47)
        Me.btn_print.TabIndex = 22
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(487, 168)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(75, 39)
        Me.btn_refresh.TabIndex = 26
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'frm_brgyClearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_srch)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.dg_bc)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_brgyClearance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dg_bc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_givenby As System.Windows.Forms.TextBox
    Friend WithEvents txt_cid As System.Windows.Forms.TextBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents txt_capt As System.Windows.Forms.TextBox
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtp_dg As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents txt_purpose As System.Windows.Forms.TextBox
    Friend WithEvents txt_age As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents dg_bc As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents btn_srch As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents txt_street As System.Windows.Forms.TextBox
    Friend WithEvents txt_hnum As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_civil As System.Windows.Forms.TextBox
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
End Class
