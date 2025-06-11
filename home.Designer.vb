<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Label1 = New Label()
        Chart1 = New DataVisualization.Charting.Chart()
        Label2 = New Label()
        inclbl = New Label()
        history = New DataGridView()
        Button2 = New Button()
        Button1 = New Button()
        MenuStrip1 = New MenuStrip()
        ProfileToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        welcm_lbl = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        RefreshToolStripMenuItem = New ToolStripMenuItem()
        savelbl = New Label()
        remain_lbl = New Label()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        CType(history, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(118, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 24)
        Label1.TabIndex = 0
        Label1.Text = "EXPENSE TRACKER"
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(35, 68)
        Chart1.Name = "Chart1"
        Chart1.Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(191, 140)
        Chart1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(96, 211)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 2
        Label2.Text = "EXPENSE"
        ' 
        ' inclbl
        ' 
        inclbl.AutoSize = True
        inclbl.Location = New Point(243, 119)
        inclbl.Name = "inclbl"
        inclbl.Size = New Size(83, 15)
        inclbl.TabIndex = 4
        inclbl.Text = "Your Income : "
        ' 
        ' history
        ' 
        history.BorderStyle = BorderStyle.Fixed3D
        history.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        history.Location = New Point(22, 288)
        history.Name = "history"
        history.Size = New Size(429, 150)
        history.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ImageAlign = Drawing.ContentAlignment.MiddleLeft
        Button2.Location = New Point(349, 254)
        Button2.Margin = New Padding(3, 0, 3, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 28)
        Button2.TabIndex = 7
        Button2.Text = "Add Expense"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(22, 254)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 28)
        Button1.TabIndex = 8
        Button1.Text = "Full History"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Salmon
        MenuStrip1.Items.AddRange(New ToolStripItem() {ProfileToolStripMenuItem, LogOutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(463, 24)
        MenuStrip1.TabIndex = 9
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ProfileToolStripMenuItem
        ' 
        ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        ProfileToolStripMenuItem.Size = New Size(53, 20)
        ProfileToolStripMenuItem.Text = "Profile"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(65, 20)
        LogOutToolStripMenuItem.Text = "Log Out "
        ' 
        ' welcm_lbl
        ' 
        welcm_lbl.AutoSize = True
        welcm_lbl.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        welcm_lbl.Location = New Point(232, 68)
        welcm_lbl.Name = "welcm_lbl"
        welcm_lbl.Size = New Size(105, 22)
        welcm_lbl.TabIndex = 10
        welcm_lbl.Text = "Welcome, "
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {RefreshToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(114, 26)
        ' 
        ' RefreshToolStripMenuItem
        ' 
        RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        RefreshToolStripMenuItem.Size = New Size(113, 22)
        RefreshToolStripMenuItem.Text = "Refresh"
        ' 
        ' savelbl
        ' 
        savelbl.AutoSize = True
        savelbl.Location = New Point(242, 153)
        savelbl.Name = "savelbl"
        savelbl.Size = New Size(84, 15)
        savelbl.TabIndex = 11
        savelbl.Text = "Safe To Spend:"
        ' 
        ' remain_lbl
        ' 
        remain_lbl.AutoSize = True
        remain_lbl.Location = New Point(242, 193)
        remain_lbl.Name = "remain_lbl"
        remain_lbl.Size = New Size(111, 15)
        remain_lbl.TabIndex = 12
        remain_lbl.Text = "Remaining Balance:"
        ' 
        ' home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = Color.WhiteSmoke
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(463, 450)
        Controls.Add(remain_lbl)
        Controls.Add(savelbl)
        Controls.Add(welcm_lbl)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(history)
        Controls.Add(inclbl)
        Controls.Add(Label2)
        Controls.Add(Chart1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "home"
        Text = "Home"
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        CType(history, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents inclbl As Label
    Friend WithEvents history As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents welcm_lbl As Label
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents savelbl As Label
    Friend WithEvents remain_lbl As Label
End Class
