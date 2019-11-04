Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Linq


Public Class StudentForm
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Friend Sub addStudent()

        displaytxt.Text = IDtxt.Text & stuNametxt.Text & marktxt.Text & depttxt.Text

    End Sub
    Structure Student
        Dim id As Integer
        Dim name As String
        Dim mark As Double
        Dim dept As Integer


        Public Overrides Function ToString() As String
            Return id.ToString() + ", " + name + ", " + mark.ToString() + ", " + dept.ToString()
        End Function
    End Structure
    'Add button
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        addStudent()
        addtData()
    End Sub
    'create a sub for add data
    Friend Sub addtData()
        Dim dbCon = GetConnection()
        Dim strQuery = "INSERT INTO studentinfo (stu_ID,stu_Name,mark,dept) values(@stu_ID_,@stu_Name_,@mark_,@dept_)"
        'Get data of Student
        Dim SQLCmd As MySqlCommand
        Dim ids = CInt(IDtxt.Text)
        Dim names = stuNametxt.Text
        Dim marks = CDbl(marktxt.Text)
        Dim depts = CInt(depttxt.Text)
        Try
            SQLCmd = New MySqlCommand(strQuery, dbCon)
            'OPEN THE DB AND KICKOFF THE QUERY
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.Parameters.AddWithValue("@stu_ID_", ids)
            SQLCmd.Parameters.AddWithValue("@stu_Name_", names)
            SQLCmd.Parameters.AddWithValue("@mark_", marks)
            SQLCmd.Parameters.AddWithValue("@dept_", depts)
            SQLCmd.ExecuteNonQuery()
            MessageBox.Show("Student added successfully")
            dbCon.Close()
        Catch ex As Exception
            MsgBox("Failure to communicate!" & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub
    'create a sub for search data
    Friend Sub searchData()
        Dim dbCon = GetConnection()
        Dim sqlCommand As New MySqlCommand()
        Dim adapter As New MySqlDataAdapter()

        Dim querySelect = "SELECT stu_Name, dept, mark FROM `studentinfo` WHERE `stu_ID` = @stu_ID"

        Try
            sqlCommand = New MySqlCommand(querySelect, dbCon)
            sqlCommand.Parameters.Add("@stu_ID", MySqlDbType.Int64).Value = IDtxt.Text
            Dim table As New DataTable()
            adapter = New MySqlDataAdapter(sqlCommand)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                displaytxt.Text = "Name: " + table(0)(0)
                displaytxt.Text += " - Dept: " + CStr(table(0)(1))
                displaytxt.Text += " - Mark: " + CStr(table(0)(2))
            Else
                MessageBox.Show("No Data Found")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbCon.Close()
        End Try
    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        searchData()
    End Sub
    Friend Sub UpdateStudent()
        Dim dbCon = GetConnection()
        Dim sqlCommand As New MySqlCommand()

        Dim queryInsert = "INSERT INTO UpdatedStudent (stu_ID,stu_Name,mark,dept,date) values(@stu_ID_,@stu_Name_,@mark_,@dept_,@date_)"

        Try
            sqlCommand = New MySqlCommand(queryInsert, dbCon)
            sqlCommand.Parameters.AddWithValue("@stu_ID_", IDtxt.Text)
            sqlCommand.Parameters.AddWithValue("@stu_Name_", stuNametxt.Text)
            sqlCommand.Parameters.AddWithValue("@mark_", marktxt.Text)
            sqlCommand.Parameters.AddWithValue("@dept_", depttxt.Text)
            sqlCommand.Parameters.AddWithValue("@date_", Now())
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Student updated successfully")
        Catch ex As Exception
            MessageBox.Show("Student updated failed. Detail: " + ex.Message)
        Finally
            sqlCommand.Dispose()
            dbCon.Close()
        End Try
    End Sub

    Friend Sub DeleteStudent()
        Dim dbCon = GetConnection()
        Dim sqlCmd As New MySqlCommand
        Dim adapter As New MySqlDataAdapter()

        Dim student As Student

        Dim querySelect = "Select stu_Name, dept, mark FROM `studentinfo` WHERE `stu_ID` = @stu_ID"
        Dim queryDelete = "Delete FROM `studentinfo` WHERE `stu_ID` = @stu_ID"
        Dim queryInsert = "INSERT INTO DeletedStudent (stu_ID,stu_Name,mark,dept,date) values(@stu_ID_,@stu_Name_,@mark_,@dept_,@date_)"

        Try
            'Get student where id enter by user assign to Student
            sqlCmd = New MySqlCommand(querySelect, dbCon)
            sqlCmd.Parameters.Add("@stu_ID", MySqlDbType.Int64).Value = IDtxt.Text
            adapter = New MySqlDataAdapter(sqlCmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                student.id = CInt(IDtxt.Text)
                student.name = table(0)(0)
                student.mark = table(0)(1)
                student.dept = table(0)(2)

                'Delete student from table studentinfo
                sqlCmd = New MySqlCommand(queryDelete, dbCon)
                sqlCmd.Parameters.Add("@stu_ID", MySqlDbType.Int64).Value = student.id
                sqlCmd.ExecuteNonQuery()
                'Insert student into table deletedstudent
                sqlCmd = New MySqlCommand(queryInsert, dbCon)
                sqlCmd.CommandType = CommandType.Text
                sqlCmd.Parameters.AddWithValue("@stu_ID_", student.id)
                sqlCmd.Parameters.AddWithValue("@stu_Name_", student.name)
                sqlCmd.Parameters.AddWithValue("@mark_", student.mark)
                sqlCmd.Parameters.AddWithValue("@dept_", student.dept)
                sqlCmd.Parameters.AddWithValue("@date_", Now())
                sqlCmd.ExecuteNonQuery()
                MessageBox.Show("Student deleted successfully")
            Else
                MessageBox.Show("This student does not exist")
            End If

        Catch ex As Exception
            MessageBox.Show("Delete student error. Detail: " + ex.Message)
        Finally
            sqlCmd.Dispose()
            adapter.Dispose()
            dbCon.Close()
        End Try

    End Sub
    Private Function GetConnection() As MySqlConnection
        Dim dbCon = New MySqlConnection("Server=;Database=student;Uid=;Pwd=")
        dbCon.Open()
        Return dbCon
    End Function

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        UpdateStudent()
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        DeleteStudent()
    End Sub
End Class
