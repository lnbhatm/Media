Public Class frmmain

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property



    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        If (System.Windows.Forms.Application.MessageLoop) Then
            System.Windows.Forms.Application.Exit()
        Else
            System.Environment.Exit(1)
        End If
    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtsrc.Text = "C:\Users\bhatml\Desktop\docs\Camera"
        txtdst.Text = "C:\Users\bhatml\Desktop\docs\Camera\dst"
    End Sub


   


    Public Function FileExists(ByVal Fname As String) As Boolean
        If My.Computer.FileSystem.FileExists(Fname) Then
            FileExists = True
        Else
            FileExists = False
        End If
    End Function

    Public Function DirectoryExists(ByVal dirname As String) As Boolean
        If My.Computer.FileSystem.DirectoryExists(dirname) Then
            DirectoryExists = True
        Else
            DirectoryExists = False
        End If
    End Function



    Public Function makedirectory(ByVal dirname As String) As Boolean
        makedirectory = False
        Try
            If My.Computer.FileSystem.DirectoryExists(dirname) = False Then
                My.Computer.FileSystem.CreateDirectory(dirname)
                makedirectory = True
            End If
        Catch ex As System.IO.IOException
            MsgBox("An error occurred")
            makedirectory = True
        End Try
    End Function

    Private Sub btnorg_Click(sender As Object, e As EventArgs) Handles btnorg.Click
        Dim strfiles As String = "Files: "

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(txtsrc.Text)

            strfiles = strfiles & vbCrLf & foundFile

        Next

        MsgBox(strfiles)


    End Sub
End Class
