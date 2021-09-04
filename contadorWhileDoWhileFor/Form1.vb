Public Class Form1

    'funcao para validar se todos os dados foram preenchidos
    Private Function validarInputs() As Boolean
        ' valida dados vazios e não numéricos 
        Dim resultadoValidacao As Boolean
        If (Not IsNumeric(txtInicio.Text) Or Not IsNumeric(txtFim.Text) Or Not IsNumeric(txtSalto.Text)) Then
            MsgBox("Algum dos campos não está preenchido, ou não é um valor válido.", MsgBoxStyle.Critical, "Atenção!")
            resultadoValidacao = False
            Exit Function
        Else
            ' valida se pelo menos um radiobutton foi selecionado 
            If (Not rbtCrescente.Checked And Not rbtDecrescente.Checked) Then
                MsgBox("Por favor, selecione a opção Crescente ou Decrescente.", MsgBoxStyle.Critical, "Atenção!")
                resultadoValidacao = False
                Exit Function
            End If
        End If
        If (txtSalto.Text < 1) Then
            MsgBox("O salto precisa ser um valor positivo e maior que zero.", MsgBoxStyle.Critical, "Atenção!")
            resultadoValidacao = False
            Exit Function
        End If
        resultadoValidacao = True
        Return resultadoValidacao
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnWhile.Click
        ' chama a funcao para validar os dados
        Dim calcular As Boolean = validarInputs()

        If (calcular) Then
            Dim inicio As Integer = txtInicio.Text
            Dim fim As Integer = txtFim.Text
            Dim salto As Integer = txtSalto.Text

            If (rbtCrescente.Checked) Then
                If (inicio >= fim) Then
                    MsgBox("Para uma contagem CRESCENTE, o valor Início deve ser MENOR que o valor Fim.", MsgBoxStyle.Critical, "Atenção!")
                    Exit Sub
                Else
                    While (inicio <= fim)
                        MsgBox(inicio, MsgBoxStyle.OkOnly, "Contando...")
                        inicio = inicio + salto
                    End While
                End If
            Else
                If (inicio >= fim) Then
                    MsgBox("Para uma contagem DECRESCENTE, o valor Fim deve ser MAIOR que o valor Início.", MsgBoxStyle.Critical, "Atenção!")
                    Exit Sub
                Else
                    While (fim >= inicio)
                        MsgBox(fim, MsgBoxStyle.OkOnly, "Contando...")
                        fim = fim - salto
                    End While
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        ' chama a funcao para validar os dados
        Dim calcular As Boolean = validarInputs()

        If (calcular) Then
            Dim inicio As Integer = txtInicio.Text
            Dim fim As Integer = txtFim.Text
            Dim salto As Integer = txtSalto.Text

            If (rbtCrescente.Checked) Then
                If (inicio >= fim) Then
                    MsgBox("Para uma contagem CRESCENTE, o valor Início deve ser MENOR que o valor Fim.", MsgBoxStyle.Critical, "Atenção!")
                    Exit Sub
                Else
                    Do While (inicio <= fim)
                        MsgBox(inicio, MsgBoxStyle.OkOnly, "Contando...")
                        inicio = inicio + salto
                    Loop
                End If
            Else
                If (inicio >= fim) Then
                    MsgBox("Para uma contagem DECRESCENTE, o valor Fim deve ser MAIOR que o valor Início.", MsgBoxStyle.Critical, "Atenção!")
                    Exit Sub
                Else
                    Do While (inicio <= fim)
                        MsgBox(fim, MsgBoxStyle.OkOnly, "Contando...")
                        fim = fim - salto
                    Loop
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        ' chama a funcao para validar os dados
        Dim calcular As Boolean = validarInputs()

        If (calcular) Then
            Dim inicio As Integer = txtInicio.Text
            Dim fim As Integer = txtFim.Text
            Dim salto As Integer = txtSalto.Text

            If (rbtCrescente.Checked) Then
                If (inicio >= fim) Then
                    MsgBox("Para uma contagem CRESCENTE, o valor Início deve ser MENOR que o valor Fim.", MsgBoxStyle.Critical, "Atenção!")
                    Exit Sub
                Else
                    For i As Integer = inicio To fim Step salto
                        '  System.Diagnostics.Debug.WriteLine(i)
                        MsgBox(inicio, MsgBoxStyle.OkOnly, "Contando...")
                        inicio = inicio + salto
                    Next
                End If
                Exit Sub
            Else
                If (inicio >= fim) Then
                    MsgBox("Para uma contagem DECRESCENTE, o valor Fim deve ser MAIOR que o valor Início.", MsgBoxStyle.Critical, "Atenção!")
                    Exit Sub
                Else
                    For i As Integer = inicio To fim Step salto
                        '  System.Diagnostics.Debug.WriteLine(i)
                        MsgBox(fim, MsgBoxStyle.OkOnly, "Contando...")
                        fim = fim - salto
                    Next
                End If
                Exit Sub
            End If
        End If
    End Sub

End Class
