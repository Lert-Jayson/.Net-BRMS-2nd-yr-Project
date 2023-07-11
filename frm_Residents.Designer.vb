<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Residents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Residents))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_refresh = New System.Windows.Forms.Button
        Me.btn_selectIND = New System.Windows.Forms.Button
        Me.btn_selectBC = New System.Windows.Forms.Button
        Me.btn_exit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cb_street = New System.Windows.Forms.ComboBox
        Me.txt_sx = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txt_rid = New System.Windows.Forms.TextBox
        Me.txt_hnum = New System.Windows.Forms.TextBox
        Me.txt_occupation = New System.Windows.Forms.TextBox
        Me.txt_citizen = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.cb_civil = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.rad_female = New System.Windows.Forms.RadioButton
        Me.rad_male = New System.Windows.Forms.RadioButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_age = New System.Windows.Forms.TextBox
        Me.txt_pob = New System.Windows.Forms.TextBox
        Me.dtp_bday = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cb_ext = New System.Windows.Forms.ComboBox
        Me.txt_mname = New System.Windows.Forms.TextBox
        Me.txt_fname = New System.Windows.Forms.TextBox
        Me.txt_lname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.dg_rlist = New System.Windows.Forms.DataGridView
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_print = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.txt_search = New System.Windows.Forms.TextBox
        Me.btn_search = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_new = New System.Windows.Forms.Button
        Me.btn_selectcomp = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_rlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btn_selectcomp)
        Me.Panel1.Controls.Add(Me.btn_refresh)
        Me.Panel1.Controls.Add(Me.btn_selectIND)
        Me.Panel1.Controls.Add(Me.btn_selectBC)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 117)
        Me.Panel1.TabIndex = 0
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(1049, 75)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(75, 39)
        Me.btn_refresh.TabIndex = 27
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_selectIND
        '
        Me.btn_selectIND.Location = New System.Drawing.Point(889, 79)
        Me.btn_selectIND.Name = "btn_selectIND"
        Me.btn_selectIND.Size = New System.Drawing.Size(124, 35)
        Me.btn_selectIND.TabIndex = 14
        Me.btn_selectIND.Text = "Use Selected"
        Me.btn_selectIND.UseVisualStyleBackColor = True
        '
        'btn_selectBC
        '
        Me.btn_selectBC.Location = New System.Drawing.Point(739, 79)
        Me.btn_selectBC.Name = "btn_selectBC"
        Me.btn_selectBC.Size = New System.Drawing.Size(124, 35)
        Me.btn_selectBC.TabIndex = 13
        Me.btn_selectBC.Text = "Use Selected"
        Me.btn_selectBC.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(1059, 13)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 38)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(498, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Residents"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_street)
        Me.GroupBox1.Controls.Add(Me.txt_sx)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txt_rid)
        Me.GroupBox1.Controls.Add(Me.txt_hnum)
        Me.GroupBox1.Controls.Add(Me.txt_occupation)
        Me.GroupBox1.Controls.Add(Me.txt_citizen)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cb_civil)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rad_female)
        Me.GroupBox1.Controls.Add(Me.rad_male)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_age)
        Me.GroupBox1.Controls.Add(Me.txt_pob)
        Me.GroupBox1.Controls.Add(Me.dtp_bday)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cb_ext)
        Me.GroupBox1.Controls.Add(Me.txt_mname)
        Me.GroupBox1.Controls.Add(Me.txt_fname)
        Me.GroupBox1.Controls.Add(Me.txt_lname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(514, 529)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resident Information"
        '
        'cb_street
        '
        Me.cb_street.FormattingEnabled = True
        Me.cb_street.Location = New System.Drawing.Point(165, 472)
        Me.cb_street.Name = "cb_street"
        Me.cb_street.Size = New System.Drawing.Size(262, 21)
        Me.cb_street.TabIndex = 136
        '
        'txt_sx
        '
        Me.txt_sx.Enabled = False
        Me.txt_sx.Location = New System.Drawing.Point(112, 301)
        Me.txt_sx.Name = "txt_sx"
        Me.txt_sx.Size = New System.Drawing.Size(48, 20)
        Me.txt_sx.TabIndex = 135
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(26, 104)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 134
        Me.Label21.Text = "Resident ID"
        '
        'txt_rid
        '
        Me.txt_rid.Enabled = False
        Me.txt_rid.Location = New System.Drawing.Point(116, 101)
        Me.txt_rid.Name = "txt_rid"
        Me.txt_rid.Size = New System.Drawing.Size(44, 20)
        Me.txt_rid.TabIndex = 133
        '
        'txt_hnum
        '
        Me.txt_hnum.Location = New System.Drawing.Point(57, 473)
        Me.txt_hnum.Name = "txt_hnum"
        Me.txt_hnum.Size = New System.Drawing.Size(75, 20)
        Me.txt_hnum.TabIndex = 131
        '
        'txt_occupation
        '
        Me.txt_occupation.Location = New System.Drawing.Point(219, 410)
        Me.txt_occupation.Name = "txt_occupation"
        Me.txt_occupation.Size = New System.Drawing.Size(283, 20)
        Me.txt_occupation.TabIndex = 130
        Me.txt_occupation.Text = "N/A"
        '
        'txt_citizen
        '
        Me.txt_citizen.Location = New System.Drawing.Point(109, 370)
        Me.txt_citizen.Name = "txt_citizen"
        Me.txt_citizen.Size = New System.Drawing.Size(344, 20)
        Me.txt_citizen.TabIndex = 129
        Me.txt_citizen.Text = "FILIPINO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 410)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(171, 15)
        Me.Label14.TabIndex = 128
        Me.Label14.Text = "PROFESSION/OCCUPATION :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 370)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 16)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Citizenship :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(249, 496)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "Street "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(54, 496)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 16)
        Me.Label12.TabIndex = 125
        Me.Label12.Text = "House No. :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(14, 442)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 15)
        Me.Label20.TabIndex = 124
        Me.Label20.Text = "RESIDENCE ADDRESS :"
        '
        'cb_civil
        '
        Me.cb_civil.FormattingEnabled = True
        Me.cb_civil.Location = New System.Drawing.Point(112, 328)
        Me.cb_civil.Name = "cb_civil"
        Me.cb_civil.Size = New System.Drawing.Size(191, 21)
        Me.cb_civil.TabIndex = 123
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Civil Status : "
        '
        'rad_female
        '
        Me.rad_female.AutoSize = True
        Me.rad_female.Location = New System.Drawing.Point(236, 304)
        Me.rad_female.Name = "rad_female"
        Me.rad_female.Size = New System.Drawing.Size(59, 17)
        Me.rad_female.TabIndex = 121
        Me.rad_female.TabStop = True
        Me.rad_female.Text = "Female"
        Me.rad_female.UseVisualStyleBackColor = True
        '
        'rad_male
        '
        Me.rad_male.AutoSize = True
        Me.rad_male.Location = New System.Drawing.Point(182, 304)
        Me.rad_male.Name = "rad_male"
        Me.rad_male.Size = New System.Drawing.Size(48, 17)
        Me.rad_male.TabIndex = 120
        Me.rad_male.TabStop = True
        Me.rad_male.Text = "Male"
        Me.rad_male.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 302)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 16)
        Me.Label11.TabIndex = 119
        Me.Label11.Text = "Gender :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Age :"
        '
        'txt_age
        '
        Me.txt_age.Location = New System.Drawing.Point(112, 220)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(78, 20)
        Me.txt_age.TabIndex = 117
        '
        'txt_pob
        '
        Me.txt_pob.Location = New System.Drawing.Point(112, 275)
        Me.txt_pob.Name = "txt_pob"
        Me.txt_pob.Size = New System.Drawing.Size(344, 20)
        Me.txt_pob.TabIndex = 116
        '
        'dtp_bday
        '
        Me.dtp_bday.CustomFormat = "yyyy/MM/dd"
        Me.dtp_bday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_bday.Location = New System.Drawing.Point(112, 249)
        Me.dtp_bday.MaxDate = New Date(2109, 12, 25, 23, 59, 59, 0)
        Me.dtp_bday.MinDate = New Date(1909, 12, 25, 23, 59, 59, 0)
        Me.dtp_bday.Name = "dtp_bday"
        Me.dtp_bday.Size = New System.Drawing.Size(191, 20)
        Me.dtp_bday.TabIndex = 115
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 16)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Place of Birth :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Date of Birth :"
        '
        'cb_ext
        '
        Me.cb_ext.FormattingEnabled = True
        Me.cb_ext.Location = New System.Drawing.Point(292, 184)
        Me.cb_ext.Name = "cb_ext"
        Me.cb_ext.Size = New System.Drawing.Size(58, 21)
        Me.cb_ext.TabIndex = 112
        '
        'txt_mname
        '
        Me.txt_mname.Location = New System.Drawing.Point(112, 185)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(174, 20)
        Me.txt_mname.TabIndex = 111
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(112, 158)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(344, 20)
        Me.txt_fname.TabIndex = 110
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(112, 128)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(344, 20)
        Me.txt_lname.TabIndex = 109
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(303, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Ext. "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Middle name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "First name :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Last name :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(215, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 16)
        Me.Label18.TabIndex = 74
        Me.Label18.Text = "BARANGAY"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 16)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "REGION"
        '
        'TextBox3
        '
        Me.TextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(304, 62)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(206, 22)
        Me.TextBox3.TabIndex = 73
        Me.TextBox3.Text = "BAGONG BUHAY"
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(103, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(45, 22)
        Me.TextBox1.TabIndex = 67
        Me.TextBox1.Text = "3"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(204, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 16)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "CITY/MUN"
        '
        'TextBox2
        '
        Me.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(109, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(83, 22)
        Me.TextBox2.TabIndex = 69
        Me.TextBox2.Text = "BULACAN"
        '
        'TextBox4
        '
        Me.TextBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(283, 28)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(219, 22)
        Me.TextBox4.TabIndex = 71
        Me.TextBox4.Text = "CITY OF SAN JOSE DELMONTE"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(26, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 16)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "PROVINCE"
        '
        'dg_rlist
        '
        Me.dg_rlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_rlist.Location = New System.Drawing.Point(541, 195)
        Me.dg_rlist.Name = "dg_rlist"
        Me.dg_rlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_rlist.Size = New System.Drawing.Size(583, 454)
        Me.dg_rlist.TabIndex = 10
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(44, 605)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(98, 44)
        Me.btn_save.TabIndex = 11
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(563, 125)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(74, 48)
        Me.btn_print.TabIndex = 12
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(816, 163)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(155, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "(Enter the Last name to search)"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(739, 140)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(287, 20)
        Me.txt_search.TabIndex = 16
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(1049, 135)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 29)
        Me.btn_search.TabIndex = 15
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(252, 605)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(98, 44)
        Me.btn_update.TabIndex = 18
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(148, 605)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(98, 44)
        Me.btn_edit.TabIndex = 19
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(356, 605)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(98, 44)
        Me.btn_delete.TabIndex = 20
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(644, 125)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(74, 48)
        Me.btn_new.TabIndex = 21
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_selectcomp
        '
        Me.btn_selectcomp.Location = New System.Drawing.Point(594, 77)
        Me.btn_selectcomp.Name = "btn_selectcomp"
        Me.btn_selectcomp.Size = New System.Drawing.Size(124, 35)
        Me.btn_selectcomp.TabIndex = 28
        Me.btn_selectcomp.Text = "Use Selected"
        Me.btn_selectcomp.UseVisualStyleBackColor = True
        '
        'frm_Residents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 689)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.dg_rlist)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Residents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg_rlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cb_ext As System.Windows.Forms.ComboBox
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_age As System.Windows.Forms.TextBox
    Friend WithEvents txt_pob As System.Windows.Forms.TextBox
    Friend WithEvents dtp_bday As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cb_civil As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_hnum As System.Windows.Forms.TextBox
    Friend WithEvents txt_occupation As System.Windows.Forms.TextBox
    Friend WithEvents txt_citizen As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dg_rlist As System.Windows.Forms.DataGridView
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_rid As System.Windows.Forms.TextBox
    Friend WithEvents rad_female As System.Windows.Forms.RadioButton
    Friend WithEvents rad_male As System.Windows.Forms.RadioButton
    Friend WithEvents txt_sx As System.Windows.Forms.TextBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_selectBC As System.Windows.Forms.Button
    Friend WithEvents btn_selectIND As System.Windows.Forms.Button
    Friend WithEvents cb_street As System.Windows.Forms.ComboBox
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents btn_selectcomp As System.Windows.Forms.Button
End Class
