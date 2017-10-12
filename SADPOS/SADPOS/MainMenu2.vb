Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Text
Imports System.ComponentModel

Imports System.IO

Public Class MainMenu2

    Private md5 As New MD5Hashing
    Private user_fname As String = Nothing
    Private user_mname As String = Nothing
    Private user_lname As String = Nothing
    Private user_gender As String = Nothing
    Private user_posistion As String = Nothing
    Private user_userName As String = Nothing
    Private user_password As String = Nothing
    Private user_confirmPassword As String = Nothing
    Private supp_companyName As String = Nothing
    Private supp_address As String = Nothing
    Private supp_contactPerson As String = Nothing
    Private supp_contactNo As String = Nothing
    Private supp_id As String = Nothing
    Private items_name As String = Nothing
    Private items_description As String = Nothing
    Private items_category As String = Nothing
    Private items_quantity As String
    Private items_ID As String
    Private descriptionID As String
    Private categoryID As String
    Private poID As String
    Private poDate As String
    Private poStatus As String
    Private customer_firstname As String
    Private customer_middleName As String
    Private customer_lastName As String
    Private customer_gender As String
    Private customer_address As String
    Private customer_contactNumber As String
    Private customer_id As String
    Private purchaseType As String
    Private itemName As String
    Private itemID As String
    Private itemDescription As String
    Private itemCategory As String
    Private total As Double
    Private qty As Double
    Private price As Double
    Private itemPrice As Double


    Private cmd As MySqlCommand

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        'SHRINK
        If menu_panel.Width = 257 Then
            logoTransition.HideSync(logo)
            menu_panel.Visible = False
            menu_panel.Width = 53
            menuPanelTransition.ShowSync(menu_panel)
            'EXPAND
        ElseIf menu_panel.Width = 53 Then
            menu_panel.Visible = False
            menu_panel.Width = 257
            menuPanelTransition.ShowSync(menu_panel)
            logoTransition.ShowSync(logo)
        End If
    End Sub

    Private Sub customer_btn_Click(sender As Object, e As EventArgs) Handles customer_btn.Click
        If customerOptions_panel.Height = 0 Then
            customer_btn.Normalcolor = customer_btn.Activecolor
            customerOptions_panel.Visible = False
            customerOptions_panel.Height = 145
            customerOptionsTransition.ShowSync(customerOptions_panel)
        ElseIf customerOptions_panel.Height = 145 Then

            customer_btn.Normalcolor = menu_panel.BackColor
            customerOptionsTransition.HideSync(customerOptions_panel)
            customerOptions_panel.Visible = False
            customerOptions_panel.Height = 0
        End If

        If customerOptions_panel.Visible = True And customer_btn.Normalcolor = customer_btn.Activecolor Then
            inventory_btn.IconVisible = False
            inventory_btn.IconVisible = False
            settings_btn.IconVisible = False
            inventory_btn.Visible = False
            reports_btn.Visible = False
            settings_btn.Visible = False
        Else
            inventory_btn.Visible = True
            inventory_btn.IconVisible = True
            reports_btn.Visible = True
            inventory_btn.IconVisible = True
            settings_btn.Visible = True
            settings_btn.IconVisible = True
        End If

    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        If MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            LogInScreen.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub timeOFday_timer_Tick(sender As Object, e As EventArgs) Handles timeOFday_timer.Tick
        clock_label.Text = TimeOfDay
        date_label.Text = Date.Now.ToString("ddd, MMM/dd/yyyy")
    End Sub

    Private Sub addCustomer_btn_Click(sender As Object, e As EventArgs) Handles addCustomer_btn.Click
        hidePanels()
        customer_panel.Visible = True
        customer_lbl.Text = "ADD CUSTOMER INFORMATION"
        customerSubmit_btn.BringToFront()
        customerSubmit_btn.Visible = True
        customer_search_txt.Visible = False
    End Sub

    Private Sub sales_btn_Click(sender As Object, e As EventArgs) Handles sales_btn.Click
        hidePanels()
        sales_panel.Visible = True
    End Sub

    Private Sub hidePanels()
        Panel2.Visible = False
        customer_panel.Visible = False
        'editCustomer_panel.Visible = False
        viewCustomer_panel.Visible = False
        inventory_panel.Visible = False
        reports_panel.Visible = False
        settings_panel.Visible = False
        purchaseOrder_panel.Visible = False
        sales_panel.Visible = False
    End Sub

    Private Sub settings_btn_Click(sender As Object, e As EventArgs) Handles settings_btn.Click
        hidePanels()
        settings_panel.Visible = True
    End Sub

    Private Sub editCustomer_btn_Click(sender As Object, e As EventArgs) Handles editCustomer_btn.Click
        hidePanels()
        customer_panel.Visible = True
        customer_lbl.Text = "EDIT CUSTOMER INFORMATION"
        customerUpdate_btn.BringToFront()
        customerUpdate_btn.Visible = True
        customer_search_txt.Visible = True
    End Sub

    Private Sub reports_btn_Click(sender As Object, e As EventArgs) Handles reports_btn.Click
        hidePanels()
        reports_panel.Visible = True
    End Sub

    Private Sub addNewUser_btn_Click(sender As Object, e As EventArgs) Handles addNewUser_btn.Click
        settings_lbl.Visible = False
        users_panel.BringToFront()
        users_panel.Visible = True
        users_label.Text = "Add New Users"
        submitNewUser_btn.BringToFront()
        submitNewUser_btn.Visible = True

        searchbox_txt.Visible = False
        usersback_btn.SendToBack()
        usersback_btn.Visible = False
        submitUpdateUsers_btn.SendToBack()
        submitUpdateUsers_btn.Visible = False
        Label13.Visible = True
        userConfirmPassword_txt.Visible = True
    End Sub

    Private Sub usersCancel_btn_Click(sender As Object, e As EventArgs) Handles usersCancel_btn.Click
        initializeUserVariables()
        If Not user_fname = Nothing Or Not user_mname = Nothing Or Not user_lname = Nothing Or Not user_gender = 0 Or Not user_posistion = 0 Or Not user_userName = Nothing Or Not user_password = Nothing Or Not user_confirmPassword = Nothing Then
            If MessageBox.Show("Do you want to discard your changes?", "Discard Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                clearFields()
                users_panel.SendToBack()
                users_panel.Visible = False
                submitNewUser_btn.Visible = False
                submitUpdateUsers_btn.Visible = False
            End If
        Else
            clearFields()
            users_panel.SendToBack()
            users_panel.Visible = False
            submitNewUser_btn.Visible = False
            submitUpdateUsers_btn.Visible = False
            settings_lbl.Visible = True
        End If
    End Sub

    Private Sub submitNewUser_btn_Click(sender As Object, e As EventArgs) Handles submitNewUser_btn.Click

        initializeUserVariables()

        Dim enc_userPassword As String

        If user_fname = Nothing And user_mname = Nothing And user_lname = Nothing And user_gender = 0 And user_posistion = 0 And user_userName = Nothing And user_password = Nothing And user_confirmPassword = Nothing Then
            MsgBox("Please fill in the fields.")
            Exit Sub
        End If
        If user_fname = Nothing Then
            MsgBox("Please Input First Name.")
            Exit Sub
        ElseIf user_mname = Nothing Then
            MsgBox("Please Input Middle Name.")
            Exit Sub
        ElseIf user_lname = Nothing Then
            MsgBox("Please Input Last Name.")
            Exit Sub
        ElseIf user_gender = 0 Then
            MsgBox("Please Select Gender.")
            Exit Sub
        ElseIf user_posistion = 0 Then
            MsgBox("Please Select Position.")
            Exit Sub
        ElseIf user_userName = Nothing Then
            MsgBox("Please Input Username.")
            Exit Sub
        ElseIf user_password = Nothing Then
            MsgBox("Please Input Password.")
            Exit Sub
        ElseIf user_confirmPassword = Nothing Then
            MsgBox("Please Confirm your Password.")
            Exit Sub
        End If

        'checking for existing users
        If Not user_password = user_confirmPassword Then
            MsgBox("Password and Confirm Password does not match.")
            Exit Sub
        Else
            'encrypt password
            Dim md5 As New MD5Hashing
            enc_userPassword = md5.Encrypt(user_password, Constants.MD5key)
        End If
        openConnection()
        Dim query As String = "SELECT user_userName FROM tbl_user WHERE user_userName = '" & user_userName & "' "
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader

        If reader.HasRows Then
            MsgBox("Username already exists. Please choose another username. " & reader.HasRows)
            reader.Close()
            closeConnection()
            Exit Sub
        Else
            reader.Close()
            closeConnection()
        End If

        Dim statement As String = "INSERT INTO tbl_employees (employee_firstName, employee_middleName, employee_lastName, employee_gender, employee_position) VALUES (@fname, @mname, @lname, @gender, @position)"
        cmd = New MySqlCommand(statement, con)

        cmd.Parameters.AddWithValue("@fname", user_fname)
        cmd.Parameters.AddWithValue("@mname", user_mname)
        cmd.Parameters.AddWithValue("@lname", user_lname)
        cmd.Parameters.AddWithValue("@gender", userGender_cb.selectedValue)
        cmd.Parameters.AddWithValue("@position", userPosition_cb.selectedValue)

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        Dim statement2 As String = "INSERT INTO tbl_user (user_userName, user_password, employee_id) VALUES (@username, @password, (SELECT employee_id FROM tbl_employees WHERE employee_firstName = '" & user_fname & "' AND employee_middleName = '" & user_mname & "' AND employee_lastName = '" & user_lname & "'))"
        cmd = New MySqlCommand(statement2, con)

        cmd.Parameters.AddWithValue("@username", user_userName)
        cmd.Parameters.AddWithValue("@password", enc_userPassword)

        Dim da2 As New MySqlDataAdapter(cmd)
        Dim dt2 As New DataTable
        da2.Fill(dt2)

        MessageBox.Show("Successfully Added User.", "Success")
        closeConnection()
        clearFields()

    End Sub

    Private Sub initializeUserVariables()
        user_fname = userFname_txt.Text
        user_mname = userMname_txt.Text
        user_lname = userLname_txt.Text
        user_gender = userGender_cb.selectedIndex
        user_posistion = userPosition_cb.selectedIndex
        user_userName = userUsername_txt.Text
        user_password = userPassword_txt.Text
        user_confirmPassword = userConfirmPassword_txt.Text
    End Sub

    Private Sub clearFields()

        userFname_txt.Text = Nothing
        userMname_txt.Text = Nothing
        userLname_txt.Text = Nothing
        userGender_cb.selectedIndex = 0
        userPosition_cb.selectedIndex = 0
        userUsername_txt.Text = Nothing
        userPassword_txt.Text = Nothing
        userConfirmPassword_txt.Text = Nothing
        searchbox_txt.text = Nothing

        supp_companyName_txt.Text = Nothing
        supp_address_txt.Text = Nothing
        supp_contactPerson_txt.Text = Nothing
        supp_contactNo_txt.Text = Nothing
        supp_search_txt.text = Nothing

        items_name_txt.Text = Nothing
        items_category_txt.Text = Nothing
        items_description_txt.Text = Nothing
        itemsQuantity_txt.Value = 0
        items_price_txt.Text = Nothing

        supp_name_txt.Text = Nothing
        POitem_ID_txt.Text = Nothing
        POitem_name_txt.Text = Nothing
        POitem_quantity_txt.Value = Nothing

        salesCustomerName_txt.Text = Nothing
        item_id_txt.Text = Nothing
        item_name_txt.Text = Nothing
        quantity_txt.Value = 0

    End Sub

    Private Sub submitUpdateUsers_btn_Click(sender As Object, e As EventArgs) Handles submitUpdateUsers_btn.Click

        initializeUserVariables()
        'ERROR TRAPS
        Dim enc_userPassword As String

        If user_fname = Nothing And user_mname = Nothing And user_lname = Nothing And user_gender = 0 And user_posistion = 0 And user_userName = Nothing And user_password = Nothing And user_confirmPassword = Nothing Then
            MsgBox("Please fill in the fields.")
            Exit Sub
        End If
        If user_fname = Nothing Then
            MsgBox("Please Input First Name.")
            Exit Sub
        ElseIf user_mname = Nothing Then
            MsgBox("Please Input Middle Name.")
            Exit Sub
        ElseIf user_lname = Nothing Then
            MsgBox("Please Input Last Name.")
            Exit Sub
        ElseIf user_gender = 0 Then
            MsgBox("Please Select Gender.")
            Exit Sub
        ElseIf user_posistion = 0 Then
            MsgBox("Please Select Position.")
            Exit Sub
        ElseIf user_userName = Nothing Then
            MsgBox("Please Input Username.")
            Exit Sub
        ElseIf user_password = Nothing Then
            MsgBox("Please Input Password.")
            Exit Sub
        ElseIf user_confirmPassword = Nothing Then
            MsgBox("Please Confirm your Password.")
            Exit Sub
        End If

        'checking for existing users
        If Not user_password = user_confirmPassword Then
            MsgBox("Password and Confirm Password does not match.")
            Exit Sub
        Else
            Dim md5 As New MD5Hashing
            enc_userPassword = md5.Encrypt(user_password, Constants.MD5key)
        End If

        Dim query As String
        query = "UPDATE tbl_employees SET employee_firstName = @fname, employee_middleName = @mname, employee_lastName = @lname, employee_gender = @gender, employee_position = @position " &
            "WHERE employee_id = (SELECT employee_id FROM tbl_user WHERE user_userName = @username)"
        openConnection()
        cmd = New MySqlCommand(query, con)

        cmd.Parameters.AddWithValue("@fname", user_fname)
        cmd.Parameters.AddWithValue("@mname", user_mname)
        cmd.Parameters.AddWithValue("@lname", user_lname)
        cmd.Parameters.AddWithValue("@gender", userGender_cb.selectedValue)
        cmd.Parameters.AddWithValue("@position", userPosition_cb.selectedValue)
        cmd.Parameters.AddWithValue("@username", user_userName)

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        closeConnection()

        Dim userUpdate As String
        userUpdate = "UPDATE tbl_user SET user_password = @enc_password WHERE user_userName = @username"

        cmd = New MySqlCommand(userUpdate, con)
        da = New MySqlDataAdapter(cmd)
        dt = New DataTable

        cmd.Parameters.AddWithValue("@enc_password", enc_userPassword)
        cmd.Parameters.AddWithValue("@username", user_userName)
        da.Fill(dt)

        MsgBox("User Info Successfully Updated.")
        clearFields()
        closeConnection()

    End Sub

    Private Sub updateUser_btn_Click(sender As Object, e As EventArgs) Handles updateUser_btn.Click
        settings_lbl.Visible = False
        users_panel.BringToFront()
        users_panel.Visible = True
        users_label.Text = "Update User Information"
        submitUpdateUsers_btn.BringToFront()
        submitUpdateUsers_btn.Visible = True
        userUsername_txt.Enabled = False
        searchbox_txt.Visible = True
        submitNewUser_btn.SendToBack()
        submitNewUser_btn.Visible = False
    End Sub

    Private Sub searchbox_txt_OnTextChange(sender As Object, e As EventArgs) Handles searchbox_txt.KeyPress
        initializeUserVariables()
        Dim user_id As String
        Dim dec_pass As String
        Dim decrypt As New MD5Hashing

        Dim query As String
        query = "SELECT * FROM tbl_user INNER JOIN tbl_employees ON tbl_user.employee_id = tbl_employees.employee_id " &
                "WHERE tbl_employees.employee_firstName LIKE '%" & searchbox_txt.text & "%' OR employee_middleName LIKE '%" & searchbox_txt.text & "%' OR employee_lastName LIKE '%" & searchbox_txt.text & "%' OR tbl_employees.employee_id LIKE '%" & searchbox_txt.text & "%'"

        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            user_fname = reader.GetString("employee_firstName")
            user_mname = reader.GetString("employee_middleName")
            user_lname = reader.GetString("employee_lastName")
            user_gender = reader.GetString("employee_gender")
            user_posistion = reader.GetString("employee_position")
            user_id = reader.GetString("employee_id")
            user_userName = reader.GetString("user_userName")
            user_password = reader.GetString("user_password")
        End While
        reader.Close()
        closeConnection()
        'decrypt password
        dec_pass = decrypt.Decrypt(user_password, Constants.MD5key)

        userFname_txt.Text = user_fname
        userMname_txt.Text = user_mname
        userLname_txt.Text = user_lname
        If user_gender = Nothing Then
            userGender_cb.selectedIndex = 0
        ElseIf user_gender = "MALE" Then
            userGender_cb.selectedIndex = 1
        ElseIf user_gender = "FEMALE" Then
            userGender_cb.selectedIndex = 2
        End If
        If user_posistion = Nothing Then
            userPosition_cb.selectedIndex = 0
        ElseIf user_posistion = "Owner" Then
            userPosition_cb.selectedIndex = 1
        ElseIf user_posistion = "Manager" Then
            userPosition_cb.selectedIndex = 2
        ElseIf user_posistion = "Accounting Staff" Then
            userPosition_cb.selectedIndex = 3
        ElseIf user_posistion = "Cashier" Then
            userPosition_cb.selectedIndex = 4
        ElseIf user_posistion = "Parts Men" Then
            userPosition_cb.selectedIndex = 5
        End If
        userUsername_txt.Text = user_userName
        userPassword_txt.Text = dec_pass
        userPassword_txt.isPassword = True
        If searchbox_txt.text = Nothing Then
            clearFields()
        End If
    End Sub

    Private Sub userPassword_txt_KeyPress(sender As Object, e As EventArgs) Handles userPassword_txt.OnValueChanged
        userPassword_txt.isPassword = True
    End Sub

    Private Sub userConfirmPassword_txt_KeyPress(sender As Object, e As EventArgs) Handles userConfirmPassword_txt.OnValueChanged
        userConfirmPassword_txt.isPassword = True
    End Sub

    Private Sub usersback_btn_Click(sender As Object, e As EventArgs) Handles usersback_btn.Click
        clearFields()
        users_panel.SendToBack()
        users_panel.Visible = False
        settings_lbl.Visible = True

        userFname_txt.Enabled = True
        userMname_txt.Enabled = True
        userLname_txt.Enabled = True
        userGender_cb.Enabled = True
        userPosition_cb.Enabled = True
        userUsername_txt.Enabled = True
        Label13.Visible = True
        userConfirmPassword_txt.Visible = True
    End Sub

    Private Sub viewUser_btn_Click(sender As Object, e As EventArgs) Handles viewUser_btn.Click
        userFname_txt.Enabled = False
        userMname_txt.Enabled = False
        userLname_txt.Enabled = False
        userGender_cb.Enabled = False
        userPosition_cb.Enabled = False
        userUsername_txt.Enabled = False
        Label13.Visible = False
        userConfirmPassword_txt.Visible = False
        usersback_btn.BringToFront()
        usersback_btn.Visible = True
        users_panel.BringToFront()
        users_panel.Visible = True
        searchbox_txt.Visible = True
        users_label.Text = "View User Information"
        settings_lbl.Visible = False
    End Sub

    Private Sub inventory_btn_Click(sender As Object, e As EventArgs) Handles inventory_btn.Click
        hidePanels()
        inventory_panel.Visible = True
        inventoryPOs_dg.Rows.Clear()
        refreshPOlistDG()

        inventoryDate_txt.Value = date_label.Text
    End Sub

    Private Sub purchaseOrders_btn_Click(sender As Object, e As EventArgs) Handles purchaseOrders_btn.Click
        hidePanels()
        purchaseOrder_panel.Visible = True
    End Sub

    Private Sub add_supplier_btn_Click(sender As Object, e As EventArgs) Handles add_supplier_btn.Click
        supplier_panel.BringToFront()
        supplier_panel.Visible = True
        supplier_lbl.Text = "ADD SUPPLIER INFORMATION"
        supp_submit_btn.BringToFront()
        supp_submit_btn.Visible = True
        settings_lbl.Visible = False

        supp_companyName_txt.Enabled = True
        supp_address_txt.Enabled = True
        supp_contactPerson_txt.Enabled = True
        supp_contactNo_txt.Enabled = True

        supp_search_txt.Visible = False
    End Sub

    Private Sub supp_cancel_btn_Click(sender As Object, e As EventArgs) Handles supp_cancel_btn.Click

        If Not supp_companyName_txt.Text = Nothing Or Not supp_address_txt.Text = Nothing Or Not supp_contactPerson_txt.Text = Nothing Or Not supp_contactNo_txt.Text = Nothing Then
            If MessageBox.Show("Do you want to discard your changes?", "Discard Changes", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                clearFields()
                supplier_panel.SendToBack()
                supplier_panel.Visible = False
                supp_submit_btn.Visible = False
                searchbox_txt.Visible = False
                settings_lbl.Visible = True
            End If
        Else
            clearFields()
            supplier_panel.SendToBack()
            supplier_panel.Visible = False
            supp_submit_btn.Visible = False
            searchbox_txt.Visible = False
            settings_lbl.Visible = True
        End If

    End Sub

    Private Sub update_supplier_btn_Click(sender As Object, e As EventArgs) Handles update_supplier_btn.Click
        supplier_panel.BringToFront()
        supplier_panel.Visible = True
        supplier_lbl.Text = "UPDATE SUPPLIER INFORMATION"
        supp_update_btn.BringToFront()
        supp_update_btn.Visible = True
        supp_search_txt.Visible = True
        settings_lbl.Visible = False

        supp_companyName_txt.Enabled = True
        supp_address_txt.Enabled = True
        supp_contactPerson_txt.Enabled = True
        supp_contactNo_txt.Enabled = True
    End Sub

    Private Sub view_supplier_btn_Click(sender As Object, e As EventArgs) Handles view_supplier_btn.Click
        supp_companyName_txt.Enabled = False
        supp_address_txt.Enabled = False
        supp_contactPerson_txt.Enabled = False
        supp_contactNo_txt.Enabled = False

        supp_back_btn.BringToFront()
        supp_back_btn.Visible = True
        supplier_panel.BringToFront()
        supplier_panel.Visible = True
        supp_search_txt.Visible = True
        supplier_lbl.Text = "VIEW SUPPLIER INFORMATION"
        settings_lbl.Visible = False

        supp_update_btn.Visible = False
        supp_submit_btn.Visible = False
    End Sub

    Private Sub supp_back_btn_Click(sender As Object, e As EventArgs) Handles supp_back_btn.Click
        clearFields()
        supplier_panel.SendToBack()
        supplier_panel.Visible = False
        settings_lbl.Visible = True
    End Sub

    Private Sub supp_submit_btn_Click(sender As Object, e As EventArgs) Handles supp_submit_btn.Click

        initializeSupplierVariables()

        If supp_companyName = Nothing And supp_address = Nothing And supp_contactPerson = Nothing And supp_contactNo = Nothing Then
            MsgBox("Please Input Fields")
            Exit Sub
        ElseIf supp_companyName = Nothing Then
            MsgBox("Please input company name.")
            Exit Sub
        ElseIf supp_address = Nothing Then
            MsgBox("Please input address.")
            Exit Sub
        ElseIf supp_contactPerson = Nothing Then
            MsgBox("Please input contact person.")
            Exit Sub
        ElseIf supp_contactNo = Nothing Then
            MsgBox("Please input contact number.")
            Exit Sub
        End If

        Dim query As String
        query = "INSERT INTO tbl_suppliers(supplier_name, supplier_address, supplier_contactPerson, supplier_contactNumber)" &
            " VALUES (@companyName, @address, @contactPerson, @contactNo)"

        cmd = New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@companyName", supp_companyName)
        cmd.Parameters.AddWithValue("@address", supp_address)
        cmd.Parameters.AddWithValue("@contactPerson", supp_contactPerson)
        cmd.Parameters.AddWithValue("@contactNo", supp_contactNo)

        Dim ad As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        ad.Fill(dt)
        MsgBox("Supplier information successfully added.")

    End Sub

    Private Sub initializeSupplierVariables()

        supp_companyName = supp_companyName_txt.Text
        supp_address = supp_address_txt.Text
        supp_contactPerson = supp_contactPerson_txt.Text
        supp_contactNo = supp_contactNo_txt.Text

    End Sub

    Private Sub supp_update_btn_Click(sender As Object, e As EventArgs) Handles supp_update_btn.Click

        initializeSupplierVariables()

        If supp_companyName = Nothing And supp_address = Nothing And supp_contactPerson = Nothing And supp_contactNo = Nothing Then
            MsgBox("Please Input Fields")
            Exit Sub
        ElseIf supp_companyName = Nothing Then
            MsgBox("Please input company name.")
            Exit Sub
        ElseIf supp_address = Nothing Then
            MsgBox("Please input address.")
            Exit Sub
        ElseIf supp_contactPerson = Nothing Then
            MsgBox("Please input contact person.")
            Exit Sub
        ElseIf supp_contactNo = Nothing Then
            MsgBox("Please input contact number.")
            Exit Sub
        End If

        Dim query As String
        query = "UPDATE tbl_suppliers SET supplier_name = @companyName, supplier_address = @address, supplier_contactPerson = @contactPerson, supplier_contactNumber = @contactNo WHERE supplier_id = @id"

        cmd = New MySqlCommand(query, con)

        cmd.Parameters.AddWithValue("@companyName", supp_companyName_txt.Text)
        cmd.Parameters.AddWithValue("@address", supp_address_txt.Text)
        cmd.Parameters.AddWithValue("@contactPerson", supp_contactPerson_txt.Text)
        cmd.Parameters.AddWithValue("@contactNo", supp_contactNo_txt.Text)
        cmd.Parameters.AddWithValue("@id", supp_id)

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)
        con.Close()
        clearFields()
        MsgBox("Supplier information successfully updated.")


    End Sub

    Private Sub supp_search_txt_OnTextChange(sender As Object, e As EventArgs) Handles supp_search_txt.KeyPress

        Dim query As String
        query = "SELECT * FROM tbl_suppliers WHERE supplier_name LIKE '%" & supp_search_txt.text & "%' OR supplier_address LIKE '%" & supp_search_txt.text & "%' OR supplier_contactPerson LIKE '%" & supp_search_txt.text & "%' OR supplier_contactNumber LIKE '%" & supp_search_txt.text & "%' OR supplier_id LIKE '" & searchbox_txt.text & "'"
        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            supp_id = reader.GetString("supplier_id")
            supp_companyName = reader.GetString("supplier_name")
            supp_address = reader.GetString("supplier_address")
            supp_contactPerson = reader.GetString("supplier_contactPerson")
            supp_contactNo = reader.GetString("supplier_contactNumber")
        End While
        reader.Close()
        closeConnection()

        supp_companyName_txt.Text = supp_companyName
        supp_address_txt.Text = supp_address
        supp_contactNo_txt.Text = supp_contactNo
        supp_contactPerson_txt.Text = supp_contactPerson

        If supp_search_txt.text = Nothing Then
            clearFields()
        End If

    End Sub


    Private Sub item_cancel_btn_Click(sender As Object, e As EventArgs) Handles item_cancel_btn.Click

        initializeItemsVariables()
        If Not items_name = Nothing Or Not items_category = Nothing Or Not items_description = Nothing Or Not items_quantity = "0" Then
            If MessageBox.Show("Do you want to discard your changes?", "Discard changes?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                clearFields()
                item_panel.SendToBack()
                settings_lbl.Visible = True
                item_panel.Visible = False
                itemSearch_txt.Visible = False
            End If
        Else
            clearFields()
            item_panel.SendToBack()
            item_panel.Visible = False
            settings_lbl.Visible = True
            itemSearch_txt.Visible = False
        End If

    End Sub

    Private Sub initializeItemsVariables()
        items_name = items_name_txt.Text
        items_category = items_category_txt.Text
        items_description = items_description_txt.Text
        items_quantity = itemsQuantity_txt.Value.ToString

        'MsgBox(items_name & " " & items_category & " " & items_description & " " & items_quantity & " ")
    End Sub

    Private Sub addNewItem_btn_Click(sender As Object, e As EventArgs) Handles addNewItem_btn.Click

        item_lbl.Text = "ADD NEW ITEM"
        submitItem_btn.BringToFront()
        submitItem_btn.Visible = True
        item_cancel_btn.BringToFront()
        item_cancel_btn.Visible = True
        item_panel.BringToFront()
        item_panel.Visible = True
        settings_lbl.Visible = False
        selectDescription_btn.Visible = True
    End Sub

    Private Sub updateItem_btn_Click(sender As Object, e As EventArgs) Handles updateItem_btn.Click

        item_lbl.Text = "UPDATE ITEM INFORMATION"
        submitItemUpdate_btn.BringToFront()
        submitItemUpdate_btn.Visible = True
        item_cancel_btn.BringToFront()
        item_cancel_btn.Visible = True
        item_panel.BringToFront()
        item_panel.Visible = True
        itemSearch_txt.Visible = True
        settings_lbl.Visible = False
        selectDescription_btn.Visible = True
    End Sub

    Private Sub viewItem_btn_Click(sender As Object, e As EventArgs) Handles viewItem_btn.Click
        settings_lbl.Visible = False
        itemSearch_txt.Visible = True
        itemsBack_btn.BringToFront()
        itemsBack_btn.Visible = True
        items_name_txt.Enabled = False
        items_category_txt.Enabled = False
        items_description_txt.Enabled = False
        itemsQuantity_txt.Enabled = False
        item_panel.BringToFront()
        item_panel.Visible = True
        submitItem_btn.Visible = False
        submitItemUpdate_btn.Visible = False
        itemSelectDescription_btn.Visible = False
    End Sub

    Private Sub itemsBack_btn_Click(sender As Object, e As EventArgs) Handles itemsBack_btn.Click
        items_name_txt.Enabled = True
        items_category_txt.Enabled = True
        items_description_txt.Enabled = True
        itemsQuantity_txt.Enabled = True
        item_panel.SendToBack()
        item_panel.Visible = False
        settings_lbl.Visible = True
        itemSearch_txt.Visible = False
        itemSelectDescription_btn.Visible = True
        clearFields()
    End Sub

    Private Sub submitItem_btn_Click(sender As Object, e As EventArgs) Handles submitItem_btn.Click

        initializeItemsVariables()
        If items_name = Nothing And items_category = Nothing And items_description = Nothing And items_quantity = "0" Then
            MsgBox("Please fill all fields.")
            Exit Sub
        ElseIf items_name = Nothing Then
            MsgBox("Please fill item name.")
            Exit Sub
        ElseIf items_category = Nothing Then
            MsgBox("Please input item category.")
            Exit Sub
        ElseIf items_description = Nothing Then
            MsgBox("Please input item description.")
            Exit Sub
            ' ElseIf items_quantity = "0" Then
            '    If MessageBox.Show("Item quantity is 0. Do you want to add the item information and proceed to purchase orders?", "Save and Proceed.", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            'MsgBox("Proceed to Purchase Order.")
            'Else
            '   Exit Sub
            'End If
        End If

        'checking description if exists else add to database
        Dim query As String
        query = "SELECT * FROM tbl_description WHERE description_name = '" & items_description & "'"
        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader
        If Not reader.HasRows Then
            descriptionID = Nothing
        Else
            reader.Read()
            descriptionID = reader.GetString("description_id")
            ' MsgBox(descriptionID)
            reader.Close()
            closeConnection()
        End If
        reader.Close()
        closeConnection()
        If descriptionID = Nothing Then
            Dim insertQuery As String
            insertQuery = "INSERT INTO tbl_description(description_name) VALUES ('" & items_description & "')"
            cmd = New MySqlCommand(insertQuery, con)
            Dim atad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            atad.Fill(dt)
            ' MsgBox("SUCCESS")
        End If

        'checking item category if exists return id else add to db
        Dim cat_query As String
        cat_query = "SELECT * FROM tbl_category WHERE category_name = '" & items_category & "'"
        openConnection()
        cmd = New MySqlCommand(cat_query, con)
        Dim cat_reader As MySqlDataReader
        cat_reader = cmd.ExecuteReader
        If Not cat_reader.HasRows Then
            cat_reader.Close()
            closeConnection()
            descriptionID = Nothing
            Dim insert_query As String
            insert_query = "INSERT INTO tbl_category(category_name) VALUES('" & items_category & "')"
            cmd = New MySqlCommand(insert_query, con)
            Dim atad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            atad.Fill(dt)
            ' MsgBox("INSERT")
        Else
            cat_reader.Read()
            categoryID = cat_reader.GetString("category_id")
            cat_reader.Close()
            closeConnection()
            'MsgBox(categoryID)
        End If

        'getting value for description & category ids
        If descriptionID = Nothing And categoryID = Nothing Then
            Dim getDesc_ID As String
            getDesc_ID = "SELECT description_id FROM tbl_description WHERE description_name = '" & items_description & "'"
            openConnection()
            cmd = New MySqlCommand(getDesc_ID, con)
            Dim reads As MySqlDataReader
            reads = cmd.ExecuteReader
            While reads.Read
                descriptionID = reads.GetString("description_id")
            End While
            reads.Close()
            closeConnection()

            Dim getCat_ID As String
            getCat_ID = "SELECT category_id FROM tbl_category WHERE category_name = '" & items_category & "'"

            openConnection()
            cmd = New MySqlCommand(getCat_ID, con)
            Dim cat_ID As MySqlDataReader
            cat_ID = cmd.ExecuteReader
            While cat_ID.Read
                categoryID = cat_ID.GetString("category_id")
            End While
            cat_ID.Close()
            closeConnection()
        End If


        'TImE TO INSERT DATA

        Dim insert As String
        insert = "INSERT INTO tbl_inventory(item_name, category_id, description_id, quantity, inventory_price) VALUES (@name, @cat_id, @desc_id, @quantity, @price)"

        cmd = New MySqlCommand(insert, con)
        cmd.Parameters.AddWithValue("@name", items_name)
        cmd.Parameters.AddWithValue("@cat_id", categoryID)
        cmd.Parameters.AddWithValue("@desc_id", descriptionID)
        cmd.Parameters.AddWithValue("@quantity", items_quantity)
        cmd.Parameters.AddWithValue("@price", items_price_txt.Text)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        MsgBox("Item information added successfully.")
        If items_quantity = "0" Then
            If MessageBox.Show("Item quantity is 0. Do you want to proceed to purchase order?", "Save and Proceed.", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                'MsgBox("Proceed to Purchase Order.")
                clearFields()

                hidePanels()
                purchaseOrder_panel.Show()
            Else
                clearFields()
            End If
        End If

    End Sub


    Private Sub cancelDescription_btn_Click(sender As Object, e As EventArgs) Handles cancelDescription_btn.Click
        itemsDescription_panel.Visible = False
        itemsDescription_panel.SendToBack()
        itemsQuantity_txt.Visible = True

    End Sub

    Private Sub itemSelectDescription_btn_Click(sender As Object, e As EventArgs) Handles itemSelectDescription_btn.Click
        itemsDescription_dg.Rows.Clear()
        itemsDescription_panel.Visible = True
        itemsDescription_panel.BringToFront()
        itemsQuantity_txt.Visible = False
        refreshDescriptionTable()
    End Sub

    Private Sub refreshDescriptionTable()
        Dim query As String
        query = "SELECT * FROM tbl_description ORDER BY description_id ASC"
        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader
        Dim i As Integer = 0
        While reader.Read
            itemsDescription_dg.Rows.Add(New String() {reader.GetString("description_id"), reader.GetString("description_name")})
        End While
        reader.Close()
        closeConnection()
    End Sub

    Private Sub selectDescription_btn_Click(sender As Object, e As EventArgs) Handles selectDescription_btn.Click
        Dim i As Integer = itemsDescription_dg.CurrentRow.Index
        items_description_txt.Text = itemsDescription_dg.Item(1, i).Value
        itemsQuantity_txt.Visible = True
        itemsDescription_panel.Visible = False
    End Sub


    Private Sub cancelCategory_btn_Click(sender As Object, e As EventArgs) Handles cancelCategory_btn.Click
        itemCategory_panel.Visible = False
        itemCategory_panel.SendToBack()
        itemsQuantity_txt.Visible = True
    End Sub

    Private Sub itemCategories_btn_Click(sender As Object, e As EventArgs) Handles itemCategories_btn.Click
        itemCategory_dg.Rows.Clear()
        itemCategory_panel.Visible = True
        itemCategory_panel.BringToFront()
        itemsQuantity_txt.Visible = False
        refreshCategoryDG()
    End Sub

    Private Sub refreshCategoryDG()
        Dim query As String
        query = "SELECT * FROM tbl_category ORDER BY category_id ASC"
        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            itemCategory_dg.Rows.Add(New String() {reader.GetString("category_id"), reader.GetString("category_name")})
        End While
        reader.Close()
        closeConnection()
    End Sub

    Private Sub selectCategory_btn_Click(sender As Object, e As EventArgs) Handles selectCategory_btn.Click
        Dim i As Integer = itemCategory_dg.CurrentRow.Index
        items_category_txt.Text = itemCategory_dg.Item(1, i).Value
        itemsQuantity_txt.Visible = True
        itemCategory_panel.Visible = False
    End Sub

    Private Sub itemSearch_txt_OnTextChange(sender As Object, e As EventArgs) Handles itemSearch_txt.KeyPress

        Dim search As String
        search = "SELECT * FROM tbl_inventory, tbl_description, tbl_category " &
            "WHERE tbl_description.description_id = tbl_inventory.description_id AND tbl_category.category_id = tbl_inventory.category_id AND tbl_inventory.item_name LIKE '%" & itemSearch_txt.text & "%'"
        cmd = New MySqlCommand(search, con)
        openConnection()
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            reader.Read()
            items_name_txt.Text = reader.GetString("item_name")
            items_description_txt.Text = reader.GetString("description_name")
            items_category_txt.Text = reader.GetString("category_name")
            itemsQuantity_txt.Value = reader.GetString("quantity")
            items_ID = reader.GetString("inventory_ID")
            items_price_txt.Text = reader.GetString("inventory_price")
        Else
            MsgBox("Please search item name or item is not yet registered. Please check if the name is correct or item register item first. ")
        End If
        reader.Close()
        closeConnection()

        If itemSearch_txt.text = Nothing Then
            clearFields()
        End If
    End Sub

    Private Sub submitItemUpdate_btn_Click(sender As Object, e As EventArgs) Handles submitItemUpdate_btn.Click
        initializeItemsVariables()
        'checking description if exists else add to database
        Dim query As String
        query = "SELECT * FROM tbl_description WHERE description_name = '" & items_description & "'"
        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader
        If Not reader.HasRows Then
            descriptionID = Nothing
        Else
            reader.Read()
            descriptionID = reader.GetString("description_id")
            ' MsgBox(descriptionID)
            reader.Close()
            closeConnection()
        End If
        reader.Close()
        closeConnection()
        If descriptionID = Nothing Then
            Dim insertQuery As String
            insertQuery = "INSERT INTO tbl_description(description_name) VALUES ('" & items_description & "')"
            cmd = New MySqlCommand(insertQuery, con)
            Dim atad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            atad.Fill(dt)
            ' MsgBox("SUCCESS")
        End If

        'checking item category if exists return id else add to db
        Dim cat_query As String
        cat_query = "SELECT * FROM tbl_category WHERE category_name = '" & items_category & "'"
        openConnection()
        cmd = New MySqlCommand(cat_query, con)
        Dim cat_reader As MySqlDataReader
        cat_reader = cmd.ExecuteReader
        If Not cat_reader.HasRows Then
            cat_reader.Close()
            closeConnection()
            descriptionID = Nothing
            Dim insert_query As String
            insert_query = "INSERT INTO tbl_category(category_name) VALUES('" & items_category & "')"
            cmd = New MySqlCommand(insert_query, con)
            Dim atad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            atad.Fill(dt)
            ' MsgBox("INSERT")
        Else
            cat_reader.Read()
            categoryID = cat_reader.GetString("category_id")
            cat_reader.Close()
            closeConnection()
            'MsgBox(categoryID)
        End If

        'getting value for description & category ids
        If descriptionID = Nothing And categoryID = Nothing Then
            Dim getDesc_ID As String
            getDesc_ID = "SELECT description_id FROM tbl_description WHERE description_name = '" & items_description & "'"
            openConnection()
            cmd = New MySqlCommand(getDesc_ID, con)
            Dim reads As MySqlDataReader
            reads = cmd.ExecuteReader
            While reads.Read
                descriptionID = reads.GetString("description_id")
            End While
            reads.Close()
            closeConnection()

            Dim getCat_ID As String
            getCat_ID = "SELECT category_id FROM tbl_category WHERE category_name = '" & items_category & "'"

            openConnection()
            cmd = New MySqlCommand(getCat_ID, con)
            Dim cat_ID As MySqlDataReader
            cat_ID = cmd.ExecuteReader
            While cat_ID.Read
                categoryID = cat_ID.GetString("category_id")
            End While
            cat_ID.Close()
            closeConnection()
        End If

        Dim update As String
        update = "UPDATE tbl_inventory SET item_name = @itemName, category_id = @categoryID, description_id = @descriptionID, quantity = @quantity, inventory_price = @price WHERE inventory_id = @ID"

        cmd = New MySqlCommand(update, con)
        cmd.Parameters.AddWithValue("@itemName", items_name)
        cmd.Parameters.AddWithValue("@categoryID", categoryID)
        cmd.Parameters.AddWithValue("@descriptionID", descriptionID)
        cmd.Parameters.AddWithValue("@quantity", items_quantity)
        cmd.Parameters.AddWithValue("@price", items_price_txt.Text)
        cmd.Parameters.AddWithValue("@ID", items_ID)

        Dim adapt As New MySqlDataAdapter(cmd)
        Dim dtable As New DataTable
        adapt.Fill(dtable)
        MsgBox("Item information updated successfully.", MsgBoxStyle.Information, "Success")
        clearFields()

    End Sub

    Private Sub selectSupplier_btn_Click(sender As Object, e As EventArgs) Handles selectSupplier_btn.Click
        POsupplier_dg.Rows.Clear()
        POselectSupp_panel.BringToFront()
        POselectSupp_panel.Visible = True
        refreshSupplierDG()
    End Sub

    Private Sub refreshSupplierDG()
        Dim query As String
        query = "SELECT * FROM tbl_suppliers"
        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            POsupplier_dg.Rows.Add(New String() {reader.GetString("supplier_id"), reader.GetString("supplier_name"), reader.GetString("supplier_address"), reader.GetString("supplier_contactPerson"), reader.GetString("supplier_contactNumber")})
        End While
        reader.Close()
        closeConnection()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles POcancelSelectsupp_btn.Click
        POselectSupp_panel.SendToBack()
        POselectSupp_panel.Visible = False
    End Sub

    Private Sub POselectSupp_btn_Click(sender As Object, e As EventArgs) Handles POselectSupp_btn.Click
        Dim i As Integer
        i = POsupplier_dg.CurrentRow.Index

        supp_name_txt.Text = POsupplier_dg.Item(POsupp_name.Index, i).Value
        POselectSupp_panel.SendToBack()
        POselectSupp_panel.Visible = False
    End Sub

    Private Sub refreshItemsDG()
        Dim query As String
        query = "SELECT * FROM tbl_inventory, tbl_description, tbl_category " &
            "WHERE tbl_inventory.description_id = tbl_description.description_id AND tbl_inventory.category_id = tbl_category.category_ID"
        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            POitems_dg.Rows.Add(New String() {reader.GetString("inventory_id"), reader.GetString("item_name"), reader.GetString("description_name"), reader.GetString("category_name"), reader.GetString("quantity")})
        End While
        reader.Close()
        closeConnection()

    End Sub

    Private Sub selectItem_btn_Click(sender As Object, e As EventArgs) Handles selectItem_btn.Click
        POitems_dg.Rows.Clear()
        POselectItems_panel.BringToFront()
        POselectItems_panel.Visible = True
        refreshItemsDG()
    End Sub

    Private Sub BunifuThinButton23_Click_1(sender As Object, e As EventArgs) Handles POcancelSelectItem_btn.Click
        POselectItems_panel.SendToBack()
        POselectItems_panel.Visible = False
    End Sub

    Private Sub POselectItem_btn_Click(sender As Object, e As EventArgs) Handles POselectItem_btn.Click
        Dim i As Integer = POitems_dg.CurrentRow.Index
        Dim query As String
        query = "SELECT * FROM tbl_inventory, tbl_category, tbl_description " &
            "WHERE tbl_description.description_id = tbl_inventory.description_id AND tbl_category.category_id = tbl_inventory.category_id AND tbl_inventory.inventory_id = @id"
        openConnection()
        cmd = New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", POitems_dg.Item(0, i).Value)

        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            items_name = reader.GetString("item_name")
            items_description = reader.GetString("description_name")
            items_category = reader.GetString("category_name")
            items_ID = reader.GetString("inventory_id")
        End While
        reader.Close()
        closeConnection()

        'POlist_dg.Rows.Add(New String() {items_ID, items_name, items_description, items_category})
        POitem_ID_txt.Text = items_ID
        'MsgBox("id: " & items_ID & " name: " & items_name & " desc: " & items_description & " cat: " & items_category)


        'POitem_ID_txt.Text = POitems_dg.Item(POitem_ID.Index, i).Value
        'POitem_name_txt.Text = POitems_dg.Item(POitem_name.Index, i).Value

        POselectItems_panel.SendToBack()
        POselectItems_panel.Visible = False

    End Sub

    Private Sub cancelPO_btn_Click(sender As Object, e As EventArgs) Handles cancelPO_btn.Click
        clearFields()
        POlist_dg.Rows.Clear()
    End Sub

    Private Sub POitem_ID_txt_KeyPress(sender As Object, e As KeyEventArgs) Handles POitem_ID_txt.KeyDown

        If e.KeyCode = Keys.Enter Then
            additemToPO()
            POitem_ID_txt.Text = Nothing
            POitem_name_txt.Text = Nothing
            POitem_quantity_txt.Value = Nothing
        End If

    End Sub

    Private Sub POitem_name_txt_KeyDown(sender As Object, e As KeyEventArgs) Handles POitem_name_txt.KeyDown

        If e.KeyCode = Keys.Enter Then
            additemToPO()
            POitem_ID_txt.Text = Nothing
            POitem_name_txt.Text = Nothing
            POitem_quantity_txt.Value = Nothing
        End If

    End Sub

    Private Sub POlist_dg_KeyDown(sender As Object, e As KeyEventArgs) Handles POlist_dg.KeyDown
        If e.KeyCode = Keys.Delete Then
            Try
                POlist_dg.Rows.RemoveAt(POlist_dg.CurrentRow.Index)
            Catch ex As Exception
                MsgBox("No items to remove.", MsgBoxStyle.Exclamation, "Empty List")
            End Try

        End If

    End Sub

    Private Sub POitem_ID_txt_OnValueChanged(sender As Object, e As EventArgs) Handles POitem_ID_txt.OnValueChanged

        Dim search As String
        search = "SELECT item_name FROM tbl_inventory WHERE inventory_id = '" & POitem_ID_txt.Text & "'"
        openConnection()
        cmd = New MySqlCommand(search, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            POitem_name_txt.Text = reader.GetString("item_name")
        End While
        reader.Close()
        closeConnection()

        If POitem_ID_txt.Text = Nothing Then
            POitem_name_txt.Text = Nothing
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            POlist_dg.Rows.RemoveAt(POlist_dg.CurrentRow.Index)
        Catch ex As Exception
            MsgBox("No items to remove.", MsgBoxStyle.Exclamation, "Empty List")
        End Try
    End Sub

    Private Sub POlist_dg_MouseUp(sender As Object, e As MouseEventArgs) Handles POlist_dg.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(POlist_dg, e.Location)
        End If
    End Sub

    Private Sub BunifuThinButton23_Click_2(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        additemToPO()
    End Sub

    Private Sub additemToPO()

        If POitem_ID_txt.Text = Nothing Or POitem_name_txt.Text = Nothing Or POitem_quantity_txt.Value = 0 Then
            MsgBox("No items to add. Please fill all the fields.")
            Exit Sub
        Else

            Dim row As Integer = 0
            Dim added As Boolean = False
            While row <= POlist_dg.Rows.Count - 1
                If POitem_ID_txt.Text = POlist_dg.Item(0, row).Value Then
                    Dim qty As Integer
                    qty = Integer.Parse(POlist_dg.Item(4, row).Value) + Integer.Parse(POitem_quantity_txt.Value)
                    POlist_dg.Item(4, row).Value = qty
                    row = row + 1
                    added = True
                    If added = True Then
                        Exit While
                    End If
                Else
                    row = row + 1
                End If
            End While

            Dim query As String
            query = "SELECT * FROM tbl_inventory, tbl_description, tbl_category " &
                "WHERE tbl_inventory.description_id = tbl_description.description_id AND " &
                "tbl_category.category_id = tbl_inventory.category_id AND inventory_id = '" & POitem_ID_txt.Text & "'"
            openConnection()
            cmd = New MySqlCommand(query, con)
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader

            While reader.Read
                items_ID = reader.GetString("inventory_id")
                items_name = reader.GetString("item_name")
                items_description = reader.GetString("description_name")
                items_category = reader.GetString("category_name")
            End While
            reader.Close()
            closeConnection()

            If POlist_dg.Rows.Count = 0 And added = False Then
                POlist_dg.Rows.Add(New String() {items_ID, items_name, items_description, items_category, POitem_quantity_txt.Value})
            ElseIf Not POlist_dg.Rows.Count = 0 And added = False Then
                POlist_dg.Rows.Add(New String() {items_ID, items_name, items_description, items_category, POitem_quantity_txt.Value})
            End If
        End If
    End Sub

    Private Sub submitPO_btn_Click(sender As Object, e As EventArgs) Handles submitPO_btn.Click
        If supp_name_txt.Text = Nothing Then
            MsgBox("Please Enter Supplier Name.")
            Exit Sub
        Else
            Dim purchaseCode As String
            Dim query As String
            Dim dateToday As String = Date.Now.ToString("MM-dd-yyyy")
            Dim ran As New Random
            purchaseCode = generateRandomSring(ran)
            query = "INSERT INTO tbl_purchased(date_purchased, inventory_id, supplier_id, purchase_quantity, purchase_code) " &
                "VALUES (@date, @itemID, (SELECT supplier_id FROM tbl_suppliers WHERE supplier_name = '" & supp_name_txt.Text & "'), @qty, @code)"
            Dim index As Integer
            While POlist_dg.Rows.Count > index
                cmd = New MySqlCommand(query, con)

                cmd.Parameters.AddWithValue("@date", dateToday)
                cmd.Parameters.AddWithValue("@itemID", POlist_dg.Item(0, index).Value)
                cmd.Parameters.AddWithValue("@qty", POlist_dg.Item(4, index).Value)
                cmd.Parameters.AddWithValue("@code", purchaseCode)

                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                index = index + 1
            End While
            MsgBox("Succesfully added PO.")

            Dim query2 As String
            query2 = "INSERT INTO tbl_purchasedlist(date_purchased, supplier_id, purchase_code, purchase_status) " &
                "VALUES (@date, (SELECT supplier_id FROM tbl_suppliers WHERE supplier_name = '" & supp_name_txt.Text & "'), @code, @status)"
            cmd = New MySqlCommand(query2, con)

            cmd.Parameters.AddWithValue("@date", dateToday)
            cmd.Parameters.AddWithValue("@code", purchaseCode)
            cmd.Parameters.AddWithValue("@status", "TO DELIVER")

            Dim da2 As New MySqlDataAdapter(cmd)
            Dim dt2 As New DataTable
            da2.Fill(dt2)

            clearFields()
            Me.Refresh()
            POlist_dg.Rows.Clear()

            Dim report As New ReportDocument
            report.Load("C:\Users\LeakSun\Documents\Visual Studio 2012\Projects\SADPOS\SADPOS\purchaseReport.rpt")
            Dim paramFieldDefinitions As ParameterFieldDefinitions
            Dim paramFieldDefinition As ParameterFieldDefinition
            Dim paramValues As New ParameterValues
            Dim paramDiscreteValue As New ParameterDiscreteValue

            paramDiscreteValue.Value = purchaseCode
            paramFieldDefinitions = report.DataDefinition.ParameterFields
            paramFieldDefinition = paramFieldDefinitions.Item("purchaseCode")
            paramValues = paramFieldDefinition.CurrentValues

            paramValues.Clear()
            paramValues.Add(paramDiscreteValue)
            paramFieldDefinition.ApplyCurrentValues(paramValues)

            Dim reportVIew As New purchaseOrderReport
            reportVIew.CrystalReportViewer1.ReportSource = report
            reportVIew.CrystalReportViewer1.Refresh()
            reportVIew.Show()
        End If

    End Sub

    Private Sub refreshPOlistDG()
        inventoryPOs_dg.Rows.Clear()
        Dim query As String

        query = "SELECT * FROM tbl_suppliers, tbl_purchasedlist WHERE tbl_suppliers.supplier_id = tbl_purchasedlist.supplier_id AND purchase_code IS NOT NULL AND purchase_status = 'TO DELIVER'"
        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            poID = reader.GetString("purchaselist_id")
            supp_companyName = reader.GetString("supplier_name")
            poDate = reader.GetString("date_purchased")
            poStatus = reader.GetString("purchase_status")

            inventoryPOs_dg.Rows.Add(New String() {poID, supp_companyName, poDate, poStatus})
        End While
        reader.Close()
        closeConnection()



    End Sub

    Private Sub inventorySearch_txt_OnTextChange(sender As Object, e As EventArgs) Handles inventorySearch_txt.KeyPress
        inventoryPOs_dg.Rows.Clear()
        If Not inventorySearch_txt.text = Nothing Then
            Dim query As String
            query = "SELECT * FROM tbl_suppliers, tbl_purchasedlist WHERE tbl_purchasedlist.purchaselist_id LIKE '%" & inventorySearch_txt.text & "%' OR tbl_suppliers.supplier_name LIKE '%" & inventorySearch_txt.text & "%' AND tbl_purchasedlist.supplier_id = tbl_suppliers.supplier_id"
            openConnection()
            cmd = New MySqlCommand(query, con)
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader
            While reader.Read
                inventoryPOs_dg.Rows.Add(New String() {reader.GetString("purchaselist_id"), reader.GetString("supplier_name"), reader.GetString("date_purchased"), reader.GetString("purchase_status")})
            End While
            reader.Close()
            closeConnection()
        Else
            If inventorySearch_txt.text = Nothing Then
                refreshPOlistDG()
            End If
        End If

    End Sub

    Private Sub inventoryDate_txt_onValueChanged(sender As Object, e As EventArgs) Handles inventoryDate_txt.onValueChanged
        inventoryPOs_dg.Rows.Clear()
        inventoryDate_txt.Format = DateTimePickerFormat.Custom

        Dim formattedDate As String
        formattedDate = inventoryDate_txt.Value.Date.ToString("MM-dd-yyyy")
        ' MsgBox(formattedDate)
        Dim query As String
        query = "SELECT * FROM tbl_purchasedlist, tbl_suppliers WHERE tbl_purchasedlist.date_purchased = '" & formattedDate & "' AND tbl_purchasedlist.supplier_id = tbl_suppliers.supplier_id"
        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader
        ' If reader.HasRows Then
        While reader.Read
            If POlist_dg.ColumnCount > 1 Then
                inventoryPOs_dg.Rows.Add(New String() {reader.GetString("purchaselist_id"), reader.GetString("supplier_name"), reader.GetString("date_purchased"), reader.GetString("purchase_status")})
            End If
        End While
        reader.Close()
        closeConnection()
        'Else
        'reader.Close()
        ' closeConnection()
        'End If
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles inventorySetDeliver_btn.Click
        If deliver_panel.Visible = False Then
            deliver_panel.Visible = False
            delivery_transition.ShowSync(deliver_panel)
        Else
            delivery_transition.HideSync(deliver_panel)
        End If
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles inventorySubmit_btn.Click

        Dim i As Integer = inventoryPOs_dg.CurrentRow.Index
        Dim selectQuery As String
        selectQuery = "SELECT * FROM tbl_inventory, tbl_purchased, tbl_purchasedlist WHERE tbl_inventory.inventory_id = tbl_purchased.inventory_id AND tbl_purchasedlist.purchase_code = tbl_purchased.purchase_code AND tbl_purchasedlist.purchaselist_id = '" & inventoryPOs_dg.Item(0, i).Value & "' AND tbl_purchasedlist.purchase_status = 'TO DELIVER'"
        openConnection()
        cmd = New MySqlCommand(selectQuery, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        Dim index As Integer
        Dim qty(9999) As String
        Dim invent_qty(9999) As String
        Dim invent_id(9999) As String
        While reader.Read
            qty(index) = reader.GetString("purchase_quantity")
            invent_qty(index) = reader.GetString("quantity")
            invent_id(index) = reader.GetString("inventory_id")

            index = index + 1
        End While
        reader.Close()
        closeConnection()

        Dim ii As Integer
        While index > ii
            Dim qtyTemp As Integer
            qtyTemp = invent_qty(ii) + (qty(ii) - inventoryDamaged_txt.Value)
            qtyTemp = qtyTemp - inventoryLost_txt.Value

            'qtyTemp = Integer.Parse(invent_qty(ii)) + (Integer.Parse(qty(ii)) - inventoryDamaged_txt.Value)

            Dim update As String
            update = "UPDATE tbl_inventory SET quantity = '" & qtyTemp & "' WHERE inventory_id = '" & invent_id(ii) & "' "
            cmd = New MySqlCommand(update, con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable

            Dim updatepurchaselist As String
            updatepurchaselist = "UPDATE tbl_purchasedlist SET purchase_status = 'DELIVERED' WHERE purchaselist_id = '" & inventoryPOs_dg.Item(0, i).Value & "'"
            cmd = New MySqlCommand(updatepurchaselist, con)
            Dim da2 As New MySqlDataAdapter(cmd)
            Dim dt2 As New DataTable
            da2.Fill(dt2)
            da.Fill(dt)
            ii = ii + 1
        End While

        MsgBox("UPDATE SUCESS")
        inventoryPOs_dg.Rows.Clear()
        refreshPOlistDG()
        inventoryDamaged_txt.Value = 0
        delivery_transition.HideSync(deliver_panel)
    End Sub

    Private Sub viewCustomer_btn_Click(sender As Object, e As EventArgs) Handles viewCustomer_btn.Click
        hidePanels()
        viewCustomer_panel.BringToFront()
        viewCustomer_panel.Visible = True
    End Sub

    Private Sub customerSubmit_btn_Click(sender As Object, e As EventArgs) Handles customerSubmit_btn.Click
        initializeCustomerVariables()
        If customer_firstname = Nothing And customer_middleName = Nothing And customer_lastName = Nothing And customerGender_cbo.selectedIndex = 0 And customer_address = Nothing Then
            MsgBox("Please fill all fields.")
            Exit Sub
        ElseIf customer_firstname = Nothing Then
            MsgBox("Please Enter First Name.")
            Exit Sub
        ElseIf customer_middleName = Nothing Then
            MsgBox("Please Enter Middle Name.")
            Exit Sub
        ElseIf customer_lastName = Nothing Then
            MsgBox("Please Enter Last Name.")
            Exit Sub
        ElseIf customerGender_cbo.selectedIndex = 0 Then
            MsgBox("Please Select Gender.")
            Exit Sub
        ElseIf customer_address = Nothing Then
            MsgBox("Please Enter Address.")
            Exit Sub
        ElseIf customer_contactNumber = Nothing Then
            MsgBox("Please Enter Contact Number.")
            Exit Sub
        End If

        Dim query As String
        query = "INSERT INTO tbl_customers(customer_firstName, customer_middleName, customer_lastName, customer_address, customer_contactNumber, customer_gender) " &
            "VALUES (@fname, @mname, @lname, @address, @cnumber, @gender)"
        cmd = New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@fname", customer_firstname)
        cmd.Parameters.AddWithValue("@mname", customer_middleName)
        cmd.Parameters.AddWithValue("@lname", customer_lastName)
        cmd.Parameters.AddWithValue("@address", customer_address)
        cmd.Parameters.AddWithValue("@cnumber", customer_contactNumber)
        cmd.Parameters.AddWithValue("@gender", customer_gender)

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        MsgBox("Customer information addedd successfully.")
        clearCustomerFields()
    End Sub

    Private Sub initializeCustomerVariables()
        customer_firstname = customerFname_txt.Text
        customer_middleName = customerMname_txt.Text
        customer_lastName = customerLname_txt.Text
        customer_gender = customerGender_cbo.selectedValue
        customer_address = customerAddress_txt.Text
        customer_contactNumber = customerContactNumber_txt.Text
    End Sub
    Private Sub clearCustomerFields()
        customerFname_txt.Text = Nothing
        customerMname_txt.Text = Nothing
        customerLname_txt.Text = Nothing
        customerGender_cbo.selectedIndex = 0
        customerAddress_txt.Text = Nothing
        customerContactNumber_txt.Text = Nothing
        customer_search_txt.text = Nothing
    End Sub

    Private Sub customerCancel_btn_Click(sender As Object, e As EventArgs) Handles customerCancel_btn.Click
        initializeCustomerVariables()
        If Not customer_firstname = Nothing Or Not customer_middleName = Nothing Or Not customer_lastName = Nothing Or Not customer_address = Nothing Or Not customer_contactNumber = Nothing Or Not customerGender_cbo.selectedIndex = 0 Then
            If MessageBox.Show("Do you want to discard your changes?", "Discard Changes?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                clearCustomerFields()
            End If
        Else
            clearCustomerFields()
        End If

    End Sub

    Private Sub customer_search_txt_OnTextChange(sender As Object, e As EventArgs) Handles customer_search_txt.KeyPress
        Dim search As String
        search = "SELECT * FROM tbl_customers WHERE customer_id LIKE '%" & customer_search_txt.text & "%' OR customer_firstName LIKE '%" & customer_search_txt.text & "%' OR customer_middleName LIKE '%" & customer_search_txt.text & "%' OR customer_lastName LIKE '%" & customer_search_txt.text & "%'"

        openConnection()
        cmd = New MySqlCommand(search, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            customerFname_txt.Text = reader.GetString("customer_firstName")
            customerMname_txt.Text = reader.GetString("customer_middleName")
            customerLname_txt.Text = reader.GetString("customer_lastName")
            If reader.GetString("customer_gender") = "MALE" Then
                customerGender_cbo.selectedIndex = 1
            Else
                customerGender_cbo.selectedIndex = 2
            End If
            ' customerGender_cbo.Text = reader.GetString("customer_gender")
            customerAddress_txt.Text = reader.GetString("customer_address")
            customerContactNumber_txt.Text = reader.GetString("customer_contactNumber")
            customer_id = reader.GetString("customer_id")
        End While
        reader.Close()
        closeConnection()


        If customer_search_txt.text = Nothing Then
            clearCustomerFields()
        End If

    End Sub

    Private Sub customerUpdate_btn_Click(sender As Object, e As EventArgs) Handles customerUpdate_btn.Click
        initializeCustomerVariables()
        If customer_firstname = Nothing And customer_middleName = Nothing And customer_lastName = Nothing And customerGender_cbo.selectedIndex = 0 And customer_address = Nothing Then
            MsgBox("Please fill all fields.")
            Exit Sub
        ElseIf customer_firstname = Nothing Then
            MsgBox("Please Enter First Name.")
            Exit Sub
        ElseIf customer_middleName = Nothing Then
            MsgBox("Please Enter Middle Name.")
            Exit Sub
        ElseIf customer_lastName = Nothing Then
            MsgBox("Please Enter Last Name.")
            Exit Sub
        ElseIf customerGender_cbo.selectedIndex = 0 Then
            MsgBox("Please Select Gender.")
            Exit Sub
        ElseIf customer_address = Nothing Then
            MsgBox("Please Enter Address.")
            Exit Sub
        ElseIf customer_contactNumber = Nothing Then
            MsgBox("Please Enter Contact Number.")
            Exit Sub
        End If

        Dim update As String
        update = "UPDATE tbl_customers SET customer_firstName = @fname, customer_middleName = @mname, customer_lastName = @lname, customer_address = @address, customer_gender = @gender, customer_contactNumber = @number WHERE customer_id = @id"

        cmd = New MySqlCommand(update, con)
        cmd.Parameters.AddWithValue("@fname", customer_firstname)
        cmd.Parameters.AddWithValue("@mname", customer_middleName)
        cmd.Parameters.AddWithValue("@lname", customer_lastName)
        cmd.Parameters.AddWithValue("@address", customer_address)
        cmd.Parameters.AddWithValue("@gender", customer_gender)
        cmd.Parameters.AddWithValue("@number", customer_contactNumber)
        cmd.Parameters.AddWithValue("@id", customer_id)

        Dim adapt As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        adapt.Fill(dt)

        MsgBox("Customer information updated successfully.")
        clearCustomerFields()
    End Sub


    Private Sub viewCustomerSearch_txt_OnTextChange(sender As Object, e As EventArgs) Handles viewCustomerSearch_txt.OnTextChange

        If viewCustomerSearch_txt.text = Nothing Then
            viewCustomerName_txt.Text = Nothing
            viewCustomerAddress_txt.Text = Nothing
            viewCustomerContactNumber_txt.Text = Nothing
            customerPurchases_dg.Rows.Clear()
        Else
            If customerCash_txt.Checked Then
                purchaseType = customerCash_txt.Text
            Else
                purchaseType = customerCharge_txt.Text
            End If
            customerPurchases_dg.Rows.Clear()
            Dim search As String
            search = "SELECT * FROM tbl_customers WHERE customer_id LIKE '%" & viewCustomerSearch_txt.text & "%' OR customer_firstName LIKE '%" & viewCustomerSearch_txt.text & "%' OR customer_middleName LIKE '%" & viewCustomerSearch_txt.text & "%' OR customer_lastName LIKE '%" & viewCustomerSearch_txt.text & "%' "
            openConnection()
            cmd = New MySqlCommand(search, con)
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader

            While reader.Read
                viewCustomerName_txt.Text = reader.GetString("customer_lastName") & ", " & reader.GetString("customer_firstName") & " " & reader.GetString("customer_middleName")
                viewCustomerAddress_txt.Text = reader.GetString("customer_address")
                viewCustomerContactNumber_txt.Text = reader.GetString("customer_contactNumber")
                customer_id = reader.GetString("customer_ID")
            End While
            reader.Close()
            closeConnection()

            Dim query As String
            query = "SELECT * FROM tbl_order, tbl_customers, tbl_inventory WHERE tbl_order.customer_id = tbl_customers.customer_id AND tbl_inventory.inventory_id = tbl_order.inventory_id AND tbl_customers.customer_id = '" & customer_id & "' AND purchase_type = '" & purchaseType & "'"
            openConnection()
            cmd = New MySqlCommand(query, con)
            Dim readerr As MySqlDataReader
            readerr = cmd.ExecuteReader
            While readerr.Read
                customerPurchases_dg.Rows.Add(New String() {readerr.GetString("date_purchased"), readerr.GetString("item_name"), readerr.GetString("price"), readerr.GetString("quantity")})
            End While
            readerr.Close()
            closeConnection()

        End If
      
    End Sub

    Private Function generateRandomSring(r As Random)
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(6, 6)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function

    Private Sub checkout_btn_Click(sender As Object, e As EventArgs) Handles checkout_btn.Click
        If salesCustomerName_txt.Text = Nothing Then
            MsgBox("Please select customer first.")
            Exit Sub
        ElseIf item_dg.Rows.Count = 0 Then
            MsgBox("Please select item first.")
            Exit Sub
        End If

        Dim ran As New Random
        Dim transactionCode As String = generateRandomSring(ran)
        Dim VAT As Double
        Dim dateToday As String = Date.Now.ToString("MM-dd-yyyy")
        Dim cash As Double
        Dim change As Double
        total = total_price_txt.Text
        VAT = total / 1.12 * 0.12
        Dim net As Double
        net = total - VAT
        
        If cash_rdo.Checked Then
            If cash_txt.Text = Nothing Then
                MsgBox("Please enter cash.")
                Exit Sub
            End If
        End If

        If change < 0 Then
            MsgBox("Not enough cash. Please check if you have entered the correct amount.")
            Exit Sub
        End If

        Dim purchase_type As String
        If cash_rdo.Checked Then
            purchase_type = cash_rdo.Text
            cash = Double.Parse(cash_txt.Text)
            change = cash - total
            change_txt.Text = change
        Else
            purchase_type = charge_rdo.Text
        End If

        Dim insert As String
        insert = "INSERT INTO tbl_order(customer_id, inventory_id, quantity, price, date_purchased, transaction_id, sales_VAT, sales_grossTotal, sales_netTotal, purchase_type) " &
            "VALUES (@customerID, @inventoryID, @qty, @price, @date, @transactionID, @VAT, @gross, @net, @type)"

        Dim updateQty As String
        updateQty = "UPDATE tbl_inventory SET quantity = (quantity - @qty) WHERE inventory_id = @inventoryID"
        Dim index As Integer = 0
        Dim i As Integer = salesCustomer_dg.CurrentRow.Index
        While item_dg.Rows.Count > index
            cmd = New MySqlCommand(insert, con)

            cmd.Parameters.AddWithValue("@customerID", salesCustomer_dg.Item(0, i).Value)
            cmd.Parameters.AddWithValue("@inventoryID", item_dg.Item(0, index).Value)
            cmd.Parameters.AddWithValue("@qty", item_dg.Item(5, index).Value)
            cmd.Parameters.AddWithValue("@price", item_dg.Item(4, index).Value)
            cmd.Parameters.AddWithValue("@date", dateToday)
            cmd.Parameters.AddWithValue("@transactionID", transactionCode)
            cmd.Parameters.AddWithValue("@VAT", VAT)
            cmd.Parameters.AddWithValue("@gross", total)
            cmd.Parameters.AddWithValue("@net", net)
            cmd.Parameters.AddWithValue("@type", purchase_type)

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            cmd = New MySqlCommand(updateQty, con)
            cmd.Parameters.AddWithValue("@qty", item_dg.Item(5, index).Value)
            cmd.Parameters.AddWithValue("@inventoryID", item_dg.Item(0, index).Value)

            Dim updateAD As New MySqlDataAdapter(cmd)
            Dim updateDT As New DataTable
            updateAD.Fill(updateDT)

            index = index + 1
        End While

        MsgBox("Purchase Complete.")
        clearFields()
        item_dg.Rows.Clear()
        cash_txt.Text = Nothing
        total_price_txt.Text = "0.0"
        change_txt.Text = "0.0"
        Dim report As New ReportDocument
        If cash_rdo.Checked Then
            report.Load("C:\Users\LeakSun\Documents\Visual Studio 2012\Projects\SADPOS\SADPOS\reciept.rpt")
        Else
            report.Load("C:\Users\LeakSun\Documents\Visual Studio 2012\Projects\SADPOS\SADPOS\chargeInvoice.rpt")
        End If
        Dim paramFieldDefinitions As ParameterFieldDefinitions
        Dim paramFieldDefinition As ParameterFieldDefinition
        Dim paramValues As New ParameterValues
        Dim paramDiscreteValue As New ParameterDiscreteValue

        paramDiscreteValue.Value = transactionCode
        paramFieldDefinitions = report.DataDefinition.ParameterFields
        paramFieldDefinition = paramFieldDefinitions.Item("transactionCode")
        paramValues = paramFieldDefinition.CurrentValues

        paramValues.Clear()
        paramValues.Add(paramDiscreteValue)
        paramFieldDefinition.ApplyCurrentValues(paramValues)

        Dim reportVIew As New receipt
        reportVIew.CrystalReportViewer1.ReportSource = report
        reportVIew.CrystalReportViewer1.Refresh()
        reportVIew.Show()

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles salesSelectCustomer_btn.Click
        salesCustomer_dg.Rows.Clear()

        salesCustomer_panel.BringToFront()
        salesCustomer_panel.Visible = True

        Dim selectquery As String
        selectquery = "SELECT * FROM tbl_customers"
        openConnection()
        cmd = New MySqlCommand(selectquery, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            salesCustomer_dg.Rows.Add(New String() {reader.GetString("customer_id"), reader.GetString("customer_lastName") & ", " & reader.GetString("customer_firstName") & " " & reader.GetString("customer_middleName"), reader.GetString("customer_address"), reader.GetString("customer_contactNumber"), reader.GetString("customer_gender")})
        End While
        reader.Close()
        closeConnection()
    End Sub

    Private Sub BunifuThinButton24_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        salesCustomer_panel.SendToBack()
        salesCustomer_panel.Visible = False
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim i As Integer = salesCustomer_dg.CurrentRow.Index
        salesCustomerName_txt.Text = salesCustomer_dg.Item(1, i).Value
        salesCustomer_panel.SendToBack()
        salesCustomer_panel.Visible = False
    End Sub

    
    Private Sub salesSelectItems_btn_Click(sender As Object, e As EventArgs) Handles salesSelectItems_btn.Click
        salesItem_panel.BringToFront()
        salesItem_panel.Visible = True

        salesItem_dg.Rows.Clear()

        Dim query As String
        query = "SELECT * FROM tbl_inventory, tbl_category, tbl_description WHERE tbl_inventory.category_id = tbl_category.category_id AND tbl_inventory.description_id = tbl_description.description_id"

        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            salesItem_dg.Rows.Add(New String() {reader.GetString("inventory_id"), reader.GetString("item_name"), reader.GetString("description_name"), reader.GetString("category_name"), reader.GetString("inventory_price"), reader.GetString("quantity")})
        End While
        reader.Close()
        closeConnection()
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        salesItem_panel.SendToBack()
        salesItem_panel.Visible = False
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        Dim i As Integer = salesItem_dg.CurrentRow.Index

        item_id_txt.Text = salesItem_dg.Item(0, i).Value
        item_name_txt.Text = salesItem_dg.Item(1, i).Value

        salesItem_panel.SendToBack()
        salesItem_panel.Visible = False
    End Sub

    Private Sub item_id_txt_OnValueChanged(sender As Object, e As EventArgs) Handles item_id_txt.OnValueChanged
        Dim query As String
        query = "SELECT item_name FROM tbl_inventory WHERE inventory_id = '" & item_id_txt.Text & "'"
        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            item_name_txt.Text = reader.GetString("item_name")
        End While
        reader.Close()
        closeConnection()

        If item_id_txt.Text = Nothing Then
            item_name_txt.Text = Nothing
        End If

    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        If item_id_txt.Text = Nothing Or item_name_txt.Text = Nothing Then
            MsgBox("Please Select item first.")
            Exit Sub
        ElseIf quantity_txt.Value = 0 Then
            MsgBox("Please enter quantity.")
            Exit Sub
        End If
        
        
        Dim selectquery As String
        selectquery = "SELECT * FROM tbl_inventory, tbl_category, tbl_description WHERE tbl_inventory.category_id = tbl_category.category_id AND tbl_inventory.description_id = tbl_description.description_id AND inventory_id = '" & item_id_txt.Text & "'"
        openConnection()
        cmd = New MySqlCommand(selectquery, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            itemID = reader.GetString("inventory_ID")
            itemName = reader.GetString("item_name")
            itemDescription = reader.GetString("description_name")
            itemCategory = reader.GetString("category_name")
            itemPrice = reader.GetDouble("inventory_price")
        End While
        reader.Close()
        closeConnection()

        qty = quantity_txt.Value
        price = Double.Parse(itemPrice) * qty
        total = total + price
        total_price_txt.Text = total

        Dim row As Integer = 0
        Dim added As Boolean = False
        While row <= item_dg.Rows.Count - 1
            If item_id_txt.Text = item_dg.Item(0, row).Value Then
                Dim rqty As Integer
                rqty = Integer.Parse(item_dg.Item(5, row).Value) + Integer.Parse(quantity_txt.Value)
                item_dg.Item(5, row).Value = rqty
                row = row + 1
                added = True
                If added = True Then
                    Exit While
                End If
            Else
                row = row + 1
            End If
        End While

        If item_dg.Rows.Count = 0 And added = False Then
            item_dg.Rows.Add(New String() {itemID, itemName, itemDescription, itemCategory, itemPrice, qty})
        ElseIf Not item_dg.Rows.Count = 0 And added = False Then
            item_dg.Rows.Add(New String() {itemID, itemName, itemDescription, itemCategory, itemPrice, qty})
        End If

        item_id_txt.Text = Nothing
        item_name_txt.Text = Nothing
        quantity_txt.Value = 0
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        inventoryDamaged_txt.Value = 0
        delivery_transition.HideSync(deliver_panel)
    End Sub

    Private Sub BunifuFlatButton5_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim i As Integer = inventoryPOs_dg.CurrentRow.Index
        If MessageBox.Show("Are you sure you want to cancel this P.O.? This can't be undone.", "Cancel PO?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If inventoryPOs_dg.Item(3, i).Value = ("DELIVERED") Or inventoryPOs_dg.Item(3, i).Value = ("CANCELED") Then
                MsgBox("Failed to cancel PO. PO already Delivered/Canceled.")
                Exit Sub
            Else
                Dim query As String
                query = "UPDATE tbl_purchasedList SET purchase_status = 'CANCELED' WHERE purchaselist_id = '" & inventoryPOs_dg.Item(0, i).Value & "'"

                cmd = New MySqlCommand(query, con)
                Dim ada As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable

                ada.Fill(dt)
                refreshPOlistDG()
            End If
            
        End If
    End Sub

    Private Sub inventoryView_btn_Click(sender As Object, e As EventArgs) Handles inventoryView_btn.Click
        If inventoryItems_dg.Visible = False Then
            inventoryItems_dg.Rows.Clear()
            inventoryItems_dg.BringToFront()
            inventoryItems_dg.Visible = True
            inventoryView_btn.Text = "View PO List"
            Dim i As Integer = inventoryPOs_dg.CurrentRow.Index
            ' If Not i = 0 Then
            Dim query As String
            query = "SELECT * FROM tbl_purchased, tbl_purchasedList, tbl_inventory, tbl_category, tbl_description WHERE tbl_purchased.purchase_code = tbl_purchasedlist.purchase_code AND tbl_purchased.inventory_id = tbl_inventory.inventory_id AND tbl_inventory.description_id = tbl_description.description_id AND tbl_category.category_id = tbl_inventory.category_id AND tbl_purchasedlist.purchaselist_id = '" & inventoryPOs_dg.Item(0, i).Value & "' "
            openConnection()
            cmd = New MySqlCommand(query, con)
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader
            While reader.Read
                inventoryItems_dg.Rows.Add(New String() {reader.GetString("inventory_id"), reader.GetString("item_name"), reader.GetString("description_name"), reader.GetString("category_name"), reader.GetString("purchase_quantity")})
            End While
            reader.Close()
            closeConnection()
            BunifuFlatButton5.Enabled = False
            'Else
            ' MsgBox("Please select listed PO first.")
            ' Exit Sub
            '  End If

        Else
            inventoryItems_dg.Visible = False
            BunifuFlatButton5.Enabled = True
            inventoryView_btn.Text = "View PO Items"
        End If

    End Sub

    Private Sub inventoryPOs_dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles inventoryPOs_dg.CellContentClick
        inventoryView_btn.Enabled = True
    End Sub

    Private Sub inventoryPurchaseStatus_cbo_onItemSelected(sender As Object, e As EventArgs) Handles inventoryPurchaseStatus_cbo.onItemSelected
        inventoryPOs_dg.Rows.Clear()
        Dim query As String
        query = "SELECT * FROM tbl_purchasedlist, tbl_suppliers WHERE tbl_suppliers.supplier_id = tbl_purchasedlist.supplier_id AND tbl_purchasedlist.purchase_status = '" & inventoryPurchaseStatus_cbo.selectedValue & "'"

        If inventoryPOs_dg.Columns.Count > 0 Then
            openConnection()
            cmd = New MySqlCommand(query, con)
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader
            While reader.Read
                inventoryPOs_dg.Rows.Add(New String() {reader.GetString("purchaselist_id"), reader.GetString("supplier_name"), reader.GetString("date_purchased"), reader.GetString("purchase_status")})
            End While
            reader.Close()
            closeConnection()
        End If


    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles stocks_btn.Click
        Chart1.Series("Series1").Points.Clear()
        inventoryItemList_dg.Rows.Clear()

        inventoryItemList_dg.BringToFront()
        inventoryItemList_dg.Visible = True
        inventoryGraph_panel.BringToFront()
        inventoryGraph_panel.Visible = True

        Dim query As String
        query = "SELECT * FROM tbl_inventory, tbl_description, tbl_category WHERE tbl_inventory.description_id = tbl_description.description_id AND tbl_category.category_id = tbl_inventory.category_id"
        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            inventoryItemList_dg.Rows.Add(New String() {reader.GetString("inventory_id"), reader.GetString("item_name"), reader.GetString("description_name"), reader.GetString("category_name"), reader.GetString("quantity")})
        End While
        reader.Close()
        closeConnection()


    End Sub

    Private Sub stockIn_btn_Click(sender As Object, e As EventArgs) Handles stockIn_btn.Click
        Chart1.Series("Series1").Points.Clear()
        inventoryItemList_dg.Visible = False
        inventoryGraph_panel.Visible = False
        refreshPOlistDG()
    End Sub

    Private Sub inventoryItemList_dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles inventoryItemList_dg.CellContentClick
        Chart1.Series("Series1").Points.Clear()
        Dim i As Integer = inventoryItemList_dg.CurrentRow.Index
        Dim query As String
        query = "SELECT quantity FROM tbl_inventory WHERE inventory_id = '" & inventoryItemList_dg.Item(0, i).Value & "'"
        openConnection()
        cmd = New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        Dim qty As String
        While reader.Read
            qty = reader.GetString("quantity")
        End While
        reader.Close()
        closeConnection()

        Chart1.Series("Series1").Points.AddXY(inventoryItemList_dg.Item(1, i).Value, qty)

        If qty > 60 Then
            Chart1.Series("Series1").Color = Color.LightGreen
        ElseIf qty <= 59 And qty >= 30 Then
            Chart1.Series("Series1").Color = Color.Yellow
        ElseIf qty > 0 And qty <= 29 Then
            Chart1.Series("Series1").Color = Color.Red
        End If


        inventoryItemList_dg.BringToFront()
        inventoryItemList_dg.Visible = True
        inventoryGraph_panel.Visible = True

    End Sub

    Private Sub BunifuThinButton28_Click(sender As Object, e As EventArgs) Handles BunifuThinButton28.Click
        Dim file As String
        file = "Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"

        Dim backup As New Process
        backup.StartInfo.FileName = "cmd.exe"
        backup.StartInfo.UseShellExecute = False
        backup.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"
        backup.StartInfo.RedirectStandardInput = True
        backup.StartInfo.RedirectStandardOutput = True
        backup.Start()
        Dim sw As StreamWriter = backup.StandardInput
        Dim sr As StreamReader = backup.StandardOutput
        sw.WriteLine("mysqldump -u root --password= -h 127.0.0.1 ""sad"" > """ + file + """ ")
        sw.Close()
        backup.WaitForExit()
        backup.Close()
            MsgBox("Backup Created Successfully!", MsgBoxStyle.Information, "Backup")
    End Sub

    Private Sub BunifuThinButton27_Click(sender As Object, e As EventArgs) Handles BunifuThinButton27.Click
        Dim file As String
        opd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        If opd.ShowDialog = DialogResult.OK Then
            file = opd.FileName
            Dim myProcess As New Process
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("mysql -u root --password= -h 127.0.0.1 ""sad"" < """ + file + """ ")
            myStreamWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()
            MsgBox("Database Restoration Successfully!", MsgBoxStyle.Information, "Restore")
        End If
    End Sub

    Private Sub BunifuThinButton211_Click(sender As Object, e As EventArgs) Handles BunifuThinButton211.Click
        Dim startDate As String = repStartDate_dt.Value.ToString("MM-dd-yyyy")
        Dim endDate As String = repEndDate_dt.Value.ToString("MM-dd-yyyy")
        Dim total As Double
        Dim grossTotal As Double
        Dim VAT As Double
        Dim netTotal As Double

        Dim quert As String
        quert = "SELECT * FROM tbl_order, tbl_inventory, tbl_description, tbl_category WHERE tbl_order.inventory_id = tbl_inventory.inventory_id AND tbl_inventory.description_id = tbl_description.description_id AND tbl_category.category_id = tbl_inventory.category_id AND tbl_order.date_purchased BETWEEN '" & startDate & "' AND '" & endDate & "' AND purchase_type = 'Cash'"
        openConnection()
        cmd = New MySqlCommand(quert, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            total = reader.GetString("price") * reader.GetString("quantity")
            grossTotal = grossTotal + total
        End While
        reader.Close()
        closeConnection()

        VAT = grossTotal / 1.12 * 0.12
        netTotal = grossTotal - VAT

        Dim report As New ReportDocument
        report.Load("C:\Users\LeakSun\Documents\Visual Studio 2012\Projects\SADPOS\SADPOS\salesReportDoc.rpt")
        Dim paramFieldDefinitions As ParameterFieldDefinitions
        Dim paramFieldDefinition As ParameterFieldDefinition
        Dim paramValues As New ParameterValues
        Dim paramDiscreteValue As New ParameterDiscreteValue

        Dim paramFieldDefinitions2 As ParameterFieldDefinitions
        Dim paramFieldDefinition2 As ParameterFieldDefinition
        Dim paramValues2 As New ParameterValues
        Dim paramDiscreteValue2 As New ParameterDiscreteValue

        Dim paramFieldDefinitions3 As ParameterFieldDefinitions
        Dim paramFieldDefinition3 As ParameterFieldDefinition
        Dim paramValues3 As New ParameterValues
        Dim paramDiscreteValue3 As New ParameterDiscreteValue

        Dim paramFieldDefinitions4 As ParameterFieldDefinitions
        Dim paramFieldDefinition4 As ParameterFieldDefinition
        Dim paramValues4 As New ParameterValues
        Dim paramDiscreteValue4 As New ParameterDiscreteValue

        Dim paramFieldDefinitions5 As ParameterFieldDefinitions
        Dim paramFieldDefinition5 As ParameterFieldDefinition
        Dim paramValues5 As New ParameterValues
        Dim paramDiscreteValue5 As New ParameterDiscreteValue

        paramDiscreteValue.Value = startDate
        paramFieldDefinitions = report.DataDefinition.ParameterFields
        paramFieldDefinition = paramFieldDefinitions.Item("startDate")
        paramValues = paramFieldDefinition.CurrentValues

        paramValues.Clear()
        paramValues.Add(paramDiscreteValue)
        paramFieldDefinition.ApplyCurrentValues(paramValues)

        paramDiscreteValue2.Value = endDate
        paramFieldDefinitions2 = report.DataDefinition.ParameterFields
        paramFieldDefinition2 = paramFieldDefinitions.Item("endDate")
        paramValues2 = paramFieldDefinition2.CurrentValues

        paramValues2.Clear()
        paramValues2.Add(paramDiscreteValue2)
        paramFieldDefinition2.ApplyCurrentValues(paramValues2)

        paramDiscreteValue3.Value = grossTotal
        paramFieldDefinitions3 = report.DataDefinition.ParameterFields
        paramFieldDefinition3 = paramFieldDefinitions3.Item("grossTotal")
        paramValues3 = paramFieldDefinition3.CurrentValues

        paramValues3.Clear()
        paramValues3.Add(paramDiscreteValue3)
        paramFieldDefinition3.ApplyCurrentValues(paramValues3)

        paramDiscreteValue4.Value = VAT
        paramFieldDefinitions4 = report.DataDefinition.ParameterFields
        paramFieldDefinition4 = paramFieldDefinitions4.Item("VAT")
        paramValues4 = paramFieldDefinition4.CurrentValues

        paramValues4.Clear()
        paramValues4.Add(paramDiscreteValue4)
        paramFieldDefinition4.ApplyCurrentValues(paramValues4)

        paramDiscreteValue5.Value = netTotal
        paramFieldDefinitions5 = report.DataDefinition.ParameterFields
        paramFieldDefinition5 = paramFieldDefinitions5.Item("netTotal")
        paramValues5 = paramFieldDefinition5.CurrentValues

        paramValues5.Clear()
        paramValues5.Add(paramDiscreteValue5)
        paramFieldDefinition5.ApplyCurrentValues(paramValues5)

        Dim salesReport As New salesReport

        salesReport.CrystalReportViewer1.ReportSource = report
        salesReport.CrystalReportViewer1.Refresh()
        salesReport.Show()


    End Sub

    Private Sub BunifuThinButton215_Click(sender As Object, e As EventArgs) Handles BunifuThinButton215.Click
        Dim report As New ReportDocument
        report.Load("C:\Users\LeakSun\Documents\Visual Studio 2012\Projects\SADPOS\SADPOS\inventoryReportDoc.rpt")

        Dim inventoryReport As New inventoryReport
        Dim dated As String = Date.Today.ToString("MM-dd-yyyy")

        inventoryReport.CrystalReportViewer1.ReportSource = report
        inventoryReport.CrystalReportViewer1.Refresh()
        inventoryReport.Show()

        Dim reportToWord As New inventoryReportDoc
        Dim reportExport As String = Constants.folderPath & "\" & dated & " InventoryReport.doc"

        reportToWord.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
        reportToWord.ExportOptions.ExportFormatType = ExportFormatType.WordForWindows

        Dim diskOptions As DiskFileDestinationOptions = New DiskFileDestinationOptions()
        diskOptions.DiskFileName = reportExport
        reportToWord.ExportOptions.DestinationOptions = diskOptions
        reportToWord.Export()

        diskOptions = Nothing
        reportToWord = Nothing

        MsgBox("Inventory report created in " & reportExport)
    End Sub

   
    Private Sub item_dg_MouseUp(sender As Object, e As MouseEventArgs) Handles item_dg.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip2.Show(item_dg, e.Location)
        End If
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        Try
            item_dg.Rows.RemoveAt(item_dg.CurrentRow.Index)
        Catch ex As Exception
            MsgBox("No items to remove.", MsgBoxStyle.Exclamation, "Empty List")
        End Try
    End Sub

    Private Sub item_dg_KeyDown(sender As Object, e As KeyEventArgs) Handles item_dg.KeyDown
        If e.KeyCode = Keys.Delete Then
            Try
                item_dg.Rows.RemoveAt(item_dg.CurrentRow.Index)
            Catch ex As Exception
                MsgBox("No items to remove.", MsgBoxStyle.Exclamation, "Empty List")
            End Try

        End If
    End Sub

    Private Sub cash_rdo_CheckedChanged(sender As Object, e As EventArgs) Handles cash_rdo.CheckedChanged
        If cash_rdo.Checked Then
            charge_rdo.Checked = False
            cash_txt.Visible = True
            change_txt.Visible = True
            Label51.Visible = True
            Label53.Visible = True
        End If
    End Sub

    Private Sub charge_rdo_CheckedChanged(sender As Object, e As EventArgs) Handles charge_rdo.CheckedChanged
        If charge_rdo.Checked Then
            cash_rdo.Checked = False
            cash_txt.Visible = False
            change_txt.Visible = False
            Label51.Visible = False
            Label53.Visible = False
        End If
    End Sub

    Private Sub customerCash_txt_CheckedChanged(sender As Object, e As EventArgs) Handles customerCash_txt.CheckedChanged
        If customerCash_txt.Checked Then
            customerCharge_txt.Checked = False
            purchaseType = customerCash_txt.Text

            customerPurchases_dg.Rows.Clear()
            Dim query As String
            query = "SELECT * FROM tbl_order, tbl_customers, tbl_inventory WHERE tbl_order.customer_id = tbl_customers.customer_id AND tbl_inventory.inventory_id = tbl_order.inventory_id AND tbl_customers.customer_id = '" & customer_id & "' AND purchase_type = '" & purchaseType & "'"
            openConnection()
            cmd = New MySqlCommand(query, con)
            Dim readerr As MySqlDataReader
            readerr = cmd.ExecuteReader
            While readerr.Read
                customerPurchases_dg.Rows.Add(New String() {readerr.GetString("date_purchased"), readerr.GetString("item_name"), readerr.GetString("price"), readerr.GetString("quantity")})
            End While
            readerr.Close()
            closeConnection()
        End If
    End Sub

    Private Sub customerCharge_txt_CheckedChanged(sender As Object, e As EventArgs) Handles customerCharge_txt.CheckedChanged
        If customerCharge_txt.Checked Then
            customerCash_txt.Checked = False
            purchaseType = customerCharge_txt.Text

            customerPurchases_dg.Rows.Clear()
            Dim query As String
            query = "SELECT * FROM tbl_order, tbl_customers, tbl_inventory WHERE tbl_order.customer_id = tbl_customers.customer_id AND tbl_inventory.inventory_id = tbl_order.inventory_id AND tbl_customers.customer_id = '" & customer_id & "' AND purchase_type = '" & purchaseType & "'"
            openConnection()
            cmd = New MySqlCommand(query, con)
            Dim readerr As MySqlDataReader
            readerr = cmd.ExecuteReader
            While readerr.Read
                customerPurchases_dg.Rows.Add(New String() {readerr.GetString("date_purchased"), readerr.GetString("item_name"), readerr.GetString("price"), readerr.GetString("quantity")})
            End While
            readerr.Close()
            closeConnection()
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim query As String
        query = "SELECT * FROM tbl_inventory"
        openConnection()
        Dim low As Boolean
        Dim cmd As New MySqlCommand(query, con)
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            If reader.GetString("quantity") < 20 Then
                low = True
            End If
        End While
        reader.Close()
        closeConnection()
        If low = True Then
            MsgBox("Warning! An item is in LOW status. Please check the inventory and submit a Purchase Order.", MsgBoxStyle.OkOnly, "Item LOW Status.")
            ' CreateObject("WScript.Shell").Popup("Warning! An item is in LOW status. Please check the inventory and submit a Purchase Order.", 5, "Item LOW Status.")
        End If
    End Sub

End Class