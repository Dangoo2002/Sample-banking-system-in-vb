<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form4))
        Me.backbtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mailtxt = New System.Windows.Forms.TextBox()
        Me.baltxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.amounttxt = New System.Windows.Forms.TextBox()
        Me.phonetxt = New System.Windows.Forms.TextBox()
        Me.lasttxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.firsttxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usercombo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.picbtn = New System.Windows.Forms.Button()
        Me.picbox = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.backbtn.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbtn.Location = New System.Drawing.Point(912, 81)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(122, 35)
        Me.backbtn.TabIndex = 18
        Me.backbtn.Text = "Back"
        Me.ToolTip1.SetToolTip(Me.backbtn, "Previous Form")
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.updatebtn.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.Location = New System.Drawing.Point(912, 144)
        Me.updatebtn.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(122, 37)
        Me.updatebtn.TabIndex = 19
        Me.updatebtn.Text = "Update"
        Me.ToolTip1.SetToolTip(Me.updatebtn, "Save")
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.mailtxt)
        Me.GroupBox1.Controls.Add(Me.baltxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.amounttxt)
        Me.GroupBox1.Controls.Add(Me.phonetxt)
        Me.GroupBox1.Controls.Add(Me.lasttxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.firsttxt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.usercombo)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 464)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update Details"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 362)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 14)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Email"
        '
        'mailtxt
        '
        Me.mailtxt.Location = New System.Drawing.Point(174, 355)
        Me.mailtxt.Name = "mailtxt"
        Me.mailtxt.Size = New System.Drawing.Size(159, 21)
        Me.mailtxt.TabIndex = 22
        '
        'baltxt
        '
        Me.baltxt.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.baltxt.Location = New System.Drawing.Point(174, 415)
        Me.baltxt.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.baltxt.Name = "baltxt"
        Me.baltxt.ReadOnly = True
        Me.baltxt.Size = New System.Drawing.Size(132, 21)
        Me.baltxt.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 422)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Balance"
        '
        'amounttxt
        '
        Me.amounttxt.Location = New System.Drawing.Point(174, 293)
        Me.amounttxt.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.amounttxt.MaxLength = 10
        Me.amounttxt.Name = "amounttxt"
        Me.amounttxt.Size = New System.Drawing.Size(159, 21)
        Me.amounttxt.TabIndex = 31
        '
        'phonetxt
        '
        Me.phonetxt.Location = New System.Drawing.Point(174, 234)
        Me.phonetxt.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(159, 21)
        Me.phonetxt.TabIndex = 30
        '
        'lasttxt
        '
        Me.lasttxt.Location = New System.Drawing.Point(174, 169)
        Me.lasttxt.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.lasttxt.Name = "lasttxt"
        Me.lasttxt.Size = New System.Drawing.Size(159, 21)
        Me.lasttxt.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 296)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 14)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Amount Deposited"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 237)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 14)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 172)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Last name"
        '
        'firsttxt
        '
        Me.firsttxt.Location = New System.Drawing.Point(174, 101)
        Me.firsttxt.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.firsttxt.Name = "firsttxt"
        Me.firsttxt.Size = New System.Drawing.Size(159, 21)
        Me.firsttxt.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 14)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 14)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Select User"
        '
        'usercombo
        '
        Me.usercombo.FormattingEnabled = True
        Me.usercombo.Location = New System.Drawing.Point(174, 29)
        Me.usercombo.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.usercombo.Name = "usercombo"
        Me.usercombo.Size = New System.Drawing.Size(159, 22)
        Me.usercombo.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.picbtn)
        Me.GroupBox2.Controls.Add(Me.picbox)
        Me.GroupBox2.Location = New System.Drawing.Point(467, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 308)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Update Picture"
        '
        'picbtn
        '
        Me.picbtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.picbtn.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picbtn.Location = New System.Drawing.Point(86, 237)
        Me.picbtn.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.picbtn.Name = "picbtn"
        Me.picbtn.Size = New System.Drawing.Size(139, 29)
        Me.picbtn.TabIndex = 19
        Me.picbtn.Text = "Update Picture"
        Me.ToolTip1.SetToolTip(Me.picbtn, "Load Picture")
        Me.picbtn.UseVisualStyleBackColor = False
        '
        'picbox
        '
        Me.picbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picbox.Location = New System.Drawing.Point(54, 45)
        Me.picbox.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(197, 174)
        Me.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox.TabIndex = 18
        Me.picbox.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Location = New System.Drawing.Point(912, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 36)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button3.Location = New System.Drawing.Point(912, 209)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 37)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'form4
        '
        Me.AcceptButton = Me.updatebtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1048, 519)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.backbtn)
        Me.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "form4"
        Me.Text = "Update Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents backbtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents baltxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents amounttxt As TextBox
    Friend WithEvents phonetxt As TextBox
    Friend WithEvents lasttxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents firsttxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents usercombo As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents picbtn As Button
    Friend WithEvents picbox As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents mailtxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
