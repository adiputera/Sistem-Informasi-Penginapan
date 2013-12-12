Namespace Entity
    Public Class kamar
        Private m_idkamar
        Public Property Idkamar() As String
            Get
                Return m_idkamar
            End Get
            Set(ByVal value As String)
                If value = "" Then
                    Throw New Exception("Masukkan Id Kamar")
                End If
                m_idkamar = value
            End Set
        End Property

        Private m_tipe
        Public Property tipe() As String
            Get
                Return m_tipe
            End Get
            Set(ByVal value As String)
                If value = "" Then
                    Throw New Exception("tipe")
                End If
                m_tipe = value
            End Set
        End Property

        Private m_biaya
        Public Property biaya() As Decimal
            Get
                Return m_biaya
            End Get
            Set(ByVal value As Decimal)
                ' If value = "" Then
                'Throw New Exception("Masukkan biaya")
                'End If
                m_biaya = value
            End Set
        End Property


        Public Property statussewa() As Boolean
           


    End Class
End Namespace