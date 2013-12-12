Public Class e_tamu
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

    
 
    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click

        Try
            Dim nama = txtnama.Text
            Dim alamat = txtalamat.Text
            Dim ttl = txtttl.Text
            Dim tipe = txttipe.Text
            Dim chekin = cekin.Value
            Dim chekout = cekout.Value
            Dim id = lbluser.Text
            Dim tamu As New Entity.tamu With {.nama = nama, .alamat = alamat, .ttl = ttl, .tipekamar = tipe, .cekin = chekin, .cekout = chekout, .Idtamu = id}
            Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ?", "Sistem Informasi Penginapan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = vbYes Then
                Accesstamu.TamuUpdate(tamu)

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

    End Sub
End Class