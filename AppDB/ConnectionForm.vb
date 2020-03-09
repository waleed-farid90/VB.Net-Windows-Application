Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ConnectionForm
    Public Shared Server2 As String
    Public Shared Username2 As String
    Public Shared Password2 As String
    Public Shared DBName2 As String
    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        Dim connection As String
        Dim dbCon As MySqlConnection
        connection = ""
        Dim server = ServerText.Text
        Dim username = UserNameText.Text
        Dim password = PasswordText.Text
        Dim dbname = DBNameText.Text

        Server2 = server
        Username2 = username
        Password2 = password
        DBName2 = dbname

        connection = "Server=" & server & ";Database=" & dbname & ";Uid=" & username & ";Pwd=" & password

        dbCon = New MySqlConnection(connection)

        Try
            dbCon.Open()
            MsgBox("Success")
            dbCon.Close()
            Form1.Show()
            Me.Close()


            Dim file As System.IO.StreamWriter
            If ((Not (server = "")) And (Not (username = "")) And (Not (dbname = ""))) Then
                file = My.Computer.FileSystem.OpenTextFileWriter("connection.txt", False)
                file.WriteLine(server & "," & dbname & "," & username & "," & password)
                file.Close()
            End If


        Catch ex As Exception
            MsgBox("Failed to Connect")

        End Try


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles DBNameText.TextChanged

    End Sub

    Private Sub ConnectRecent_Click(sender As Object, e As EventArgs) Handles ConnectRecent.Click


        Dim connection As String
        Dim dbCon As MySqlConnection
        connection = ""
        Dim server = ""
        Dim username = ""
        Dim password = ""
        Dim dbname = ""

        Using sr As StreamReader = New StreamReader("connection.txt")



            Dim tmp(3) As String
            Dim line As String

            Do Until sr.EndOfStream
                line = sr.ReadLine()
                tmp = line.Split(New [Char]() {CChar(vbTab), CChar(","), CChar(";")})
                server = (tmp(0))
                dbname = tmp(1)
                username = (tmp(2))
                password = (tmp(3))
            Loop
        End Using

        Server2 = server
        Username2 = username
        Password2 = password
        DBName2 = dbname


        connection = "Server=" & server & ";Database=" & dbname & ";Uid=" & username & ";Pwd=" & password
        dbCon = New MySqlConnection(connection)

        Try
            dbCon.Open()
            MsgBox("Success")
            dbCon.Close()
            Form1.Show()
            Me.Close()


            Dim file As System.IO.StreamWriter
            If ((Not (server = "")) And (Not (username = "")) And (Not (dbname = ""))) Then
                file = My.Computer.FileSystem.OpenTextFileWriter("connection.txt", False)
                file.WriteLine(server & "," & dbname & "," & username & "," & password)
                file.Close()
            End If


        Catch ex As Exception
            MsgBox("Failed to Connect")

        End Try
      
    End Sub

    Private Sub ConnectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class