<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.AdobeTheme1 = New Glyph.AdobeTheme()
        Me.AdobeButton1 = New Glyph.AdobeButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AdobeCheck1 = New Glyph.AdobeCheck()
        Me.AdobeTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdobeTheme1
        '
        Me.AdobeTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AdobeTheme1.Controls.Add(Me.AdobeCheck1)
        Me.AdobeTheme1.Controls.Add(Me.Label2)
        Me.AdobeTheme1.Controls.Add(Me.Label1)
        Me.AdobeTheme1.Controls.Add(Me.PictureBox1)
        Me.AdobeTheme1.Controls.Add(Me.TextBox2)
        Me.AdobeTheme1.Controls.Add(Me.TextBox1)
        Me.AdobeTheme1.Controls.Add(Me.AdobeButton1)
        Me.AdobeTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdobeTheme1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AdobeTheme1.Image = Nothing
        Me.AdobeTheme1.Location = New System.Drawing.Point(0, 0)
        Me.AdobeTheme1.MoveHeight = 19
        Me.AdobeTheme1.Name = "AdobeTheme1"
        Me.AdobeTheme1.Resizable = False
        Me.AdobeTheme1.Size = New System.Drawing.Size(180, 397)
        Me.AdobeTheme1.TabIndex = 0
        Me.AdobeTheme1.TextAlignment = Glyph.AdobeTheme.TextAlign.Left
        Me.AdobeTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'AdobeButton1
        '
        Me.AdobeButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AdobeButton1.Image = Nothing
        Me.AdobeButton1.Location = New System.Drawing.Point(100, 366)
        Me.AdobeButton1.Name = "AdobeButton1"
        Me.AdobeButton1.NoRounding = False
        Me.AdobeButton1.Orange = False
        Me.AdobeButton1.Size = New System.Drawing.Size(75, 23)
        Me.AdobeButton1.TabIndex = 0
        Me.AdobeButton1.Text = "Login"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 308)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 21)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 266)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(156, 21)
        Me.TextBox2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Glyph.My.Resources.Resources.glyph_logo_v1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 241)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'AdobeCheck1
        '
        Me.AdobeCheck1.CheckedState = False
        Me.AdobeCheck1.Image = Nothing
        Me.AdobeCheck1.Location = New System.Drawing.Point(15, 336)
        Me.AdobeCheck1.MaximumSize = New System.Drawing.Size(600, 16)
        Me.AdobeCheck1.MinimumSize = New System.Drawing.Size(16, 16)
        Me.AdobeCheck1.Name = "AdobeCheck1"
        Me.AdobeCheck1.NoRounding = False
        Me.AdobeCheck1.Size = New System.Drawing.Size(150, 16)
        Me.AdobeCheck1.TabIndex = 6
        Me.AdobeCheck1.Text = "Remember Me"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(180, 397)
        Me.Controls.Add(Me.AdobeTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.AdobeTheme1.ResumeLayout(False)
        Me.AdobeTheme1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AdobeTheme1 As Glyph.AdobeTheme
    Friend WithEvents AdobeButton1 As Glyph.AdobeButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AdobeCheck1 As Glyph.AdobeCheck
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
