

Public Class Form5

    Private Sub Form5_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        BindingNavigator1.Visible = False
        GroupBox2.Visible = False
        DataGridViewReturn.Visible = False
        DataGridViewRented.Visible = False
        DataGridViewRented.Visible = False
        cmdAdd.Enabled = False
        cmdSave.Enabled = False
        cmdDelete.Enabled = False
        Panel1.Visible = False
    End Sub


    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarRentalSystemDataSet.Rent_Details' table. You can move, or remove it, as needed.
        Me.Rent_DetailsTableAdapter.Fill(Me.CarRentalSystemDataSet.Rent_Details)
        'TODO: This line of code loads data into the 'CarRentalSystemDataSet.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter.Fill(Me.CarRentalSystemDataSet.Reservation)
        'TODO: This line of code loads data into the 'CarRentalSystemDataSet._Return' table. You can move, or remove it, as needed.
        Me.ReturnTableAdapter.Fill(Me.CarRentalSystemDataSet._Return)
        'TODO: This line of code loads data into the 'CarRentalSystemDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.CarRentalSystemDataSet.Clients)

    End Sub

    Private Sub cmdDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Me.ClientsBindingSource.RemoveCurrent()

    End Sub

    Private Sub cmdHome_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHome.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub ClientscmdClients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientscmdClients.Click
        BindingNavigator1.Visible = True
        cmdAdd.Enabled = True
        GroupBox2.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub cmdReservation_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReservation.Click
        BindingNavigator1.Visible = False
        GroupBox2.Visible = False
        Panel1.Visible = True
        DataGridViewHistory.Visible = False
        DataGridViewRented.Visible = False
        DataGridViewReturn.Visible = False
        DataGridViewBooking.Visible = True
    End Sub

    Private Sub cmdRented_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRented.Click
        BindingNavigator1.Visible = False
        GroupBox2.Visible = False
        Panel1.Visible = True
        DataGridViewHistory.Visible = False
        DataGridViewRented.Visible = True
        DataGridViewReturn.Visible = False
        DataGridViewBooking.Visible = False
    End Sub

    Private Sub cmdHistory_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHistory.Click
        BindingNavigator1.Visible = False
        GroupBox2.Visible = False
        Panel1.Visible = True
        DataGridViewHistory.Visible = True
        DataGridViewRented.Visible = False
        DataGridViewReturn.Visible = False
        DataGridViewBooking.Visible = False
    End Sub

    Private Sub cmdReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturn.Click
        BindingNavigator1.Visible = False
        GroupBox2.Visible = False
        Panel1.Visible = True
        DataGridViewHistory.Visible = False
        DataGridViewRented.Visible = False
        DataGridViewReturn.Visible = True
        DataGridViewBooking.Visible = False
    End Sub

    Private Sub cmdClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        GroupBox2.Visible = False
        Panel1.Visible = False
        DataGridViewHistory.Visible = False
        DataGridViewRented.Visible = False
        DataGridViewReturn.Visible = False
        DataGridViewBooking.Visible = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        ClientsBindingSource.EndEdit()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        cmdDelete.Enabled = True
        cmdSave.Enabled = True
        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub cmdAdd_Client_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_Client.Click
        ClientsBindingSource.AddNew()
        ClientsTableAdapter.Update(CarRentalSystemDataSet.Clients)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ClientsBindingSource.Filter = "Customer_ID='" & txtClient_ID.Text & "'"
    End Sub
End Class