<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductMgmt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.lstProducts = New System.Windows.Forms.ListBox()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.txtNewProduct = New System.Windows.Forms.TextBox()
        Me.lblSubAssembliesInProd = New System.Windows.Forms.Label()
        Me.lstSubAsmInProduct = New System.Windows.Forms.ListBox()
        Me.btnAddSubAsmToProduct = New System.Windows.Forms.Button()
        Me.btnRemoveSubAsmFromProduct = New System.Windows.Forms.Button()
        Me.lstAllSubAsm = New System.Windows.Forms.ListBox()
        Me.lblAllSubasm = New System.Windows.Forms.Label()
        Me.txtAddNewSubAsm = New System.Windows.Forms.TextBox()
        Me.btnAddSubAsm = New System.Windows.Forms.Button()
        Me.txtNewMaterial = New System.Windows.Forms.TextBox()
        Me.btnAddNewMaterial = New System.Windows.Forms.Button()
        Me.lstAllBasicMaterials = New System.Windows.Forms.ListBox()
        Me.lblAllBasicMaterials = New System.Windows.Forms.Label()
        Me.btnRemoveMaterialFromSubAsm = New System.Windows.Forms.Button()
        Me.btnAddMaterialToSubAsm = New System.Windows.Forms.Button()
        Me.lstMaterialsInSubAsm = New System.Windows.Forms.ListBox()
        Me.lblMaterialsInSubAsm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblProducts
        '
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Location = New System.Drawing.Point(13, 13)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(52, 13)
        Me.lblProducts.TabIndex = 0
        Me.lblProducts.Text = "Products:"
        '
        'lstProducts
        '
        Me.lstProducts.FormattingEnabled = True
        Me.lstProducts.Location = New System.Drawing.Point(16, 30)
        Me.lstProducts.Name = "lstProducts"
        Me.lstProducts.Size = New System.Drawing.Size(854, 95)
        Me.lstProducts.TabIndex = 1
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(505, 131)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(91, 46)
        Me.btnAddProduct.TabIndex = 2
        Me.btnAddProduct.Text = "Add New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Product"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'txtNewProduct
        '
        Me.txtNewProduct.Location = New System.Drawing.Point(602, 145)
        Me.txtNewProduct.Name = "txtNewProduct"
        Me.txtNewProduct.Size = New System.Drawing.Size(241, 20)
        Me.txtNewProduct.TabIndex = 3
        '
        'lblSubAssembliesInProd
        '
        Me.lblSubAssembliesInProd.AutoSize = True
        Me.lblSubAssembliesInProd.Location = New System.Drawing.Point(16, 189)
        Me.lblSubAssembliesInProd.Name = "lblSubAssembliesInProd"
        Me.lblSubAssembliesInProd.Size = New System.Drawing.Size(131, 13)
        Me.lblSubAssembliesInProd.TabIndex = 4
        Me.lblSubAssembliesInProd.Text = "Subassemblies in Product:"
        '
        'lstSubAsmInProduct
        '
        Me.lstSubAsmInProduct.FormattingEnabled = True
        Me.lstSubAsmInProduct.Location = New System.Drawing.Point(19, 206)
        Me.lstSubAsmInProduct.Name = "lstSubAsmInProduct"
        Me.lstSubAsmInProduct.Size = New System.Drawing.Size(328, 95)
        Me.lstSubAsmInProduct.TabIndex = 5
        '
        'btnAddSubAsmToProduct
        '
        Me.btnAddSubAsmToProduct.Location = New System.Drawing.Point(371, 206)
        Me.btnAddSubAsmToProduct.Name = "btnAddSubAsmToProduct"
        Me.btnAddSubAsmToProduct.Size = New System.Drawing.Size(128, 41)
        Me.btnAddSubAsmToProduct.TabIndex = 6
        Me.btnAddSubAsmToProduct.Text = "<-"
        Me.btnAddSubAsmToProduct.UseVisualStyleBackColor = True
        '
        'btnRemoveSubAsmFromProduct
        '
        Me.btnRemoveSubAsmFromProduct.Location = New System.Drawing.Point(371, 260)
        Me.btnRemoveSubAsmFromProduct.Name = "btnRemoveSubAsmFromProduct"
        Me.btnRemoveSubAsmFromProduct.Size = New System.Drawing.Size(128, 41)
        Me.btnRemoveSubAsmFromProduct.TabIndex = 7
        Me.btnRemoveSubAsmFromProduct.Text = "->"
        Me.btnRemoveSubAsmFromProduct.UseVisualStyleBackColor = True
        '
        'lstAllSubAsm
        '
        Me.lstAllSubAsm.FormattingEnabled = True
        Me.lstAllSubAsm.Location = New System.Drawing.Point(523, 206)
        Me.lstAllSubAsm.Name = "lstAllSubAsm"
        Me.lstAllSubAsm.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstAllSubAsm.Size = New System.Drawing.Size(347, 95)
        Me.lstAllSubAsm.TabIndex = 9
        '
        'lblAllSubasm
        '
        Me.lblAllSubasm.AutoSize = True
        Me.lblAllSubasm.Location = New System.Drawing.Point(520, 189)
        Me.lblAllSubasm.Name = "lblAllSubasm"
        Me.lblAllSubasm.Size = New System.Drawing.Size(125, 13)
        Me.lblAllSubasm.TabIndex = 8
        Me.lblAllSubasm.Text = "List of All Subassemblies:"
        '
        'txtAddNewSubAsm
        '
        Me.txtAddNewSubAsm.Location = New System.Drawing.Point(602, 329)
        Me.txtAddNewSubAsm.Name = "txtAddNewSubAsm"
        Me.txtAddNewSubAsm.Size = New System.Drawing.Size(241, 20)
        Me.txtAddNewSubAsm.TabIndex = 11
        '
        'btnAddSubAsm
        '
        Me.btnAddSubAsm.Location = New System.Drawing.Point(505, 315)
        Me.btnAddSubAsm.Name = "btnAddSubAsm"
        Me.btnAddSubAsm.Size = New System.Drawing.Size(91, 46)
        Me.btnAddSubAsm.TabIndex = 10
        Me.btnAddSubAsm.Text = "Add New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Subasm"
        Me.btnAddSubAsm.UseVisualStyleBackColor = True
        '
        'txtNewMaterial
        '
        Me.txtNewMaterial.Location = New System.Drawing.Point(602, 525)
        Me.txtNewMaterial.Name = "txtNewMaterial"
        Me.txtNewMaterial.Size = New System.Drawing.Size(241, 20)
        Me.txtNewMaterial.TabIndex = 19
        '
        'btnAddNewMaterial
        '
        Me.btnAddNewMaterial.Location = New System.Drawing.Point(505, 511)
        Me.btnAddNewMaterial.Name = "btnAddNewMaterial"
        Me.btnAddNewMaterial.Size = New System.Drawing.Size(91, 46)
        Me.btnAddNewMaterial.TabIndex = 18
        Me.btnAddNewMaterial.Text = "Add New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Material"
        Me.btnAddNewMaterial.UseVisualStyleBackColor = True
        '
        'lstAllBasicMaterials
        '
        Me.lstAllBasicMaterials.FormattingEnabled = True
        Me.lstAllBasicMaterials.Location = New System.Drawing.Point(523, 402)
        Me.lstAllBasicMaterials.Name = "lstAllBasicMaterials"
        Me.lstAllBasicMaterials.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstAllBasicMaterials.Size = New System.Drawing.Size(347, 95)
        Me.lstAllBasicMaterials.TabIndex = 17
        '
        'lblAllBasicMaterials
        '
        Me.lblAllBasicMaterials.AutoSize = True
        Me.lblAllBasicMaterials.Location = New System.Drawing.Point(520, 385)
        Me.lblAllBasicMaterials.Name = "lblAllBasicMaterials"
        Me.lblAllBasicMaterials.Size = New System.Drawing.Size(126, 13)
        Me.lblAllBasicMaterials.TabIndex = 16
        Me.lblAllBasicMaterials.Text = "List of All Basic Materials:"
        '
        'btnRemoveMaterialFromSubAsm
        '
        Me.btnRemoveMaterialFromSubAsm.Location = New System.Drawing.Point(371, 456)
        Me.btnRemoveMaterialFromSubAsm.Name = "btnRemoveMaterialFromSubAsm"
        Me.btnRemoveMaterialFromSubAsm.Size = New System.Drawing.Size(128, 41)
        Me.btnRemoveMaterialFromSubAsm.TabIndex = 15
        Me.btnRemoveMaterialFromSubAsm.Text = "->"
        Me.btnRemoveMaterialFromSubAsm.UseVisualStyleBackColor = True
        '
        'btnAddMaterialToSubAsm
        '
        Me.btnAddMaterialToSubAsm.Location = New System.Drawing.Point(371, 402)
        Me.btnAddMaterialToSubAsm.Name = "btnAddMaterialToSubAsm"
        Me.btnAddMaterialToSubAsm.Size = New System.Drawing.Size(128, 41)
        Me.btnAddMaterialToSubAsm.TabIndex = 14
        Me.btnAddMaterialToSubAsm.Text = "<-"
        Me.btnAddMaterialToSubAsm.UseVisualStyleBackColor = True
        '
        'lstMaterialsInSubAsm
        '
        Me.lstMaterialsInSubAsm.FormattingEnabled = True
        Me.lstMaterialsInSubAsm.Location = New System.Drawing.Point(19, 402)
        Me.lstMaterialsInSubAsm.Name = "lstMaterialsInSubAsm"
        Me.lstMaterialsInSubAsm.Size = New System.Drawing.Size(328, 95)
        Me.lstMaterialsInSubAsm.TabIndex = 13
        '
        'lblMaterialsInSubAsm
        '
        Me.lblMaterialsInSubAsm.AutoSize = True
        Me.lblMaterialsInSubAsm.Location = New System.Drawing.Point(16, 385)
        Me.lblMaterialsInSubAsm.Name = "lblMaterialsInSubAsm"
        Me.lblMaterialsInSubAsm.Size = New System.Drawing.Size(202, 13)
        Me.lblMaterialsInSubAsm.TabIndex = 12
        Me.lblMaterialsInSubAsm.Text = "Basic Materials in Selected Subassembly:"
        '
        'frmProductMgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 577)
        Me.Controls.Add(Me.txtNewMaterial)
        Me.Controls.Add(Me.btnAddNewMaterial)
        Me.Controls.Add(Me.lstAllBasicMaterials)
        Me.Controls.Add(Me.lblAllBasicMaterials)
        Me.Controls.Add(Me.btnRemoveMaterialFromSubAsm)
        Me.Controls.Add(Me.btnAddMaterialToSubAsm)
        Me.Controls.Add(Me.lstMaterialsInSubAsm)
        Me.Controls.Add(Me.lblMaterialsInSubAsm)
        Me.Controls.Add(Me.txtAddNewSubAsm)
        Me.Controls.Add(Me.btnAddSubAsm)
        Me.Controls.Add(Me.lstAllSubAsm)
        Me.Controls.Add(Me.lblAllSubasm)
        Me.Controls.Add(Me.btnRemoveSubAsmFromProduct)
        Me.Controls.Add(Me.btnAddSubAsmToProduct)
        Me.Controls.Add(Me.lstSubAsmInProduct)
        Me.Controls.Add(Me.lblSubAssembliesInProd)
        Me.Controls.Add(Me.txtNewProduct)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.lstProducts)
        Me.Controls.Add(Me.lblProducts)
        Me.Name = "frmProductMgmt"
        Me.Text = "PlastiCo Manufacturing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProducts As Label
    Friend WithEvents lstProducts As ListBox
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents txtNewProduct As TextBox
    Friend WithEvents lblSubAssembliesInProd As Label
    Friend WithEvents lstSubAsmInProduct As ListBox
    Friend WithEvents btnAddSubAsmToProduct As Button
    Friend WithEvents btnRemoveSubAsmFromProduct As Button
    Friend WithEvents lstAllSubAsm As ListBox
    Friend WithEvents lblAllSubasm As Label
    Friend WithEvents txtAddNewSubAsm As TextBox
    Friend WithEvents btnAddSubAsm As Button
    Friend WithEvents txtNewMaterial As TextBox
    Friend WithEvents btnAddNewMaterial As Button
    Friend WithEvents lstAllBasicMaterials As ListBox
    Friend WithEvents lblAllBasicMaterials As Label
    Friend WithEvents btnRemoveMaterialFromSubAsm As Button
    Friend WithEvents btnAddMaterialToSubAsm As Button
    Friend WithEvents lstMaterialsInSubAsm As ListBox
    Friend WithEvents lblMaterialsInSubAsm As Label
End Class
