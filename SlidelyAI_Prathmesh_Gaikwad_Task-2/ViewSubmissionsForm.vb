Imports System.Net.Http
Imports Newtonsoft.Json ' Ensure you have installed the Newtonsoft.Json NuGet package

Public Class ViewSubmissionsForm
    Private index As Integer = 0
    Private submissions As List(Of Submission) = New List(Of Submission)()

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Enable form-level key preview
        AddHandler Me.KeyDown, AddressOf ViewSubmissionsForm_KeyDown ' Hook into the KeyDown event
        Await LoadSubmission(index)
    End Sub

    ' KeyDown event handler
    Private Async Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Await previousbtn_Click(Nothing, Nothing) ' Simulate a click on the previous button
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Await nextbtn_Click(Nothing, Nothing) ' Simulate a click on the next button
        End If
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Try
            Using client As New HttpClient()
                client.BaseAddress = New Uri("http://localhost:3000/")
                Dim response = Await client.GetAsync($"read?index={index}")

                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()
                    Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(json)
                    DisplaySubmission(submission)
                Else
                    MessageBox.Show($"Error fetching submission: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading submission: {ex.Message}")
        End Try
    End Function

    Private Sub DisplaySubmission(submission As Submission)
        ' Update UI controls with submission data
        Nameview.Text = submission.Name
        EmailView.Text = submission.Email
        Phoneview.Text = submission.Phone
        githubview.Text = submission.GitHub_Link
        stopwatchview.Text = submission.Stopwatch_Time.ToString '("hh\:mm\:ss") ' Format the time string
    End Sub

    Private Async Function previousbtn_Click(sender As Object, e As EventArgs) As Task Handles previousbtn.Click
        If index > 0 Then
            index -= 1
            Await LoadSubmission(index)
        Else
            MessageBox.Show("No previous submission available.")
        End If
    End Function

    Private Async Function nextbtn_Click(sender As Object, e As EventArgs) As Task Handles nextbtn.Click
        index += 1
        Await LoadSubmission(index)
    End Function

    ' Define Submission class structure (replace with actual structure)
    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GitHub_Link As String
        Public Property Stopwatch_Time As String ' Assuming Stopwatch_Time is a formatted string
    End Class
End Class
