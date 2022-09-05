Imports MySql.Data.MySqlClient

Public Class Waiter
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'calling functions to be executed
        showusers()
        showconfirmed()
    End Sub

    'function to fetch customer's orders from the database
    Sub showusers()
        connection = New MySqlConnection
        connection.ConnectionString = "SERVER = localhost; USERID = root; PASSWORD = ; DATABASE = latteorder;"
        connection.Open()
        command = New MySqlCommand("select * from customer", connection)
        dataAdapter = New MySqlDataAdapter(command)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet, "customer")
        DataGridView1.DataSource = dataSet
        DataGridView1.DataMember = "customer"
        command.Dispose()
        dataAdapter.Dispose()
        connection.Close()


    End Sub

    'function that fetches confirmed orders from the database
    Sub showconfirmed()
        connection = New MySqlConnection
        connection.ConnectionString = "SERVER = localhost; USERID = root; PASSWORD = ; DATABASE = latteorder;"
        connection.Open()
        command = New MySqlCommand("select * from waiter", connection)
        dataAdapter = New MySqlDataAdapter(command)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet, "waiter")
        DataGridView2.DataSource = dataSet
        DataGridView2.DataMember = "waiter"
        command.Dispose()
        dataAdapter.Dispose()

    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'establishing database connection to send data into the database when button is clicked
        command = New MySqlCommand

        Try
            Dim connect As String = "INSERT INTO waiter(TableNumber,Vanilla,Peppermint,Caramel,Toffee,Orange,Raspberry,Butteredrum,Hazelnut,Cinnamon,Amount,Status) VALUES ('" & ComboBox1.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & TextBox7.Text & "', '" & TextBox8.Text & "', '" & TextBox9.Text & "', '" & TextBox10.Text & "', '" & TextBox11.Text & "')"
            command.Connection = connection
            command.CommandText = connect
            command.ExecuteNonQuery()
            MsgBox("Successful :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'multiplying the individual flavour amount by quantity selected then suming up all the totals to get the Total amount of the overall order 
        Dim Vanilla, Peppermint, Caramel, Toffee, Orange, Raspberry, Butteredrum, Hazelnut, Cinnamon As Double
        Vanilla = Format(TextBox1.Text * 10000.0, "0.0")
        Peppermint = Format(TextBox2.Text * 12000.0, "0.0")
        Caramel = Format(TextBox3.Text * 13000.0, "0.0")
        Toffee = Format(TextBox4.Text * 15000.0, "0.0")
        Orange = Format(TextBox5.Text * 16000.0, "0.0")
        Raspberry = Format(TextBox6.Text * 11000.0, "0.0")
        Butteredrum = Format(TextBox7.Text * 12000.0, "0.0")
        Hazelnut = Format(TextBox8.Text * 14000.0, "0.0")
        Cinnamon = Format(TextBox9.Text * 18000.0, "0.0")

        TextBox10.Text = Vanilla + Peppermint + Caramel + Toffee + Orange + Raspberry + Butteredrum + Hazelnut + Cinnamon
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'establishing database connection to update database data in waiter's table
        command = New MySqlCommand

        Try
            Dim connect As String = "UPDATE waiter SET Status = '" & "Paid" & "' WHERE ID = '" & TextBox12.Text & "' "
            command.Connection = connection
            command.CommandText = connect
            command.ExecuteNonQuery()
            MsgBox("Successful :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'transition to baristas screen when button is clicked 
        Barista.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'all textboxes and variables, should carry a value of 0 and all lables should carry empty strings
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0
        TextBox9.Text = 0
        TextBox10.Text = 0
        TextBox12.Text = " "
        Dim Vanilla, Peppermint, Caramel, Toffee, Orange, Raspberry, Butteredrum, Hazelnut, Cinnamon As Integer
        Vanilla = 0
        Peppermint = 0
        Caramel = 0
        Toffee = 0
        Orange = 0
        Raspberry = 0
        Butteredrum = 0
        Hazelnut = 0
        Cinnamon = 0

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class
