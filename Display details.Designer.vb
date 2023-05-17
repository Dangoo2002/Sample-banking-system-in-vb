<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form5))
        Me.displaybtn = New System.Windows.Forms.Button()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'displaybtn
        '
        Me.displaybtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.displaybtn.Location = New System.Drawing.Point(631, 314)
        Me.displaybtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.displaybtn.Name = "displaybtn"
        Me.displaybtn.Size = New System.Drawing.Size(135, 40)
        Me.displaybtn.TabIndex = 0
        Me.displaybtn.Text = "DISPLAY"
        Me.displaybtn.UseVisualStyleBackColor = False
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.backbtn.Location = New System.Drawing.Point(631, 364)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(135, 41)
        Me.backbtn.TabIndex = 1
        Me.backbtn.Text = "BACK"
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 85)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(590, 320)
        Me.dgv.TabIndex = 2
        '
        'form5
        '
        Me.AcceptButton = Me.displaybtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(769, 432)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.displaybtn)
        Me.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "form5"
        Me.Text = "Display Details"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents displaybtn As Button
    Friend WithEvents backbtn As Button
    Friend WithEvents dgv As DataGridView
End Class
