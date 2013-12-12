Public Class del_kamar
    Protected Accesskamar As New AccessData.Accesskamar
    Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click
        F_kamar.Close()

        Try
            Dim id = txtid.Text
            Dim kamar As New Entity.kamar With {.Idkamar = id}

            Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ?", "Sistem Informasi Penginapan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = vbYes Then
                Accesskamar.delete(kamar)

                Me.Close()
                Me.Dispose()
                F_kamar.Show()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString())
        End Try

    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        Me.Dispose()
        F_kamar.Show()
    End Sub
End Class