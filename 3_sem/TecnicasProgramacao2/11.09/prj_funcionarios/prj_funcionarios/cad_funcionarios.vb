Public Class cad_funcionarios
    Private Sub cad_funcionarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
        carregar_dados()
        carregar_tipo()
        carregar_pesq()
    End Sub
    Private Sub Btn_salvar_editar_Click(sender As Object, e As EventArgs) Handles btn_salvar_editar.Click
        SQL = "SELECT * FROM tb_funcionario WHERE cpf='" & txt_cpf.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = True Then
            qtd = Convert.ToDouble(txt_qtd_sal.Text)
            quant = qtd.ToString("0.00")
            SQL = "INSERT INTO tb_funcionario (nome, cpf, cargo, dtAdmissao, qtdSalarios, salarioBruto, salarioLiquido, inss, foto) VALUES ('" & txt_nome.Text &
                "', '" & txt_cpf.Text & "', '" & cbbx_cargo.Text & "', '" & txt_dtAdmissao.Value & "', '" & quant & "', '" & txt_brutus.Text &
                "', '" & txt_liquid.Text & "', '" & txt_inss.Text &
                "', '" & diretorio & "')"
            rs = db.Execute(UCase(SQL))
            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        Else
            qtd = Convert.ToDouble(txt_qtd_sal.Text)
            quant = qtd.ToString("0.00")
            SQL = "UPDATE tb_funcionario SET cpf= '" & txt_cpf.Text() & "', nome ='" & txt_nome.Text() & "', cargo ='" & cbbx_cargo.Text & "'" &
                ", foto='" & diretorio & "', dtAdmissao = '" & txt_dtAdmissao.Value & "', qtdSalarios ='" & quant & "'" &
                ", salarioBruto = '" & txt_brutus.Text & "', salarioLiquido ='" & txt_liquid.Text & "', inss ='" & txt_inss.Text & "'" &
                "WHERE id = '" & rs.Fields(0).Value & "'"
            rs = db.Execute(UCase(SQL))
            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        End If
        txt_cpf.Clear()
        txt_nome.Clear()
        cbbx_cargo.SelectedIndex = 0
        txt_dtAdmissao.Value = Today
        txt_qtd_sal.Clear()
        txt_brutus.Clear()
        txt_liquid.Clear()
        txt_inss.Clear()
        img_foto.Load(Application.StartupPath & "\fotos\nova_foto.png")
        diretorio = ""
        txt_nome.Focus()
        carregar_dados()
    End Sub
    Private Sub Img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub txt_qtd_sal_LostFocus(sender As Object, e As EventArgs) Handles txt_qtd_sal.LostFocus
        If txt_qtd_sal.Text <> "" Then
            brutus = Convert.ToDouble(txt_qtd_sal.Text) * 1320
            If brutus >= 1630 Then
                inss = (brutus * 11) / 100
            End If
            liquid = brutus - inss

            txt_brutus.Text = brutus.ToString("0.00")
            txt_liquid.Text = liquid.ToString("0.00")
            txt_inss.Text = inss.ToString("0.00")
        End If

    End Sub
    Private Sub txt_nome_DoubleClick(sender As Object, e As EventArgs) Handles txt_nome.DoubleClick
        txt_cpf.Clear()
        txt_nome.Clear()
        cbbx_cargo.SelectedIndex = 0
        txt_qtd_sal.Clear()
        txt_dtAdmissao.Value = Today
        txt_brutus.Clear()
        txt_liquid.Clear()
        txt_inss.Clear()
        diretorio = ""
        img_foto.Load(Application.StartupPath & "\fotos\nova_foto.png")
    End Sub
    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            SQL = "SELECT nome,cargo,salarioBruto,salarioLiquido FROM tb_funcionario WHERE " & cbbx_pesq.Text & " LIKE '%" & txt_busca.Text & "%' ORDER BY nome ASC"
            rs = db.Execute(SQL)
            With dgv_info
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub dgv_info_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_info.CellContentClick
        Try
            With dgv_info
                If .CurrentRow.Cells(5).Selected = True Then
                    aux_nome = .CurrentRow.Cells(1).Value
                    SQL = "SELECT * FROM tb_funcionario WHERE nome = '" & aux_nome & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        diretorio = rs.Fields(9).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_cpf.Text = rs.Fields(2).Value
                        cbbx_cargo.SelectedIndex = cbbx_cargo.FindStringExact(rs.Fields(3).Value)
                        txt_dtAdmissao.Value = rs.Fields(4).Value
                        txt_qtd_sal.Text = rs.Fields(5).Value
                        txt_brutus.Text = rs.Fields(6).Value
                        txt_liquid.Text = rs.Fields(7).Value
                        txt_inss.Text = rs.Fields(8).Value
                        img_foto.Load(rs.Fields(9).Value)
                    End If
                ElseIf .CurrentRow.Cells(6).Selected = True Then
                    aux_nome = .CurrentRow.Cells(1).Value
                    SQL = "SELECT * FROM tb_funcionario WHERE nome = '" & aux_nome & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente excluir o cliente " & aux_nome & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO!")
                        If resp = MsgBoxResult.Yes Then
                            SQL = "DELETE FROM tb_funcionario WHERE nome = '" & aux_nome & "'"
                            rs = db.Execute(SQL)
                            carregar_dados()

                        End If
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub TabControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseClick
        txt_cpf.Clear()
        txt_nome.Clear()
        cbbx_cargo.SelectedIndex = 0
        txt_qtd_sal.Clear()
        txt_dtAdmissao.Value = Today
        txt_brutus.Clear()
        txt_liquid.Clear()
        txt_inss.Clear()
        diretorio = ""
        img_foto.Load(Application.StartupPath & "\fotos\nova_foto.png")
    End Sub
End Class
