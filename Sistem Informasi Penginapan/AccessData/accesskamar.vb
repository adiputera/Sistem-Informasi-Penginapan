Imports System.Data
Imports System.Data.OleDb
Namespace AccessData
    Public Class Accesskamar
        Public Function tambah(ByVal kamar As Entity.kamar) As OleDbDataReader
            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("INSERT INTO kamar (IDkamar, tipe, biaya) VALUES ([@idkamar], [@tipe], [@biaya])", connect)
                        mycommand.CommandType = CommandType.Text

                        Dim idparameter As OleDbParameter = New OleDbParameter("@idkamar", OleDbType.VarChar, 20)
                        idparameter.Value = kamar.Idkamar

                        Dim tipeparameter As OleDbParameter = New OleDbParameter("@tipe", OleDbType.VarChar, 30)
                        tipeparameter.Value = kamar.tipe

                        Dim biayaparameter As OleDbParameter = New OleDbParameter("@biaya", OleDbType.Integer, 30)
                        biayaparameter.Value = kamar.biaya

                        With mycommand.Parameters
                            .Add(idparameter)
                            .Add(tipeparameter)
                            .Add(biayaparameter)
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

        Public Function edit(ByVal kamar As Entity.kamar) As OleDbDataReader
            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("usp_updatekamar", connect)
                        mycommand.CommandType = CommandType.StoredProcedure

                        Dim idparameter As OleDbParameter = New OleDbParameter("@idkamar", OleDbType.VarChar, 20)
                        idparameter.Value = kamar.Idkamar

                        Dim tipeparameter As OleDbParameter = New OleDbParameter("@tipe", OleDbType.VarChar, 30)
                        tipeparameter.Value = kamar.tipe

                        Dim biayaparameter As OleDbParameter = New OleDbParameter("@biaya", OleDbType.Integer, 30)
                        biayaparameter.Value = kamar.biaya

                        With mycommand.Parameters
                            .Add(idparameter)
                            .Add(tipeparameter)
                            .Add(biayaparameter)
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

        Public Function delete(ByVal kamar As Entity.kamar) As OleDbDataReader
            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("usp_deletekamar", connect)
                        mycommand.CommandType = CommandType.StoredProcedure

                        Dim idparameter As OleDbParameter = New OleDbParameter("@idkamar", OleDbType.VarChar, 20)
                        idparameter.Value = kamar.Idkamar

                        With mycommand.Parameters
                            .Add(idparameter)
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

        Public Function UbahStatus(ByVal kamar As Entity.kamar) As OleDbDataReader
            Try
                Using connect As New OleDbConnection(My.Settings.sipdb)
                    Using mycommand As OleDbCommand = New OleDbCommand("UPDATE kamar SET statussewa='1' WHERE idKamar = @idKamar ", connect)
                        mycommand.CommandType = CommandType.Text

                        Dim idparameter As OleDbParameter = New OleDbParameter("@idkamar", OleDbType.VarChar, 20)
                        idparameter.Value = kamar.Idkamar

                        With mycommand.Parameters
                            .Add(idparameter)
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

