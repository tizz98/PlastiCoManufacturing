Imports System.ComponentModel

Public Class frmProductMgmt
    ' Initialize with default data
    Private products As List(Of Product) = modFixtureData.defaultProducts
    Private subAssemblies As List(Of SubAssembly) = modFixtureData.defaultSubAssemblies
    Private baseMaterials As List(Of BaseMaterial) = modFixtureData.defaultBaseMaterials

    Private Sub frmProductMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshProductList()
        refreshSubAssemblyList()
        refreshBaseMaterialList()
        setupErrorProviders()
    End Sub

    Private Sub setupErrorProviders()
        errProduct.SetIconAlignment(txtNewProduct, ErrorIconAlignment.MiddleRight)
        errProduct.SetIconPadding(txtNewProduct, 2)

        errSubAsm.SetIconAlignment(txtAddNewSubAsm, ErrorIconAlignment.MiddleRight)
        errSubAsm.SetIconPadding(txtAddNewSubAsm, 2)

        errMaterial.SetIconAlignment(txtNewMaterial, ErrorIconAlignment.MiddleRight)
        errMaterial.SetIconPadding(txtNewMaterial, 2)
    End Sub


    Private Sub refreshProductList()
        lstProducts.DataSource = Product.getDisplayList(products)
    End Sub

    Private Sub refreshSubAssemblyList()
        lstAllSubAsm.DataSource = SubAssembly.getDisplayList(subAssemblies)
    End Sub

    Private Sub refreshBaseMaterialList()
        lstAllBasicMaterials.DataSource = BaseMaterial.getDisplayList(baseMaterials)
    End Sub

    Private Sub updateSubAssemblyFromProduct(product As Product)
        lstSubAsmInProduct.DataSource = SubAssembly.getDisplayList(product.subAssemblies)
    End Sub

    Private Sub updateMaterialFromSubAsm(subAsm As SubAssembly)
        lstMaterialsInSubAsm.DataSource = BaseMaterial.getDisplayList(subAsm.baseMaterials)
    End Sub

    Private Sub lstProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProducts.SelectedIndexChanged
        Dim product As Product = products(lstProducts.SelectedIndex)
        updateSubAssemblyFromProduct(product)
    End Sub

    Private Sub lstAllSubAsm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAllSubAsm.SelectedIndexChanged
        Dim subAssembly As SubAssembly = subAssemblies(lstAllSubAsm.SelectedIndex)
        updateMaterialFromSubAsm(subAssembly)
    End Sub

    Private Sub txtNewProduct_Validating(sender As Object, e As CancelEventArgs) Handles txtNewProduct.Validating
        If Product.validateNewProduct(products, txtNewProduct.Text) Then
            errProduct.SetError(txtNewProduct, String.Empty)
        Else
            errProduct.SetError(txtNewProduct, Product.INVALID_PRODUCT_ERROR_STR)
        End If
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        If Product.validateNewProduct(products, txtNewProduct.Text) Then
            products.Add(New Product(txtNewProduct.Text))
            products = modFixtureData.sortProductList(products)

            txtNewProduct.Text = ""
            refreshProductList()
        End If
    End Sub

    Private Sub btnAddSubAsm_Click(sender As Object, e As EventArgs) Handles btnAddSubAsm.Click
        If SubAssembly.validateNewSubAsm(subAssemblies, txtAddNewSubAsm.Text) Then
            errSubAsm.SetError(txtAddNewSubAsm, String.Empty)
        Else
            errSubAsm.SetError(txtAddNewSubAsm, SubAssembly.INVALID_SUBASM_ERROR_STR)
        End If
    End Sub

    Private Sub txtAddNewSubAsm_Validating(sender As Object, e As CancelEventArgs) Handles txtAddNewSubAsm.Validating
        If SubAssembly.validateNewSubAsm(subAssemblies, txtAddNewSubAsm.Text) Then
            subAssemblies.Add(New SubAssembly(txtAddNewSubAsm.Text))
            subAssemblies = modFixtureData.sortSubAsmList(subAssemblies)

            txtAddNewSubAsm.Text = ""
            refreshSubAssemblyList()
        End If
    End Sub

    Private Sub txtNewMaterial_Validating(sender As Object, e As CancelEventArgs) Handles txtNewMaterial.Validating
        If BaseMaterial.validateNewBaseMaterial(baseMaterials, txtNewMaterial.Text) Then
            errMaterial.SetError(txtNewMaterial, String.Empty)
        Else
            errMaterial.SetError(txtNewMaterial, BaseMaterial.INVALID_MATERIAL_ERROR_STR)
        End If
    End Sub

    Private Sub btnAddNewMaterial_Click(sender As Object, e As EventArgs) Handles btnAddNewMaterial.Click
        If BaseMaterial.validateNewBaseMaterial(baseMaterials, txtNewMaterial.Text) Then
            baseMaterials.Add(New BaseMaterial(txtNewMaterial.Text))
            baseMaterials = modFixtureData.sortMaterialList(baseMaterials)

            txtNewMaterial.Text = ""
            refreshBaseMaterialList()
        End If
    End Sub

    Private Sub btnAddSubAsmToProduct_Click(sender As Object, e As EventArgs) Handles btnAddSubAsmToProduct.Click
        ' Add a new subassembly or subassemblies to a product
        Dim product As Product = products(lstProducts.SelectedIndex)  ' this is the actual product from the list, i.e. same address in memory

        For Each subAsm As String In lstAllSubAsm.SelectedItems
            product.addSubAsm(New SubAssembly(subAsm))
        Next

        updateSubAssemblyFromProduct(product)
    End Sub

    Private Sub btnRemoveSubAsmFromProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveSubAsmFromProduct.Click
        ' Remove a subassembly or subassemblies from a product
        Dim product As Product = products(lstProducts.SelectedIndex)  ' this is the actual product from the list, i.e. same address in memory

        For Each subAsm As String In lstSubAsmInProduct.SelectedItems
            product.removeSubAsm(subAsm)
        Next

        updateSubAssemblyFromProduct(product)
    End Sub
End Class
