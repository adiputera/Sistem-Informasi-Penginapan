Public Class user_e

    Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click


        Try
            If txtid.Text = "" Then
                MsgBox("Masukkan ID Resepsionis", MsgBoxStyle.Information, "Sistem Informasi Penginapan")
                Exit Sub
            End If
            Dim RoleList As New List(Of Entity.Users)
            Dim Coltype As System.Data.OleDb.OleDbType() = {System.Data.OleDb.OleDbType.VarChar}
            Dim FieldName As String() = {"@username"}
            Dim Size As Integer() = {15}
            Dim Value As String() = {txtid.Text}
            Dim columns As String() = {"username"}
            sipModule.FillListWithParam(RoleList, columns, "usp_selectlogin", _
                                                             GetType(Entity.Users), FieldName, _
                                                             Coltype, Size, Value)
            If RoleList.Count = 0 Then
                MsgBox("ID salah")
                Exit Sub
            End If

            ee_user.lbluser.Text = txtid.Text

            ee_user.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Sistem Informasi Penginapan")
        End Try
    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        F_Resepsionis.Show()
    End Sub

   
End Class