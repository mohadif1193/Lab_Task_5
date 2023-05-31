<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movie))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ans6 = New System.Windows.Forms.CheckBox()
        Me.ans5 = New System.Windows.Forms.CheckBox()
        Me.ans4 = New System.Windows.Forms.CheckBox()
        Me.ans3 = New System.Windows.Forms.CheckBox()
        Me.ans2 = New System.Windows.Forms.CheckBox()
        Me.ans1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRightAns = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btCheck = New System.Windows.Forms.Button()
        Me.btEnd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.ans6)
        Me.GroupBox1.Controls.Add(Me.ans5)
        Me.GroupBox1.Controls.Add(Me.ans4)
        Me.GroupBox1.Controls.Add(Me.ans3)
        Me.GroupBox1.Controls.Add(Me.ans2)
        Me.GroupBox1.Controls.Add(Me.ans1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(15, 90)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(440, 159)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'ans6
        '
        Me.ans6.AutoSize = True
        Me.ans6.Location = New System.Drawing.Point(215, 113)
        Me.ans6.Name = "ans6"
        Me.ans6.Size = New System.Drawing.Size(195, 36)
        Me.ans6.TabIndex = 5
        Me.ans6.Text = "Into Darkness"
        Me.ans6.UseVisualStyleBackColor = True
        '
        'ans5
        '
        Me.ans5.AutoSize = True
        Me.ans5.Location = New System.Drawing.Point(215, 71)
        Me.ans5.Name = "ans5"
        Me.ans5.Size = New System.Drawing.Size(125, 36)
        Me.ans5.TabIndex = 4
        Me.ans5.Text = "Genesis"
        Me.ans5.UseVisualStyleBackColor = True
        '
        'ans4
        '
        Me.ans4.AutoSize = True
        Me.ans4.Location = New System.Drawing.Point(215, 26)
        Me.ans4.Name = "ans4"
        Me.ans4.Size = New System.Drawing.Size(108, 36)
        Me.ans4.TabIndex = 3
        Me.ans4.Text = "Doom"
        Me.ans4.UseVisualStyleBackColor = True
        '
        'ans3
        '
        Me.ans3.AutoSize = True
        Me.ans3.Location = New System.Drawing.Point(9, 113)
        Me.ans3.Name = "ans3"
        Me.ans3.Size = New System.Drawing.Size(175, 36)
        Me.ans3.TabIndex = 2
        Me.ans3.Text = "Generations"
        Me.ans3.UseVisualStyleBackColor = True
        '
        'ans2
        '
        Me.ans2.AutoSize = True
        Me.ans2.Location = New System.Drawing.Point(9, 71)
        Me.ans2.Name = "ans2"
        Me.ans2.Size = New System.Drawing.Size(175, 36)
        Me.ans2.TabIndex = 1
        Me.ans2.Text = "Insurrection"
        Me.ans2.UseVisualStyleBackColor = True
        '
        'ans1
        '
        Me.ans1.AutoSize = True
        Me.ans1.Location = New System.Drawing.Point(9, 26)
        Me.ans1.Name = "ans1"
        Me.ans1.Size = New System.Drawing.Size(194, 36)
        Me.ans1.TabIndex = 0
        Me.ans1.Text = "First Contract"
        Me.ans1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 32)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Marks: "
        '
        'lblRightAns
        '
        Me.lblRightAns.AutoSize = True
        Me.lblRightAns.BackColor = System.Drawing.Color.Transparent
        Me.lblRightAns.ForeColor = System.Drawing.Color.White
        Me.lblRightAns.Location = New System.Drawing.Point(100, 53)
        Me.lblRightAns.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblRightAns.Name = "lblRightAns"
        Me.lblRightAns.Size = New System.Drawing.Size(0, 32)
        Me.lblRightAns.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 32)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Select the real movie title of Star Trek"
        '
        'btCheck
        '
        Me.btCheck.BackColor = System.Drawing.SystemColors.Control
        Me.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCheck.Location = New System.Drawing.Point(15, 258)
        Me.btCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.btCheck.Name = "btCheck"
        Me.btCheck.Size = New System.Drawing.Size(169, 50)
        Me.btCheck.TabIndex = 21
        Me.btCheck.Text = "Check"
        Me.btCheck.UseVisualStyleBackColor = False
        '
        'btEnd
        '
        Me.btEnd.BackColor = System.Drawing.SystemColors.Control
        Me.btEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btEnd.Location = New System.Drawing.Point(286, 258)
        Me.btEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.btEnd.Name = "btEnd"
        Me.btEnd.Size = New System.Drawing.Size(169, 50)
        Me.btEnd.TabIndex = 20
        Me.btEnd.Text = "End"
        Me.btEnd.UseVisualStyleBackColor = False
        '
        'Movie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Lab_Task_5.My.Resources.Resources.MovieBG
        Me.ClientSize = New System.Drawing.Size(469, 320)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btCheck)
        Me.Controls.Add(Me.lblRightAns)
        Me.Controls.Add(Me.btEnd)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Movie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Star Trek Movie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRightAns As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btCheck As Button
    Friend WithEvents btEnd As Button
    Friend WithEvents ans6 As CheckBox
    Friend WithEvents ans5 As CheckBox
    Friend WithEvents ans4 As CheckBox
    Friend WithEvents ans3 As CheckBox
    Friend WithEvents ans2 As CheckBox
    Friend WithEvents ans1 As CheckBox
End Class
