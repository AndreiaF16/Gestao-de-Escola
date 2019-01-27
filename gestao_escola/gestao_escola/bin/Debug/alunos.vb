Public Class alunos

    Private Sub AlunosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlunosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AlunosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub

    Private Sub alunos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.turmas' table. You can move, or remove it, as needed.
        Me.TurmasTableAdapter.Fill(Me.EscolaDataSet.turmas)
        'TODO: This line of code loads data into the 'EscolaDataSet.alunos' table. You can move, or remove it, as needed.
        Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.alunos)
        Me.BindingNavigatorAddNewItem.Enabled = True
        Me.BindingNavigatorDeleteItem.Enabled = True
    End Sub

    Private Sub alunos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.AlunosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.AlunosBindingSource.EndEdit()

        Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.alunos)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        'Dim resposta As DialogResult

        ' resposta = MessageBox.Show("Deseja eliminar o registo?", "The Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        'If resposta = Windows.Forms.DialogResult.Yes Then
        'AlunosBindingSource.EndEdit()
        'AlunosTableAdapter.Fill(EscolaDataSet.alunos)
        'End If
        'Me.BindingNavigatorDeleteItem.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        form1.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pesquisaalunos.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class