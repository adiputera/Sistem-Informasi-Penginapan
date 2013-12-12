Imports System.Data
Imports System.Data.OleDb
Public Class F_tamu

    Protected Accessuser As New AccessData.Accesstamu

    Public ID As String
    Dim userlist As New List(Of Entity.tamu)
    

    Private Sub FormatGridWithBothTableAndColumnStyles()
        dgview.AutoGenerateColumns = True

        
    End Sub

    Private Sub F_tamu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim columns As String() = {"idtamu", "nama", "alamat", "ttl", "cekin", "cekout", "tipekamar"}
            sipModule.FillListWithoutParam(userlist, columns, "usp_Selecttamu", _
                                                             GetType(Entity.tamu))

            FormatGridWithBothTableAndColumnStyles()
            dgview.DataSource = userlist
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Sistem Informasi Penginapan")
        End Try
    End Sub

    Private Sub btnkamar_Click(sender As System.Object, e As System.EventArgs) Handles btnkamar.Click
        Me.Hide()

        F_kamar.Show()

    End Sub

    Private Sub btnhome_Click(sender As System.Object, e As System.EventArgs) Handles btnhome.Click
        Me.Hide()

        F_Main.Show()

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

    Private Sub btnadd_Click(sender As System.Object, e As System.EventArgs) Handles btnadd.Click
        A_tamu.Show()

    End Sub

    Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click
        s_tamu.Show()
    End Sub

    Private Sub btndel_Click(sender As System.Object, e As System.EventArgs) Handles btndel.Click
        del_tamu.Show()
    End Sub
End Class