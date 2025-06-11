Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class signup
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim i, t As Integer
    Dim da As OleDb.OleDbDataAdapter


    Private Sub newuserval(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles newuser.Validating
        If newuser.Text = "" Then
            ErrorProvider1.SetError(newuser, "Gmail address is required!")
            createacc_btn.Enabled = False
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(newuser.Text, "^[a-zA-Z0-9._%+-]+@gmail\.com$") Then
            ErrorProvider1.SetError(newuser, "Enter a valid Gmail address (e.g., example@gmail.com)")
            createacc_btn.Enabled = False
        Else
            ErrorProvider1.SetError(newuser, "")

        End If
    End Sub

    Private Sub repasstxt_val(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles repasstxt.Validating
        If passtxt.Text <> repasstxt.Text Then
            ErrorProvider2.SetError(repasstxt, "Passwords do not match!")
            createacc_btn.Enabled = False
        Else
            ErrorProvider2.SetError(repasstxt, "")
            createacc_btn.Enabled = True

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles createacc_btn.Click
        If String.IsNullOrEmpty(passtxt.Text) OrElse String.IsNullOrEmpty(repasstxt.Text) Then
            ErrorProvider2.SetError(repasstxt, "Please enter a password")
            ErrorProvider2.SetError(passtxt, "Please enter a password")
            createacc_btn.Enabled = False
        End If

        Dim sql As String = "select COUNT(*) from LogData where adduser = '" & newuser.Text & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        If count > 0 Then
            ErrorProvider1.SetError(newuser, "User already exists!")

        Else
            ErrorProvider1.SetError(newuser, "")


            cmd = New OleDb.OleDbCommand("insert into LogData (adduser , Pass) values ('" & newuser.Text & "','" & passtxt.Text & "')", conn)
            cmd.ExecuteNonQuery()
            Dim idsql As String = "SELECT userid FROM LogData WHERE adduser = '" & newuser.Text & "'"

            cmd = New OleDb.OleDbCommand(idsql, conn)
            t = cmd.ExecuteNonQuery()
            Dim reader2 As OleDbDataReader = cmd.ExecuteReader()
            If reader2.Read() Then
                Dim id As String = reader2("userid").ToString()
                reader2.Close()
                home.receivedid = id
                Me.Close()
                home.Show()
                MsgBox("Please Set Your Profile From Above Profile Button", MsgBoxStyle.Information, "Getting Started")
            End If
        End If
    End Sub

    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = DbConnect()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bckfrm1 As New Login
        Me.Close()
        bckfrm1.Show()
    End Sub


End Class