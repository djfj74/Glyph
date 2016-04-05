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
        Me.AdobeTheme1 = New Glyph.AdobeTheme
        Me.AdobeButton1 = New Glyph.AdobeButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.AdobeButton2 = New Glyph.AdobeButton
        Me.AdobeTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdobeTheme1
        '
        Me.AdobeTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AdobeTheme1.Controls.Add(Me.AdobeButton2)
        Me.AdobeTheme1.Controls.Add(Me.AdobeButton1)
        Me.AdobeTheme1.Controls.Add(Me.PictureBox1)
        Me.AdobeTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdobeTheme1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AdobeTheme1.Image = Nothing
        Me.AdobeTheme1.Location = New System.Drawing.Point(0, 0)
        Me.AdobeTheme1.MoveHeight = 19
        Me.AdobeTheme1.Name = "AdobeTheme1"
        Me.AdobeTheme1.Resizable = False
        Me.AdobeTheme1.Size = New System.Drawing.Size(183, 314)
        Me.AdobeTheme1.TabIndex = 0
        Me.AdobeTheme1.TextAlignment = Glyph.AdobeTheme.TextAlign.Left
        Me.AdobeTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'AdobeButton1
        '
        Me.AdobeButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AdobeButton1.Image = Nothing
        Me.AdobeButton1.Location = New System.Drawing.Point(96, 283)
        Me.AdobeButton1.Name = "AdobeButton1"
        Me.AdobeButton1.NoRounding = False
        Me.AdobeButton1.Orange = False
        Me.AdobeButton1.Size = New System.Drawing.Size(75, 23)
        Me.AdobeButton1.TabIndex = 5
        Me.AdobeButton1.Text = "Continue"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Glyph.My.Resources.Resources.glyph_logo_v1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 240)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'AdobeButton2
        '
        Me.AdobeButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AdobeButton2.Image = Nothing
        Me.AdobeButton2.Location = New System.Drawing.Point(13, 247)
        Me.AdobeButton2.Name = "AdobeButton2"
        Me.AdobeButton2.NoRounding = False
        Me.AdobeButton2.Orange = False
        Me.AdobeButton2.Size = New System.Drawing.Size(158, 23)
        Me.AdobeButton2.TabIndex = 6
        Me.AdobeButton2.Text = "Authenticate"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(183, 314)
        Me.Controls.Add(Me.AdobeTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.AdobeTheme1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AdobeTheme1 As Glyph.AdobeTheme
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AdobeButton1 As Glyph.AdobeButton
    Friend WithEvents AdobeButton2 As Glyph.AdobeButton

End Class
