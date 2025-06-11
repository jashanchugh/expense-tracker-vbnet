Public Class profile
    Public receivedid As String
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Public income, username, saving As String
    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = DbConnect()

    End Sub

    Private Sub profile_btn_Click(sender As Object, e As EventArgs) Handles profile_btn.Click


        If String.IsNullOrWhiteSpace(incometxtbox.Text) OrElse
   String.IsNullOrWhiteSpace(usertxtbox.Text) OrElse
   String.IsNullOrWhiteSpace(savetxtbox.Text) Then
            ErrorProvider1.SetError(usertxtbox, "Please Fill the Boxes")
            MsgBox("Update Unsuccessful", MsgBoxStyle.Exclamation, "Invalid Request")
            profile_btn.Enabled = False
        Else
            ErrorProvider1.SetError(usertxtbox, "")
            profile_btn.Enabled = True
            income = incometxtbox.Text
            username = usertxtbox.Text
            saving = savetxtbox.Text


            Dim CheckQuery As String = "SELECT COUNT(*) AS RecordCount FROM Profiledata WHERE Userid = " & CInt(receivedid)
            cmd = New OleDb.OleDbCommand(CheckQuery, conn)
            Dim recordCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If recordCount > 0 Then
                Dim UpdateQuery As String = "UPDATE Profiledata SET income = @income, name = @name, saving = @saving WHERE Userid = @Userid"
                cmd = New OleDb.OleDbCommand(UpdateQuery, conn)
                cmd.Parameters.AddWithValue("@income", income)
                cmd.Parameters.AddWithValue("@name", username)
                cmd.Parameters.AddWithValue("@saving", saving)
                cmd.Parameters.AddWithValue("@Userid", receivedid)

                cmd.ExecuteNonQuery()
            Else
                Dim InsertQuery As String = "INSERT INTO Profiledata (income, name, saving, Userid) VALUES (@income, @name, @saving, @userid)"
                cmd = New OleDb.OleDbCommand(InsertQuery, conn)
                cmd.Parameters.AddWithValue("@income", income)
                cmd.Parameters.AddWithValue("@name", username)
                cmd.Parameters.AddWithValue("@saving", saving)
                cmd.Parameters.AddWithValue("@userid", receivedid)
                cmd.ExecuteNonQuery()
                MsgBox("Profile Added", MsgBoxStyle.Information, "Getting Started")

            End If

        End If


        Me.Close()
        Dim Homefrm As New home
        home.receivedid = receivedid
        home.Show()



    End Sub


    Private Sub Cnclbtn_Click(sender As Object, e As EventArgs) Handles Cnclbtn.Click
        Me.Close()
        Dim Homefrm As New home
        Homefrm.receivedid = receivedid
        Homefrm.Show()
    End Sub
End Class