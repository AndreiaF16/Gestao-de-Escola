Public Class pesquisaclassifica

    Private Sub ClassificaçõesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClassificaçõesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscolaDataSet)

    End Sub

    Private Sub consultaclassifica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.classificações' table. You can move, or remove it, as needed.
        Me.ClassificaçõesTableAdapter.Fill(Me.EscolaDataSet.classificações)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        classifica.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim procura, instrucao As String
        procura = TextBox1.Text
        If RadioButton2.Checked = True Then
            instrucao = "select * from classificações where cod_disciplina = " & Val(procura)
        Else
            If RadioButton1.Checked = True Then
                instrucao = "select * from classificações where num_processo = " & Val(procura)
            Else
                instrucao = "select * from classificações where nota  = " & Val(procura)

            End If
        End If

        Me.ClassificaçõesTableAdapter.Adapter.SelectCommand.CommandText = instrucao
        Me.ClassificaçõesTableAdapter.Fill(Me.EscolaDataSet.classificações)
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Label1.Text = "Nota"
        TextBox1.ResetText()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "Número do Processo"
        TextBox1.ResetText()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "Código da Disciplina"
        TextBox1.ResetText()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        pesquisas.Show()
    End Sub
End Class