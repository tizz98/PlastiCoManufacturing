Public Class BaseMaterial
    Public name As String

    Public Const INVALID_MATERIAL_ERROR_STR As String = "This name for a basic material is invalid, please try a different name."

    Public Sub New(name As String)
        Me.name = name
    End Sub

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

    Public Shared Function validateNewBaseMaterial(materials As List(Of BaseMaterial), newMaterialName As String) As Boolean
        ' "Hi" = "hi", so we make each name lowercase before comparing
        Dim index As Integer = materials.FindIndex(Function(m) m.name.ToLower() = newMaterialName.ToLower())

        ' < 0 means it wasn't found in the list, thus being valid
        Return index < 0 And Not String.IsNullOrWhiteSpace(newMaterialName)
    End Function
End Class
