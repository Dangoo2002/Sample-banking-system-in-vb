<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form3))
        Me.backbtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mailtxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.idtxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.phonetxt = New System.Windows.Forms.TextBox()
        Me.amnttxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gentxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lastnametxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.firstnametxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.loadpicbtn = New System.Windows.Forms.Button()
        Me.picbox = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.backbtn.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbtn.Location = New System.Drawing.Point(726, 420)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(129, 40)
        Me.backbtn.TabIndex = 8
        Me.backbtn.Text = "Back"
        Me.ToolTip1.SetToolTip(Me.backbtn, "Previous Form")
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.savebtn.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.Location = New System.Drawing.Point(889, 419)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(137, 41)
        Me.savebtn.TabIndex = 9
        Me.savebtn.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.savebtn, "Save")
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.mailtxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.idtxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.phonetxt)
        Me.GroupBox1.Controls.Add(Me.amnttxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.gentxt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lastnametxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.firstnametxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 449)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input  Details"
        '
        'mailtxt
        '
        Me.mailtxt.Location = New System.Drawing.Point(197, 275)
        Me.mailtxt.Name = "mailtxt"
        Me.mailtxt.Size = New System.Drawing.Size(132, 21)
        Me.mailtxt.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 14)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Email"
        '
        'idtxt
        '
        Me.idtxt.Location = New System.Drawing.Point(197, 19)
        Me.idtxt.Name = "idtxt"
        Me.idtxt.Size = New System.Drawing.Size(43, 21)
        Me.idtxt.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 14)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "ID"
        '
        'phonetxt
        '
        Me.phonetxt.Location = New System.Drawing.Point(197, 154)
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(132, 21)
        Me.phonetxt.TabIndex = 28
        '
        'amnttxt
        '
        Me.amnttxt.Location = New System.Drawing.Point(197, 214)
        Me.amnttxt.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.amnttxt.Name = "amnttxt"
        Me.amnttxt.Size = New System.Drawing.Size(132, 21)
        Me.amnttxt.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 221)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 14)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Amount Deposited"
        '
        'gentxt
        '
        Me.gentxt.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.gentxt.Location = New System.Drawing.Point(197, 354)
        Me.gentxt.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.gentxt.Name = "gentxt"
        Me.gentxt.ReadOnly = True
        Me.gentxt.Size = New System.Drawing.Size(132, 21)
        Me.gentxt.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(8, 357)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 28)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Generate Accont Number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lastnametxt
        '
        Me.lastnametxt.Location = New System.Drawing.Point(197, 106)
        Me.lastnametxt.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.lastnametxt.Name = "lastnametxt"
        Me.lastnametxt.Size = New System.Drawing.Size(132, 21)
        Me.lastnametxt.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 14)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Last name"
        '
        'firstnametxt
        '
        Me.firstnametxt.Location = New System.Drawing.Point(197, 57)
        Me.firstnametxt.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.firstnametxt.Name = "firstnametxt"
        Me.firstnametxt.Size = New System.Drawing.Size(132, 21)
        Me.firstnametxt.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "First Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.loadpicbtn)
        Me.GroupBox2.Controls.Add(Me.picbox)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(509, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 287)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Insert picture"
        '
        'loadpicbtn
        '
        Me.loadpicbtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.loadpicbtn.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadpicbtn.Location = New System.Drawing.Point(96, 241)
        Me.loadpicbtn.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.loadpicbtn.Name = "loadpicbtn"
        Me.loadpicbtn.Size = New System.Drawing.Size(105, 23)
        Me.loadpicbtn.TabIndex = 13
        Me.loadpicbtn.Text = "Load Picture"
        Me.ToolTip1.SetToolTip(Me.loadpicbtn, "Load Picture")
        Me.loadpicbtn.UseVisualStyleBackColor = False
        '
        'picbox
        '
        Me.picbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picbox.Location = New System.Drawing.Point(61, 48)
        Me.picbox.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(170, 187)
        Me.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox.TabIndex = 12
        Me.picbox.TabStop = False
        '
        'form3
        '
        Me.AcceptButton = Me.savebtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1066, 484)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.backbtn)
        Me.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "form3"
        Me.Text = "Register New User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents backbtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents amnttxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents gentxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lastnametxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents firstnametxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents loadpicbtn As Button
    Friend WithEvents picbox As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents phonetxt As TextBox
    Friend WithEvents idtxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mailtxt As TextBox
    Friend WithEvents Label4 As Label
End Class
