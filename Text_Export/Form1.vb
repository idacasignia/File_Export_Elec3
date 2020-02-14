Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myFile As String, myFolder As String

        myFolder = "C:\Users\idaca\Desktop"
        myFile = myFolder & "Export.txt"


        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.txt", "" & Label1.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.txt", "" & TextBox1.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.txt", "" & TextBox2.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.txt", "" & TextBox3.Text, True)

        MsgBox("saved")
    End Sub
End Class
