Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.OleDb
Imports System.Data.Common

Public Class home
    Public income As String = 0
    Public saving As String = 0
    Public receivedid As String
    Dim t As Integer
    Dim k As Object
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim cb As OleDb.OleDbCommandBuilder
    Dim totalExp As Integer = 0
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = DbConnect()

        Dim sql As String = "select Serial,Description,Amount,Category,Date from History where Date = Date() and userid = " & "'" & receivedid & "'" & " order by Serial DESC"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        cmd = New OleDb.OleDbCommand
        dt = New DataTable
        cb = New OleDb.OleDbCommandBuilder(da)
        da.Fill(dt)
        history.DataSource = dt
        history.Columns(0).HeaderText = "S No."
        history.Columns(1).HeaderText = "Description"
        history.Columns(2).HeaderText = "Amount"
        history.Columns(3).HeaderText = "Category"
        history.Columns(4).HeaderText = "Date"

        history.Columns(0).Width = 30
        history.Columns(2).Width = 70


        Dim sql2 As String = "select * from Profiledata where Userid = " & CInt(receivedid)
        cmd = New OleDb.OleDbCommand(sql2, conn)
        cmd.Connection = conn
        cmd.CommandText = sql2
        Dim reader2 As OleDbDataReader = cmd.ExecuteReader()
        If reader2.HasRows Then
            If reader2.Read() Then
                income = reader2("income").ToString()
                saving = reader2("saving").ToString()
                Dim name As String = reader2("name").ToString()
                welcm_lbl.Text = "Welcome, " & name
                inclbl.Text = "Your Income: ₹" & income



            End If

        End If
        reader2.Close()
        Dim piequery As String = "SELECT Category, SUM(Amount) As TotalAmount From History Where Month(Date) = ? And YEAR(Date) = ? AND userid = ? GROUP BY Category"

        cmd.Connection = conn
        cmd.CommandText = piequery
        cmd.Parameters.AddWithValue("@month", DateTime.Now.Month)
        cmd.Parameters.AddWithValue("@year", DateTime.Now.Year)
        cmd.Parameters.AddWithValue("@userid", receivedid)

        Chart1.Series.Clear()
        Dim exp As New Series("Expense")
        exp.ChartType = SeriesChartType.Pie
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            exp.Points.AddXY("Income", income)

            While reader.Read()

                Dim items As String = reader("Category").ToString()
                Dim amt As String = reader("TotalAmount").ToString()


                exp.Points.AddXY(items, amt)


            End While


        Else
            exp.Points.AddXY("Income", 100)
        End If
        Chart1.Series.Add(exp)
        Chart1.ChartAreas(0).AxisY.Maximum = income
        reader.Close()
        Try

            Dim spent As String = "SELECT SUM(Amount) From History Where Month(Date) = ? And YEAR(Date) = ? AND userid = ?"

            cmd = New OleDb.OleDbCommand(spent, conn)
            cmd.Parameters.AddWithValue("@month", DateTime.Now.Month)
            cmd.Parameters.AddWithValue("@year", DateTime.Now.Year)
            cmd.Parameters.AddWithValue("@userid", receivedid)
            k = cmd.ExecuteScalar()

            Dim resultval As Integer = If(IsDBNull(k), 0, Convert.ToInt32(k))

            Dim daysinmonth As Integer = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)
            Dim currentDay As Integer = Date.Now.Day

            Dim remainingdays As Integer = daysinmonth - currentDay
            Dim availableToSpend As Decimal = CInt(income) - resultval - CInt(saving)
            If availableToSpend >= 0 Then
                Dim dailySpendingLimit As Decimal = availableToSpend / remainingdays
                savelbl.Text = "Safe To Spend: ₹" & CInt(dailySpendingLimit) & " per day"
            Else
                savelbl.Text = "Safe To Spend: ₹0 per day"
            End If
            remain_lbl.Text = "Remaining Balance: ₹" & availableToSpend
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Input Error")
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim addfrm As New Add()
        addfrm.receivedid = receivedid
        addfrm.Show()
        Me.Close()


    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim his_frm As New historyform
        his_frm.receivedid = receivedid
        his_frm.Show()
    End Sub



    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click

        profile.receivedid = receivedid
        profile.Show()
        Me.Close()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim loginfrm As New Login()
        loginfrm.Show()
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.Refresh()
    End Sub

End Class