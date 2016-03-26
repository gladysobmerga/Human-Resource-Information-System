imports system.data.odbc

Public Class Form1
    Dim sql As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New OdbcConnection("DSN=gladiesobmerga")

        If TextBox1.Text = "employee" And TextBox2.Text = "employee" Then
            'Dim sql = "SELECT * FROM user_login WHERE Username=@id AND Password=@password"
            ' Dim cmd As OdbcCommand = New OdbcCommand(sql, conn)

            'cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            'cmd.Parameters.AddWithValue("@password", TextBox2.Text)

            conn.Open()

            '  Dim dr As OdbcDataReader = cmd.ExecuteReader
            '  If dr.Read() Then
            'dr.Read()
            LogHistory()
            Form2.Show()
            Me.Close()

            'End If


        ElseIf TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            ' Dim sql = "SELECT * FROM user_login WHERE Username=@id AND Password=@password"
            ' Dim cmd As OdbcCommand = New OdbcCommand(sql, conn)

            ' cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            'cmd.Parameters.AddWithValue("@password", TextBox2.Text)

            conn.Open()

            ' Dim dr As OdbcDataReader = cmd.ExecuteReader
            ' If dr.Read() Then
            'MsgBox("lol")
            '.Read()
            LogHistory()
            Form3.Show()
            Me.Close()
            'dr.Close()


        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid")
            End If
        conn.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRISDataSet.USER_LOGIN' table. You can move, or remove it, as needed.


    End Sub

    Private Sub LogHistory()
        Label3.Text = DateTimePicker2.Value
        'Connect to DB
        Dim conn As New OdbcConnection("DSN=gladiesobmerga")
        Dim sql As String
        sql = "INSERT INTO user_login (Username, Date_Login, Password) VALUES('" + TextBox1.Text + "','" + Label3.Text + "','" + TextBox2.Text + "')"
        Dim cmd As OdbcCommand = New OdbcCommand(sql, conn)
        conn.Open()
        ' cmd.Parameters.AddWithValue("@username2", TextBox1.Text)
        'cmd.Parameters.AddWithValue("@date2", Label3.Text)
        'cmd.Parameters.AddWithValue("@password2", TextBox2.Text)
        MsgBox("Successfully Login")
        'Open Database Connection
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
           

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
