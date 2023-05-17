<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form2))
        Me.regbtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.displaybtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'regbtn
        '
        Me.regbtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.regbtn.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regbtn.Location = New System.Drawing.Point(38, 49)
        Me.regbtn.Name = "regbtn"
        Me.regbtn.Size = New System.Drawing.Size(133, 23)
        Me.regbtn.TabIndex = 0
        Me.regbtn.Text = "Register New User"
        Me.ToolTip1.SetToolTip(Me.regbtn, "New User")
        Me.regbtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.updatebtn.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.Location = New System.Drawing.Point(38, 100)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(133, 23)
        Me.updatebtn.TabIndex = 1
        Me.updatebtn.Text = "Update Details"
        Me.ToolTip1.SetToolTip(Me.updatebtn, "Update Details")
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.backbtn.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbtn.Location = New System.Drawing.Point(182, 199)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(119, 23)
        Me.backbtn.TabIndex = 3
        Me.backbtn.Text = "Back"
        Me.ToolTip1.SetToolTip(Me.backbtn, "Previous Form")
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.displaybtn)
        Me.GroupBox1.Controls.Add(Me.regbtn)
        Me.GroupBox1.Controls.Add(Me.backbtn)
        Me.GroupBox1.Controls.Add(Me.updatebtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 228)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'displaybtn
        '
        Me.displaybtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.displaybtn.Location = New System.Drawing.Point(38, 141)
        Me.displaybtn.Name = "displaybtn"
        Me.displaybtn.Size = New System.Drawing.Size(133, 23)
        Me.displaybtn.TabIndex = 4
        Me.displaybtn.Text = "Display Users"
        Me.displaybtn.UseVisualStyleBackColor = False
        '
        'form2
        '
        Me.AcceptButton = Me.regbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 275)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "form2"
        Me.Text = "Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents regbtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents backbtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents displaybtn As Button
End Class
