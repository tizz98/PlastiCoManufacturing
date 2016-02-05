Public Class Product
    Public name As String
    Public subAssemblies As List(Of SubAssembly)

    Public Const INVALID_PRODUCT_ERROR_STR As String = "This name for a product is invalid, please try a different name."

    Public Sub New(name As String)
        Me.name = name
        Me.subAssemblies = New List(Of SubAssembly)
    End Sub

    Public Sub New(name As String, subAssemblies As List(Of SubAssembly))
        Me.name = name
        Me.subAssemblies = subAssemblies
    End Sub

    Public Shared Function getDisplayList(products As List(Of Product), Optional sorted As Boolean = True) As List(Of String)
        Dim returnValues As New List(Of String)

        For Each product As Product In products
            returnValues.Add(product.name)
        Next

        If sorted Then
            returnValues.Sort()
        End If

        Return returnValues
    End Function

    Public Shared Function validateNewProduct(products As List(Of Product), newProductName As String) As Boolean
        ' "Hi" = "hi", so we make each name lowercase before comparing
        Dim index As Integer = products.FindIndex(Function(p) p.name.ToLower() = newProductName.ToLower())

        Return index < 0  ' < 0 means it wasn't found in the list, thus being valid
    End Function
End Class
