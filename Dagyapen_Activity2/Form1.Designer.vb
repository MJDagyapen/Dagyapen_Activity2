<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtfirstnum = New TextBox()
        Label2 = New Label()
        txtsecondnum = New TextBox()
        Btn1 = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Number"
        ' 
        ' txtfirstnum
        ' 
        txtfirstnum.Location = New Point(0, 18)
        txtfirstnum.Name = "txtfirstnum"
        txtfirstnum.Size = New Size(100, 23)
        txtfirstnum.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 15)
        Label2.TabIndex = 2
        Label2.Text = "Second Number"
        ' 
        ' txtsecondnum
        ' 
        txtsecondnum.Location = New Point(0, 62)
        txtsecondnum.Name = "txtsecondnum"
        txtsecondnum.Size = New Size(100, 23)
        txtsecondnum.TabIndex = 3
        ' 
        ' Btn1
        ' 
        Btn1.Location = New Point(1, 91)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(75, 23)
        Btn1.TabIndex = 4
        Btn1.Text = "Subtract"
        Btn1.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(1, 133)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(46, 15)
        lblResult.TabIndex = 5
        lblResult.Text = "Answer"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(Btn1)
        Controls.Add(txtsecondnum)
        Controls.Add(Label2)
        Controls.Add(txtfirstnum)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtfirstnum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsecondnum As TextBox
    Friend WithEvents Btn1 As Button
    Friend WithEvents lblResult As Label
End Class
