Public Class s_tamu

    Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click

        Try
            If txtid.Text = "" Then
                MsgBox("Masukkan ID Tamu", MsgBoxStyle.Information, "Sistem Informasi Penginapan")
                Exit Sub
            End If
            Dim RoleList As New List(Of Entity.tamu)
            Dim Coltype As System.Data.OleDb.OleDbType() = {System.Data.OleDb.OleDbType.VarChar}
            Dim FieldName As String() = {"@idtamu"}
            Dim Size As Integer() = {15}
            Dim Value As String() = {txtid.Text}
            Dim columns As String() = {"idtamu"}
            sipModule.FillListWithParam(RoleList, columns, "usp_selecttamu", _
                                                             GetType(Entity.tamu), FieldName, _
                                                             Coltype, Size, Value)
            If RoleList.Count = 0 Then
                MsgBox("ID salah")
                Exit Sub
            End If

            e_tamu.lbluser.Text = txtid.Text
            e_tamu.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Sistem Informasi Penginapan")
        End Try
    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class