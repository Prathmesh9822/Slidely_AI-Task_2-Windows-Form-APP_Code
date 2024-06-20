<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtphone = New TextBox()
        txtgit = New TextBox()
        btnStopwatch = New Button()
        Button2 = New Button()
        timerStopwatch = New Timer(components)
        Label2 = New Label()
        Label3 = New Label()
        lablephone = New Label()
        lablegit = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(116, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(546, 30)
        Label1.TabIndex = 0
        Label1.Text = "Prathmesh Gaikwad, Slidely Task-2, Create Submission"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(417, 61)
        txtName.Name = "txtName"
        txtName.Size = New Size(288, 23)
        txtName.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(417, 90)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(288, 23)
        txtEmail.TabIndex = 2
        ' 
        ' txtphone
        ' 
        txtphone.Location = New Point(417, 119)
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(288, 23)
        txtphone.TabIndex = 3
        ' 
        ' txtgit
        ' 
        txtgit.Location = New Point(417, 148)
        txtgit.Name = "txtgit"
        txtgit.Size = New Size(288, 23)
        txtgit.TabIndex = 4
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnStopwatch.Location = New Point(84, 191)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(212, 40)
        btnStopwatch.TabIndex = 5
        btnStopwatch.Text = "Toggle Stopwatch (CTRL + T)"
        btnStopwatch.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(54, 246)
        Button2.Name = "Button2"
        Button2.Size = New Size(651, 36)
        Button2.TabIndex = 6
        Button2.Text = "Submit ( CTRL + S )"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(84, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 7
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(87, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 8
        Label3.Text = "Email"
        ' 
        ' lablephone
        ' 
        lablephone.AutoSize = True
        lablephone.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lablephone.Location = New Point(84, 127)
        lablephone.Name = "lablephone"
        lablephone.Size = New Size(86, 20)
        lablephone.TabIndex = 9
        lablephone.Text = "Phone Num"
        ' 
        ' lablegit
        ' 
        lablegit.AutoSize = True
        lablegit.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lablegit.Location = New Point(84, 156)
        lablegit.Name = "lablegit"
        lablegit.Size = New Size(86, 20)
        lablegit.TabIndex = 10
        lablegit.Text = "GitHub Link"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(529, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 20)
        Label6.TabIndex = 11
        Label6.Text = "00:00:00"
        ' 
        ' CreateNewSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(lablegit)
        Controls.Add(lablephone)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(btnStopwatch)
        Controls.Add(txtgit)
        Controls.Add(txtphone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Name = "CreateNewSubmissionForm"
        Text = "CreateNewSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtgit As TextBox
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents timerStopwatch As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lablephone As Label
    Friend WithEvents lablegit As Label
    Friend WithEvents Label6 As Label
End Class
