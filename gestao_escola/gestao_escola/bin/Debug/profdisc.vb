Public Class profdisc

    Private Sub Professores_disciplinasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Professores_disciplinasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub

    Private Sub alunos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Professores_disciplinasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub
    Private Sub Professores_disciplinasBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Professores_disciplinasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Professores_disciplinasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.disciplinas' table. You can move, or remove it, as needed.
        Me.DisciplinasTableAdapter.Fill(Me.EscolaDataSet.disciplinas)
        'TODO: This line of code loads data into the 'EscolaDataSet.professores' table. You can move, or remove it, as needed.
        Me.ProfessoresTableAdapter.Fill(Me.EscolaDataSet.professores)
        'TODO: This line of code loads data into the 'EscolaDataSet.professores_disciplinas' table. You can move, or remove it, as needed.
        Me.Professores_disciplinasTableAdapter.Fill(Me.EscolaDataSet.professores_disciplinas)
        Me.BindingNavigatorAddNewItem.Enabled = True
        Me.BindingNavigatorDeleteItem.Enabled = True
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.Professores_disciplinasBindingSource.EndEdit()
        Me.Professores_disciplinasTableAdapter.Fill(Me.EscolaDataSet.professores_disciplinas)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        'Dim resposta As DialogResult

        'resposta = MessageBox.Show("Deseja eliminar o registo?", "The Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        'If resposta = Windows.Forms.DialogResult.Yes Then
        'Professores_disciplinasBindingSource.EndEdit()
        'Professores_disciplinasTableAdapter.Fill(EscolaDataSet.professores_disciplinas)
        'End If
        'Me.BindingNavigatorDeleteItem.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        form1.Show()
    End Sub
End Class