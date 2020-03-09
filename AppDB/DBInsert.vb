Imports MySql.Data.MySqlClient
Module DBInsert
    Dim dbCon As MySqlConnection
    Dim strQuery = ""
    Dim SQLCmd As MySqlCommand
    Dim DR As MySqlDataReader

    Dim server = Form1.server
    Dim username = Form1.username
    Dim password = Form1.password
    Dim dbname = Form1.dbname
    Dim connection = "Server=" & server & ";Database=" & dbname & ";Uid=" & username & ";Pwd=" & password

    Friend Sub InsertData()
        Dim ids = CInt(Form1.txt1.Text)
        Dim names = Form1.txt2.Text
        Dim marks = CDbl(Form1.txt3.Text)
        Dim departs = CInt(Form1.txt4.Text)

        Try
            'PREPARE THE CONNECTION TO DB
            dbCon = New MySqlConnection(connection)
            'STATEMENT
            strQuery = "INSERT INTO student (id,name,mark,depart) values(@id_,@name_,@mark_,@depart_)"
            'Open the connection
            dbCon.Open()
            SQLCmd = New MySqlCommand(strQuery, dbCon)
            'OPEN THE DB AND KICKOFF THE QUERY
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.Parameters.AddWithValue("@id_", ids)
            SQLCmd.Parameters.AddWithValue("@name_", names)
            SQLCmd.Parameters.AddWithValue("@mark_", marks)
            SQLCmd.Parameters.AddWithValue("@depart_", departs)
            SQLCmd.ExecuteNonQuery()
            MsgBox("Data sucessfully inserted!")
            dbCon.Close()

        Catch ex As Exception
            MsgBox("Failure to communicate!" & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub

    Friend Sub searchData()
        Form1.SearchName.Text = ""
        Form1.SearchMark.Text = ""
        Form1.SearchDepartment.Text = ""


        Dim id As String = (Form1.SearchID.Text)

        Try
            dbCon = New MySqlConnection(connection)

            strQuery = "SELECT * FROM STUDENT WHERE ID =" & id

            SQLCmd = New MySqlCommand(strQuery, dbCon)
            dbCon.Open()
            DR = SQLCmd.ExecuteReader

            While DR.Read

                Form1.SearchName.Text = DR.Item("name")
                Form1.SearchMark.Text = DR.Item("mark")
                Form1.SearchDepartment.Text = DR.Item("depart")
            End While
            If (Form1.SearchName.Text = "" And Form1.SearchMark.Text = "" And Form1.SearchDepartment.Text = "") Then
                MsgBox("No record found!")
            End If

            DR.Close()
                dbCon.Close()
        Catch ex As Exception
            MsgBox("Failure to communicate!" & vbCrLf & vbCrLf & ex.Message)
        End Try

    End Sub

    Friend Sub updateData()
        If (Not Form1.SearchName.Text = "" And Not Form1.SearchMark.Text = "" And Not Form1.SearchDepartment.Text = "") Then

            Dim id = Form1.SearchID.Text
            Dim id2 = CInt(Form1.SearchID.Text)
            Dim name As String = Form1.SearchName.Text
            Dim mark = CDbl(Form1.SearchMark.Text)
            Dim depart = CInt(Form1.SearchDepartment.Text)
            Dim old_name
            Dim old_mark
            Dim old_depart

            Try
                'PREPARE THE CONNECTION TO DB
                dbCon = New MySqlConnection(connection)
                'STATEMENT
                Dim selectQuery = "SELECT * FROM STUDENT WHERE ID = " & id
                strQuery = "INSERT INTO UPDATE_TABLE (id,name,mark,depart,date) values(@id_,@name_,@mark_,@depart_,NOW())"
                Dim updateQuery = "UPDATE STUDENT SET NAME = @name , MARK = @mark , DEPART = @depart WHERE ID = " & id
                'Open the connection
                dbCon.Open()
                SQLCmd = New MySqlCommand(selectQuery, dbCon)
                'OPEN THE DB AND KICKOFF THE QUERY
                DR = SQLCmd.ExecuteReader

                While DR.Read
                    old_name = DR.Item("name")
                    old_mark = DR.Item("mark")
                    old_depart = DR.Item("depart")
                End While

                DR.Close()

                Dim SQLCmd2 = New MySqlCommand(strQuery, dbCon)
                SQLCmd2.CommandType = CommandType.Text
                SQLCmd2.Parameters.AddWithValue("@id_", id2)
                SQLCmd2.Parameters.AddWithValue("@name_", old_name)
                SQLCmd2.Parameters.AddWithValue("@mark_", old_mark)
                SQLCmd2.Parameters.AddWithValue("@depart_", old_depart)
                SQLCmd2.ExecuteNonQuery()

                Dim SQLCmd3 = New MySqlCommand(updateQuery, dbCon)
                SQLCmd3.CommandType = CommandType.Text
                SQLCmd3.Parameters.AddWithValue("@name", name)
                SQLCmd3.Parameters.AddWithValue("@mark", mark)
                SQLCmd3.Parameters.AddWithValue("@depart", depart)
                SQLCmd3.ExecuteNonQuery()
                MsgBox("Data sucessfully inserted!")
                dbCon.Close()

            Catch ex As Exception
                MsgBox("Failure to communicate!" & vbCrLf & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Friend Sub deleteData()
        searchData()

        Dim result As Integer = MessageBox.Show("Are You Sure You Want To Delete This Record", "Delete Record", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            If (Form1.SearchName.Text = "" And Form1.SearchMark.Text = "" And Form1.SearchDepartment.Text = "") Then
                MsgBox("No record found!")
            Else

                Dim id = Form1.SearchID.Text
                Dim id2 = CInt(Form1.SearchID.Text)
                Dim name As String = Form1.SearchName.Text
                Dim mark = CDbl(Form1.SearchMark.Text)
                Dim depart = CInt(Form1.SearchDepartment.Text)


                Try
                    'PREPARE THE CONNECTION TO DB
                    dbCon = New MySqlConnection(connection)
                    'STATEMENT
                    strQuery = "INSERT INTO DELETE_TABLE (id,name,mark,depart,date) values(@id_,@name_,@mark_,@depart_,NOW())"
                    Dim deleteQuery = "DELETE FROM STUDENT WHERE `ID` = " & id
                    'Open the connection
                    dbCon.Open()


                    Dim SQLCmd2 = New MySqlCommand(strQuery, dbCon)
                    SQLCmd2.CommandType = CommandType.Text
                    SQLCmd2.Parameters.AddWithValue("@id_", id2)
                    SQLCmd2.Parameters.AddWithValue("@name_", name)
                    SQLCmd2.Parameters.AddWithValue("@mark_", mark)
                    SQLCmd2.Parameters.AddWithValue("@depart_", depart)
                    SQLCmd2.ExecuteNonQuery()

                    Dim SQLCmd3 = New MySqlCommand(deleteQuery, dbCon)
                    SQLCmd3.CommandType = CommandType.Text
                    SQLCmd3.ExecuteNonQuery()
                    MsgBox("Data sucessfully deleted!")
                    dbCon.Close()

                Catch ex As Exception
                    MsgBox("Failure to communicate!" & vbCrLf & vbCrLf & ex.Message)
                End Try
            End If
        End If


    End Sub
End Module
