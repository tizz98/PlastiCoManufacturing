'------------------------------------------------------------
'-                  File Name: Product.vb                   -
'-                 Part of Project: Assign4                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 02/05/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This contains the Product class.                         -
'------------------------------------------------------------
Public Class Product
    Public name As String
    Public subAssemblies As List(Of SubAssembly)

    Public Const INVALID_PRODUCT_ERROR_STR As String = "This name for a product is invalid, please try a different name."

    '------------------------------------------------------------
    '-                   Subprogram Name: New                   -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Create a new Product object with the provided name and   -
    '- an empty list of subassemblies.                          -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- name - The name to be set for the product                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New(name As String)
        Me.name = name
        Me.subAssemblies = New List(Of SubAssembly)
    End Sub

    '------------------------------------------------------------
    '-                   Subprogram Name: New                   -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Create a new Product object with the provided name and   -
    '- provided list of subassemblies.                          -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- name - The name to be set for the product                -
    '- subAssemblies - The list of subassemblies to be set for  -
    '-                 the product                              -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New(name As String, subAssemblies As List(Of SubAssembly))
        Me.name = name
        Me.subAssemblies = subAssemblies
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: addSubAsm                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Add a sub assembly to the list of sub assemblies, making -
    '- sure to keep the list of sub assemblies sorted.          -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- subAsm - The sub assembly to add                         -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub addSubAsm(subAsm As SubAssembly)
        subAssemblies.Add(subAsm)
        subAssemblies = modFixtureData.sortSubAsmList(subAssemblies)
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: removeSubAsm               -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Remove a sub assembly by name from the list of sub       -
    '- assemblies, if it exists in the list.                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- subAsmName - The name of the sub assembly to remove      -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- index - The index of the sub assembly to remove in the   -
    '-         sub assembly list                                -
    '------------------------------------------------------------
    Public Sub removeSubAsm(subAsmName As String)
        Dim index As Integer = subAssemblies.FindIndex(Function(s) s.name.ToLower() = subAsmName.ToLower())

        ' Make sure the sub assembly is in the sub assemblies for this product
        If index >= 0 Then
            subAssemblies.RemoveAt(index)
        End If
    End Sub

    '------------------------------------------------------------
    '-              Function Name: getDisplayList               -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This gets a list of strings based off of the name of     -
    '- each product passed to the function.                     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- products - List of products to get the display list of   -
    '- sorted - Whether or not to sort the list of strings      -
    '-          before returning it                             -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- returnValues - A list of strings that will be populated  -
    '-                based off of the name of each product     -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- List(Of String) - A list of strings to be used when      -
    '-                   displaying a list of products          -
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    '-            Function Name: validateNewProduct             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This checks to see if the newProductName is already in   -
    '- the list of products, and also checks to make sure the   -
    '- newProductName isn't null or whitespace.                 -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- products - The list of products to validate against      -
    '- newProductName - The name of the proposed new product    -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- index - The index of the proposed new product in the     -
    '-         list of products                                 -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Boolean - Whether or not the proposed new product would  -
    '-           be valid amongst the provided list of products -
    '------------------------------------------------------------
    Public Shared Function validateNewProduct(products As List(Of Product), newProductName As String) As Boolean
        ' "Hi" = "hi", so we make each name lowercase before comparing
        Dim index As Integer = products.FindIndex(Function(p) p.name.ToLower() = newProductName.ToLower())

        ' < 0 means it wasn't found in the list, thus being valid
        Return index < 0 And Not String.IsNullOrWhiteSpace(newProductName)
    End Function
End Class
