<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Precursor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Precursor))
        Me.AESDecrypt = New System.Windows.Forms.Button()
        Me.FileBrowse = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AESEncrypt = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AESDecrypt
        '
        Me.AESDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AESDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AESDecrypt.ForeColor = System.Drawing.Color.DodgerBlue
        Me.AESDecrypt.Location = New System.Drawing.Point(514, 208)
        Me.AESDecrypt.Name = "AESDecrypt"
        Me.AESDecrypt.Size = New System.Drawing.Size(128, 32)
        Me.AESDecrypt.TabIndex = 15
        Me.AESDecrypt.Text = "Decrypt File"
        Me.AESDecrypt.UseVisualStyleBackColor = True
        '
        'FileBrowse
        '
        Me.FileBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FileBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileBrowse.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FileBrowse.Location = New System.Drawing.Point(515, 12)
        Me.FileBrowse.Name = "FileBrowse"
        Me.FileBrowse.Size = New System.Drawing.Size(128, 61)
        Me.FileBrowse.TabIndex = 14
        Me.FileBrowse.Text = "Browse File"
        Me.FileBrowse.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(28, 208)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(459, 13)
        Me.ProgressBar1.TabIndex = 12
        Me.ProgressBar1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(24, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "File to Encrypt:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(28, 156)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(459, 32)
        Me.TextBox1.TabIndex = 1
        '
        'AESEncrypt
        '
        Me.AESEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AESEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AESEncrypt.ForeColor = System.Drawing.Color.DodgerBlue
        Me.AESEncrypt.Location = New System.Drawing.Point(514, 156)
        Me.AESEncrypt.Name = "AESEncrypt"
        Me.AESEncrypt.Size = New System.Drawing.Size(128, 32)
        Me.AESEncrypt.TabIndex = 0
        Me.AESEncrypt.Text = "Encrypt File"
        Me.AESEncrypt.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(28, 227)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(459, 13)
        Me.ProgressBar2.TabIndex = 16
        Me.ProgressBar2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Precursor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(655, 259)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.AESDecrypt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FileBrowse)
        Me.Controls.Add(Me.AESEncrypt)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Precursor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rijndael 256-Bit Precursor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AESEncrypt As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents FileBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AESDecrypt As Button
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
End Class
