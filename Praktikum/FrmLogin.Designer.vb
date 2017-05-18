<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxPassword = New System.Windows.Forms.TextBox()
        Me.TxUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.cb_saveid = New System.Windows.Forms.CheckBox()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_saveid)
        Me.GroupBox1.Controls.Add(Me.BtnBatal)
        Me.GroupBox1.Controls.Add(Me.BtnLogin)
        Me.GroupBox1.Controls.Add(PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TxPassword)
        Me.GroupBox1.Controls.Add(Me.TxUserName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 221)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'TxPassword
        '
        Me.TxPassword.Location = New System.Drawing.Point(76, 112)
        Me.TxPassword.Name = "TxPassword"
        Me.TxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxPassword.Size = New System.Drawing.Size(168, 20)
        Me.TxPassword.TabIndex = 7
        '
        'TxUserName
        '
        Me.TxUserName.Location = New System.Drawing.Point(75, 86)
        Me.TxUserName.Name = "TxUserName"
        Me.TxUserName.Size = New System.Drawing.Size(168, 20)
        Me.TxUserName.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username :"
        '
        'PictureBox1
        '
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.login
        PictureBox1.ImageLocation = ""
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New System.Drawing.Point(103, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(57, 57)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(16, 161)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(227, 23)
        Me.BtnLogin.TabIndex = 9
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(16, 190)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(227, 23)
        Me.BtnBatal.TabIndex = 10
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'cb_saveid
        '
        Me.cb_saveid.AutoSize = True
        Me.cb_saveid.Location = New System.Drawing.Point(16, 138)
        Me.cb_saveid.Name = "cb_saveid"
        Me.cb_saveid.Size = New System.Drawing.Size(182, 17)
        Me.cb_saveid.TabIndex = 11
        Me.cb_saveid.Text = "Simpan Username dan Password"
        Me.cb_saveid.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxPassword As TextBox
    Friend WithEvents TxUserName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents cb_saveid As CheckBox
End Class
