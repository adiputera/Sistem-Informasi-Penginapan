Public Class A_tamu

    Protected Accesstamu As New AccessData.Accesstamu
    Protected Accessuser As New AccessData.Accesstamu
    Protected Accesskamar As New AccessData.Accesskamar

    Public ID As String
    Dim userlist As New List(Of Entity.tamu)
    Dim columns As String() = {}

    ' Private Sub SortID()
    'Dim RoleList As New List(Of Entity.kamar) From {{"0", "- Choice -"}}
    '   sipModule.FillListWithoutParam(RoleList, columns, "select ", _
    '                                                   GetType(Entity.kamar))
    ' cbid.DataSource = RoleList
    'cbid.DisplayMember = "ID Kamar"
    'cbid.ValueMember = "idkamar"
    'End Sub

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


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Try
            Dim id = txtid.Text
            Dim nama = txtnama.Text
            Dim alamat = txtalamat.Text
            Dim ttl = txtttl.Text
            Dim chekin = cekin.Value
            Dim chekout = cekout.Value
            Dim idkamar = txttipe.Text
            Dim users As New Entity.tamu With {.Idtamu = id, .nama = nama, .alamat = alamat, .ttl = ttl, .cekin = chekin, .cekout = chekout, .tipekamar = idkamar}
            Dim kamar As New Entity.kamar With {.Idkamar = idkamar}
            Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ?", "Sistem Informasi Penginapan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = vbYes Then
                Accesstamu.InsertTamu(users)
                Accesskamar.UbahStatus(kamar)

                Me.Close()
                listuser()
                FormatGridWithBothTableAndColumnStyles()

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString())
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class