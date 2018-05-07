Imports System.Data.OleDb
Public Class Form2

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        lblDate.Text = DateTime.Now.ToLongDateString
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub Form2_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        Timer2.Start()

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdCancel.Click
        'Me.Close()
        Form3.Show()

    End Sub

    Private Sub cmdLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdLogin.Click
        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        dataFile = "E:\Maxwell\Car Rental system\CarRentalSystem.mdb"            ' <<<<<< Enter mdb.file path here
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        myConnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Admin] WHERE [Username] = '" & txtUsername.Text & "' AND [Password] = '" & txtPassword.Text & "' AND [Authentication] = '" & cboUsers.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim userFound As Boolean = False

        'the following variables will store Username and Password if found.
        Dim Username As String = ""
        Dim Password As String = ""
        Dim Name As String = ""

        'if found:
        While dr.Read
            userFound = True
            Username = dr("Username").ToString
            Password = dr("Password").ToString
            Name = dr("Full_Name").ToString
        End While

        'checking the result
        If userFound = True Then
            If cboUsers.Text = "Reception" Or cboUsers.Text = "Management" Then
                MsgBox("Hello, you have succefully logged on!")
                Me.Hide()
                Form3.Show()
                Form3.cmdAdmin.Enabled = False
                If cboUsers.Text = "Reception" Then
                    Form3.lblUser1.Text = "Reception"
                Else
                    Form3.lblUser1.Text = "Management"
                End If
            ElseIf cboUsers.Text = "Admin" Then
                Form3.Show()
                Me.Hide()
                Form3.lblUser1.Text = "Admin"
            Else
                MsgBox("Select User option")
                cboUsers.Focus()
            End If
        Else
            MsgBox("Sorry, username or password not found")
            txtPassword.Clear()
            txtUsername.Clear()
            cboUsers.Text = "Select"
        End If

        Form3.lblUser_Name.Text = Name
        myConnection.Close()
    End Sub

End Class