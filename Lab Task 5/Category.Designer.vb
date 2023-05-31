<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Category))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btChar = New System.Windows.Forms.Button()
        Me.btMovie = New System.Windows.Forms.Button()
        Me.btPlanet = New System.Windows.Forms.Button()
        Me.btQuote = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label1.Location = New System.Drawing.Point(236, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 54)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Select a category:"
        '
        'btChar
        '
        Me.btChar.BackColor = System.Drawing.Color.Transparent
        Me.btChar.BackgroundImage = Global.Lab_Task_5.My.Resources.Resources.Character
        Me.btChar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btChar.Location = New System.Drawing.Point(12, 84)
        Me.btChar.Name = "btChar"
        Me.btChar.Size = New System.Drawing.Size(400, 150)
        Me.btChar.TabIndex = 13
        Me.btChar.UseVisualStyleBackColor = False
        '
        'btMovie
        '
        Me.btMovie.BackColor = System.Drawing.Color.Transparent
        Me.btMovie.BackgroundImage = Global.Lab_Task_5.My.Resources.Resources.Movie
        Me.btMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btMovie.Location = New System.Drawing.Point(421, 84)
        Me.btMovie.Name = "btMovie"
        Me.btMovie.Size = New System.Drawing.Size(400, 150)
        Me.btMovie.TabIndex = 14
        Me.btMovie.UseVisualStyleBackColor = False
        '
        'btPlanet
        '
        Me.btPlanet.BackColor = System.Drawing.Color.Transparent
        Me.btPlanet.BackgroundImage = Global.Lab_Task_5.My.Resources.Resources.Planet
        Me.btPlanet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btPlanet.Location = New System.Drawing.Point(421, 240)
        Me.btPlanet.Name = "btPlanet"
        Me.btPlanet.Size = New System.Drawing.Size(400, 150)
        Me.btPlanet.TabIndex = 16
        Me.btPlanet.UseVisualStyleBackColor = False
        '
        'btQuote
        '
        Me.btQuote.BackColor = System.Drawing.Color.Transparent
        Me.btQuote.BackgroundImage = Global.Lab_Task_5.My.Resources.Resources.Quote
        Me.btQuote.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btQuote.Location = New System.Drawing.Point(12, 240)
        Me.btQuote.Name = "btQuote"
        Me.btQuote.Size = New System.Drawing.Size(400, 150)
        Me.btQuote.TabIndex = 15
        Me.btQuote.UseVisualStyleBackColor = False
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Lab_Task_5.My.Resources.Resources.CategoryBG1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(833, 427)
        Me.Controls.Add(Me.btPlanet)
        Me.Controls.Add(Me.btQuote)
        Me.Controls.Add(Me.btMovie)
        Me.Controls.Add(Me.btChar)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btChar As Button
    Friend WithEvents btMovie As Button
    Friend WithEvents btPlanet As Button
    Friend WithEvents btQuote As Button
End Class
