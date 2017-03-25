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
        DGKaryawan.Columns(2).Width = 255
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
        TxtNmKar.Text = ""
        TxtAlamat.Text = ""
        TxtTelp.Text = ""
        TxtNmKar.Focus()
    End Sub

    Private Sub FrmKaryawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TokoDataSet.tblkaryawan' table. You can move, or remove it, as needed.
        Me.TblkaryawanTableAdapter.Fill(Me.TokoDataSet.tblkaryawan)
        Call Atur()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtNmKar.Text = "" Then TxtNmKar.Focus() : Exit Sub
        SQL = "Insert Into Tblkaryawan Values ('" & TxtKode.Text & "','" & TxtNmKar.Text & "', '" & TxtAlamat.Text & "','" & TxtTelp.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Atur()

    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If TxtNmKar.Text = "" Then TxtNmKar.Focus() : Exit Sub
        SQL = "update tblkaryawan set Nama_Karyawan = '" & TxtNmKar.Text & "', alamat = '" & TxtAlamat.Text & "', Telepon = '" & TxtTelp.Text & "' where ID_Karyawan = '" & TxtKode.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data sudah diperbaiki...!!", "Perubahan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Atur()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        SQL = "delete from tblkaryawan where ID_Karyawan = '" & TxtKode.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data sudah dihapus...!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Atur()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Call Atur()
    End Sub

    Private Sub DGKaryawan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGKaryawan.DoubleClick
        TxtKode.Text = DGKaryawan.SelectedCells(0).Value
        TxtNmKar.Text = DGKaryawan.SelectedCells(1).Value
        BtnUbah.Enabled = True
        BtnHapus.Enabled = True
        BtnSimpan.Enabled = False
    End Sub

    'Private Sub DGKaryawan_Click(sender As Object, e As EventArgs) Handles DGKaryawan.Click
    'Dim barkom As Integer
    'With DGKaryawan
    '       barkom = .CurrentRow.Index

    '      TxtKode.Text = .Item(0, barkom).Value
    '      TxtNmKar.Text = .Item(1, barkom).Value
    '      TxtAlamat.Text = .Item(2, barkom).Value
    '      TxtTelp.Text = .Item(3, barkom).Value
    'End With
    '  BtnUbah.Enabled = True
    ''  BtnHapus.Enabled = True
    ' BtnSimpan.Enabled = False
    '    btncari.Enabled = False
    'End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        If TxtNmKar.Text = "" Then TxtNmKar.Focus() : Exit Sub
        tblKaryawan = Proses.ExecuteQuery("select * from tblkaryawan where nama_karyawan like '%" & TxtNmKar.Text & "%' ")
        DGKaryawan.DataSource = tblKaryawan
        TxtNmKar.Focus()
        TxtAlamat.Text = ""
        TxtTelp.Text = ""
    End Sub

    Private Sub TxtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAlamat.KeyPress
        btncari.Enabled = False
    End Sub

    Private Sub TxtNmKar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNmKar.KeyPress
        btncari.Enabled = True

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
