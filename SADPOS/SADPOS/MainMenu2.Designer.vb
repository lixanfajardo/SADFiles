<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu2
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
        Dim Animation35 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim CustomLabel25 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel26 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel27 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title9 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Animation36 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation33 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu2))
        Dim Animation34 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.logoTransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.header_panel = New System.Windows.Forms.Panel()
        Me.date_label = New System.Windows.Forms.Label()
        Me.clock_label = New System.Windows.Forms.Label()
        Me.menu_panel = New System.Windows.Forms.Panel()
        Me.customerOptions_panel = New System.Windows.Forms.Panel()
        Me.editCustomer_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.addCustomer_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.viewCustomer_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator8 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator7 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.logout_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.settings_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.reports_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.inventory_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator6 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.customer_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.purchaseOrders_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.sales_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.sales_panel = New System.Windows.Forms.Panel()
        Me.change_txt = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.cash_txt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.charge_rdo = New System.Windows.Forms.RadioButton()
        Me.cash_rdo = New System.Windows.Forms.RadioButton()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.add_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.salesSelectItems_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.salesSelectCustomer_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.salesCustomerName_txt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.checkout_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.total_price_txt = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.item_id_txt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.item_name_txt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.quantity_txt = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.item_dg = New System.Windows.Forms.DataGridView()
        Me.item_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salesItem_panel = New System.Windows.Forms.Panel()
        Me.BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton26 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.salesItem_dg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salesCustomer_panel = New System.Windows.Forms.Panel()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.salesCustomer_dg = New System.Windows.Forms.DataGridView()
        Me.salesCustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salesCustomer_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salesCustomer_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salesCustomer_contactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salesCustomer_gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.viewCustomer_panel = New System.Windows.Forms.Panel()
        Me.customerCharge_txt = New System.Windows.Forms.RadioButton()
        Me.customerCash_txt = New System.Windows.Forms.RadioButton()
        Me.customerPurchases_dg = New System.Windows.Forms.DataGridView()
        Me.vcustomer_datePurchased = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vcustomer_itemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vcustomer_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vcustomer_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.viewCustomerContactNumber_txt = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.viewCustomerAddress_txt = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.viewCustomerName_txt = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.viewCustomerSearch_txt = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.inventory_panel = New System.Windows.Forms.Panel()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.inventoryItemList_dg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inventoryPOs_dg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inventoryPurchaseStatus_cbo = New Bunifu.Framework.UI.BunifuDropdown()
        Me.deliver_panel = New System.Windows.Forms.Panel()
        Me.inventoryLost_txt = New System.Windows.Forms.NumericUpDown()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.inventoryDamaged_txt = New System.Windows.Forms.NumericUpDown()
        Me.inventorySubmit_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.inventoryDate_txt = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inventorySearch_txt = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inventoryItems_dg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockIn_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.inventorySetDeliver_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.stocks_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.inventoryView_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.inventoryGraph_panel = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.reports_panel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.repEndDate_dt = New System.Windows.Forms.DateTimePicker()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.repStartDate_dt = New System.Windows.Forms.DateTimePicker()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.BunifuThinButton211 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.BunifuThinButton215 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.settings_panel = New System.Windows.Forms.Panel()
        Me.userSettings_panel = New System.Windows.Forms.Panel()
        Me.viewUser_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.updateUser_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.addNewUser_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton27 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.BunifuThinButton28 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.items_panel = New System.Windows.Forms.Panel()
        Me.viewItem_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.updateItem_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.addNewItem_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.suppliers_panel = New System.Windows.Forms.Panel()
        Me.view_supplier_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.add_supplier_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.update_supplier_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.settings_lbl = New System.Windows.Forms.Label()
        Me.users_panel = New System.Windows.Forms.Panel()
        Me.searchbox_txt = New Bunifu.Framework.UI.BunifuTextbox()
        Me.userConfirmPassword_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.userPassword_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.userUsername_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.userPosition_cb = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.userGender_cb = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userLname_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.userMname_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.userFname_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.users_label = New System.Windows.Forms.Label()
        Me.submitUpdateUsers_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.submitNewUser_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.usersback_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.usersCancel_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.supplier_panel = New System.Windows.Forms.Panel()
        Me.supp_address_txt = New System.Windows.Forms.RichTextBox()
        Me.supp_search_txt = New Bunifu.Framework.UI.BunifuTextbox()
        Me.supp_contactNo_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.supp_contactPerson_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.supp_companyName_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.supplier_lbl = New System.Windows.Forms.Label()
        Me.supp_update_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.supp_back_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.supp_cancel_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.supp_submit_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.item_panel = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.items_price_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.itemCategories_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.itemSelectDescription_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.itemsQuantity_txt = New System.Windows.Forms.NumericUpDown()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.items_description_txt = New System.Windows.Forms.RichTextBox()
        Me.itemSearch_txt = New Bunifu.Framework.UI.BunifuTextbox()
        Me.items_category_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.items_name_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.item_lbl = New System.Windows.Forms.Label()
        Me.item_cancel_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.itemsBack_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.submitItem_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.itemsDescription_panel = New System.Windows.Forms.Panel()
        Me.cancelDescription_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.selectDescription_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.itemsDescription_dg = New System.Windows.Forms.DataGridView()
        Me.description_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description_txt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemCategory_panel = New System.Windows.Forms.Panel()
        Me.cancelCategory_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.selectCategory_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.itemCategory_dg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.submitItemUpdate_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.customer_panel = New System.Windows.Forms.Panel()
        Me.customer_search_txt = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuSearchEngine1 = New Bunifu.Framework.UI.BunifuSearchEngine()
        Me.customerCancel_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.customerContactNumber_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.customerAddress_txt = New System.Windows.Forms.RichTextBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.customerGender_cbo = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.customerLname_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.customerMname_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.customerFname_txt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cust_fnameTxt = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.customer_lbl = New System.Windows.Forms.Label()
        Me.customerUpdate_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.customerSubmit_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.purchaseOrder_panel = New System.Windows.Forms.Panel()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.cancelPO_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.selectItem_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.selectSupplier_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.supp_name_txt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.submitPO_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.POitem_ID_txt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.POitem_name_txt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.POitem_quantity_txt = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.POlist_dg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POlist_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POselectSupp_panel = New System.Windows.Forms.Panel()
        Me.POcancelSelectsupp_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.POselectSupp_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.POsupplier_dg = New System.Windows.Forms.DataGridView()
        Me.POsupp_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POsupp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POsupp_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POsupp_contactPerson = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POsupp_contactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POselectItems_panel = New System.Windows.Forms.Panel()
        Me.POcancelSelectItem_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.POselectItem_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.POitems_dg = New System.Windows.Forms.DataGridView()
        Me.POitem_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POitem_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POdescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POcategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POitemQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPanelTransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.customerOptionsTransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.timeOFday_timer = New System.Windows.Forms.Timer(Me.components)
        Me.delivery_transition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.header_panel.SuspendLayout()
        Me.menu_panel.SuspendLayout()
        Me.customerOptions_panel.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sales_panel.SuspendLayout()
        CType(Me.quantity_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.salesItem_panel.SuspendLayout()
        CType(Me.salesItem_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.salesCustomer_panel.SuspendLayout()
        CType(Me.salesCustomer_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.viewCustomer_panel.SuspendLayout()
        CType(Me.customerPurchases_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inventory_panel.SuspendLayout()
        CType(Me.inventoryItemList_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryPOs_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.deliver_panel.SuspendLayout()
        CType(Me.inventoryLost_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryDamaged_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryItems_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inventoryGraph_panel.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.reports_panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settings_panel.SuspendLayout()
        Me.userSettings_panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.items_panel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.suppliers_panel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.users_panel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.supplier_panel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.item_panel.SuspendLayout()
        CType(Me.itemsQuantity_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.itemsDescription_panel.SuspendLayout()
        CType(Me.itemsDescription_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.itemCategory_panel.SuspendLayout()
        CType(Me.itemCategory_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.customer_panel.SuspendLayout()
        Me.purchaseOrder_panel.SuspendLayout()
        CType(Me.POitem_quantity_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POlist_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.POselectSupp_panel.SuspendLayout()
        CType(Me.POsupplier_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.POselectItems_panel.SuspendLayout()
        CType(Me.POitems_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 25
        Me.BunifuElipse1.TargetControl = Me
        '
        'logoTransition
        '
        Me.logoTransition.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic
        Me.logoTransition.Cursor = Nothing
        Animation35.AnimateOnlyDifferences = True
        Animation35.BlindCoeff = CType(resources.GetObject("Animation35.BlindCoeff"), System.Drawing.PointF)
        Animation35.LeafCoeff = 0.0!
        Animation35.MaxTime = 1.0!
        Animation35.MinTime = 0.0!
        Animation35.MosaicCoeff = CType(resources.GetObject("Animation35.MosaicCoeff"), System.Drawing.PointF)
        Animation35.MosaicShift = CType(resources.GetObject("Animation35.MosaicShift"), System.Drawing.PointF)
        Animation35.MosaicSize = 20
        Animation35.Padding = New System.Windows.Forms.Padding(30)
        Animation35.RotateCoeff = 0.0!
        Animation35.RotateLimit = 0.0!
        Animation35.ScaleCoeff = CType(resources.GetObject("Animation35.ScaleCoeff"), System.Drawing.PointF)
        Animation35.SlideCoeff = CType(resources.GetObject("Animation35.SlideCoeff"), System.Drawing.PointF)
        Animation35.TimeCoeff = 0.0!
        Animation35.TransparencyCoeff = 0.0!
        Me.logoTransition.DefaultAnimation = Animation35
        '
        'header_panel
        '
        Me.header_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.header_panel.Controls.Add(Me.date_label)
        Me.header_panel.Controls.Add(Me.clock_label)
        Me.delivery_transition.SetDecoration(Me.header_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.header_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.header_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.header_panel, BunifuAnimatorNS.DecorationType.None)
        Me.header_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.header_panel.Location = New System.Drawing.Point(0, 0)
        Me.header_panel.Name = "header_panel"
        Me.header_panel.Size = New System.Drawing.Size(1366, 39)
        Me.header_panel.TabIndex = 1
        '
        'date_label
        '
        Me.date_label.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.date_label, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.date_label, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.date_label, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.date_label, BunifuAnimatorNS.DecorationType.None)
        Me.date_label.Font = New System.Drawing.Font("Monaco", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_label.Location = New System.Drawing.Point(716, 9)
        Me.date_label.Name = "date_label"
        Me.date_label.Size = New System.Drawing.Size(109, 20)
        Me.date_label.TabIndex = 7
        Me.date_label.Text = "Date_Label"
        '
        'clock_label
        '
        Me.clock_label.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.clock_label, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.clock_label, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.clock_label, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.clock_label, BunifuAnimatorNS.DecorationType.None)
        Me.clock_label.Font = New System.Drawing.Font("DS-Digital", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clock_label.Location = New System.Drawing.Point(592, 9)
        Me.clock_label.Name = "clock_label"
        Me.clock_label.Size = New System.Drawing.Size(118, 19)
        Me.clock_label.TabIndex = 6
        Me.clock_label.Text = "Clock_Label"
        '
        'menu_panel
        '
        Me.menu_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.menu_panel.Controls.Add(Me.customerOptions_panel)
        Me.menu_panel.Controls.Add(Me.BunifuSeparator8)
        Me.menu_panel.Controls.Add(Me.BunifuSeparator7)
        Me.menu_panel.Controls.Add(Me.logout_btn)
        Me.menu_panel.Controls.Add(Me.BunifuSeparator5)
        Me.menu_panel.Controls.Add(Me.settings_btn)
        Me.menu_panel.Controls.Add(Me.BunifuSeparator4)
        Me.menu_panel.Controls.Add(Me.reports_btn)
        Me.menu_panel.Controls.Add(Me.inventory_btn)
        Me.menu_panel.Controls.Add(Me.BunifuSeparator6)
        Me.menu_panel.Controls.Add(Me.customer_btn)
        Me.menu_panel.Controls.Add(Me.BunifuSeparator3)
        Me.menu_panel.Controls.Add(Me.BunifuSeparator2)
        Me.menu_panel.Controls.Add(Me.BunifuSeparator1)
        Me.menu_panel.Controls.Add(Me.purchaseOrders_btn)
        Me.menu_panel.Controls.Add(Me.sales_btn)
        Me.menu_panel.Controls.Add(Me.logo)
        Me.menu_panel.Controls.Add(Me.BunifuImageButton1)
        Me.delivery_transition.SetDecoration(Me.menu_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.menu_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.menu_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.menu_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menu_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.menu_panel.Location = New System.Drawing.Point(0, 39)
        Me.menu_panel.Name = "menu_panel"
        Me.menu_panel.Size = New System.Drawing.Size(53, 729)
        Me.menu_panel.TabIndex = 0
        '
        'customerOptions_panel
        '
        Me.customerOptions_panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.customerOptions_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.customerOptions_panel.Controls.Add(Me.editCustomer_btn)
        Me.customerOptions_panel.Controls.Add(Me.addCustomer_btn)
        Me.customerOptions_panel.Controls.Add(Me.viewCustomer_btn)
        Me.delivery_transition.SetDecoration(Me.customerOptions_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customerOptions_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customerOptions_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.customerOptions_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptions_panel.Location = New System.Drawing.Point(-101, 325)
        Me.customerOptions_panel.Name = "customerOptions_panel"
        Me.customerOptions_panel.Size = New System.Drawing.Size(257, 0)
        Me.customerOptions_panel.TabIndex = 1
        Me.customerOptions_panel.Visible = False
        '
        'editCustomer_btn
        '
        Me.editCustomer_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.editCustomer_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.editCustomer_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.editCustomer_btn.BorderRadius = 0
        Me.editCustomer_btn.ButtonText = "EDIT CUSTOMER DETAILS"
        Me.editCustomer_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.editCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.editCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.editCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.editCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.editCustomer_btn.DisabledColor = System.Drawing.Color.Gray
        Me.editCustomer_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.editCustomer_btn.Iconimage = Nothing
        Me.editCustomer_btn.Iconimage_right = Nothing
        Me.editCustomer_btn.Iconimage_right_Selected = Nothing
        Me.editCustomer_btn.Iconimage_Selected = Nothing
        Me.editCustomer_btn.IconMarginLeft = 0
        Me.editCustomer_btn.IconMarginRight = 0
        Me.editCustomer_btn.IconRightVisible = True
        Me.editCustomer_btn.IconRightZoom = 0.0R
        Me.editCustomer_btn.IconVisible = True
        Me.editCustomer_btn.IconZoom = 70.0R
        Me.editCustomer_btn.IsTab = False
        Me.editCustomer_btn.Location = New System.Drawing.Point(0, 48)
        Me.editCustomer_btn.Name = "editCustomer_btn"
        Me.editCustomer_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.editCustomer_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.editCustomer_btn.OnHoverTextColor = System.Drawing.Color.White
        Me.editCustomer_btn.selected = False
        Me.editCustomer_btn.Size = New System.Drawing.Size(257, 48)
        Me.editCustomer_btn.TabIndex = 15
        Me.editCustomer_btn.Text = "EDIT CUSTOMER DETAILS"
        Me.editCustomer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.editCustomer_btn.Textcolor = System.Drawing.Color.White
        Me.editCustomer_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'addCustomer_btn
        '
        Me.addCustomer_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.addCustomer_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.addCustomer_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addCustomer_btn.BorderRadius = 0
        Me.addCustomer_btn.ButtonText = "ADD CUSTOMER DETAILS"
        Me.addCustomer_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.addCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.addCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.addCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.addCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.addCustomer_btn.DisabledColor = System.Drawing.Color.Gray
        Me.addCustomer_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.addCustomer_btn.Iconimage = Nothing
        Me.addCustomer_btn.Iconimage_right = Nothing
        Me.addCustomer_btn.Iconimage_right_Selected = Nothing
        Me.addCustomer_btn.Iconimage_Selected = Nothing
        Me.addCustomer_btn.IconMarginLeft = 0
        Me.addCustomer_btn.IconMarginRight = 0
        Me.addCustomer_btn.IconRightVisible = True
        Me.addCustomer_btn.IconRightZoom = 0.0R
        Me.addCustomer_btn.IconVisible = True
        Me.addCustomer_btn.IconZoom = 70.0R
        Me.addCustomer_btn.IsTab = False
        Me.addCustomer_btn.Location = New System.Drawing.Point(0, 1)
        Me.addCustomer_btn.Name = "addCustomer_btn"
        Me.addCustomer_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.addCustomer_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.addCustomer_btn.OnHoverTextColor = System.Drawing.Color.White
        Me.addCustomer_btn.selected = False
        Me.addCustomer_btn.Size = New System.Drawing.Size(257, 48)
        Me.addCustomer_btn.TabIndex = 14
        Me.addCustomer_btn.Text = "ADD CUSTOMER DETAILS"
        Me.addCustomer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addCustomer_btn.Textcolor = System.Drawing.Color.White
        Me.addCustomer_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'viewCustomer_btn
        '
        Me.viewCustomer_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.viewCustomer_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.viewCustomer_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.viewCustomer_btn.BorderRadius = 0
        Me.viewCustomer_btn.ButtonText = "VIEW CUSTOMER DETAILS"
        Me.viewCustomer_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.viewCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.viewCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.viewCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.viewCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.viewCustomer_btn.DisabledColor = System.Drawing.Color.Gray
        Me.viewCustomer_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.viewCustomer_btn.Iconimage = Nothing
        Me.viewCustomer_btn.Iconimage_right = Nothing
        Me.viewCustomer_btn.Iconimage_right_Selected = Nothing
        Me.viewCustomer_btn.Iconimage_Selected = Nothing
        Me.viewCustomer_btn.IconMarginLeft = 0
        Me.viewCustomer_btn.IconMarginRight = 0
        Me.viewCustomer_btn.IconRightVisible = True
        Me.viewCustomer_btn.IconRightZoom = 0.0R
        Me.viewCustomer_btn.IconVisible = True
        Me.viewCustomer_btn.IconZoom = 70.0R
        Me.viewCustomer_btn.IsTab = False
        Me.viewCustomer_btn.Location = New System.Drawing.Point(0, 95)
        Me.viewCustomer_btn.Name = "viewCustomer_btn"
        Me.viewCustomer_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.viewCustomer_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.viewCustomer_btn.OnHoverTextColor = System.Drawing.Color.White
        Me.viewCustomer_btn.selected = False
        Me.viewCustomer_btn.Size = New System.Drawing.Size(257, 48)
        Me.viewCustomer_btn.TabIndex = 16
        Me.viewCustomer_btn.Text = "VIEW CUSTOMER DETAILS"
        Me.viewCustomer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.viewCustomer_btn.Textcolor = System.Drawing.Color.White
        Me.viewCustomer_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator8
        '
        Me.BunifuSeparator8.BackColor = System.Drawing.Color.Transparent
        Me.delivery_transition.SetDecoration(Me.BunifuSeparator8, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuSeparator8, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuSeparator8, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.BunifuSeparator8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BunifuSeparator8.LineThickness = 1
        Me.BunifuSeparator8.Location = New System.Drawing.Point(0, 524)
        Me.BunifuSeparator8.Name = "BunifuSeparator8"
        Me.BunifuSeparator8.Size = New System.Drawing.Size(257, 1)
        Me.BunifuSeparator8.TabIndex = 23
        Me.BunifuSeparator8.Transparency = 255
        Me.BunifuSeparator8.Vertical = False
        '
        'BunifuSeparator7
        '
        Me.BunifuSeparator7.BackColor = System.Drawing.Color.Transparent
        Me.delivery_transition.SetDecoration(Me.BunifuSeparator7, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuSeparator7, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuSeparator7, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.BunifuSeparator7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BunifuSeparator7.LineThickness = 1
        Me.BunifuSeparator7.Location = New System.Drawing.Point(0, 474)
        Me.BunifuSeparator7.Name = "BunifuSeparator7"
        Me.BunifuSeparator7.Size = New System.Drawing.Size(257, 1)
        Me.BunifuSeparator7.TabIndex = 21
        Me.BunifuSeparator7.Transparency = 255
        Me.BunifuSeparator7.Vertical = False
        '
        'logout_btn
        '
        Me.logout_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.logout_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logout_btn.BorderRadius = 0
        Me.logout_btn.ButtonText = "        LOG OUT"
        Me.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.logout_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.logout_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.logout_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.logout_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logout_btn.DisabledColor = System.Drawing.Color.Gray
        Me.logout_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.logout_btn.Iconimage = CType(resources.GetObject("logout_btn.Iconimage"), System.Drawing.Image)
        Me.logout_btn.Iconimage_right = Nothing
        Me.logout_btn.Iconimage_right_Selected = Nothing
        Me.logout_btn.Iconimage_Selected = Nothing
        Me.logout_btn.IconMarginLeft = 0
        Me.logout_btn.IconMarginRight = 0
        Me.logout_btn.IconRightVisible = True
        Me.logout_btn.IconRightZoom = 0.0R
        Me.logout_btn.IconVisible = True
        Me.logout_btn.IconZoom = 70.0R
        Me.logout_btn.IsTab = False
        Me.logout_btn.Location = New System.Drawing.Point(0, 474)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.logout_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.logout_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.logout_btn.selected = False
        Me.logout_btn.Size = New System.Drawing.Size(257, 50)
        Me.logout_btn.TabIndex = 22
        Me.logout_btn.Text = "        LOG OUT"
        Me.logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logout_btn.Textcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.logout_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.delivery_transition.SetDecoration(Me.BunifuSeparator5, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuSeparator5, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuSeparator5, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.BunifuSeparator5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 1
        Me.BunifuSeparator5.Location = New System.Drawing.Point(3, 424)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(257, 1)
        Me.BunifuSeparator5.TabIndex = 19
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'settings_btn
        '
        Me.settings_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.settings_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.settings_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.settings_btn.BorderRadius = 0
        Me.settings_btn.ButtonText = "        SETTINGS"
        Me.settings_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.settings_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.settings_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.settings_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.settings_btn, BunifuAnimatorNS.DecorationType.None)
        Me.settings_btn.DisabledColor = System.Drawing.Color.Gray
        Me.settings_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.settings_btn.Iconimage = CType(resources.GetObject("settings_btn.Iconimage"), System.Drawing.Image)
        Me.settings_btn.Iconimage_right = Nothing
        Me.settings_btn.Iconimage_right_Selected = Nothing
        Me.settings_btn.Iconimage_Selected = Nothing
        Me.settings_btn.IconMarginLeft = 0
        Me.settings_btn.IconMarginRight = 0
        Me.settings_btn.IconRightVisible = True
        Me.settings_btn.IconRightZoom = 0.0R
        Me.settings_btn.IconVisible = True
        Me.settings_btn.IconZoom = 70.0R
        Me.settings_btn.IsTab = False
        Me.settings_btn.Location = New System.Drawing.Point(0, 424)
        Me.settings_btn.Name = "settings_btn"
        Me.settings_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.settings_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.settings_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.settings_btn.selected = False
        Me.settings_btn.Size = New System.Drawing.Size(257, 50)
        Me.settings_btn.TabIndex = 20
        Me.settings_btn.Text = "        SETTINGS"
        Me.settings_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settings_btn.Textcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.settings_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.delivery_transition.SetDecoration(Me.BunifuSeparator4, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuSeparator4, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuSeparator4, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.BunifuSeparator4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 1
        Me.BunifuSeparator4.Location = New System.Drawing.Point(0, 374)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(257, 1)
        Me.BunifuSeparator4.TabIndex = 18
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'reports_btn
        '
        Me.reports_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.reports_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.reports_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.reports_btn.BorderRadius = 0
        Me.reports_btn.ButtonText = "        REPORTS"
        Me.reports_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.reports_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.reports_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.reports_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.reports_btn, BunifuAnimatorNS.DecorationType.None)
        Me.reports_btn.DisabledColor = System.Drawing.Color.Gray
        Me.reports_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.reports_btn.Iconimage = CType(resources.GetObject("reports_btn.Iconimage"), System.Drawing.Image)
        Me.reports_btn.Iconimage_right = Nothing
        Me.reports_btn.Iconimage_right_Selected = Nothing
        Me.reports_btn.Iconimage_Selected = Nothing
        Me.reports_btn.IconMarginLeft = 0
        Me.reports_btn.IconMarginRight = 0
        Me.reports_btn.IconRightVisible = True
        Me.reports_btn.IconRightZoom = 0.0R
        Me.reports_btn.IconVisible = True
        Me.reports_btn.IconZoom = 70.0R
        Me.reports_btn.IsTab = False
        Me.reports_btn.Location = New System.Drawing.Point(0, 374)
        Me.reports_btn.Name = "reports_btn"
        Me.reports_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.reports_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.reports_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.reports_btn.selected = False
        Me.reports_btn.Size = New System.Drawing.Size(257, 50)
        Me.reports_btn.TabIndex = 17
        Me.reports_btn.Text = "        REPORTS"
        Me.reports_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.reports_btn.Textcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.reports_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'inventory_btn
        '
        Me.inventory_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.inventory_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.inventory_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inventory_btn.BorderRadius = 0
        Me.inventory_btn.ButtonText = "        INVENTORY"
        Me.inventory_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.inventory_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.inventory_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventory_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.inventory_btn, BunifuAnimatorNS.DecorationType.None)
        Me.inventory_btn.DisabledColor = System.Drawing.Color.Gray
        Me.inventory_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.inventory_btn.Iconimage = CType(resources.GetObject("inventory_btn.Iconimage"), System.Drawing.Image)
        Me.inventory_btn.Iconimage_right = Nothing
        Me.inventory_btn.Iconimage_right_Selected = Nothing
        Me.inventory_btn.Iconimage_Selected = Nothing
        Me.inventory_btn.IconMarginLeft = 0
        Me.inventory_btn.IconMarginRight = 0
        Me.inventory_btn.IconRightVisible = True
        Me.inventory_btn.IconRightZoom = 0.0R
        Me.inventory_btn.IconVisible = True
        Me.inventory_btn.IconZoom = 70.0R
        Me.inventory_btn.IsTab = False
        Me.inventory_btn.Location = New System.Drawing.Point(0, 324)
        Me.inventory_btn.Name = "inventory_btn"
        Me.inventory_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.inventory_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.inventory_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.inventory_btn.selected = False
        Me.inventory_btn.Size = New System.Drawing.Size(257, 50)
        Me.inventory_btn.TabIndex = 16
        Me.inventory_btn.Text = "        INVENTORY"
        Me.inventory_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.inventory_btn.Textcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.inventory_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator6
        '
        Me.BunifuSeparator6.BackColor = System.Drawing.Color.Transparent
        Me.delivery_transition.SetDecoration(Me.BunifuSeparator6, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuSeparator6, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuSeparator6, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.BunifuSeparator6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BunifuSeparator6.LineThickness = 1
        Me.BunifuSeparator6.Location = New System.Drawing.Point(0, 322)
        Me.BunifuSeparator6.Name = "BunifuSeparator6"
        Me.BunifuSeparator6.Size = New System.Drawing.Size(257, 1)
        Me.BunifuSeparator6.TabIndex = 14
        Me.BunifuSeparator6.Transparency = 255
        Me.BunifuSeparator6.Vertical = False
        '
        'customer_btn
        '
        Me.customer_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.customer_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.customer_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.customer_btn.BorderRadius = 0
        Me.customer_btn.ButtonText = "        CUSTOMERS"
        Me.customer_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.customer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.customer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customer_btn.DisabledColor = System.Drawing.Color.Gray
        Me.customer_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.customer_btn.Iconimage = CType(resources.GetObject("customer_btn.Iconimage"), System.Drawing.Image)
        Me.customer_btn.Iconimage_right = Nothing
        Me.customer_btn.Iconimage_right_Selected = Nothing
        Me.customer_btn.Iconimage_Selected = Nothing
        Me.customer_btn.IconMarginLeft = 0
        Me.customer_btn.IconMarginRight = 0
        Me.customer_btn.IconRightVisible = True
        Me.customer_btn.IconRightZoom = 0.0R
        Me.customer_btn.IconVisible = True
        Me.customer_btn.IconZoom = 70.0R
        Me.customer_btn.IsTab = False
        Me.customer_btn.Location = New System.Drawing.Point(0, 272)
        Me.customer_btn.Name = "customer_btn"
        Me.customer_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.customer_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.customer_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.customer_btn.selected = False
        Me.customer_btn.Size = New System.Drawing.Size(257, 50)
        Me.customer_btn.TabIndex = 11
        Me.customer_btn.Text = "        CUSTOMERS"
        Me.customer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.customer_btn.Textcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.customer_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.delivery_transition.SetDecoration(Me.BunifuSeparator3, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuSeparator3, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuSeparator3, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.BunifuSeparator3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(0, 320)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(257, 1)
        Me.BunifuSeparator3.TabIndex = 8
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.delivery_transition.SetDecoration(Me.BunifuSeparator2, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuSeparator2, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuSeparator2, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.BunifuSeparator2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(0, 269)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(257, 1)
        Me.BunifuSeparator2.TabIndex = 7
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.delivery_transition.SetDecoration(Me.BunifuSeparator1, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuSeparator1, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuSeparator1, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.BunifuSeparator1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 216)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(257, 1)
        Me.BunifuSeparator1.TabIndex = 6
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'purchaseOrders_btn
        '
        Me.purchaseOrders_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.purchaseOrders_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.purchaseOrders_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.purchaseOrders_btn.BorderRadius = 0
        Me.purchaseOrders_btn.ButtonText = "        PURCHASE ORDERS"
        Me.purchaseOrders_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.purchaseOrders_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.purchaseOrders_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.purchaseOrders_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.purchaseOrders_btn, BunifuAnimatorNS.DecorationType.None)
        Me.purchaseOrders_btn.DisabledColor = System.Drawing.Color.Gray
        Me.purchaseOrders_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.purchaseOrders_btn.Iconimage = CType(resources.GetObject("purchaseOrders_btn.Iconimage"), System.Drawing.Image)
        Me.purchaseOrders_btn.Iconimage_right = Nothing
        Me.purchaseOrders_btn.Iconimage_right_Selected = Nothing
        Me.purchaseOrders_btn.Iconimage_Selected = Nothing
        Me.purchaseOrders_btn.IconMarginLeft = 0
        Me.purchaseOrders_btn.IconMarginRight = 0
        Me.purchaseOrders_btn.IconRightVisible = True
        Me.purchaseOrders_btn.IconRightZoom = 0.0R
        Me.purchaseOrders_btn.IconVisible = True
        Me.purchaseOrders_btn.IconZoom = 70.0R
        Me.purchaseOrders_btn.IsTab = False
        Me.purchaseOrders_btn.Location = New System.Drawing.Point(0, 218)
        Me.purchaseOrders_btn.Name = "purchaseOrders_btn"
        Me.purchaseOrders_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.purchaseOrders_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.purchaseOrders_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.purchaseOrders_btn.selected = False
        Me.purchaseOrders_btn.Size = New System.Drawing.Size(257, 50)
        Me.purchaseOrders_btn.TabIndex = 4
        Me.purchaseOrders_btn.Text = "        PURCHASE ORDERS"
        Me.purchaseOrders_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.purchaseOrders_btn.Textcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.purchaseOrders_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'sales_btn
        '
        Me.sales_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.sales_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.sales_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sales_btn.BorderRadius = 0
        Me.sales_btn.ButtonText = "        SALES"
        Me.sales_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.sales_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.sales_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.sales_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.sales_btn, BunifuAnimatorNS.DecorationType.None)
        Me.sales_btn.DisabledColor = System.Drawing.Color.Gray
        Me.sales_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.sales_btn.Iconimage = CType(resources.GetObject("sales_btn.Iconimage"), System.Drawing.Image)
        Me.sales_btn.Iconimage_right = Nothing
        Me.sales_btn.Iconimage_right_Selected = Nothing
        Me.sales_btn.Iconimage_Selected = Nothing
        Me.sales_btn.IconMarginLeft = 0
        Me.sales_btn.IconMarginRight = 0
        Me.sales_btn.IconRightVisible = True
        Me.sales_btn.IconRightZoom = 0.0R
        Me.sales_btn.IconVisible = True
        Me.sales_btn.IconZoom = 70.0R
        Me.sales_btn.IsTab = False
        Me.sales_btn.Location = New System.Drawing.Point(0, 166)
        Me.sales_btn.Name = "sales_btn"
        Me.sales_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.sales_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.sales_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.sales_btn.selected = False
        Me.sales_btn.Size = New System.Drawing.Size(257, 50)
        Me.sales_btn.TabIndex = 3
        Me.sales_btn.Text = "        SALES"
        Me.sales_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sales_btn.Textcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.sales_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'logo
        '
        Me.customerOptionsTransition.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(0, 45)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(257, 90)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.logo.TabIndex = 2
        Me.logo.TabStop = False
        Me.logo.Visible = False
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.delivery_transition.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(53, 39)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.delivery_transition.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(53, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1313, 729)
        Me.Panel2.TabIndex = 2
        '
        'sales_panel
        '
        Me.sales_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.sales_panel.Controls.Add(Me.change_txt)
        Me.sales_panel.Controls.Add(Me.Label53)
        Me.sales_panel.Controls.Add(Me.Label51)
        Me.sales_panel.Controls.Add(Me.cash_txt)
        Me.sales_panel.Controls.Add(Me.charge_rdo)
        Me.sales_panel.Controls.Add(Me.cash_rdo)
        Me.sales_panel.Controls.Add(Me.Label47)
        Me.sales_panel.Controls.Add(Me.add_btn)
        Me.sales_panel.Controls.Add(Me.salesSelectItems_btn)
        Me.sales_panel.Controls.Add(Me.salesSelectCustomer_btn)
        Me.sales_panel.Controls.Add(Me.salesCustomerName_txt)
        Me.sales_panel.Controls.Add(Me.Label18)
        Me.sales_panel.Controls.Add(Me.checkout_btn)
        Me.sales_panel.Controls.Add(Me.total_price_txt)
        Me.sales_panel.Controls.Add(Me.Label17)
        Me.sales_panel.Controls.Add(Me.item_id_txt)
        Me.sales_panel.Controls.Add(Me.item_name_txt)
        Me.sales_panel.Controls.Add(Me.quantity_txt)
        Me.sales_panel.Controls.Add(Me.Label16)
        Me.sales_panel.Controls.Add(Me.Label15)
        Me.sales_panel.Controls.Add(Me.Label14)
        Me.sales_panel.Controls.Add(Me.item_dg)
        Me.sales_panel.Controls.Add(Me.salesItem_panel)
        Me.sales_panel.Controls.Add(Me.salesCustomer_panel)
        Me.delivery_transition.SetDecoration(Me.sales_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.sales_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.sales_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.sales_panel, BunifuAnimatorNS.DecorationType.None)
        Me.sales_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sales_panel.Location = New System.Drawing.Point(53, 39)
        Me.sales_panel.Name = "sales_panel"
        Me.sales_panel.Size = New System.Drawing.Size(1313, 729)
        Me.sales_panel.TabIndex = 3
        '
        'change_txt
        '
        Me.change_txt.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.change_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.change_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.change_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.change_txt, BunifuAnimatorNS.DecorationType.None)
        Me.change_txt.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_txt.Location = New System.Drawing.Point(1145, 502)
        Me.change_txt.Name = "change_txt"
        Me.change_txt.Size = New System.Drawing.Size(72, 44)
        Me.change_txt.TabIndex = 23
        Me.change_txt.Text = "0.0"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label53, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label53, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label53, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label53, BunifuAnimatorNS.DecorationType.None)
        Me.Label53.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(1077, 486)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(75, 21)
        Me.Label53.TabIndex = 22
        Me.Label53.Text = "Change"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label51, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label51, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label51, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label51, BunifuAnimatorNS.DecorationType.None)
        Me.Label51.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(821, 374)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(50, 21)
        Me.Label51.TabIndex = 21
        Me.Label51.Text = "Cash"
        '
        'cash_txt
        '
        Me.cash_txt.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cash_txt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.cash_txt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cash_txt.BorderThickness = 2
        Me.cash_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.customerOptionsTransition.SetDecoration(Me.cash_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.cash_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.cash_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.cash_txt, BunifuAnimatorNS.DecorationType.None)
        Me.cash_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cash_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.cash_txt.isPassword = False
        Me.cash_txt.Location = New System.Drawing.Point(822, 406)
        Me.cash_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.cash_txt.Name = "cash_txt"
        Me.cash_txt.Size = New System.Drawing.Size(136, 44)
        Me.cash_txt.TabIndex = 20
        Me.cash_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'charge_rdo
        '
        Me.charge_rdo.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.charge_rdo, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.charge_rdo, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.charge_rdo, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.charge_rdo, BunifuAnimatorNS.DecorationType.None)
        Me.charge_rdo.Location = New System.Drawing.Point(897, 344)
        Me.charge_rdo.Name = "charge_rdo"
        Me.charge_rdo.Size = New System.Drawing.Size(59, 17)
        Me.charge_rdo.TabIndex = 19
        Me.charge_rdo.Text = "Charge"
        Me.charge_rdo.UseVisualStyleBackColor = True
        '
        'cash_rdo
        '
        Me.cash_rdo.AutoSize = True
        Me.cash_rdo.Checked = True
        Me.customerOptionsTransition.SetDecoration(Me.cash_rdo, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.cash_rdo, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.cash_rdo, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.cash_rdo, BunifuAnimatorNS.DecorationType.None)
        Me.cash_rdo.Location = New System.Drawing.Point(822, 344)
        Me.cash_rdo.Name = "cash_rdo"
        Me.cash_rdo.Size = New System.Drawing.Size(49, 17)
        Me.cash_rdo.TabIndex = 18
        Me.cash_rdo.TabStop = True
        Me.cash_rdo.Text = "Cash"
        Me.cash_rdo.UseVisualStyleBackColor = True
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label47, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label47, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label47, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label47, BunifuAnimatorNS.DecorationType.None)
        Me.Label47.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(20, 32)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(102, 42)
        Me.Label47.TabIndex = 17
        Me.Label47.Text = "Sales"
        '
        'add_btn
        '
        Me.add_btn.ActiveBorderThickness = 1
        Me.add_btn.ActiveCornerRadius = 20
        Me.add_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.add_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.add_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.add_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.add_btn.BackgroundImage = CType(resources.GetObject("add_btn.BackgroundImage"), System.Drawing.Image)
        Me.add_btn.ButtonText = "ADD"
        Me.add_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.add_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.add_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.add_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.add_btn, BunifuAnimatorNS.DecorationType.None)
        Me.add_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.add_btn.IdleBorderThickness = 1
        Me.add_btn.IdleCornerRadius = 20
        Me.add_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.add_btn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.add_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.add_btn.Location = New System.Drawing.Point(1153, 282)
        Me.add_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(103, 41)
        Me.add_btn.TabIndex = 14
        Me.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'salesSelectItems_btn
        '
        Me.salesSelectItems_btn.ActiveBorderThickness = 1
        Me.salesSelectItems_btn.ActiveCornerRadius = 20
        Me.salesSelectItems_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.salesSelectItems_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.salesSelectItems_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.salesSelectItems_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.salesSelectItems_btn.BackgroundImage = CType(resources.GetObject("salesSelectItems_btn.BackgroundImage"), System.Drawing.Image)
        Me.salesSelectItems_btn.ButtonText = "..."
        Me.salesSelectItems_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.salesSelectItems_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.salesSelectItems_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.salesSelectItems_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.salesSelectItems_btn, BunifuAnimatorNS.DecorationType.None)
        Me.salesSelectItems_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesSelectItems_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.salesSelectItems_btn.IdleBorderThickness = 1
        Me.salesSelectItems_btn.IdleCornerRadius = 20
        Me.salesSelectItems_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.salesSelectItems_btn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.salesSelectItems_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.salesSelectItems_btn.Location = New System.Drawing.Point(1190, 183)
        Me.salesSelectItems_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.salesSelectItems_btn.Name = "salesSelectItems_btn"
        Me.salesSelectItems_btn.Size = New System.Drawing.Size(66, 41)
        Me.salesSelectItems_btn.TabIndex = 13
        Me.salesSelectItems_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'salesSelectCustomer_btn
        '
        Me.salesSelectCustomer_btn.ActiveBorderThickness = 1
        Me.salesSelectCustomer_btn.ActiveCornerRadius = 20
        Me.salesSelectCustomer_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.salesSelectCustomer_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.salesSelectCustomer_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.salesSelectCustomer_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.salesSelectCustomer_btn.BackgroundImage = CType(resources.GetObject("salesSelectCustomer_btn.BackgroundImage"), System.Drawing.Image)
        Me.salesSelectCustomer_btn.ButtonText = "..."
        Me.salesSelectCustomer_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.salesSelectCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.salesSelectCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.salesSelectCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.salesSelectCustomer_btn, BunifuAnimatorNS.DecorationType.None)
        Me.salesSelectCustomer_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesSelectCustomer_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.salesSelectCustomer_btn.IdleBorderThickness = 1
        Me.salesSelectCustomer_btn.IdleCornerRadius = 20
        Me.salesSelectCustomer_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.salesSelectCustomer_btn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.salesSelectCustomer_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.salesSelectCustomer_btn.Location = New System.Drawing.Point(1190, 123)
        Me.salesSelectCustomer_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.salesSelectCustomer_btn.Name = "salesSelectCustomer_btn"
        Me.salesSelectCustomer_btn.Size = New System.Drawing.Size(66, 41)
        Me.salesSelectCustomer_btn.TabIndex = 12
        Me.salesSelectCustomer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'salesCustomerName_txt
        '
        Me.salesCustomerName_txt.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.salesCustomerName_txt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.salesCustomerName_txt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.salesCustomerName_txt.BorderThickness = 2
        Me.salesCustomerName_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.customerOptionsTransition.SetDecoration(Me.salesCustomerName_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.salesCustomerName_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.salesCustomerName_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.salesCustomerName_txt, BunifuAnimatorNS.DecorationType.None)
        Me.salesCustomerName_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.salesCustomerName_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.salesCustomerName_txt.isPassword = False
        Me.salesCustomerName_txt.Location = New System.Drawing.Point(963, 124)
        Me.salesCustomerName_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.salesCustomerName_txt.Name = "salesCustomerName_txt"
        Me.salesCustomerName_txt.Size = New System.Drawing.Size(218, 44)
        Me.salesCustomerName_txt.TabIndex = 11
        Me.salesCustomerName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label18, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label18, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label18, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label18, BunifuAnimatorNS.DecorationType.None)
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(818, 138)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(138, 21)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Customer Name"
        '
        'checkout_btn
        '
        Me.checkout_btn.ActiveBorderThickness = 1
        Me.checkout_btn.ActiveCornerRadius = 20
        Me.checkout_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.checkout_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.checkout_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.checkout_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.checkout_btn.BackgroundImage = CType(resources.GetObject("checkout_btn.BackgroundImage"), System.Drawing.Image)
        Me.checkout_btn.ButtonText = "Check Out"
        Me.checkout_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.checkout_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.checkout_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.checkout_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.checkout_btn, BunifuAnimatorNS.DecorationType.None)
        Me.checkout_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkout_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.checkout_btn.IdleBorderThickness = 1
        Me.checkout_btn.IdleCornerRadius = 20
        Me.checkout_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.checkout_btn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.checkout_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.checkout_btn.Location = New System.Drawing.Point(1075, 339)
        Me.checkout_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.checkout_btn.Name = "checkout_btn"
        Me.checkout_btn.Size = New System.Drawing.Size(181, 41)
        Me.checkout_btn.TabIndex = 9
        Me.checkout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'total_price_txt
        '
        Me.total_price_txt.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.total_price_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.total_price_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.total_price_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.total_price_txt, BunifuAnimatorNS.DecorationType.None)
        Me.total_price_txt.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_price_txt.Location = New System.Drawing.Point(1145, 424)
        Me.total_price_txt.Name = "total_price_txt"
        Me.total_price_txt.Size = New System.Drawing.Size(72, 44)
        Me.total_price_txt.TabIndex = 8
        Me.total_price_txt.Text = "0.0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label17, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label17, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label17, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label17, BunifuAnimatorNS.DecorationType.None)
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1077, 408)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 21)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Total"
        '
        'item_id_txt
        '
        Me.item_id_txt.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.item_id_txt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.item_id_txt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.item_id_txt.BorderThickness = 2
        Me.item_id_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.customerOptionsTransition.SetDecoration(Me.item_id_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.item_id_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.item_id_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.item_id_txt, BunifuAnimatorNS.DecorationType.None)
        Me.item_id_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.item_id_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.item_id_txt.isPassword = False
        Me.item_id_txt.Location = New System.Drawing.Point(963, 183)
        Me.item_id_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.item_id_txt.Name = "item_id_txt"
        Me.item_id_txt.Size = New System.Drawing.Size(218, 44)
        Me.item_id_txt.TabIndex = 6
        Me.item_id_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'item_name_txt
        '
        Me.item_name_txt.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.item_name_txt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.item_name_txt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.item_name_txt.BorderThickness = 2
        Me.item_name_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.customerOptionsTransition.SetDecoration(Me.item_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.item_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.item_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.item_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.item_name_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.item_name_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.item_name_txt.isPassword = False
        Me.item_name_txt.Location = New System.Drawing.Point(963, 235)
        Me.item_name_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.item_name_txt.Name = "item_name_txt"
        Me.item_name_txt.Size = New System.Drawing.Size(293, 44)
        Me.item_name_txt.TabIndex = 5
        Me.item_name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'quantity_txt
        '
        Me.quantity_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.delivery_transition.SetDecoration(Me.quantity_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.quantity_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.quantity_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.quantity_txt, BunifuAnimatorNS.DecorationType.None)
        Me.quantity_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.quantity_txt.Location = New System.Drawing.Point(963, 291)
        Me.quantity_txt.Name = "quantity_txt"
        Me.quantity_txt.Size = New System.Drawing.Size(70, 26)
        Me.quantity_txt.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label16, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label16, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label16, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label16, BunifuAnimatorNS.DecorationType.None)
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(818, 291)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 21)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Quantity"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(818, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 21)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Item Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label14, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label14, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label14, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label14, BunifuAnimatorNS.DecorationType.None)
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(818, 196)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 21)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Item ID"
        '
        'item_dg
        '
        Me.item_dg.AllowUserToAddRows = False
        Me.item_dg.AllowUserToDeleteRows = False
        Me.item_dg.AllowUserToResizeColumns = False
        Me.item_dg.AllowUserToResizeRows = False
        Me.item_dg.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.item_dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.item_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.item_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_id, Me.item_name, Me.item_description, Me.item_category, Me.item_price, Me.item_quantity})
        Me.menuPanelTransition.SetDecoration(Me.item_dg, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.item_dg, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.item_dg, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.item_dg, BunifuAnimatorNS.DecorationType.None)
        Me.item_dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.item_dg.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.item_dg.Location = New System.Drawing.Point(28, 107)
        Me.item_dg.MultiSelect = False
        Me.item_dg.Name = "item_dg"
        Me.item_dg.ReadOnly = True
        Me.item_dg.RowHeadersVisible = False
        Me.item_dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.item_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.item_dg.Size = New System.Drawing.Size(720, 345)
        Me.item_dg.TabIndex = 0
        '
        'item_id
        '
        Me.item_id.HeaderText = "Item ID"
        Me.item_id.Name = "item_id"
        Me.item_id.ReadOnly = True
        Me.item_id.Width = 120
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = True
        Me.item_name.Width = 120
        '
        'item_description
        '
        Me.item_description.HeaderText = "Description"
        Me.item_description.Name = "item_description"
        Me.item_description.ReadOnly = True
        Me.item_description.Width = 120
        '
        'item_category
        '
        Me.item_category.HeaderText = "Category"
        Me.item_category.Name = "item_category"
        Me.item_category.ReadOnly = True
        Me.item_category.Width = 120
        '
        'item_price
        '
        Me.item_price.HeaderText = "Price"
        Me.item_price.Name = "item_price"
        Me.item_price.ReadOnly = True
        Me.item_price.Width = 120
        '
        'item_quantity
        '
        Me.item_quantity.HeaderText = "Quantity"
        Me.item_quantity.Name = "item_quantity"
        Me.item_quantity.ReadOnly = True
        Me.item_quantity.Width = 120
        '
        'salesItem_panel
        '
        Me.salesItem_panel.Controls.Add(Me.BunifuThinButton25)
        Me.salesItem_panel.Controls.Add(Me.BunifuThinButton26)
        Me.salesItem_panel.Controls.Add(Me.salesItem_dg)
        Me.delivery_transition.SetDecoration(Me.salesItem_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.salesItem_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.salesItem_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.salesItem_panel, BunifuAnimatorNS.DecorationType.None)
        Me.salesItem_panel.Location = New System.Drawing.Point(27, 98)
        Me.salesItem_panel.Name = "salesItem_panel"
        Me.salesItem_panel.Size = New System.Drawing.Size(721, 354)
        Me.salesItem_panel.TabIndex = 16
        Me.salesItem_panel.Visible = False
        '
        'BunifuThinButton25
        '
        Me.BunifuThinButton25.ActiveBorderThickness = 1
        Me.BunifuThinButton25.ActiveCornerRadius = 20
        Me.BunifuThinButton25.ActiveFillColor = System.Drawing.Color.Red
        Me.BunifuThinButton25.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BunifuThinButton25.ActiveLineColor = System.Drawing.Color.Red
        Me.BunifuThinButton25.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton25.BackgroundImage = CType(resources.GetObject("BunifuThinButton25.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton25.ButtonText = "Cancel"
        Me.BunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.BunifuThinButton25, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuThinButton25, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuThinButton25, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuThinButton25, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton25.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.IdleBorderThickness = 1
        Me.BunifuThinButton25.IdleCornerRadius = 20
        Me.BunifuThinButton25.IdleFillColor = System.Drawing.Color.Red
        Me.BunifuThinButton25.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton25.IdleLineColor = System.Drawing.Color.Red
        Me.BunifuThinButton25.Location = New System.Drawing.Point(7, 293)
        Me.BunifuThinButton25.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton25.Name = "BunifuThinButton25"
        Me.BunifuThinButton25.Size = New System.Drawing.Size(118, 41)
        Me.BunifuThinButton25.TabIndex = 11
        Me.BunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton26
        '
        Me.BunifuThinButton26.ActiveBorderThickness = 1
        Me.BunifuThinButton26.ActiveCornerRadius = 20
        Me.BunifuThinButton26.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton26.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BunifuThinButton26.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton26.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton26.BackgroundImage = CType(resources.GetObject("BunifuThinButton26.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton26.ButtonText = "Select"
        Me.BunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.BunifuThinButton26, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuThinButton26, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuThinButton26, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuThinButton26, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton26.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton26.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.IdleBorderThickness = 1
        Me.BunifuThinButton26.IdleCornerRadius = 20
        Me.BunifuThinButton26.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuThinButton26.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BunifuThinButton26.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuThinButton26.Location = New System.Drawing.Point(598, 295)
        Me.BunifuThinButton26.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton26.Name = "BunifuThinButton26"
        Me.BunifuThinButton26.Size = New System.Drawing.Size(118, 41)
        Me.BunifuThinButton26.TabIndex = 10
        Me.BunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'salesItem_dg
        '
        Me.salesItem_dg.AllowUserToAddRows = False
        Me.salesItem_dg.AllowUserToDeleteRows = False
        Me.salesItem_dg.BackgroundColor = System.Drawing.Color.White
        Me.salesItem_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salesItem_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.Column1})
        Me.menuPanelTransition.SetDecoration(Me.salesItem_dg, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.salesItem_dg, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.salesItem_dg, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.salesItem_dg, BunifuAnimatorNS.DecorationType.None)
        Me.salesItem_dg.Location = New System.Drawing.Point(7, 9)
        Me.salesItem_dg.Name = "salesItem_dg"
        Me.salesItem_dg.ReadOnly = True
        Me.salesItem_dg.RowHeadersVisible = False
        Me.salesItem_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.salesItem_dg.Size = New System.Drawing.Size(710, 279)
        Me.salesItem_dg.TabIndex = 0
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Item ID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 120
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 120
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 120
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 120
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 120
        '
        'Column1
        '
        Me.Column1.HeaderText = "Quantity"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'salesCustomer_panel
        '
        Me.salesCustomer_panel.Controls.Add(Me.BunifuThinButton24)
        Me.salesCustomer_panel.Controls.Add(Me.BunifuThinButton21)
        Me.salesCustomer_panel.Controls.Add(Me.salesCustomer_dg)
        Me.delivery_transition.SetDecoration(Me.salesCustomer_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.salesCustomer_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.salesCustomer_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.salesCustomer_panel, BunifuAnimatorNS.DecorationType.None)
        Me.salesCustomer_panel.Location = New System.Drawing.Point(27, 98)
        Me.salesCustomer_panel.Name = "salesCustomer_panel"
        Me.salesCustomer_panel.Size = New System.Drawing.Size(721, 354)
        Me.salesCustomer_panel.TabIndex = 15
        Me.salesCustomer_panel.Visible = False
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.Red
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.Red
        Me.BunifuThinButton24.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton24.ButtonText = "Cancel"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.BunifuThinButton24, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuThinButton24, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuThinButton24, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuThinButton24, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.Red
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.Red
        Me.BunifuThinButton24.Location = New System.Drawing.Point(7, 293)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(118, 41)
        Me.BunifuThinButton24.TabIndex = 11
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Select"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(598, 295)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(118, 41)
        Me.BunifuThinButton21.TabIndex = 10
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'salesCustomer_dg
        '
        Me.salesCustomer_dg.AllowUserToAddRows = False
        Me.salesCustomer_dg.AllowUserToDeleteRows = False
        Me.salesCustomer_dg.BackgroundColor = System.Drawing.Color.White
        Me.salesCustomer_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salesCustomer_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.salesCustomerID, Me.salesCustomer_Name, Me.salesCustomer_address, Me.salesCustomer_contactNumber, Me.salesCustomer_gender})
        Me.menuPanelTransition.SetDecoration(Me.salesCustomer_dg, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.salesCustomer_dg, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.salesCustomer_dg, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.salesCustomer_dg, BunifuAnimatorNS.DecorationType.None)
        Me.salesCustomer_dg.Location = New System.Drawing.Point(7, 9)
        Me.salesCustomer_dg.Name = "salesCustomer_dg"
        Me.salesCustomer_dg.ReadOnly = True
        Me.salesCustomer_dg.RowHeadersVisible = False
        Me.salesCustomer_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.salesCustomer_dg.Size = New System.Drawing.Size(710, 279)
        Me.salesCustomer_dg.TabIndex = 0
        '
        'salesCustomerID
        '
        Me.salesCustomerID.HeaderText = "CustomerID"
        Me.salesCustomerID.Name = "salesCustomerID"
        Me.salesCustomerID.ReadOnly = True
        Me.salesCustomerID.Width = 144
        '
        'salesCustomer_Name
        '
        Me.salesCustomer_Name.HeaderText = "Customer Name"
        Me.salesCustomer_Name.Name = "salesCustomer_Name"
        Me.salesCustomer_Name.ReadOnly = True
        Me.salesCustomer_Name.Width = 144
        '
        'salesCustomer_address
        '
        Me.salesCustomer_address.HeaderText = "Address"
        Me.salesCustomer_address.Name = "salesCustomer_address"
        Me.salesCustomer_address.ReadOnly = True
        Me.salesCustomer_address.Width = 144
        '
        'salesCustomer_contactNumber
        '
        Me.salesCustomer_contactNumber.HeaderText = "Contact Number"
        Me.salesCustomer_contactNumber.Name = "salesCustomer_contactNumber"
        Me.salesCustomer_contactNumber.ReadOnly = True
        Me.salesCustomer_contactNumber.Width = 144
        '
        'salesCustomer_gender
        '
        Me.salesCustomer_gender.HeaderText = "Gender"
        Me.salesCustomer_gender.Name = "salesCustomer_gender"
        Me.salesCustomer_gender.ReadOnly = True
        Me.salesCustomer_gender.Width = 144
        '
        'viewCustomer_panel
        '
        Me.viewCustomer_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.viewCustomer_panel.Controls.Add(Me.customerCharge_txt)
        Me.viewCustomer_panel.Controls.Add(Me.customerCash_txt)
        Me.viewCustomer_panel.Controls.Add(Me.customerPurchases_dg)
        Me.viewCustomer_panel.Controls.Add(Me.viewCustomerContactNumber_txt)
        Me.viewCustomer_panel.Controls.Add(Me.Label41)
        Me.viewCustomer_panel.Controls.Add(Me.viewCustomerAddress_txt)
        Me.viewCustomer_panel.Controls.Add(Me.Label39)
        Me.viewCustomer_panel.Controls.Add(Me.Label38)
        Me.viewCustomer_panel.Controls.Add(Me.viewCustomerName_txt)
        Me.viewCustomer_panel.Controls.Add(Me.Label36)
        Me.viewCustomer_panel.Controls.Add(Me.Label35)
        Me.viewCustomer_panel.Controls.Add(Me.viewCustomerSearch_txt)
        Me.viewCustomer_panel.Controls.Add(Me.Label34)
        Me.delivery_transition.SetDecoration(Me.viewCustomer_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.viewCustomer_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.viewCustomer_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.viewCustomer_panel, BunifuAnimatorNS.DecorationType.None)
        Me.viewCustomer_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewCustomer_panel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.viewCustomer_panel.Location = New System.Drawing.Point(53, 39)
        Me.viewCustomer_panel.Name = "viewCustomer_panel"
        Me.viewCustomer_panel.Size = New System.Drawing.Size(1313, 729)
        Me.viewCustomer_panel.TabIndex = 4
        '
        'customerCharge_txt
        '
        Me.customerCharge_txt.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.customerCharge_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customerCharge_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customerCharge_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.customerCharge_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerCharge_txt.Location = New System.Drawing.Point(362, 420)
        Me.customerCharge_txt.Name = "customerCharge_txt"
        Me.customerCharge_txt.Size = New System.Drawing.Size(59, 17)
        Me.customerCharge_txt.TabIndex = 12
        Me.customerCharge_txt.TabStop = True
        Me.customerCharge_txt.Text = "Charge"
        Me.customerCharge_txt.UseVisualStyleBackColor = True
        '
        'customerCash_txt
        '
        Me.customerCash_txt.AutoSize = True
        Me.customerCash_txt.Checked = True
        Me.customerOptionsTransition.SetDecoration(Me.customerCash_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customerCash_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customerCash_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.customerCash_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerCash_txt.Location = New System.Drawing.Point(255, 420)
        Me.customerCash_txt.Name = "customerCash_txt"
        Me.customerCash_txt.Size = New System.Drawing.Size(49, 17)
        Me.customerCash_txt.TabIndex = 11
        Me.customerCash_txt.TabStop = True
        Me.customerCash_txt.Text = "Cash"
        Me.customerCash_txt.UseVisualStyleBackColor = True
        '
        'customerPurchases_dg
        '
        Me.customerPurchases_dg.AllowUserToAddRows = False
        Me.customerPurchases_dg.AllowUserToDeleteRows = False
        Me.customerPurchases_dg.AllowUserToResizeRows = False
        Me.customerPurchases_dg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.customerPurchases_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.customerPurchases_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vcustomer_datePurchased, Me.vcustomer_itemName, Me.vcustomer_price, Me.vcustomer_quantity})
        Me.menuPanelTransition.SetDecoration(Me.customerPurchases_dg, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customerPurchases_dg, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.customerPurchases_dg, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.customerPurchases_dg, BunifuAnimatorNS.DecorationType.None)
        Me.customerPurchases_dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.customerPurchases_dg.Location = New System.Drawing.Point(73, 458)
        Me.customerPurchases_dg.Name = "customerPurchases_dg"
        Me.customerPurchases_dg.ReadOnly = True
        Me.customerPurchases_dg.RowHeadersVisible = False
        Me.customerPurchases_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.customerPurchases_dg.Size = New System.Drawing.Size(810, 233)
        Me.customerPurchases_dg.TabIndex = 10
        '
        'vcustomer_datePurchased
        '
        Me.vcustomer_datePurchased.HeaderText = "Date Purchased"
        Me.vcustomer_datePurchased.Name = "vcustomer_datePurchased"
        Me.vcustomer_datePurchased.ReadOnly = True
        Me.vcustomer_datePurchased.Width = 202
        '
        'vcustomer_itemName
        '
        Me.vcustomer_itemName.HeaderText = "Item Name"
        Me.vcustomer_itemName.Name = "vcustomer_itemName"
        Me.vcustomer_itemName.ReadOnly = True
        Me.vcustomer_itemName.Width = 202
        '
        'vcustomer_price
        '
        Me.vcustomer_price.HeaderText = "Item Price"
        Me.vcustomer_price.Name = "vcustomer_price"
        Me.vcustomer_price.ReadOnly = True
        Me.vcustomer_price.Width = 202
        '
        'vcustomer_quantity
        '
        Me.vcustomer_quantity.HeaderText = "Quantity"
        Me.vcustomer_quantity.Name = "vcustomer_quantity"
        Me.vcustomer_quantity.ReadOnly = True
        Me.vcustomer_quantity.Width = 202
        '
        'viewCustomerContactNumber_txt
        '
        Me.viewCustomerContactNumber_txt.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.viewCustomerContactNumber_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.viewCustomerContactNumber_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.viewCustomerContactNumber_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.viewCustomerContactNumber_txt, BunifuAnimatorNS.DecorationType.None)
        Me.viewCustomerContactNumber_txt.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewCustomerContactNumber_txt.Location = New System.Drawing.Point(251, 336)
        Me.viewCustomerContactNumber_txt.Name = "viewCustomerContactNumber_txt"
        Me.viewCustomerContactNumber_txt.Size = New System.Drawing.Size(260, 22)
        Me.viewCustomerContactNumber_txt.TabIndex = 9
        Me.viewCustomerContactNumber_txt.Text = "Customer Contact Number"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label41, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label41, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label41, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label41, BunifuAnimatorNS.DecorationType.None)
        Me.Label41.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(69, 336)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(167, 22)
        Me.Label41.TabIndex = 8
        Me.Label41.Text = "Contact Number"
        '
        'viewCustomerAddress_txt
        '
        Me.viewCustomerAddress_txt.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.viewCustomerAddress_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.viewCustomerAddress_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.viewCustomerAddress_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.viewCustomerAddress_txt, BunifuAnimatorNS.DecorationType.None)
        Me.viewCustomerAddress_txt.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewCustomerAddress_txt.Location = New System.Drawing.Point(251, 286)
        Me.viewCustomerAddress_txt.Name = "viewCustomerAddress_txt"
        Me.viewCustomerAddress_txt.Size = New System.Drawing.Size(176, 22)
        Me.viewCustomerAddress_txt.TabIndex = 7
        Me.viewCustomerAddress_txt.Text = "Customer Address"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label39, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label39, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label39, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label39, BunifuAnimatorNS.DecorationType.None)
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(69, 286)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(83, 22)
        Me.Label39.TabIndex = 6
        Me.Label39.Text = "Address"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label38, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label38, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label38, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label38, BunifuAnimatorNS.DecorationType.None)
        Me.Label38.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(69, 420)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(159, 22)
        Me.Label38.TabIndex = 5
        Me.Label38.Text = "Purchase History"
        '
        'viewCustomerName_txt
        '
        Me.viewCustomerName_txt.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.viewCustomerName_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.viewCustomerName_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.viewCustomerName_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.viewCustomerName_txt, BunifuAnimatorNS.DecorationType.None)
        Me.viewCustomerName_txt.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewCustomerName_txt.Location = New System.Drawing.Point(251, 234)
        Me.viewCustomerName_txt.Name = "viewCustomerName_txt"
        Me.viewCustomerName_txt.Size = New System.Drawing.Size(159, 22)
        Me.viewCustomerName_txt.TabIndex = 4
        Me.viewCustomerName_txt.Text = "Customer Name"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label36, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label36, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label36, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label36, BunifuAnimatorNS.DecorationType.None)
        Me.Label36.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(69, 234)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(66, 22)
        Me.Label36.TabIndex = 3
        Me.Label36.Text = "Name"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label35, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label35, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label35, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label35, BunifuAnimatorNS.DecorationType.None)
        Me.Label35.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(69, 148)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(74, 22)
        Me.Label35.TabIndex = 2
        Me.Label35.Text = "Search"
        '
        'viewCustomerSearch_txt
        '
        Me.viewCustomerSearch_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.viewCustomerSearch_txt.BackgroundImage = CType(resources.GetObject("viewCustomerSearch_txt.BackgroundImage"), System.Drawing.Image)
        Me.viewCustomerSearch_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delivery_transition.SetDecoration(Me.viewCustomerSearch_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.viewCustomerSearch_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.viewCustomerSearch_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.viewCustomerSearch_txt, BunifuAnimatorNS.DecorationType.None)
        Me.viewCustomerSearch_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.viewCustomerSearch_txt.Icon = CType(resources.GetObject("viewCustomerSearch_txt.Icon"), System.Drawing.Image)
        Me.viewCustomerSearch_txt.Location = New System.Drawing.Point(149, 136)
        Me.viewCustomerSearch_txt.Name = "viewCustomerSearch_txt"
        Me.viewCustomerSearch_txt.Size = New System.Drawing.Size(363, 42)
        Me.viewCustomerSearch_txt.TabIndex = 1
        Me.viewCustomerSearch_txt.text = ""
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label34, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label34, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label34, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label34, BunifuAnimatorNS.DecorationType.None)
        Me.Label34.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(450, 56)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(502, 39)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "VIEW CUSTOMER INFORMATION"
        '
        'inventory_panel
        '
        Me.inventory_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.inventory_panel.Controls.Add(Me.Label49)
        Me.inventory_panel.Controls.Add(Me.inventoryItemList_dg)
        Me.inventory_panel.Controls.Add(Me.inventoryPOs_dg)
        Me.inventory_panel.Controls.Add(Me.inventoryPurchaseStatus_cbo)
        Me.inventory_panel.Controls.Add(Me.deliver_panel)
        Me.inventory_panel.Controls.Add(Me.inventoryDate_txt)
        Me.inventory_panel.Controls.Add(Me.Label4)
        Me.inventory_panel.Controls.Add(Me.inventorySearch_txt)
        Me.inventory_panel.Controls.Add(Me.Label1)
        Me.inventory_panel.Controls.Add(Me.inventoryItems_dg)
        Me.inventory_panel.Controls.Add(Me.inventoryView_btn)
        Me.inventory_panel.Controls.Add(Me.stocks_btn)
        Me.inventory_panel.Controls.Add(Me.BunifuFlatButton5)
        Me.inventory_panel.Controls.Add(Me.stockIn_btn)
        Me.inventory_panel.Controls.Add(Me.inventorySetDeliver_btn)
        Me.inventory_panel.Controls.Add(Me.ShapeContainer1)
        Me.inventory_panel.Controls.Add(Me.inventoryGraph_panel)
        Me.delivery_transition.SetDecoration(Me.inventory_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventory_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.inventory_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.inventory_panel, BunifuAnimatorNS.DecorationType.None)
        Me.inventory_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inventory_panel.Location = New System.Drawing.Point(53, 39)
        Me.inventory_panel.Name = "inventory_panel"
        Me.inventory_panel.Size = New System.Drawing.Size(1313, 729)
        Me.inventory_panel.TabIndex = 5
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label49, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label49, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label49, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label49, BunifuAnimatorNS.DecorationType.None)
        Me.Label49.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(50, 60)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(186, 44)
        Me.Label49.TabIndex = 18
        Me.Label49.Text = "Inventory"
        '
        'inventoryItemList_dg
        '
        Me.inventoryItemList_dg.AllowUserToAddRows = False
        Me.inventoryItemList_dg.AllowUserToDeleteRows = False
        Me.inventoryItemList_dg.AllowUserToResizeColumns = False
        Me.inventoryItemList_dg.AllowUserToResizeRows = False
        Me.inventoryItemList_dg.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.inventoryItemList_dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.inventoryItemList_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.inventoryItemList_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.Column2})
        Me.menuPanelTransition.SetDecoration(Me.inventoryItemList_dg, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventoryItemList_dg, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.inventoryItemList_dg, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.inventoryItemList_dg, BunifuAnimatorNS.DecorationType.None)
        Me.inventoryItemList_dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.inventoryItemList_dg.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.inventoryItemList_dg.Location = New System.Drawing.Point(58, 188)
        Me.inventoryItemList_dg.MultiSelect = False
        Me.inventoryItemList_dg.Name = "inventoryItemList_dg"
        Me.inventoryItemList_dg.ReadOnly = True
        Me.inventoryItemList_dg.RowHeadersVisible = False
        Me.inventoryItemList_dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.inventoryItemList_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.inventoryItemList_dg.Size = New System.Drawing.Size(714, 327)
        Me.inventoryItemList_dg.TabIndex = 16
        Me.inventoryItemList_dg.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "Item ID"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn22.Width = 142
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 142
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 142
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 142
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 142
        '
        'inventoryPOs_dg
        '
        Me.inventoryPOs_dg.AllowUserToAddRows = False
        Me.inventoryPOs_dg.AllowUserToDeleteRows = False
        Me.inventoryPOs_dg.AllowUserToResizeColumns = False
        Me.inventoryPOs_dg.AllowUserToResizeRows = False
        Me.inventoryPOs_dg.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.inventoryPOs_dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.inventoryPOs_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.inventoryPOs_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn12})
        Me.menuPanelTransition.SetDecoration(Me.inventoryPOs_dg, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventoryPOs_dg, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.inventoryPOs_dg, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.inventoryPOs_dg, BunifuAnimatorNS.DecorationType.None)
        Me.inventoryPOs_dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.inventoryPOs_dg.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.inventoryPOs_dg.Location = New System.Drawing.Point(58, 188)
        Me.inventoryPOs_dg.MultiSelect = False
        Me.inventoryPOs_dg.Name = "inventoryPOs_dg"
        Me.inventoryPOs_dg.ReadOnly = True
        Me.inventoryPOs_dg.RowHeadersVisible = False
        Me.inventoryPOs_dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.inventoryPOs_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.inventoryPOs_dg.Size = New System.Drawing.Size(714, 327)
        Me.inventoryPOs_dg.TabIndex = 2
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "P.O Number"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 178
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Supplier Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 178
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date Purchased"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 178
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 178
        '
        'inventoryPurchaseStatus_cbo
        '
        Me.inventoryPurchaseStatus_cbo.BackColor = System.Drawing.Color.Transparent
        Me.inventoryPurchaseStatus_cbo.BorderRadius = 3
        Me.customerOptionsTransition.SetDecoration(Me.inventoryPurchaseStatus_cbo, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventoryPurchaseStatus_cbo, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.inventoryPurchaseStatus_cbo, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.inventoryPurchaseStatus_cbo, BunifuAnimatorNS.DecorationType.None)
        Me.inventoryPurchaseStatus_cbo.DisabledColor = System.Drawing.Color.Gray
        Me.inventoryPurchaseStatus_cbo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.inventoryPurchaseStatus_cbo.Items = New String() {"TO DELIVER", "DELIVERED", "CANCELED"}
        Me.inventoryPurchaseStatus_cbo.Location = New System.Drawing.Point(871, 440)
        Me.inventoryPurchaseStatus_cbo.Name = "inventoryPurchaseStatus_cbo"
        Me.inventoryPurchaseStatus_cbo.NomalColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.inventoryPurchaseStatus_cbo.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.inventoryPurchaseStatus_cbo.selectedIndex = 0
        Me.inventoryPurchaseStatus_cbo.Size = New System.Drawing.Size(297, 35)
        Me.inventoryPurchaseStatus_cbo.TabIndex = 14
        '
        'deliver_panel
        '
        Me.deliver_panel.Controls.Add(Me.inventoryLost_txt)
        Me.deliver_panel.Controls.Add(Me.Label50)
        Me.deliver_panel.Controls.Add(Me.BunifuThinButton22)
        Me.deliver_panel.Controls.Add(Me.inventoryDamaged_txt)
        Me.deliver_panel.Controls.Add(Me.inventorySubmit_btn)
        Me.deliver_panel.Controls.Add(Me.Label31)
        Me.delivery_transition.SetDecoration(Me.deliver_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.deliver_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.deliver_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.deliver_panel, BunifuAnimatorNS.DecorationType.None)
        Me.deliver_panel.Location = New System.Drawing.Point(780, 286)
        Me.deliver_panel.Name = "deliver_panel"
        Me.deliver_panel.Size = New System.Drawing.Size(500, 135)
        Me.deliver_panel.TabIndex = 13
        Me.deliver_panel.Visible = False
        '
        'inventoryLost_txt
        '
        Me.delivery_transition.SetDecoration(Me.inventoryLost_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.inventoryLost_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventoryLost_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.inventoryLost_txt, BunifuAnimatorNS.DecorationType.None)
        Me.inventoryLost_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryLost_txt.Location = New System.Drawing.Point(92, 48)
        Me.inventoryLost_txt.Name = "inventoryLost_txt"
        Me.inventoryLost_txt.Size = New System.Drawing.Size(98, 26)
        Me.inventoryLost_txt.TabIndex = 20
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label50, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label50, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label50, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label50, BunifuAnimatorNS.DecorationType.None)
        Me.Label50.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label50.Location = New System.Drawing.Point(3, 53)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(37, 20)
        Me.Label50.TabIndex = 19
        Me.Label50.Text = "Lost"
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.DarkGray
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "CANCEL"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.BunifuThinButton22, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuThinButton22, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuThinButton22, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuThinButton22, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.Red
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(5, 89)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(133, 35)
        Me.BunifuThinButton22.TabIndex = 18
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'inventoryDamaged_txt
        '
        Me.delivery_transition.SetDecoration(Me.inventoryDamaged_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.inventoryDamaged_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventoryDamaged_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.inventoryDamaged_txt, BunifuAnimatorNS.DecorationType.None)
        Me.inventoryDamaged_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryDamaged_txt.Location = New System.Drawing.Point(92, 14)
        Me.inventoryDamaged_txt.Name = "inventoryDamaged_txt"
        Me.inventoryDamaged_txt.Size = New System.Drawing.Size(98, 26)
        Me.inventoryDamaged_txt.TabIndex = 17
        '
        'inventorySubmit_btn
        '
        Me.inventorySubmit_btn.ActiveBorderThickness = 1
        Me.inventorySubmit_btn.ActiveCornerRadius = 20
        Me.inventorySubmit_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.inventorySubmit_btn.ActiveForecolor = System.Drawing.Color.White
        Me.inventorySubmit_btn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.inventorySubmit_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.inventorySubmit_btn.BackgroundImage = CType(resources.GetObject("inventorySubmit_btn.BackgroundImage"), System.Drawing.Image)
        Me.inventorySubmit_btn.ButtonText = "SUBMIT"
        Me.inventorySubmit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.inventorySubmit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventorySubmit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.inventorySubmit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.inventorySubmit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.inventorySubmit_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventorySubmit_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.inventorySubmit_btn.IdleBorderThickness = 1
        Me.inventorySubmit_btn.IdleCornerRadius = 20
        Me.inventorySubmit_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.inventorySubmit_btn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.inventorySubmit_btn.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.inventorySubmit_btn.Location = New System.Drawing.Point(343, 89)
        Me.inventorySubmit_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.inventorySubmit_btn.Name = "inventorySubmit_btn"
        Me.inventorySubmit_btn.Size = New System.Drawing.Size(133, 35)
        Me.inventorySubmit_btn.TabIndex = 16
        Me.inventorySubmit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label31, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label31, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label31, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label31, BunifuAnimatorNS.DecorationType.None)
        Me.Label31.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(3, 19)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(83, 20)
        Me.Label31.TabIndex = 14
        Me.Label31.Text = "Damaged"
        '
        'inventoryDate_txt
        '
        Me.inventoryDate_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.inventoryDate_txt.BorderRadius = 0
        Me.delivery_transition.SetDecoration(Me.inventoryDate_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.inventoryDate_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventoryDate_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.inventoryDate_txt, BunifuAnimatorNS.DecorationType.None)
        Me.inventoryDate_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.inventoryDate_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.inventoryDate_txt.FormatCustom = "ddd, MMM/dd/yyyy"
        Me.inventoryDate_txt.Location = New System.Drawing.Point(871, 379)
        Me.inventoryDate_txt.Name = "inventoryDate_txt"
        Me.inventoryDate_txt.Size = New System.Drawing.Size(297, 36)
        Me.inventoryDate_txt.TabIndex = 12
        Me.inventoryDate_txt.Value = New Date(2017, 10, 4, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(806, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Date"
        '
        'inventorySearch_txt
        '
        Me.inventorySearch_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.inventorySearch_txt.BackgroundImage = CType(resources.GetObject("inventorySearch_txt.BackgroundImage"), System.Drawing.Image)
        Me.inventorySearch_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delivery_transition.SetDecoration(Me.inventorySearch_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.inventorySearch_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventorySearch_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.inventorySearch_txt, BunifuAnimatorNS.DecorationType.None)
        Me.inventorySearch_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.inventorySearch_txt.Icon = CType(resources.GetObject("inventorySearch_txt.Icon"), System.Drawing.Image)
        Me.inventorySearch_txt.Location = New System.Drawing.Point(871, 322)
        Me.inventorySearch_txt.Name = "inventorySearch_txt"
        Me.inventorySearch_txt.Size = New System.Drawing.Size(297, 38)
        Me.inventorySearch_txt.TabIndex = 10
        Me.inventorySearch_txt.text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(805, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Search"
        '
        'inventoryItems_dg
        '
        Me.inventoryItems_dg.AllowUserToAddRows = False
        Me.inventoryItems_dg.AllowUserToDeleteRows = False
        Me.inventoryItems_dg.AllowUserToResizeRows = False
        Me.inventoryItems_dg.BackgroundColor = System.Drawing.Color.White
        Me.inventoryItems_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.inventoryItems_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.menuPanelTransition.SetDecoration(Me.inventoryItems_dg, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventoryItems_dg, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.inventoryItems_dg, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.inventoryItems_dg, BunifuAnimatorNS.DecorationType.None)
        Me.inventoryItems_dg.Location = New System.Drawing.Point(58, 188)
        Me.inventoryItems_dg.Name = "inventoryItems_dg"
        Me.inventoryItems_dg.ReadOnly = True
        Me.inventoryItems_dg.RowHeadersVisible = False
        Me.inventoryItems_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.inventoryItems_dg.Size = New System.Drawing.Size(714, 327)
        Me.inventoryItems_dg.TabIndex = 8
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Item ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 144
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 144
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 144
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 144
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 144
        '
        'stockIn_btn
        '
        Me.stockIn_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.stockIn_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.stockIn_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.stockIn_btn.BorderRadius = 0
        Me.stockIn_btn.ButtonText = "                  Stock In"
        Me.stockIn_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.stockIn_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.stockIn_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.stockIn_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.stockIn_btn, BunifuAnimatorNS.DecorationType.None)
        Me.stockIn_btn.DisabledColor = System.Drawing.Color.Gray
        Me.stockIn_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.stockIn_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.stockIn_btn.Iconimage = CType(resources.GetObject("stockIn_btn.Iconimage"), System.Drawing.Image)
        Me.stockIn_btn.Iconimage_right = Nothing
        Me.stockIn_btn.Iconimage_right_Selected = Nothing
        Me.stockIn_btn.Iconimage_Selected = Nothing
        Me.stockIn_btn.IconMarginLeft = 0
        Me.stockIn_btn.IconMarginRight = 0
        Me.stockIn_btn.IconRightVisible = True
        Me.stockIn_btn.IconRightZoom = 0.0R
        Me.stockIn_btn.IconVisible = True
        Me.stockIn_btn.IconZoom = 70.0R
        Me.stockIn_btn.IsTab = False
        Me.stockIn_btn.Location = New System.Drawing.Point(780, 188)
        Me.stockIn_btn.Name = "stockIn_btn"
        Me.stockIn_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.stockIn_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.stockIn_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.stockIn_btn.selected = False
        Me.stockIn_btn.Size = New System.Drawing.Size(250, 48)
        Me.stockIn_btn.TabIndex = 3
        Me.stockIn_btn.Text = "                  Stock In"
        Me.stockIn_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stockIn_btn.Textcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.stockIn_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'inventorySetDeliver_btn
        '
        Me.inventorySetDeliver_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.inventorySetDeliver_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.inventorySetDeliver_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inventorySetDeliver_btn.BorderRadius = 0
        Me.inventorySetDeliver_btn.ButtonText = "Set As Delivered"
        Me.inventorySetDeliver_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.inventorySetDeliver_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.inventorySetDeliver_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventorySetDeliver_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.inventorySetDeliver_btn, BunifuAnimatorNS.DecorationType.None)
        Me.inventorySetDeliver_btn.DisabledColor = System.Drawing.Color.Gray
        Me.inventorySetDeliver_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.inventorySetDeliver_btn.Iconimage = CType(resources.GetObject("inventorySetDeliver_btn.Iconimage"), System.Drawing.Image)
        Me.inventorySetDeliver_btn.Iconimage_right = Nothing
        Me.inventorySetDeliver_btn.Iconimage_right_Selected = Nothing
        Me.inventorySetDeliver_btn.Iconimage_Selected = Nothing
        Me.inventorySetDeliver_btn.IconMarginLeft = 0
        Me.inventorySetDeliver_btn.IconMarginRight = 0
        Me.inventorySetDeliver_btn.IconRightVisible = True
        Me.inventorySetDeliver_btn.IconRightZoom = 0.0R
        Me.inventorySetDeliver_btn.IconVisible = True
        Me.inventorySetDeliver_btn.IconZoom = 45.0R
        Me.inventorySetDeliver_btn.IsTab = False
        Me.inventorySetDeliver_btn.Location = New System.Drawing.Point(780, 236)
        Me.inventorySetDeliver_btn.Name = "inventorySetDeliver_btn"
        Me.inventorySetDeliver_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.inventorySetDeliver_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.inventorySetDeliver_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.inventorySetDeliver_btn.selected = False
        Me.inventorySetDeliver_btn.Size = New System.Drawing.Size(166, 50)
        Me.inventorySetDeliver_btn.TabIndex = 5
        Me.inventorySetDeliver_btn.Text = "Set As Delivered"
        Me.inventorySetDeliver_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.inventorySetDeliver_btn.Textcolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.inventorySetDeliver_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'stocks_btn
        '
        Me.stocks_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.stocks_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.stocks_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.stocks_btn.BorderRadius = 0
        Me.stocks_btn.ButtonText = "                     Stocks"
        Me.stocks_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.stocks_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.stocks_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.stocks_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.stocks_btn, BunifuAnimatorNS.DecorationType.None)
        Me.stocks_btn.DisabledColor = System.Drawing.Color.Gray
        Me.stocks_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.stocks_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.stocks_btn.Iconimage = CType(resources.GetObject("stocks_btn.Iconimage"), System.Drawing.Image)
        Me.stocks_btn.Iconimage_right = Nothing
        Me.stocks_btn.Iconimage_right_Selected = Nothing
        Me.stocks_btn.Iconimage_Selected = Nothing
        Me.stocks_btn.IconMarginLeft = 0
        Me.stocks_btn.IconMarginRight = 0
        Me.stocks_btn.IconRightVisible = True
        Me.stocks_btn.IconRightZoom = 0.0R
        Me.stocks_btn.IconVisible = True
        Me.stocks_btn.IconZoom = 70.0R
        Me.stocks_btn.IsTab = False
        Me.stocks_btn.Location = New System.Drawing.Point(1030, 188)
        Me.stocks_btn.Name = "stocks_btn"
        Me.stocks_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.stocks_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.stocks_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.stocks_btn.selected = False
        Me.stocks_btn.Size = New System.Drawing.Size(250, 48)
        Me.stocks_btn.TabIndex = 4
        Me.stocks_btn.Text = "                     Stocks"
        Me.stocks_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stocks_btn.Textcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.stocks_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.Red
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "Cancel PO"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0.0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 90.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(1114, 236)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.Red
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(166, 50)
        Me.BunifuFlatButton5.TabIndex = 7
        Me.BunifuFlatButton5.Text = "Cancel PO"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'inventoryView_btn
        '
        Me.inventoryView_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.inventoryView_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.inventoryView_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inventoryView_btn.BorderRadius = 0
        Me.inventoryView_btn.ButtonText = "View PO Items"
        Me.inventoryView_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delivery_transition.SetDecoration(Me.inventoryView_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.inventoryView_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventoryView_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.inventoryView_btn, BunifuAnimatorNS.DecorationType.None)
        Me.inventoryView_btn.DisabledColor = System.Drawing.Color.Gray
        Me.inventoryView_btn.Enabled = False
        Me.inventoryView_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.inventoryView_btn.Iconimage = CType(resources.GetObject("inventoryView_btn.Iconimage"), System.Drawing.Image)
        Me.inventoryView_btn.Iconimage_right = Nothing
        Me.inventoryView_btn.Iconimage_right_Selected = Nothing
        Me.inventoryView_btn.Iconimage_Selected = Nothing
        Me.inventoryView_btn.IconMarginLeft = 0
        Me.inventoryView_btn.IconMarginRight = 0
        Me.inventoryView_btn.IconRightVisible = True
        Me.inventoryView_btn.IconRightZoom = 0.0R
        Me.inventoryView_btn.IconVisible = True
        Me.inventoryView_btn.IconZoom = 45.0R
        Me.inventoryView_btn.IsTab = False
        Me.inventoryView_btn.Location = New System.Drawing.Point(947, 236)
        Me.inventoryView_btn.Name = "inventoryView_btn"
        Me.inventoryView_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.inventoryView_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.inventoryView_btn.OnHoverTextColor = System.Drawing.Color.White
        Me.inventoryView_btn.selected = False
        Me.inventoryView_btn.Size = New System.Drawing.Size(166, 50)
        Me.inventoryView_btn.TabIndex = 6
        Me.inventoryView_btn.Text = "View PO Items"
        Me.inventoryView_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.inventoryView_btn.Textcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.inventoryView_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ShapeContainer1
        '
        Me.delivery_transition.SetDecoration(Me.ShapeContainer1, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.ShapeContainer1, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.ShapeContainer1, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.ShapeContainer1, BunifuAnimatorNS.DecorationType.None)
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1313, 729)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.RectangleShape1.Location = New System.Drawing.Point(776, 188)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(504, 326)
        '
        'inventoryGraph_panel
        '
        Me.inventoryGraph_panel.Controls.Add(Me.Chart1)
        Me.delivery_transition.SetDecoration(Me.inventoryGraph_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.inventoryGraph_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.inventoryGraph_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.inventoryGraph_panel, BunifuAnimatorNS.DecorationType.None)
        Me.inventoryGraph_panel.Location = New System.Drawing.Point(776, 237)
        Me.inventoryGraph_panel.Name = "inventoryGraph_panel"
        Me.inventoryGraph_panel.Size = New System.Drawing.Size(504, 278)
        Me.inventoryGraph_panel.TabIndex = 15
        Me.inventoryGraph_panel.Visible = False
        '
        'Chart1
        '
        CustomLabel25.ForeColor = System.Drawing.Color.Blue
        CustomLabel25.FromPosition = 200.0R
        CustomLabel25.Text = "High"
        CustomLabel26.ForeColor = System.Drawing.Color.Yellow
        CustomLabel26.FromPosition = 100.0R
        CustomLabel26.Text = "Medium"
        CustomLabel27.ForeColor = System.Drawing.Color.Red
        CustomLabel27.FromPosition = 30.0R
        CustomLabel27.Text = "Low"
        ChartArea9.AxisY.CustomLabels.Add(CustomLabel25)
        ChartArea9.AxisY.CustomLabels.Add(CustomLabel26)
        ChartArea9.AxisY.CustomLabels.Add(CustomLabel27)
        ChartArea9.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea9)
        Me.delivery_transition.SetDecoration(Me.Chart1, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Chart1, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Chart1, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.Chart1, BunifuAnimatorNS.DecorationType.None)
        Me.Chart1.Location = New System.Drawing.Point(4, 0)
        Me.Chart1.Name = "Chart1"
        Series9.ChartArea = "ChartArea1"
        Series9.Color = System.Drawing.Color.Blue
        Series9.Name = "Series1"
        Me.Chart1.Series.Add(Series9)
        Me.Chart1.Size = New System.Drawing.Size(500, 275)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title9.Name = "Title1"
        Title9.Text = "Item Status"
        Me.Chart1.Titles.Add(Title9)
        '
        'reports_panel
        '
        Me.reports_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.reports_panel.Controls.Add(Me.Panel1)
        Me.reports_panel.Controls.Add(Me.Label45)
        Me.reports_panel.Controls.Add(Me.Panel4)
        Me.delivery_transition.SetDecoration(Me.reports_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.reports_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.reports_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.reports_panel, BunifuAnimatorNS.DecorationType.None)
        Me.reports_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reports_panel.Location = New System.Drawing.Point(53, 39)
        Me.reports_panel.Name = "reports_panel"
        Me.reports_panel.Size = New System.Drawing.Size(1313, 729)
        Me.reports_panel.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.repEndDate_dt)
        Me.Panel1.Controls.Add(Me.Label43)
        Me.Panel1.Controls.Add(Me.repStartDate_dt)
        Me.Panel1.Controls.Add(Me.Label46)
        Me.Panel1.Controls.Add(Me.BunifuThinButton211)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.Label42)
        Me.delivery_transition.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(375, 205)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 260)
        Me.Panel1.TabIndex = 4
        '
        'repEndDate_dt
        '
        Me.customerOptionsTransition.SetDecoration(Me.repEndDate_dt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.repEndDate_dt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.repEndDate_dt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.repEndDate_dt, BunifuAnimatorNS.DecorationType.None)
        Me.repEndDate_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.repEndDate_dt.Location = New System.Drawing.Point(42, 156)
        Me.repEndDate_dt.Name = "repEndDate_dt"
        Me.repEndDate_dt.Size = New System.Drawing.Size(196, 20)
        Me.repEndDate_dt.TabIndex = 8
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label43, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label43, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label43, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label43, BunifuAnimatorNS.DecorationType.None)
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(38, 129)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(27, 20)
        Me.Label43.TabIndex = 7
        Me.Label43.Text = "To"
        '
        'repStartDate_dt
        '
        Me.customerOptionsTransition.SetDecoration(Me.repStartDate_dt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.repStartDate_dt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.repStartDate_dt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.repStartDate_dt, BunifuAnimatorNS.DecorationType.None)
        Me.repStartDate_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.repStartDate_dt.Location = New System.Drawing.Point(42, 102)
        Me.repStartDate_dt.Name = "repStartDate_dt"
        Me.repStartDate_dt.Size = New System.Drawing.Size(196, 20)
        Me.repStartDate_dt.TabIndex = 6
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label46, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label46, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label46, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label46, BunifuAnimatorNS.DecorationType.None)
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(38, 73)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(46, 20)
        Me.Label46.TabIndex = 5
        Me.Label46.Text = "From"
        '
        'BunifuThinButton211
        '
        Me.BunifuThinButton211.ActiveBorderThickness = 1
        Me.BunifuThinButton211.ActiveCornerRadius = 20
        Me.BunifuThinButton211.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton211.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BunifuThinButton211.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuThinButton211.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton211.BackgroundImage = CType(resources.GetObject("BunifuThinButton211.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton211.ButtonText = "Generate Sales Report"
        Me.BunifuThinButton211.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.BunifuThinButton211, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuThinButton211, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuThinButton211, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuThinButton211, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton211.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton211.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton211.IdleBorderThickness = 1
        Me.BunifuThinButton211.IdleCornerRadius = 20
        Me.BunifuThinButton211.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuThinButton211.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton211.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton211.Location = New System.Drawing.Point(35, 189)
        Me.BunifuThinButton211.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton211.Name = "BunifuThinButton211"
        Me.BunifuThinButton211.Size = New System.Drawing.Size(203, 47)
        Me.BunifuThinButton211.TabIndex = 0
        Me.BunifuThinButton211.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox8
        '
        Me.customerOptionsTransition.SetDecoration(Me.PictureBox8, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.PictureBox8, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.PictureBox8, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.PictureBox8, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(12, 17)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 1
        Me.PictureBox8.TabStop = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label42, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label42, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label42, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label42, BunifuAnimatorNS.DecorationType.None)
        Me.Label42.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(58, 25)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(169, 32)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "SALES REPORT"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label45, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label45, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label45, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label45, BunifuAnimatorNS.DecorationType.None)
        Me.Label45.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(520, 52)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(306, 50)
        Me.Label45.TabIndex = 7
        Me.Label45.Text = "Generate Reports"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label44)
        Me.Panel4.Controls.Add(Me.PictureBox10)
        Me.Panel4.Controls.Add(Me.BunifuThinButton215)
        Me.delivery_transition.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(691, 205)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(290, 260)
        Me.Panel4.TabIndex = 6
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label44, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label44, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label44, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label44, BunifuAnimatorNS.DecorationType.None)
        Me.Label44.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(65, 24)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(207, 30)
        Me.Label44.TabIndex = 6
        Me.Label44.Text = "INVENTORY REPORT"
        '
        'PictureBox10
        '
        Me.customerOptionsTransition.SetDecoration(Me.PictureBox10, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.PictureBox10, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.PictureBox10, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.PictureBox10, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(19, 16)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 7
        Me.PictureBox10.TabStop = False
        '
        'BunifuThinButton215
        '
        Me.BunifuThinButton215.ActiveBorderThickness = 1
        Me.BunifuThinButton215.ActiveCornerRadius = 20
        Me.BunifuThinButton215.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton215.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BunifuThinButton215.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuThinButton215.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton215.BackgroundImage = CType(resources.GetObject("BunifuThinButton215.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton215.ButtonText = "Generate Inventory Report"
        Me.BunifuThinButton215.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.BunifuThinButton215, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuThinButton215, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuThinButton215, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuThinButton215, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton215.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton215.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton215.IdleBorderThickness = 1
        Me.BunifuThinButton215.IdleCornerRadius = 20
        Me.BunifuThinButton215.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuThinButton215.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton215.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton215.Location = New System.Drawing.Point(47, 120)
        Me.BunifuThinButton215.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton215.Name = "BunifuThinButton215"
        Me.BunifuThinButton215.Size = New System.Drawing.Size(203, 56)
        Me.BunifuThinButton215.TabIndex = 5
        Me.BunifuThinButton215.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'settings_panel
        '
        Me.settings_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.settings_panel.Controls.Add(Me.userSettings_panel)
        Me.settings_panel.Controls.Add(Me.Panel5)
        Me.settings_panel.Controls.Add(Me.items_panel)
        Me.settings_panel.Controls.Add(Me.suppliers_panel)
        Me.settings_panel.Controls.Add(Me.settings_lbl)
        Me.settings_panel.Controls.Add(Me.users_panel)
        Me.settings_panel.Controls.Add(Me.supplier_panel)
        Me.settings_panel.Controls.Add(Me.item_panel)
        Me.delivery_transition.SetDecoration(Me.settings_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.settings_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.settings_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.settings_panel, BunifuAnimatorNS.DecorationType.None)
        Me.settings_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settings_panel.Location = New System.Drawing.Point(53, 39)
        Me.settings_panel.Name = "settings_panel"
        Me.settings_panel.Size = New System.Drawing.Size(1313, 729)
        Me.settings_panel.TabIndex = 7
        '
        'userSettings_panel
        '
        Me.userSettings_panel.BackColor = System.Drawing.Color.White
        Me.userSettings_panel.Controls.Add(Me.viewUser_btn)
        Me.userSettings_panel.Controls.Add(Me.updateUser_btn)
        Me.userSettings_panel.Controls.Add(Me.addNewUser_btn)
        Me.userSettings_panel.Controls.Add(Me.PictureBox1)
        Me.userSettings_panel.Controls.Add(Me.Label3)
        Me.delivery_transition.SetDecoration(Me.userSettings_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.userSettings_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.userSettings_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.userSettings_panel, BunifuAnimatorNS.DecorationType.None)
        Me.userSettings_panel.Location = New System.Drawing.Point(304, 107)
        Me.userSettings_panel.Name = "userSettings_panel"
        Me.userSettings_panel.Size = New System.Drawing.Size(290, 260)
        Me.userSettings_panel.TabIndex = 2
        '
        'viewUser_btn
        '
        Me.viewUser_btn.ActiveBorderThickness = 1
        Me.viewUser_btn.ActiveCornerRadius = 20
        Me.viewUser_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.viewUser_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.viewUser_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.viewUser_btn.BackColor = System.Drawing.Color.White
        Me.viewUser_btn.BackgroundImage = CType(resources.GetObject("viewUser_btn.BackgroundImage"), System.Drawing.Image)
        Me.viewUser_btn.ButtonText = "View User Profile"
        Me.viewUser_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.viewUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.viewUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.viewUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.viewUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.viewUser_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewUser_btn.ForeColor = System.Drawing.Color.White
        Me.viewUser_btn.IdleBorderThickness = 1
        Me.viewUser_btn.IdleCornerRadius = 20
        Me.viewUser_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.viewUser_btn.IdleForecolor = System.Drawing.Color.White
        Me.viewUser_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.viewUser_btn.Location = New System.Drawing.Point(54, 148)
        Me.viewUser_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.viewUser_btn.Name = "viewUser_btn"
        Me.viewUser_btn.Size = New System.Drawing.Size(203, 47)
        Me.viewUser_btn.TabIndex = 2
        Me.viewUser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updateUser_btn
        '
        Me.updateUser_btn.ActiveBorderThickness = 1
        Me.updateUser_btn.ActiveCornerRadius = 20
        Me.updateUser_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.updateUser_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.updateUser_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.updateUser_btn.BackColor = System.Drawing.Color.White
        Me.updateUser_btn.BackgroundImage = CType(resources.GetObject("updateUser_btn.BackgroundImage"), System.Drawing.Image)
        Me.updateUser_btn.ButtonText = "Update User Profile"
        Me.updateUser_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.updateUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.updateUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.updateUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.updateUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.updateUser_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateUser_btn.ForeColor = System.Drawing.Color.White
        Me.updateUser_btn.IdleBorderThickness = 1
        Me.updateUser_btn.IdleCornerRadius = 20
        Me.updateUser_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.updateUser_btn.IdleForecolor = System.Drawing.Color.White
        Me.updateUser_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.updateUser_btn.Location = New System.Drawing.Point(54, 109)
        Me.updateUser_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.updateUser_btn.Name = "updateUser_btn"
        Me.updateUser_btn.Size = New System.Drawing.Size(203, 47)
        Me.updateUser_btn.TabIndex = 0
        Me.updateUser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addNewUser_btn
        '
        Me.addNewUser_btn.ActiveBorderThickness = 1
        Me.addNewUser_btn.ActiveCornerRadius = 20
        Me.addNewUser_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.addNewUser_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.addNewUser_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.addNewUser_btn.BackColor = System.Drawing.Color.White
        Me.addNewUser_btn.BackgroundImage = CType(resources.GetObject("addNewUser_btn.BackgroundImage"), System.Drawing.Image)
        Me.addNewUser_btn.ButtonText = "Add New User"
        Me.addNewUser_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.addNewUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.addNewUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.addNewUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.addNewUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.addNewUser_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNewUser_btn.ForeColor = System.Drawing.Color.White
        Me.addNewUser_btn.IdleBorderThickness = 1
        Me.addNewUser_btn.IdleCornerRadius = 20
        Me.addNewUser_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.addNewUser_btn.IdleForecolor = System.Drawing.Color.White
        Me.addNewUser_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.addNewUser_btn.Location = New System.Drawing.Point(54, 68)
        Me.addNewUser_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.addNewUser_btn.Name = "addNewUser_btn"
        Me.addNewUser_btn.Size = New System.Drawing.Size(203, 47)
        Me.addNewUser_btn.TabIndex = 0
        Me.addNewUser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.customerOptionsTransition.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(58, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "USERS"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.BunifuThinButton27)
        Me.Panel5.Controls.Add(Me.Label40)
        Me.Panel5.Controls.Add(Me.BunifuThinButton28)
        Me.Panel5.Controls.Add(Me.PictureBox7)
        Me.delivery_transition.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.Panel5.Location = New System.Drawing.Point(304, 398)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(290, 260)
        Me.Panel5.TabIndex = 2
        '
        'BunifuThinButton27
        '
        Me.BunifuThinButton27.ActiveBorderThickness = 1
        Me.BunifuThinButton27.ActiveCornerRadius = 20
        Me.BunifuThinButton27.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton27.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BunifuThinButton27.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuThinButton27.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton27.BackgroundImage = CType(resources.GetObject("BunifuThinButton27.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton27.ButtonText = "Restore Database"
        Me.BunifuThinButton27.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.BunifuThinButton27, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuThinButton27, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuThinButton27, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuThinButton27, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton27.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton27.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton27.IdleBorderThickness = 1
        Me.BunifuThinButton27.IdleCornerRadius = 20
        Me.BunifuThinButton27.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuThinButton27.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton27.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton27.Location = New System.Drawing.Point(53, 145)
        Me.BunifuThinButton27.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton27.Name = "BunifuThinButton27"
        Me.BunifuThinButton27.Size = New System.Drawing.Size(203, 47)
        Me.BunifuThinButton27.TabIndex = 3
        Me.BunifuThinButton27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label40, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label40, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label40, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label40, BunifuAnimatorNS.DecorationType.None)
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(58, 22)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(113, 32)
        Me.Label40.TabIndex = 8
        Me.Label40.Text = "Database"
        '
        'BunifuThinButton28
        '
        Me.BunifuThinButton28.ActiveBorderThickness = 1
        Me.BunifuThinButton28.ActiveCornerRadius = 20
        Me.BunifuThinButton28.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton28.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BunifuThinButton28.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuThinButton28.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton28.BackgroundImage = CType(resources.GetObject("BunifuThinButton28.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton28.ButtonText = "Back Up Database"
        Me.BunifuThinButton28.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.BunifuThinButton28, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuThinButton28, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuThinButton28, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuThinButton28, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton28.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton28.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton28.IdleBorderThickness = 1
        Me.BunifuThinButton28.IdleCornerRadius = 20
        Me.BunifuThinButton28.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuThinButton28.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton28.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton28.Location = New System.Drawing.Point(53, 101)
        Me.BunifuThinButton28.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton28.Name = "BunifuThinButton28"
        Me.BunifuThinButton28.Size = New System.Drawing.Size(203, 47)
        Me.BunifuThinButton28.TabIndex = 4
        Me.BunifuThinButton28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox7
        '
        Me.customerOptionsTransition.SetDecoration(Me.PictureBox7, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.PictureBox7, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.PictureBox7, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.PictureBox7, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        '
        'items_panel
        '
        Me.items_panel.BackColor = System.Drawing.Color.White
        Me.items_panel.Controls.Add(Me.viewItem_btn)
        Me.items_panel.Controls.Add(Me.updateItem_btn)
        Me.items_panel.Controls.Add(Me.Label21)
        Me.items_panel.Controls.Add(Me.PictureBox5)
        Me.items_panel.Controls.Add(Me.addNewItem_btn)
        Me.delivery_transition.SetDecoration(Me.items_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.items_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.items_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.items_panel, BunifuAnimatorNS.DecorationType.None)
        Me.items_panel.Location = New System.Drawing.Point(621, 398)
        Me.items_panel.Name = "items_panel"
        Me.items_panel.Size = New System.Drawing.Size(290, 260)
        Me.items_panel.TabIndex = 3
        '
        'viewItem_btn
        '
        Me.viewItem_btn.ActiveBorderThickness = 1
        Me.viewItem_btn.ActiveCornerRadius = 20
        Me.viewItem_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.viewItem_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.viewItem_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.viewItem_btn.BackColor = System.Drawing.Color.White
        Me.viewItem_btn.BackgroundImage = CType(resources.GetObject("viewItem_btn.BackgroundImage"), System.Drawing.Image)
        Me.viewItem_btn.ButtonText = "View Item"
        Me.viewItem_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.viewItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.viewItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.viewItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.viewItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.viewItem_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewItem_btn.ForeColor = System.Drawing.Color.White
        Me.viewItem_btn.IdleBorderThickness = 1
        Me.viewItem_btn.IdleCornerRadius = 20
        Me.viewItem_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.viewItem_btn.IdleForecolor = System.Drawing.Color.White
        Me.viewItem_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.viewItem_btn.Location = New System.Drawing.Point(54, 147)
        Me.viewItem_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.viewItem_btn.Name = "viewItem_btn"
        Me.viewItem_btn.Size = New System.Drawing.Size(203, 47)
        Me.viewItem_btn.TabIndex = 8
        Me.viewItem_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updateItem_btn
        '
        Me.updateItem_btn.ActiveBorderThickness = 1
        Me.updateItem_btn.ActiveCornerRadius = 20
        Me.updateItem_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.updateItem_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.updateItem_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.updateItem_btn.BackColor = System.Drawing.Color.White
        Me.updateItem_btn.BackgroundImage = CType(resources.GetObject("updateItem_btn.BackgroundImage"), System.Drawing.Image)
        Me.updateItem_btn.ButtonText = "Update Item "
        Me.updateItem_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.updateItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.updateItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.updateItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.updateItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.updateItem_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateItem_btn.ForeColor = System.Drawing.Color.White
        Me.updateItem_btn.IdleBorderThickness = 1
        Me.updateItem_btn.IdleCornerRadius = 20
        Me.updateItem_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.updateItem_btn.IdleForecolor = System.Drawing.Color.White
        Me.updateItem_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.updateItem_btn.Location = New System.Drawing.Point(54, 108)
        Me.updateItem_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.updateItem_btn.Name = "updateItem_btn"
        Me.updateItem_btn.Size = New System.Drawing.Size(203, 47)
        Me.updateItem_btn.TabIndex = 4
        Me.updateItem_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label21, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label21, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label21, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label21, BunifuAnimatorNS.DecorationType.None)
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(58, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 32)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "ITEMS"
        '
        'PictureBox5
        '
        Me.customerOptionsTransition.SetDecoration(Me.PictureBox5, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.PictureBox5, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.PictureBox5, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.PictureBox5, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(12, 16)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'addNewItem_btn
        '
        Me.addNewItem_btn.ActiveBorderThickness = 1
        Me.addNewItem_btn.ActiveCornerRadius = 20
        Me.addNewItem_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.addNewItem_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.addNewItem_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.addNewItem_btn.BackColor = System.Drawing.Color.White
        Me.addNewItem_btn.BackgroundImage = CType(resources.GetObject("addNewItem_btn.BackgroundImage"), System.Drawing.Image)
        Me.addNewItem_btn.ButtonText = "Add New Item"
        Me.addNewItem_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.addNewItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.addNewItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.addNewItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.addNewItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.addNewItem_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNewItem_btn.ForeColor = System.Drawing.Color.White
        Me.addNewItem_btn.IdleBorderThickness = 1
        Me.addNewItem_btn.IdleCornerRadius = 20
        Me.addNewItem_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.addNewItem_btn.IdleForecolor = System.Drawing.Color.White
        Me.addNewItem_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.addNewItem_btn.Location = New System.Drawing.Point(54, 67)
        Me.addNewItem_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.addNewItem_btn.Name = "addNewItem_btn"
        Me.addNewItem_btn.Size = New System.Drawing.Size(203, 47)
        Me.addNewItem_btn.TabIndex = 5
        Me.addNewItem_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'suppliers_panel
        '
        Me.suppliers_panel.BackColor = System.Drawing.Color.White
        Me.suppliers_panel.Controls.Add(Me.view_supplier_btn)
        Me.suppliers_panel.Controls.Add(Me.Label20)
        Me.suppliers_panel.Controls.Add(Me.PictureBox3)
        Me.suppliers_panel.Controls.Add(Me.add_supplier_btn)
        Me.suppliers_panel.Controls.Add(Me.update_supplier_btn)
        Me.delivery_transition.SetDecoration(Me.suppliers_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.suppliers_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.suppliers_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.suppliers_panel, BunifuAnimatorNS.DecorationType.None)
        Me.suppliers_panel.Location = New System.Drawing.Point(620, 107)
        Me.suppliers_panel.Name = "suppliers_panel"
        Me.suppliers_panel.Size = New System.Drawing.Size(290, 260)
        Me.suppliers_panel.TabIndex = 3
        '
        'view_supplier_btn
        '
        Me.view_supplier_btn.ActiveBorderThickness = 1
        Me.view_supplier_btn.ActiveCornerRadius = 20
        Me.view_supplier_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.view_supplier_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.view_supplier_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.view_supplier_btn.BackColor = System.Drawing.Color.White
        Me.view_supplier_btn.BackgroundImage = CType(resources.GetObject("view_supplier_btn.BackgroundImage"), System.Drawing.Image)
        Me.view_supplier_btn.ButtonText = "View Supplier Profile"
        Me.view_supplier_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.view_supplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.view_supplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.view_supplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.view_supplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.view_supplier_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_supplier_btn.ForeColor = System.Drawing.Color.White
        Me.view_supplier_btn.IdleBorderThickness = 1
        Me.view_supplier_btn.IdleCornerRadius = 20
        Me.view_supplier_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.view_supplier_btn.IdleForecolor = System.Drawing.Color.White
        Me.view_supplier_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.view_supplier_btn.Location = New System.Drawing.Point(61, 147)
        Me.view_supplier_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.view_supplier_btn.Name = "view_supplier_btn"
        Me.view_supplier_btn.Size = New System.Drawing.Size(203, 47)
        Me.view_supplier_btn.TabIndex = 8
        Me.view_supplier_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label20, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label20, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label20, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label20, BunifuAnimatorNS.DecorationType.None)
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(65, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 32)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "SUPPLIERS"
        '
        'PictureBox3
        '
        Me.customerOptionsTransition.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(19, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'add_supplier_btn
        '
        Me.add_supplier_btn.ActiveBorderThickness = 1
        Me.add_supplier_btn.ActiveCornerRadius = 20
        Me.add_supplier_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.add_supplier_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.add_supplier_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.add_supplier_btn.BackColor = System.Drawing.Color.White
        Me.add_supplier_btn.BackgroundImage = CType(resources.GetObject("add_supplier_btn.BackgroundImage"), System.Drawing.Image)
        Me.add_supplier_btn.ButtonText = "Add New Supplier"
        Me.add_supplier_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.add_supplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.add_supplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.add_supplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.add_supplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.add_supplier_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_supplier_btn.ForeColor = System.Drawing.Color.White
        Me.add_supplier_btn.IdleBorderThickness = 1
        Me.add_supplier_btn.IdleCornerRadius = 20
        Me.add_supplier_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.add_supplier_btn.IdleForecolor = System.Drawing.Color.White
        Me.add_supplier_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.add_supplier_btn.Location = New System.Drawing.Point(61, 67)
        Me.add_supplier_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.add_supplier_btn.Name = "add_supplier_btn"
        Me.add_supplier_btn.Size = New System.Drawing.Size(203, 47)
        Me.add_supplier_btn.TabIndex = 5
        Me.add_supplier_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'update_supplier_btn
        '
        Me.update_supplier_btn.ActiveBorderThickness = 1
        Me.update_supplier_btn.ActiveCornerRadius = 20
        Me.update_supplier_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.update_supplier_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.update_supplier_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.update_supplier_btn.BackColor = System.Drawing.Color.White
        Me.update_supplier_btn.BackgroundImage = CType(resources.GetObject("update_supplier_btn.BackgroundImage"), System.Drawing.Image)
        Me.update_supplier_btn.ButtonText = "Update Supplier Profile"
        Me.update_supplier_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.update_supplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.update_supplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.update_supplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.update_supplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.update_supplier_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_supplier_btn.ForeColor = System.Drawing.Color.White
        Me.update_supplier_btn.IdleBorderThickness = 1
        Me.update_supplier_btn.IdleCornerRadius = 20
        Me.update_supplier_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.update_supplier_btn.IdleForecolor = System.Drawing.Color.White
        Me.update_supplier_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.update_supplier_btn.Location = New System.Drawing.Point(61, 108)
        Me.update_supplier_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.update_supplier_btn.Name = "update_supplier_btn"
        Me.update_supplier_btn.Size = New System.Drawing.Size(203, 47)
        Me.update_supplier_btn.TabIndex = 4
        Me.update_supplier_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'settings_lbl
        '
        Me.settings_lbl.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.settings_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.settings_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.settings_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.settings_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.settings_lbl.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.settings_lbl.Location = New System.Drawing.Point(534, 18)
        Me.settings_lbl.Name = "settings_lbl"
        Me.settings_lbl.Size = New System.Drawing.Size(155, 50)
        Me.settings_lbl.TabIndex = 0
        Me.settings_lbl.Text = "Settings"
        '
        'users_panel
        '
        Me.users_panel.Controls.Add(Me.searchbox_txt)
        Me.users_panel.Controls.Add(Me.userConfirmPassword_txt)
        Me.users_panel.Controls.Add(Me.Label13)
        Me.users_panel.Controls.Add(Me.userPassword_txt)
        Me.users_panel.Controls.Add(Me.Label12)
        Me.users_panel.Controls.Add(Me.userUsername_txt)
        Me.users_panel.Controls.Add(Me.Label11)
        Me.users_panel.Controls.Add(Me.userPosition_cb)
        Me.users_panel.Controls.Add(Me.Label10)
        Me.users_panel.Controls.Add(Me.Label9)
        Me.users_panel.Controls.Add(Me.userGender_cb)
        Me.users_panel.Controls.Add(Me.Label8)
        Me.users_panel.Controls.Add(Me.Label2)
        Me.users_panel.Controls.Add(Me.userLname_txt)
        Me.users_panel.Controls.Add(Me.Label7)
        Me.users_panel.Controls.Add(Me.userMname_txt)
        Me.users_panel.Controls.Add(Me.Label6)
        Me.users_panel.Controls.Add(Me.userFname_txt)
        Me.users_panel.Controls.Add(Me.Label5)
        Me.users_panel.Controls.Add(Me.PictureBox2)
        Me.users_panel.Controls.Add(Me.users_label)
        Me.users_panel.Controls.Add(Me.submitUpdateUsers_btn)
        Me.users_panel.Controls.Add(Me.submitNewUser_btn)
        Me.users_panel.Controls.Add(Me.usersback_btn)
        Me.users_panel.Controls.Add(Me.usersCancel_btn)
        Me.delivery_transition.SetDecoration(Me.users_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.users_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.users_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.users_panel, BunifuAnimatorNS.DecorationType.None)
        Me.users_panel.Location = New System.Drawing.Point(137, 107)
        Me.users_panel.Name = "users_panel"
        Me.users_panel.Size = New System.Drawing.Size(921, 552)
        Me.users_panel.TabIndex = 4
        Me.users_panel.Visible = False
        '
        'searchbox_txt
        '
        Me.searchbox_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.searchbox_txt.BackgroundImage = CType(resources.GetObject("searchbox_txt.BackgroundImage"), System.Drawing.Image)
        Me.searchbox_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delivery_transition.SetDecoration(Me.searchbox_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.searchbox_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.searchbox_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.searchbox_txt, BunifuAnimatorNS.DecorationType.None)
        Me.searchbox_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.searchbox_txt.Icon = CType(resources.GetObject("searchbox_txt.Icon"), System.Drawing.Image)
        Me.searchbox_txt.Location = New System.Drawing.Point(612, 33)
        Me.searchbox_txt.Name = "searchbox_txt"
        Me.searchbox_txt.Size = New System.Drawing.Size(250, 42)
        Me.searchbox_txt.TabIndex = 25
        Me.searchbox_txt.text = ""
        Me.searchbox_txt.Visible = False
        '
        'userConfirmPassword_txt
        '
        Me.userConfirmPassword_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.userConfirmPassword_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.userConfirmPassword_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.userConfirmPassword_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.userConfirmPassword_txt, BunifuAnimatorNS.DecorationType.None)
        Me.userConfirmPassword_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.userConfirmPassword_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userConfirmPassword_txt.HintForeColor = System.Drawing.Color.Empty
        Me.userConfirmPassword_txt.HintText = ""
        Me.userConfirmPassword_txt.isPassword = True
        Me.userConfirmPassword_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userConfirmPassword_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.userConfirmPassword_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userConfirmPassword_txt.LineThickness = 3
        Me.userConfirmPassword_txt.Location = New System.Drawing.Point(688, 309)
        Me.userConfirmPassword_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.userConfirmPassword_txt.Name = "userConfirmPassword_txt"
        Me.userConfirmPassword_txt.Size = New System.Drawing.Size(174, 33)
        Me.userConfirmPassword_txt.TabIndex = 23
        Me.userConfirmPassword_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(547, 323)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Confirm Password"
        '
        'userPassword_txt
        '
        Me.userPassword_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.userPassword_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.userPassword_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.userPassword_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.userPassword_txt, BunifuAnimatorNS.DecorationType.None)
        Me.userPassword_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.userPassword_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userPassword_txt.HintForeColor = System.Drawing.Color.Empty
        Me.userPassword_txt.HintText = ""
        Me.userPassword_txt.isPassword = True
        Me.userPassword_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userPassword_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.userPassword_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userPassword_txt.LineThickness = 3
        Me.userPassword_txt.Location = New System.Drawing.Point(688, 268)
        Me.userPassword_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.userPassword_txt.Name = "userPassword_txt"
        Me.userPassword_txt.Size = New System.Drawing.Size(174, 33)
        Me.userPassword_txt.TabIndex = 21
        Me.userPassword_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(547, 279)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 21)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Password"
        '
        'userUsername_txt
        '
        Me.userUsername_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.userUsername_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.userUsername_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.userUsername_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.userUsername_txt, BunifuAnimatorNS.DecorationType.None)
        Me.userUsername_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.userUsername_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userUsername_txt.HintForeColor = System.Drawing.Color.Empty
        Me.userUsername_txt.HintText = ""
        Me.userUsername_txt.isPassword = False
        Me.userUsername_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userUsername_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.userUsername_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userUsername_txt.LineThickness = 3
        Me.userUsername_txt.Location = New System.Drawing.Point(688, 224)
        Me.userUsername_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.userUsername_txt.Name = "userUsername_txt"
        Me.userUsername_txt.Size = New System.Drawing.Size(174, 33)
        Me.userUsername_txt.TabIndex = 19
        Me.userUsername_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(547, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 21)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "User Name"
        '
        'userPosition_cb
        '
        Me.userPosition_cb.BackColor = System.Drawing.Color.Transparent
        Me.userPosition_cb.BorderRadius = 3
        Me.customerOptionsTransition.SetDecoration(Me.userPosition_cb, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.userPosition_cb, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.userPosition_cb, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.userPosition_cb, BunifuAnimatorNS.DecorationType.None)
        Me.userPosition_cb.DisabledColor = System.Drawing.Color.Gray
        Me.userPosition_cb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.userPosition_cb.Items = New String() {"PLEASE SELECT...", "Owner", "Manager", "Accounting Staff", "Cashier", "Parts Men"}
        Me.userPosition_cb.Location = New System.Drawing.Point(688, 189)
        Me.userPosition_cb.Name = "userPosition_cb"
        Me.userPosition_cb.NomalColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.userPosition_cb.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userPosition_cb.selectedIndex = 0
        Me.userPosition_cb.Size = New System.Drawing.Size(174, 31)
        Me.userPosition_cb.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label10, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label10, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label10, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label10, BunifuAnimatorNS.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(547, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 21)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Position"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(546, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(255, 30)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "ACCOUNT INFORMATION"
        '
        'userGender_cb
        '
        Me.userGender_cb.BackColor = System.Drawing.Color.Transparent
        Me.userGender_cb.BorderRadius = 3
        Me.customerOptionsTransition.SetDecoration(Me.userGender_cb, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.userGender_cb, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.userGender_cb, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.userGender_cb, BunifuAnimatorNS.DecorationType.None)
        Me.userGender_cb.DisabledColor = System.Drawing.Color.Gray
        Me.userGender_cb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.userGender_cb.Items = New String() {"PLEASE SELECT...", "MALE", "FEMALE"}
        Me.userGender_cb.Location = New System.Drawing.Point(186, 313)
        Me.userGender_cb.Name = "userGender_cb"
        Me.userGender_cb.NomalColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.userGender_cb.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userGender_cb.selectedIndex = 0
        Me.userGender_cb.Size = New System.Drawing.Size(189, 31)
        Me.userGender_cb.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(50, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(49, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 30)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "PERSONAL INFORMATION"
        '
        'userLname_txt
        '
        Me.userLname_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.userLname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.userLname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.userLname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.userLname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.userLname_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.userLname_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userLname_txt.HintForeColor = System.Drawing.Color.Empty
        Me.userLname_txt.HintText = ""
        Me.userLname_txt.isPassword = False
        Me.userLname_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userLname_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.userLname_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userLname_txt.LineThickness = 3
        Me.userLname_txt.Location = New System.Drawing.Point(186, 267)
        Me.userLname_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.userLname_txt.Name = "userLname_txt"
        Me.userLname_txt.Size = New System.Drawing.Size(189, 33)
        Me.userLname_txt.TabIndex = 9
        Me.userLname_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(50, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 21)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Last Name"
        '
        'userMname_txt
        '
        Me.userMname_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.userMname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.userMname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.userMname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.userMname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.userMname_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.userMname_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userMname_txt.HintForeColor = System.Drawing.Color.Empty
        Me.userMname_txt.HintText = ""
        Me.userMname_txt.isPassword = False
        Me.userMname_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userMname_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.userMname_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userMname_txt.LineThickness = 3
        Me.userMname_txt.Location = New System.Drawing.Point(186, 226)
        Me.userMname_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.userMname_txt.Name = "userMname_txt"
        Me.userMname_txt.Size = New System.Drawing.Size(189, 33)
        Me.userMname_txt.TabIndex = 7
        Me.userMname_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(50, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Middle Name"
        '
        'userFname_txt
        '
        Me.userFname_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.userFname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.userFname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.userFname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.userFname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.userFname_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.userFname_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userFname_txt.HintForeColor = System.Drawing.Color.Empty
        Me.userFname_txt.HintText = ""
        Me.userFname_txt.isPassword = False
        Me.userFname_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userFname_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.userFname_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.userFname_txt.LineThickness = 3
        Me.userFname_txt.Location = New System.Drawing.Point(186, 185)
        Me.userFname_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.userFname_txt.Name = "userFname_txt"
        Me.userFname_txt.Size = New System.Drawing.Size(189, 33)
        Me.userFname_txt.TabIndex = 5
        Me.userFname_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(50, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "First Name"
        '
        'PictureBox2
        '
        Me.customerOptionsTransition.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(29, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'users_label
        '
        Me.users_label.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.users_label, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.users_label, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.users_label, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.users_label, BunifuAnimatorNS.DecorationType.None)
        Me.users_label.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.users_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.users_label.Location = New System.Drawing.Point(85, 31)
        Me.users_label.Name = "users_label"
        Me.users_label.Size = New System.Drawing.Size(83, 32)
        Me.users_label.TabIndex = 2
        Me.users_label.Text = "USERS"
        '
        'submitUpdateUsers_btn
        '
        Me.submitUpdateUsers_btn.ActiveBorderThickness = 1
        Me.submitUpdateUsers_btn.ActiveCornerRadius = 20
        Me.submitUpdateUsers_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.submitUpdateUsers_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.submitUpdateUsers_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.submitUpdateUsers_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.submitUpdateUsers_btn.BackgroundImage = CType(resources.GetObject("submitUpdateUsers_btn.BackgroundImage"), System.Drawing.Image)
        Me.submitUpdateUsers_btn.ButtonText = "UPDATE"
        Me.submitUpdateUsers_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.submitUpdateUsers_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.submitUpdateUsers_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.submitUpdateUsers_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.submitUpdateUsers_btn, BunifuAnimatorNS.DecorationType.None)
        Me.submitUpdateUsers_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitUpdateUsers_btn.ForeColor = System.Drawing.Color.White
        Me.submitUpdateUsers_btn.IdleBorderThickness = 1
        Me.submitUpdateUsers_btn.IdleCornerRadius = 20
        Me.submitUpdateUsers_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.submitUpdateUsers_btn.IdleForecolor = System.Drawing.Color.White
        Me.submitUpdateUsers_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.submitUpdateUsers_btn.Location = New System.Drawing.Point(791, 500)
        Me.submitUpdateUsers_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.submitUpdateUsers_btn.Name = "submitUpdateUsers_btn"
        Me.submitUpdateUsers_btn.Size = New System.Drawing.Size(125, 47)
        Me.submitUpdateUsers_btn.TabIndex = 24
        Me.submitUpdateUsers_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.submitUpdateUsers_btn.Visible = False
        '
        'submitNewUser_btn
        '
        Me.submitNewUser_btn.ActiveBorderThickness = 1
        Me.submitNewUser_btn.ActiveCornerRadius = 20
        Me.submitNewUser_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.submitNewUser_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.submitNewUser_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.submitNewUser_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.submitNewUser_btn.BackgroundImage = CType(resources.GetObject("submitNewUser_btn.BackgroundImage"), System.Drawing.Image)
        Me.submitNewUser_btn.ButtonText = "SUBMIT"
        Me.submitNewUser_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.submitNewUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.submitNewUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.submitNewUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.submitNewUser_btn, BunifuAnimatorNS.DecorationType.None)
        Me.submitNewUser_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitNewUser_btn.ForeColor = System.Drawing.Color.White
        Me.submitNewUser_btn.IdleBorderThickness = 1
        Me.submitNewUser_btn.IdleCornerRadius = 20
        Me.submitNewUser_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.submitNewUser_btn.IdleForecolor = System.Drawing.Color.White
        Me.submitNewUser_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.submitNewUser_btn.Location = New System.Drawing.Point(791, 500)
        Me.submitNewUser_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.submitNewUser_btn.Name = "submitNewUser_btn"
        Me.submitNewUser_btn.Size = New System.Drawing.Size(125, 47)
        Me.submitNewUser_btn.TabIndex = 11
        Me.submitNewUser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.submitNewUser_btn.Visible = False
        '
        'usersback_btn
        '
        Me.usersback_btn.ActiveBorderThickness = 1
        Me.usersback_btn.ActiveCornerRadius = 20
        Me.usersback_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.usersback_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.usersback_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.usersback_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.usersback_btn.BackgroundImage = CType(resources.GetObject("usersback_btn.BackgroundImage"), System.Drawing.Image)
        Me.usersback_btn.ButtonText = "BACK"
        Me.usersback_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.usersback_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.usersback_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.usersback_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.usersback_btn, BunifuAnimatorNS.DecorationType.None)
        Me.usersback_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usersback_btn.ForeColor = System.Drawing.Color.White
        Me.usersback_btn.IdleBorderThickness = 1
        Me.usersback_btn.IdleCornerRadius = 20
        Me.usersback_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.usersback_btn.IdleForecolor = System.Drawing.Color.White
        Me.usersback_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.usersback_btn.Location = New System.Drawing.Point(5, 500)
        Me.usersback_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.usersback_btn.Name = "usersback_btn"
        Me.usersback_btn.Size = New System.Drawing.Size(125, 47)
        Me.usersback_btn.TabIndex = 26
        Me.usersback_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.usersback_btn.Visible = False
        '
        'usersCancel_btn
        '
        Me.usersCancel_btn.ActiveBorderThickness = 1
        Me.usersCancel_btn.ActiveCornerRadius = 20
        Me.usersCancel_btn.ActiveFillColor = System.Drawing.Color.Red
        Me.usersCancel_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.usersCancel_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.usersCancel_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.usersCancel_btn.BackgroundImage = CType(resources.GetObject("usersCancel_btn.BackgroundImage"), System.Drawing.Image)
        Me.usersCancel_btn.ButtonText = "CANCEL"
        Me.usersCancel_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.usersCancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.usersCancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.usersCancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.usersCancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.usersCancel_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usersCancel_btn.ForeColor = System.Drawing.Color.White
        Me.usersCancel_btn.IdleBorderThickness = 1
        Me.usersCancel_btn.IdleCornerRadius = 20
        Me.usersCancel_btn.IdleFillColor = System.Drawing.Color.Red
        Me.usersCancel_btn.IdleForecolor = System.Drawing.Color.White
        Me.usersCancel_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.usersCancel_btn.Location = New System.Drawing.Point(5, 500)
        Me.usersCancel_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.usersCancel_btn.Name = "usersCancel_btn"
        Me.usersCancel_btn.Size = New System.Drawing.Size(125, 47)
        Me.usersCancel_btn.TabIndex = 12
        Me.usersCancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'supplier_panel
        '
        Me.supplier_panel.Controls.Add(Me.supp_address_txt)
        Me.supplier_panel.Controls.Add(Me.supp_search_txt)
        Me.supplier_panel.Controls.Add(Me.supp_contactNo_txt)
        Me.supplier_panel.Controls.Add(Me.Label25)
        Me.supplier_panel.Controls.Add(Me.supp_contactPerson_txt)
        Me.supplier_panel.Controls.Add(Me.Label26)
        Me.supplier_panel.Controls.Add(Me.Label32)
        Me.supplier_panel.Controls.Add(Me.supp_companyName_txt)
        Me.supplier_panel.Controls.Add(Me.Label33)
        Me.supplier_panel.Controls.Add(Me.PictureBox4)
        Me.supplier_panel.Controls.Add(Me.supplier_lbl)
        Me.supplier_panel.Controls.Add(Me.supp_update_btn)
        Me.supplier_panel.Controls.Add(Me.supp_back_btn)
        Me.supplier_panel.Controls.Add(Me.supp_cancel_btn)
        Me.supplier_panel.Controls.Add(Me.supp_submit_btn)
        Me.delivery_transition.SetDecoration(Me.supplier_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.supplier_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.supplier_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.supplier_panel, BunifuAnimatorNS.DecorationType.None)
        Me.supplier_panel.Location = New System.Drawing.Point(136, 107)
        Me.supplier_panel.Name = "supplier_panel"
        Me.supplier_panel.Size = New System.Drawing.Size(921, 552)
        Me.supplier_panel.TabIndex = 5
        Me.supplier_panel.Visible = False
        '
        'supp_address_txt
        '
        Me.supp_address_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.delivery_transition.SetDecoration(Me.supp_address_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.supp_address_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.supp_address_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.supp_address_txt, BunifuAnimatorNS.DecorationType.None)
        Me.supp_address_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.supp_address_txt.Location = New System.Drawing.Point(186, 244)
        Me.supp_address_txt.Name = "supp_address_txt"
        Me.supp_address_txt.Size = New System.Drawing.Size(190, 96)
        Me.supp_address_txt.TabIndex = 27
        Me.supp_address_txt.Text = ""
        '
        'supp_search_txt
        '
        Me.supp_search_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.supp_search_txt.BackgroundImage = CType(resources.GetObject("supp_search_txt.BackgroundImage"), System.Drawing.Image)
        Me.supp_search_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delivery_transition.SetDecoration(Me.supp_search_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.supp_search_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.supp_search_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.supp_search_txt, BunifuAnimatorNS.DecorationType.None)
        Me.supp_search_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.supp_search_txt.Icon = CType(resources.GetObject("supp_search_txt.Icon"), System.Drawing.Image)
        Me.supp_search_txt.Location = New System.Drawing.Point(612, 33)
        Me.supp_search_txt.Name = "supp_search_txt"
        Me.supp_search_txt.Size = New System.Drawing.Size(250, 42)
        Me.supp_search_txt.TabIndex = 25
        Me.supp_search_txt.text = ""
        Me.supp_search_txt.Visible = False
        '
        'supp_contactNo_txt
        '
        Me.supp_contactNo_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.supp_contactNo_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.supp_contactNo_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.supp_contactNo_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.supp_contactNo_txt, BunifuAnimatorNS.DecorationType.None)
        Me.supp_contactNo_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.supp_contactNo_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.supp_contactNo_txt.HintForeColor = System.Drawing.Color.Empty
        Me.supp_contactNo_txt.HintText = ""
        Me.supp_contactNo_txt.isPassword = False
        Me.supp_contactNo_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.supp_contactNo_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.supp_contactNo_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.supp_contactNo_txt.LineThickness = 3
        Me.supp_contactNo_txt.Location = New System.Drawing.Point(686, 236)
        Me.supp_contactNo_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.supp_contactNo_txt.Name = "supp_contactNo_txt"
        Me.supp_contactNo_txt.Size = New System.Drawing.Size(174, 33)
        Me.supp_contactNo_txt.TabIndex = 21
        Me.supp_contactNo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label25, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label25, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label25, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label25, BunifuAnimatorNS.DecorationType.None)
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(538, 248)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(125, 21)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "Contact Number"
        '
        'supp_contactPerson_txt
        '
        Me.supp_contactPerson_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.supp_contactPerson_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.supp_contactPerson_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.supp_contactPerson_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.supp_contactPerson_txt, BunifuAnimatorNS.DecorationType.None)
        Me.supp_contactPerson_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.supp_contactPerson_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.supp_contactPerson_txt.HintForeColor = System.Drawing.Color.Empty
        Me.supp_contactPerson_txt.HintText = ""
        Me.supp_contactPerson_txt.isPassword = False
        Me.supp_contactPerson_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.supp_contactPerson_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.supp_contactPerson_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.supp_contactPerson_txt.LineThickness = 3
        Me.supp_contactPerson_txt.Location = New System.Drawing.Point(686, 185)
        Me.supp_contactPerson_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.supp_contactPerson_txt.Name = "supp_contactPerson_txt"
        Me.supp_contactPerson_txt.Size = New System.Drawing.Size(174, 33)
        Me.supp_contactPerson_txt.TabIndex = 19
        Me.supp_contactPerson_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label26, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label26, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label26, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label26, BunifuAnimatorNS.DecorationType.None)
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(538, 197)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(114, 21)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Contact Person"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label32, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label32, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label32, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label32, BunifuAnimatorNS.DecorationType.None)
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(50, 238)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(66, 21)
        Me.Label32.TabIndex = 6
        Me.Label32.Text = "Address"
        '
        'supp_companyName_txt
        '
        Me.supp_companyName_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.supp_companyName_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.supp_companyName_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.supp_companyName_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.supp_companyName_txt, BunifuAnimatorNS.DecorationType.None)
        Me.supp_companyName_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.supp_companyName_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.supp_companyName_txt.HintForeColor = System.Drawing.Color.Empty
        Me.supp_companyName_txt.HintText = ""
        Me.supp_companyName_txt.isPassword = False
        Me.supp_companyName_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.supp_companyName_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.supp_companyName_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.supp_companyName_txt.LineThickness = 3
        Me.supp_companyName_txt.Location = New System.Drawing.Point(186, 185)
        Me.supp_companyName_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.supp_companyName_txt.Name = "supp_companyName_txt"
        Me.supp_companyName_txt.Size = New System.Drawing.Size(189, 33)
        Me.supp_companyName_txt.TabIndex = 5
        Me.supp_companyName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label33, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label33, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label33, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label33, BunifuAnimatorNS.DecorationType.None)
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(50, 197)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(123, 21)
        Me.Label33.TabIndex = 4
        Me.Label33.Text = "Company Name"
        '
        'PictureBox4
        '
        Me.customerOptionsTransition.SetDecoration(Me.PictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.PictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.PictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.PictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(29, 25)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'supplier_lbl
        '
        Me.supplier_lbl.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.supplier_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.supplier_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.supplier_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.supplier_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.supplier_lbl.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supplier_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.supplier_lbl.Location = New System.Drawing.Point(85, 31)
        Me.supplier_lbl.Name = "supplier_lbl"
        Me.supplier_lbl.Size = New System.Drawing.Size(126, 32)
        Me.supplier_lbl.TabIndex = 2
        Me.supplier_lbl.Text = "SUPPLIERS"
        '
        'supp_update_btn
        '
        Me.supp_update_btn.ActiveBorderThickness = 1
        Me.supp_update_btn.ActiveCornerRadius = 20
        Me.supp_update_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.supp_update_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.supp_update_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.supp_update_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.supp_update_btn.BackgroundImage = CType(resources.GetObject("supp_update_btn.BackgroundImage"), System.Drawing.Image)
        Me.supp_update_btn.ButtonText = "UPDATE"
        Me.supp_update_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.supp_update_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.supp_update_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.supp_update_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.supp_update_btn, BunifuAnimatorNS.DecorationType.None)
        Me.supp_update_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supp_update_btn.ForeColor = System.Drawing.Color.White
        Me.supp_update_btn.IdleBorderThickness = 1
        Me.supp_update_btn.IdleCornerRadius = 20
        Me.supp_update_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.supp_update_btn.IdleForecolor = System.Drawing.Color.White
        Me.supp_update_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.supp_update_btn.Location = New System.Drawing.Point(791, 500)
        Me.supp_update_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.supp_update_btn.Name = "supp_update_btn"
        Me.supp_update_btn.Size = New System.Drawing.Size(125, 47)
        Me.supp_update_btn.TabIndex = 24
        Me.supp_update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.supp_update_btn.Visible = False
        '
        'supp_back_btn
        '
        Me.supp_back_btn.ActiveBorderThickness = 1
        Me.supp_back_btn.ActiveCornerRadius = 20
        Me.supp_back_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.supp_back_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.supp_back_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.supp_back_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.supp_back_btn.BackgroundImage = CType(resources.GetObject("supp_back_btn.BackgroundImage"), System.Drawing.Image)
        Me.supp_back_btn.ButtonText = "BACK"
        Me.supp_back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.supp_back_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.supp_back_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.supp_back_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.supp_back_btn, BunifuAnimatorNS.DecorationType.None)
        Me.supp_back_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supp_back_btn.ForeColor = System.Drawing.Color.White
        Me.supp_back_btn.IdleBorderThickness = 1
        Me.supp_back_btn.IdleCornerRadius = 20
        Me.supp_back_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.supp_back_btn.IdleForecolor = System.Drawing.Color.White
        Me.supp_back_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.supp_back_btn.Location = New System.Drawing.Point(5, 500)
        Me.supp_back_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.supp_back_btn.Name = "supp_back_btn"
        Me.supp_back_btn.Size = New System.Drawing.Size(125, 47)
        Me.supp_back_btn.TabIndex = 26
        Me.supp_back_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.supp_back_btn.Visible = False
        '
        'supp_cancel_btn
        '
        Me.supp_cancel_btn.ActiveBorderThickness = 1
        Me.supp_cancel_btn.ActiveCornerRadius = 20
        Me.supp_cancel_btn.ActiveFillColor = System.Drawing.Color.Red
        Me.supp_cancel_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.supp_cancel_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.supp_cancel_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.supp_cancel_btn.BackgroundImage = CType(resources.GetObject("supp_cancel_btn.BackgroundImage"), System.Drawing.Image)
        Me.supp_cancel_btn.ButtonText = "CANCEL"
        Me.supp_cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.supp_cancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.supp_cancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.supp_cancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.supp_cancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.supp_cancel_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supp_cancel_btn.ForeColor = System.Drawing.Color.White
        Me.supp_cancel_btn.IdleBorderThickness = 1
        Me.supp_cancel_btn.IdleCornerRadius = 20
        Me.supp_cancel_btn.IdleFillColor = System.Drawing.Color.Red
        Me.supp_cancel_btn.IdleForecolor = System.Drawing.Color.White
        Me.supp_cancel_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.supp_cancel_btn.Location = New System.Drawing.Point(5, 500)
        Me.supp_cancel_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.supp_cancel_btn.Name = "supp_cancel_btn"
        Me.supp_cancel_btn.Size = New System.Drawing.Size(125, 47)
        Me.supp_cancel_btn.TabIndex = 12
        Me.supp_cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'supp_submit_btn
        '
        Me.supp_submit_btn.ActiveBorderThickness = 1
        Me.supp_submit_btn.ActiveCornerRadius = 20
        Me.supp_submit_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.supp_submit_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.supp_submit_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.supp_submit_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.supp_submit_btn.BackgroundImage = CType(resources.GetObject("supp_submit_btn.BackgroundImage"), System.Drawing.Image)
        Me.supp_submit_btn.ButtonText = "SUBMIT"
        Me.supp_submit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.supp_submit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.supp_submit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.supp_submit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.supp_submit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.supp_submit_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supp_submit_btn.ForeColor = System.Drawing.Color.White
        Me.supp_submit_btn.IdleBorderThickness = 1
        Me.supp_submit_btn.IdleCornerRadius = 20
        Me.supp_submit_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.supp_submit_btn.IdleForecolor = System.Drawing.Color.White
        Me.supp_submit_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.supp_submit_btn.Location = New System.Drawing.Point(791, 500)
        Me.supp_submit_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.supp_submit_btn.Name = "supp_submit_btn"
        Me.supp_submit_btn.Size = New System.Drawing.Size(125, 47)
        Me.supp_submit_btn.TabIndex = 11
        Me.supp_submit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.supp_submit_btn.Visible = False
        '
        'item_panel
        '
        Me.item_panel.Controls.Add(Me.Label37)
        Me.item_panel.Controls.Add(Me.items_price_txt)
        Me.item_panel.Controls.Add(Me.itemCategories_btn)
        Me.item_panel.Controls.Add(Me.itemSelectDescription_btn)
        Me.item_panel.Controls.Add(Me.itemsQuantity_txt)
        Me.item_panel.Controls.Add(Me.Label27)
        Me.item_panel.Controls.Add(Me.items_description_txt)
        Me.item_panel.Controls.Add(Me.itemSearch_txt)
        Me.item_panel.Controls.Add(Me.items_category_txt)
        Me.item_panel.Controls.Add(Me.Label28)
        Me.item_panel.Controls.Add(Me.Label29)
        Me.item_panel.Controls.Add(Me.items_name_txt)
        Me.item_panel.Controls.Add(Me.Label30)
        Me.item_panel.Controls.Add(Me.PictureBox6)
        Me.item_panel.Controls.Add(Me.item_lbl)
        Me.item_panel.Controls.Add(Me.item_cancel_btn)
        Me.item_panel.Controls.Add(Me.itemsBack_btn)
        Me.item_panel.Controls.Add(Me.submitItem_btn)
        Me.item_panel.Controls.Add(Me.itemsDescription_panel)
        Me.item_panel.Controls.Add(Me.itemCategory_panel)
        Me.item_panel.Controls.Add(Me.submitItemUpdate_btn)
        Me.delivery_transition.SetDecoration(Me.item_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.item_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.item_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.item_panel, BunifuAnimatorNS.DecorationType.None)
        Me.item_panel.Location = New System.Drawing.Point(136, 105)
        Me.item_panel.Name = "item_panel"
        Me.item_panel.Size = New System.Drawing.Size(921, 552)
        Me.item_panel.TabIndex = 6
        Me.item_panel.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label37, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label37, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label37, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label37, BunifuAnimatorNS.DecorationType.None)
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(538, 289)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(44, 21)
        Me.Label37.TabIndex = 34
        Me.Label37.Text = "Price"
        '
        'items_price_txt
        '
        Me.items_price_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.items_price_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.items_price_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.items_price_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.items_price_txt, BunifuAnimatorNS.DecorationType.None)
        Me.items_price_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.items_price_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.items_price_txt.HintForeColor = System.Drawing.Color.Empty
        Me.items_price_txt.HintText = ""
        Me.items_price_txt.isPassword = False
        Me.items_price_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.items_price_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.items_price_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.items_price_txt.LineThickness = 3
        Me.items_price_txt.Location = New System.Drawing.Point(673, 277)
        Me.items_price_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.items_price_txt.Name = "items_price_txt"
        Me.items_price_txt.Size = New System.Drawing.Size(164, 33)
        Me.items_price_txt.TabIndex = 34
        Me.items_price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'itemCategories_btn
        '
        Me.itemCategories_btn.ActiveBorderThickness = 1
        Me.itemCategories_btn.ActiveCornerRadius = 20
        Me.itemCategories_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.itemCategories_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.itemCategories_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.itemCategories_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.itemCategories_btn.BackgroundImage = CType(resources.GetObject("itemCategories_btn.BackgroundImage"), System.Drawing.Image)
        Me.itemCategories_btn.ButtonText = "..."
        Me.itemCategories_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.itemCategories_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.itemCategories_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.itemCategories_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.itemCategories_btn, BunifuAnimatorNS.DecorationType.None)
        Me.itemCategories_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemCategories_btn.ForeColor = System.Drawing.Color.White
        Me.itemCategories_btn.IdleBorderThickness = 1
        Me.itemCategories_btn.IdleCornerRadius = 20
        Me.itemCategories_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.itemCategories_btn.IdleForecolor = System.Drawing.Color.White
        Me.itemCategories_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.itemCategories_btn.Location = New System.Drawing.Point(846, 171)
        Me.itemCategories_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.itemCategories_btn.Name = "itemCategories_btn"
        Me.itemCategories_btn.Size = New System.Drawing.Size(70, 47)
        Me.itemCategories_btn.TabIndex = 32
        Me.itemCategories_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'itemSelectDescription_btn
        '
        Me.itemSelectDescription_btn.ActiveBorderThickness = 1
        Me.itemSelectDescription_btn.ActiveCornerRadius = 20
        Me.itemSelectDescription_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.itemSelectDescription_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.itemSelectDescription_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.itemSelectDescription_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.itemSelectDescription_btn.BackgroundImage = CType(resources.GetObject("itemSelectDescription_btn.BackgroundImage"), System.Drawing.Image)
        Me.itemSelectDescription_btn.ButtonText = "..."
        Me.itemSelectDescription_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.itemSelectDescription_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.itemSelectDescription_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.itemSelectDescription_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.itemSelectDescription_btn, BunifuAnimatorNS.DecorationType.None)
        Me.itemSelectDescription_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemSelectDescription_btn.ForeColor = System.Drawing.Color.White
        Me.itemSelectDescription_btn.IdleBorderThickness = 1
        Me.itemSelectDescription_btn.IdleCornerRadius = 20
        Me.itemSelectDescription_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.itemSelectDescription_btn.IdleForecolor = System.Drawing.Color.White
        Me.itemSelectDescription_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.itemSelectDescription_btn.Location = New System.Drawing.Point(384, 234)
        Me.itemSelectDescription_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.itemSelectDescription_btn.Name = "itemSelectDescription_btn"
        Me.itemSelectDescription_btn.Size = New System.Drawing.Size(71, 47)
        Me.itemSelectDescription_btn.TabIndex = 30
        Me.itemSelectDescription_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'itemsQuantity_txt
        '
        Me.delivery_transition.SetDecoration(Me.itemsQuantity_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.itemsQuantity_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.itemsQuantity_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.itemsQuantity_txt, BunifuAnimatorNS.DecorationType.None)
        Me.itemsQuantity_txt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemsQuantity_txt.Location = New System.Drawing.Point(674, 238)
        Me.itemsQuantity_txt.Name = "itemsQuantity_txt"
        Me.itemsQuantity_txt.Size = New System.Drawing.Size(163, 27)
        Me.itemsQuantity_txt.TabIndex = 29
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label27, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label27, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label27, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label27, BunifuAnimatorNS.DecorationType.None)
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(538, 238)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 21)
        Me.Label27.TabIndex = 28
        Me.Label27.Text = "Quantity"
        '
        'items_description_txt
        '
        Me.items_description_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.items_description_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.delivery_transition.SetDecoration(Me.items_description_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.items_description_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.items_description_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.items_description_txt, BunifuAnimatorNS.DecorationType.None)
        Me.items_description_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.items_description_txt.Location = New System.Drawing.Point(176, 234)
        Me.items_description_txt.Name = "items_description_txt"
        Me.items_description_txt.Size = New System.Drawing.Size(200, 113)
        Me.items_description_txt.TabIndex = 27
        Me.items_description_txt.Text = ""
        '
        'itemSearch_txt
        '
        Me.itemSearch_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.itemSearch_txt.BackgroundImage = CType(resources.GetObject("itemSearch_txt.BackgroundImage"), System.Drawing.Image)
        Me.itemSearch_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delivery_transition.SetDecoration(Me.itemSearch_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.itemSearch_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.itemSearch_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.itemSearch_txt, BunifuAnimatorNS.DecorationType.None)
        Me.itemSearch_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.itemSearch_txt.Icon = CType(resources.GetObject("itemSearch_txt.Icon"), System.Drawing.Image)
        Me.itemSearch_txt.Location = New System.Drawing.Point(612, 33)
        Me.itemSearch_txt.Name = "itemSearch_txt"
        Me.itemSearch_txt.Size = New System.Drawing.Size(250, 42)
        Me.itemSearch_txt.TabIndex = 25
        Me.itemSearch_txt.text = ""
        Me.itemSearch_txt.Visible = False
        '
        'items_category_txt
        '
        Me.items_category_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.items_category_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.items_category_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.items_category_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.items_category_txt, BunifuAnimatorNS.DecorationType.None)
        Me.items_category_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.items_category_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.items_category_txt.HintForeColor = System.Drawing.Color.Empty
        Me.items_category_txt.HintText = ""
        Me.items_category_txt.isPassword = False
        Me.items_category_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.items_category_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.items_category_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.items_category_txt.LineThickness = 3
        Me.items_category_txt.Location = New System.Drawing.Point(673, 177)
        Me.items_category_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.items_category_txt.Name = "items_category_txt"
        Me.items_category_txt.Size = New System.Drawing.Size(164, 33)
        Me.items_category_txt.TabIndex = 19
        Me.items_category_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label28, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label28, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label28, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label28, BunifuAnimatorNS.DecorationType.None)
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(537, 188)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(73, 21)
        Me.Label28.TabIndex = 18
        Me.Label28.Text = "Category"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label29, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label29, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label29, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label29, BunifuAnimatorNS.DecorationType.None)
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(50, 238)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(89, 21)
        Me.Label29.TabIndex = 6
        Me.Label29.Text = "Description"
        '
        'items_name_txt
        '
        Me.items_name_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.items_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.items_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.items_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.items_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.items_name_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.items_name_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.items_name_txt.HintForeColor = System.Drawing.Color.Empty
        Me.items_name_txt.HintText = ""
        Me.items_name_txt.isPassword = False
        Me.items_name_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.items_name_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.items_name_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.items_name_txt.LineThickness = 3
        Me.items_name_txt.Location = New System.Drawing.Point(176, 185)
        Me.items_name_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.items_name_txt.Name = "items_name_txt"
        Me.items_name_txt.Size = New System.Drawing.Size(305, 33)
        Me.items_name_txt.TabIndex = 5
        Me.items_name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label30, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label30, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label30, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label30, BunifuAnimatorNS.DecorationType.None)
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(50, 197)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(87, 21)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Item Name"
        '
        'PictureBox6
        '
        Me.customerOptionsTransition.SetDecoration(Me.PictureBox6, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.PictureBox6, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.PictureBox6, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.PictureBox6, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(29, 25)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 3
        Me.PictureBox6.TabStop = False
        '
        'item_lbl
        '
        Me.item_lbl.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.item_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.item_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.item_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.item_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.item_lbl.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.item_lbl.Location = New System.Drawing.Point(85, 31)
        Me.item_lbl.Name = "item_lbl"
        Me.item_lbl.Size = New System.Drawing.Size(73, 32)
        Me.item_lbl.TabIndex = 2
        Me.item_lbl.Text = "Items"
        '
        'item_cancel_btn
        '
        Me.item_cancel_btn.ActiveBorderThickness = 1
        Me.item_cancel_btn.ActiveCornerRadius = 20
        Me.item_cancel_btn.ActiveFillColor = System.Drawing.Color.Red
        Me.item_cancel_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.item_cancel_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.item_cancel_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.item_cancel_btn.BackgroundImage = CType(resources.GetObject("item_cancel_btn.BackgroundImage"), System.Drawing.Image)
        Me.item_cancel_btn.ButtonText = "CANCEL"
        Me.item_cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.item_cancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.item_cancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.item_cancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.item_cancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.item_cancel_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_cancel_btn.ForeColor = System.Drawing.Color.White
        Me.item_cancel_btn.IdleBorderThickness = 1
        Me.item_cancel_btn.IdleCornerRadius = 20
        Me.item_cancel_btn.IdleFillColor = System.Drawing.Color.Red
        Me.item_cancel_btn.IdleForecolor = System.Drawing.Color.White
        Me.item_cancel_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.item_cancel_btn.Location = New System.Drawing.Point(5, 500)
        Me.item_cancel_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.item_cancel_btn.Name = "item_cancel_btn"
        Me.item_cancel_btn.Size = New System.Drawing.Size(125, 47)
        Me.item_cancel_btn.TabIndex = 12
        Me.item_cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'itemsBack_btn
        '
        Me.itemsBack_btn.ActiveBorderThickness = 1
        Me.itemsBack_btn.ActiveCornerRadius = 20
        Me.itemsBack_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.itemsBack_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.itemsBack_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.itemsBack_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.itemsBack_btn.BackgroundImage = CType(resources.GetObject("itemsBack_btn.BackgroundImage"), System.Drawing.Image)
        Me.itemsBack_btn.ButtonText = "BACK"
        Me.itemsBack_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.itemsBack_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.itemsBack_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.itemsBack_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.itemsBack_btn, BunifuAnimatorNS.DecorationType.None)
        Me.itemsBack_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemsBack_btn.ForeColor = System.Drawing.Color.White
        Me.itemsBack_btn.IdleBorderThickness = 1
        Me.itemsBack_btn.IdleCornerRadius = 20
        Me.itemsBack_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.itemsBack_btn.IdleForecolor = System.Drawing.Color.White
        Me.itemsBack_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.itemsBack_btn.Location = New System.Drawing.Point(5, 500)
        Me.itemsBack_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.itemsBack_btn.Name = "itemsBack_btn"
        Me.itemsBack_btn.Size = New System.Drawing.Size(125, 47)
        Me.itemsBack_btn.TabIndex = 26
        Me.itemsBack_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.itemsBack_btn.Visible = False
        '
        'submitItem_btn
        '
        Me.submitItem_btn.ActiveBorderThickness = 1
        Me.submitItem_btn.ActiveCornerRadius = 20
        Me.submitItem_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.submitItem_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.submitItem_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.submitItem_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.submitItem_btn.BackgroundImage = CType(resources.GetObject("submitItem_btn.BackgroundImage"), System.Drawing.Image)
        Me.submitItem_btn.ButtonText = "SUBMIT"
        Me.submitItem_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.submitItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.submitItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.submitItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.submitItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.submitItem_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitItem_btn.ForeColor = System.Drawing.Color.White
        Me.submitItem_btn.IdleBorderThickness = 1
        Me.submitItem_btn.IdleCornerRadius = 20
        Me.submitItem_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.submitItem_btn.IdleForecolor = System.Drawing.Color.White
        Me.submitItem_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.submitItem_btn.Location = New System.Drawing.Point(791, 500)
        Me.submitItem_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.submitItem_btn.Name = "submitItem_btn"
        Me.submitItem_btn.Size = New System.Drawing.Size(125, 47)
        Me.submitItem_btn.TabIndex = 11
        Me.submitItem_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.submitItem_btn.Visible = False
        '
        'itemsDescription_panel
        '
        Me.itemsDescription_panel.Controls.Add(Me.cancelDescription_btn)
        Me.itemsDescription_panel.Controls.Add(Me.selectDescription_btn)
        Me.itemsDescription_panel.Controls.Add(Me.itemsDescription_dg)
        Me.delivery_transition.SetDecoration(Me.itemsDescription_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.itemsDescription_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.itemsDescription_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.itemsDescription_panel, BunifuAnimatorNS.DecorationType.None)
        Me.itemsDescription_panel.Location = New System.Drawing.Point(176, 228)
        Me.itemsDescription_panel.Name = "itemsDescription_panel"
        Me.itemsDescription_panel.Size = New System.Drawing.Size(493, 269)
        Me.itemsDescription_panel.TabIndex = 31
        Me.itemsDescription_panel.Visible = False
        '
        'cancelDescription_btn
        '
        Me.cancelDescription_btn.ActiveBorderThickness = 1
        Me.cancelDescription_btn.ActiveCornerRadius = 20
        Me.cancelDescription_btn.ActiveFillColor = System.Drawing.Color.Red
        Me.cancelDescription_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.cancelDescription_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.cancelDescription_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.cancelDescription_btn.BackgroundImage = CType(resources.GetObject("cancelDescription_btn.BackgroundImage"), System.Drawing.Image)
        Me.cancelDescription_btn.ButtonText = "CANCEL"
        Me.cancelDescription_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.cancelDescription_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.cancelDescription_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.cancelDescription_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.cancelDescription_btn, BunifuAnimatorNS.DecorationType.None)
        Me.cancelDescription_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelDescription_btn.ForeColor = System.Drawing.Color.White
        Me.cancelDescription_btn.IdleBorderThickness = 1
        Me.cancelDescription_btn.IdleCornerRadius = 20
        Me.cancelDescription_btn.IdleFillColor = System.Drawing.Color.Red
        Me.cancelDescription_btn.IdleForecolor = System.Drawing.Color.White
        Me.cancelDescription_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.cancelDescription_btn.Location = New System.Drawing.Point(5, 217)
        Me.cancelDescription_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.cancelDescription_btn.Name = "cancelDescription_btn"
        Me.cancelDescription_btn.Size = New System.Drawing.Size(125, 47)
        Me.cancelDescription_btn.TabIndex = 32
        Me.cancelDescription_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'selectDescription_btn
        '
        Me.selectDescription_btn.ActiveBorderThickness = 1
        Me.selectDescription_btn.ActiveCornerRadius = 20
        Me.selectDescription_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.selectDescription_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.selectDescription_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.selectDescription_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.selectDescription_btn.BackgroundImage = CType(resources.GetObject("selectDescription_btn.BackgroundImage"), System.Drawing.Image)
        Me.selectDescription_btn.ButtonText = "SELECT"
        Me.selectDescription_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.selectDescription_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.selectDescription_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.selectDescription_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.selectDescription_btn, BunifuAnimatorNS.DecorationType.None)
        Me.selectDescription_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectDescription_btn.ForeColor = System.Drawing.Color.White
        Me.selectDescription_btn.IdleBorderThickness = 1
        Me.selectDescription_btn.IdleCornerRadius = 20
        Me.selectDescription_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.selectDescription_btn.IdleForecolor = System.Drawing.Color.White
        Me.selectDescription_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.selectDescription_btn.Location = New System.Drawing.Point(363, 217)
        Me.selectDescription_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.selectDescription_btn.Name = "selectDescription_btn"
        Me.selectDescription_btn.Size = New System.Drawing.Size(125, 47)
        Me.selectDescription_btn.TabIndex = 12
        Me.selectDescription_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'itemsDescription_dg
        '
        Me.itemsDescription_dg.AllowUserToAddRows = False
        Me.itemsDescription_dg.AllowUserToDeleteRows = False
        Me.itemsDescription_dg.BackgroundColor = System.Drawing.SystemColors.Control
        Me.itemsDescription_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.itemsDescription_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.description_ID, Me.description_txt})
        Me.menuPanelTransition.SetDecoration(Me.itemsDescription_dg, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.itemsDescription_dg, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.itemsDescription_dg, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.itemsDescription_dg, BunifuAnimatorNS.DecorationType.None)
        Me.itemsDescription_dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.itemsDescription_dg.Location = New System.Drawing.Point(1, 1)
        Me.itemsDescription_dg.Name = "itemsDescription_dg"
        Me.itemsDescription_dg.ReadOnly = True
        Me.itemsDescription_dg.RowHeadersVisible = False
        Me.itemsDescription_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.itemsDescription_dg.ShowEditingIcon = False
        Me.itemsDescription_dg.Size = New System.Drawing.Size(492, 212)
        Me.itemsDescription_dg.TabIndex = 0
        '
        'description_ID
        '
        Me.description_ID.HeaderText = "Description ID"
        Me.description_ID.Name = "description_ID"
        Me.description_ID.ReadOnly = True
        Me.description_ID.Width = 150
        '
        'description_txt
        '
        Me.description_txt.HeaderText = "Description"
        Me.description_txt.Name = "description_txt"
        Me.description_txt.ReadOnly = True
        Me.description_txt.Width = 342
        '
        'itemCategory_panel
        '
        Me.itemCategory_panel.Controls.Add(Me.cancelCategory_btn)
        Me.itemCategory_panel.Controls.Add(Me.selectCategory_btn)
        Me.itemCategory_panel.Controls.Add(Me.itemCategory_dg)
        Me.delivery_transition.SetDecoration(Me.itemCategory_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.itemCategory_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.itemCategory_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.itemCategory_panel, BunifuAnimatorNS.DecorationType.None)
        Me.itemCategory_panel.Location = New System.Drawing.Point(423, 227)
        Me.itemCategory_panel.Name = "itemCategory_panel"
        Me.itemCategory_panel.Size = New System.Drawing.Size(493, 269)
        Me.itemCategory_panel.TabIndex = 33
        Me.itemCategory_panel.Visible = False
        '
        'cancelCategory_btn
        '
        Me.cancelCategory_btn.ActiveBorderThickness = 1
        Me.cancelCategory_btn.ActiveCornerRadius = 20
        Me.cancelCategory_btn.ActiveFillColor = System.Drawing.Color.Red
        Me.cancelCategory_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.cancelCategory_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.cancelCategory_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.cancelCategory_btn.BackgroundImage = CType(resources.GetObject("cancelCategory_btn.BackgroundImage"), System.Drawing.Image)
        Me.cancelCategory_btn.ButtonText = "CANCEL"
        Me.cancelCategory_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.cancelCategory_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.cancelCategory_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.cancelCategory_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.cancelCategory_btn, BunifuAnimatorNS.DecorationType.None)
        Me.cancelCategory_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelCategory_btn.ForeColor = System.Drawing.Color.White
        Me.cancelCategory_btn.IdleBorderThickness = 1
        Me.cancelCategory_btn.IdleCornerRadius = 20
        Me.cancelCategory_btn.IdleFillColor = System.Drawing.Color.Red
        Me.cancelCategory_btn.IdleForecolor = System.Drawing.Color.White
        Me.cancelCategory_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.cancelCategory_btn.Location = New System.Drawing.Point(5, 217)
        Me.cancelCategory_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.cancelCategory_btn.Name = "cancelCategory_btn"
        Me.cancelCategory_btn.Size = New System.Drawing.Size(125, 47)
        Me.cancelCategory_btn.TabIndex = 32
        Me.cancelCategory_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'selectCategory_btn
        '
        Me.selectCategory_btn.ActiveBorderThickness = 1
        Me.selectCategory_btn.ActiveCornerRadius = 20
        Me.selectCategory_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.selectCategory_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.selectCategory_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.selectCategory_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.selectCategory_btn.BackgroundImage = CType(resources.GetObject("selectCategory_btn.BackgroundImage"), System.Drawing.Image)
        Me.selectCategory_btn.ButtonText = "SELECT"
        Me.selectCategory_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.selectCategory_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.selectCategory_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.selectCategory_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.selectCategory_btn, BunifuAnimatorNS.DecorationType.None)
        Me.selectCategory_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectCategory_btn.ForeColor = System.Drawing.Color.White
        Me.selectCategory_btn.IdleBorderThickness = 1
        Me.selectCategory_btn.IdleCornerRadius = 20
        Me.selectCategory_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.selectCategory_btn.IdleForecolor = System.Drawing.Color.White
        Me.selectCategory_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.selectCategory_btn.Location = New System.Drawing.Point(363, 217)
        Me.selectCategory_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.selectCategory_btn.Name = "selectCategory_btn"
        Me.selectCategory_btn.Size = New System.Drawing.Size(125, 47)
        Me.selectCategory_btn.TabIndex = 12
        Me.selectCategory_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'itemCategory_dg
        '
        Me.itemCategory_dg.AllowUserToAddRows = False
        Me.itemCategory_dg.AllowUserToDeleteRows = False
        Me.itemCategory_dg.BackgroundColor = System.Drawing.SystemColors.Control
        Me.itemCategory_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.itemCategory_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.menuPanelTransition.SetDecoration(Me.itemCategory_dg, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.itemCategory_dg, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.itemCategory_dg, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.itemCategory_dg, BunifuAnimatorNS.DecorationType.None)
        Me.itemCategory_dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.itemCategory_dg.Location = New System.Drawing.Point(1, 1)
        Me.itemCategory_dg.Name = "itemCategory_dg"
        Me.itemCategory_dg.ReadOnly = True
        Me.itemCategory_dg.RowHeadersVisible = False
        Me.itemCategory_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.itemCategory_dg.ShowEditingIcon = False
        Me.itemCategory_dg.Size = New System.Drawing.Size(492, 212)
        Me.itemCategory_dg.TabIndex = 0
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Category ID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 342
        '
        'submitItemUpdate_btn
        '
        Me.submitItemUpdate_btn.ActiveBorderThickness = 1
        Me.submitItemUpdate_btn.ActiveCornerRadius = 20
        Me.submitItemUpdate_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.submitItemUpdate_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.submitItemUpdate_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.submitItemUpdate_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.submitItemUpdate_btn.BackgroundImage = CType(resources.GetObject("submitItemUpdate_btn.BackgroundImage"), System.Drawing.Image)
        Me.submitItemUpdate_btn.ButtonText = "UPDATE"
        Me.submitItemUpdate_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.submitItemUpdate_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.submitItemUpdate_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.submitItemUpdate_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.submitItemUpdate_btn, BunifuAnimatorNS.DecorationType.None)
        Me.submitItemUpdate_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitItemUpdate_btn.ForeColor = System.Drawing.Color.White
        Me.submitItemUpdate_btn.IdleBorderThickness = 1
        Me.submitItemUpdate_btn.IdleCornerRadius = 20
        Me.submitItemUpdate_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.submitItemUpdate_btn.IdleForecolor = System.Drawing.Color.White
        Me.submitItemUpdate_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.submitItemUpdate_btn.Location = New System.Drawing.Point(791, 500)
        Me.submitItemUpdate_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.submitItemUpdate_btn.Name = "submitItemUpdate_btn"
        Me.submitItemUpdate_btn.Size = New System.Drawing.Size(125, 47)
        Me.submitItemUpdate_btn.TabIndex = 24
        Me.submitItemUpdate_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.submitItemUpdate_btn.Visible = False
        '
        'customer_panel
        '
        Me.customer_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.customer_panel.Controls.Add(Me.customer_search_txt)
        Me.customer_panel.Controls.Add(Me.BunifuSearchEngine1)
        Me.customer_panel.Controls.Add(Me.customerCancel_btn)
        Me.customer_panel.Controls.Add(Me.customerContactNumber_txt)
        Me.customer_panel.Controls.Add(Me.BunifuCustomLabel5)
        Me.customer_panel.Controls.Add(Me.customerAddress_txt)
        Me.customer_panel.Controls.Add(Me.BunifuCustomLabel4)
        Me.customer_panel.Controls.Add(Me.customerGender_cbo)
        Me.customer_panel.Controls.Add(Me.BunifuCustomLabel3)
        Me.customer_panel.Controls.Add(Me.customerLname_txt)
        Me.customer_panel.Controls.Add(Me.BunifuCustomLabel2)
        Me.customer_panel.Controls.Add(Me.customerMname_txt)
        Me.customer_panel.Controls.Add(Me.BunifuCustomLabel1)
        Me.customer_panel.Controls.Add(Me.customerFname_txt)
        Me.customer_panel.Controls.Add(Me.cust_fnameTxt)
        Me.customer_panel.Controls.Add(Me.customer_lbl)
        Me.customer_panel.Controls.Add(Me.customerUpdate_btn)
        Me.customer_panel.Controls.Add(Me.customerSubmit_btn)
        Me.delivery_transition.SetDecoration(Me.customer_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customer_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customer_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.customer_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customer_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.customer_panel.Location = New System.Drawing.Point(53, 39)
        Me.customer_panel.Name = "customer_panel"
        Me.customer_panel.Size = New System.Drawing.Size(1313, 729)
        Me.customer_panel.TabIndex = 5
        '
        'customer_search_txt
        '
        Me.customer_search_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.customer_search_txt.BackgroundImage = CType(resources.GetObject("customer_search_txt.BackgroundImage"), System.Drawing.Image)
        Me.customer_search_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delivery_transition.SetDecoration(Me.customer_search_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customer_search_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customer_search_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.customer_search_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customer_search_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.customer_search_txt.Icon = CType(resources.GetObject("customer_search_txt.Icon"), System.Drawing.Image)
        Me.customer_search_txt.Location = New System.Drawing.Point(428, 550)
        Me.customer_search_txt.Name = "customer_search_txt"
        Me.customer_search_txt.Size = New System.Drawing.Size(371, 40)
        Me.customer_search_txt.TabIndex = 16
        Me.customer_search_txt.text = ""
        Me.customer_search_txt.Visible = False
        '
        'BunifuSearchEngine1
        '
        Me.BunifuSearchEngine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.customerOptionsTransition.SetDecoration(Me.BunifuSearchEngine1, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuSearchEngine1, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuSearchEngine1, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuSearchEngine1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSearchEngine1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuSearchEngine1.Name = "BunifuSearchEngine1"
        Me.BunifuSearchEngine1.Size = New System.Drawing.Size(43, 44)
        Me.BunifuSearchEngine1.TabIndex = 15
        '
        'customerCancel_btn
        '
        Me.customerCancel_btn.ActiveBorderThickness = 1
        Me.customerCancel_btn.ActiveCornerRadius = 20
        Me.customerCancel_btn.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.customerCancel_btn.ActiveForecolor = System.Drawing.Color.White
        Me.customerCancel_btn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.customerCancel_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.customerCancel_btn.BackgroundImage = CType(resources.GetObject("customerCancel_btn.BackgroundImage"), System.Drawing.Image)
        Me.customerCancel_btn.ButtonText = "CANCEL"
        Me.customerCancel_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.customerCancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customerCancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customerCancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.customerCancel_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerCancel_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerCancel_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.customerCancel_btn.IdleBorderThickness = 1
        Me.customerCancel_btn.IdleCornerRadius = 20
        Me.customerCancel_btn.IdleFillColor = System.Drawing.Color.Red
        Me.customerCancel_btn.IdleForecolor = System.Drawing.Color.White
        Me.customerCancel_btn.IdleLineColor = System.Drawing.Color.Sienna
        Me.customerCancel_btn.Location = New System.Drawing.Point(116, 550)
        Me.customerCancel_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.customerCancel_btn.Name = "customerCancel_btn"
        Me.customerCancel_btn.Size = New System.Drawing.Size(181, 41)
        Me.customerCancel_btn.TabIndex = 14
        Me.customerCancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'customerContactNumber_txt
        '
        Me.customerContactNumber_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.customerContactNumber_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customerContactNumber_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customerContactNumber_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.customerContactNumber_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerContactNumber_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.customerContactNumber_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.customerContactNumber_txt.HintForeColor = System.Drawing.Color.Empty
        Me.customerContactNumber_txt.HintText = ""
        Me.customerContactNumber_txt.isPassword = False
        Me.customerContactNumber_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.customerContactNumber_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.customerContactNumber_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.customerContactNumber_txt.LineThickness = 3
        Me.customerContactNumber_txt.Location = New System.Drawing.Point(838, 332)
        Me.customerContactNumber_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.customerContactNumber_txt.Name = "customerContactNumber_txt"
        Me.customerContactNumber_txt.Size = New System.Drawing.Size(217, 33)
        Me.customerContactNumber_txt.TabIndex = 12
        Me.customerContactNumber_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(663, 344)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(167, 22)
        Me.BunifuCustomLabel5.TabIndex = 11
        Me.BunifuCustomLabel5.Text = "Contact Number"
        '
        'customerAddress_txt
        '
        Me.delivery_transition.SetDecoration(Me.customerAddress_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customerAddress_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customerAddress_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.customerAddress_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerAddress_txt.Location = New System.Drawing.Point(833, 202)
        Me.customerAddress_txt.Name = "customerAddress_txt"
        Me.customerAddress_txt.Size = New System.Drawing.Size(222, 109)
        Me.customerAddress_txt.TabIndex = 10
        Me.customerAddress_txt.Text = ""
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(663, 202)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(83, 22)
        Me.BunifuCustomLabel4.TabIndex = 9
        Me.BunifuCustomLabel4.Text = "Address"
        '
        'customerGender_cbo
        '
        Me.customerGender_cbo.BackColor = System.Drawing.Color.Transparent
        Me.customerGender_cbo.BorderRadius = 3
        Me.customerOptionsTransition.SetDecoration(Me.customerGender_cbo, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customerGender_cbo, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customerGender_cbo, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.customerGender_cbo, BunifuAnimatorNS.DecorationType.None)
        Me.customerGender_cbo.DisabledColor = System.Drawing.Color.Gray
        Me.customerGender_cbo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.customerGender_cbo.Items = New String() {"PLEASE SELECT...", "MALE", "FEMALE"}
        Me.customerGender_cbo.Location = New System.Drawing.Point(252, 330)
        Me.customerGender_cbo.Name = "customerGender_cbo"
        Me.customerGender_cbo.NomalColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.customerGender_cbo.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.customerGender_cbo.selectedIndex = 0
        Me.customerGender_cbo.Size = New System.Drawing.Size(217, 35)
        Me.customerGender_cbo.TabIndex = 8
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(113, 340)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(82, 22)
        Me.BunifuCustomLabel3.TabIndex = 7
        Me.BunifuCustomLabel3.Text = "Gender"
        '
        'customerLname_txt
        '
        Me.customerLname_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.customerLname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customerLname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customerLname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.customerLname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerLname_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.customerLname_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.customerLname_txt.HintForeColor = System.Drawing.Color.Empty
        Me.customerLname_txt.HintText = ""
        Me.customerLname_txt.isPassword = False
        Me.customerLname_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.customerLname_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.customerLname_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.customerLname_txt.LineThickness = 3
        Me.customerLname_txt.Location = New System.Drawing.Point(252, 278)
        Me.customerLname_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.customerLname_txt.Name = "customerLname_txt"
        Me.customerLname_txt.Size = New System.Drawing.Size(217, 33)
        Me.customerLname_txt.TabIndex = 6
        Me.customerLname_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(113, 289)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(107, 22)
        Me.BunifuCustomLabel2.TabIndex = 5
        Me.BunifuCustomLabel2.Text = "Last Name"
        '
        'customerMname_txt
        '
        Me.customerMname_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.customerMname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customerMname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customerMname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.customerMname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerMname_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.customerMname_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.customerMname_txt.HintForeColor = System.Drawing.Color.Empty
        Me.customerMname_txt.HintText = ""
        Me.customerMname_txt.isPassword = False
        Me.customerMname_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.customerMname_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.customerMname_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.customerMname_txt.LineThickness = 3
        Me.customerMname_txt.Location = New System.Drawing.Point(252, 237)
        Me.customerMname_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.customerMname_txt.Name = "customerMname_txt"
        Me.customerMname_txt.Size = New System.Drawing.Size(217, 33)
        Me.customerMname_txt.TabIndex = 4
        Me.customerMname_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(113, 249)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(132, 22)
        Me.BunifuCustomLabel1.TabIndex = 3
        Me.BunifuCustomLabel1.Text = "Middle Name"
        '
        'customerFname_txt
        '
        Me.customerFname_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.delivery_transition.SetDecoration(Me.customerFname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customerFname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customerFname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.customerFname_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerFname_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.customerFname_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.customerFname_txt.HintForeColor = System.Drawing.Color.Empty
        Me.customerFname_txt.HintText = ""
        Me.customerFname_txt.isPassword = False
        Me.customerFname_txt.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.customerFname_txt.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.customerFname_txt.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.customerFname_txt.LineThickness = 3
        Me.customerFname_txt.Location = New System.Drawing.Point(252, 194)
        Me.customerFname_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.customerFname_txt.Name = "customerFname_txt"
        Me.customerFname_txt.Size = New System.Drawing.Size(217, 33)
        Me.customerFname_txt.TabIndex = 2
        Me.customerFname_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cust_fnameTxt
        '
        Me.cust_fnameTxt.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.cust_fnameTxt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.cust_fnameTxt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.cust_fnameTxt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.cust_fnameTxt, BunifuAnimatorNS.DecorationType.None)
        Me.cust_fnameTxt.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cust_fnameTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.cust_fnameTxt.Location = New System.Drawing.Point(112, 205)
        Me.cust_fnameTxt.Name = "cust_fnameTxt"
        Me.cust_fnameTxt.Size = New System.Drawing.Size(103, 22)
        Me.cust_fnameTxt.TabIndex = 1
        Me.cust_fnameTxt.Text = "First Name"
        '
        'customer_lbl
        '
        Me.customer_lbl.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.customer_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customer_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.customer_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customer_lbl, BunifuAnimatorNS.DecorationType.None)
        Me.customer_lbl.Font = New System.Drawing.Font("Segoe UI Semilight", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.customer_lbl.Location = New System.Drawing.Point(344, 45)
        Me.customer_lbl.Name = "customer_lbl"
        Me.customer_lbl.Size = New System.Drawing.Size(539, 50)
        Me.customer_lbl.TabIndex = 0
        Me.customer_lbl.Text = "ADD CUSTOMER INFORMATION"
        Me.customer_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'customerUpdate_btn
        '
        Me.customerUpdate_btn.ActiveBorderThickness = 1
        Me.customerUpdate_btn.ActiveCornerRadius = 20
        Me.customerUpdate_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.customerUpdate_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.customerUpdate_btn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.customerUpdate_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.customerUpdate_btn.BackgroundImage = CType(resources.GetObject("customerUpdate_btn.BackgroundImage"), System.Drawing.Image)
        Me.customerUpdate_btn.ButtonText = "UPDATE"
        Me.customerUpdate_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.customerUpdate_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customerUpdate_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customerUpdate_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.customerUpdate_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerUpdate_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerUpdate_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.customerUpdate_btn.IdleBorderThickness = 1
        Me.customerUpdate_btn.IdleCornerRadius = 20
        Me.customerUpdate_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.customerUpdate_btn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.customerUpdate_btn.IdleLineColor = System.Drawing.Color.Sienna
        Me.customerUpdate_btn.Location = New System.Drawing.Point(874, 549)
        Me.customerUpdate_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.customerUpdate_btn.Name = "customerUpdate_btn"
        Me.customerUpdate_btn.Size = New System.Drawing.Size(181, 41)
        Me.customerUpdate_btn.TabIndex = 17
        Me.customerUpdate_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.customerUpdate_btn.Visible = False
        '
        'customerSubmit_btn
        '
        Me.customerSubmit_btn.ActiveBorderThickness = 1
        Me.customerSubmit_btn.ActiveCornerRadius = 20
        Me.customerSubmit_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.customerSubmit_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.customerSubmit_btn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.customerSubmit_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.customerSubmit_btn.BackgroundImage = CType(resources.GetObject("customerSubmit_btn.BackgroundImage"), System.Drawing.Image)
        Me.customerSubmit_btn.ButtonText = "SUBMIT"
        Me.customerSubmit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.customerSubmit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.customerSubmit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.customerSubmit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.customerSubmit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.customerSubmit_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerSubmit_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.customerSubmit_btn.IdleBorderThickness = 1
        Me.customerSubmit_btn.IdleCornerRadius = 20
        Me.customerSubmit_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.customerSubmit_btn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.customerSubmit_btn.IdleLineColor = System.Drawing.Color.Sienna
        Me.customerSubmit_btn.Location = New System.Drawing.Point(874, 549)
        Me.customerSubmit_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.customerSubmit_btn.Name = "customerSubmit_btn"
        Me.customerSubmit_btn.Size = New System.Drawing.Size(181, 41)
        Me.customerSubmit_btn.TabIndex = 13
        Me.customerSubmit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.customerSubmit_btn.Visible = False
        '
        'purchaseOrder_panel
        '
        Me.purchaseOrder_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.purchaseOrder_panel.Controls.Add(Me.Label48)
        Me.purchaseOrder_panel.Controls.Add(Me.BunifuThinButton23)
        Me.purchaseOrder_panel.Controls.Add(Me.cancelPO_btn)
        Me.purchaseOrder_panel.Controls.Add(Me.selectItem_btn)
        Me.purchaseOrder_panel.Controls.Add(Me.selectSupplier_btn)
        Me.purchaseOrder_panel.Controls.Add(Me.supp_name_txt)
        Me.purchaseOrder_panel.Controls.Add(Me.Label19)
        Me.purchaseOrder_panel.Controls.Add(Me.submitPO_btn)
        Me.purchaseOrder_panel.Controls.Add(Me.POitem_ID_txt)
        Me.purchaseOrder_panel.Controls.Add(Me.POitem_name_txt)
        Me.purchaseOrder_panel.Controls.Add(Me.POitem_quantity_txt)
        Me.purchaseOrder_panel.Controls.Add(Me.Label22)
        Me.purchaseOrder_panel.Controls.Add(Me.Label23)
        Me.purchaseOrder_panel.Controls.Add(Me.Label24)
        Me.purchaseOrder_panel.Controls.Add(Me.POlist_dg)
        Me.purchaseOrder_panel.Controls.Add(Me.POselectSupp_panel)
        Me.purchaseOrder_panel.Controls.Add(Me.POselectItems_panel)
        Me.delivery_transition.SetDecoration(Me.purchaseOrder_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.purchaseOrder_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.purchaseOrder_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.purchaseOrder_panel, BunifuAnimatorNS.DecorationType.None)
        Me.purchaseOrder_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.purchaseOrder_panel.Location = New System.Drawing.Point(53, 39)
        Me.purchaseOrder_panel.Name = "purchaseOrder_panel"
        Me.purchaseOrder_panel.Size = New System.Drawing.Size(1313, 729)
        Me.purchaseOrder_panel.TabIndex = 14
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label48, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label48, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label48, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label48, BunifuAnimatorNS.DecorationType.None)
        Me.Label48.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(28, 45)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(247, 36)
        Me.Label48.TabIndex = 36
        Me.Label48.Text = "Purchase Orders"
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "ADD"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.BunifuThinButton23, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.BunifuThinButton23, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.BunifuThinButton23, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.BunifuThinButton23, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuThinButton23.Location = New System.Drawing.Point(1153, 341)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(103, 41)
        Me.BunifuThinButton23.TabIndex = 35
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cancelPO_btn
        '
        Me.cancelPO_btn.ActiveBorderThickness = 1
        Me.cancelPO_btn.ActiveCornerRadius = 20
        Me.cancelPO_btn.ActiveFillColor = System.Drawing.Color.Red
        Me.cancelPO_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.cancelPO_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.cancelPO_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.cancelPO_btn.BackgroundImage = CType(resources.GetObject("cancelPO_btn.BackgroundImage"), System.Drawing.Image)
        Me.cancelPO_btn.ButtonText = "CANCEL"
        Me.cancelPO_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.cancelPO_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.cancelPO_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.cancelPO_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.cancelPO_btn, BunifuAnimatorNS.DecorationType.None)
        Me.cancelPO_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelPO_btn.ForeColor = System.Drawing.Color.White
        Me.cancelPO_btn.IdleBorderThickness = 1
        Me.cancelPO_btn.IdleCornerRadius = 20
        Me.cancelPO_btn.IdleFillColor = System.Drawing.Color.Red
        Me.cancelPO_btn.IdleForecolor = System.Drawing.Color.White
        Me.cancelPO_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.cancelPO_btn.Location = New System.Drawing.Point(825, 410)
        Me.cancelPO_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.cancelPO_btn.Name = "cancelPO_btn"
        Me.cancelPO_btn.Size = New System.Drawing.Size(181, 41)
        Me.cancelPO_btn.TabIndex = 34
        Me.cancelPO_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'selectItem_btn
        '
        Me.selectItem_btn.ActiveBorderThickness = 1
        Me.selectItem_btn.ActiveCornerRadius = 20
        Me.selectItem_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.selectItem_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.selectItem_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.selectItem_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.selectItem_btn.BackgroundImage = CType(resources.GetObject("selectItem_btn.BackgroundImage"), System.Drawing.Image)
        Me.selectItem_btn.ButtonText = "..."
        Me.selectItem_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.selectItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.selectItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.selectItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.selectItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.selectItem_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectItem_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.selectItem_btn.IdleBorderThickness = 1
        Me.selectItem_btn.IdleCornerRadius = 20
        Me.selectItem_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.selectItem_btn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.selectItem_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.selectItem_btn.Location = New System.Drawing.Point(1190, 235)
        Me.selectItem_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.selectItem_btn.Name = "selectItem_btn"
        Me.selectItem_btn.Size = New System.Drawing.Size(66, 41)
        Me.selectItem_btn.TabIndex = 13
        Me.selectItem_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'selectSupplier_btn
        '
        Me.selectSupplier_btn.ActiveBorderThickness = 1
        Me.selectSupplier_btn.ActiveCornerRadius = 20
        Me.selectSupplier_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.selectSupplier_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.selectSupplier_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.selectSupplier_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.selectSupplier_btn.BackgroundImage = CType(resources.GetObject("selectSupplier_btn.BackgroundImage"), System.Drawing.Image)
        Me.selectSupplier_btn.ButtonText = "..."
        Me.selectSupplier_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.selectSupplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.selectSupplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.selectSupplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.selectSupplier_btn, BunifuAnimatorNS.DecorationType.None)
        Me.selectSupplier_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectSupplier_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.selectSupplier_btn.IdleBorderThickness = 1
        Me.selectSupplier_btn.IdleCornerRadius = 20
        Me.selectSupplier_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.selectSupplier_btn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.selectSupplier_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.selectSupplier_btn.Location = New System.Drawing.Point(1190, 173)
        Me.selectSupplier_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.selectSupplier_btn.Name = "selectSupplier_btn"
        Me.selectSupplier_btn.Size = New System.Drawing.Size(66, 41)
        Me.selectSupplier_btn.TabIndex = 12
        Me.selectSupplier_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'supp_name_txt
        '
        Me.supp_name_txt.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.supp_name_txt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.supp_name_txt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.supp_name_txt.BorderThickness = 2
        Me.supp_name_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.customerOptionsTransition.SetDecoration(Me.supp_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.supp_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.supp_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.supp_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.supp_name_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.supp_name_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.supp_name_txt.isPassword = False
        Me.supp_name_txt.Location = New System.Drawing.Point(963, 173)
        Me.supp_name_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.supp_name_txt.Name = "supp_name_txt"
        Me.supp_name_txt.Size = New System.Drawing.Size(218, 44)
        Me.supp_name_txt.TabIndex = 11
        Me.supp_name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label19, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label19, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label19, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label19, BunifuAnimatorNS.DecorationType.None)
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(818, 180)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 21)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Supplier Name"
        '
        'submitPO_btn
        '
        Me.submitPO_btn.ActiveBorderThickness = 1
        Me.submitPO_btn.ActiveCornerRadius = 20
        Me.submitPO_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.submitPO_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.submitPO_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.submitPO_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.submitPO_btn.BackgroundImage = CType(resources.GetObject("submitPO_btn.BackgroundImage"), System.Drawing.Image)
        Me.submitPO_btn.ButtonText = "SUBMIT"
        Me.submitPO_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.submitPO_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.submitPO_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.submitPO_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.submitPO_btn, BunifuAnimatorNS.DecorationType.None)
        Me.submitPO_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitPO_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.submitPO_btn.IdleBorderThickness = 1
        Me.submitPO_btn.IdleCornerRadius = 20
        Me.submitPO_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.submitPO_btn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.submitPO_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.submitPO_btn.Location = New System.Drawing.Point(1081, 408)
        Me.submitPO_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.submitPO_btn.Name = "submitPO_btn"
        Me.submitPO_btn.Size = New System.Drawing.Size(181, 41)
        Me.submitPO_btn.TabIndex = 9
        Me.submitPO_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'POitem_ID_txt
        '
        Me.POitem_ID_txt.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.POitem_ID_txt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.POitem_ID_txt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.POitem_ID_txt.BorderThickness = 2
        Me.POitem_ID_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.customerOptionsTransition.SetDecoration(Me.POitem_ID_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.POitem_ID_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.POitem_ID_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.POitem_ID_txt, BunifuAnimatorNS.DecorationType.None)
        Me.POitem_ID_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.POitem_ID_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.POitem_ID_txt.isPassword = False
        Me.POitem_ID_txt.Location = New System.Drawing.Point(963, 239)
        Me.POitem_ID_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.POitem_ID_txt.Name = "POitem_ID_txt"
        Me.POitem_ID_txt.Size = New System.Drawing.Size(218, 44)
        Me.POitem_ID_txt.TabIndex = 6
        Me.POitem_ID_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'POitem_name_txt
        '
        Me.POitem_name_txt.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.POitem_name_txt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.POitem_name_txt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.POitem_name_txt.BorderThickness = 2
        Me.POitem_name_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.customerOptionsTransition.SetDecoration(Me.POitem_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.POitem_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.POitem_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.POitem_name_txt, BunifuAnimatorNS.DecorationType.None)
        Me.POitem_name_txt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.POitem_name_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.POitem_name_txt.isPassword = False
        Me.POitem_name_txt.Location = New System.Drawing.Point(963, 291)
        Me.POitem_name_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.POitem_name_txt.Name = "POitem_name_txt"
        Me.POitem_name_txt.Size = New System.Drawing.Size(293, 44)
        Me.POitem_name_txt.TabIndex = 5
        Me.POitem_name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'POitem_quantity_txt
        '
        Me.POitem_quantity_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.delivery_transition.SetDecoration(Me.POitem_quantity_txt, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.POitem_quantity_txt, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.POitem_quantity_txt, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.POitem_quantity_txt, BunifuAnimatorNS.DecorationType.None)
        Me.POitem_quantity_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POitem_quantity_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.POitem_quantity_txt.Location = New System.Drawing.Point(963, 347)
        Me.POitem_quantity_txt.Name = "POitem_quantity_txt"
        Me.POitem_quantity_txt.Size = New System.Drawing.Size(70, 26)
        Me.POitem_quantity_txt.TabIndex = 4
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label22, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label22, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label22, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label22, BunifuAnimatorNS.DecorationType.None)
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(818, 347)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 21)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Quantity"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label23, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label23, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label23, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label23, BunifuAnimatorNS.DecorationType.None)
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(818, 300)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(99, 21)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Item Name"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.customerOptionsTransition.SetDecoration(Me.Label24, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.Label24, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.Label24, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.Label24, BunifuAnimatorNS.DecorationType.None)
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(821, 249)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(68, 21)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Item ID"
        '
        'POlist_dg
        '
        Me.POlist_dg.AllowUserToAddRows = False
        Me.POlist_dg.AllowUserToDeleteRows = False
        Me.POlist_dg.AllowUserToResizeColumns = False
        Me.POlist_dg.AllowUserToResizeRows = False
        Me.POlist_dg.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.POlist_dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.POlist_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.POlist_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.POlist_quantity, Me.DataGridViewTextBoxColumn6})
        Me.menuPanelTransition.SetDecoration(Me.POlist_dg, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.POlist_dg, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.POlist_dg, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.POlist_dg, BunifuAnimatorNS.DecorationType.None)
        Me.POlist_dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.POlist_dg.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.POlist_dg.Location = New System.Drawing.Point(28, 107)
        Me.POlist_dg.MultiSelect = False
        Me.POlist_dg.Name = "POlist_dg"
        Me.POlist_dg.ReadOnly = True
        Me.POlist_dg.RowHeadersVisible = False
        Me.POlist_dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.POlist_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.POlist_dg.Size = New System.Drawing.Size(720, 345)
        Me.POlist_dg.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'POlist_quantity
        '
        Me.POlist_quantity.HeaderText = "Quantity"
        Me.POlist_quantity.Name = "POlist_quantity"
        Me.POlist_quantity.ReadOnly = True
        Me.POlist_quantity.Width = 120
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'POselectSupp_panel
        '
        Me.POselectSupp_panel.Controls.Add(Me.POcancelSelectsupp_btn)
        Me.POselectSupp_panel.Controls.Add(Me.POselectSupp_btn)
        Me.POselectSupp_panel.Controls.Add(Me.POsupplier_dg)
        Me.delivery_transition.SetDecoration(Me.POselectSupp_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.POselectSupp_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.POselectSupp_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.POselectSupp_panel, BunifuAnimatorNS.DecorationType.None)
        Me.POselectSupp_panel.Location = New System.Drawing.Point(28, 105)
        Me.POselectSupp_panel.Name = "POselectSupp_panel"
        Me.POselectSupp_panel.Size = New System.Drawing.Size(720, 347)
        Me.POselectSupp_panel.TabIndex = 14
        Me.POselectSupp_panel.Visible = False
        '
        'POcancelSelectsupp_btn
        '
        Me.POcancelSelectsupp_btn.ActiveBorderThickness = 1
        Me.POcancelSelectsupp_btn.ActiveCornerRadius = 20
        Me.POcancelSelectsupp_btn.ActiveFillColor = System.Drawing.Color.Red
        Me.POcancelSelectsupp_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.POcancelSelectsupp_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.POcancelSelectsupp_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.POcancelSelectsupp_btn.BackgroundImage = CType(resources.GetObject("POcancelSelectsupp_btn.BackgroundImage"), System.Drawing.Image)
        Me.POcancelSelectsupp_btn.ButtonText = "CANCEL"
        Me.POcancelSelectsupp_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.POcancelSelectsupp_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.POcancelSelectsupp_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.POcancelSelectsupp_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.POcancelSelectsupp_btn, BunifuAnimatorNS.DecorationType.None)
        Me.POcancelSelectsupp_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POcancelSelectsupp_btn.ForeColor = System.Drawing.Color.White
        Me.POcancelSelectsupp_btn.IdleBorderThickness = 1
        Me.POcancelSelectsupp_btn.IdleCornerRadius = 20
        Me.POcancelSelectsupp_btn.IdleFillColor = System.Drawing.Color.Red
        Me.POcancelSelectsupp_btn.IdleForecolor = System.Drawing.Color.White
        Me.POcancelSelectsupp_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.POcancelSelectsupp_btn.Location = New System.Drawing.Point(5, 301)
        Me.POcancelSelectsupp_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.POcancelSelectsupp_btn.Name = "POcancelSelectsupp_btn"
        Me.POcancelSelectsupp_btn.Size = New System.Drawing.Size(118, 41)
        Me.POcancelSelectsupp_btn.TabIndex = 33
        Me.POcancelSelectsupp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'POselectSupp_btn
        '
        Me.POselectSupp_btn.ActiveBorderThickness = 1
        Me.POselectSupp_btn.ActiveCornerRadius = 20
        Me.POselectSupp_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.POselectSupp_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.POselectSupp_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.POselectSupp_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.POselectSupp_btn.BackgroundImage = CType(resources.GetObject("POselectSupp_btn.BackgroundImage"), System.Drawing.Image)
        Me.POselectSupp_btn.ButtonText = "SELECT"
        Me.POselectSupp_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.POselectSupp_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.POselectSupp_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.POselectSupp_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.POselectSupp_btn, BunifuAnimatorNS.DecorationType.None)
        Me.POselectSupp_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POselectSupp_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.POselectSupp_btn.IdleBorderThickness = 1
        Me.POselectSupp_btn.IdleCornerRadius = 20
        Me.POselectSupp_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.POselectSupp_btn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.POselectSupp_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.POselectSupp_btn.Location = New System.Drawing.Point(592, 301)
        Me.POselectSupp_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.POselectSupp_btn.Name = "POselectSupp_btn"
        Me.POselectSupp_btn.Size = New System.Drawing.Size(118, 41)
        Me.POselectSupp_btn.TabIndex = 13
        Me.POselectSupp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'POsupplier_dg
        '
        Me.POsupplier_dg.AllowUserToAddRows = False
        Me.POsupplier_dg.AllowUserToDeleteRows = False
        Me.POsupplier_dg.AllowUserToResizeRows = False
        Me.POsupplier_dg.BackgroundColor = System.Drawing.Color.White
        Me.POsupplier_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.POsupplier_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.POsupp_ID, Me.POsupp_name, Me.POsupp_address, Me.POsupp_contactPerson, Me.POsupp_contactNumber})
        Me.menuPanelTransition.SetDecoration(Me.POsupplier_dg, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.POsupplier_dg, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.POsupplier_dg, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.POsupplier_dg, BunifuAnimatorNS.DecorationType.None)
        Me.POsupplier_dg.Location = New System.Drawing.Point(0, 0)
        Me.POsupplier_dg.Name = "POsupplier_dg"
        Me.POsupplier_dg.ReadOnly = True
        Me.POsupplier_dg.RowHeadersVisible = False
        Me.POsupplier_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.POsupplier_dg.Size = New System.Drawing.Size(720, 296)
        Me.POsupplier_dg.TabIndex = 0
        '
        'POsupp_ID
        '
        Me.POsupp_ID.HeaderText = "Supplier ID"
        Me.POsupp_ID.Name = "POsupp_ID"
        Me.POsupp_ID.ReadOnly = True
        Me.POsupp_ID.Width = 144
        '
        'POsupp_name
        '
        Me.POsupp_name.HeaderText = "Supplier Name"
        Me.POsupp_name.Name = "POsupp_name"
        Me.POsupp_name.ReadOnly = True
        Me.POsupp_name.Width = 144
        '
        'POsupp_address
        '
        Me.POsupp_address.HeaderText = "Address"
        Me.POsupp_address.Name = "POsupp_address"
        Me.POsupp_address.ReadOnly = True
        Me.POsupp_address.Width = 144
        '
        'POsupp_contactPerson
        '
        Me.POsupp_contactPerson.HeaderText = "Contact Person"
        Me.POsupp_contactPerson.Name = "POsupp_contactPerson"
        Me.POsupp_contactPerson.ReadOnly = True
        Me.POsupp_contactPerson.Width = 144
        '
        'POsupp_contactNumber
        '
        Me.POsupp_contactNumber.HeaderText = "Contact Number"
        Me.POsupp_contactNumber.Name = "POsupp_contactNumber"
        Me.POsupp_contactNumber.ReadOnly = True
        Me.POsupp_contactNumber.Width = 144
        '
        'POselectItems_panel
        '
        Me.POselectItems_panel.Controls.Add(Me.POcancelSelectItem_btn)
        Me.POselectItems_panel.Controls.Add(Me.POselectItem_btn)
        Me.POselectItems_panel.Controls.Add(Me.POitems_dg)
        Me.delivery_transition.SetDecoration(Me.POselectItems_panel, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.POselectItems_panel, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.POselectItems_panel, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.POselectItems_panel, BunifuAnimatorNS.DecorationType.None)
        Me.POselectItems_panel.Location = New System.Drawing.Point(28, 104)
        Me.POselectItems_panel.Name = "POselectItems_panel"
        Me.POselectItems_panel.Size = New System.Drawing.Size(720, 347)
        Me.POselectItems_panel.TabIndex = 34
        Me.POselectItems_panel.Visible = False
        '
        'POcancelSelectItem_btn
        '
        Me.POcancelSelectItem_btn.ActiveBorderThickness = 1
        Me.POcancelSelectItem_btn.ActiveCornerRadius = 20
        Me.POcancelSelectItem_btn.ActiveFillColor = System.Drawing.Color.Red
        Me.POcancelSelectItem_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.POcancelSelectItem_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.POcancelSelectItem_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.POcancelSelectItem_btn.BackgroundImage = CType(resources.GetObject("POcancelSelectItem_btn.BackgroundImage"), System.Drawing.Image)
        Me.POcancelSelectItem_btn.ButtonText = "CANCEL"
        Me.POcancelSelectItem_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.POcancelSelectItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.POcancelSelectItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.POcancelSelectItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.POcancelSelectItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.POcancelSelectItem_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POcancelSelectItem_btn.ForeColor = System.Drawing.Color.White
        Me.POcancelSelectItem_btn.IdleBorderThickness = 1
        Me.POcancelSelectItem_btn.IdleCornerRadius = 20
        Me.POcancelSelectItem_btn.IdleFillColor = System.Drawing.Color.Red
        Me.POcancelSelectItem_btn.IdleForecolor = System.Drawing.Color.White
        Me.POcancelSelectItem_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.POcancelSelectItem_btn.Location = New System.Drawing.Point(5, 301)
        Me.POcancelSelectItem_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.POcancelSelectItem_btn.Name = "POcancelSelectItem_btn"
        Me.POcancelSelectItem_btn.Size = New System.Drawing.Size(118, 41)
        Me.POcancelSelectItem_btn.TabIndex = 33
        Me.POcancelSelectItem_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'POselectItem_btn
        '
        Me.POselectItem_btn.ActiveBorderThickness = 1
        Me.POselectItem_btn.ActiveCornerRadius = 20
        Me.POselectItem_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.POselectItem_btn.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.POselectItem_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.POselectItem_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.POselectItem_btn.BackgroundImage = CType(resources.GetObject("POselectItem_btn.BackgroundImage"), System.Drawing.Image)
        Me.POselectItem_btn.ButtonText = "SELECT"
        Me.POselectItem_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerOptionsTransition.SetDecoration(Me.POselectItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.POselectItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.POselectItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.POselectItem_btn, BunifuAnimatorNS.DecorationType.None)
        Me.POselectItem_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POselectItem_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.POselectItem_btn.IdleBorderThickness = 1
        Me.POselectItem_btn.IdleCornerRadius = 20
        Me.POselectItem_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.POselectItem_btn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.POselectItem_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.POselectItem_btn.Location = New System.Drawing.Point(592, 301)
        Me.POselectItem_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.POselectItem_btn.Name = "POselectItem_btn"
        Me.POselectItem_btn.Size = New System.Drawing.Size(118, 41)
        Me.POselectItem_btn.TabIndex = 13
        Me.POselectItem_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'POitems_dg
        '
        Me.POitems_dg.AllowUserToAddRows = False
        Me.POitems_dg.AllowUserToDeleteRows = False
        Me.POitems_dg.AllowUserToResizeRows = False
        Me.POitems_dg.BackgroundColor = System.Drawing.Color.White
        Me.POitems_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.POitems_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.POitem_ID, Me.POitem_name, Me.POdescription, Me.POcategory, Me.POitemQuantity})
        Me.menuPanelTransition.SetDecoration(Me.POitems_dg, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.POitems_dg, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me.POitems_dg, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.POitems_dg, BunifuAnimatorNS.DecorationType.None)
        Me.POitems_dg.Location = New System.Drawing.Point(0, 0)
        Me.POitems_dg.Name = "POitems_dg"
        Me.POitems_dg.ReadOnly = True
        Me.POitems_dg.RowHeadersVisible = False
        Me.POitems_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.POitems_dg.Size = New System.Drawing.Size(720, 296)
        Me.POitems_dg.TabIndex = 0
        '
        'POitem_ID
        '
        Me.POitem_ID.HeaderText = "Item ID"
        Me.POitem_ID.Name = "POitem_ID"
        Me.POitem_ID.ReadOnly = True
        Me.POitem_ID.Width = 144
        '
        'POitem_name
        '
        Me.POitem_name.HeaderText = "Item Name"
        Me.POitem_name.Name = "POitem_name"
        Me.POitem_name.ReadOnly = True
        Me.POitem_name.Width = 144
        '
        'POdescription
        '
        Me.POdescription.HeaderText = "Description"
        Me.POdescription.Name = "POdescription"
        Me.POdescription.ReadOnly = True
        Me.POdescription.Width = 144
        '
        'POcategory
        '
        Me.POcategory.HeaderText = "Category"
        Me.POcategory.Name = "POcategory"
        Me.POcategory.ReadOnly = True
        Me.POcategory.Width = 144
        '
        'POitemQuantity
        '
        Me.POitemQuantity.HeaderText = "Quantity"
        Me.POitemQuantity.Name = "POitemQuantity"
        Me.POitemQuantity.ReadOnly = True
        Me.POitemQuantity.Width = 144
        '
        'ContextMenuStrip1
        '
        Me.delivery_transition.SetDecoration(Me.ContextMenuStrip1, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.ContextMenuStrip1, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.ContextMenuStrip1, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.ContextMenuStrip1, BunifuAnimatorNS.DecorationType.None)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(144, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem1.Text = "Remove Item"
        '
        'ContextMenuStrip2
        '
        Me.delivery_transition.SetDecoration(Me.ContextMenuStrip2, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me.ContextMenuStrip2, BunifuAnimatorNS.DecorationType.None)
        Me.customerOptionsTransition.SetDecoration(Me.ContextMenuStrip2, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me.ContextMenuStrip2, BunifuAnimatorNS.DecorationType.None)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveItemToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(169, 26)
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        Me.RemoveItemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RemoveItemToolStripMenuItem.Text = "Remove Item"
        '
        'menuPanelTransition
        '
        Me.menuPanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.menuPanelTransition.Cursor = Nothing
        Animation36.AnimateOnlyDifferences = True
        Animation36.BlindCoeff = CType(resources.GetObject("Animation36.BlindCoeff"), System.Drawing.PointF)
        Animation36.LeafCoeff = 0.0!
        Animation36.MaxTime = 1.0!
        Animation36.MinTime = 0.0!
        Animation36.MosaicCoeff = CType(resources.GetObject("Animation36.MosaicCoeff"), System.Drawing.PointF)
        Animation36.MosaicShift = CType(resources.GetObject("Animation36.MosaicShift"), System.Drawing.PointF)
        Animation36.MosaicSize = 0
        Animation36.Padding = New System.Windows.Forms.Padding(0)
        Animation36.RotateCoeff = 0.0!
        Animation36.RotateLimit = 0.0!
        Animation36.ScaleCoeff = CType(resources.GetObject("Animation36.ScaleCoeff"), System.Drawing.PointF)
        Animation36.SlideCoeff = CType(resources.GetObject("Animation36.SlideCoeff"), System.Drawing.PointF)
        Animation36.TimeCoeff = 0.0!
        Animation36.TransparencyCoeff = 0.0!
        Me.menuPanelTransition.DefaultAnimation = Animation36
        '
        'customerOptionsTransition
        '
        Me.customerOptionsTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.customerOptionsTransition.Cursor = Nothing
        Animation33.AnimateOnlyDifferences = True
        Animation33.BlindCoeff = CType(resources.GetObject("Animation33.BlindCoeff"), System.Drawing.PointF)
        Animation33.LeafCoeff = 0.0!
        Animation33.MaxTime = 1.0!
        Animation33.MinTime = 0.0!
        Animation33.MosaicCoeff = CType(resources.GetObject("Animation33.MosaicCoeff"), System.Drawing.PointF)
        Animation33.MosaicShift = CType(resources.GetObject("Animation33.MosaicShift"), System.Drawing.PointF)
        Animation33.MosaicSize = 0
        Animation33.Padding = New System.Windows.Forms.Padding(0)
        Animation33.RotateCoeff = 0.0!
        Animation33.RotateLimit = 0.0!
        Animation33.ScaleCoeff = CType(resources.GetObject("Animation33.ScaleCoeff"), System.Drawing.PointF)
        Animation33.SlideCoeff = CType(resources.GetObject("Animation33.SlideCoeff"), System.Drawing.PointF)
        Animation33.TimeCoeff = 0.0!
        Animation33.TransparencyCoeff = 0.0!
        Me.customerOptionsTransition.DefaultAnimation = Animation33
        '
        'timeOFday_timer
        '
        Me.timeOFday_timer.Enabled = True
        '
        'delivery_transition
        '
        Me.delivery_transition.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind
        Me.delivery_transition.Cursor = Nothing
        Animation34.AnimateOnlyDifferences = True
        Animation34.BlindCoeff = CType(resources.GetObject("Animation34.BlindCoeff"), System.Drawing.PointF)
        Animation34.LeafCoeff = 0.0!
        Animation34.MaxTime = 1.0!
        Animation34.MinTime = 0.0!
        Animation34.MosaicCoeff = CType(resources.GetObject("Animation34.MosaicCoeff"), System.Drawing.PointF)
        Animation34.MosaicShift = CType(resources.GetObject("Animation34.MosaicShift"), System.Drawing.PointF)
        Animation34.MosaicSize = 0
        Animation34.Padding = New System.Windows.Forms.Padding(0)
        Animation34.RotateCoeff = 0.0!
        Animation34.RotateLimit = 0.0!
        Animation34.ScaleCoeff = CType(resources.GetObject("Animation34.ScaleCoeff"), System.Drawing.PointF)
        Animation34.SlideCoeff = CType(resources.GetObject("Animation34.SlideCoeff"), System.Drawing.PointF)
        Animation34.TimeCoeff = 0.0!
        Animation34.TransparencyCoeff = 0.0!
        Me.delivery_transition.DefaultAnimation = Animation34
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'MainMenu2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.viewCustomer_panel)
        Me.Controls.Add(Me.inventory_panel)
        Me.Controls.Add(Me.sales_panel)
        Me.Controls.Add(Me.purchaseOrder_panel)
        Me.Controls.Add(Me.reports_panel)
        Me.Controls.Add(Me.settings_panel)
        Me.Controls.Add(Me.customer_panel)
        Me.Controls.Add(Me.menu_panel)
        Me.Controls.Add(Me.header_panel)
        Me.customerOptionsTransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.delivery_transition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.logoTransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.menuPanelTransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.header_panel.ResumeLayout(False)
        Me.header_panel.PerformLayout()
        Me.menu_panel.ResumeLayout(False)
        Me.customerOptions_panel.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sales_panel.ResumeLayout(False)
        Me.sales_panel.PerformLayout()
        CType(Me.quantity_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.salesItem_panel.ResumeLayout(False)
        CType(Me.salesItem_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.salesCustomer_panel.ResumeLayout(False)
        CType(Me.salesCustomer_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.viewCustomer_panel.ResumeLayout(False)
        Me.viewCustomer_panel.PerformLayout()
        CType(Me.customerPurchases_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inventory_panel.ResumeLayout(False)
        Me.inventory_panel.PerformLayout()
        CType(Me.inventoryItemList_dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryPOs_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.deliver_panel.ResumeLayout(False)
        Me.deliver_panel.PerformLayout()
        CType(Me.inventoryLost_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryDamaged_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryItems_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inventoryGraph_panel.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.reports_panel.ResumeLayout(False)
        Me.reports_panel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settings_panel.ResumeLayout(False)
        Me.settings_panel.PerformLayout()
        Me.userSettings_panel.ResumeLayout(False)
        Me.userSettings_panel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.items_panel.ResumeLayout(False)
        Me.items_panel.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.suppliers_panel.ResumeLayout(False)
        Me.suppliers_panel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.users_panel.ResumeLayout(False)
        Me.users_panel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.supplier_panel.ResumeLayout(False)
        Me.supplier_panel.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.item_panel.ResumeLayout(False)
        Me.item_panel.PerformLayout()
        CType(Me.itemsQuantity_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.itemsDescription_panel.ResumeLayout(False)
        CType(Me.itemsDescription_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.itemCategory_panel.ResumeLayout(False)
        CType(Me.itemCategory_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.customer_panel.ResumeLayout(False)
        Me.customer_panel.PerformLayout()
        Me.purchaseOrder_panel.ResumeLayout(False)
        Me.purchaseOrder_panel.PerformLayout()
        CType(Me.POitem_quantity_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POlist_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.POselectSupp_panel.ResumeLayout(False)
        CType(Me.POsupplier_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.POselectItems_panel.ResumeLayout(False)
        CType(Me.POitems_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Private WithEvents menuPanelTransition As BunifuAnimatorNS.BunifuTransition
    Private WithEvents logoTransition As BunifuAnimatorNS.BunifuTransition
    Private WithEvents customerOptionsTransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents timeOFday_timer As System.Windows.Forms.Timer
    Friend WithEvents menu_panel As System.Windows.Forms.Panel
    Friend WithEvents customerOptions_panel As System.Windows.Forms.Panel
    Friend WithEvents editCustomer_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents addCustomer_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents viewCustomer_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator8 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator7 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents logout_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents settings_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents reports_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents inventory_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator6 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents customer_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents purchaseOrders_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents sales_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents header_panel As System.Windows.Forms.Panel
    Friend WithEvents date_label As System.Windows.Forms.Label
    Friend WithEvents clock_label As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents sales_panel As System.Windows.Forms.Panel
    Friend WithEvents viewCustomer_panel As System.Windows.Forms.Panel
    Friend WithEvents inventory_panel As System.Windows.Forms.Panel
    Friend WithEvents reports_panel As System.Windows.Forms.Panel
    Friend WithEvents settings_panel As System.Windows.Forms.Panel
    Friend WithEvents customer_panel As System.Windows.Forms.Panel
    Friend WithEvents customer_lbl As System.Windows.Forms.Label
    Friend WithEvents cust_fnameTxt As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents settings_lbl As System.Windows.Forms.Label
    Friend WithEvents items_panel As System.Windows.Forms.Panel
    Friend WithEvents suppliers_panel As System.Windows.Forms.Panel
    Friend WithEvents userSettings_panel As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents addNewUser_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents updateUser_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents viewUser_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents customerLname_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents customerMname_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents customerFname_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents users_panel As System.Windows.Forms.Panel
    Friend WithEvents userLname_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents userMname_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents userFname_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents users_label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents submitNewUser_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents usersCancel_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents userGender_cb As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents userUsername_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents userPosition_cb As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents userPassword_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents userConfirmPassword_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents submitUpdateUsers_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents searchbox_txt As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents usersback_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents item_dg As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents item_id_txt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents item_name_txt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents quantity_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents total_price_txt As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents checkout_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents salesCustomerName_txt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents salesSelectItems_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents salesSelectCustomer_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents purchaseOrder_panel As System.Windows.Forms.Panel
    Friend WithEvents selectItem_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents selectSupplier_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents supp_name_txt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents submitPO_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents POitem_ID_txt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents POitem_name_txt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents POitem_quantity_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents POlist_dg As System.Windows.Forms.DataGridView
    Friend WithEvents view_supplier_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents add_supplier_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents update_supplier_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents supplier_panel As System.Windows.Forms.Panel
    Friend WithEvents supp_address_txt As System.Windows.Forms.RichTextBox
    Friend WithEvents supp_search_txt As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents supp_contactNo_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents supp_contactPerson_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents supp_companyName_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents supplier_lbl As System.Windows.Forms.Label
    Friend WithEvents supp_cancel_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents supp_submit_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents supp_update_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents supp_back_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents viewItem_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents updateItem_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents addNewItem_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents item_panel As System.Windows.Forms.Panel
    Friend WithEvents items_description_txt As System.Windows.Forms.RichTextBox
    Friend WithEvents itemSearch_txt As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents items_category_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents items_name_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents item_lbl As System.Windows.Forms.Label
    Friend WithEvents submitItemUpdate_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents itemsBack_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents item_cancel_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents submitItem_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents itemsQuantity_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents itemSelectDescription_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents itemsDescription_panel As System.Windows.Forms.Panel
    Friend WithEvents cancelDescription_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents selectDescription_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents itemsDescription_dg As System.Windows.Forms.DataGridView
    Friend WithEvents description_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description_txt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemCategories_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents itemCategory_panel As System.Windows.Forms.Panel
    Friend WithEvents cancelCategory_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents selectCategory_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents itemCategory_dg As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POselectSupp_panel As System.Windows.Forms.Panel
    Friend WithEvents POsupplier_dg As System.Windows.Forms.DataGridView
    Friend WithEvents POselectSupp_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents POsupp_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POsupp_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POsupp_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POsupp_contactPerson As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POsupp_contactNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POcancelSelectsupp_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cancelPO_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents POselectItems_panel As System.Windows.Forms.Panel
    Friend WithEvents POcancelSelectItem_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents POselectItem_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents POitems_dg As System.Windows.Forms.DataGridView
    Friend WithEvents POitem_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POitem_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POdescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POcategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POitemQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents customerAddress_txt As System.Windows.Forms.RichTextBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents customerGender_cbo As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents customerContactNumber_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents inventoryPOs_dg As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POlist_quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stockIn_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents stocks_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents inventoryView_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents inventorySetDeliver_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents inventoryItems_dg As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inventorySearch_txt As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inventoryDate_txt As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents deliver_panel As System.Windows.Forms.Panel
    Friend WithEvents inventorySubmit_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents delivery_transition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents inventoryDamaged_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents customerSubmit_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents customerCancel_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents customer_search_txt As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuSearchEngine1 As Bunifu.Framework.UI.BunifuSearchEngine
    Friend WithEvents customerUpdate_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents viewCustomerSearch_txt As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents viewCustomerName_txt As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents viewCustomerAddress_txt As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents viewCustomerContactNumber_txt As System.Windows.Forms.Label
    Friend WithEvents customerPurchases_dg As System.Windows.Forms.DataGridView
    Friend WithEvents vcustomer_datePurchased As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vcustomer_itemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vcustomer_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vcustomer_quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents items_price_txt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents add_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents salesCustomer_panel As System.Windows.Forms.Panel
    Friend WithEvents salesCustomer_dg As System.Windows.Forms.DataGridView
    Friend WithEvents salesCustomerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salesCustomer_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salesCustomer_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salesCustomer_contactNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salesCustomer_gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents salesItem_panel As System.Windows.Forms.Panel
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton26 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents salesItem_dg As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents inventoryPurchaseStatus_cbo As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents inventoryGraph_panel As System.Windows.Forms.Panel
    Friend WithEvents inventoryItemList_dg As System.Windows.Forms.DataGridView
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents BunifuThinButton27 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents BunifuThinButton28 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuThinButton211 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuThinButton215 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents repEndDate_dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents repStartDate_dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inventoryLost_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents charge_rdo As System.Windows.Forms.RadioButton
    Friend WithEvents cash_rdo As System.Windows.Forms.RadioButton
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents cash_txt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents change_txt As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents customerCharge_txt As System.Windows.Forms.RadioButton
    Friend WithEvents customerCash_txt As System.Windows.Forms.RadioButton
End Class
