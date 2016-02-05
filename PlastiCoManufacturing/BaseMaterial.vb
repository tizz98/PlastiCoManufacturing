'------------------------------------------------------------
'-                File Name: BaseMaterial.vb                -
'-                 Part of Project: Assign4                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 02/05/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- Contains the BaseMaterial class.                         -
'------------------------------------------------------------
Public Class BaseMaterial
    Public name As String

    Public Const INVALID_MATERIAL_ERROR_STR As String = "This name for a basic material is invalid, please try a different name."

    '------------------------------------------------------------
    '-                   Subprogram Name: New                   -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Create a new BaseMaterial object based off of the        -
    '- provided name.                                           -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- name - Name to be used for the object                    -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New(name As String)
        Me.name = name
    End Sub

    '------------------------------------------------------------
    '-              Function Name: getDisplayList               -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This gets a list of strings based off of the name for    -
    '- each in the provided list of materials.                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- materials - List of materials to be used to get names    -
    '-             from                                         -
    '- sorted - Whether or not to sort the list of strings      -
    '-          before returning                                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- returnMaterials - List of strings that is populated from -
    '-                   the materials and eventually returned  -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- List(Of String) - List of strings based off of the       -
    '-                   material names                         -
    '------------------------------------------------------------
    Public Shared Function getDisplayList(materials As List(Of BaseMaterial),
                                          Optional sorted As Boolean = True) As List(Of String)
        Dim returnMaterials As New List(Of String)

        For Each material As BaseMaterial In materials
            returnMaterials.Add(material.name)
        Next

        If sorted Then
            returnMaterials.Sort()
        End If

        Return returnMaterials
    End Function

    '------------------------------------------------------------
    '-          Function Name: validateNewBaseMaterial          -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/05/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Check whether or not the provided new material name      -
    '- would be valid in the list of provided materials.        -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- materials - List of materials to compare the new         -
    '-             material name to                             -
    '- newMaterialName - The name of the proposed name of a new -
    '-                   material                               -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- index - The index of the proposed material name in the   -
    '-         current list of materials                        -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Boolean - Whether or not the proposed new material name  -
    '-           would be valid among the current list of       -
    '-           materials                                      -
    '------------------------------------------------------------
    Public Shared Function validateNewBaseMaterial(materials As List(Of BaseMaterial), newMaterialName As String) As Boolean
        ' "Hi" = "hi", so we make each name lowercase before comparing
        Dim index As Integer = materials.FindIndex(Function(m) m.name.ToLower() = newMaterialName.ToLower())

        ' < 0 means it wasn't found in the list, thus being valid
        Return index < 0 And Not String.IsNullOrWhiteSpace(newMaterialName)
    End Function
End Class
