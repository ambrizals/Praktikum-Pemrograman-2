Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class FrmKaryawan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblKaryawan As DataTable

    Sub Data_Record()
        tblKaryawan = Proses.ExecuteQuery("Select * From TblKaryawan")
        DGKaryawan.DataSource = tblKaryawan
        DGKaryawan.Columns(0).Width = 75
        DGKaryawan.Columns(1).Width = 100
        DGKaryawan.Columns(2).Width = 295.2
        DGKaryawan.Columns(3).Width = 100
    End Sub

    Sub Data_Edit()
        tblKaryawan = Proses.ExecuteQuery("Select * From TblKaryawan where ID_Karyawan ='" & TxtKode.Text & "'")
        DGKaryawan.DataSource = tblKaryawan
        DGKaryawan.Columns(0).Width = 75
        DGKaryawan.Columns(1).Width = 100
        DGKaryawan.Columns(2).Width = 295.2
        DGKaryawan.Columns(3).Width = 100
    End Sub

    Sub Kode_Otomatis()
        tblKaryawan = Proses.ExecuteQuery("Select * From TblKaryawan order by ID_Karyawan desc")
        If tblKaryawan.Rows.Count = 0 Then
            TxtKode.Text = "KRY-001"
        Else
            With tblKaryawan.Rows(0)
                TxtKode.Text = .Item("ID_Karyawan")
            End With
            TxtKode.Text = Val(Microsoft.VisualBasic.Mid(TxtKode.Text, 5, 3)) + 1
            If Len(TxtKode.Text) = 1 Then
                TxtKode.Text = "KRY-00" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 2 Then
                TxtKode.Text = "KRY-0" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 3 Then
                TxtKode.Text = "KRY-" & TxtKode.Text & ""
            End If
        End If
    End Sub

    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        TxtKode.Enabled = False
        TxtNmKar.ReadOnly = False
        TxtNmKar.Text = ""
        TxtAlamat.Text = ""
        TxtTelp.Text = ""
        TxtNmKar.Focus()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtNmKar.Text = "" Then
            MsgBox("Data Nama Karyawan Belum Terisi", MsgBoxStyle.Critical, "Error")
            TxtNmKar.Focus()
        ElseIf TxtAlamat.Text = "" Then
            MsgBox("Data Alamat Karyawan Belum Terisi", MsgBoxStyle.Critical, "Error")
            TxtAlamat.Focus()
        ElseIf TxtTelp.Text = "" Then
            MsgBox("Data Nomor Telepon Karyawan Belum Terisi", MsgBoxStyle.Critical, "Error")
            TxtTelp.Focus()
        Else
            SQL = "Insert Into Tblkaryawan Values ('" & TxtKode.Text & "','" & TxtNmKar.Text & "', '" & TxtAlamat.Text & "','" & TxtTelp.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Atur()
        End If
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If TxtNmKar.Text = "" Then TxtNmKar.Focus() : Exit Sub
        'Inisialisasi variabel
        Dim alamat_karyawan_old, telp_karyawan_old As String
        Dim alamat_karyawan_new, telp_karyawan_new As String
        'Ambil data lama dari datagridview
        alamat_karyawan_old = DGKaryawan.SelectedCells(2).Value
        telp_karyawan_old = DGKaryawan.SelectedCells(3).Value
        'Ambil data baru dari textbox
        alamat_karyawan_new = TxtAlamat.Text
        telp_karyawan_new = TxtTelp.Text

        'Validasi data yang sama
        If telp_karyawan_old = telp_karyawan_new And alamat_karyawan_old = alamat_karyawan_new Then
            MsgBox("Tidak ada perubahan", MsgBoxStyle.Information, "Info")
        Else
            'Proses dieksekusi jika data yang diinput telah berbeda
            SQL = "update tblkaryawan set Nama_Karyawan = '" & TxtNmKar.Text & "', alamat = '" & TxtAlamat.Text & "', Telepon = '" & TxtTelp.Text & "' where ID_Karyawan = '" & TxtKode.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data sudah diperbaiki...!!", "Perubahan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Atur()
        End If
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        'Konfirmasi penghapusan
        If MsgBox("Apakah ingin menghapus data ini ?", MsgBoxStyle.OkCancel, "Konfirmasi !") = MsgBoxResult.Ok Then
            SQL = "delete from tblkaryawan where ID_Karyawan = '" & TxtKode.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data sudah dihapus...!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Atur()
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        If TxtNmKar.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub DGKaryawan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGKaryawan.DoubleClick
        TxtKode.Text = DGKaryawan.SelectedCells(0).Value
        TxtNmKar.Text = DGKaryawan.SelectedCells(1).Value
        TxtAlamat.Text = DGKaryawan.SelectedCells(2).Value
        TxtTelp.Text = DGKaryawan.SelectedCells(3).Value
        TxtNmKar.ReadOnly = True
        BtnUbah.Enabled = True
        BtnHapus.Enabled = True
        BtnSimpan.Enabled = False
        Call Data_Edit()

    End Sub


    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        If TxtNmKar.Text = "" Then TxtNmKar.Focus() : Exit Sub
        tblKaryawan = Proses.ExecuteQuery("select * from tblkaryawan where nama_karyawan like '%" & TxtNmKar.Text & "%' ")
        DGKaryawan.DataSource = tblKaryawan
        If DGKaryawan.RowCount.ToString = "0" Then
            Call Atur()
            MsgBox("Data tidak ditemukan", MsgBoxStyle.Information, "Error")
        Else
            DGKaryawan.DataSource = tblKaryawan
        End If
        TxtNmKar.Focus()
        TxtAlamat.Text = ""
        TxtTelp.Text = ""
    End Sub

    Private Sub TxtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAlamat.KeyPress
        If DGKaryawan.RowCount > 0 Then
            btncari.Enabled = False
        End If
    End Sub

    Private Sub TxtNmKar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNmKar.KeyPress
        If DGKaryawan.RowCount > 0 Then
            btncari.Enabled = True
        End If
    End Sub

    Private Sub FrmKaryawan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Atur()
    End Sub

    Private Sub TxtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelp.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


End Class
Public Class ClsKoneksi
    Protected SQL As String
    Protected Cn As New MySqlConnection
    Protected Cmd As New MySql.Data.MySqlClient.MySqlCommand
    Protected Da As New MySql.Data.MySqlClient.MySqlDataAdapter
    Protected Ds As New DataSet
    Protected Dt As DataTable
    Public Function OpenConn() As Boolean
        Cn = New MySqlConnection("server=localhost;" _
            & "user id=root;" _
            & "password=123456;" _
            & "database=toko")
        Cn.Open()
        If Cn.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub CloseConn()
        If Not IsNothing(Cn) Then
            Cn.Close()
            Cn = Nothing
        End If
    End Sub
    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed")
            Return Nothing
            Exit Function
        End If
        Cmd = New MySql.Data.MySqlClient.MySqlCommand(Query, Cn)
        Da = New MySql.Data.MySqlClient.MySqlDataAdapter
        Da.SelectCommand = Cmd
        Ds = New Data.DataSet
        Da.Fill(Ds)
        Dt = Ds.Tables(0)
        Return Dt
        Dt = Nothing
        Ds = Nothing
        Da = Nothing
        Cmd = Nothing
        CloseConn()
    End Function
    Public Sub ExecuteNonQuery(ByVal Query As String)
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed..!!")
            Exit Sub
        End If
        Cmd = New MySql.Data.MySqlClient.MySqlCommand
        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = Query
        Cmd.ExecuteNonQuery()
        Cmd = Nothing
        CloseConn()
    End Sub

End Class
