Public Class Form3

    Private Sub Form3_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.TabControl1.Visible = False
        ' Me.Client_ListPanel.Visible = False
        'New_ClientPanel.Visible = False

        Timer1.Start()
        txtdays.Enabled = False
        txtClient_Name.Enabled = False
        txtClient_Surname.Enabled = False
        txtMobile.Enabled = False
        txtDr_entry.Enabled = False
        txtID_Passport.Enabled = False
        txtEmail.Enabled = False
    End Sub

    Private Sub cmdLogout_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        lblEvents.Text = "Log Out"
    End Sub

    Private Sub cmdLogout_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        lblEvents.Text = ""

    End Sub


    Private Sub cmdAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdmin.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub cmdAdmin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdmin.MouseHover
        lblEvents.Text = "Administration panel"
    End Sub

    Private Sub cmdAdmin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdmin.MouseLeave
        lblEvents.Text = ""
    End Sub



    Private Sub cmdProfile_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdManagement.MouseHover
        lblEvents.Text = "View and edit account"
    End Sub

    Private Sub cmdProfile_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdManagement.MouseLeave
        lblEvents.Text = ""
    End Sub

    Private Sub cmdHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHelp.Click

    End Sub

    Private Sub cmdHelp_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdHelp.MouseHover
        lblEvents.Text = "Ask for assistance"
    End Sub

    Private Sub cmdHelp_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdHelp.MouseLeave
        lblEvents.Text = ""
    End Sub

    Private Sub cmdHire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHire.Click
        txtID_Passport.Text = "1001"
        Me.TabControl1.Visible = True
        TabControl1.SelectedIndex = 0
        Label17.Text = "Rent ID"
        'disable buttons
        cmdReservation.Enabled = False
        cmdReturn.Enabled = False

        Forward_progres()
    End Sub

    Private Sub cmdReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReservation.Click
        txtID_Passport.Text = "2001"
        Me.TabControl1.Visible = True
        TabControl1.SelectedIndex = 0
        Label7.Text = "Reservation ID"
        'disable buttons
        cmdHire.Enabled = False
        cmdReturn.Enabled = False
        Forward_progres()

    End Sub

    Private Sub cmdReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturn.Click
        txtID_Passport.Text = "3001"
        Me.TabControl1.Visible = True
        TabControl1.SelectedIndex = 1
        Label17.Text = "Rent ID"
        'disenable buttons
        cmdBack1.Enabled = False
        cmdReservation.Enabled = False
        cmdHire.Enabled = False
        Forward_progres()
    End Sub


    '*************************************************************************************************************
    Function Forward_progres()

        ProgressBar1.Increment(25)
        If ProgressBar1.Value = 100 Then
            ProgressBar1.Value = 100
        End If
        Return Nothing
    End Function
    Function Backwards_progres()
        ProgressBar1.Increment(-25)
        If ProgressBar1.Value = 0 Then
            ProgressBar1.Value = 0
        End If
        Return Nothing
    End Function
    '**************************************************************************************************************

    Private Sub cmdNext1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext1.Click
        Forward_progres()
        TabControl1.SelectedIndex = 1

    End Sub

    Private Sub cmdNext2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext2.Click
        Forward_progres()
        TabControl1.SelectedIndex = 2
        txtclient_id_pay.Text = txtClient_ID.Text
        Dim days As Double
        Dim rentfee, amount As Double
        rentfee = lblRent_fee.Text
        days = txtdays.Text
        amount = Val(rentfee) * Val(days)
        txtAmount.Text = amount
        txtIDs.Enabled = False
        txtclient_id_pay.Enabled = False
        txtdays_pay.Enabled = False
        txtAmount.Enabled = False

       
    End Sub

    Private Sub cmdFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinish.Click

        Dim dues As String
        Forward_progres()
        MsgBox("Completed successfully.", MsgBoxStyle.OkCancel)
        dues = txtAmount.Text
        MsgBox("Amount = " + dues, MsgBoxStyle.OkCancel)

        '  If cmdHire.Enabled = True Then
        '      cmdReservation.Enabled = True
        '       cmdReturn.Enabled = True
        '
        '   ElseIf cmdReservation.Enabled = True Then
        '     cmdHire.Enabled = True
        '  cmdReturn.Enabled = True

        ' ElseIf cmdReservation.Enabled = True Then
        '      cmdHire.Enabled = True
        '     cmdReservation.Enabled = True
        'End If

        cmdHire.Enabled = True
        cmdReservation.Enabled = True
        cmdReturn.Enabled = True

        ProgressBar1.Value = 0
        ProgressBar1.Visible = False

    End Sub

    Private Sub cmdBack2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack2.Click
        TabControl1.SelectedIndex = 1
        Backwards_progres()
    End Sub

    Private Sub cmdBack1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack1.Click
        TabControl1.SelectedIndex = 0
        Backwards_progres()
        GroupBox4.Enabled = True
        GroupBox1.Enabled = True
    End Sub

    Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click
        Me.Hide()
        Form2.Show()
        Form2.txtPassword.Clear()
        Form2.txtUsername.Clear()
        Form2.cboUsers.Text = "Select"
    End Sub

    Private Sub cmdHire_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdHire.MouseHover
        lblEvents.Text = "Rent/Hire a car."
    End Sub

    Private Sub cmdHire_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdHire.MouseLeave
        lblEvents.Text = ""
    End Sub

    Private Sub cmdReservation_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdReservation.MouseHover
        lblEvents.Text = "Book a car in advance."
    End Sub

    Private Sub cmdReservation_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdReservation.MouseLeave
        lblEvents.Text = ""
    End Sub

    Private Sub cmdReturn_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdReturn.MouseHover
        lblEvents.Text = "Sign out the vehicle."
    End Sub

    Private Sub cmdReturn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdReturn.MouseLeave
        lblEvents.Text = ""
    End Sub

    Private Sub cmdNew_client_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' If cmdNew_client.Enabled Then
        ' Client_ListPanel.Visible = True
        cmdHire.Enabled = False
        cmdReturn.Enabled = False
        cmdReservation.Enabled = False
        Me.TabControl1.Visible = False
        ' End If


    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Client_ListPanel.Visible = False
        cmdHire.Enabled = True
        cmdReturn.Enabled = True
        cmdReservation.Enabled = True
        Me.TabControl1.Visible = False
    End Sub

    Private Sub cmdCancel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'New_ClientPanel.Visible = False
        cmdHire.Enabled = True
        cmdReturn.Enabled = True
        cmdReservation.Enabled = True
        Me.TabControl1.Visible = False
    End Sub

    Private Sub cmdRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDate.Text = DateTime.Now.ToLongDateString
        lblTime.Text = TimeOfDay
        lblcurrent_time.Text = TimeOfDay
    End Sub

    Private Sub cmdCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.TabControl1.Visible = False
        TabControl1.SelectedIndex = 0
        cmdHire.Enabled = True
        cmdReturn.Enabled = True
        cmdReservation.Enabled = True
        GroupBox3.Enabled = True
    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        GroupBox3.Enabled = False

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarRentalSystemDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.CarRentalSystemDataSet.Clients)
        'TODO: This line of code loads data into the 'CarRentalSystemDataSet.ListOfCars' table. You can move, or remove it, as needed.
        Me.ListOfCarsTableAdapter.Fill(Me.CarRentalSystemDataSet.ListOfCars)
        ProgressBar1.Visible = False
    End Sub

    Private Sub cmdSelect1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect1.Click
        Dim client As String
        GroupBox4.Enabled = False
        GroupBox1.Enabled = False

        client = txtClient_ID.Text
        txtclient_id_pay.Text = client
    End Sub

    Private Sub cmdClients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClients.Click
        Me.Hide()
        Form5.Show()
        BindingNavigator1.Visible = True
        Form5.cmdAdd.Enabled = True
        Form5.GroupBox2.Visible = True
    End Sub

    Private Sub cmdRecords_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form5.Show()
        Me.Hide()
    End Sub


    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub cmdValidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdValidate.Click
        Dim First As Date
        Dim Second As Date
        Dim Result As New TimeSpan()
        Dim Ans As String
        First = DateTimePicker1.Value
        Second = DateTimePicker2.Value
        Result = Second - First
        Ans = FormatNumber(Result.TotalDays.ToString, 2)
        txtdays.Text = FormatNumber(Result.TotalDays.ToString, 2)
        txtdays_pay.Text = txtdays.Text
        txtdays.Enabled = True

    End Sub

    Private Sub cmdSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Me.ClientsBindingSource.Filter = "Customer_ID='" & txtClient_ID.Text & "'"
    End Sub

    Private Sub cmdManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdManagement.Click

    End Sub
End Class