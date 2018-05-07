Imports System.Data.OleDb
Public Class Form4

    Private Sub cmdHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHome.Click
        Me.Dispose()
        Form3.Show()
    End Sub

    Private Sub Form4_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        GroupBox1.Visible = False
        GroupBox3.Visible = False

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarRentalSystemDataSet1.Admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter1.Fill(Me.CarRentalSystemDataSet1.Admin)
        'TODO: This line of code loads data into the 'CarRentalSystemDataSet1.ListOfCars' table. You can move, or remove it, as needed.
        Me.ListOfCarsTableAdapter.Fill(Me.CarRentalSystemDataSet1.ListOfCars)


        txtCar_color.Clear()
        txtCar_ID.Clear()
        txtEngine_no.Clear()
        txtFname.Clear()
        txtMake.Clear()
        txtModel.Clear()
        txtPassword1.Clear()
        'txtPassword2.Clear()
        txtReg_no.Clear()
        txtuserid.Clear()
        txtUsername.Clear()

    End Sub


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Me.AdminBindingSource.AddNew()
        AdminTableAdapter1.Update(CarRentalSystemDataSet.Admin)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Me.AdminBindingSource.EndEdit()
        AdminTableAdapter1.Update(CarRentalSystemDataSet.Admin)

        'Me.AdminTableAdapter1.Update(Me.AdminTableAdapter.)
        update_database()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Me.AdminBindingSource.Remove(DataGridViewSelectionMode.FullRowSelect)
    End Sub


    Private Sub cmdUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUsers.Click
        GroupBox1.Visible = True
        GroupBox3.Visible = False
    End Sub

    Private Sub cmdCars_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCars.Click
        GroupBox3.Visible = True
        GroupBox1.Visible = False
    End Sub

    Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Function update_database()
        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        dataFile = "G:\Car Rental system\CarRentalSystem.mdb"            ' <<<<<< Enter mdb.file path here
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        myConnection.Open()
        'the query:
        Dim str As String
        str = "Insert into Admin([Full_Name],[Username],[Password],[Authentication]) Values(?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Full_Name", CType(txtFname.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Username", CType(txtUsername.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(txtPassword1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Authentication", CType(cboUsers.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            MsgBox("Updated")
        Catch ex As Exception
            MsgBox("Failed to update")
            myConnection.Close()
        End Try
        myConnection.Close()
        Return Nothing
    End Function

   
    Private Sub cmdAdd_car_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_car.Click
        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        dataFile = "G:\Car Rental system\CarRentalSystem.mdb"            ' <<<<<< Enter mdb.file path here
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        myConnection.Open()
        'the query:
        Dim str As String
        str = "Insert into ListOfCars([Car_ID],[Plate_NO],[Color],[Car_Name],[Engine_No],[Seats]) Values(?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.Parameters.Add(New OleDbParameter("Car_ID", CType(txtCar_ID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Plate_NO", CType(txtReg_no.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Car_Name", CType(txtMake.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Color", CType(txtCar_color.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Seats", CType(txtSeats.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Engine_No", CType(txtEngine_no.Text, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            MsgBox("Updated")
            myConnection.Close()
        Catch ex As Exception
            'MsgBox("Failed to update")
        End Try
    End Sub

    Private Sub cmdSave_car_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave_car.Click
        Me.ListOfCarsBindingSource.EndEdit()
        ListOfCarsTableAdapter.Update(CarRentalSystemDataSet.ListOfCars)
    End Sub

    Private Sub cmdDelete_car_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete_car.Click
        Me.ListOfCarsBindingSource.Remove(SelectionMode.One)
    End Sub
End Class