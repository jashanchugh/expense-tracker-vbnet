Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Login

    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim i, t As Integer
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Public receivedid As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = DbConnect()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_login.Click

        Dim user_name As String = user_value.Text
        Dim pass_word As String = user_pass.Text
        Btn_login.Enabled = False


        Dim sql As String = "SELECT * FROM LogData WHERE adduser = '" & user_name & "'"
        Dim cmd As New OleDbCommand(sql, conn)

        cmd.Connection = conn
        cmd.CommandText = sql
        Try
            t = cmd.ExecuteNonQuery()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.HasRows Then


                If reader.Read() Then

                    Dim userpass As String = reader("Pass").ToString()
                    user_value.Clear()
                    user_pass.Clear()
                    If userpass = pass_word Then
                        Dim idsql As String = "SELECT userid FROM LogData WHERE adduser = '" & user_name & "'"

                        cmd = New OleDb.OleDbCommand(idsql, conn)
                        t = cmd.ExecuteNonQuery()
                        Dim reader2 As OleDbDataReader = cmd.ExecuteReader()
                        If reader2.Read() Then
                            Dim id As String = reader2("userid").ToString()
                            reader2.Close()
                            Dim frm2 As New home()
                            frm2.receivedid = id
                            frm2.Show()
                            DbDisconnect()
                            Me.Hide()

                        End If


                    Else
                        MsgBox("PLEASE CHECK YOUR USERNAME OR PASSWORD", MsgBoxStyle.Exclamation, "Login Error")
                        Btn_login.Enabled = True
                    End If
                    reader.Close()
                End If
            Else
                MsgBox("Invalid username and password", MsgBoxStyle.Exclamation, "Login Error")
                Btn_login.Enabled = True
                reader.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Exclamation, "Admin Error")
        End Try

    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim signup As New signup
        signup.Show()
        Me.Hide()

    End Sub

    Private Sub incorrectinput(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles user_value.Validating
        If Not System.Text.RegularExpressions.Regex.IsMatch(user_value.Text, "^[a-zA-Z0-9._%+-]+@gmail\.com$") Then
            ErrorProvider1.SetError(user_value, "Enter a valid Gmail address (e.g., example@gmail.com)")
            Btn_login.Enabled = False
        Else
            ErrorProvider1.SetError(user_value, "")
            Btn_login.Enabled = True
        End If
    End Sub
End Class
