Public Class F_kamar

    Public ID As String
    Dim kamarlist As New List(Of Entity.kamar)
    Private Sub listkamar()
        Try
            Dim columns As String() = {"IdKamar", "tipe", "biaya", "statussewa"}
            sipModule.FillListWithoutParam(kamarlist, columns, "usp_selectkamar", GetType(Entity.Users))
            FormatGridWithBothTableAndColumnStyles()
            dgview.DataSource = kamarlist
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Sistem Informasi Penginapan")
        End Try
    End Sub

    Private Sub FormatGridWithBothTableAndColumnStyles()
        dgview.AutoGenerateColumns = False

        Dim makeColumn As New DataGridViewTextBoxColumn()
        makeColumn.DataPropertyName = "IdKamar"
        makeColumn.HeaderText = "ID kamar"
        makeColumn.Width = 80

        Dim FirstColumn As New DataGridViewTextBoxColumn()
        FirstColumn.DataPropertyName = "tipe"
        FirstColumn.HeaderText = "Tipe"
        FirstColumn.Width = 100

        Dim LastColumn As New DataGridViewTextBoxColumn()
        LastColumn.DataPropertyName = "biaya"
        LastColumn.HeaderText = "Biaya"
        LastColumn.Width = 100

        Dim AddColumn As New DataGridViewTextBoxColumn()
        AddColumn.DataPropertyName = "statussewa"
        AddColumn.HeaderText = "sewa"
        AddColumn.Width = 150




        dgview.Columns.Add(makeColumn)
        dgview.Columns.Add(FirstColumn)
        dgview.Columns.Add(LastColumn)
        dgview.Columns.Add(AddColumn)


    End Sub

    Private Sub F_kamar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim columns As String() = {"IdKamar", "tipe", "biaya", "statussewa"}
            sipModule.FillListWithoutParam(kamarlist, columns, "usp_selectkamar", _
                                                             GetType(Entity.kamar))

            FormatGridWithBothTableAndColumnStyles()
            dgview.DataSource = kamarlist
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Sistem Informasi Penginapan")
        End Try
    End Sub

    Private Sub DgView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim row As DataGridViewRow = dgview.Rows(e.RowIndex)
        ID = row.Cells(0).Value
        Me.Close()
    End Sub

    Protected Accesskamar As New AccessData.Accesskamar

    Private Sub btnhome_Click(sender As System.Object, e As System.EventArgs) Handles btnhome.Click
        Me.Hide()
        F_Main.Show()

    End Sub

    Private Sub btntamu_Click(sender As System.Object, e As System.EventArgs) Handles btntamu.Click
        Me.Hide()
        F_tamu.Show()

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

    Private Sub Btnadd_Click(sender As System.Object, e As System.EventArgs) Handles Btnadd.Click
        A_kamar.Show()

    End Sub

    Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click
        s_kamar.Show()

    End Sub

    Private Sub btndel_Click(sender As System.Object, e As System.EventArgs) Handles btndel.Click
        del_kamar.Show()

    End Sub
End Class