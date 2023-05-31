<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quote2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quote2))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ansBot = New System.Windows.Forms.RadioButton()
        Me.ansMid = New System.Windows.Forms.RadioButton()
        Me.ansTop = New System.Windows.Forms.RadioButton()
        Me.btCheck = New System.Windows.Forms.Button()
        Me.lblRightAns = New System.Windows.Forms.Label()
        Me.btNext = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 32)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Marks: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 64)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = """If we're going to be damned, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "let's be damned for what we really are."""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ansBot)
        Me.GroupBox1.Controls.Add(Me.ansMid)
        Me.GroupBox1.Controls.Add(Me.ansTop)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(17, 144)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(466, 217)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(344, 32)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Who's quote is shown above?"
        '
        'ansBot
        '
        Me.ansBot.AutoSize = True
        Me.ansBot.Location = New System.Drawing.Point(15, 160)
        Me.ansBot.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ansBot.Name = "ansBot"
        Me.ansBot.Size = New System.Drawing.Size(111, 36)
        Me.ansBot.TabIndex = 2
        Me.ansBot.TabStop = True
        Me.ansBot.Text = "Neelix"
        Me.ansBot.UseVisualStyleBackColor = True
        '
        'ansMid
        '
        Me.ansMid.AutoSize = True
        Me.ansMid.Location = New System.Drawing.Point(15, 114)
        Me.ansMid.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ansMid.Name = "ansMid"
        Me.ansMid.Size = New System.Drawing.Size(57, 36)
        Me.ansMid.TabIndex = 1
        Me.ansMid.TabStop = True
        Me.ansMid.Text = "Q"
        Me.ansMid.UseVisualStyleBackColor = True
        '
        'ansTop
        '
        Me.ansTop.AutoSize = True
        Me.ansTop.Location = New System.Drawing.Point(15, 68)
        Me.ansTop.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ansTop.Name = "ansTop"
        Me.ansTop.Size = New System.Drawing.Size(216, 36)
        Me.ansTop.TabIndex = 0
        Me.ansTop.TabStop = True
        Me.ansTop.Text = "Jean-Luc Picard"
        Me.ansTop.UseVisualStyleBackColor = True
        '
        'btCheck
        '
        Me.btCheck.BackColor = System.Drawing.SystemColors.Control
        Me.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCheck.Location = New System.Drawing.Point(17, 370)
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
        Me.lblRightAns.Location = New System.Drawing.Point(102, 86)
        Me.lblRightAns.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblRightAns.Name = "lblRightAns"
        Me.lblRightAns.Size = New System.Drawing.Size(0, 32)
        Me.lblRightAns.TabIndex = 22
        '
        'btNext
        '
        Me.btNext.BackColor = System.Drawing.SystemColors.Control
        Me.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btNext.Location = New System.Drawing.Point(316, 370)
        Me.btNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btNext.Name = "btNext"
        Me.btNext.Size = New System.Drawing.Size(167, 50)
        Me.btNext.TabIndex = 26
        Me.btNext.Text = "Next"
        Me.btNext.UseVisualStyleBackColor = False
        '
        'Quote2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Lab_Task_5.My.Resources.Resources.QuoteBG
        Me.ClientSize = New System.Drawing.Size(500, 430)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btCheck)
        Me.Controls.Add(Me.lblRightAns)
        Me.Controls.Add(Me.btNext)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Quote2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Star Trek Quote"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ansBot As RadioButton
    Friend WithEvents ansMid As RadioButton
    Friend WithEvents ansTop As RadioButton
    Friend WithEvents btCheck As Button
    Friend WithEvents lblRightAns As Label
    Friend WithEvents btNext As Button
End Class
