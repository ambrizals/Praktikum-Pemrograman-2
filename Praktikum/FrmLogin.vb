Imports MySql.Data.MySqlClient
Public Class FrmLogin
    Sub kosong()
        TxUserName.Text = ""
        TxPassword.Text = ""
        TxUserName.Focus()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost;" _
& "user id=root;" _
& "password=;" _
& "database=toko")
        conn.Open()
        If conn.State <> ConnectionState.Open Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed")
        Else
            Dim myadapter As New MySqlDataAdapter
            Dim sqlquery = "SELECT * FROM tbladmin where user_name='" +
Trim(TxUserName.Text) + "' And Password='" + Trim(TxPassword.Text) + "'"
            Dim mycommand As New MySqlCommand
            mycommand.Connection = conn
            mycommand.CommandText = sqlquery
            myadapter.SelectCommand = mycommand
            Dim mydata As MySqlDataReader
            mydata = mycommand.ExecuteReader()
            If TxUserName.Text.Count = 0 Then
                MsgBox("Masukkan Username !", MsgBoxStyle.Information, "Info")
            ElseIf TxPassword.Text.Count = 0
                MsgBox("Masukkan Password !", MsgBoxStyle.Information, "Info")
            Else
                If mydata.HasRows = 0 Then
                    MsgBox("Username atau password ada yang salah!", MsgBoxStyle.Exclamation,
                "Error Login")
                    Call kosong()
                Else
                    MsgBox("Login Berhasil", MsgBoxStyle.Information, "Info")
                    MenuForm.Show()
                    If cb_saveid.Checked = False Then
                        Call kosong()
                    End If
                    Me.Hide()
                End If
            End If
        End If

    End Sub
    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub
End Class