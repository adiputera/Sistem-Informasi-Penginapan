Imports System.Data
Imports System.Data.OleDb
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices

Module sipModule
    Public Operate, FormShow, UserName, Password As String



#Region "Process"

    Public Function GetLeftRightItemFromControl(ByVal Teks As String) As String()
        '//cari item kiri dari teks
        Dim intPanjangString As Integer
        Dim intPosisiDash As Integer
        intPanjangString = Strings.Len(Teks)
        intPosisiDash = Teks.IndexOf(">")
        Dim strID As String = Trim(Strings.Left(Teks, intPosisiDash - 1))
        Dim strNama As String = Trim(Strings.Mid(Teks, intPosisiDash + 2, intPanjangString - intPosisiDash + 2))
        Dim arrString As String() = {strID, strNama}
        Return arrString
    End Function

    Public Sub AddParameter(ByVal Name As String, ByVal Type As OleDbType, _
      ByVal Size As Integer, ByVal Value As Object, ByVal myCommand As OleDbCommand)
        Try
            myCommand.Parameters.Add(Name, Type, Size).Value = Value
        Catch OleDbExceptionErr As OleDbException
            Throw New System.Exception(OleDbExceptionErr.Message, _
                OleDbExceptionErr.InnerException)
        End Try
    End Sub

#End Region





#Region "ExtensionMethod"
    <Extension()>
    Sub Add(ByVal listuser As List(Of Entity.Users), ByVal username As String, ByVal password As String, ByVal akses As String)

        listuser.Add(New Entity.Users With {.Username = username, .Password = password, .akses = akses})
    End Sub




#End Region

#Region "Fill"

    Private Sub Fill(Of T)(ByVal reader As IDataReader, ByVal list As IList(Of T), _
                                  ByVal type As Type, ByVal fields As String())

        Dim index As Integer = 0

        ' run the reader
        While reader.Read()
            ' create an instance of the type
            Dim item As T = DirectCast(Activator.CreateInstance(type), T)
            ' get all the properties of the type
            Dim properties As Reflection.PropertyInfo() = DirectCast(item.GetType(), Type).GetProperties()
            'Dim MyType As Type = type.GetType("Myproperty")

            If fields.Length <> 0 Then
                For j As Integer = 0 To fields.Length - 1

                    ' get the index of the property
                    index = FindProperyIndexByColumnName(fields(j), properties)
                    ' set the value of the property
                    '  properties(index).GetAccessors(
                    If index <> -1 Then
                        properties(index).SetValue(item,
                        If(reader(fields(j)).ToString = "", "",
                           reader(fields(j))), Nothing)
                    End If

                Next
            Else
                For i As Integer = 0 To reader.FieldCount - 1

                    index = FindProperyIndexByColumnName(reader.GetName(i), properties)
                    Dim a, b As String
                    a = reader(reader.GetName(i)).ToString
                    b = ""
                    If index <> -1 Then
                        properties(index).SetValue(item,
                        If(reader(reader.GetName(i)).ToString = "", "",
                           reader(reader.GetName(i))), Nothing)
                    End If


                Next
            End If

            ' add the item to the list
            list.Add(item)
        End While

    End Sub

    Private Function FindProperyIndexByColumnName(ByVal columnName As String, ByVal prop As Reflection.PropertyInfo()) As Integer
        Dim index As Integer = -1
        For i As Integer = 0 To prop.Length - 1

            If UCase(prop(i).Name) = UCase(columnName) Then
                index = i
                Exit For
            End If

        Next

        Return index

    End Function

    Public Sub FillListWithParam(Of T)(ByVal list As IList(Of T),
                                         ByVal fields As String(), ByVal Query As String,
                                         ByVal type As Type,
                                         ByVal Name As String(), ByVal OleType As OleDbType(),
                                         ByVal Size As Integer(), ByVal Value As Object())

        Using connect As New OleDbConnection(My.Settings.sipdb)

            Using mycommand As OleDbCommand = New OleDbCommand(Query, connect)
                mycommand.CommandType = CommandType.StoredProcedure
                If Name.Length > 0 Then
                    For i = 0 To Name.Length - 1
                        sipModule.AddParameter(Name(i), OleType(i), Size(i), Value(i), mycommand)
                    Next
                End If
                connect.Open()
                Using reader As OleDbDataReader = mycommand.ExecuteReader()
                    Fill(reader, list, type, fields)
                End Using
            End Using
        End Using

    End Sub

    Public Sub FillListWithoutParam(Of T)(ByVal list As IList(Of T),
                                       ByVal fields As String(), ByVal Query As String,
                                       ByVal type As Type)

        Using connect As New OleDbConnection(My.Settings.sipdb)

            Using mycommand As OleDbCommand = New OleDbCommand(Query, connect)
                mycommand.CommandType = CommandType.StoredProcedure

                connect.Open()
                Using reader As OleDbDataReader = mycommand.ExecuteReader()
                    Fill(reader, list, type, fields)
                End Using
            End Using
        End Using

    End Sub

#End Region


End Module
