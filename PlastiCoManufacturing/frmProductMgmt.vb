'------------------------------------------------------------
'-                File Name: frmProductMgmt                 -
'-                 Part of Project: Assign4                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 02/05/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This is the main form for the program.                   -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows for creating products which are made -
'- up of subassemblies. Subassemblies can also be created,  -
'- which are made up of basic materials. Basic materials    -
'- can also be created.                                     -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- (None)                                                   -
'------------------------------------------------------------
Imports System.ComponentModel

Public Class frmProductMgmt
    ' Initialize with default data
    Private products As List(Of Product) = modFixtureData.defaultProducts
    Private subAssemblies As List(Of SubAssembly) = modFixtureData.defaultSubAssemblies
    Private baseMaterials As List(Of BaseMaterial) = modFixtureData.defaultBaseMaterials

    '------------------------------------------------------------
    '-           Subprogram Name: frmProductMgmt_Load           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subprogram handles the form loading event. It calls -
    '- other subprograms to setup the initial data for the form -
    '- as well as the various error providers.                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the load event             -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmProductMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshProductList()
        refreshSubAssemblyList()
        refreshBaseMaterialList()
        setupErrorProviders()
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: setupErrorProviders           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sets up the error providers for the three           -
    '- textboxes, including aligning the icon and setting their -
    '- padding.                                                 -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub setupErrorProviders()
        errProduct.SetIconAlignment(txtNewProduct, ErrorIconAlignment.MiddleRight)
        errProduct.SetIconPadding(txtNewProduct, 2)

        errSubAsm.SetIconAlignment(txtAddNewSubAsm, ErrorIconAlignment.MiddleRight)
        errSubAsm.SetIconPadding(txtAddNewSubAsm, 2)

        errMaterial.SetIconAlignment(txtNewMaterial, ErrorIconAlignment.MiddleRight)
        errMaterial.SetIconPadding(txtNewMaterial, 2)
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: refreshProductList            -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sets the product list box data source to whatever   -
    '- is currently stored in the products member of this       -
    '- class.                                                   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub refreshProductList()
        lstProducts.DataSource = Product.getDisplayList(products)
    End Sub

    '------------------------------------------------------------
    '-         Subprogram Name: refreshSubAssemblyList          -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sets the subassembly list box data source to        -
    '- whatever is currently stored in the subAssemblies member -
    '- of this class.                                           -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub refreshSubAssemblyList()
        lstAllSubAsm.DataSource = SubAssembly.getDisplayList(subAssemblies)
    End Sub

    '------------------------------------------------------------
    '-         Subprogram Name: refreshBaseMaterialList         -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sets the base materials list box data source to     -
    '- whatever is currently stored in the baseMaterials member -
    '- of this class.                                           -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub refreshBaseMaterialList()
        lstAllBasicMaterials.DataSource = BaseMaterial.getDisplayList(baseMaterials)
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: updateSubAssemblyFromProduct       -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sets the sub assemblies for a product list box data -
    '- source to the sub assemblies of the product passed to    -
    '- this subprogram.                                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- product - Product that will be used to get sub           -
    '-           assemblies from                                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub updateSubAssemblyFromProduct(product As Product)
        lstSubAsmInProduct.DataSource = SubAssembly.getDisplayList(product.subAssemblies)
    End Sub

    '------------------------------------------------------------
    '-        Subprogram Name: updateMaterialFromSubAsm         -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sets the materials for a subassembly list box data  -
    '- source to the materials of the subassembly passed to     -
    '- this subprogram.                                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- subAsm - Subassembly that will be used to get its        -
    '-          materials                                       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub updateMaterialFromSubAsm(subAsm As SubAssembly)
        lstMaterialsInSubAsm.DataSource = BaseMaterial.getDisplayList(subAsm.baseMaterials)
    End Sub

    '------------------------------------------------------------
    '-    Subprogram Name: lstProducts_SelectedIndexChanged     -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This handles when a different product is selected from   -
    '- the product list box. It updates the sub assemblies for  -
    '- a product list box.                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the SelectedIndexChanged   -
    '-          event                                           -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- product - This holds the product based off of the        -
    '-           product list box selected index                -
    '------------------------------------------------------------
    Private Sub lstProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProducts.SelectedIndexChanged
        Dim product As Product = products(lstProducts.SelectedIndex)
        updateSubAssemblyFromProduct(product)
    End Sub

    '------------------------------------------------------------
    '-    Subprogram Name: lstAllSubAsm_SelectedIndexChanged    -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This handles when a different subassembly is selected    -
    '- from the subassembly list box. It updates the materials  -
    '- for a subassembly list box.                              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the SelectedIndexChanged   -
    '-          event                                           -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- subAssembly - The subassembly based off of which item    -
    '-               was selected from the subassembly list box -
    '------------------------------------------------------------
    Private Sub lstAllSubAsm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAllSubAsm.SelectedIndexChanged
        Dim subAssembly As SubAssembly = subAssemblies(lstAllSubAsm.SelectedIndex)
        updateMaterialFromSubAsm(subAssembly)
    End Sub

    '------------------------------------------------------------
    '-        Subprogram Name: txtNewProduct_Validating         -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This handles the validating event for the new product    -
    '- text box. If the text isn't valid, it will set the error -
    '- provider to a specific string.                           -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the Validating event       -
    '- e - Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtNewProduct_Validating(sender As Object, e As CancelEventArgs) Handles txtNewProduct.Validating
        ' Remove error if the user clears the text box or the text is valid
        If Product.validateNewProduct(products, txtNewProduct.Text) Or String.IsNullOrEmpty(txtNewProduct.Text) Then
            errProduct.SetError(txtNewProduct, String.Empty)
        Else
            errProduct.SetError(txtNewProduct, Product.INVALID_PRODUCT_ERROR_STR)
        End If
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnAddProduct_Click           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This handles when the add product button is clicked. It  -
    '- makes sure the string is valid, then adds it to the      -
    '- products list and refreshes the list box.                -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the Click event            -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        If Product.validateNewProduct(products, txtNewProduct.Text) Then
            products.Add(New Product(txtNewProduct.Text))
            products = modFixtureData.sortProductList(products)

            txtNewProduct.Text = ""
            refreshProductList()
        End If
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnAddSubAsm_Click            -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This handles when the add sub assembly button is         -
    '- clicked. It makes sure the string is valid, then adds it -
    '- to the sub assembly list and refreshes the list box.     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the Click event            -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnAddSubAsm_Click(sender As Object, e As EventArgs) Handles btnAddSubAsm.Click
        If SubAssembly.validateNewSubAsm(subAssemblies, txtAddNewSubAsm.Text) Then
            subAssemblies.Add(New SubAssembly(txtAddNewSubAsm.Text))
            subAssemblies = modFixtureData.sortSubAsmList(subAssemblies)

            txtAddNewSubAsm.Text = ""
            refreshSubAssemblyList()
        End If
    End Sub

    '------------------------------------------------------------
    '-       Subprogram Name: txtAddNewSubAsm_Validating        -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This checks to see if the string entered for a new sub   -
    '- assembly is valid, if it isn't then it will activate the -
    '- appropriate error provider.                              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the Validating event       -
    '- e - Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtAddNewSubAsm_Validating(sender As Object, e As CancelEventArgs) Handles txtAddNewSubAsm.Validating
        ' Remove error if the user clears the text box or the text is valid
        If SubAssembly.validateNewSubAsm(subAssemblies, txtAddNewSubAsm.Text) Or String.IsNullOrEmpty(txtAddNewSubAsm.Text) Then
            errSubAsm.SetError(txtAddNewSubAsm, String.Empty)
        Else
            errSubAsm.SetError(txtAddNewSubAsm, SubAssembly.INVALID_SUBASM_ERROR_STR)
        End If
    End Sub

    '------------------------------------------------------------
    '-        Subprogram Name: txtNewMaterial_Validating        -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This checks to see if the string entered for a new       -
    '- material is valid, if it isn't then it will activate the -
    '- appropriate error provider.                              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the Validating event       -
    '- e - Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtNewMaterial_Validating(sender As Object, e As CancelEventArgs) Handles txtNewMaterial.Validating
        ' Remove error if the user clears the text box or the text is valid
        If BaseMaterial.validateNewBaseMaterial(baseMaterials, txtNewMaterial.Text) Or String.IsNullOrEmpty(txtNewMaterial.Text) Then
            errMaterial.SetError(txtNewMaterial, String.Empty)
        Else
            errMaterial.SetError(txtNewMaterial, BaseMaterial.INVALID_MATERIAL_ERROR_STR)
        End If
    End Sub

    '------------------------------------------------------------
    '-         Subprogram Name: btnAddNewMaterial_Click         -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This handles when the add material button is clicked. It -
    '- makes sure the string is valid, then adds it to the      -
    '- materials list and refreshes the list box.               -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the Click event            -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnAddNewMaterial_Click(sender As Object, e As EventArgs) Handles btnAddNewMaterial.Click
        If BaseMaterial.validateNewBaseMaterial(baseMaterials, txtNewMaterial.Text) Then
            baseMaterials.Add(New BaseMaterial(txtNewMaterial.Text))
            baseMaterials = modFixtureData.sortMaterialList(baseMaterials)

            txtNewMaterial.Text = ""
            refreshBaseMaterialList()
        End If
    End Sub

    '------------------------------------------------------------
    '-       Subprogram Name: btnAddSubAsmToProduct_Click       -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This adds a new subassembly or subassemblies to          -
    '- whichever product is currently selected. It will then    -
    '- update the list box that contains the subassemblies for  -
    '- the selected product.                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the Click event            -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- product - Holds the product based off of which product   -
    '-           is selected in the product list box            -
    '------------------------------------------------------------
    Private Sub btnAddSubAsmToProduct_Click(sender As Object, e As EventArgs) Handles btnAddSubAsmToProduct.Click
        ' Add a new subassembly or subassemblies to a product
        Dim product As Product = products(lstProducts.SelectedIndex)  ' this is the actual product from the list, i.e. same address in memory

        For Each subAsm As String In lstAllSubAsm.SelectedItems
            product.addSubAsm(New SubAssembly(subAsm))
        Next

        updateSubAssemblyFromProduct(product)
    End Sub

    '------------------------------------------------------------
    '-    Subprogram Name: btnRemoveSubAsmFromProduct_Click     -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This removes a subassembly or subassemblies from         -
    '- whichever product is currently selected. It will then    -
    '- update the list box that contains the subassemblies for  -
    '- the selected product.                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the Click event            -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- product - Holds the product based off of which product   -
    '-           is selected in the product list box            -
    '------------------------------------------------------------
    Private Sub btnRemoveSubAsmFromProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveSubAsmFromProduct.Click
        ' Remove a subassembly or subassemblies from a product
        Dim product As Product = products(lstProducts.SelectedIndex)  ' this is the actual product from the list, i.e. same address in memory

        For Each subAsm As String In lstSubAsmInProduct.SelectedItems
            product.removeSubAsm(subAsm)
        Next

        updateSubAssemblyFromProduct(product)
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: btnAddMaterialToSubAsm_Click       -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This adds a material or materials to whichever           -
    '- subassembly is currently selected. It will then update   -
    '- the list box that contains the materials for the         -
    '- selected subassembly.                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the Click event            -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- subAsm - Holds the subassembly based off of which        -
    '-          subassembly is selected in the list box         -
    '------------------------------------------------------------
    Private Sub btnAddMaterialToSubAsm_Click(sender As Object, e As EventArgs) Handles btnAddMaterialToSubAsm.Click
        ' Add a new material or materials to a subassembly
        Dim subAsm As SubAssembly = subAssemblies(lstAllSubAsm.SelectedIndex)  ' this is the actual subasm from the list, i.e. same address in memory

        For Each material As String In lstAllBasicMaterials.SelectedItems
            subAsm.addMaterial(New BaseMaterial(material))
        Next

        updateMaterialFromSubAsm(subAsm)
    End Sub

    '------------------------------------------------------------
    '-    Subprogram Name: btnRemoveMaterialFromSubAsm_Click    -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This removes a material or materials from whichever      -
    '- subassembly is currently selected. It will then update   -
    '- the list box that contains the materials for the         -
    '- selected subassembly.                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the Click event            -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- subAsm - Holds the subassembly based off of which        -
    '-          subassembly is selected in the list box         -
    '------------------------------------------------------------
    Private Sub btnRemoveMaterialFromSubAsm_Click(sender As Object, e As EventArgs) Handles btnRemoveMaterialFromSubAsm.Click
        ' Remove a material or materials from a subassembly
        Dim subAsm As SubAssembly = subAssemblies(lstAllSubAsm.SelectedIndex)  ' this is the actual subasm from the list, i.e. same address in memory

        For Each material As String In lstMaterialsInSubAsm.SelectedItems
            subAsm.removeMaterial(material)
        Next

        updateMaterialFromSubAsm(subAsm)
    End Sub
End Class
