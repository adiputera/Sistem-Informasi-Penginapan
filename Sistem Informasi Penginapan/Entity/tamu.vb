Namespace Entity
    Public Class tamu
        Private m_idtamu
        Public Property Idtamu() As String
            Get
                Return m_idtamu
            End Get
            Set(ByVal value As String)
                If value = "" Then
                    Throw New Exception("Masukkan Id tamu")
                End If
                m_idtamu = value
            End Set
        End Property

        Private m_nama
        Public Property nama() As String
            Get
                Return m_nama
            End Get
            Set(ByVal value As String)
                If value = "" Then
                    Throw New Exception("masukkan nama")
                End If
                m_nama = value
            End Set
        End Property

        Private m_alamat
        Public Property alamat() As String
            Get
                Return m_alamat
            End Get
            Set(ByVal value As String)
                If value = "" Then
                    Throw New Exception("Masukkan biaya")
                End If
                m_alamat = value
            End Set
        End Property

        Private m_ttl
        Public Property ttl() As String
            Get
                Return m_ttl
            End Get
            Set(ByVal value As String)
                If value = "" Then
                    Throw New Exception("Masukkan tempat tanggal lahir")
                End If
                m_ttl = value
            End Set
        End Property

        Private m_cekin
        Public Property cekin() As Date
            Get
                Return m_cekin
            End Get
            Set(ByVal value As Date)
                'If value = "" Then
                'Throw New Exception("Masukkan tanggal cekin")
                'End If
                m_cekin = value
            End Set
        End Property

        Private m_cekout
        Public Property cekout() As Date
            Get
                Return m_cekout
            End Get
            Set(ByVal value As Date)
                'If value = "" Then
                'Throw New Exception("Masukkan tanggal cekout")
                'End If
                m_cekout = value
            End Set
        End Property


        Public Property tipekamar() As String



    End Class
End Namespace