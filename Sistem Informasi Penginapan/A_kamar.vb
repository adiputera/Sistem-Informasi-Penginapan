Public Class A_kamar
    Protected Accesskamar As New AccessData.Accesskamar

    Public ID As String
    Dim kamarlist As New List(Of Entity.kamar)

    Private Sub listkamar()
        Try
            Dim columns As String() = {"IdKamar", "tipe", "biaya", "statussewa"}
            sipModule.FillListWithoutParam(kamarlist, columns, "usp_selectkamar", GetType(Entity.kamar))
            FormatGridWithBothTableAndColumnStyles()
            F_kamar.dgview.DataSource = kamarlist
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Sistem Informasi Penginapan")
        End Try
    End Sub

    Private Sub FormatGridWithBothTableAndColumnStyles()
        F_kamar.dgview.AutoGenerateColumns = False

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




        F_kamar.dgview.Columns.Add(makeColumn)
        F_kamar.dgview.Columns.Add(FirstColumn)
        F_kamar.dgview.Columns.Add(LastColumn)
        F_kamar.dgview.Columns.Add(AddColumn)


    End Sub
    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click

        Try
            Dim id = txtid.Text
            Dim tipe = cbtipe.Text
            Dim biaya = txtbiaya.Text
            Dim barang As New Entity.kamar With {.Idkamar = id, .tipe = tipe, .biaya = biaya}

            Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ?", "Sistem Informasi Penginapan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = vbYes Then
                Accesskamar.tambah(barang)
                Me.Close()
                listkamar()
                FormatGridWithBothTableAndColumnStyles()

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class