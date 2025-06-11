Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices

Public Class historyform
    Public receivedid As String
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim i, t As Integer
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim cb As OleDb.OleDbCommandBuilder


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = DbConnect()


        Dim sql As String = "select Serial,Description,Amount,Category,Date from History where userid = " & "'" & receivedid & "'" & " order by Serial DESC"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        cmd = New OleDb.OleDbCommand
        dt = New DataTable
        cb = New OleDb.OleDbCommandBuilder(da)
        da.Fill(dt)
        Fullhistory.DataSource = dt
        Fullhistory.Columns(0).HeaderText = "S No."
        Fullhistory.Columns(1).HeaderText = "Description"
        Fullhistory.Columns(2).HeaderText = "Amount"
        Fullhistory.Columns(3).HeaderText = "Category"
        Fullhistory.Columns(4).HeaderText = "Date"

        Fullhistory.Columns(0).Width = 30
        Fullhistory.Columns(2).Width = 70

        cmd.Connection = conn
        cmd.CommandText = sql
        t = cmd.ExecuteNonQuery()
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.HasRows Then


            While reader.Read()

                Dim items As String = reader("Description").ToString()
                Dim amt As String = reader("Amount").ToString()





            End While
        End If
        ComboBox1.Items.Add("All")
        ComboBox1.Items.Add("Investment")
        ComboBox1.Items.Add("Secondary Income")
        ComboBox1.SelectedIndex = 0



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim ressql As String
        If ComboBox1.SelectedItem = "All" Then

            ressql = "select Serial,Description,Amount,Category,Date from History where userid = " & "'" & receivedid & "'" & "  order by Serial DESC" ' Default query or handle the error appropriately


        ElseIf ComboBox1.SelectedItem = "Investment" Then

            ressql = "select Serial,Description,Amount,Category,Date from History where Category = " & "'" & "Investment" & "'" & " and userid = " & "'" & receivedid & "'" & "order by Serial DESC"

        ElseIf ComboBox1.SelectedItem = "Secondary Income" Then

            ressql = "select Serial,Description,Amount,Category,Date from History where Category = " & "'" & "Secondary Income" & "'" & "and userid = " & "'" & receivedid & "'" & "order by Serial DESC"

        Else
            ressql = "select Serial,Description,Amount,Category,Date from History where userid = " & "'" & receivedid & "'" & "  order by Serial DESC" ' Default query or handle the error appropriately



        End If

        da = New OleDb.OleDbDataAdapter(ressql, conn)
        dt = New DataTable
        da.Fill(dt)
        Fullhistory.DataSource = dt

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If MsgBox("Do you want to delete item with description " & (Fullhistory.SelectedRows.Item(0).Cells(1).Value) & "?", MsgBoxStyle.YesNo, "Delete Expense") = MsgBoxResult.Yes Then
                Dim delquery As String = "Delete from History where Description=" & "'" & (Fullhistory.SelectedRows.Item(0).Cells(1).Value) & "'"
                cmd = New OleDb.OleDbCommand(delquery, conn)
                cmd.ExecuteNonQuery()
                da.SelectCommand = New OleDb.OleDbCommand("select Serial,Description,Amount,Category,Date from History where userid = " & "'" & receivedid & "'" & "  order by Serial DESC")
                da.SelectCommand.Connection = conn
                dt.Clear()
                da.Fill(dt)

            End If

        Catch ex As Exception
            MsgBox("Please Select The Row", MsgBoxStyle.Exclamation, "Invalid Request")

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim updateval1, updateval2 As String
        Dim selectedCell As DataGridViewCell = Fullhistory.CurrentCell
        If selectedCell IsNot Nothing Then
            Dim rowIndex As Integer = selectedCell.RowIndex
            Dim columnIndex As Integer = selectedCell.ColumnIndex
            Dim cellValue As Object = selectedCell.Value

            Dim updatequery As String = ""
            Select Case columnIndex
                Case 0

                Case 1
                    updateval1 = InputBox("Enter Description", "Updating...")
                    If updateval1 = " " Then

                    Else
                        updatequery = "update History set Description = " & "'" & updateval1 & "'" & "where Description = " & "'" & CStr(cellValue) & "'"
                    End If
                Case 2

                    updateval2 = InputBox("Enter Amount", "Updating...")
                    If updateval2 = " " Then

                    Else
                        updatequery = "update History set Amount = " & CInt(updateval2) & " where Amount = " & CInt(cellValue)
                    End If


            End Select
            If updatequery <> "" Then

                cmd = New OleDb.OleDbCommand(updatequery, conn)
                cmd.Connection = conn
                cmd.CommandText = updatequery
                cmd.ExecuteNonQuery()
                da.SelectCommand = New OleDb.OleDbCommand("select Serial,Description,Amount,Category,Date from History where userid = " & "'" & receivedid & "'" & "  order by Serial DESC")
                da.SelectCommand.Connection = conn
                dt.Clear()
                da.Fill(dt)
            Else
                MsgBox("No cell is currently selected.", MsgBoxStyle.Exclamation, "Invalid Request")

            End If

        End If

    End Sub

    Private Sub search_btn_click(sender As Object, e As EventArgs) Handles search_btn.Click

        Dim searchql As String = "select Serial,Description,Amount,Category,Date from History where userid = " & "'" & receivedid & "'" & " and Date = DATE() "
        If Not DateTimePicker2.Checked Or Not DateTimePicker1.Checked Then
            MsgBox("Please Select The Date", MsgBoxStyle.Exclamation, "Unchecked Box")
        Else
            Dim time1 As Date = DateTimePicker1.Value.Date
            Dim time2 As Date = DateTimePicker2.Value.Date

            If time1 = Date.Today Then
                searchql = "select Serial,Description,Amount,Category,Date from History where userid = " & "'" & receivedid & "'" & " and Date = DATE() "
            Else
                searchql = "SELECT Serial, Description, Amount, Category, Date FROM History WHERE userid = '" & receivedid & "' AND Date BETWEEN #" & time1.ToString("MM/dd/yyyy") & "# AND #" & time2.ToString("MM/dd/yyyy") & "#"

            End If
        End If
        da = New OleDb.OleDbDataAdapter(searchql, conn)
        dt = New DataTable
        da.Fill(dt)
        Fullhistory.DataSource = dt
    End Sub
End Class