Public Class F_Login




    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Dim AccessUser As New AccessData.AccessUser
            Dim user As New Entity.Users
            user.Username = txtUser.Text
            user.Password = txtPassword.Text

            Dim list As List(Of Entity.Users) = AccessUser.Login(txtUser.Text)
            'jika isi list kosong
            If list.Count = 0 Then
                MsgBox("Username Salah", MsgBoxStyle.Information, "Sistem Informasi Penginapan")
                txtUser.Focus()
                txtUser.SelectAll()
                Exit Sub
            End If

            Dim username = list.Item(0).username
            Dim password = list.Item(0).password
            Dim akses = list.Item(0).akses
            If txtPassword.Text <> password Then
                MsgBox("Password Salah", MsgBoxStyle.Information, "Sistem Informasi Penginapan")
                txtPassword.Focus()
                txtPassword.SelectAll()
                Exit Sub
            End If

            If akses = "admin" Then
                F_Main.btnhome.Visible = True
                F_Main.btnkamar.Visible = True
                F_Main.btntamu.Visible = True
                F_Main.btnresepsionis.Visible = True
                F_Main.btnlogout.Visible = True

                F_kamar.btnhome.Visible = True
                F_kamar.btnkamar.Visible = True
                F_kamar.btntamu.Visible = True
                F_kamar.btnresepsionis.Visible = True
                F_kamar.btnlogout.Visible = True
                F_kamar.Btnadd.Visible = True
                F_kamar.btnedit.Visible = True
                F_kamar.btndel.Visible = True


                F_tamu.btnhome.Visible = True
                F_tamu.btnkamar.Visible = True
                F_tamu.btntamu.Visible = True
                F_tamu.btnresepsionis.Visible = True
                F_tamu.btnlogout.Visible = True

                F_Resepsionis.btnhome.Visible = True
                F_Resepsionis.btnkamar.Visible = True
                F_Resepsionis.btntamu.Visible = True
                F_Resepsionis.btnresepsionis.Visible = True
                F_Resepsionis.btnlogout.Visible = True

            ElseIf akses = "user" Then
                F_Main.btnhome.Visible = True
                F_Main.btnkamar.Visible = True
                F_Main.btntamu.Visible = True
                F_Main.btnresepsionis.Visible = False
                F_Main.btnlogout.Visible = True

                F_kamar.btnhome.Visible = True
                F_kamar.btnkamar.Visible = True
                F_kamar.btntamu.Visible = True
                F_kamar.btnresepsionis.Visible = False
                F_kamar.btnlogout.Visible = True
                F_kamar.Btnadd.Visible = False
                F_kamar.btnedit.Visible = False
                F_kamar.btndel.Visible = False

                F_tamu.btnhome.Visible = True
                F_tamu.btnkamar.Visible = True
                F_tamu.btntamu.Visible = True
                F_tamu.btnresepsionis.Visible = False
                F_tamu.btnlogout.Visible = True

                F_Resepsionis.btnhome.Visible = True
                F_Resepsionis.btnkamar.Visible = True
                F_Resepsionis.btntamu.Visible = True
                F_Resepsionis.btnresepsionis.Visible = True
                F_Resepsionis.btnlogout.Visible = True
            End If

            F_Main.Show()
            Me.Close()
            Me.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Sistem Informasi Penginapan")
        End Try

    End Sub

    Private Sub txtPassword_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    
End Class