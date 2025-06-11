<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        user_value = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        user_pass = New TextBox()
        Btn_login = New Button()
        Label5 = New Label()
        Button2 = New Button()
        Botmtxt = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' user_value
        ' 
        user_value.Location = New Point(216, 84)
        user_value.Name = "user_value"
        user_value.Size = New Size(169, 23)
        user_value.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.InfoText
        Label1.Location = New Point(100, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 29)
        Label1.TabIndex = 1
        Label1.Text = "EXPENSE TRACKER"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 2
        Label2.Text = "USERNAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(65, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 3
        Label3.Text = "PASSWORD"
        ' 
        ' user_pass
        ' 
        user_pass.Location = New Point(216, 142)
        user_pass.Name = "user_pass"
        user_pass.PasswordChar = "*"c
        user_pass.Size = New Size(169, 23)
        user_pass.TabIndex = 4
        ' 
        ' Btn_login
        ' 
        Btn_login.Location = New Point(155, 197)
        Btn_login.Name = "Btn_login"
        Btn_login.Size = New Size(100, 32)
        Btn_login.TabIndex = 5
        Btn_login.Text = "LOG IN"
        Btn_login.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(78, 271)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 15)
        Label5.TabIndex = 7
        Label5.Text = "Don't have an account? "
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(237, 267)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 8
        Button2.Text = "Sign Up"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Botmtxt
        ' 
        Botmtxt.AutoSize = True
        Botmtxt.Location = New Point(142, 426)
        Botmtxt.Name = "Botmtxt"
        Botmtxt.Size = New Size(133, 15)
        Botmtxt.TabIndex = 9
        Botmtxt.Text = "Made With ❤️ In Punjab"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(463, 450)
        Controls.Add(Botmtxt)
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(Btn_login)
        Controls.Add(user_pass)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(user_value)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Login"
        Text = "Expense Tracker"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents user_value As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents user_pass As TextBox
    Friend WithEvents Btn_login As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Botmtxt As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
