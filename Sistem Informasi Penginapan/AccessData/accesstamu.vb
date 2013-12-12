Imports System.Data
Imports System.Data.OleDb
Namespace AccessData
    Public Class Accesstamu

        Public Function InsertTamu(ByVal tamu As Entity.tamu) As OleDbDataReader

            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("usp_inserttamu", connect)
                        mycommand.CommandType = CommandType.StoredProcedure

                        Dim parameteridtamu As OleDbParameter = New OleDbParameter("@idtamu", OleDbType.VarChar, 15)
                        parameteridtamu.Value = tamu.Idtamu

                        Dim parameternama As OleDbParameter = New OleDbParameter("@nama", OleDbType.VarChar, 15)
                        parameternama.Value = tamu.nama

                        Dim parameteralamat As OleDbParameter = New OleDbParameter("@alamat", OleDbType.VarChar, 15)
                        parameteralamat.Value = tamu.alamat

                        Dim Parameterttl As OleDbParameter = New OleDbParameter("@ttl", OleDbType.VarChar, 50)
                        Parameterttl.Value = tamu.ttl

                        Dim parametercekin As OleDbParameter = New OleDbParameter("@cekin", OleDbType.Date, 15)
                        parametercekin.Value = tamu.cekin

                        Dim parametercekout As OleDbParameter = New OleDbParameter("@cekout", OleDbType.Date, 50)
                        parametercekout.Value = tamu.cekout

                        Dim parametertipe As OleDbParameter = New OleDbParameter("@tipe", OleDbType.VarChar, 50)
                        parametertipe.Value = tamu.tipekamar


                        With mycommand.Parameters
                            .Add(parameteridtamu)
                            .Add(parameternama)
                            .Add(parameteralamat)
                            .Add(Parameterttl)
                            .Add(parametercekin)
                            .Add(parametercekout)
                            .Add(parametertipe)

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

        Public Function TamuUpdate(ByVal tamu As Entity.tamu) As OleDbDataReader
            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("usp_updatetamu", connect)
                        mycommand.CommandType = CommandType.StoredProcedure

                        Dim parameternama As OleDbParameter = New OleDbParameter("@nama", OleDbType.VarChar, 15)
                        parameternama.Value = tamu.nama

                        Dim parameteralamat As OleDbParameter = New OleDbParameter("@alamat", OleDbType.VarChar, 15)
                        parameteralamat.Value = tamu.alamat

                        Dim Parameterttl As OleDbParameter = New OleDbParameter("@ttl", OleDbType.VarChar, 50)
                        Parameterttl.Value = tamu.ttl

                        Dim parametercekin As OleDbParameter = New OleDbParameter("@cekin", OleDbType.Date, 15)
                        parametercekin.Value = tamu.cekin

                        Dim parametercekout As OleDbParameter = New OleDbParameter("@cekout", OleDbType.Date, 50)
                        parametercekout.Value = tamu.cekout

                        Dim parametertipe As OleDbParameter = New OleDbParameter("@tipe", OleDbType.VarChar, 50)
                        parametertipe.Value = tamu.tipekamar

                        Dim parameteridtamu As OleDbParameter = New OleDbParameter("@idtamu", OleDbType.VarChar, 15)
                        parameteridtamu.Value = tamu.Idtamu

                        With mycommand.Parameters
                            .Add(parameternama)
                            .Add(parameteralamat)
                            .Add(Parameterttl)
                            .Add(parametercekin)
                            .Add(parametercekout)
                            .Add(parametertipe)
                            .Add(parameteridtamu)
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


        Public Function Tamudelete(ByVal tamu As Entity.tamu) As OleDbDataReader
            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("usp_deletetamu", connect)
                        mycommand.CommandType = CommandType.StoredProcedure

                        Dim parameterid As OleDbParameter = New OleDbParameter("@idtamu", OleDbType.VarChar, 15)
                        parameterid.Value = tamu.Idtamu

                        With mycommand.Parameters
                            .Add(parameterid)
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

