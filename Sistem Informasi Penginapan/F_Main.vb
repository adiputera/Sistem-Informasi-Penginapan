Public Class F_Main

    Private Sub btnkamar_Click(sender As System.Object, e As System.EventArgs) Handles btnkamar.Click
        Me.Hide()

        F_kamar.Show()

    End Sub

    Private Sub btntamu_Click(sender As System.Object, e As System.EventArgs) Handles btntamu.Click
        Me.Hide()

        F_tamu.Show()

    End Sub

    Private Sub btnresepsionis_Click(sender As System.Object, e As System.EventArgs) Handles btnresepsionis.Click
        Me.Hide()

        F_Resepsionis.Show()

    End Sub

    Private Sub btnlogout_Click(sender As System.Object, e As System.EventArgs) Handles btnlogout.Click
        Me.Close()
        Me.Dispose()
        F_Login.Show()

    End Sub
End Class