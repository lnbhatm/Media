Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Public Class frmmain
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
                logmessage("Application exited")
                System.Windows.Forms.Application.Exit()
            Else
                System.Environment.Exit(1)
            End If
        End If
    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & vbTab & " Version [R " & My.Application.Info.Version.Major
        Me.Text = Me.Text & "." & My.Application.Info.Version.Minor
        Me.Text = Me.Text & "." & My.Application.Info.Version.Build
        Me.Text = Me.Text & "." & My.Application.Info.Version.Revision & "]"
        pgbar.Minimum = 0
        txtdst.Text = "C:\Manimoole\GirishBhatM"
        txtlog.Text = "--------------- Program started at " & Format(Now, "[ yyy-MM-dd hh-mm-ss: ]") & " ---------------"
    End Sub

    Public Function FileExists(ByVal Fname As String) As Boolean
        If My.Computer.FileSystem.FileExists(Fname) Then
            FileExists = True
        Else
            FileExists = False
        End If
    End Function

    Public Function HandleDuplicates(ByVal srcfile As String, ByVal dstfile As String) As String
        Dim strfilename As String = dstfile
        Dim strext As String = Path.GetExtension(dstfile)
        Dim strdstdir As String = Path.GetDirectoryName(dstfile)
        Dim strfilenamenoext As String = Path.GetFileNameWithoutExtension(dstfile)
        If FileExists(dstfile) = True Then
            If hashcomparefiles(srcfile, dstfile) = True Then
                logmessage("Files: " & vbCrLf & srcfile & " And " & vbCrLf & dstfile & vbCrLf & " Are same ")
                strfilename = String.Empty
            Else
                strfilenamenoext = strfilenamenoext & "_" & Format(Now, "mmss")
                strfilename = My.Computer.FileSystem.CombinePath(strdstdir, strfilenamenoext & strext)
                logmessage("Files: " & vbCrLf & srcfile & " And " & vbCrLf & dstfile & vbCrLf & " Are Not the Same ")
            End If
        End If
        Return (strfilename)
    End Function

    Public Function filecreationtime2filename(ByVal dstdir As String, ByVal strorgname As String, ByVal type As String) As String
        Dim strnewname As String = Nothing
        Dim infoReader As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(strorgname)
        Dim Ext As String = System.IO.Path.GetExtension(strorgname)
        Dim strcreatedtime As Date = infoReader.LastWriteTime
        Dim picturetaken As Date = Nothing
        Dim EquipmentModel As String = Nothing
        Dim strYear As String = Nothing
        Dim strMonth As String = Nothing
        Dim strDay As String = Nothing
        Dim mediadir As String = "\Media\" & type
        '------------------------------------------------------------------------------------------
        If type = "Photos" Then
            Using EW As New ExifWorks(strorgname)
                picturetaken = EW.DateTimeOriginal
                EquipmentModel = EW.EquipmentModel
            End Using
        End If
        '------------------------------------------------------------------------------------------
        If picturetaken <> Nothing Then
            strYear = Format(picturetaken, "yyyy")
            strMonth = Format(picturetaken, "MM")
            strDay = Format(picturetaken, "dd_MMMM_yyyy")
            strnewname = Trim(Format(picturetaken, "yyyyMMdd_hhmmsstt") & Trim(EquipmentModel))
        Else
            strYear = Format(infoReader.LastWriteTime, "yyyy")
            strMonth = Format(infoReader.LastWriteTime, "MM")
            strDay = Format(infoReader.LastWriteTime, "dd_MMMM_yyyy")
            strnewname = Trim(Format(strcreatedtime, "yyyyMMdd_hhmmsstt") & Trim(EquipmentModel))
        End If
        '------------------------------------------------------------------------------------------
        mediadir = dstdir & mediadir & "\" & strYear & "\" & strMonth & "\" & strDay
        Try
            My.Computer.FileSystem.CreateDirectory(mediadir)
            strnewname = My.Computer.FileSystem.CombinePath(mediadir, strnewname & Ext)
        Catch ex As Exception
        End Try
        Return (strnewname)
    End Function

    Public Function updateproperty(ByVal dstfile As String) As Integer
        Dim strnewname As String = Nothing
        Dim infoReader As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(dstfile)
        Dim strcreatedtime As Date = infoReader.LastWriteTime
        Dim picturetaken As Date = Nothing
        Dim EquipmentModel As String = Nothing
        '------------------------------------------------------------------------------------------
        Using EW As New ExifWorks(dstfile)
            picturetaken = EW.DateTimeOriginal
            EquipmentModel = EW.EquipmentModel
        End Using
        '------------------------------------------------------------------------------------------
        If picturetaken <> Nothing Then
            File.SetCreationTime(dstfile, picturetaken)
            File.SetLastAccessTime(dstfile, picturetaken)
        Else
            File.SetCreationTime(dstfile, picturetaken)
            File.SetLastAccessTime(dstfile, picturetaken)
        End If
        '------------------------------------------------------------------------------------------
        Return (0)
    End Function

    Public Function logmessage(ByVal msg As String) As Integer
        txtlog.Text = txtlog.Text & vbCrLf & Format(Now, "[yyy-MM-dd hh-mm-ss]") & ":  " & msg & vbCrLf
        Return 0
    End Function

    Public Function isDirectoryExists(ByVal dirname As String) As Boolean
        If My.Computer.FileSystem.DirectoryExists(dirname) Then
            isDirectoryExists = True
        Else
            isDirectoryExists = False
        End If
    End Function
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

    Public Function backupmediafiles(ByVal dstdir As String, ByVal dstsubdir As String, ByVal sourcefile As String) As Integer
        Dim bkup As String = dstdir & "\bkup\" & dstsubdir & "\"
        Dim bkupfile As String = bkup & Path.GetFileName(sourcefile)
        If My.Computer.FileSystem.DirectoryExists(bkup) = False Then
            My.Computer.FileSystem.CreateDirectory(bkup)
        End If
        bkupfile = HandleDuplicates(sourcefile, bkupfile)
        If bkupfile IsNot String.Empty Then
            My.Computer.FileSystem.CopyFile(sourcefile, bkupfile, overwrite:=False)
            logmessage("Backup created: " & sourcefile)
        End If
        Return (0)
    End Function
    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtsrc.Text = ""
        pgbar.Minimum = 0
        pgbar.Value = 0
        lblprgs.Text = "0%"
        btnorg.Enabled = True
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        txtlog.Text = ""
        lblprgs.Text = "0%"
    End Sub

    Private Sub btnorg_Click(sender As Object, e As EventArgs) Handles btnorg.Click
        Dim sourcedir As String = Trim(txtsrc.Text)
        Dim destdir As String = Trim(txtdst.Text)
        Dim filecount As Integer = 0
        Dim idx = 0
        Dim outfilename As String
        pgbar.Minimum = 0
        If sourcedir = "" Or isDirectoryExists(sourcedir) = False Then
            MsgBox(sourcedir & "Does not exists!", vbCritical, "INPUT DIRECTORY ERROR")
            logmessage(sourcedir & "Does not exists!")
            txtsrc.Focus()
            Exit Sub
        End If

        If destdir = "" Or isDirectoryExists(destdir) = False Then
            MsgBox(destdir & "Does not exists!", vbCritical, "INPUT DIRECTORY ERROR")
            logmessage(destdir & "Does not exists!")
            txtdst.Focus()
            Exit Sub
        End If
        'backup photos files.
        Dim strphotos = My.Computer.FileSystem.GetFiles(sourcedir, FileIO.SearchOption.SearchTopLevelOnly, "*.jpeg", "*.jpg", "*.bmp")
        Dim strvideofiles = My.Computer.FileSystem.GetFiles(sourcedir, FileIO.SearchOption.SearchTopLevelOnly, "*.avi", "*.mov", "*.mp4", "*.3gp", "*.wmv")
        'backup photos files.
        filecount = strphotos.Count
        idx = 0
        If filecount <> 0 Then
            pgbar.Maximum = filecount
            logmessage("Image file backup started..")
            For Each file As String In strphotos
                backupmediafiles(destdir, "Photos", file)
                idx = idx + 1
                pgbar.Value = idx
                lblprgs.Text = Int((idx / filecount) * 100) & " %"
                MyBase.Update()
            Next
            logmessage("Image file backup completed..")
        End If
        '----------------------------------------------------------------------------------
        'backup video files.
        filecount = strvideofiles.Count
        idx = 0
        If filecount <> 0 Then
            pgbar.Maximum = filecount
            logmessage("Video file backup started..")
            For Each file As String In strvideofiles
                backupmediafiles(destdir, "Videos", file)
                idx = idx + 1
                pgbar.Value = idx
                lblprgs.Text = Int((idx / filecount) * 100) & " %"
                MyBase.Update()
            Next
            logmessage("Video file backup completed..")
        End If
        '----------------------------------------------------------------------------------
        'arrange photos.
        filecount = strphotos.Count
        idx = 0
        If filecount <> 0 Then
            pgbar.Maximum = filecount
            logmessage("Image file processing started..")
            For Each file As String In strphotos
                outfilename = filecreationtime2filename(destdir, file, "Photos")
                outfilename = HandleDuplicates(file, outfilename)
                If outfilename IsNot String.Empty Then
                    My.Computer.FileSystem.MoveFile(file, outfilename, overwrite:=False)
                    logmessage("Moved source: " & file)
                End If
                idx = idx + 1
                pgbar.Value = idx
                lblprgs.Text = Int((idx / filecount) * 100) & " %"
                MyBase.Update()
            Next
            logmessage("Image file processing completed..")
        End If
        '----------------------------------------------------------------------------------
        'arrange Videos.
        filecount = strvideofiles.Count
        idx = 0
        If filecount <> 0 Then
            pgbar.Maximum = filecount
            logmessage("Video file Processing started..")
            For Each file As String In strvideofiles
                outfilename = filecreationtime2filename(destdir, file, "Videos")
                outfilename = HandleDuplicates(file, outfilename)
                If outfilename IsNot String.Empty Then
                    My.Computer.FileSystem.MoveFile(file, outfilename, overwrite:=False)
                    logmessage("Moved source: " & file)
                End If
                idx = idx + 1
                pgbar.Value = idx
                lblprgs.Text = Int((idx / filecount) * 100) & " %"
                MyBase.Update()
            Next
            logmessage("Video file Processing completed..")
        End If
        '----------------------------------------------------------------------------------
        logmessage("End of Arrangements..")
    End Sub
End Class
