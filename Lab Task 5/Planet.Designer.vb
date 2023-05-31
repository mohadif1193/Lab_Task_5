<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Planet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Planet))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ans4 = New System.Windows.Forms.CheckBox()
        Me.ans3 = New System.Windows.Forms.CheckBox()
        Me.ans2 = New System.Windows.Forms.CheckBox()
        Me.ans1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btCheck = New System.Windows.Forms.Button()
        Me.lblRightAns = New System.Windows.Forms.Label()
        Me.btEnd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 32)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Marks: "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.ans4)
        Me.GroupBox1.Controls.Add(Me.ans3)
        Me.GroupBox1.Controls.Add(Me.ans2)
        Me.GroupBox1.Controls.Add(Me.ans1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(28, 89)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(440, 121)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'ans4
        '
        Me.ans4.AutoSize = True
        Me.ans4.Location = New System.Drawing.Point(247, 64)
        Me.ans4.Name = "ans4"
        Me.ans4.Size = New System.Drawing.Size(114, 36)
        Me.ans4.TabIndex = 3
        Me.ans4.Text = "Remus"
        Me.ans4.UseVisualStyleBackColor = True
        '
        'ans3
        '
        Me.ans3.AutoSize = True
        Me.ans3.Location = New System.Drawing.Point(247, 19)
        Me.ans3.Name = "ans3"
        Me.ans3.Size = New System.Drawing.Size(131, 36)
        Me.ans3.TabIndex = 2
        Me.ans3.Text = "Andoria"
        Me.ans3.UseVisualStyleBackColor = True
        '
        'ans2
        '
        Me.ans2.AutoSize = True
        Me.ans2.Location = New System.Drawing.Point(9, 64)
        Me.ans2.Name = "ans2"
        Me.ans2.Size = New System.Drawing.Size(118, 36)
        Me.ans2.TabIndex = 1
        Me.ans2.Text = "Hanzel"
        Me.ans2.UseVisualStyleBackColor = True
        '
        'ans1
        '
        Me.ans1.AutoSize = True
        Me.ans1.Location = New System.Drawing.Point(9, 19)
        Me.ans1.Name = "ans1"
        Me.ans1.Size = New System.Drawing.Size(117, 36)
        Me.ans1.TabIndex = 0
        Me.ans1.Text = "Vulcan"
        Me.ans1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(481, 32)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Select planets that are shown in Star Trek"
        '
        'btCheck
        '
        Me.btCheck.BackColor = System.Drawing.SystemColors.Control
        Me.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCheck.Location = New System.Drawing.Point(28, 219)
        Me.btCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.btCheck.Name = "btCheck"
        Me.btCheck.Size = New System.Drawing.Size(169, 50)
        Me.btCheck.TabIndex = 27
        Me.btCheck.Text = "Check"
        Me.btCheck.UseVisualStyleBackColor = False
        '
        'lblRightAns
        '
        Me.lblRightAns.AutoSize = True
        Me.lblRightAns.BackColor = System.Drawing.Color.Transparent
        Me.lblRightAns.ForeColor = System.Drawing.Color.White
        Me.lblRightAns.Location = New System.Drawing.Point(102, 53)
        Me.lblRightAns.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblRightAns.Name = "lblRightAns"
        Me.lblRightAns.Size = New System.Drawing.Size(0, 32)
        Me.lblRightAns.TabIndex = 22
        '
        'btEnd
        '
        Me.btEnd.BackColor = System.Drawing.SystemColors.Control
        Me.btEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btEnd.Location = New System.Drawing.Point(299, 219)
        Me.btEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.btEnd.Name = "btEnd"
        Me.btEnd.Size = New System.Drawing.Size(169, 50)
        Me.btEnd.TabIndex = 26
        Me.btEnd.Text = "End"
        Me.btEnd.UseVisualStyleBackColor = False
        '
        'Planet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Lab_Task_5.My.Resources.Resources.planetBG
        Me.ClientSize = New System.Drawing.Size(497, 282)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btCheck)
        Me.Controls.Add(Me.lblRightAns)
        Me.Controls.Add(Me.btEnd)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Planet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Star Trek Planet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ans4 As CheckBox
    Friend WithEvents ans3 As CheckBox
    Friend WithEvents ans2 As CheckBox
    Friend WithEvents ans1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btCheck As Button
    Friend WithEvents lblRightAns As Label
    Friend WithEvents btEnd As Button
End Class
