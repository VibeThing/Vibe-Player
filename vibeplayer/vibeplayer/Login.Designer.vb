<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Code SemiBold", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(133, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 106)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Code SemiBold", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(528, 52)
        Label2.TabIndex = 1
        Label2.Text = "Welcome to Vibe Thing!"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = My.Resources.Resources.discord
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Location = New Point(221, 286)
        Button1.Name = "Button1"
        Button1.Size = New Size(40, 40)
        Button1.TabIndex = 2
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources.favicon__1__2
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.Location = New Point(276, 286)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 40)
        Button2.TabIndex = 3
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(221, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 20)
        Label3.TabIndex = 4
        Label3.Text = "Connect with"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(551, 398)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Login"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label

End Class
