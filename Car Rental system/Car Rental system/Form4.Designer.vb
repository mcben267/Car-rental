<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.cmdHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCars = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cboUsers = New System.Windows.Forms.ComboBox()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarRentalSystemDataSet1 = New Car_Rental_system.CarRentalSystemDataSet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtPassword1 = New System.Windows.Forms.TextBox()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtSeats = New System.Windows.Forms.TextBox()
        Me.ListOfCarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdDelete_car = New System.Windows.Forms.Button()
        Me.cmdSave_car = New System.Windows.Forms.Button()
        Me.cmdAdd_car = New System.Windows.Forms.Button()
        Me.txtCar_color = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPlate_No = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEngine_no = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.txtReg_no = New System.Windows.Forms.TextBox()
        Me.txtCar_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CarIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlateNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EngineNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListOfCarsTableAdapter = New Car_Rental_system.CarRentalSystemDataSetTableAdapters.ListOfCarsTableAdapter()
        Me.AdminTableAdapter1 = New Car_Rental_system.CarRentalSystemDataSetTableAdapters.AdminTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarRentalSystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdHome, Me.cmdCars, Me.cmdUsers, Me.cmdLogout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(732, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'cmdHome
        '
        Me.cmdHome.Name = "cmdHome"
        Me.cmdHome.Size = New System.Drawing.Size(52, 20)
        Me.cmdHome.Text = "Home"
        '
        'cmdCars
        '
        Me.cmdCars.Name = "cmdCars"
        Me.cmdCars.Size = New System.Drawing.Size(62, 20)
        Me.cmdCars.Text = "Vehicles"
        '
        'cmdUsers
        '
        Me.cmdUsers.Name = "cmdUsers"
        Me.cmdUsers.Size = New System.Drawing.Size(47, 20)
        Me.cmdUsers.Text = "Users"
        '
        'cmdLogout
        '
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(57, 20)
        Me.cmdLogout.Text = "Logout"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdDelete)
        Me.GroupBox2.Controls.Add(Me.cmdSave)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Controls.Add(Me.cboUsers)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtFname)
        Me.GroupBox2.Controls.Add(Me.txtPassword1)
        Me.GroupBox2.Controls.Add(Me.txtuserid)
        Me.GroupBox2.Controls.Add(Me.txtUsername)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(526, 109)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New User Details"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(445, 68)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 14
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(445, 39)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 13
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(445, 10)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 12
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cboUsers
        '
        Me.cboUsers.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "Authentication", True))
        Me.cboUsers.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsers.FormattingEnabled = True
        Me.cboUsers.Items.AddRange(New Object() {"Admin", "Reception", "Management"})
        Me.cboUsers.Location = New System.Drawing.Point(313, 43)
        Me.cboUsers.Name = "cboUsers"
        Me.cboUsers.Size = New System.Drawing.Size(100, 22)
        Me.cboUsers.TabIndex = 11
        Me.cboUsers.Text = "Select"
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "Admin"
        Me.AdminBindingSource.DataSource = Me.CarRentalSystemDataSet1
        '
        'CarRentalSystemDataSet1
        '
        Me.CarRentalSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "First Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Password"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(216, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = " Authentication"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(216, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "User ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Username"
        '
        'txtFname
        '
        Me.txtFname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "Full_Name", True))
        Me.txtFname.Location = New System.Drawing.Point(97, 19)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(100, 20)
        Me.txtFname.TabIndex = 4
        '
        'txtPassword1
        '
        Me.txtPassword1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "Password", True))
        Me.txtPassword1.Location = New System.Drawing.Point(97, 71)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword1.TabIndex = 6
        '
        'txtuserid
        '
        Me.txtuserid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "User_ID", True))
        Me.txtuserid.Location = New System.Drawing.Point(313, 16)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(100, 20)
        Me.txtuserid.TabIndex = 5
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "Username", True))
        Me.txtUsername.Location = New System.Drawing.Point(97, 45)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DataGridView1.DataSource = Me.AdminBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 204)
        Me.DataGridView1.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "User_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "User_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Full_Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Full_Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Authentication"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Authentication"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 344)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 385)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(732, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 344)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSeats)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtCategory)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.cmdDelete_car)
        Me.GroupBox4.Controls.Add(Me.cmdSave_car)
        Me.GroupBox4.Controls.Add(Me.cmdAdd_car)
        Me.GroupBox4.Controls.Add(Me.txtCar_color)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtPlate_No)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtEngine_no)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtModel)
        Me.GroupBox4.Controls.Add(Me.txtMake)
        Me.GroupBox4.Controls.Add(Me.txtReg_no)
        Me.GroupBox4.Controls.Add(Me.txtCar_ID)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(79, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(540, 140)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Vehicle Details"
        '
        'txtSeats
        '
        Me.txtSeats.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Seats", True))
        Me.txtSeats.Location = New System.Drawing.Point(401, 19)
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.Size = New System.Drawing.Size(100, 20)
        Me.txtSeats.TabIndex = 38
        Me.txtSeats.Text = " "
        '
        'ListOfCarsBindingSource
        '
        Me.ListOfCarsBindingSource.DataMember = "ListOfCars"
        Me.ListOfCarsBindingSource.DataSource = Me.CarRentalSystemDataSet1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(342, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Steats"
        '
        'txtCategory
        '
        Me.txtCategory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Category", True))
        Me.txtCategory.Location = New System.Drawing.Point(401, 46)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(100, 20)
        Me.txtCategory.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(342, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = " Category"
        '
        'cmdDelete_car
        '
        Me.cmdDelete_car.Location = New System.Drawing.Point(288, 104)
        Me.cmdDelete_car.Name = "cmdDelete_car"
        Me.cmdDelete_car.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete_car.TabIndex = 32
        Me.cmdDelete_car.Text = "Delete"
        Me.cmdDelete_car.UseVisualStyleBackColor = True
        '
        'cmdSave_car
        '
        Me.cmdSave_car.Location = New System.Drawing.Point(207, 104)
        Me.cmdSave_car.Name = "cmdSave_car"
        Me.cmdSave_car.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave_car.TabIndex = 31
        Me.cmdSave_car.Text = "Save"
        Me.cmdSave_car.UseVisualStyleBackColor = True
        '
        'cmdAdd_car
        '
        Me.cmdAdd_car.Location = New System.Drawing.Point(126, 104)
        Me.cmdAdd_car.Name = "cmdAdd_car"
        Me.cmdAdd_car.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd_car.TabIndex = 30
        Me.cmdAdd_car.Text = "Add"
        Me.cmdAdd_car.UseVisualStyleBackColor = True
        '
        'txtCar_color
        '
        Me.txtCar_color.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Color", True))
        Me.txtCar_color.Location = New System.Drawing.Point(236, 19)
        Me.txtCar_color.Name = "txtCar_color"
        Me.txtCar_color.Size = New System.Drawing.Size(100, 20)
        Me.txtCar_color.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = " Car Color"
        '
        'txtPlate_No
        '
        Me.txtPlate_No.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Plate_No", True))
        Me.txtPlate_No.Location = New System.Drawing.Point(236, 45)
        Me.txtPlate_No.Name = "txtPlate_No"
        Me.txtPlate_No.Size = New System.Drawing.Size(100, 20)
        Me.txtPlate_No.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(175, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Plate No."
        '
        'txtEngine_no
        '
        Me.txtEngine_no.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Engine_No", True))
        Me.txtEngine_no.Location = New System.Drawing.Point(401, 72)
        Me.txtEngine_no.Name = "txtEngine_no"
        Me.txtEngine_no.Size = New System.Drawing.Size(100, 20)
        Me.txtEngine_no.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "EngineNo."
        '
        'txtModel
        '
        Me.txtModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Model", True))
        Me.txtModel.Location = New System.Drawing.Point(236, 71)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(100, 20)
        Me.txtModel.TabIndex = 24
        '
        'txtMake
        '
        Me.txtMake.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Car_Name", True))
        Me.txtMake.Location = New System.Drawing.Point(71, 71)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(100, 20)
        Me.txtMake.TabIndex = 25
        '
        'txtReg_no
        '
        Me.txtReg_no.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Reg_No", True))
        Me.txtReg_no.Location = New System.Drawing.Point(69, 45)
        Me.txtReg_no.Name = "txtReg_no"
        Me.txtReg_no.Size = New System.Drawing.Size(100, 20)
        Me.txtReg_no.TabIndex = 23
        '
        'txtCar_ID
        '
        Me.txtCar_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Car_ID", True))
        Me.txtCar_ID.Location = New System.Drawing.Point(69, 19)
        Me.txtCar_ID.Name = "txtCar_ID"
        Me.txtCar_ID.Size = New System.Drawing.Size(100, 20)
        Me.txtCar_ID.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Model"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Car Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = " Reg No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = " Car ID"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CarIDDataGridViewTextBoxColumn, Me.PlateNoDataGridViewTextBoxColumn, Me.CarNameDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.SeatsDataGridViewTextBoxColumn, Me.EngineNoDataGridViewTextBoxColumn, Me.RegNoDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.ListOfCarsBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(22, 159)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(670, 169)
        Me.DataGridView2.TabIndex = 0
        '
        'CarIDDataGridViewTextBoxColumn
        '
        Me.CarIDDataGridViewTextBoxColumn.DataPropertyName = "Car_ID"
        Me.CarIDDataGridViewTextBoxColumn.HeaderText = "Car_ID"
        Me.CarIDDataGridViewTextBoxColumn.Name = "CarIDDataGridViewTextBoxColumn"
        '
        'PlateNoDataGridViewTextBoxColumn
        '
        Me.PlateNoDataGridViewTextBoxColumn.DataPropertyName = "Plate_No"
        Me.PlateNoDataGridViewTextBoxColumn.HeaderText = "Plate_No"
        Me.PlateNoDataGridViewTextBoxColumn.Name = "PlateNoDataGridViewTextBoxColumn"
        '
        'CarNameDataGridViewTextBoxColumn
        '
        Me.CarNameDataGridViewTextBoxColumn.DataPropertyName = "Car_Name"
        Me.CarNameDataGridViewTextBoxColumn.HeaderText = "Car_Name"
        Me.CarNameDataGridViewTextBoxColumn.Name = "CarNameDataGridViewTextBoxColumn"
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
        'EngineNoDataGridViewTextBoxColumn
        '
        Me.EngineNoDataGridViewTextBoxColumn.DataPropertyName = "Engine_No"
        Me.EngineNoDataGridViewTextBoxColumn.HeaderText = "Engine_No"
        Me.EngineNoDataGridViewTextBoxColumn.Name = "EngineNoDataGridViewTextBoxColumn"
        '
        'RegNoDataGridViewTextBoxColumn
        '
        Me.RegNoDataGridViewTextBoxColumn.DataPropertyName = "Reg_No"
        Me.RegNoDataGridViewTextBoxColumn.HeaderText = "Reg_No"
        Me.RegNoDataGridViewTextBoxColumn.Name = "RegNoDataGridViewTextBoxColumn"
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'ListOfCarsTableAdapter
        '
        Me.ListOfCarsTableAdapter.ClearBeforeFill = True
        '
        'AdminTableAdapter1
        '
        Me.AdminTableAdapter1.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 407)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administration Panel"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarRentalSystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents cmdHome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCars As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdUsers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents txtuserid As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboUsers As System.Windows.Forms.ComboBox
    Friend WithEvents CarRentalSystemDataSet As Car_Rental_system.CarRentalSystemDataSet
    Friend WithEvents AdminTableAdapter As Car_Rental_system.CarRentalSystemDataSetTableAdapters.AdminTableAdapter
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthenticationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDelete_car As System.Windows.Forms.Button
    Friend WithEvents cmdSave_car As System.Windows.Forms.Button
    Friend WithEvents cmdAdd_car As System.Windows.Forms.Button
    Friend WithEvents txtCar_color As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEngine_no As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtMake As System.Windows.Forms.TextBox
    Friend WithEvents txtReg_no As System.Windows.Forms.TextBox
    Friend WithEvents txtCar_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSeats As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CarRentalSystemDataSet1 As Car_Rental_system.CarRentalSystemDataSet
    Friend WithEvents ListOfCarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfCarsTableAdapter As Car_Rental_system.CarRentalSystemDataSetTableAdapters.ListOfCarsTableAdapter
    Friend WithEvents CarIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlateNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeatsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EngineNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminTableAdapter1 As Car_Rental_system.CarRentalSystemDataSetTableAdapters.AdminTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPlate_No As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
