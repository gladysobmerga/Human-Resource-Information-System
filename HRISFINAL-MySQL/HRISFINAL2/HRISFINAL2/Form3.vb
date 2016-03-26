Imports System.Data.Odbc


Public Class Form3


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshDataGrid()

    End Sub
    Private Sub RefreshDataGrid()
        Dim MyDataAdapter As New Odbc.OdbcDataAdapter
        Dim MyDataAdapter1 As New Odbc.OdbcDataAdapter
        Dim MyDataAdapter3 As New Odbc.OdbcDataAdapter

        Dim MyDataSet As New DataSet
        Dim MyDataSet1 As New DataSet
        Dim MyDataSet3 As New DataSet

        Dim MySelect As String = "Select * from payroll_sheet"
        Dim MySelect1 As String = "Select * from user_login"
        Dim MySelect3 As String = "Select * from employees"

        Dim StrConn As String = "DSN=gladiesobmerga"
        Dim MyConn As New Odbc.OdbcConnection(StrConn)

        MyConn.Open()

        MyDataAdapter.SelectCommand = New Odbc.OdbcCommand(MySelect, MyConn)
        MyDataAdapter1.SelectCommand = New Odbc.OdbcCommand(MySelect1, MyConn)
        MyDataAdapter3.SelectCommand = New Odbc.OdbcCommand(MySelect3, MyConn)

        MyDataAdapter.Fill(MyDataSet)
        MyDataAdapter1.Fill(MyDataSet1)
        MyDataAdapter3.Fill(MyDataSet3)


        Me.BindingSource1.DataMember = MyDataSet.Tables(0).TableName
        Me.BindingSource2.DataMember = MyDataSet1.Tables(0).TableName
        Me.BindingSource3.DataMember = MyDataSet3.Tables(0).TableName


        Me.BindingSource1.DataSource = MyDataSet
        Me.BindingSource2.DataSource = MyDataSet1
        Me.BindingSource3.DataSource = MyDataSet3


        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView2.DataSource = Me.BindingSource2
        Me.DataGridView3.DataSource = Me.BindingSource3

    End Sub


    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click, DataGridView1.VisibleChanged
        Dim myConnection As New OdbcConnection("DSN=gladiesobmerga")

        myConnection.Open()
        Dim str As String
        str = "INSERT INTO payroll_sheet (Employee_Id,Salary_Rate) VALUES('" + TextBox1.Text + "','" + TextBox4.Text + "')"
        Dim cmd As OdbcCommand = New OdbcCommand(str, myConnection)
        ' cmd.Parameters.Add(New OdbcParameter("Employee_ID", CType(TextBox1.Text, String)))
        ' cmd.Parameters.Add(New OdbcParameter("Employee_Username", CType(TextBox2.Text, String)))
        ' cmd.Parameters.Add(New OdbcParameter("Position", CType(TextBox3.Text, String)))
        ' cmd.Parameters.Add(New OdbcParameter("Salary_Rate", CType(TextBox4.Text, String)))




        Try
            cmd.ExecuteNonQuery()
            RefreshDataGrid()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Clear()
            TextBox4.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
            myConnection.Close()

        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub TabPage2_Click(sender As System.Object, e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Label2.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(2).Value
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim myConnection As New OdbcConnection("DSN=gladiesobmerga")
        Dim result As String
        Try
            myConnection.Open()
            Dim str As String = "Update payroll_sheet Set Employee_ID = '" + TextBox1.Text + "', Salary_Rate = '" + TextBox4.Text + "' WHERE id = " & Val(Label2.Text) & ";"
            Dim cmd As OdbcCommand = New OdbcCommand(Str, myConnection)
            result = cmd.ExecuteNonQuery


            If result = 0 Then
                MsgBox("Data has been Updated!")
            Else
                MsgBox("Successfully Updated")
                RefreshDataGrid()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myConnection.Close()

    End Sub

    Private Sub DataGridView3_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView3.CellMouseClick

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim myConnection As New OdbcConnection("DSN=gladiesobmerga")
        Dim result As String
        Try
            myConnection.Open()
            Dim str As String = "DELETE FROM payroll_sheet WHERE id = " & Val(Label2.Text) & ";"
            Dim cmd As OdbcCommand = New OdbcCommand(str, myConnection)
            result = cmd.ExecuteNonQuery


            If result = 0 Then
                MsgBox("Data has been Updated!")
            Else
                MsgBox("Successfully Deleted")
                RefreshDataGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myConnection.Close()
    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub
End Class