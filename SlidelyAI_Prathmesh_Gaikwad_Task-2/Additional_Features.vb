Imports System.Net.Http
Imports System.Net.Http.Json
Imports System.Text
Imports Newtonsoft.Json
Imports SlidelyAI_Prathmesh_Gaikwad_Task_2.ViewSubmissionsForm

Public Class Additional_Features
    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GitHub_Link As String
        Public Property Stopwatch_Time As String ' Assuming Stopwatch_Time is a formatted string
    End Class

    ' Handles the Search button click event
    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchEmail As String = txtSearchEmail.Text.Trim()

        ' Validate the search email (optional)
        If String.IsNullOrEmpty(searchEmail) OrElse searchEmail = "Enter Search Email Here" Then
            MessageBox.Show("Please enter a valid email address to search.")
            Return
        End If

        Try
            Using client As New HttpClient()
                client.BaseAddress = New Uri("http://localhost:3000/")

                ' Send GET request to /search endpoint with email as query parameter
                Dim response = Await client.GetAsync($"search?email={searchEmail}")

                If response.IsSuccessStatusCode Then
                    ' Read response content as string
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()

                    ' Deserialize JSON array to list of Submission objects
                    Dim submissions As List(Of Submission) = JsonConvert.DeserializeObject(Of List(Of Submission))(jsonResponse)

                    ' Display the first submission's details in the text boxes
                    If submissions.Count > 0 Then
                        Dim submission As Submission = submissions(0) ' Assuming only one submission is expected per email
                        txtName.Text = submission.Name
                        txtEmail.Text = submission.Email
                        txtPhone.Text = submission.Phone
                        txtGithubLink.Text = submission.GitHub_Link
                        txtStopwatchTime.Text = submission.Stopwatch_Time
                    Else
                        MessageBox.Show("No submissions found for the provided email.")
                    End If
                Else
                    ' Handle unsuccessful response
                    MessageBox.Show($"Error searching submissions: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error searching submissions: {ex.Message}")
        End Try
    End Sub

    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Retrieve the ID from txtid
        Dim id As Integer
        If Not Integer.TryParse(txtid.Text.Trim(), id) Then
            MessageBox.Show("Please enter a valid ID.")
            Return
        End If

        ' Validate the submission data
        Dim name As String = txtName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()
        Dim githubLink As String = txtGithubLink.Text.Trim()
        Dim stopwatchTime As String = txtStopwatchTime.Text.Trim()

        If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(phone) OrElse String.IsNullOrEmpty(githubLink) OrElse String.IsNullOrEmpty(stopwatchTime) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Prepare the updated submission data
        Dim updatedSubmission As New With {
            .name = name,
            .email = email,
            .phone = phone,
            .github_link = githubLink,
            .stopwatch_time = stopwatchTime
        }

        Try
            Using client As New HttpClient()
                client.BaseAddress = New Uri("http://localhost:3000/")

                ' Send PUT request to /update endpoint with index as query parameter and updatedSubmission as JSON body
                Dim response = Await client.PutAsJsonAsync($"update?index={id}", updatedSubmission)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission updated successfully!")
                Else
                    MessageBox.Show($"Error updating submission: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating submission: {ex.Message}")
        End Try
    End Sub

    ' Handles the txtid text box enter event

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Retrieve the ID from txtid
        Dim id As Integer
        If Not Integer.TryParse(txtid.Text.Trim(), id) Then
            MessageBox.Show("Please enter a valid ID.")
            Return
        End If

        Try
            Using client As New HttpClient()
                client.BaseAddress = New Uri("http://localhost:3000/")

                ' Send DELETE request to /delete/:index endpoint with id as part of the URL
                Dim response = Await client.DeleteAsync($"delete?index={id}")

                If response.IsSuccessStatusCode Then
                    MessageBox.Show($"Submission at index {id} deleted successfully!")
                    ' Optionally, clear text boxes after successful deletion
                    ClearTextBoxes()
                Else
                    MessageBox.Show($"Error deleting submission: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error deleting submission: {ex.Message}")
        End Try
    End Sub

    ' Handles the txtid text box enter event
    Private Sub txtid_Enter(sender As Object, e As EventArgs) Handles txtid.Enter
        ' Clear the default text if it matches the placeholder
        If txtid.Text = "Enter Id you Want to edit or delete Here" Then
            txtid.Text = ""
        End If
    End Sub

    ' Method to clear all text boxes
    Private Sub ClearTextBoxes()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGithubLink.Text = ""
        txtStopwatchTime.Text = ""
    End Sub

End Class
