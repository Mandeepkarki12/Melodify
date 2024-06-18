Imports System.IO
Imports NAudio.Wave
Public Class test
    Public sql As New SQLControl
    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize SQL connection
    End Sub
    Public Sub musicSave(filePath As String)
        Try
            If Not sql.hasConnection() Then
                MessageBox.Show("Connection to the database failed.")
                Return
            End If
            ' Read file data
            Dim fileData As Byte() = File.ReadAllBytes(filePath)
            ' Insert file data into database
            Dim query As String = "INSERT INTO PreSongs (Title, SongData) VALUES ('Farkanna Hola', @SongData)"
            sql.AddParam("@SongData", fileData)
            sql.ExecQuery(query)
            ' Check for exceptions
            If Not String.IsNullOrEmpty(sql.Exception) Then
                MessageBox.Show("An error occurred during SQL query execution: " & sql.Exception)
            Else
                MessageBox.Show("Data inserted successfully.")
            End If
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Call musicSave method with the file path
        musicSave("C:\Users\karki\Downloads\Farkanna Hola ( Official Lyrical Video ) #shotoniphone.mp3")

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim sql As New SQLControl()
            ' Retrieve song data from database
            Dim query As String = "SELECT SongData FROM PreSongs WHERE Title = 'Farkanna Hola'"
            sql.ExecQuery(query)
            ' Check for exceptions
            If Not String.IsNullOrEmpty(sql.Exception) Then
                MessageBox.Show("An error occurred during SQL query execution: " & sql.Exception)
                Return
            End If
            ' Check if there's any data returned
            If sql.RecordCount > 0 Then
                ' Get song data
                Dim songData As Byte() = DirectCast(sql.SQLDS.Tables(0).Rows(0)("SongData"), Byte())

                ' Your code to play audio using NAudio
                ' (Refer to the previous example for how to play audio with NAudio)
                Dim tempFilePath As String = Path.GetTempFileName()
                File.WriteAllBytes(tempFilePath, songData)

                ' Play audio using NAudio
                Using audioFileReader As New AudioFileReader(tempFilePath)
                    Using outputDevice As New WaveOutEvent()
                        outputDevice.Init(audioFileReader)
                        outputDevice.Play()

                        ' Wait until playback finishes
                        While outputDevice.PlaybackState = PlaybackState.Playing
                            System.Threading.Thread.Sleep(100)
                        End While
                    End Using
                End Using
                ' Delete temporary file after playback
                File.Delete(tempFilePath)
            Else
                MessageBox.Show("No song found with the specified title.")
            End If
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class
