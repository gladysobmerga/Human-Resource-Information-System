Imports System.Data.Odbc

Public Class Form2
    

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        RefreshDataGrid()
    End Sub
    Private Sub RefreshDataGrid()
        Dim MyDataAdapter As New Odbc.OdbcDataAdapter
        Dim MyDataAdapter1 As New Odbc.OdbcDataAdapter
        Dim MyDataAdapter2 As New Odbc.OdbcDataAdapter

        Dim MyDataSet As New DataSet
        Dim MyDataSet1 As New DataSet
        Dim MyDataSet2 As New DataSet

        Dim MySelect As String = "Select * from personal_information"
        Dim MySelect1 As String = "Select * from time_sheet"
        Dim MySelect2 As String = "Select * from project_report"

        Dim StrConn As String = "DSN=gladiesobmerga"
        Dim MyConn As New Odbc.OdbcConnection(StrConn)

        MyConn.Open()

        MyDataAdapter.SelectCommand = New Odbc.OdbcCommand(MySelect, MyConn)
        MyDataAdapter1.SelectCommand = New Odbc.OdbcCommand(MySelect1, MyConn)
        MyDataAdapter2.SelectCommand = New Odbc.OdbcCommand(MySelect2, MyConn)


        MyDataAdapter.Fill(MyDataSet)
        MyDataAdapter1.Fill(MyDataSet1)
        MyDataAdapter2.Fill(MyDataSet2)


        Me.BindingSource1.DataMember = MyDataSet.Tables(0).TableName
        Me.BindingSource2.DataMember = MyDataSet1.Tables(0).TableName
        Me.BindingSource3.DataMember = MyDataSet2.Tables(0).TableName


        Me.BindingSource1.DataSource = MyDataSet
        Me.BindingSource2.DataSource = MyDataSet1
        Me.BindingSource3.DataSource = MyDataSet2


        Me.DataGridView3.DataSource = Me.BindingSource1
        Me.DataGridView1.DataSource = Me.BindingSource2
        Me.DataGridView2.DataSource = Me.BindingSource3


        MyConn.Close()
    End Sub



    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim myConnection As New OdbcConnection("DSN=gladiesobmerga")
        myConnection.Open()

        Dim str As String = "INSERT INTO project_report VALUES ('" + TextBox34.Text + "','" + TextBox35.Text + "','" + TextBox36.Text + "','" + TextBox37.Text + "','" + TextBox39.Text + "','" + TextBox40.Text + "','" + TextBox41.Text + "','" + TextBox40.Text + "')"
        Dim cmd As OdbcCommand = New OdbcCommand(str, myConnection)
        ' cmd.Parameters.Add(New OdbcParameter("Date_Modified", CType(TextBox34.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Project_Title", CType(TextBox35.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Project_Number", CType(TextBox36.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Assigned_To", CType(TextBox37.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Task", CType(TextBox38.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Status", CType(TextBox39.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Link", CType(TextBox40.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Reply_with_the_Client", CType(TextBox41.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("What_have_you_Learned", CType(TextBox42.Text, String)))


        Try
            cmd.ExecuteNonQuery()
            RefreshDataGrid()
            cmd.Dispose()
            myConnection.Close()
            TextBox34.Clear()
            TextBox35.Clear()
            TextBox36.Clear()
            TextBox37.Clear()
            TextBox39.Clear()
            TextBox40.Clear()
            TextBox41.Clear()
            TextBox42.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
            myConnection.Close()

        End Try
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click, DataGridView3.VisibleChanged
        Dim myConnection As New OdbcConnection("DSN=gladiesobmerga")
        myConnection.Open()
        Dim per As String
        Dim emp As String
        per = "INSERT INTO personal_information (Employee_ID,Username,Password,First_Name,Last_Name,Middle_Name,Age,Gender,Zip_Code,Email_Address,Contact_Number,Contact_Person_in_case_of_emergency,Employees_Contact_Person_Number,Highest_Educational_Attainment,College_University,Date_Graduated,Previous_Employment,Previous_Position,Employer_Contact_Number) VALUES('" + TextBox1.Text + "','" + TextBox8.Text + "','" + TextBox23.Text + "','" + TextBox6.Text + "','" + TextBox5.Text + "','" + TextBox7.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" + TextBox16.Text + "','" + TextBox17.Text + "','" + TextBox18.Text + "','" + TextBox19.Text + "','" + TextBox20.Text + "','" + TextBox21.Text + "')"
        emp = "INSERT INTO employees (Employee_Code,Position,Department,Status,Date_Started,Username,Password) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox31.Text + "','" + TextBox4.Text + "','" + TextBox3.Text + "','" + TextBox8.Text + "','" + TextBox23.Text + "')"
        Dim cmd As OdbcCommand = New OdbcCommand(per, myConnection)
        Dim cmd1 As OdbcCommand = New OdbcCommand(emp, myConnection)
        ' cmd.Parameters.Add(New OdbcParameter("Employee_ID", CType(TextBox1.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Position", CType(TextBox2.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Date_Started", CType(TextBox3.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Status", CType(TextBox4.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Last_Name", CType(TextBox5.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("First_Name", CType(TextBox6.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Middle_Name", CType(TextBox7.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Age", CType(TextBox9.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Gender", CType(TextBox10.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Address", CType(TextBox11.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Email_Address", CType(TextBox12.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Contact_Number", CType(TextBox13.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Contact_Person_in_case_of_emergency", CType(TextBox14.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("HisHer_Contact_Number", CType(TextBox15.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("College_Degree", CType(TextBox16.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("CollegeUniversity", CType(TextBox17.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Date_Graduated", CType(TextBox18.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Previous_Employer", CType(TextBox19.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Previous_Position", CType(TextBox20.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Employers_Contact_Person", CType(TextBox21.Text, String)))


        Try
            cmd.ExecuteNonQuery()
            cmd1.ExecuteNonQuery()
            RefreshDataGrid()
            cmd.Dispose()
            cmd1.Dispose()
            myConnection.Close()
            ' MsgBox("Successfully Added")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox9.Clear()
            TextBox10.Clear()
            TextBox11.Clear()
            TextBox12.Clear()
            TextBox13.Clear()
            TextBox14.Clear()
            TextBox15.Clear()
            TextBox16.Clear()
            TextBox17.Clear()
            TextBox18.Clear()
            TextBox19.Clear()
            TextBox20.Clear()
            TextBox21.Clear()
            TextBox31.Clear()
            TextBox8.Clear()
            TextBox23.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
            myConnection.Close()

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
       Dim myConnection As New OdbcConnection("DSN=gladiesobmerga")
        myConnection.Open()
        Dim str As String
        str = "INSERT INTO time_sheet (Employee_ID,Total_Hours_Required,Total_Hours_Left,Date,Time_In,Time_Out,Number_of_Hours) VALUES('" + TextBox22.Text + "','" + TextBox24.Text + "','" + TextBox25.Text + "','" + TextBox27.Text + "','" + TextBox28.Text + "','" + TextBox29.Text + "','" + TextBox30.Text + "')"
        Dim cmd As OdbcCommand = New OdbcCommand(str, myConnection)
        'cmd.Parameters.Add(New OdbcParameter("Employees_ID", CType(TextBox22.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Employee_Username", CType(TextBox23.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Total_Hours_Required", CType(TextBox24.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Total_Hours_Left", CType(TextBox25.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("End_Period", CType(TextBox26.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Date", CType(TextBox27.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Time_In", CType(TextBox28.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Time_Out", CType(TextBox29.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Number_of_Hours", CType(TextBox30.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Project_Number", CType(TextBox31.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Task", CType(TextBox32.Text, String)))
        'cmd.Parameters.Add(New OdbcParameter("Status", CType(TextBox33.Text, String)))
   

        Try
            cmd.ExecuteNonQuery()
            RefreshDataGrid()
            cmd.Dispose()
            myConnection.Close()
            'MsgBox("Successfully Added")
            TextBox22.Clear()
            TextBox23.Clear()
            TextBox24.Clear()
            TextBox25.Clear()
            TextBox27.Clear()
            TextBox28.Clear()
            TextBox29.Clear()
            TextBox30.Clear()
            TextBox31.Clear()
           

        Catch ex As Exception
            MsgBox(ex.Message)
            myConnection.Close()

        End Try
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
        TextBox18.Clear()
        TextBox19.Clear()
        TextBox20.Clear()
        TextBox21.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox22.Clear()
        TextBox23.Clear()
        TextBox24.Clear()
        TextBox25.Clear()
        TextBox27.Clear()
        TextBox28.Clear()
        TextBox29.Clear()
        TextBox30.Clear()
        TextBox31.Clear()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox34.Clear()
        TextBox35.Clear()
        TextBox36.Clear()
        TextBox37.Clear()
        TextBox39.Clear()
        TextBox40.Clear()
        TextBox41.Clear()
        TextBox42.Clear()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        Dim myConnection As New OdbcConnection("DSN=gladiesobmerga")
        Dim result As String
        Dim result1 As String
        Try
            myConnection.Open()
            Dim per As String = "Update personal_information Set Employee_ID = '" + TextBox1.Text + "', Username = '" + TextBox8.Text + "',Password='" + TextBox23.Text + "',First_Name='" + TextBox6.Text + "',Last_Name = '" + TextBox5.Text + "', Middle_Name = '" + TextBox7.Text + "' ,Age = '" + TextBox9.Text + "',Gender = '" + TextBox10.Text + "', Zip_Code = '" + TextBox11.Text + "', Email_Address = '" + TextBox12.Text + "', Contact_Number = '" + TextBox13.Text + "', Contact_Person_in_case_of_emergency = '" + TextBox14.Text + "', Employees_Contact_Person_Number = '" + TextBox15.Text + "', Highest_Educational_Attainment = '" + TextBox16.Text + "', College_University = '" + TextBox17.Text + "', Date_Graduated = '" + TextBox18.Text + "', Previous_Employment = '" + TextBox19.Text + "',Previous_Position = '" + TextBox20.Text + "',Employer_Contact_Number = '" + TextBox21.Text + "' WHERE Count = " & Val(Label25.Text) & ";"
            Dim emp As String = "UPDATE employees Set Employee_Code = '" + TextBox1.Text + "',Position = '" + TextBox2.Text + "',Department = '" + TextBox31.Text + "',Status = '" + TextBox4.Text + "',Date_Started = '" + TextBox3.Text + "',Username = '" + TextBox8.Text + "',Password = '" + TextBox23.Text + "' WHERE Count = " & Val(Label25.Text) & "; "
            Dim cmd As OdbcCommand = New OdbcCommand(per, myConnection)
            Dim cmd1 As OdbcCommand = New OdbcCommand(emp, myConnection)
            result = cmd.ExecuteNonQuery
            result1 = cmd1.ExecuteNonQuery


            If result = 0 Then
                MsgBox("Data has been Updated!")
            Else
                MsgBox("Successfully Updated")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
                TextBox9.Clear()
                TextBox10.Clear()
                TextBox11.Clear()
                TextBox12.Clear()
                TextBox13.Clear()
                TextBox14.Clear()
                TextBox15.Clear()
                TextBox16.Clear()
                TextBox17.Clear()
                TextBox18.Clear()
                TextBox19.Clear()
                TextBox20.Clear()
                TextBox21.Clear()
                TextBox31.Clear()
                TextBox8.Clear()
                TextBox23.Clear()
                RefreshDataGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myConnection.Close()
    End Sub

    Private Sub TextBox18_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox18.TextChanged

    End Sub

    Private Sub DataGridView3_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView3.CellMouseClick
        Label25.Text = DataGridView3.CurrentRow.Cells(0).Value
        TextBox1.Text = DataGridView3.CurrentRow.Cells(1).Value
        TextBox8.Text = DataGridView3.CurrentRow.Cells(2).Value
        TextBox23.Text = DataGridView3.CurrentRow.Cells(3).Value
        TextBox6.Text = DataGridView3.CurrentRow.Cells(4).Value
        TextBox5.Text = DataGridView3.CurrentRow.Cells(5).Value
        TextBox7.Text = DataGridView3.CurrentRow.Cells(6).Value
        TextBox9.Text = DataGridView3.CurrentRow.Cells(7).Value
        TextBox10.Text = DataGridView3.CurrentRow.Cells(8).Value
        TextBox11.Text = DataGridView3.CurrentRow.Cells(9).Value
        TextBox12.Text = DataGridView3.CurrentRow.Cells(10).Value
        TextBox13.Text = DataGridView3.CurrentRow.Cells(11).Value
        TextBox14.Text = DataGridView3.CurrentRow.Cells(12).Value
        TextBox15.Text = DataGridView3.CurrentRow.Cells(13).Value
        TextBox16.Text = DataGridView3.CurrentRow.Cells(14).Value
        TextBox17.Text = DataGridView3.CurrentRow.Cells(15).Value
        TextBox18.Text = DataGridView3.CurrentRow.Cells(16).Value
        TextBox19.Text = DataGridView3.CurrentRow.Cells(17).Value
        TextBox20.Text = DataGridView3.CurrentRow.Cells(18).Value
        TextBox21.Text = DataGridView3.CurrentRow.Cells(19).Value

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Label30.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox22.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox24.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox25.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox27.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBox28.Text = DataGridView1.CurrentRow.Cells(5).Value
        TextBox29.Text = DataGridView1.CurrentRow.Cells(6).Value
        TextBox30.Text = DataGridView1.CurrentRow.Cells(7).Value

    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        TextBox34.Text = DataGridView2.CurrentRow.Cells(0).Value
        TextBox35.Text = DataGridView2.CurrentRow.Cells(1).Value
        TextBox36.Text = DataGridView2.CurrentRow.Cells(2).Value
        TextBox37.Text = DataGridView2.CurrentRow.Cells(3).Value
        TextBox39.Text = DataGridView2.CurrentRow.Cells(4).Value
        TextBox40.Text = DataGridView2.CurrentRow.Cells(5).Value
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim myConnection As New OdbcConnection("DSN=gladiesobmerga")
        Dim result As String

        Try
            myConnection.Open()
            Dim per As String = "Update time_sheet Set Employee_ID = '" + TextBox22.Text + "',Total_Hours_Required = '" + TextBox24.Text + "',Total_Hours_Left = '" + TextBox25.Text + "',Date = '" + TextBox27.Text + "',Time_In = '" + TextBox28.Text + "',Time_Out = '" + TextBox29.Text + "',Number_of_Hours = '" + TextBox30.Text + "' WHERE Count = " & Val(Label30.Text) & "; "

            Dim cmd As OdbcCommand = New OdbcCommand(per, myConnection)

            result = cmd.ExecuteNonQuery

            Me.DataGridView1.Refresh()

            If result = 0 Then
                MsgBox("Data has been Updated!")
            Else
                MsgBox("Successfully Updated")
                TextBox22.Clear()
                TextBox23.Clear()
                TextBox24.Clear()
                TextBox25.Clear()
                TextBox27.Clear()
                TextBox28.Clear()
                TextBox29.Clear()
                TextBox30.Clear()
                TextBox31.Clear()
                RefreshDataGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myConnection.Close()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim myConnection As New OdbcConnection("DSN=gladiesobmerga")
        Dim result As String
        Dim result1 As String
        Try
            myConnection.Open()
            Dim per As String = "DELETE FROM personal_information WHERE Count = " & Val(Label25.Text) & ";"
            Dim emp As String = "DELETE FROM employees WHERE Count = " & Val(Label25.Text) & "; "
            Dim cmd As OdbcCommand = New OdbcCommand(per, myConnection)
            Dim cmd1 As OdbcCommand = New OdbcCommand(emp, myConnection)
            result = cmd.ExecuteNonQuery
            result1 = cmd1.ExecuteNonQuery
            Me.DataGridView1.Refresh()

            If result = 0 Then
                MsgBox("Data has been Updated!")
            Else
                MsgBox("Successfully Deleted")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
                TextBox9.Clear()
                TextBox10.Clear()
                TextBox11.Clear()
                TextBox12.Clear()
                TextBox13.Clear()
                TextBox14.Clear()
                TextBox15.Clear()
                TextBox16.Clear()
                TextBox17.Clear()
                TextBox18.Clear()
                TextBox19.Clear()
                TextBox20.Clear()
                TextBox21.Clear()
                TextBox31.Clear()
                TextBox8.Clear()
                TextBox23.Clear()
                RefreshDataGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myConnection.Close()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim myConnection As New OdbcConnection("DSN=gladiesobmerga")
        Dim result As String

        Try
            myConnection.Open()
            Dim per As String = "DELETE FROM time_sheet WHERE Count = " & Val(Label30.Text) & "; "

            Dim cmd As OdbcCommand = New OdbcCommand(per, myConnection)

            result = cmd.ExecuteNonQuery

            Me.DataGridView1.Refresh()

            If result = 0 Then
                MsgBox("Data has been Updated!")
            Else
                MsgBox("Successfully Deleted")
                TextBox22.Clear()
                TextBox23.Clear()
                TextBox24.Clear()
                TextBox25.Clear()
                TextBox27.Clear()
                TextBox28.Clear()
                TextBox29.Clear()
                TextBox30.Clear()
                TextBox31.Clear()
                RefreshDataGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myConnection.Close()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Dim myConnection As New OdbcConnection("DSN=gladiesobmerga")
        Dim result As String

        Try
            myConnection.Open()
            Dim per As String = "Update project_report Set Date_Modified = '" + TextBox34.Text + "',Project_Title = '" + TextBox35.Text + "',Project_Number = '" + TextBox36.Text + "',Assigned_To = '" + TextBox37.Text + "',Status = '" + TextBox39.Text + "',Link = '" + TextBox40.Text + "',Reply_With_the_Client = '" + TextBox41.Text + "',What_have_you_Learned = '" + TextBox42.Text + "' "

            Dim cmd As OdbcCommand = New OdbcCommand(per, myConnection)

            result = cmd.ExecuteNonQuery

            Me.DataGridView1.Refresh()

            If result = 0 Then
                MsgBox("Data has been Updated!")
            Else
                MsgBox("Successfully Updated")
                TextBox34.Clear()
                TextBox35.Clear()
                TextBox36.Clear()
                TextBox37.Clear()
                TextBox39.Clear()
                TextBox40.Clear()
                TextBox41.Clear()
                TextBox42.Clear()
                RefreshDataGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myConnection.Close()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Dim myConnection As New OdbcConnection("DSN=gladiesobmerga")
        Dim result As String

        Try
            myConnection.Open()
            Dim per As String = "DELETE FROM project_report "

            Dim cmd As OdbcCommand = New OdbcCommand(per, myConnection)

            result = cmd.ExecuteNonQuery

            Me.DataGridView1.Refresh()

            If result = 0 Then
                MsgBox("Data has been Updated!")
            Else
                MsgBox("Successfully Deleted")
                TextBox34.Clear()
                TextBox35.Clear()
                TextBox36.Clear()
                TextBox37.Clear()
                TextBox39.Clear()
                TextBox40.Clear()
                TextBox41.Clear()
                TextBox42.Clear()
                RefreshDataGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myConnection.Close()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Form4.Show()
    End Sub
End Class