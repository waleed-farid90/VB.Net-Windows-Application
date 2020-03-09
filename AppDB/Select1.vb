Imports MySql.Data.MySqlClient
Module Select1
    Dim dbCon As MySqlConnection
    Dim strQuery = ""
    Dim SQLCmd As MySqlCommand
    Dim DR As MySqlDataReader


    Dim server = Form1.server
    Dim username = Form1.username
    Dim password = Form1.password
    Dim dbname = Form1.dbname


    Dim connection = "Server=" & server & ";Database=" & dbname & ";Uid=" & username & ";Pwd=" & password



    Friend Sub GetData()
        Form1.rtxt1.Text = ""
        Try
            'PREPARE THE CONNECTION TO DB
            dbCon = New MySqlConnection(connection)
            'STATEMENT
            strQuery = "SELECT student.name,student.mark, student.depart FROM student ORDER BY student.name"
            SQLCmd = New MySqlCommand(strQuery, dbCon)
            'OPEN THE DB AND KICKOFF THE QUERY
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            While DR.Read
                Form1.rtxt1.Text = Form1.rtxt1.Text & DR.Item("name") & Space(10) & DR.Item("mark") & Space(10) & DR.Item("depart") & vbCrLf
            End While
            'DONE, WE CLOSE EVERYTHING
            DR.Close()
            dbCon.Close()
        Catch ex As Exception
            MsgBox("Failure to communicate!" & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub


    Friend Sub GetDeletedData()
        Form1.rtxt1.Text = ""
        Try
            'PREPARE THE CONNECTION TO DB
            dbCon = New MySqlConnection(connection)
            'STATEMENT
            strQuery = "SELECT name,mark, depart FROM delete_table ORDER BY name"
            SQLCmd = New MySqlCommand(strQuery, dbCon)
            'OPEN THE DB AND KICKOFF THE QUERY
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            While DR.Read
                Form1.RichTextDeleted.Text = Form1.RichTextDeleted.Text & DR.Item("name") & Space(10) & DR.Item("mark") & Space(10) & DR.Item("depart") & vbCrLf
            End While
            'DONE, WE CLOSE EVERYTHING
            DR.Close()
            dbCon.Close()
        Catch ex As Exception
            MsgBox("Failure to communicate!" & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub


    Friend Sub GetUpdatedData()
        Form1.rtxt1.Text = ""
        Try
            'PREPARE THE CONNECTION TO DB
            dbCon = New MySqlConnection(connection)
            'STATEMENT
            strQuery = "SELECT name,mark, depart FROM update_table ORDER BY name"
            SQLCmd = New MySqlCommand(strQuery, dbCon)
            'OPEN THE DB AND KICKOFF THE QUERY
            dbCon.Open()
            DR = SQLCmd.ExecuteReader
            While DR.Read
                Form1.RichTextUpdated.Text = Form1.RichTextUpdated.Text & DR.Item("name") & Space(10) & DR.Item("mark") & Space(10) & DR.Item("depart") & vbCrLf
            End While
            'DONE, WE CLOSE EVERYTHING
            DR.Close()
            dbCon.Close()
        Catch ex As Exception
            MsgBox("Failure to communicate!" & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub



End Module
