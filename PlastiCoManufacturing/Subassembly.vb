'------------------------------------------------------------
'-                File Name: SubAssembly.vb                 -
'-                 Part of Project: Assign4                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 02/05/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- Contains the SubAssembly class.                          -
'------------------------------------------------------------
Public Class SubAssembly
    Public name As String
    Public baseMaterials As List(Of BaseMaterial)

    Public Const INVALID_SUBASM_ERROR_STR As String = "This name for a subassembly is invalid, please try a different name."

    '------------------------------------------------------------
    '-                   Subprogram Name: New                   -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Create a new SubAssembly object with the provided name   -
    '- and an empty list of base materials.                     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- name - Name to be used for the sub assembly              -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New(name As String)
        Me.name = name
        Me.baseMaterials = New List(Of BaseMaterial)
    End Sub

    '------------------------------------------------------------
    '-                   Subprogram Name: New                   -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Create a new SubAssembly object from a provided name and -
    '- list of base materials.                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- name - Name to be used for the sub assembly              -
    '- baseMaterials - List of materials to be used for the sub -
    '-                 assembly                                 -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New(name As String, baseMaterials As List(Of BaseMaterial))
        Me.name = name
        Me.baseMaterials = baseMaterials
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: addMaterial               -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Add a new material to the list of materials, while       -
    '- keeping the list of materials sorted.                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- material - BaseMaterial to add                           -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub addMaterial(material As BaseMaterial)
        baseMaterials.Add(material)
        baseMaterials = modFixtureData.sortMaterialList(baseMaterials)
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: removeMaterial              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Removes a new material to the list of materials, if it   -
    '- exists in the list.                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- materialName - Name of the material to remove            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- index - The index of the materialName in the list of     -
    '-         materials                                        -
    '------------------------------------------------------------
    Public Sub removeMaterial(materialName As String)
        Dim index As Integer = baseMaterials.FindIndex(Function(m) m.name.ToLower() = materialName.ToLower())

        If index >= 0 Then
            baseMaterials.RemoveAt(index)
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
    '- This function gets a list of strings based on the name   -
    '- of each sub assembly in the provided list and sorts the  -
    '- list.                                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- subAssemblies - The sub assemblies to get the list from  -
    '- sorted - Whether or not to sort the returned list of     -
    '-          strings                                         -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- returnSubAsm - The list of strings that gets populated   -
    '-                and eventually returned.                  -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- List(Of String) - A list of all the subassembly's names. -
    '------------------------------------------------------------
    Public Shared Function getDisplayList(subAssemblies As List(Of SubAssembly),
                                          Optional sorted As Boolean = True) As List(Of String)
        Dim returnSubAsm As New List(Of String)

        For Each subAsm As SubAssembly In subAssemblies
            returnSubAsm.Add(subAsm.name)
        Next

        If sorted Then
            returnSubAsm.Sort()
        End If

        Return returnSubAsm
    End Function

    '------------------------------------------------------------
    '-             Function Name: validateNewSubAsm             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function checks whether or not a proposed name for  -
    '- a sub assembly would be valid among a current list of    -
    '- sub assemblies.                                          -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- subAsms - Current list of sub assemblies                 -
    '- newSubAsmName - The proposed new name for a sub assembly -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- index - The index of the proposed sub assembly name in   -
    '-         the list of current sub assemblies               -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Boolean - Whether or not the proposed new sub assembly   -
    '-           name is valid among the current sub            -
    '-           assemblies.                                    -
    '------------------------------------------------------------
    Public Shared Function validateNewSubAsm(subAsms As List(Of SubAssembly), newSubAsmName As String) As Boolean
        ' "Hi" = "hi", so we make each name lowercase before comparing
        Dim index As Integer = subAsms.FindIndex(Function(s) s.name.ToLower() = newSubAsmName.ToLower())

        ' < 0 means it wasn't found in the list, thus being valid
        Return index < 0 And Not String.IsNullOrWhiteSpace(newSubAsmName)
    End Function
End Class
