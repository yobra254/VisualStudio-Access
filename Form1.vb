'Imports System.Data.OleDb

Public Class Form1
    Dim maxRows, count As Integer

    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String


    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click

    

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source = C:/Users/Ryan/Documents/Registration1.mdb"
        'C:\Users\Ryan\Documents\Registration.accdb
        con.ConnectionString = dbProvider & dbSource

        con.Open()
        sql = "Select * FROM Students"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Registration")
        MsgBox("Database is now open")

        txtReg.Text() = ds.Tables("Registration").Rows(0).Item(0)
        txtFname.Text() = ds.Tables("Registration").Rows(0).Item(1)
        txtLname.Text() = ds.Tables("Registration").Rows(0).Item(2)
        txtContact.Text() = ds.Tables("Registration").Rows(0).Item(3)
        txtAdm.Text() = ds.Tables("Registration").Rows(0).Item(4)


        con.Close()
        'MsgBox("Database is now Closed")'

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'maxRows = ds.Tables("Registration").Rows.Count
        'count = -1
    End Sub

    Private Sub RecordNavigator()
        txtReg.Text() = ds.Tables("Registration").Rows(count).Item(0)
        txtFname.Text() = ds.Tables("Registration").Rows(count).Item(1)
        txtLname.Text() = ds.Tables("Registration").Rows(count).Item(2)
        txtContact.Text() = ds.Tables("Registration").Rows(count).Item(3)
        txtAdm.Text() = ds.Tables("Registration").Rows(count).Item(4)
    End Sub

    Private Sub txtNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNext.Click


        Try
            If count <> maxRows - 1 Then
                RecordNavigator()
                count += 1
            Else
                MsgBox("No More Rows ")
            End If
        Catch ex As Exception
            MsgBox("No More records " + ex.Message)
            count = 0
        End Try

    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click


        Try
            If count > 0 Then
                count = count - 1
                RecordNavigator()
            Else
                MsgBox("First Record")
            End If
        Catch ex As Exception
            MsgBox("Cannot move back!!!")

        End Try

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtReg.Clear()
        txtFname.Clear()
        txtLname.Clear()
        txtContact.Clear()
        txtAdm.Clear()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        MsgBox("the system is shutting down")
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow

        Try
            If count <> -1 Then
                dsNewRow = ds.Tables("Registration").NewRow()
                dsNewRow.Item("Reg_No") = txtReg.Text
                dsNewRow.Item("FName") = txtFname.Text
                dsNewRow.Item("LName") = txtLname.Text
                dsNewRow.Item("Contact") = txtContact.Text
                dsNewRow.Item("Date_Of_Admission") = txtAdm.Text

                ds.Tables("Registration").Rows.Add(dsNewRow)
                da.Update(ds, "Registration")
                MsgBox("New Record Added To The Database")
            End If

        Catch ex As Exception
            MsgBox("Update Not Possible" + ex.Message)
        End Try

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim sqls As String
        Dim mySearch As String = InputBox("Enter Name To Search")
        Try
            If mySearch <> "" Then
                sqls = "select * from Students where Reg_No LIKE '%" & mySearch & "%' "
                Dim dt As New DataTable
                ds = New DataSet()
                da = New OleDb.OleDbDataAdapter(sqls, con)
                ds.Tables.Add(dt)
                da.Fill(dt)

                DataGridView.DataSource = dt.DefaultView

            End If
        Catch ex As Exception
            MsgBox("Search Failed!!!" + ex.Message)
        End Try


    End Sub


End Class
