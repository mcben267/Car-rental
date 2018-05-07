<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtClient_ID = New System.Windows.Forms.TextBox()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarRentalSystemDataSet = New Car_Rental_system.CarRentalSystemDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID_passort = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtDriveno = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPassportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrivingLicenseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewHistory = New System.Windows.Forms.DataGridView()
        Me.RentDetailsIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarIDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlateNoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarNameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentDayDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureDataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.RentDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewBooking = New System.Windows.Forms.DataGridView()
        Me.BookingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlateNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBorrowedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReturnedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcessedByDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewReturn = New System.Windows.Forms.DataGridView()
        Me.RentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlateNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBorrowedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReturnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcessedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewRented = New System.Windows.Forms.DataGridView()
        Me.RentDetailsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlateNoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.RentDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.cmdHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientscmdClients = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdReservation = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRented = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsTableAdapter = New Car_Rental_system.CarRentalSystemDataSetTableAdapters.ClientsTableAdapter()
        Me.ReturnTableAdapter = New Car_Rental_system.CarRentalSystemDataSetTableAdapters.ReturnTableAdapter()
        Me.ReservationTableAdapter = New Car_Rental_system.CarRentalSystemDataSetTableAdapters.ReservationTableAdapter()
        Me.Rent_DetailsTableAdapter = New Car_Rental_system.CarRentalSystemDataSetTableAdapters.Rent_DetailsTableAdapter()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdAdd_Client = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarRentalSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewRented, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAdd_Client)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtClient_ID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtID_passort)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.txtMobile)
        Me.GroupBox1.Controls.Add(Me.txtDriveno)
        Me.GroupBox1.Controls.Add(Me.txtLastname)
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(84, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 141)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client Details"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Find Client"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Client ID"
        '
        'txtClient_ID
        '
        Me.txtClient_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Customer_ID", True))
        Me.txtClient_ID.Location = New System.Drawing.Point(97, 25)
        Me.txtClient_ID.Name = "txtClient_ID"
        Me.txtClient_ID.Size = New System.Drawing.Size(100, 20)
        Me.txtClient_ID.TabIndex = 7
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "Clients"
        Me.ClientsBindingSource.DataSource = Me.CarRentalSystemDataSet
        '
        'CarRentalSystemDataSet
        '
        Me.CarRentalSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(216, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = " Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = " Mobile"
        '
        'txtID_passort
        '
        Me.txtID_passort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "ID/Passport", True))
        Me.txtID_passort.Location = New System.Drawing.Point(97, 104)
        Me.txtID_passort.Name = "txtID_passort"
        Me.txtID_passort.Size = New System.Drawing.Size(100, 20)
        Me.txtID_passort.TabIndex = 7
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Email", True))
        Me.TextBox6.Location = New System.Drawing.Point(280, 104)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 6
        '
        'txtMobile
        '
        Me.txtMobile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Mobile", True))
        Me.txtMobile.Location = New System.Drawing.Point(280, 78)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(100, 20)
        Me.txtMobile.TabIndex = 6
        '
        'txtDriveno
        '
        Me.txtDriveno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Driving License", True))
        Me.txtDriveno.Location = New System.Drawing.Point(97, 78)
        Me.txtDriveno.Name = "txtDriveno"
        Me.txtDriveno.Size = New System.Drawing.Size(100, 20)
        Me.txtDriveno.TabIndex = 5
        '
        'txtLastname
        '
        Me.txtLastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Last_Name", True))
        Me.txtLastname.Location = New System.Drawing.Point(280, 52)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(100, 20)
        Me.txtLastname.TabIndex = 5
        '
        'txtFirstname
        '
        Me.txtFirstname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "First_Name", True))
        Me.txtFirstname.Location = New System.Drawing.Point(97, 52)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID/Passport"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Driving License"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdSave)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Controls.Add(Me.cmdDelete)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(622, 348)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(260, 318)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 26)
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = " Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(179, 318)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 26)
        Me.cmdAdd.TabIndex = 14
        Me.cmdAdd.Text = " Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(341, 318)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 26)
        Me.cmdDelete.TabIndex = 12
        Me.cmdDelete.Text = " Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.IDPassportDataGridViewTextBoxColumn, Me.MobileDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DrivingLicenseDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 162)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(590, 150)
        Me.DataGridView1.TabIndex = 7
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'IDPassportDataGridViewTextBoxColumn
        '
        Me.IDPassportDataGridViewTextBoxColumn.DataPropertyName = "ID/Passport"
        Me.IDPassportDataGridViewTextBoxColumn.HeaderText = "ID/Passport"
        Me.IDPassportDataGridViewTextBoxColumn.Name = "IDPassportDataGridViewTextBoxColumn"
        '
        'MobileDataGridViewTextBoxColumn
        '
        Me.MobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile"
        Me.MobileDataGridViewTextBoxColumn.HeaderText = "Mobile"
        Me.MobileDataGridViewTextBoxColumn.Name = "MobileDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'DrivingLicenseDataGridViewTextBoxColumn
        '
        Me.DrivingLicenseDataGridViewTextBoxColumn.DataPropertyName = "Driving License"
        Me.DrivingLicenseDataGridViewTextBoxColumn.HeaderText = "Driving License"
        Me.DrivingLicenseDataGridViewTextBoxColumn.Name = "DrivingLicenseDataGridViewTextBoxColumn"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridViewHistory)
        Me.Panel1.Controls.Add(Me.DataGridViewBooking)
        Me.Panel1.Controls.Add(Me.DataGridViewReturn)
        Me.Panel1.Controls.Add(Me.DataGridViewRented)
        Me.Panel1.Location = New System.Drawing.Point(21, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 301)
        Me.Panel1.TabIndex = 13
        '
        'DataGridViewHistory
        '
        Me.DataGridViewHistory.AutoGenerateColumns = False
        Me.DataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RentDetailsIDDataGridViewTextBoxColumn1, Me.RentIDDataGridViewTextBoxColumn2, Me.CarIDDataGridViewTextBoxColumn3, Me.PlateNoDataGridViewTextBoxColumn3, Me.CarNameDataGridViewTextBoxColumn3, Me.ColorDataGridViewTextBoxColumn1, Me.SeatsDataGridViewTextBoxColumn1, Me.RentDayDataGridViewTextBoxColumn1, Me.PictureDataGridViewImageColumn1})
        Me.DataGridViewHistory.DataSource = Me.RentDetailsBindingSource1
        Me.DataGridViewHistory.Location = New System.Drawing.Point(4, 3)
        Me.DataGridViewHistory.Name = "DataGridViewHistory"
        Me.DataGridViewHistory.Size = New System.Drawing.Size(600, 299)
        Me.DataGridViewHistory.TabIndex = 11
        '
        'RentDetailsIDDataGridViewTextBoxColumn1
        '
        Me.RentDetailsIDDataGridViewTextBoxColumn1.DataPropertyName = "RentDetails_ID"
        Me.RentDetailsIDDataGridViewTextBoxColumn1.HeaderText = "RentDetails_ID"
        Me.RentDetailsIDDataGridViewTextBoxColumn1.Name = "RentDetailsIDDataGridViewTextBoxColumn1"
        '
        'RentIDDataGridViewTextBoxColumn2
        '
        Me.RentIDDataGridViewTextBoxColumn2.DataPropertyName = "Rent_ID"
        Me.RentIDDataGridViewTextBoxColumn2.HeaderText = "Rent_ID"
        Me.RentIDDataGridViewTextBoxColumn2.Name = "RentIDDataGridViewTextBoxColumn2"
        '
        'CarIDDataGridViewTextBoxColumn3
        '
        Me.CarIDDataGridViewTextBoxColumn3.DataPropertyName = "Car_ID"
        Me.CarIDDataGridViewTextBoxColumn3.HeaderText = "Car_ID"
        Me.CarIDDataGridViewTextBoxColumn3.Name = "CarIDDataGridViewTextBoxColumn3"
        '
        'PlateNoDataGridViewTextBoxColumn3
        '
        Me.PlateNoDataGridViewTextBoxColumn3.DataPropertyName = "Plate_No"
        Me.PlateNoDataGridViewTextBoxColumn3.HeaderText = "Plate_No"
        Me.PlateNoDataGridViewTextBoxColumn3.Name = "PlateNoDataGridViewTextBoxColumn3"
        '
        'CarNameDataGridViewTextBoxColumn3
        '
        Me.CarNameDataGridViewTextBoxColumn3.DataPropertyName = "Car_Name"
        Me.CarNameDataGridViewTextBoxColumn3.HeaderText = "Car_Name"
        Me.CarNameDataGridViewTextBoxColumn3.Name = "CarNameDataGridViewTextBoxColumn3"
        '
        'ColorDataGridViewTextBoxColumn1
        '
        Me.ColorDataGridViewTextBoxColumn1.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn1.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn1.Name = "ColorDataGridViewTextBoxColumn1"
        '
        'SeatsDataGridViewTextBoxColumn1
        '
        Me.SeatsDataGridViewTextBoxColumn1.DataPropertyName = "Seats"
        Me.SeatsDataGridViewTextBoxColumn1.HeaderText = "Seats"
        Me.SeatsDataGridViewTextBoxColumn1.Name = "SeatsDataGridViewTextBoxColumn1"
        '
        'RentDayDataGridViewTextBoxColumn1
        '
        Me.RentDayDataGridViewTextBoxColumn1.DataPropertyName = "Rent/Day"
        Me.RentDayDataGridViewTextBoxColumn1.HeaderText = "Rent/Day"
        Me.RentDayDataGridViewTextBoxColumn1.Name = "RentDayDataGridViewTextBoxColumn1"
        '
        'PictureDataGridViewImageColumn1
        '
        Me.PictureDataGridViewImageColumn1.DataPropertyName = "Picture"
        Me.PictureDataGridViewImageColumn1.HeaderText = "Picture"
        Me.PictureDataGridViewImageColumn1.Name = "PictureDataGridViewImageColumn1"
        '
        'RentDetailsBindingSource1
        '
        Me.RentDetailsBindingSource1.DataMember = "Rent_Details"
        Me.RentDetailsBindingSource1.DataSource = Me.CarRentalSystemDataSet
        '
        'DataGridViewBooking
        '
        Me.DataGridViewBooking.AutoGenerateColumns = False
        Me.DataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBooking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn2, Me.LastNameDataGridViewTextBoxColumn2, Me.CarIDDataGridViewTextBoxColumn1, Me.CarNameDataGridViewTextBoxColumn1, Me.PlateNoDataGridViewTextBoxColumn1, Me.DateBorrowedDataGridViewTextBoxColumn1, Me.DateReturnedDataGridViewTextBoxColumn1, Me.ProcessedByDataGridViewTextBoxColumn1})
        Me.DataGridViewBooking.DataSource = Me.ReservationBindingSource
        Me.DataGridViewBooking.Location = New System.Drawing.Point(4, 3)
        Me.DataGridViewBooking.Name = "DataGridViewBooking"
        Me.DataGridViewBooking.Size = New System.Drawing.Size(600, 299)
        Me.DataGridViewBooking.TabIndex = 10
        '
        'BookingIDDataGridViewTextBoxColumn
        '
        Me.BookingIDDataGridViewTextBoxColumn.DataPropertyName = "Booking_ID"
        Me.BookingIDDataGridViewTextBoxColumn.HeaderText = "Booking_ID"
        Me.BookingIDDataGridViewTextBoxColumn.Name = "BookingIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn2
        '
        Me.FirstNameDataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn2.Name = "FirstNameDataGridViewTextBoxColumn2"
        '
        'LastNameDataGridViewTextBoxColumn2
        '
        Me.LastNameDataGridViewTextBoxColumn2.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn2.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn2.Name = "LastNameDataGridViewTextBoxColumn2"
        '
        'CarIDDataGridViewTextBoxColumn1
        '
        Me.CarIDDataGridViewTextBoxColumn1.DataPropertyName = "Car_ID"
        Me.CarIDDataGridViewTextBoxColumn1.HeaderText = "Car_ID"
        Me.CarIDDataGridViewTextBoxColumn1.Name = "CarIDDataGridViewTextBoxColumn1"
        '
        'CarNameDataGridViewTextBoxColumn1
        '
        Me.CarNameDataGridViewTextBoxColumn1.DataPropertyName = "Car_Name"
        Me.CarNameDataGridViewTextBoxColumn1.HeaderText = "Car_Name"
        Me.CarNameDataGridViewTextBoxColumn1.Name = "CarNameDataGridViewTextBoxColumn1"
        '
        'PlateNoDataGridViewTextBoxColumn1
        '
        Me.PlateNoDataGridViewTextBoxColumn1.DataPropertyName = "Plate_No"
        Me.PlateNoDataGridViewTextBoxColumn1.HeaderText = "Plate_No"
        Me.PlateNoDataGridViewTextBoxColumn1.Name = "PlateNoDataGridViewTextBoxColumn1"
        '
        'DateBorrowedDataGridViewTextBoxColumn1
        '
        Me.DateBorrowedDataGridViewTextBoxColumn1.DataPropertyName = "Date_Borrowed"
        Me.DateBorrowedDataGridViewTextBoxColumn1.HeaderText = "Date_Borrowed"
        Me.DateBorrowedDataGridViewTextBoxColumn1.Name = "DateBorrowedDataGridViewTextBoxColumn1"
        '
        'DateReturnedDataGridViewTextBoxColumn1
        '
        Me.DateReturnedDataGridViewTextBoxColumn1.DataPropertyName = "Date_Returned"
        Me.DateReturnedDataGridViewTextBoxColumn1.HeaderText = "Date_Returned"
        Me.DateReturnedDataGridViewTextBoxColumn1.Name = "DateReturnedDataGridViewTextBoxColumn1"
        '
        'ProcessedByDataGridViewTextBoxColumn1
        '
        Me.ProcessedByDataGridViewTextBoxColumn1.DataPropertyName = "Processed_By"
        Me.ProcessedByDataGridViewTextBoxColumn1.HeaderText = "Processed_By"
        Me.ProcessedByDataGridViewTextBoxColumn1.Name = "ProcessedByDataGridViewTextBoxColumn1"
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.DataSource = Me.CarRentalSystemDataSet
        '
        'DataGridViewReturn
        '
        Me.DataGridViewReturn.AutoGenerateColumns = False
        Me.DataGridViewReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReturn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RentIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn1, Me.LastNameDataGridViewTextBoxColumn1, Me.CarIDDataGridViewTextBoxColumn, Me.CarNameDataGridViewTextBoxColumn, Me.PlateNoDataGridViewTextBoxColumn, Me.DateBorrowedDataGridViewTextBoxColumn, Me.DateReturnedDataGridViewTextBoxColumn, Me.ProcessedByDataGridViewTextBoxColumn})
        Me.DataGridViewReturn.DataSource = Me.ReturnBindingSource
        Me.DataGridViewReturn.Location = New System.Drawing.Point(4, 3)
        Me.DataGridViewReturn.Name = "DataGridViewReturn"
        Me.DataGridViewReturn.Size = New System.Drawing.Size(600, 299)
        Me.DataGridViewReturn.TabIndex = 8
        '
        'RentIDDataGridViewTextBoxColumn
        '
        Me.RentIDDataGridViewTextBoxColumn.DataPropertyName = "Rent_ID"
        Me.RentIDDataGridViewTextBoxColumn.HeaderText = "Rent_ID"
        Me.RentIDDataGridViewTextBoxColumn.Name = "RentIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn1
        '
        Me.FirstNameDataGridViewTextBoxColumn1.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn1.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn1.Name = "FirstNameDataGridViewTextBoxColumn1"
        '
        'LastNameDataGridViewTextBoxColumn1
        '
        Me.LastNameDataGridViewTextBoxColumn1.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn1.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn1.Name = "LastNameDataGridViewTextBoxColumn1"
        '
        'CarIDDataGridViewTextBoxColumn
        '
        Me.CarIDDataGridViewTextBoxColumn.DataPropertyName = "Car_ID"
        Me.CarIDDataGridViewTextBoxColumn.HeaderText = "Car_ID"
        Me.CarIDDataGridViewTextBoxColumn.Name = "CarIDDataGridViewTextBoxColumn"
        '
        'CarNameDataGridViewTextBoxColumn
        '
        Me.CarNameDataGridViewTextBoxColumn.DataPropertyName = "Car_Name"
        Me.CarNameDataGridViewTextBoxColumn.HeaderText = "Car_Name"
        Me.CarNameDataGridViewTextBoxColumn.Name = "CarNameDataGridViewTextBoxColumn"
        '
        'PlateNoDataGridViewTextBoxColumn
        '
        Me.PlateNoDataGridViewTextBoxColumn.DataPropertyName = "Plate_No"
        Me.PlateNoDataGridViewTextBoxColumn.HeaderText = "Plate_No"
        Me.PlateNoDataGridViewTextBoxColumn.Name = "PlateNoDataGridViewTextBoxColumn"
        '
        'DateBorrowedDataGridViewTextBoxColumn
        '
        Me.DateBorrowedDataGridViewTextBoxColumn.DataPropertyName = "Date_Borrowed"
        Me.DateBorrowedDataGridViewTextBoxColumn.HeaderText = "Date_Borrowed"
        Me.DateBorrowedDataGridViewTextBoxColumn.Name = "DateBorrowedDataGridViewTextBoxColumn"
        '
        'DateReturnedDataGridViewTextBoxColumn
        '
        Me.DateReturnedDataGridViewTextBoxColumn.DataPropertyName = "Date_Returned"
        Me.DateReturnedDataGridViewTextBoxColumn.HeaderText = "Date_Returned"
        Me.DateReturnedDataGridViewTextBoxColumn.Name = "DateReturnedDataGridViewTextBoxColumn"
        '
        'ProcessedByDataGridViewTextBoxColumn
        '
        Me.ProcessedByDataGridViewTextBoxColumn.DataPropertyName = "Processed_By"
        Me.ProcessedByDataGridViewTextBoxColumn.HeaderText = "Processed_By"
        Me.ProcessedByDataGridViewTextBoxColumn.Name = "ProcessedByDataGridViewTextBoxColumn"
        '
        'ReturnBindingSource
        '
        Me.ReturnBindingSource.DataMember = "Return"
        Me.ReturnBindingSource.DataSource = Me.CarRentalSystemDataSet
        '
        'DataGridViewRented
        '
        Me.DataGridViewRented.AutoGenerateColumns = False
        Me.DataGridViewRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRented.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RentDetailsIDDataGridViewTextBoxColumn, Me.RentIDDataGridViewTextBoxColumn1, Me.CarIDDataGridViewTextBoxColumn2, Me.PlateNoDataGridViewTextBoxColumn2, Me.CarNameDataGridViewTextBoxColumn2, Me.ColorDataGridViewTextBoxColumn, Me.SeatsDataGridViewTextBoxColumn, Me.RentDayDataGridViewTextBoxColumn, Me.PictureDataGridViewImageColumn})
        Me.DataGridViewRented.DataSource = Me.RentDetailsBindingSource
        Me.DataGridViewRented.Location = New System.Drawing.Point(4, 3)
        Me.DataGridViewRented.Name = "DataGridViewRented"
        Me.DataGridViewRented.Size = New System.Drawing.Size(600, 299)
        Me.DataGridViewRented.TabIndex = 9
        '
        'RentDetailsIDDataGridViewTextBoxColumn
        '
        Me.RentDetailsIDDataGridViewTextBoxColumn.DataPropertyName = "RentDetails_ID"
        Me.RentDetailsIDDataGridViewTextBoxColumn.HeaderText = "RentDetails_ID"
        Me.RentDetailsIDDataGridViewTextBoxColumn.Name = "RentDetailsIDDataGridViewTextBoxColumn"
        '
        'RentIDDataGridViewTextBoxColumn1
        '
        Me.RentIDDataGridViewTextBoxColumn1.DataPropertyName = "Rent_ID"
        Me.RentIDDataGridViewTextBoxColumn1.HeaderText = "Rent_ID"
        Me.RentIDDataGridViewTextBoxColumn1.Name = "RentIDDataGridViewTextBoxColumn1"
        '
        'CarIDDataGridViewTextBoxColumn2
        '
        Me.CarIDDataGridViewTextBoxColumn2.DataPropertyName = "Car_ID"
        Me.CarIDDataGridViewTextBoxColumn2.HeaderText = "Car_ID"
        Me.CarIDDataGridViewTextBoxColumn2.Name = "CarIDDataGridViewTextBoxColumn2"
        '
        'PlateNoDataGridViewTextBoxColumn2
        '
        Me.PlateNoDataGridViewTextBoxColumn2.DataPropertyName = "Plate_No"
        Me.PlateNoDataGridViewTextBoxColumn2.HeaderText = "Plate_No"
        Me.PlateNoDataGridViewTextBoxColumn2.Name = "PlateNoDataGridViewTextBoxColumn2"
        '
        'CarNameDataGridViewTextBoxColumn2
        '
        Me.CarNameDataGridViewTextBoxColumn2.DataPropertyName = "Car_Name"
        Me.CarNameDataGridViewTextBoxColumn2.HeaderText = "Car_Name"
        Me.CarNameDataGridViewTextBoxColumn2.Name = "CarNameDataGridViewTextBoxColumn2"
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        '
        'SeatsDataGridViewTextBoxColumn
        '
        Me.SeatsDataGridViewTextBoxColumn.DataPropertyName = "Seats"
        Me.SeatsDataGridViewTextBoxColumn.HeaderText = "Seats"
        Me.SeatsDataGridViewTextBoxColumn.Name = "SeatsDataGridViewTextBoxColumn"
        '
        'RentDayDataGridViewTextBoxColumn
        '
        Me.RentDayDataGridViewTextBoxColumn.DataPropertyName = "Rent/Day"
        Me.RentDayDataGridViewTextBoxColumn.HeaderText = "Rent/Day"
        Me.RentDayDataGridViewTextBoxColumn.Name = "RentDayDataGridViewTextBoxColumn"
        '
        'PictureDataGridViewImageColumn
        '
        Me.PictureDataGridViewImageColumn.DataPropertyName = "Picture"
        Me.PictureDataGridViewImageColumn.HeaderText = "Picture"
        Me.PictureDataGridViewImageColumn.Name = "PictureDataGridViewImageColumn"
        '
        'RentDetailsBindingSource
        '
        Me.RentDetailsBindingSource.DataMember = "Rent_Details"
        Me.RentDetailsBindingSource.DataSource = Me.CarRentalSystemDataSet
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.ClientsBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 25)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(644, 29)
        Me.BindingNavigator1.TabIndex = 13
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 26)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 29)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdHome, Me.ClientscmdClients, Me.cmdReservation, Me.cmdRented, Me.cmdReturn, Me.cmdHistory})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(644, 25)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'cmdHome
        '
        Me.cmdHome.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHome.Name = "cmdHome"
        Me.cmdHome.Size = New System.Drawing.Size(57, 21)
        Me.cmdHome.Text = "Home"
        '
        'ClientscmdClients
        '
        Me.ClientscmdClients.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientscmdClients.Name = "ClientscmdClients"
        Me.ClientscmdClients.Size = New System.Drawing.Size(60, 21)
        Me.ClientscmdClients.Text = "Clients"
        '
        'cmdReservation
        '
        Me.cmdReservation.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReservation.Name = "cmdReservation"
        Me.cmdReservation.Size = New System.Drawing.Size(91, 21)
        Me.cmdReservation.Text = "Reservation"
        '
        'cmdRented
        '
        Me.cmdRented.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRented.Name = "cmdRented"
        Me.cmdRented.Size = New System.Drawing.Size(63, 21)
        Me.cmdRented.Text = "Rented"
        '
        'cmdReturn
        '
        Me.cmdReturn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(61, 21)
        Me.cmdReturn.Text = "Return"
        '
        'cmdHistory
        '
        Me.cmdHistory.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHistory.Name = "cmdHistory"
        Me.cmdHistory.Size = New System.Drawing.Size(116, 21)
        Me.cmdHistory.Text = "History Records"
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'ReturnTableAdapter
        '
        Me.ReturnTableAdapter.ClearBeforeFill = True
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'Rent_DetailsTableAdapter
        '
        Me.Rent_DetailsTableAdapter.ClearBeforeFill = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(536, 414)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 26)
        Me.cmdClose.TabIndex = 15
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdAdd_Client
        '
        Me.cmdAdd_Client.Location = New System.Drawing.Point(215, 19)
        Me.cmdAdd_Client.Name = "cmdAdd_Client"
        Me.cmdAdd_Client.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd_Client.TabIndex = 10
        Me.cmdAdd_Client.Text = "Add Client"
        Me.cmdAdd_Client.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 445)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarRentalSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewRented, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtClient_ID As System.Windows.Forms.TextBox
    Friend WithEvents txtID_passort As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtDriveno As System.Windows.Forms.TextBox
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents DataGridViewRented As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewReturn As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewBooking As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewHistory As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents cmdHome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientscmdClients As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdReservation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRented As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarRentalSystemDataSet As Car_Rental_system.CarRentalSystemDataSet
    Friend WithEvents ClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientsTableAdapter As Car_Rental_system.CarRentalSystemDataSetTableAdapters.ClientsTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPassportDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DrivingLicenseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReturnTableAdapter As Car_Rental_system.CarRentalSystemDataSetTableAdapters.ReturnTableAdapter
    Friend WithEvents RentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlateNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateBorrowedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateReturnedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcessedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReservationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationTableAdapter As Car_Rental_system.CarRentalSystemDataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents BookingIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlateNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateBorrowedDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateReturnedDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcessedByDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RentDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rent_DetailsTableAdapter As Car_Rental_system.CarRentalSystemDataSetTableAdapters.Rent_DetailsTableAdapter
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents RentDetailsIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RentIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarIDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlateNoDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarNameDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeatsDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RentDayDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureDataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents RentDetailsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RentDetailsIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RentIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlateNoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarNameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeatsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RentDayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdAdd_Client As System.Windows.Forms.Button
End Class
