<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        ListBox1 = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Nameview = New TextBox()
        previousbtn = New Button()
        nextbtn = New Button()
        EmailView = New TextBox()
        Phoneview = New TextBox()
        githubview = New TextBox()
        stopwatchview = New TextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(399, 56)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(120, 34)
        ListBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(70, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(70, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(70, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 3
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(70, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 15)
        Label4.TabIndex = 4
        Label4.Text = "Github Link"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(70, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 15)
        Label5.TabIndex = 5
        Label5.Text = "StopWatch Time"
        ' 
        ' Nameview
        ' 
        Nameview.Location = New Point(233, 67)
        Nameview.Name = "Nameview"
        Nameview.ReadOnly = True
        Nameview.Size = New Size(100, 23)
        Nameview.TabIndex = 6
        ' 
        ' previousbtn
        ' 
        previousbtn.Location = New Point(51, 300)
        previousbtn.Name = "previousbtn"
        previousbtn.Size = New Size(125, 38)
        previousbtn.TabIndex = 7
        previousbtn.Text = "Previous (CTRL + P) "
        previousbtn.UseVisualStyleBackColor = True
        ' 
        ' nextbtn
        ' 
        nextbtn.Location = New Point(208, 300)
        nextbtn.Name = "nextbtn"
        nextbtn.Size = New Size(125, 38)
        nextbtn.TabIndex = 8
        nextbtn.Text = "Next (CTRL + N)"
        nextbtn.UseVisualStyleBackColor = True
        ' 
        ' EmailView
        ' 
        EmailView.Location = New Point(233, 96)
        EmailView.Name = "EmailView"
        EmailView.ReadOnly = True
        EmailView.Size = New Size(100, 23)
        EmailView.TabIndex = 9
        ' 
        ' Phoneview
        ' 
        Phoneview.Location = New Point(233, 125)
        Phoneview.Name = "Phoneview"
        Phoneview.ReadOnly = True
        Phoneview.Size = New Size(100, 23)
        Phoneview.TabIndex = 10
        ' 
        ' githubview
        ' 
        githubview.Location = New Point(233, 154)
        githubview.Name = "githubview"
        githubview.ReadOnly = True
        githubview.Size = New Size(100, 23)
        githubview.TabIndex = 11
        ' 
        ' stopwatchview
        ' 
        stopwatchview.Location = New Point(233, 183)
        stopwatchview.Name = "stopwatchview"
        stopwatchview.ReadOnly = True
        stopwatchview.Size = New Size(100, 23)
        stopwatchview.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(70, 22)
        Label6.Name = "Label6"
        Label6.Size = New Size(264, 30)
        Label6.TabIndex = 13
        Label6.Text = "Slidely Task-2,Slidely Form App VIEW Submission" & vbCrLf & vbCrLf
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 450)
        Controls.Add(Label6)
        Controls.Add(stopwatchview)
        Controls.Add(githubview)
        Controls.Add(Phoneview)
        Controls.Add(EmailView)
        Controls.Add(nextbtn)
        Controls.Add(previousbtn)
        Controls.Add(Nameview)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListBox1)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Nameview As TextBox
    Friend WithEvents previousbtn As Button
    Friend WithEvents nextbtn As Button
    Friend WithEvents EmailView As TextBox
    Friend WithEvents Phoneview As TextBox
    Friend WithEvents githubview As TextBox
    Friend WithEvents stopwatchview As TextBox
    Friend WithEvents Label6 As Label
End Class
