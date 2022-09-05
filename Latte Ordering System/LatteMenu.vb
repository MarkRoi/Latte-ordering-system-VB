Imports MySql.Data.MySqlClient

Public Class LatteMenu
    'initializing variables
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'making the objects below visible when button12 is clicked and textbox invisible 
        Label22.Visible = True
        Label11.Visible = True
        TextBox11.Visible = True
        TextBox12.Visible = False
        'establishing database connection
        command = New MySqlCommand
        Try
            Dim connect As String = "INSERT INTO customer(Table_Number,Vanilla,Peppermint,Caramel,Toffee,Orange,Raspberry,Butteredrum,Hazelnut,Cinnamon,Total) VALUES ('" & ComboBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox10.Text & "', '" & TextBox6.Text & "', '" & TextBox7.Text & "', '" & TextBox8.Text & "', '" & TextBox9.Text & "', '" & TextBox11.Text & "')"
            command.Connection = connection
            command.CommandText = connect
            command.ExecuteNonQuery()
            MsgBox("Successful :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'increasing the value in textbox by one whenever the button is clicked
        TextBox2.Text += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'decreasing the value in textbox by one whenever the button is clicked
        TextBox2.Text -= 1
        'the value in the textbox should remain zero for any value kess than zero 
        If TextBox2.Text <= 0 Then
            TextBox2.Text = 0
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'multiplying the individual flavour amount by quantity selected then suming up all the totals to get the Total amount of the overall order 
        Dim Vanilla, Peppermint, Caramel, Toffee, Orange, Raspberry, Butteredrum, Hazelnut, Cinnamon As Double
        Vanilla = Format(TextBox2.Text * 10000.0, "0.0")
        Peppermint = Format(TextBox3.Text * 12000.0, "0.0")
        Caramel = Format(TextBox4.Text * 13000.0, "0.0")
        Toffee = Format(TextBox5.Text * 15000.0, "0.0")
        Orange = Format(TextBox10.Text * 16000.0, "0.0")
        Raspberry = Format(TextBox6.Text * 11000.0, "0.0")
        Butteredrum = Format(TextBox7.Text * 12000.0, "0.0")
        Hazelnut = Format(TextBox8.Text * 14000.0, "0.0")
        Cinnamon = Format(TextBox9.Text * 18000.0, "0.0")

        TextBox11.Text = Vanilla + Peppermint + Caramel + Toffee + Orange + Raspberry + Butteredrum + Hazelnut + Cinnamon

        'for any textbox value greater than 1, the lables should display the latte flavor and computed amount for the quantities select or else the should not display anything
        If TextBox2.Text >= 1 Then
            Label23.Text = ("Vanilla UGX: " & TextBox2.Text * 10000)
        Else
            TextBox1.Text = ("")
        End If

        If TextBox3.Text >= 1 Then
            Label24.Text = ("Peppermint UGX: " & TextBox3.Text * 12000)
        Else
            TextBox1.Text = ("")
        End If

        If TextBox4.Text >= 1 Then
            Label25.Text = ("Caramel UGX: " & TextBox4.Text * 13000)
        Else
            TextBox1.Text = ("")
        End If

        If TextBox5.Text >= 1 Then
            Label26.Text = ("Toffee UGX: " & TextBox5.Text * 15000)
        Else
            TextBox1.Text = ("")
        End If

        If TextBox10.Text >= 1 Then
            Label27.Text = ("Orange UGX: " & TextBox10.Text * 16000)
        Else
            TextBox1.Text = ("")
        End If

        If TextBox6.Text >= 1 Then
            Label28.Text = ("Raspberry UGX: " & TextBox6.Text * 11000)
        Else
            TextBox1.Text = ("")
        End If

        If TextBox7.Text >= 1 Then
            Label29.Text = ("Buttered rum UGX: " & TextBox7.Text * 12000)
        Else
            TextBox1.Text = ("")
        End If

        If TextBox8.Text >= 1 Then
            Label30.Text = ("Hazelnut UGX: " & TextBox8.Text * 14000)
        Else
            TextBox1.Text = ("")
        End If

        If TextBox9.Text >= 1 Then
            Label31.Text = ("Cinnamon UGX: " & TextBox9.Text * 18000)
        Else
            TextBox1.Text = ("")
        End If


    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox3.Text += 1
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox4.Text += 1
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox5.Text += 1
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox10.Text += 1
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox6.Text += 1
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox7.Text += 1
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox8.Text += 1
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox9.Text += 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text -= 1
        If TextBox3.Text <= 0 Then
            TextBox3.Text = 0
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox4.Text -= 1
        If TextBox4.Text <= 0 Then
            TextBox4.Text = 0
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox5.Text -= 1
        If TextBox5.Text <= 0 Then
            TextBox5.Text = 0
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox10.Text -= 1
        If TextBox10.Text <= 0 Then
            TextBox10.Text = 0
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox6.Text -= 1
        If TextBox6.Text <= 0 Then
            TextBox6.Text = 0
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox7.Text -= 1
        If TextBox7.Text <= 0 Then
            TextBox7.Text = 0
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox8.Text -= 1
        If TextBox8.Text <= 0 Then
            TextBox8.Text = 0
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox9.Text -= 1
        If TextBox9.Text <= 0 Then
            TextBox9.Text = 0
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'all textboxes and variables, should carry a value of 0 and all lables should carry empty strings
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0
        TextBox9.Text = 0
        TextBox10.Text = 0
        TextBox11.Text = 0
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

        Label23.Text = ""
        Label22.Text = ""
        Label24.Text = ""
        Label25.Text = ""
        Label26.Text = ""
        Label27.Text = ""
        Label28.Text = ""
        Label29.Text = ""
        Label30.Text = ""
        Label31.Text = ""

        TextBox11.Visible = False
        TextBox12.Visible = True


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection = New MySqlConnection
            connection.ConnectionString = "SERVER = localhost; USERID = root; PASSWORD = ; DATABASE = latteorder;"
            connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        'should transition to waiter's screen when button is clicked
        Waiter.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class