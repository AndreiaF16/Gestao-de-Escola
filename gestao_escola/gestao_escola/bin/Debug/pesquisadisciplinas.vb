Public Class pesquisadisciplinas

    Private Sub DisciplinasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DisciplinasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.professores_disciplinas' table. You can move, or remove it, as needed.
        Me.Professores_disciplinasTableAdapter.Fill(Me.EscolaDataSet.professores_disciplinas)
        'TODO: This line of code loads data into the 'EscolaDataSet.disciplinas' table. You can move, or remove it, as needed.
        Me.DisciplinasTableAdapter.Fill(Me.EscolaDataSet.disciplinas)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        pesquisas.Show()
    End Sub
End Class