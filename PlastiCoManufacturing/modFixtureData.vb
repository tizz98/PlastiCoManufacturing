'------------------------------------------------------------
'-               File Name: modFixtureData.vb               -
'-                 Part of Project: Assign4                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 02/05/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- Contains a module which contains the initial data to be  -
'- used for the program when it launches.                   -
'------------------------------------------------------------
Module modFixtureData
    Private defaultMaterialStrings() As String = {"Axel", "Base", "Frame", "Leg", "Long Rail", "Seat", "Short Rail"}
    Private defaultSubAssemblyStrings() As String = {"2-Wheel Frame", "4-Wheel Frame", "Box"}
    Private defaultProductStrings() As String = {"Wagon", "Cart"}

    Public defaultBaseMaterials As List(Of BaseMaterial) = getDefaultMaterials()
    Public defaultSubAssemblies As List(Of SubAssembly) = getDefaultSubAssemblies()
    Public defaultProducts As List(Of Product) = getDefaultProducts()

    '------------------------------------------------------------
    '-            Function Name: getDefaultMaterials            -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Generate a list of BaseMaterial objects from the         -
    '- module's defaultMaterialStrings.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- returnMaterials - List of materials to return after      -
    '-                   being populated.                       -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- List(Of BaseMaterial) - List of BaseMaterial objects     -
    '------------------------------------------------------------
    Private Function getDefaultMaterials() As List(Of BaseMaterial)
        Dim returnMaterials As New List(Of BaseMaterial)

        For Each material As String In defaultMaterialStrings
            returnMaterials.Add(New BaseMaterial(material))
        Next

        Return sortMaterialList(returnMaterials)
    End Function

    '------------------------------------------------------------
    '-          Function Name: getDefaultSubAssemblies          -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Generate a list of SubAssembly objects from the module's -
    '- defaultSubAssemblyStrings.                               -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- materials - A list of BaseMaterial to be added to a      -
    '-             particular SubAssembly                       -
    '- returnAssemblies - List of SubAssembly objects that is   -
    '-                    populated within the function         -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- List(Of SubAssembly) - List of SubAssembly objects       -
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    '-            Function Name: getDefaultProducts             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Generate a list of Product objects from the module's     -
    '- defaultProductStrings.                                   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- returnProducts - List of Product objects to be returned  -
    '-                  and is populated within the function    -
    '- subAssemblies - A list of SubAssembly objects to be used -
    '-                 for a particular Product                 -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- List(Of Product) - List of Product objects               -
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    '-              Function Name: getProductList               -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Sorts a list of Product objects by their name.           -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- products - List of product objects to be sorted by their -
    '-            name                                          -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- returnProducts - List of Product objects to be returned  -
    '-                  and is populated within the function    -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- List(Of Product) - List of Product objects               -
    '------------------------------------------------------------
    Public Function sortProductList(products As List(Of Product)) As List(Of Product)
        Dim returnProducts As New List(Of Product)
        returnProducts.AddRange(products)

        returnProducts.Sort(Function(x, y) x.name.CompareTo(y.name))

        Return returnProducts
    End Function

    '------------------------------------------------------------
    '-              Function Name: sortSubAsmList               -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Sorts a list of SubAssembly objects by their name.       -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- subAsm - A list of SubAssembly objects to be sorted      -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- returnSubAsm - List of SubAssembly objects that is       -
    '-                populated and eventually returned         -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- List(Of SubAssembly) - List of SubAssembly objects       -
    '------------------------------------------------------------
    Public Function sortSubAsmList(subAsm As List(Of SubAssembly)) As List(Of SubAssembly)
        Dim returnSubAsm As New List(Of SubAssembly)
        returnSubAsm.AddRange(subAsm)

        returnSubAsm.Sort(Function(x, y) x.name.CompareTo(y.name))

        Return returnSubAsm
    End Function

    '------------------------------------------------------------
    '-             Function Name: sortMaterialList              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Sorts a list of BaseMaterial objects by their name.      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- materials - A list of BaseMaterial objects to be sorted  -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- returnMaterials - A list of BaseMaterial objects that is -
    '-                   populated and eventually returned      -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- List(Of BaseMaterial) - List of BaseMaterial objects     -
    '------------------------------------------------------------
    Public Function sortMaterialList(materials As List(Of BaseMaterial)) As List(Of BaseMaterial)
        Dim returnMaterials As New List(Of BaseMaterial)
        returnMaterials.AddRange(materials)

        returnMaterials.Sort(Function(x, y) x.name.CompareTo(y.name))

        Return returnMaterials
    End Function
End Module
