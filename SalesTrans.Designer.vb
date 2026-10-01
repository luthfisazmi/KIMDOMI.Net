<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesTrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesTrans))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LSellNum = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LCustName = New System.Windows.Forms.Label()
        Me.LPhone = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LAdmin = New System.Windows.Forms.Label()
        Me.LHours = New System.Windows.Forms.Label()
        Me.LDate = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LChange = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LProdName = New System.Windows.Forms.Label()
        Me.LPrice = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LItem = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LBrand = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selling Number"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer ID"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phone Number"
        '
        'LSellNum
        '
        Me.LSellNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LSellNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSellNum.Location = New System.Drawing.Point(179, 41)
        Me.LSellNum.Name = "LSellNum"
        Me.LSellNum.Size = New System.Drawing.Size(273, 33)
        Me.LSellNum.TabIndex = 4
        Me.LSellNum.Text = "LSellNum"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(179, 77)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(245, 28)
        Me.ComboBox1.TabIndex = 5
        '
        'LCustName
        '
        Me.LCustName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCustName.Location = New System.Drawing.Point(179, 108)
        Me.LCustName.Name = "LCustName"
        Me.LCustName.Size = New System.Drawing.Size(273, 33)
        Me.LCustName.TabIndex = 6
        Me.LCustName.Text = "LCustName"
        '
        'LPhone
        '
        Me.LPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPhone.Location = New System.Drawing.Point(179, 140)
        Me.LPhone.Name = "LPhone"
        Me.LPhone.Size = New System.Drawing.Size(273, 33)
        Me.LPhone.TabIndex = 7
        Me.LPhone.Text = "LPhone"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.LPhone)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LCustName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LSellNum)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 216)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Transaction"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LAdmin)
        Me.GroupBox2.Controls.Add(Me.LHours)
        Me.GroupBox2.Controls.Add(Me.LDate)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(550, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 151)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'LAdmin
        '
        Me.LAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAdmin.Location = New System.Drawing.Point(139, 95)
        Me.LAdmin.Name = "LAdmin"
        Me.LAdmin.Size = New System.Drawing.Size(241, 33)
        Me.LAdmin.TabIndex = 11
        Me.LAdmin.Text = "LAdmin"
        '
        'LHours
        '
        Me.LHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHours.Location = New System.Drawing.Point(139, 64)
        Me.LHours.Name = "LHours"
        Me.LHours.Size = New System.Drawing.Size(241, 33)
        Me.LHours.TabIndex = 10
        Me.LHours.Text = "LHours"
        '
        'LDate
        '
        Me.LDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDate.Location = New System.Drawing.Point(139, 31)
        Me.LDate.Name = "LDate"
        Me.LDate.Size = New System.Drawing.Size(241, 33)
        Me.LDate.TabIndex = 10
        Me.LDate.Text = "LDate"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 33)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Admin"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 33)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Hours"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(550, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 45)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Total : Rp."
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(697, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(258, 45)
        Me.Label9.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MediumVioletRed
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 415)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(818, 197)
        Me.DataGridView1.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(548, 639)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 33)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Paid        :"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(548, 672)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 33)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Change   :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(650, 637)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 27)
        Me.TextBox1.TabIndex = 15
        '
        'LChange
        '
        Me.LChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LChange.Location = New System.Drawing.Point(650, 670)
        Me.LChange.Name = "LChange"
        Me.LChange.Size = New System.Drawing.Size(196, 33)
        Me.LChange.TabIndex = 16
        Me.LChange.Text = "LChange"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aquamarine
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(863, 452)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 47)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumVioletRed
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(863, 525)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 47)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkMagenta
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(863, 593)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 47)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 333)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 33)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Product ID"
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(390, 333)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 33)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Name"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(390, 366)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 33)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Price"
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(763, 328)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 33)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Amount"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(135, 334)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(219, 27)
        Me.TextBox2.TabIndex = 24
        '
        'LProdName
        '
        Me.LProdName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProdName.Location = New System.Drawing.Point(495, 333)
        Me.LProdName.Name = "LProdName"
        Me.LProdName.Size = New System.Drawing.Size(231, 33)
        Me.LProdName.TabIndex = 25
        Me.LProdName.Text = "Name"
        '
        'LPrice
        '
        Me.LPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrice.Location = New System.Drawing.Point(495, 366)
        Me.LPrice.Name = "LPrice"
        Me.LPrice.Size = New System.Drawing.Size(231, 33)
        Me.LPrice.TabIndex = 26
        Me.LPrice.Text = "Price"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(763, 364)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(83, 27)
        Me.TextBox3.TabIndex = 27
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.HotPink
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(863, 387)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 47)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Insert"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(333, 639)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 33)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Item"
        '
        'LItem
        '
        Me.LItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LItem.Location = New System.Drawing.Point(429, 639)
        Me.LItem.Name = "LItem"
        Me.LItem.Size = New System.Drawing.Size(90, 33)
        Me.LItem.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 366)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 33)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Brand"
        '
        'LBrand
        '
        Me.LBrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBrand.Location = New System.Drawing.Point(135, 366)
        Me.LBrand.Name = "LBrand"
        Me.LBrand.Size = New System.Drawing.Size(219, 33)
        Me.LBrand.TabIndex = 32
        Me.LBrand.Text = "Brand"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe Print", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(161, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(598, 58)
        Me.Label18.TabIndex = 72
        Me.Label18.Text = "Kim DO-MI Customer Transaction"
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(863, 338)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 73
        '
        'SalesTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = Global.Aplikasi_KIMDOMI.My.Resources.Resources.Kim_DO_Mi__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(983, 724)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.LBrand)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LItem)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LPrice)
        Me.Controls.Add(Me.LProdName)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LChange)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "SalesTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Transaction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LSellNum As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LCustName As Label
    Friend WithEvents LPhone As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LAdmin As Label
    Friend WithEvents LHours As Label
    Friend WithEvents LDate As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LChange As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LProdName As Label
    Friend WithEvents LPrice As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents LItem As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents LBrand As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
End Class
