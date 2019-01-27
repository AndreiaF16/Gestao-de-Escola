<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesquisaturmas
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
        Dim Cod_turmaLabel As System.Windows.Forms.Label
        Dim DesignaçãoLabel As System.Windows.Forms.Label
        Dim Total_alunosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pesquisaturmas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EscolaDataSet = New WindowsApplication1.escolaDataSet()
        Me.TurmasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurmasTableAdapter = New WindowsApplication1.escolaDataSetTableAdapters.turmasTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.escolaDataSetTableAdapters.TableAdapterManager()
        Me.AlunosTableAdapter = New WindowsApplication1.escolaDataSetTableAdapters.alunosTableAdapter()
        Me.TurmasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Cod_turmaTextBox = New System.Windows.Forms.TextBox()
        Me.DesignaçãoTextBox = New System.Windows.Forms.TextBox()
        Me.Total_alunosTextBox = New System.Windows.Forms.TextBox()
        Me.AlunosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlunosDataGridView = New System.Windows.Forms.DataGridView()
        Cod_turmaLabel = New System.Windows.Forms.Label()
        DesignaçãoLabel = New System.Windows.Forms.Label()
        Total_alunosLabel = New System.Windows.Forms.Label()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurmasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TurmasBindingNavigator.SuspendLayout()
        CType(Me.AlunosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_turmaLabel
        '
        Cod_turmaLabel.AutoSize = True
        Cod_turmaLabel.BackColor = System.Drawing.Color.Transparent
        Cod_turmaLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_turmaLabel.Location = New System.Drawing.Point(310, 136)
        Cod_turmaLabel.Name = "Cod_turmaLabel"
        Cod_turmaLabel.Size = New System.Drawing.Size(99, 22)
        Cod_turmaLabel.TabIndex = 1
        Cod_turmaLabel.Text = "cod turma:"
        '
        'DesignaçãoLabel
        '
        DesignaçãoLabel.AutoSize = True
        DesignaçãoLabel.BackColor = System.Drawing.Color.Transparent
        DesignaçãoLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesignaçãoLabel.Location = New System.Drawing.Point(296, 164)
        DesignaçãoLabel.Name = "DesignaçãoLabel"
        DesignaçãoLabel.Size = New System.Drawing.Size(113, 22)
        DesignaçãoLabel.TabIndex = 3
        DesignaçãoLabel.Text = "designação:"
        '
        'Total_alunosLabel
        '
        Total_alunosLabel.AutoSize = True
        Total_alunosLabel.BackColor = System.Drawing.Color.Transparent
        Total_alunosLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_alunosLabel.Location = New System.Drawing.Point(296, 190)
        Total_alunosLabel.Name = "Total_alunosLabel"
        Total_alunosLabel.Size = New System.Drawing.Size(110, 22)
        Total_alunosLabel.TabIndex = 5
        Total_alunosLabel.Text = "total alunos:"
        '
        'EscolaDataSet
        '
        Me.EscolaDataSet.DataSetName = "escolaDataSet"
        Me.EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TurmasBindingSource
        '
        Me.TurmasBindingSource.DataMember = "turmas"
        Me.TurmasBindingSource.DataSource = Me.EscolaDataSet
        '
        'TurmasTableAdapter
        '
        Me.TurmasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alunosTableAdapter = Me.AlunosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.classificaçõesTableAdapter = Nothing
        Me.TableAdapterManager.disciplinasTableAdapter = Nothing
        Me.TableAdapterManager.professores_disciplinasTableAdapter = Nothing
        Me.TableAdapterManager.professoresTableAdapter = Nothing
        Me.TableAdapterManager.turmasTableAdapter = Me.TurmasTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.escolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AlunosTableAdapter
        '
        Me.AlunosTableAdapter.ClearBeforeFill = True
        '
        'TurmasBindingNavigator
        '
        Me.TurmasBindingNavigator.AddNewItem = Nothing
        Me.TurmasBindingNavigator.BindingSource = Me.TurmasBindingSource
        Me.TurmasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TurmasBindingNavigator.DeleteItem = Nothing
        Me.TurmasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TurmasBindingNavigator.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurmasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.TurmasBindingNavigator.Location = New System.Drawing.Point(46, 141)
        Me.TurmasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TurmasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TurmasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TurmasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TurmasBindingNavigator.Name = "TurmasBindingNavigator"
        Me.TurmasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TurmasBindingNavigator.Size = New System.Drawing.Size(213, 25)
        Me.TurmasBindingNavigator.TabIndex = 0
        Me.TurmasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(39, 22)
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
        'Cod_turmaTextBox
        '
        Me.Cod_turmaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "cod_turma", True))
        Me.Cod_turmaTextBox.Location = New System.Drawing.Point(416, 138)
        Me.Cod_turmaTextBox.Name = "Cod_turmaTextBox"
        Me.Cod_turmaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cod_turmaTextBox.TabIndex = 2
        '
        'DesignaçãoTextBox
        '
        Me.DesignaçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "designação", True))
        Me.DesignaçãoTextBox.Location = New System.Drawing.Point(416, 164)
        Me.DesignaçãoTextBox.Name = "DesignaçãoTextBox"
        Me.DesignaçãoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DesignaçãoTextBox.TabIndex = 4
        '
        'Total_alunosTextBox
        '
        Me.Total_alunosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "total_alunos", True))
        Me.Total_alunosTextBox.Location = New System.Drawing.Point(416, 190)
        Me.Total_alunosTextBox.Name = "Total_alunosTextBox"
        Me.Total_alunosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_alunosTextBox.TabIndex = 6
        '
        'AlunosBindingSource
        '
        Me.AlunosBindingSource.DataMember = "turmasalunos"
        Me.AlunosBindingSource.DataSource = Me.TurmasBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(573, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ALUNOS EXISTENTES NAS TURMAS"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(673, 129)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 57)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "VOLTAR CONSULTAS"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cod_turma"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cod_turma"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "telefone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "telefone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "morada"
        Me.DataGridViewTextBoxColumn4.HeaderText = "morada"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idade"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idade"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "num_processo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "num_processo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'AlunosDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AlunosDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AlunosDataGridView.AutoGenerateColumns = False
        Me.AlunosDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.AlunosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlunosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.AlunosDataGridView.DataSource = Me.AlunosBindingSource
        Me.AlunosDataGridView.Location = New System.Drawing.Point(46, 227)
        Me.AlunosDataGridView.Name = "AlunosDataGridView"
        Me.AlunosDataGridView.Size = New System.Drawing.Size(747, 192)
        Me.AlunosDataGridView.TabIndex = 7
        '
        'pesquisaturmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(855, 437)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AlunosDataGridView)
        Me.Controls.Add(Cod_turmaLabel)
        Me.Controls.Add(Me.Cod_turmaTextBox)
        Me.Controls.Add(DesignaçãoLabel)
        Me.Controls.Add(Me.DesignaçãoTextBox)
        Me.Controls.Add(Total_alunosLabel)
        Me.Controls.Add(Me.Total_alunosTextBox)
        Me.Controls.Add(Me.TurmasBindingNavigator)
        Me.Name = "pesquisaturmas"
        Me.Text = "consulta_turmas"
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurmasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TurmasBindingNavigator.ResumeLayout(False)
        Me.TurmasBindingNavigator.PerformLayout()
        CType(Me.AlunosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EscolaDataSet As WindowsApplication1.escolaDataSet
    Friend WithEvents TurmasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TurmasTableAdapter As WindowsApplication1.escolaDataSetTableAdapters.turmasTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.escolaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TurmasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Cod_turmaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DesignaçãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_alunosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlunosTableAdapter As WindowsApplication1.escolaDataSetTableAdapters.alunosTableAdapter
    Friend WithEvents AlunosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlunosDataGridView As System.Windows.Forms.DataGridView
End Class
