<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesquisadisciplinas
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
        Dim DisciplinaLabel As System.Windows.Forms.Label
        Dim Cod_disciplinaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pesquisadisciplinas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EscolaDataSet = New WindowsApplication1.escolaDataSet()
        Me.DisciplinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DisciplinasTableAdapter = New WindowsApplication1.escolaDataSetTableAdapters.disciplinasTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.escolaDataSetTableAdapters.TableAdapterManager()
        Me.Professores_disciplinasTableAdapter = New WindowsApplication1.escolaDataSetTableAdapters.professores_disciplinasTableAdapter()
        Me.DisciplinasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Professores_disciplinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DisciplinaTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_disciplinaTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Professores_disciplinasDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        DisciplinaLabel = New System.Windows.Forms.Label()
        Cod_disciplinaLabel = New System.Windows.Forms.Label()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisciplinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisciplinasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DisciplinasBindingNavigator.SuspendLayout()
        CType(Me.Professores_disciplinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Professores_disciplinasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DisciplinaLabel
        '
        DisciplinaLabel.AutoSize = True
        DisciplinaLabel.BackColor = System.Drawing.Color.Transparent
        DisciplinaLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DisciplinaLabel.Location = New System.Drawing.Point(28, 193)
        DisciplinaLabel.Name = "DisciplinaLabel"
        DisciplinaLabel.Size = New System.Drawing.Size(93, 22)
        DisciplinaLabel.TabIndex = 3
        DisciplinaLabel.Text = "disciplina:"
        '
        'Cod_disciplinaLabel
        '
        Cod_disciplinaLabel.AutoSize = True
        Cod_disciplinaLabel.BackColor = System.Drawing.Color.Transparent
        Cod_disciplinaLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_disciplinaLabel.Location = New System.Drawing.Point(28, 167)
        Cod_disciplinaLabel.Name = "Cod_disciplinaLabel"
        Cod_disciplinaLabel.Size = New System.Drawing.Size(130, 22)
        Cod_disciplinaLabel.TabIndex = 1
        Cod_disciplinaLabel.Text = "cod disciplina:"
        '
        'EscolaDataSet
        '
        Me.EscolaDataSet.DataSetName = "escolaDataSet"
        Me.EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DisciplinasBindingSource
        '
        Me.DisciplinasBindingSource.DataMember = "disciplinas"
        Me.DisciplinasBindingSource.DataSource = Me.EscolaDataSet
        '
        'DisciplinasTableAdapter
        '
        Me.DisciplinasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alunosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.classificaçõesTableAdapter = Nothing
        Me.TableAdapterManager.disciplinasTableAdapter = Me.DisciplinasTableAdapter
        Me.TableAdapterManager.professores_disciplinasTableAdapter = Me.Professores_disciplinasTableAdapter
        Me.TableAdapterManager.professoresTableAdapter = Nothing
        Me.TableAdapterManager.turmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.escolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Professores_disciplinasTableAdapter
        '
        Me.Professores_disciplinasTableAdapter.ClearBeforeFill = True
        '
        'DisciplinasBindingNavigator
        '
        Me.DisciplinasBindingNavigator.AddNewItem = Nothing
        Me.DisciplinasBindingNavigator.BindingSource = Me.DisciplinasBindingSource
        Me.DisciplinasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DisciplinasBindingNavigator.DeleteItem = Nothing
        Me.DisciplinasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.DisciplinasBindingNavigator.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisciplinasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.DisciplinasBindingNavigator.Location = New System.Drawing.Point(50, 101)
        Me.DisciplinasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DisciplinasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DisciplinasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DisciplinasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DisciplinasBindingNavigator.Name = "DisciplinasBindingNavigator"
        Me.DisciplinasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DisciplinasBindingNavigator.Size = New System.Drawing.Size(218, 25)
        Me.DisciplinasBindingNavigator.TabIndex = 0
        Me.DisciplinasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'Professores_disciplinasBindingSource
        '
        Me.Professores_disciplinasBindingSource.DataMember = "disciplinasprofessores_disciplinas"
        Me.Professores_disciplinasBindingSource.DataSource = Me.DisciplinasBindingSource
        '
        'DisciplinaTextBox
        '
        Me.DisciplinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DisciplinasBindingSource, "disciplina", True))
        Me.DisciplinaTextBox.Location = New System.Drawing.Point(164, 193)
        Me.DisciplinaTextBox.Name = "DisciplinaTextBox"
        Me.DisciplinaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DisciplinaTextBox.TabIndex = 4
        '
        'Cod_disciplinaTextBox
        '
        Me.Cod_disciplinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DisciplinasBindingSource, "cod_disciplina", True))
        Me.Cod_disciplinaTextBox.Location = New System.Drawing.Point(164, 167)
        Me.Cod_disciplinaTextBox.Name = "Cod_disciplinaTextBox"
        Me.Cod_disciplinaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cod_disciplinaTextBox.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cod_disciplina"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cod_disciplina"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cod_professor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "cod_professor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
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
        Me.Professores_disciplinasDataGridView.Location = New System.Drawing.Point(365, 167)
        Me.Professores_disciplinasDataGridView.Name = "Professores_disciplinasDataGridView"
        Me.Professores_disciplinasDataGridView.Size = New System.Drawing.Size(249, 220)
        Me.Professores_disciplinasDataGridView.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(661, 101)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 55)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "VOLTAR CONSULTAS"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(790, 37)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "QUE DISCIPLINAS OS PROFESSORES LECCIONAM"
        '
        'pesquisadisciplinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(891, 404)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Professores_disciplinasDataGridView)
        Me.Controls.Add(Cod_disciplinaLabel)
        Me.Controls.Add(Me.Cod_disciplinaTextBox)
        Me.Controls.Add(DisciplinaLabel)
        Me.Controls.Add(Me.DisciplinaTextBox)
        Me.Controls.Add(Me.DisciplinasBindingNavigator)
        Me.Name = "pesquisadisciplinas"
        Me.Text = "consulta_disciplinas"
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisciplinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisciplinasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DisciplinasBindingNavigator.ResumeLayout(False)
        Me.DisciplinasBindingNavigator.PerformLayout()
        CType(Me.Professores_disciplinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Professores_disciplinasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EscolaDataSet As WindowsApplication1.escolaDataSet
    Friend WithEvents DisciplinasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DisciplinasTableAdapter As WindowsApplication1.escolaDataSetTableAdapters.disciplinasTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.escolaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DisciplinasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Professores_disciplinasTableAdapter As WindowsApplication1.escolaDataSetTableAdapters.professores_disciplinasTableAdapter
    Friend WithEvents Professores_disciplinasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DisciplinaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_disciplinaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Professores_disciplinasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
