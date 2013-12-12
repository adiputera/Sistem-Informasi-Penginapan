Imports System.Data
Imports System.Data.OleDb
Namespace AccessData
    Public Class AccessUser

        Public Function UserInsert(ByVal User As Entity.Users) As OleDbDataReader

            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("usp_insertuser", connect)
                        mycommand.CommandType = CommandType.StoredProcedure

                        Dim parameteridresepsionis As OleDbParameter = New OleDbParameter("@idresepsionis", OleDbType.VarChar, 15)
                        parameteridresepsionis.Value = User.IdResepsionis

                        Dim parameterUserName As OleDbParameter = New OleDbParameter("@UserName", OleDbType.VarChar, 15)
                        parameterUserName.Value = User.Username

                        Dim parameterPassword As OleDbParameter = New OleDbParameter("@Password", OleDbType.VarChar, 15)
                        parameterPassword.Value = User.Password

                        Dim Parameteralamat As OleDbParameter = New OleDbParameter("@alamat", OleDbType.VarChar, 50)
                        Parameteralamat.Value = User.alamat

                        Dim parametertelepon As OleDbParameter = New OleDbParameter("@telepon", OleDbType.VarChar, 15)
                        parametertelepon.Value = User.telepon

                        Dim parameterFirstName As OleDbParameter = New OleDbParameter("@first_name", OleDbType.VarChar, 50)
                        parameterFirstName.Value = User.First_Name

                        Dim parameterLastName As OleDbParameter = New OleDbParameter("@last_name", OleDbType.VarChar, 50)
                        parameterLastName.Value = User.Last_Name

                       
                        With mycommand.Parameters
                            .Add(parameteridresepsionis)
                            .Add(parameterUserName)
                            .Add(parameterPassword)
                            .Add(Parameteralamat)
                            .Add(parametertelepon)
                            .Add(parameterFirstName)
                            .Add(parameterLastName)

                        End With
                        connect.Open()

                        Using result As OleDbDataReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
                            Return result
                        End Using

                    End Using
                End Using
            Catch ex As OleDbException
                Throw New Exception(ex.Message.ToString())
            End Try
           
        End Function

        Public Function UserUpdate(ByVal User As Entity.Users) As OleDbDataReader
            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("usp_updateuser", connect)
                        mycommand.CommandType = CommandType.StoredProcedure

                        Dim parameterPassword As OleDbParameter = New OleDbParameter("@Password", OleDbType.VarChar, 15)
                        parameterPassword.Value = User.Password

                        Dim parameterFirstName As OleDbParameter = New OleDbParameter("@first_name", OleDbType.VarChar, 50)
                        parameterFirstName.Value = User.First_Name

                        Dim parameterLastName As OleDbParameter = New OleDbParameter("@last_name", OleDbType.VarChar, 50)
                        parameterLastName.Value = User.Last_Name

                        Dim Parameteralamat As OleDbParameter = New OleDbParameter("@alamat", OleDbType.VarChar, 50)
                        Parameteralamat.Value = User.alamat

                        Dim parametertelepon As OleDbParameter = New OleDbParameter("@telepon", OleDbType.VarChar, 15)
                        parametertelepon.Value = User.telepon

                        Dim parameterUserName As OleDbParameter = New OleDbParameter("@UserName", OleDbType.VarChar, 15)
                        parameterUserName.Value = User.Username

                        With mycommand.Parameters
                            .Add(parameterPassword)
                            .Add(parameterFirstName)
                            .Add(parameterLastName)
                            .Add(Parameteralamat)
                            .Add(parametertelepon)
                            .Add(parameterUserName)
                        End With
                        connect.Open()

                        Using result As OleDbDataReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
                            Return result
                        End Using

                    End Using
                End Using
            Catch ex As OleDbException
                Throw New Exception(ex.Message.ToString())
            End Try
        End Function

        Public Function login(ByVal username As String) As List(Of Entity.Users)
            Dim user As New List(Of Entity.Users)
            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("usp_selectlogin", connect)
                        mycommand.CommandType = CommandType.StoredProcedure
                        Dim userparameter As OleDbParameter = New OleDbParameter("@username", OleDbType.VarChar)
                        userparameter.Value = username
                        With mycommand.Parameters
                            .Add(userparameter)
                        End With
                        connect.Open()

                        Using rdr As OleDbDataReader = mycommand.ExecuteReader
                            While rdr.Read
                                user.Add(rdr("username").ToString(), rdr("password").ToString(), rdr("akses").ToString())
                            End While

                        End Using
                    End Using
                End Using
            Catch ex As OleDbException
                Throw New Exception(ex.Message.ToString())
            End Try
            Return user
        End Function


        Public Function viewall() As IEnumerable(Of Entity.Users)
            Dim user As New List(Of Entity.Users)()
            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("usp_selectuser", connect)
                        mycommand.CommandType = CommandType.StoredProcedure

                        connect.Open()

                        Using rdr As OleDbDataReader = mycommand.ExecuteReader
                            While rdr.Read
                                user.Add(rdr("first_name").ToString(), _
                                                rdr("alamat").ToString(), _
                                                rdr("telepon").ToString())

                            End While
                        End Using

                    End Using
                End Using
            Catch ex As OleDbException
                Throw New Exception(ex.Message.ToString())
            End Try
            Return user
        End Function

        Public Function max() As Int32
            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("select count(idresepsionis) from user", connect)
                        mycommand.CommandType = CommandType.Text

                        connect.Open()

                        Dim result = Convert.ToInt32(mycommand.ExecuteScalar)
                        Return result
                    End Using
                End Using
            Catch ex As OleDbException
                Throw New Exception(ex.Message.ToString())
            End Try
        End Function

        Public Function cek(ByVal idresepsionis As String) As List(Of Entity.Users)
            Dim user As New List(Of Entity.Users)
            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("usp_userselect", connect)
                        mycommand.CommandType = CommandType.StoredProcedure
                        Dim idparameter As OleDbParameter = New OleDbParameter("@idresepsionis", OleDbType.VarChar)
                        idparameter.Value = idresepsionis
                        With mycommand.Parameters
                            .Add(idparameter)
                        End With
                        connect.Open()

                        Using rdr As OleDbDataReader = mycommand.ExecuteReader
                            While rdr.Read
                                user.Add(rdr("idresepsionis").ToString(), rdr("password").ToString(), rdr("akses").ToString())
                            End While

                        End Using
                    End Using
                End Using
            Catch ex As OleDbException
                Throw New Exception(ex.Message.ToString())
            End Try
            Return user
        End Function

        Public Function Userdelete(ByVal User As Entity.Users) As OleDbDataReader
            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("usp_deleteuser", connect)
                        mycommand.CommandType = CommandType.StoredProcedure

                        Dim parameterUserName As OleDbParameter = New OleDbParameter("@UserName", OleDbType.VarChar, 15)
                        parameterUserName.Value = User.Username

                        With mycommand.Parameters
                            .Add(parameterUserName)
                        End With
                        connect.Open()

                        Using result As OleDbDataReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)
                            Return result
                        End Using

                    End Using
                End Using
            Catch ex As OleDbException
                Throw New Exception(ex.Message.ToString())
            End Try
        End Function
    End Class
End Namespace

