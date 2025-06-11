<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historyform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(historyform))
        Fullhistory = New DataGridView()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Label3 = New Label()
        search_btn = New Button()
        CType(Fullhistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Fullhistory
        ' 
        Fullhistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Fullhistory.Location = New Point(12, 77)
        Fullhistory.Name = "Fullhistory"
        Fullhistory.Size = New Size(438, 336)
        Fullhistory.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(148, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 29)
        Label1.TabIndex = 1
        Label1.Text = "HISTORY"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(329, 48)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(267, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 3
        Label2.Text = "Catogory"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Delete"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(93, 51)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 5
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = ""
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(12, 419)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.ShowCheckBox = True
        DateTimePicker1.Size = New Size(95, 23)
        DateTimePicker1.TabIndex = 6
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(139, 419)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.ShowCheckBox = True
        DateTimePicker2.Size = New Size(98, 23)
        DateTimePicker2.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(113, 425)
        Label3.Name = "Label3"
        Label3.Size = New Size(20, 15)
        Label3.TabIndex = 8
        Label3.Text = "To"
        ' 
        ' search_btn
        ' 
        search_btn.Location = New Point(268, 420)
        search_btn.Name = "search_btn"
        search_btn.Size = New Size(75, 23)
        search_btn.TabIndex = 9
        search_btn.Text = "Search"
        search_btn.UseVisualStyleBackColor = True
        ' 
        ' historyform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(463, 450)
        Controls.Add(search_btn)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(Fullhistory)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "historyform"
        Text = "History"
        CType(Fullhistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Fullhistory As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents search_btn As Button
End Class
