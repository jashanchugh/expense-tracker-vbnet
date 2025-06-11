Public Class Add
    Public receivedid As String

    Private Sub addtxtbox_val(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles addtxtbox.Validating
        If addtxtbox.Text = "" Then
            ErrorProvider1.SetError(addtxtbox, "Please enter a description")
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(addtxtbox.Text, "^[a-z A-Z]*$") Then
            ErrorProvider1.SetError(addtxtbox, "Please enter a valid description")
        Else
            ErrorProvider1.SetError(addtxtbox, "")
        End If
    End Sub

    Private Sub amttxtbox_val(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles amttxtbox.Validating
        If amttxtbox.Text = "" Then
            ErrorProvider2.SetError(amttxtbox, "Please enter a Amount")
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(amttxtbox.Text, "^[0-9]*$") Then
            ErrorProvider2.SetError(amttxtbox, "Please enter a valid Amount")
        Else
            ErrorProvider2.SetError(amttxtbox, "")
        End If
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        If ErrorProvider1.GetError(addtxtbox) = "" And ErrorProvider2.GetError(amttxtbox) = "" Then
            Dim newdt, newval, Cat As String
            Cat = RadioButton1.Text
            newdt = addtxtbox.Text
            newval = amttxtbox.Text
            If RadioButton1.Checked Then
                Cat = RadioButton1.Text
                RadioButton1.Checked = False
            ElseIf RadioButton2.Checked Then
                Cat = RadioButton2.Text
                RadioButton2.Checked = False
            ElseIf RadioButton3.Checked Then
                Cat = RadioButton3.Text
                RadioButton3.Checked = False
            End If
            cmd = New OleDb.OleDbCommand("insert into history (Description, Amount, Category, userid) values ('" & newdt & "','" & newval & "','" & Cat & "','" & receivedid & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Added Successfully", MsgBoxStyle.Information, "Hurrayyy")
            addtxtbox.Text = ""
            amttxtbox.Text = ""


        Else
            MsgBox("Please enter valid data", MsgBoxStyle.Exclamation, "Invalid Request")
        End If


        Me.Close()
        home.receivedid = receivedid
        home.Show()

    End Sub
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim da As OleDb.OleDbDataAdapter
    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = DbConnect()
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Dim homefrm As New home
        homefrm.receivedid = receivedid
        homefrm.Show()
        Me.Close()
    End Sub
End Class