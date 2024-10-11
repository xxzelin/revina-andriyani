Imports System.IO
Public Class Form1

    Private Sub driveList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles driveList.SelectedIndexChanged
        folderList.Items.Clear()

        Try
            Dim drive As DriveInfo = DirectCast(driveList.SelectedItem, DriveInfo)

            For Each dirinfo As DirectoryInfo In drive.RootDirectory.GetDirectories()
                folderList.Items.Add(dirinfo)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each di As DriveInfo In DriveInfo.GetDrives()
            driveList.Items.Add(di)
        Next
    End Sub

    Private Sub folderList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles folderList.SelectedIndexChanged
        filesList.Items.Clear()

        Dim dir As DirectoryInfo = DirectCast(folderList.SelectedItem, DirectoryInfo)
        For Each fi As FileInfo In dir.GetFiles()
            filesList.Items.Add(fi)
        Next

    End Sub
End Class