Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myFile As String, myFolder As String

        myFolder = "C:\Users\idaca\Desktop"
        myFile = myFolder & "Export.txt"


        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.txt", "" & Label1.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.txt", "" & TextBox1.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.txt", "" & Label2.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.txt", "" & TextBox2.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.txt", "" & Label3.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.txt", "" & TextBox3.Text, True)

        MsgBox("saved")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myFile As String, myFolder As String

        myFolder = "C:\Users\idaca\Desktop"
        myFile = myFolder & "Export.txt"


        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.xml", "" & Label1.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.xml", "" & TextBox1.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.xml", "" & Label2.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.xml", "" & TextBox2.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.xml", "" & Label3.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.xml", "" & TextBox3.Text, True)

        MsgBox("saved")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myFile As String, myFolder As String

        myFolder = "C:\Users\idaca\Desktop"
        myFile = myFolder & "Export.txt"


        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.json", "" & Label1.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.json", "" & TextBox1.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.json", "" & Label2.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.json", "" & TextBox2.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.json", "" & Label3.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\Users\idaca\Desktop\Export.json", "" & TextBox3.Text, True)

        MsgBox("saved")
    End Sub
End Class
