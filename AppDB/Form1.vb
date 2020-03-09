Public Class Form1
    Public server = ConnectionForm.Server2
    Public username = ConnectionForm.Username2
    Public password = ConnectionForm.Password2
    Public dbname = ConnectionForm.DBName2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InsertData()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        searchData()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        updateData()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        deleteData()
    End Sub

    Private Sub DisplayUpdatedButton_Click(sender As Object, e As EventArgs) Handles DisplayUpdatedButton.Click
        GetUpdatedData()
    End Sub

    Private Sub DisplayDeletedButton_Click(sender As Object, e As EventArgs) Handles DisplayDeletedButton.Click
        GetDeletedData()
    End Sub
End Class
