Public Class del_tamu
    Protected Accesstamu As New AccessData.Accesstamu

    Public ID As String
    Dim userlist As New List(Of Entity.tamu)
    Private Sub listuser()
        Try
            Dim columns As String() = {"idtamu", "nama", "alamat", "ttl", "cekin", "cekout", "tipekamar"}
            sipModule.FillListWithoutParam(userlist, columns, "usp_Selecttamu", GetType(Entity.tamu))
            FormatGridWithBothTableAndColumnStyles()
            F_tamu.dgview.DataSource = userlist
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Sistem Informasi Penginapan")
        End Try
    End Sub

    Private Sub FormatGridWithBothTableAndColumnStyles()
        F_tamu.dgview.AutoGenerateColumns = True


    End Sub
    Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click


        Try
            Dim id = txtid.Text
            Dim tamu As New Entity.tamu With {.Idtamu = id}

            Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ?", "Sistem Informasi Penginapan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = vbYes Then
                Accesstamu.Tamudelete(tamu)

                Me.Close()
                Me.Dispose()
                listuser()
                FormatGridWithBothTableAndColumnStyles()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        Me.Dispose()
        F_tamu.Show()
    End Sub
End Class