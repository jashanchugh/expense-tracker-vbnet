<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        addtxtbox = New TextBox()
        amttxtbox = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        addbtn = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        cancel_btn = New Button()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(95, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 44)
        Label1.TabIndex = 0
        Label1.Text = "Add Expense"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 1
        Label2.Text = "Description"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(49, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 2
        Label3.Text = "Amount"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(49, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 3
        Label4.Text = "Category"
        ' 
        ' addtxtbox
        ' 
        addtxtbox.Location = New Point(181, 84)
        addtxtbox.Name = "addtxtbox"
        addtxtbox.Size = New Size(185, 23)
        addtxtbox.TabIndex = 4
        ' 
        ' amttxtbox
        ' 
        amttxtbox.Location = New Point(181, 135)
        amttxtbox.Name = "amttxtbox"
        amttxtbox.Size = New Size(100, 23)
        amttxtbox.TabIndex = 5
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(184, 204)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(58, 19)
        RadioButton1.TabIndex = 6
        RadioButton1.TabStop = True
        RadioButton1.Text = "Home"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(184, 229)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(84, 19)
        RadioButton2.TabIndex = 7
        RadioButton2.TabStop = True
        RadioButton2.Text = "Investment"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(184, 254)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(123, 19)
        RadioButton3.TabIndex = 8
        RadioButton3.TabStop = True
        RadioButton3.Text = "Secondary Income"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' addbtn
        ' 
        addbtn.Location = New Point(116, 323)
        addbtn.Name = "addbtn"
        addbtn.Size = New Size(75, 23)
        addbtn.TabIndex = 9
        addbtn.Text = "ADD"
        addbtn.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' cancel_btn
        ' 
        cancel_btn.Location = New Point(219, 323)
        cancel_btn.Name = "cancel_btn"
        cancel_btn.Size = New Size(75, 23)
        cancel_btn.TabIndex = 10
        cancel_btn.Text = "Cancel"
        cancel_btn.UseVisualStyleBackColor = True
        ' 
        ' Add
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(463, 450)
        Controls.Add(cancel_btn)
        Controls.Add(addbtn)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(amttxtbox)
        Controls.Add(addtxtbox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Add"
        Text = "Add"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents addtxtbox As TextBox
    Friend WithEvents amttxtbox As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents addbtn As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents cancel_btn As Button
End Class
