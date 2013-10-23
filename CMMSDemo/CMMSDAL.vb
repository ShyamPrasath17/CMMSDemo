Imports System.Data.SqlClient

Public Class CMMSDAL
    Private Shared MainDS As DataSet
    Private Shared mySQLCommand As SqlClient.SqlCommand
    Private Shared mySQLAdapter As SqlClient.SqlDataAdapter
    Private Shared cn As SqlConnection
    Private Shared _DSCmms As New DSCmms
    Public Shared strConn As String = "Data Source=SHYAM-PC\TOWNSUITE;Initial Catalog=DBCMMS;Persist Security Info=True;" & _
    "User ID=sa;Password=Wheymu1"

    Public Shared Function Create_dtProject() As DataTable
        Return _DSCmms.Tables("CMProject").Clone
    End Function

    Public Shared Function Create_dtWo() As DataTable
        Return _DSCmms.Tables("CMWorkOrder").Clone
    End Function

    Public Shared Function Create_dtTask() As DataTable
        Return _DSCmms.Tables("CMTasks").Clone
    End Function

    Public Shared Function cls_EXE_STORED_PROCEDURE(ByVal storedProcedureName As String) As DataSet


        Try
            MainDS = New DataSet
            MainDS.Clear()
            mySQLCommand = New SqlClient.SqlCommand
            cn = New SqlClient.SqlConnection(strConn)
            mySQLCommand.Connection = cn
            mySQLCommand.CommandText = storedProcedureName
            mySQLCommand.CommandType = CommandType.StoredProcedure

            cn.Open()
            mySQLAdapter = New SqlClient.SqlDataAdapter(mySQLCommand)
            mySQLAdapter.Fill(MainDS)
            cn.Close()

            Return MainDS
        Catch ex As Exception
            MessageBox.Show("Wrong Connection")
        Finally
            MainDS.Dispose()
            mySQLCommand.Dispose()
            mySQLAdapter.Dispose()
            cn.Dispose()
        End Try

    End Function


    Public Shared Function cls_EXE_STORED_PROCEDURE_PRAM(ByRef argArray As ArrayList, ByVal storedProcedureName As String) As DataSet
        Dim myEnumerator As System.Collections.IEnumerator = _
                argArray.GetEnumerator
        Try
            Dim mySQLParameter As SqlClient.SqlParameter
            cn = New SqlClient.SqlConnection(strConn)
            mySQLCommand = New SqlClient.SqlCommand

            While myEnumerator.MoveNext()
                mySQLParameter = New SqlClient.SqlParameter
                mySQLParameter.ParameterName = myEnumerator.Current.ToString
                myEnumerator.MoveNext()
                mySQLParameter.Value = myEnumerator.Current
                myEnumerator.MoveNext()
                mySQLParameter.Direction = ParameterDirection.Input
                mySQLParameter.DbType = CType(myEnumerator.Current, System.Data.DbType)
                mySQLCommand.Parameters.Add(mySQLParameter)
            End While

            MainDS = New DataSet
            MainDS.Clear()

            mySQLCommand.Connection = cn
            mySQLCommand.CommandText = storedProcedureName
            mySQLCommand.CommandType = CommandType.StoredProcedure

            cn.Open()
            mySQLAdapter = New SqlClient.SqlDataAdapter(mySQLCommand)

            mySQLAdapter.Fill(MainDS)
            cn.Close()

            Return MainDS
        Catch ex As Exception
            MessageBox.Show("Wrong Connection")
        Finally
            MainDS.Dispose()
            mySQLCommand.Dispose()
            mySQLAdapter.Dispose()
            cn.Dispose()
        End Try

    End Function

End Class



