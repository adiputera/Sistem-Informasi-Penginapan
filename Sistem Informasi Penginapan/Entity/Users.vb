Namespace Entity

    Public Class Users

        Private m_IdResepsionis As String
        Public Property IdResepsionis() As String
            Get
                Return m_IdResepsionis
            End Get

            Set(ByVal value As String)
                If value = "" Then
                    Throw New Exception("Masukkan ID Resepsionis")
                End If
                m_IdResepsionis = value
            End Set
        End Property

        Private m_username As String
        Public Property Username() As String
            Get
                Return m_username
            End Get

            Set(ByVal value As String)
                If value = "" Then
                    Throw New Exception("Masukkan username")
                End If
                m_username = value
            End Set
        End Property

        Private m_password As String
        Public Property Password() As String
            Get
                Return m_password
            End Get

            Set(ByVal value As String)
                If value = "" Then
                    Throw New Exception("Masukkan Password")
                End If
                m_password = value
            End Set
        End Property

        Private m_alamat As String
        Public Property alamat() As String
            Get
                Return m_alamat
            End Get

            Set(ByVal value As String)
                If value = "" Then
                    Throw New Exception("Masukkan alamat")
                End If
                m_alamat = value
            End Set
        End Property

        Private m_telepon As String
        Public Property telepon() As String
            Get
                Return m_telepon
            End Get

            Set(ByVal value As String)
                If value = "" Then
                    Throw New Exception("Masukkan nomor telepon")
                End If
                m_telepon = value
            End Set
        End Property

        Private m_firstname As String
        Public Property First_Name() As String
            Get
                Return m_firstname
            End Get
            Set(ByVal value As String)
                If value = "" Then
                    Throw New Exception("Masukkan First Name")
                End If
                m_firstname = value
            End Set
        End Property

        Private m_lastname As String
        Public Property Last_Name() As String
            Get
                Return m_lastname
            End Get

            Set(ByVal value As String)
                If value = "" Then
                    Throw New Exception("Masukkan Last Name")
                End If
                m_lastname = value
            End Set
        End Property

        Public Property akses() As String
    End Class

End Namespace

