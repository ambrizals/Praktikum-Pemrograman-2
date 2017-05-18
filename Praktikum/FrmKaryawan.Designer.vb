<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmKaryawan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtNmKar = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.TxtTelp = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.DGKaryawan = New System.Windows.Forms.DataGridView()
        Me.btncari = New System.Windows.Forms.Button()
        CType(Me.DGKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Karyawan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Karyawan :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telepon :"
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(115, 11)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(471, 20)
        Me.TxtKode.TabIndex = 1
        '
        'TxtNmKar
        '
        Me.TxtNmKar.Location = New System.Drawing.Point(115, 36)
        Me.TxtNmKar.Name = "TxtNmKar"
        Me.TxtNmKar.Size = New System.Drawing.Size(316, 20)
        Me.TxtNmKar.TabIndex = 2
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Enabled = False
        Me.TxtAlamat.Location = New System.Drawing.Point(115, 60)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(471, 20)
        Me.TxtAlamat.TabIndex = 4
        '
        'TxtTelp
        '
        Me.TxtTelp.Enabled = False
        Me.TxtTelp.Location = New System.Drawing.Point(115, 85)
        Me.TxtTelp.Name = "TxtTelp"
        Me.TxtTelp.Size = New System.Drawing.Size(471, 20)
        Me.TxtTelp.TabIndex = 5
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(13, 112)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(127, 40)
        Me.BtnSimpan.TabIndex = 6
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Location = New System.Drawing.Point(146, 112)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(137, 40)
        Me.BtnUbah.TabIndex = 9
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(289, 112)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(154, 40)
        Me.BtnHapus.TabIndex = 10
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBatal.Location = New System.Drawing.Point(449, 112)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(137, 40)
        Me.BtnBatal.TabIndex = 11
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'DGKaryawan
        '
        Me.DGKaryawan.AllowUserToAddRows = False
        Me.DGKaryawan.AllowUserToDeleteRows = False
        Me.DGKaryawan.AllowUserToResizeColumns = False
        Me.DGKaryawan.AllowUserToResizeRows = False
        Me.DGKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKaryawan.Location = New System.Drawing.Point(13, 158)
        Me.DGKaryawan.MultiSelect = False
        Me.DGKaryawan.Name = "DGKaryawan"
        Me.DGKaryawan.ReadOnly = True
        Me.DGKaryawan.RowHeadersVisible = False
        Me.DGKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGKaryawan.Size = New System.Drawing.Size(573, 216)
        Me.DGKaryawan.TabIndex = 12
        '
        'btncari
        '
        Me.btncari.Enabled = False
        Me.btncari.Location = New System.Drawing.Point(437, 36)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(149, 20)
        Me.btncari.TabIndex = 3
        Me.btncari.Text = "Search"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'FrmKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 386)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.DGKaryawan)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TxtTelp)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.TxtNmKar)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FrmKaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Karyawan"
        CType(Me.DGKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtKode As System.Windows.Forms.TextBox
    Friend WithEvents TxtNmKar As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelp As System.Windows.Forms.TextBox
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents DGKaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents btncari As Button
End Class
