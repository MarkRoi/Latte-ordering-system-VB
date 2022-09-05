Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Latte_Ordering_System
Imports MySql.Data.MySqlClient

<TestClass()> Public Class UnitTest1
    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    <TestMethod()> Public Sub TestMethod1()
        Dim TableNumber, vanilla, peppermint, Total As Integer
        TableNumber = 1
        vanilla = 2
        peppermint = 1
        Total = 36000

        command = New MySqlCommand
        Try

            Dim connect As String = "INSERT INTO customer(Table_Number,Vanilla,Peppermint,Total) VALUES ('" & TableNumber & "', '" & vanilla & "', '" & peppermint & "', '" & Total & "')"
            command.Connection = connection
            connection.Open()
            command.CommandText = connect
            command.ExecuteNonQuery()
            MsgBox("Successful :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
