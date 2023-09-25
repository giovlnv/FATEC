Imports System.Data.SqlTypes
Imports System.Text.RegularExpressions

Public Class frm_func
    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog2
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub Frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados()
        carregar_tipo()
        carregar_cargo()
    End Sub
    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(7).Selected = True Then
                    aux_n = .CurrentRow.Cells(1).Value
                    SQL = "SELECT * FROM tb_cadastro WHERE id = '" & aux_n & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        diretorio = rs.Fields(8).Value
                        txt_nome.Text = rs.Fields(1).Value
                        menu_cargo.SelectedText = rs.Fields(2).Value
                        data_adm.Value = rs.Fields(3).Value
                        txt_salario.Text = rs.Fields(4).Value
                        txt_salbrut.Text = rs.Fields(5).Value
                        txt_salliq.Text = rs.Fields(6).Value
                        txt_inss.Text = rs.Fields(7).Value
                        img_foto.Load(rs.Fields(8).Value)
                    End If
                ElseIf .CurrentRow.Cells(8).Selected = True Then
                    aux_n = .CurrentRow.Cells(1).Value
                    SQL = "SELECT * FROM tb_cadastro WHERE id = '" & aux_n & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente excluir o funcionário " & txt_nome.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO!")
                        If resp = MsgBoxResult.Yes Then
                            SQL = "DELETE FROM tb_cadastro WHERE id = '" & aux_n & "'"
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
    Private Sub txt_salario_LostFocus(sender As Object, e As EventArgs) Handles txt_salario.LostFocus
        Dim salario, inss, salbrut, salliq As Double
        Try
            salario = Double.Parse(txt_salario.Text())
            salbrut = salario * 1320
            If salbrut >= 1630 Then
                inss = salbrut * 0.11
            Else
                inss = 0
            End If
            salliq = salbrut - inss
            txt_salbrut.Text() = salbrut
            txt_salliq.Text() = salliq
            txt_inss.Text() = inss

        Catch ex As Exception
            MsgBox("Erro ao calcular!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Private Sub TabControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseClick
        txt_nome.Clear()
        menu_cargo.ResetText()
        data_adm.ResetText()
        txt_salario.Clear()
        txt_salbrut.Clear()
        txt_salliq.Clear()
        txt_inss.Clear()
        img_foto.Load(Application.StartupPath & "\Fotos\nova_foto.png")
    End Sub
    Private Sub Btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Dim salario, inss, salbrut, salliq As Double
        Try
            SQL = "SELECT * FROM tb_cadastro WHERE nome='" & txt_nome.Text & "'"
            rs = db.Execute(SQL)
            salario = Double.Parse(txt_salario.Text)
            salbrut = Double.Parse(txt_salbrut.Text)
            salliq = Double.Parse(txt_salliq.Text)
            inss = Double.Parse(txt_inss.Text)

            If rs.EOF = True Then
                SQL = "INSERT INTO tb_cadastro (nome,cargo,data_adm,qtd_sal,sal_brut,sal_liq,inss,foto) VALUES ('" & txt_nome.Text & "', " &
                "'" & menu_cargo.SelectedItem.ToString & "','" & data_adm.Value() & "','" & salario & "'," &
                "'" & salbrut & "','" & salliq & "','" & inss & "','" & diretorio & "')"
                rs = db.Execute(SQL)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                SQL = "UPDATE tb_cadastro SET cargo = '" & menu_cargo.SelectedItem.ToString & "', data_adm ='" & data_adm.Value() &
                      "', qtd_sal = '" & salario & "', sal_brut ='" & salbrut &
                      "', sal_liq = '" & salliq & "', inss ='" & inss &
                      "', foto = '" & diretorio & "' WHERE nome ='" & txt_nome.Text() & "'"
                rs = db.Execute(SQL)
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            txt_nome.Clear()
            menu_cargo.ResetText()
            data_adm.ResetText()
            txt_salario.Clear()
            txt_salbrut.Clear()
            txt_salliq.Clear()
            txt_inss.Clear()
            img_foto.Load(Application.StartupPath & "\Fotos\nova_foto.png")
            txt_nome.Focus()
            carregar_dados()

        Catch ex As Exception
            MsgBox("Erro ao gravar! Erro:" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            SQL = "SELECT * FROM tb_cadastro WHERE " & cmb_tipo.Text & " LIKE '%" & txt_busca.Text & "%'"
            rs = db.Execute(SQL)
            With dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(5).Value, rs.Fields(6).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class