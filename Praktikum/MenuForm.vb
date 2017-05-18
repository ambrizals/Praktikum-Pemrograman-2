Public Class MenuForm

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub

    Private Sub FormKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormKaryawanToolStripMenuItem.Click
        FrmKaryawan.ShowDialog()

    End Sub

    Private Sub KaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaryawanToolStripMenuItem.Click
        FormLaporanKaryawan.ShowDialog()

    End Sub
End Class