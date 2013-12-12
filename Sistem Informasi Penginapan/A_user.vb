Public Class A_user
    Protected AccessUser As New AccessData.AccessUser

    Public ID As String
    Dim userlist As New List(Of Entity.Users)

    Private Sub listuser()
        Try
            Dim columns As String() = {"idresepsionis", "username", "first_name", "last_name", "alamat", "telepon"}
            sipModule.FillListWithoutParam(userlist, columns, "usp_Selectuser", GetType(Entity.Users))
            FormatGridWithBothTableAndColumnStyles()
            F_Resepsionis.dgview.DataSource = userlist
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Sistem Informasi Penginapan")
        End Try
    End Sub

    Private Sub FormatGridWithBothTableAndColumnStyles()
        F_Resepsionis.dgview.AutoGenerateColumns = True

    End Sub
    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        Try
            Dim id = txtid.Text
            Dim username = txtuser.Text
            Dim password = txtpass.Text
            Dim alamat = txtalamat.Text
            Dim telepon = txttlp.Text
            Dim firstname = txtfn.Text
            Dim lastname = txtln.Text
            Dim users As New Entity.Users With {.IdResepsionis = id, .Username = username, .Password = password, .alamat = alamat, .telepon = telepon, .First_Name = firstname, .Last_Name = lastname}

            Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ?", "Sistem Informasi Penginapan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = vbYes Then
                AccessUser.UserInsert(users)

                Me.Close()
                F_Resepsionis.Show()
                listuser()
                FormatGridWithBothTableAndColumnStyles()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString())
        End Try


    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        F_Resepsionis.Show()
    End Sub
End Class