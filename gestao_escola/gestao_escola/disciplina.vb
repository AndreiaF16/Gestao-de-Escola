Public Class disciplina

    Private Sub DisciplinasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisciplinasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DisciplinasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.disciplinas' table. You can move, or remove it, as needed.
        Me.DisciplinasTableAdapter.Fill(Me.EscolaDataSet.disciplinas)
        Me.BindingNavigatorAddNewItem.Enabled = True
        Me.BindingNavigatorDeleteItem.Enabled = True
    End Sub

    Private Sub disciplinas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.DisciplinasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.DisciplinasBindingSource.EndEdit()

        Me.DisciplinasTableAdapter.Fill(Me.EscolaDataSet.disciplinas)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        'Dim resposta As DialogResult

        'resposta = MessageBox.Show("Deseja eliminar o registo?", "The Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        'If resposta = Windows.Forms.DialogResult.Yes Then
        'DisciplinasBindingSource.EndEdit()
        'DisciplinasTableAdapter.Fill(EscolaDataSet.disciplinas)
        'End If
        'Me.BindingNavigatorDeleteItem.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        form1.Show()
    End Sub
End Class