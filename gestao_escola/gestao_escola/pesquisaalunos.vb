Public Class pesquisaalunos

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "Número do Processo"
        TextBox1.ResetText()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "Nome do Aluno"
        TextBox1.ResetText()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Label1.Text = "Idade do Aluno"
        TextBox1.ResetText()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Label1.Text = "Morada do Aluno"
        TextBox1.ResetText()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim procura, instrucao As String
        procura = TextBox1.Text
        If RadioButton1.Checked = True Then
            instrucao = "select * from alunos where num_processo =" & Val(procura)
        ElseIf RadioButton2.Checked = True Then
            instrucao = "select * from alunos where nome like '" & procura & "'"
        ElseIf RadioButton3.Checked = True Then
            instrucao = "select * from alunos where idade  = " & Val(procura)
        Else
            instrucao = "select * from alunos where morada like '" & procura & "'"
        End If

        Me.AlunosTableAdapter.Adapter.SelectCommand.CommandText = instrucao
        Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.alunos)
        Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.alunos)

    End Sub

    Private Sub AlunosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AlunosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub

    Private Sub consultaalunos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.alunos' table. You can move, or remove it, as needed.
        Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.alunos)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        alunos.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        pesquisas.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class