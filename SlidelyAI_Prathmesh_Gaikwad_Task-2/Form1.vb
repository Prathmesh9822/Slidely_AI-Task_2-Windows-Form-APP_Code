Imports System.Net.Http

Public Class Form1

    Private ReadOnly httpClient As New HttpClient()

    ' Constructor
    Public Sub New()
        InitializeComponent()

        ' Initialize HttpClient
        httpClient.BaseAddress = New Uri("http://localhost:3000/") ' Replace with your backend URL
        httpClient.DefaultRequestHeaders.Accept.Clear()
        httpClient.DefaultRequestHeaders.Accept.Add(New Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        ' Assign shortcuts
        Me.KeyPreview = True ' Enable form-level key preview
        AddHandler Me.KeyDown, AddressOf Form1_KeyDown ' Hook into the KeyDown event
    End Sub

    ' Handle form-level KeyDown event
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Ctrl + V: View Submission
            Button1.PerformClick() ' Simulate a click on Button1 (View Submission)
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Ctrl + N: Create New Submission
            Button2.PerformClick() ' Simulate a click on Button2 (Create New Submission)
        End If
    End Sub

    ' Handle Click event for View Submission button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create a new instance of the ViewSubmissionsForm
        Dim viewForm As New ViewSubmissionsForm()

        ' Make the new form visible
        viewForm.Show()
    End Sub

    ' Handle Click event for Create New Submission button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Create a new instance of the CreateNewSubmissionForm
        Dim createForm As New CreateNewSubmissionForm()

        ' Make the new form visible
        createForm.Show()
    End Sub
End Class
