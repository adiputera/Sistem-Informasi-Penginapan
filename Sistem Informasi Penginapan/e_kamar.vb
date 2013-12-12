Public Class e_kamar
    Protected Accesskamar As New AccessData.Accesskamar


    Private Sub Clear()
        Dim C As Control
        Dim T As TextBox
        For Each C In Me.gb.Controls
            If TypeOf C Is TextBox Then
                T = CType(C, TextBox)
                T.Text = ""
            End If
        Next

    End Sub

   
    Private Sub e_kamar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        F_kamar.Close()
        Try
            Dim id = txtid.Text
            Dim tipe = txttipe.Text
            Dim biaya = txtbiaya.Text
            Dim kamar As New Entity.kamar With {.Idkamar = id, .tipe = tipe, .biaya = biaya}

            Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ?", "Sistem Informasi Penginapan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = vbYes Then
                Accesskamar.edit(kamar)

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
        F_kamar.Show()

    End Sub
End Class