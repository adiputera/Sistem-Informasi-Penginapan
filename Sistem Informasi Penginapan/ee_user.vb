Public Class ee_user
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

    Private Sub ViewUser()
        Dim list As List(Of Entity.Users) = AccessUser.login(lbluser.Text)
        txtpass.Text = list.First.Password
        txtfn.Text = list.First.First_Name
        txtln.Text = list.First.Last_Name
        txtalamat.Text = list.First.alamat
        txttlp.Text = list.First.telepon
    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim password = txtpass.Text
            Dim alamat = txtalamat.Text
            Dim telepon = txttlp.Text
            Dim firstname = txtfn.Text
            Dim lastname = txtln.Text
            Dim username = lbluser.Text
            Dim users As New Entity.Users With {.Password = password, .alamat = alamat, .telepon = telepon, .First_Name = firstname, .Last_Name = lastname, .Username = username}

            Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ?", "Sistem Informasi Penginapan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = vbYes Then
                AccessUser.UserUpdate(users)

                Me.Close()
                Me.Dispose()
                listuser()
                FormatGridWithBothTableAndColumnStyles()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString())
        End Try

        F_Resepsionis.Show()

    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        F_Resepsionis.Show()
    End Sub
End Class