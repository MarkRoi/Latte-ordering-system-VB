Imports MySql.Data.MySqlClient

Public Class Barista
    'initializing variables
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Barista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'calling function that fetches from the database to execute
        showconfirmed()
    End Sub

    'function that fetches confirmed order from the database to execute
    Sub showconfirmed()
        connection = New MySqlConnection
        connection.ConnectionString = "SERVER = localhost; USERID = root; PASSWORD = ; DATABASE = latteorder;"
        connection.Open()
        command = New MySqlCommand("select * from waiter", connection)
        dataAdapter = New MySqlDataAdapter(command)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet, "waiter")
        DataGridView1.DataSource = dataSet
        DataGridView1.DataMember = "waiter"
        command.Dispose()
        dataAdapter.Dispose()
        connection.Close()


    End Sub
End Class