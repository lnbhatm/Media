Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Public Class frmmain

    Public pDir As String = "\Media\Photos"
    Public vDir As String = "\Media\Videos"
    Public dDir As String = "\Media\Docs"

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        If MsgBox("Are You Sure you want to Exit ?", vbYesNo, "Exit") = vbYes Then
            If (System.Windows.Forms.Application.MessageLoop) Then
                System.Windows.Forms.Application.Exit()
            Else
                System.Environment.Exit(1)
            End If
        End If
    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pgbar.Minimum = 0
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
    Public Sub makephotosdir(ByVal dirname As String)
        pDir = dirname & pDir
        On Error GoTo ErrorHandler
        My.Computer.FileSystem.CreateDirectory(pDir)
        Exit Sub
ErrorHandler:
        Resume Next
    End Sub


    Function hash_SHA256_generate(ByVal file_name As String)
        Dim hash
        Dim hashValue() As Byte
        hash = SHA256.Create()
        Dim fileStream As FileStream = File.OpenRead(file_name)
        fileStream.Position = 0
        hashValue = hash.ComputeHash(fileStream)
        Dim hash_hex = PrintByteArray(hashValue)
        fileStream.Close()
        Return hash_hex
    End Function
    Public Function PrintByteArray(ByVal array() As Byte)
        Dim hex_value As String = ""
        Dim i As Integer
        For i = 0 To array.Length - 1
            hex_value += array(i).ToString("X2")
        Next i
        Return hex_value.ToUpper
    End Function

    Public Function hashcomparefiles(ByVal oFile As String, ByVal nFile As String) As Boolean
        Dim hashOFile As String = hash_SHA256_generate(oFile)
        Dim hashnFile As String = hash_SHA256_generate(nFile)
        If StrComp(hashOFile, hashnFile, CompareMethod.Binary) Then
            hashcomparefiles = False
        Else
            hashcomparefiles = True
        End If
    End Function


    Public Function arrangephotos(ByVal fileName As String) As Integer
        Dim ext As String
        Dim infoReader As System.IO.FileInfo
        Dim strTimeCreated As Date
        Dim strTimeModified As Date
        Dim strYear As String
        Dim strMonth As String
        Dim strDay As String
        Dim strNewFileName As String
        Dim strdstdir As String
        Dim picturetaken As Date = Nothing
        Dim EquipmentModel As String
        '--------------------------------------------------------------------------
        ext = System.IO.Path.GetExtension(fileName)
        infoReader = My.Computer.FileSystem.GetFileInfo(fileName)
        strTimeCreated = infoReader.CreationTime
        strTimeModified = infoReader.LastWriteTime
        '--------------------------------------------------------------------------
        Using EW As New ExifWorks(fileName)
            picturetaken = EW.DateTimeOriginal
            EquipmentModel = EW.EquipmentModel
        End Using
        If picturetaken <> Nothing Then
            strYear = Format(picturetaken, "yyyy")
            strMonth = Format(picturetaken, "MM")
            strDay = Format(picturetaken, "dd_MMMM_yyyy")
            strNewFileName = Format(picturetaken, "ddMMyyyy_hmmsstt_") & Trim(EquipmentModel)
        Else
            If strTimeCreated > strTimeModified Then
                strYear = Format(infoReader.LastWriteTime, "yyyy")
                strMonth = Format(infoReader.LastWriteTime, "MM")
                strDay = Format(infoReader.LastWriteTime, "dd_MMMM_yyyy")
                strNewFileName = Format(infoReader.LastWriteTime, "ddMMyyyy_hmmsstt")
            Else
                strYear = Format(infoReader.CreationTime, "yyyy")
                strMonth = Format(infoReader.CreationTime, "MM")
                strDay = Format(infoReader.CreationTime, "dd_MMMM_yyyy")
                strNewFileName = Format(infoReader.CreationTime, "ddMMyyyy_hmmsstt")
            End If
        End If
        strdstdir = pDir & "\" & strYear & "\" & strMonth & "\" & strDay
        Try
            My.Computer.FileSystem.CreateDirectory(strdstdir)
            strNewFileName = My.Computer.FileSystem.CombinePath(strdstdir, strNewFileName & ext)
            If FileExists(strNewFileName) Then
                If hashcomparefiles(strNewFileName, fileName) = False Then
                    Dim tmpfilename As String
                    tmpfilename = Path.GetFileNameWithoutExtension(strNewFileName)
                    tmpfilename = tmpfilename & "_P" & Format(Now, "hhmmss")
                    strNewFileName = My.Computer.FileSystem.CombinePath(strdstdir, tmpfilename & ext)
                End If
            End If
            My.Computer.FileSystem.MoveFile(fileName, strNewFileName, overwrite:=False)
            File.SetLastWriteTime(strNewFileName, picturetaken)
            File.SetCreationTime(strNewFileName, picturetaken)
            File.SetLastAccessTime(strNewFileName, picturetaken)
        Catch ex As Exception
        End Try
        '--------------------------------------------------------------------------
        Return 0
    End Function
    Private Sub btnorg_Click(sender As Object, e As EventArgs) Handles btnorg.Click
        Dim filecount As Integer = 0
        Dim fileindex As Integer = 0
        Dim percent As Integer = 0
        Dim sourcedir As String = Trim(txtsrc.Text)
        Dim destdir As String = Trim(txtdst.Text)
        If sourcedir = "" Or DirectoryExists(sourcedir) = False Then
            MsgBox("Directroy: " & sourcedir & "Does not exists!", vbCritical, "INPUT DIRECTORY ERROR")
            txtsrc.Focus()
            Exit Sub
        End If
        If destdir = "" Or DirectoryExists(destdir) = False Then
            MsgBox("Directroy: " & destdir & "Does not exists!", vbCritical, "INPUT DIRECTORY ERROR")
            txtdst.Focus()
            Exit Sub
        End If
        My.Computer.FileSystem.CreateDirectory(destdir & "\sourcebkup")
        Dim fileNames = My.Computer.FileSystem.GetFiles(sourcedir, FileIO.SearchOption.SearchTopLevelOnly, "*.jpeg", "*.jpg", "*.bmp")
        filecount = fileNames.Count
        If filecount = 0 Then
            MsgBox("No Media files in the directory: " & sourcedir)
            Exit Sub
        End If
        For Each file As String In fileNames
            My.Computer.FileSystem.CopyFile(file, destdir & "\sourcebkup\" & Path.GetFileName(file), overwrite:=False)
        Next
        makephotosdir(destdir)
        pgbar.Maximum = filecount
        For Each file As String In fileNames
            arrangephotos(file)
            fileindex = fileindex + 1
            pgbar.Value = fileindex
            percent = (fileindex / filecount) * 100
            lblprgs.Text = percent & " %"
            MyBase.Update()
        Next
        btnorg.Enabled = False
    End Sub
    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtsrc.Text = ""
        txtdst.Text = ""
        pgbar.Minimum = 0
        pgbar.Value = 0
        lblprgs.Text = "0%"
        btnorg.Enabled = True
    End Sub
End Class
