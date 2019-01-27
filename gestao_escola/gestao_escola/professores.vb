Public Class professores

    Private Sub ProfessoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfessoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfessoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub

    Private Sub professores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.professores' table. You can move, or remove it, as needed.
        Me.ProfessoresTableAdapter.Fill(Me.EscolaDataSet.professores)
        Me.BindingNavigatorAddNewItem.Enabled = True
        Me.BindingNavigatorDeleteItem.Enabled = True
    End Sub
    Private Sub classifica_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.ProfessoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub
    

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.ProfessoresBindingSource.EndEdit()

        Me.ProfessoresTableAdapter.Fill(Me.EscolaDataSet.professores)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        form1.Show()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        'Dim resposta As DialogResult

        'resposta = MessageBox.Show("Deseja eliminar o registo?", "The Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        'If resposta = Windows.Forms.DialogResult.Yes Then
        'ProfessoresBindingSource.EndEdit()
        'ProfessoresTableAdapter.Fill(EscolaDataSet.professores)
        'End If
        'Me.BindingNavigatorDeleteItem.Enabled = True
    End Sub
End Class