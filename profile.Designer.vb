<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profile))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        sav_lbl = New Label()
        usertxtbox = New TextBox()
        savetxtbox = New TextBox()
        incometxtbox = New TextBox()
        profile_btn = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        Cnclbtn = New Button()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(165, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 46)
        Label1.TabIndex = 0
        Label1.Text = "Profile"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(122, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter Your Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(122, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 15)
        Label3.TabIndex = 2
        Label3.Text = "Set Your Income"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 167)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 3
        ' 
        ' sav_lbl
        ' 
        sav_lbl.AutoSize = True
        sav_lbl.Location = New Point(65, 126)
        sav_lbl.Name = "sav_lbl"
        sav_lbl.Size = New Size(219, 15)
        sav_lbl.TabIndex = 4
        sav_lbl.Text = "How much do you want to save? (in Rs.)"
        ' 
        ' usertxtbox
        ' 
        usertxtbox.Location = New Point(305, 65)
        usertxtbox.Name = "usertxtbox"
        usertxtbox.Size = New Size(100, 23)
        usertxtbox.TabIndex = 5
        ' 
        ' savetxtbox
        ' 
        savetxtbox.Location = New Point(305, 123)
        savetxtbox.Name = "savetxtbox"
        savetxtbox.Size = New Size(100, 23)
        savetxtbox.TabIndex = 6
        ' 
        ' incometxtbox
        ' 
        incometxtbox.Location = New Point(305, 94)
        incometxtbox.Name = "incometxtbox"
        incometxtbox.Size = New Size(100, 23)
        incometxtbox.TabIndex = 7
        ' 
        ' profile_btn
        ' 
        profile_btn.Location = New Point(122, 231)
        profile_btn.Name = "profile_btn"
        profile_btn.Size = New Size(75, 23)
        profile_btn.TabIndex = 8
        profile_btn.Text = "Save"
        profile_btn.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Cnclbtn
        ' 
        Cnclbtn.Location = New Point(220, 231)
        Cnclbtn.Name = "Cnclbtn"
        Cnclbtn.Size = New Size(75, 23)
        Cnclbtn.TabIndex = 9
        Cnclbtn.Text = "Cancel"
        Cnclbtn.UseVisualStyleBackColor = True
        ' 
        ' profile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(463, 450)
        Controls.Add(Cnclbtn)
        Controls.Add(profile_btn)
        Controls.Add(incometxtbox)
        Controls.Add(savetxtbox)
        Controls.Add(usertxtbox)
        Controls.Add(sav_lbl)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "profile"
        Text = "profile"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sav_lbl As Label
    Friend WithEvents usertxtbox As TextBox
    Friend WithEvents savetxtbox As TextBox
    Friend WithEvents incometxtbox As TextBox
    Friend WithEvents profile_btn As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Cnclbtn As Button
End Class
