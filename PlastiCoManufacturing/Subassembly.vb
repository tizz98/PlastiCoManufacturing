Public Class SubAssembly
    Public name As String
    Public baseMaterials As List(Of BaseMaterial)

    Public Const INVALID_SUBASM_ERROR_STR As String = "This name for a subassembly is invalid, please try a different name."

    Public Sub New(name As String)
        Me.name = name
        Me.baseMaterials = New List(Of BaseMaterial)
    End Sub

    Public Sub New(name As String, baseMaterials As List(Of BaseMaterial))
        Me.name = name
        Me.baseMaterials = baseMaterials
    End Sub

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

    Public Shared Function validateNewSubAsm(subAsms As List(Of SubAssembly), newSubAsmName As String) As Boolean
        ' "Hi" = "hi", so we make each name lowercase before comparing
        Dim index As Integer = subAsms.FindIndex(Function(s) s.name.ToLower() = newSubAsmName.ToLower())

        Return index < 0  ' < 0 means it wasn't found in the list, thus being valid
    End Function
End Class
