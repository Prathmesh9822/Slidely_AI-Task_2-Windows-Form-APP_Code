Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateNewSubmissionForm
    Private stopwatch As Stopwatch = New Stopwatch()
    Private timer As Timer = New Timer()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer.Interval = 1000
        AddHandler timer.Tick, AddressOf UpdateStopwatch

        ' Enable form-level key preview
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf CreateNewSubmissionForm_KeyDown
    End Sub

    ' KeyDown event handler
    Private Sub CreateNewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.S Then
            Button2_Click(Nothing, Nothing) ' Simulate a click on the submit button
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnStopwatch_Click(Nothing, Nothing) ' Simulate a click on the stopwatch toggle button
        End If
    End Sub

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
            btnStopwatch.Text = "Resume"
        Else
            stopwatch.Start()
            timer.Start()
            btnStopwatch.Text = "Pause"
        End If
    End Sub

    Private Sub UpdateStopwatch(sender As Object, e As EventArgs)
        Label6.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:3000/")
            Dim stopwatchTimeFormatted As String = stopwatch.Elapsed.ToString("hh\:mm\:ss")

            ' Serialize the data as JSON
            Dim submissionData As New With {
                .name = txtName.Text,
                .email = txtEmail.Text,
                .phone = txtphone.Text,
                .github_link = txtgit.Text,
                .stopwatch_time = stopwatchTimeFormatted
            }
            Dim jsonContent As String = JsonConvert.SerializeObject(submissionData)
            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

            Try
                Dim response = Await client.PostAsync("submit", content)
                If response.IsSuccessStatusCode Then
                    Dim responseString = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show("Submission successful.")
                Else
                    Dim errorMessage = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show($"Error submitting data: {errorMessage}")
                End If
            Catch ex As Exception
                MessageBox.Show($"Error submitting data: {ex.Message}")
            End Try
        End Using
    End Sub
End Class
