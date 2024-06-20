<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Additional_Features
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Label1 = New Label()
        txtSearchEmail = New TextBox()
        btnSearch = New Button()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnEdit = New Button()
        btnDelete = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtid = New TextBox()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(127, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(574, 30)
        Label1.TabIndex = 0
        Label1.Text = "Prathmesh Gaikwad SlidelyAI Task 2- Additional Features"
        ' 
        ' txtSearchEmail
        ' 
        txtSearchEmail.Location = New Point(239, 66)
        txtSearchEmail.Name = "txtSearchEmail"
        txtSearchEmail.Size = New Size(246, 23)
        txtSearchEmail.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(79, 66)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(145, 23)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(239, 95)
        txtName.Name = "txtName"
        txtName.Size = New Size(246, 23)
        txtName.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(239, 153)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(246, 23)
        txtEmail.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(239, 124)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(246, 23)
        txtPhone.TabIndex = 6
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(239, 182)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(246, 23)
        txtGithubLink.TabIndex = 7
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(239, 211)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(246, 23)
        txtStopwatchTime.TabIndex = 8
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(79, 303)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(164, 55)
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit Form"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(321, 303)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(164, 55)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(79, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 11
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(79, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 12
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(79, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 13
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(79, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 15)
        Label5.TabIndex = 14
        Label5.Text = "GitHub Link"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(79, 219)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 15)
        Label6.TabIndex = 15
        Label6.Text = "StopWatch Time"
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(239, 274)
        txtid.Name = "txtid"
        txtid.Size = New Size(246, 23)
        txtid.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(79, 273)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 20)
        Label7.TabIndex = 17
        Label7.Text = "Enter Id " & vbCrLf
        ' 
        ' Additional_Features
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(txtid)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnSearch)
        Controls.Add(txtSearchEmail)
        Controls.Add(Label1)
        Name = "Additional_Features"
        Text = "Additional_Features"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchEmail As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label7 As Label


End Class
