<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profdisc
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profdisc))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EscolaDataSet = New WindowsApplication1.escolaDataSet()
        Me.Professores_disciplinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Professores_disciplinasTableAdapter = New WindowsApplication1.escolaDataSetTableAdapters.professores_disciplinasTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.escolaDataSetTableAdapters.TableAdapterManager()
        Me.DisciplinasTableAdapter = New WindowsApplication1.escolaDataSetTableAdapters.disciplinasTableAdapter()
        Me.ProfessoresTableAdapter = New WindowsApplication1.escolaDataSetTableAdapters.professoresTableAdapter()
        Me.Professores_disciplinasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Professores_disciplinasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Professores_disciplinasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProfessoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DisciplinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Professores_disciplinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Professores_disciplinasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Professores_disciplinasBindingNavigator.SuspendLayout()
        CType(Me.Professores_disciplinasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfessoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisciplinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EscolaDataSet
        '
        Me.EscolaDataSet.DataSetName = "escolaDataSet"
        Me.EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Professores_disciplinasBindingSource
        '
        Me.Professores_disciplinasBindingSource.DataMember = "professores_disciplinas"
        Me.Professores_disciplinasBindingSource.DataSource = Me.EscolaDataSet
        '
        'Professores_disciplinasTableAdapter
        '
        Me.Professores_disciplinasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alunosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.classificaçõesTableAdapter = Nothing
        Me.TableAdapterManager.disciplinasTableAdapter = Me.DisciplinasTableAdapter
        Me.TableAdapterManager.professores_disciplinasTableAdapter = Me.Professores_disciplinasTableAdapter
        Me.TableAdapterManager.professoresTableAdapter = Me.ProfessoresTableAdapter
        Me.TableAdapterManager.turmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.escolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DisciplinasTableAdapter
        '
        Me.DisciplinasTableAdapter.ClearBeforeFill = True
        '
        'ProfessoresTableAdapter
        '
        Me.ProfessoresTableAdapter.ClearBeforeFill = True
        '
        'Professores_disciplinasBindingNavigator
        '
        Me.Professores_disciplinasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Professores_disciplinasBindingNavigator.BindingSource = Me.Professores_disciplinasBindingSource
        Me.Professores_disciplinasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Professores_disciplinasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Professores_disciplinasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Professores_disciplinasBindingNavigator.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Professores_disciplinasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Professores_disciplinasBindingNavigatorSaveItem})
        Me.Professores_disciplinasBindingNavigator.Location = New System.Drawing.Point(159, 109)
        Me.Professores_disciplinasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Professores_disciplinasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Professores_disciplinasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Professores_disciplinasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Professores_disciplinasBindingNavigator.Name = "Professores_disciplinasBindingNavigator"
        Me.Professores_disciplinasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Professores_disciplinasBindingNavigator.Size = New System.Drawing.Size(318, 25)
        Me.Professores_disciplinasBindingNavigator.TabIndex = 0
        Me.Professores_disciplinasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Professores_disciplinasBindingNavigatorSaveItem
        '
        Me.Professores_disciplinasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Professores_disciplinasBindingNavigatorSaveItem.Image = CType(resources.GetObject("Professores_disciplinasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Professores_disciplinasBindingNavigatorSaveItem.Name = "Professores_disciplinasBindingNavigatorSaveItem"
        Me.Professores_disciplinasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Professores_disciplinasBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Professores_disciplinasDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Professores_disciplinasDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Professores_disciplinasDataGridView.AutoGenerateColumns = False
        Me.Professores_disciplinasDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Professores_disciplinasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Professores_disciplinasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Professores_disciplinasDataGridView.DataSource = Me.Professores_disciplinasBindingSource
        Me.Professores_disciplinasDataGridView.Location = New System.Drawing.Point(186, 165)
        Me.Professores_disciplinasDataGridView.Name = "Professores_disciplinasDataGridView"
        Me.Professores_disciplinasDataGridView.Size = New System.Drawing.Size(245, 220)
        Me.Professores_disciplinasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cod_professor"
        Me.DataGridViewTextBoxColumn1.DataSource = Me.ProfessoresBindingSource
        Me.DataGridViewTextBoxColumn1.DisplayMember = "cod_professor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "cod_professor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.ValueMember = "cod_professor"
        '
        'ProfessoresBindingSource
        '
        Me.ProfessoresBindingSource.DataMember = "professores"
        Me.ProfessoresBindingSource.DataSource = Me.EscolaDataSet
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cod_disciplina"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.DisciplinasBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "cod_disciplina"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cod_disciplina"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "cod_disciplina"
        '
        'DisciplinasBindingSource
        '
        Me.DisciplinasBindingSource.DataMember = "disciplinas"
        Me.DisciplinasBindingSource.DataSource = Me.EscolaDataSet
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(522, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "MENU"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(599, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PROFESSOR LECCIONA X DISCIPLINA"
        '
        'profdisc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(653, 409)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Professores_disciplinasDataGridView)
        Me.Controls.Add(Me.Professores_disciplinasBindingNavigator)
        Me.Name = "profdisc"
        Me.Text = "prof/disc"
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Professores_disciplinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Professores_disciplinasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Professores_disciplinasBindingNavigator.ResumeLayout(False)
        Me.Professores_disciplinasBindingNavigator.PerformLayout()
        CType(Me.Professores_disciplinasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfessoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisciplinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EscolaDataSet As WindowsApplication1.escolaDataSet
    Friend WithEvents Professores_disciplinasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Professores_disciplinasTableAdapter As WindowsApplication1.escolaDataSetTableAdapters.professores_disciplinasTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.escolaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Professores_disciplinasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Professores_disciplinasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProfessoresTableAdapter As WindowsApplication1.escolaDataSetTableAdapters.professoresTableAdapter
    Friend WithEvents Professores_disciplinasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProfessoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DisciplinasTableAdapter As WindowsApplication1.escolaDataSetTableAdapters.disciplinasTableAdapter
    Friend WithEvents DisciplinasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
