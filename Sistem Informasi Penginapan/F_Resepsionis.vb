Imports System.Data
Imports System.Data.OleDb
Public Class F_Resepsionis

    Public ID As String
    Dim userlist As New List(Of Entity.Users)
    Private Sub listuser()
        Try
            Dim columns As String() = {"idresepsionis", "username", "first_name", "last_name", "alamat", "telepon"}
            sipModule.FillListWithoutParam(userlist, columns, "usp_Selectuser", GetType(Entity.Users))
            FormatGridWithBothTableAndColumnStyles()
            dgview.DataSource = userlist
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Sistem Informasi Penginapan")
        End Try
    End Sub

    Private Sub FormatGridWithBothTableAndColumnStyles()
        dgview.AutoGenerateColumns = True

        ' Dim makeColumn As New DataGridViewTextBoxColumn()
        'makeColumn.DataPropertyName = "idresepsionis"
        'makeColumn.HeaderText = "ID Resepsionis"
        'makeColumn.Width = 100

        'Dim userColumn As New DataGridViewTextBoxColumn()
        'makeColumn.DataPropertyName = "username"
        'makeColumn.HeaderText = "Username"
        'makeColumn.Width = 100

        'Dim FirstColumn As New DataGridViewTextBoxColumn()
        'FirstColumn.DataPropertyName = "first_name"
        'FirstColumn.HeaderText = "Nama"
        'FirstColumn.Width = 100

        'Dim LastColumn As New DataGridViewTextBoxColumn()
        'LastColumn.DataPropertyName = "last_name"
        'LastColumn.HeaderText = "TTL"
        'LastColumn.Width = 100

        'Dim AddColumn As New DataGridViewTextBoxColumn()
        'AddColumn.DataPropertyName = "alamat"
        'AddColumn.HeaderText = "alamat"
        'AddColumn.Width = 150


        'Dim PhoneColumn As New DataGridViewTextBoxColumn()
        'PhoneColumn.DataPropertyName = "telepon"
        'PhoneColumn.HeaderText = "Phone"
        'PhoneColumn.Width = 150


        '        dgview.Columns.Add(makeColumn)
        '       dgview.Columns.Add(userColumn)
        '      dgview.Columns.Add(FirstColumn)
        '     dgview.Columns.Add(LastColumn)
        '    dgview.Columns.Add(AddColumn)
        '   dgview.Columns.Add(PhoneColumn)

    End Sub

    Private Sub F_Resepsionis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim columns As String() = {"idresepsionis", "username", "first_name", "last_name", "alamat", "telepon"}
            sipModule.FillListWithoutParam(userlist, columns, "usp_Selectuser", _
                                                             GetType(Entity.Users))

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

    Private Sub btntamu_Click(sender As System.Object, e As System.EventArgs) Handles btntamu.Click
        Me.Hide()
        F_tamu.Show()

    End Sub

    Private Sub btnhome_Click(sender As System.Object, e As System.EventArgs) Handles btnhome.Click
        Me.Hide()
        F_Main.Show()

    End Sub

    Private Sub btnlogout_Click(sender As System.Object, e As System.EventArgs) Handles btnlogout.Click
        Me.Close()
        Me.Dispose()
        F_Login.Show()

    End Sub


  
    Private Sub btnadd_Click(sender As System.Object, e As System.EventArgs) Handles btnadd.Click
        A_user.Show()

    End Sub

    Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click

        user_e.Show()
    End Sub

    Private Sub btnresepsionis_Click(sender As System.Object, e As System.EventArgs) Handles btnresepsionis.Click

    End Sub

    Private Sub btndel_Click(sender As System.Object, e As System.EventArgs) Handles btndel.Click
        del_user.Show()

    End Sub
End Class