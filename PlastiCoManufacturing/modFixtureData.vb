Module modFixtureData
    Private defaultMaterialStrings() As String = {"Axel", "Base", "Frame", "Leg", "Long Rail", "Seat", "Short Rail"}
    Private defaultSubAssemblyStrings() As String = {"2-Wheel Frame", "4-Wheel Frame", "Box"}
    Private defaultProductStrings() As String = {"Wagon", "Cart"}

    Public defaultBaseMaterials As List(Of BaseMaterial) = getDefaultMaterials()
    Public defaultSubAssemblies As List(Of SubAssembly) = getDefaultSubAssemblies()
    Public defaultProducts As List(Of Product) = getDefaultProducts()

    Private Function getDefaultMaterials() As List(Of BaseMaterial)
        Dim returnMaterials As New List(Of BaseMaterial)

        For Each material As String In defaultMaterialStrings
            returnMaterials.Add(New BaseMaterial(material))
        Next

        Return sortMaterialList(returnMaterials)
    End Function

    Private Function getDefaultSubAssemblies() As List(Of SubAssembly)
        Dim returnAssemblies As New List(Of SubAssembly)
        Dim materials As New List(Of BaseMaterial)

        For i As Integer = 0 To defaultSubAssemblyStrings.GetUpperBound(0)
            If i = 0 Then
                materials = New List(Of BaseMaterial) From {defaultBaseMaterials(0), defaultBaseMaterials(2), defaultBaseMaterials(3)}
            ElseIf i = 1 Then
                materials = New List(Of BaseMaterial) From {defaultBaseMaterials(1), defaultBaseMaterials(4)}
            ElseIf i = 2 Then
                materials = New List(Of BaseMaterial) From {defaultBaseMaterials(0), defaultBaseMaterials(3)}
            End If

            returnAssemblies.Add(New SubAssembly(defaultSubAssemblyStrings(i), materials))
        Next

        Return sortSubAsmList(returnAssemblies)
    End Function

    Private Function getDefaultProducts() As List(Of Product)
        Dim returnProducts As New List(Of Product)
        Dim subAssemblies As New List(Of SubAssembly)

        For i As Integer = 0 To defaultProductStrings.GetUpperBound(0)
            If i = 0 Then
                subAssemblies = New List(Of SubAssembly) From {defaultSubAssemblies(0), defaultSubAssemblies(1)}
            ElseIf i = 1 Then
                subAssemblies = New List(Of SubAssembly) From {defaultSubAssemblies(1), defaultSubAssemblies(2)}
            End If

            returnProducts.Add(New Product(defaultProductStrings(i), subAssemblies))
        Next

        Return sortProductList(returnProducts)
    End Function

    Public Function sortProductList(products As List(Of Product)) As List(Of Product)
        Dim returnProducts As New List(Of Product)
        returnProducts.AddRange(products)

        returnProducts.Sort(Function(x, y) x.name.CompareTo(y.name))

        Return returnProducts
    End Function

    Public Function sortSubAsmList(subAsm As List(Of SubAssembly)) As List(Of SubAssembly)
        Dim returnSubAsm As New List(Of SubAssembly)
        returnSubAsm.AddRange(subAsm)

        returnSubAsm.Sort(Function(x, y) x.name.CompareTo(y.name))

        Return returnSubAsm
    End Function

    Public Function sortMaterialList(materials As List(Of BaseMaterial)) As List(Of BaseMaterial)
        Dim returnMaterials As New List(Of BaseMaterial)
        returnMaterials.AddRange(materials)

        returnMaterials.Sort(Function(x, y) x.name.CompareTo(y.name))

        Return returnMaterials
    End Function
End Module
