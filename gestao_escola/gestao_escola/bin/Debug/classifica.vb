Public Class classifica

    Private Sub ClassificaçõesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassificaçõesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClassificaçõesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.alunos' table. You can move, or remove it, as needed.
        Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.alunos)
        'TODO: This line of code loads data into the 'EscolaDataSet.disciplinas' table. You can move, or remove it, as needed.
        Me.DisciplinasTableAdapter.Fill(Me.EscolaDataSet.disciplinas)
        'TODO: This line of code loads data into the 'EscolaDataSet.classificações' table. You can move, or remove it, as needed.
        Me.ClassificaçõesTableAdapter.Fill(Me.EscolaDataSet.classificações)
        Me.BindingNavigatorAddNewItem.Enabled = True
        Me.BindingNavigatorDeleteItem.Enabled = True
    End Sub

    Private Sub classifica_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.ClassificaçõesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.ClassificaçõesBindingSource.EndEdit()

        Me.ClassificaçõesTableAdapter.Fill(Me.EscolaDataSet.classificações)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        'Dim resposta As DialogResult

        'resposta = MessageBox.Show("Deseja eliminar o registo?", "The Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        'If resposta = Windows.Forms.DialogResult.Yes Then
        'ClassificaçõesBindingSource.EndEdit()
        'ClassificaçõesTableAdapter.Fill(EscolaDataSet.classificações)
        'End If
        'Me.BindingNavigatorDeleteItem.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        form1.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        pesquisaclassifica.Show()
    End Sub
End Class