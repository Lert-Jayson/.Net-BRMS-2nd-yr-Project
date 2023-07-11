<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_brgyOfficials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_brgyOfficials))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_stat = New System.Windows.Forms.TextBox
        Me.txt_oid = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cb_pos = New System.Windows.Forms.ComboBox
        Me.dtp_dob = New System.Windows.Forms.DateTimePicker
        Me.rad_notactive = New System.Windows.Forms.RadioButton
        Me.rad_active = New System.Windows.Forms.RadioButton
        Me.txt_fname = New System.Windows.Forms.TextBox
        Me.txt_mname = New System.Windows.Forms.TextBox
        Me.txt_lname = New System.Windows.Forms.TextBox
        Me.txt_age = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dg_olist = New System.Windows.Forms.DataGridView
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_search = New System.Windows.Forms.TextBox
        Me.btn_search = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_new = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_olist, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1136, 149)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(460, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List of Officials"
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(1020, 19)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_stat)
        Me.GroupBox2.Controls.Add(Me.txt_oid)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cb_pos)
        Me.GroupBox2.Controls.Add(Me.dtp_dob)
        Me.GroupBox2.Controls.Add(Me.rad_notactive)
        Me.GroupBox2.Controls.Add(Me.rad_active)
        Me.GroupBox2.Controls.Add(Me.txt_fname)
        Me.GroupBox2.Controls.Add(Me.txt_mname)
        Me.GroupBox2.Controls.Add(Me.txt_lname)
        Me.GroupBox2.Controls.Add(Me.txt_age)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(571, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 376)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Official Details"
        '
        'txt_stat
        '
        Me.txt_stat.Enabled = False
        Me.txt_stat.Location = New System.Drawing.Point(152, 349)
        Me.txt_stat.Name = "txt_stat"
        Me.txt_stat.Size = New System.Drawing.Size(78, 20)
        Me.txt_stat.TabIndex = 8
        '
        'txt_oid
        '
        Me.txt_oid.Enabled = False
        Me.txt_oid.Location = New System.Drawing.Point(152, 35)
        Me.txt_oid.Name = "txt_oid"
        Me.txt_oid.Size = New System.Drawing.Size(55, 20)
        Me.txt_oid.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Official ID:"
        '
        'cb_pos
        '
        Me.cb_pos.FormattingEnabled = True
        Me.cb_pos.Location = New System.Drawing.Point(152, 304)
        Me.cb_pos.Name = "cb_pos"
        Me.cb_pos.Size = New System.Drawing.Size(200, 21)
        Me.cb_pos.TabIndex = 4
        '
        'dtp_dob
        '
        Me.dtp_dob.CustomFormat = "yyyy/MM/dd"
        Me.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_dob.Location = New System.Drawing.Point(152, 259)
        Me.dtp_dob.Name = "dtp_dob"
        Me.dtp_dob.Size = New System.Drawing.Size(200, 20)
        Me.dtp_dob.TabIndex = 3
        '
        'rad_notactive
        '
        Me.rad_notactive.AutoSize = True
        Me.rad_notactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_notactive.Location = New System.Drawing.Point(341, 352)
        Me.rad_notactive.Name = "rad_notactive"
        Me.rad_notactive.Size = New System.Drawing.Size(75, 17)
        Me.rad_notactive.TabIndex = 2
        Me.rad_notactive.TabStop = True
        Me.rad_notactive.Text = "Not Active"
        Me.rad_notactive.UseVisualStyleBackColor = True
        '
        'rad_active
        '
        Me.rad_active.AutoSize = True
        Me.rad_active.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_active.Location = New System.Drawing.Point(264, 352)
        Me.rad_active.Name = "rad_active"
        Me.rad_active.Size = New System.Drawing.Size(55, 17)
        Me.rad_active.TabIndex = 2
        Me.rad_active.TabStop = True
        Me.rad_active.Text = "Active"
        Me.rad_active.UseVisualStyleBackColor = True
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(152, 80)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(234, 20)
        Me.txt_fname.TabIndex = 1
        '
        'txt_mname
        '
        Me.txt_mname.Location = New System.Drawing.Point(152, 169)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(234, 20)
        Me.txt_mname.TabIndex = 1
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(152, 124)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(234, 20)
        Me.txt_lname.TabIndex = 1
        '
        'txt_age
        '
        Me.txt_age.Location = New System.Drawing.Point(152, 210)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(78, 20)
        Me.txt_age.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 349)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Status:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Position:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Date of Birth:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Age:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Middle Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name:"
        '
        'dg_olist
        '
        Me.dg_olist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_olist.Location = New System.Drawing.Point(12, 155)
        Me.dg_olist.Name = "dg_olist"
        Me.dg_olist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_olist.Size = New System.Drawing.Size(542, 373)
        Me.dg_olist.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(203, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "(Enter the Last name to search)"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(93, 108)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(378, 20)
        Me.txt_search.TabIndex = 18
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(12, 108)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 29)
        Me.btn_search.TabIndex = 17
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(584, 527)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(98, 44)
        Me.btn_save.TabIndex = 20
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(899, 527)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(98, 44)
        Me.btn_delete.TabIndex = 23
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(691, 527)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(98, 44)
        Me.btn_edit.TabIndex = 22
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(795, 527)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(98, 44)
        Me.btn_update.TabIndex = 21
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(805, 100)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(98, 44)
        Me.btn_new.TabIndex = 24
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'frm_brgyOfficials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 593)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.dg_olist)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_brgyOfficials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dg_olist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_oid As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cb_pos As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents rad_notactive As System.Windows.Forms.RadioButton
    Friend WithEvents rad_active As System.Windows.Forms.RadioButton
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents txt_age As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dg_olist As System.Windows.Forms.DataGridView
    Friend WithEvents txt_stat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
End Class
