Public Class FormUtama

    Private Sub FormUtama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            e.Cancel = False 'Lanjutkan menutup form
        Else
            e.Cancel = True 'Tidak menutup form
        End If
    End Sub

End Class
