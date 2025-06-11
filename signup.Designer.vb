<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(signup))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        newuser = New TextBox()
        passtxt = New TextBox()
        repasstxt = New TextBox()
        createacc_btn = New Button()
        Label5 = New Label()
        Button2 = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(111, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(187, 46)
        Label1.TabIndex = 0
        Label1.Text = "SIGN UP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter Gmail"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 15)
        Label3.TabIndex = 2
        Label3.Text = "Enter Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 15)
        Label4.TabIndex = 3
        Label4.Text = "Re-Enter Password"
        ' 
        ' newuser
        ' 
        newuser.Location = New Point(215, 87)
        newuser.Name = "newuser"
        newuser.Size = New Size(138, 23)
        newuser.TabIndex = 4
        ' 
        ' passtxt
        ' 
        passtxt.Location = New Point(215, 138)
        passtxt.Name = "passtxt"
        passtxt.PasswordChar = "*"c
        passtxt.Size = New Size(138, 23)
        passtxt.TabIndex = 5
        ' 
        ' repasstxt
        ' 
        repasstxt.Location = New Point(215, 188)
        repasstxt.Name = "repasstxt"
        repasstxt.PasswordChar = "*"c
        repasstxt.Size = New Size(138, 23)
        repasstxt.TabIndex = 6
        ' 
        ' createacc_btn
        ' 
        createacc_btn.Location = New Point(144, 247)
        createacc_btn.Name = "createacc_btn"
        createacc_btn.Size = New Size(103, 32)
        createacc_btn.TabIndex = 7
        createacc_btn.Text = "Create Account"
        createacc_btn.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(84, 339)
        Label5.Name = "Label5"
        Label5.Size = New Size(148, 15)
        Label5.TabIndex = 8
        Label5.Text = "Already Have An Account?"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(238, 335)
        Button2.Name = "Button2"
        Button2.Size = New Size(60, 23)
        Button2.TabIndex = 9
        Button2.Text = "Sign In"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' signup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(463, 450)
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(createacc_btn)
        Controls.Add(repasstxt)
        Controls.Add(passtxt)
        Controls.Add(newuser)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "signup"
        Text = "signup"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents newuser As TextBox
    Friend WithEvents passtxt As TextBox
    Friend WithEvents repasstxt As TextBox
    Friend WithEvents createacc_btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
