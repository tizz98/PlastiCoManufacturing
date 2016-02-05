Public Class frmProductMgmt
    ' Initialize with default data
    Private products As List(Of Product) = modFixtureData.defaultProducts
    Private subAssemblies As List(Of SubAssembly) = modFixtureData.defaultSubAssemblies
    Private baseMaterials As List(Of BaseMaterial) = modFixtureData.defaultBaseMaterials

    Private Sub frmProductMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshProductList()
        refreshSubAssemblyList()
        refreshBaseMaterialList()
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
End Class
