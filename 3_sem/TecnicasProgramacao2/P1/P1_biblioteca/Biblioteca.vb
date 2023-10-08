Public Class Biblioteca
    Private Sub biblioteca_load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_usuarios()
        carregar_livros()
        carregar_emprestimos()
        tab_cad.BringToFront()
    End Sub
    Private Sub btn_cad_Click(sender As Object, e As EventArgs) Handles btn_cad.Click
        tab_cad.BringToFront()
        tab_cons.SendToBack()
    End Sub
    Private Sub btn_cons_Click(sender As Object, e As EventArgs) Handles btn_cons.Click
        tab_cons.BringToFront()
        tab_cad.SendToBack()
    End Sub
    Private Sub img_foto_usuario_Click(sender As Object, e As EventArgs) Handles img_foto_usuario.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & ".\fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto_usuario.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub btn_user_limp_Click(sender As Object, e As EventArgs) Handles btn_user_limp.Click
        txt_cad_nome.Clear()
        txt_cad_cpf.Clear()
        txt_email.Clear()
        txt_senha.Clear()
        txt_cad_nome.Focus()
        diretorio = ""
    End Sub
    Private Sub btn_user_salvar_Click(sender As Object, e As EventArgs) Handles btn_user_salvar.Click
        SQL = "SELECT * FROM tb_usuario WHERE cpf='" & txt_cad_cpf.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = True Then
            SQL = "INSERT INTO tb_usuario (nome,cpf,email,senha,foto) VALUES ('" & txt_cad_nome.Text &
                "', '" & txt_cad_cpf.Text & "', '" & txt_email.Text & "', '" & txt_senha.Text & "'," &
                "'" & diretorio & "')"
            rs = db.Execute(UCase(SQL))
            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        Else
            SQL = "UPDATE tb_usuario SET cpf= '" & txt_cad_cpf.Text & "', nome ='" & txt_cad_nome.Text & "'" &
                ", foto='" & diretorio & "', email = '" & txt_email.Text & "', senha ='" & txt_senha.Text & "'" &
                "WHERE id = '" & rs.Fields(0).Value & "'"
            rs = db.Execute(UCase(SQL))
            MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        End If
        txt_cad_nome.Clear()
        txt_cad_cpf.Clear()
        txt_email.Clear()
        txt_senha.Clear()
        txt_cad_nome.Focus()
        img_foto_usuario.Load(Application.StartupPath & "..\fotos\nova_foto.png")
        diretorio = ""
        carregar_emprestimos()
        carregar_livros()
        carregar_usuarios()
    End Sub
    Private Sub btn_cadl_limp_Click(sender As Object, e As EventArgs) Handles btn_cadl_limp.Click
        txt_cad_titulo.Clear()
        txt_cad_autor.Clear()
        txt_editora.Clear()
        txt_serie.Clear()
        txt_idioma.Clear()
        txt_qtd_pag.Value = 0
        dt_pub.Value = Today
        txt_isbn.Clear()
        txt_cad_titulo.Focus()
        diretorio = ""
    End Sub
    Private Sub btn_cadl_salv_Click(sender As Object, e As EventArgs) Handles btn_cadl_salv.Click
        SQL = "SELECT * FROM tb_livro WHERE isbn='" & txt_isbn.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = True Then
            SQL = "INSERT INTO tb_livro (isbn,titulo,autor,editora,paginas,dt_pub,idioma,serie,quant,capa) VALUES (" &
                "'" & txt_isbn.Text & "', '" & txt_cad_titulo.Text & "', '" & txt_cad_autor.Text & "'," &
                "'" & txt_editora.Text & "', '" & txt_qtd_pag.Value & "', '" & dt_pub.Value & "'," &
                "'" & txt_idioma.Text & "', '" & txt_serie.Text & "', '" & txt_qtd_livros.Value & "'," &
                "'" & diretorio & "')"
            rs = db.Execute(UCase(SQL))
            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        Else
            SQL = "UPDATE tb_livro SET isbn= '" & txt_isbn.Text & "', titulo ='" & txt_cad_titulo.Text & "'" &
                ", capa='" & diretorio & "', autor = '" & txt_cad_autor.Text & "', editora ='" & txt_editora.Text & "'" &
                ", paginas='" & txt_qtd_pag.Value & "', dt_pub = '" & dt_pub.Value & "', idioma ='" & txt_idioma.Text & "'" &
                ", serie='" & txt_serie.Text & "', quant = '" & txt_qtd_livros.Value & "'" &
                "WHERE id = '" & rs.Fields(0).Value & "'"
            rs = db.Execute(UCase(SQL))
            MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        End If
        txt_cad_titulo.Clear()
        txt_cad_autor.Clear()
        txt_editora.Clear()
        txt_serie.Clear()
        txt_idioma.Clear()
        txt_qtd_pag.Value = 0
        dt_pub.Value = Today
        txt_isbn.Clear()
        txt_cad_titulo.Focus()
        img_capa_livro.Load(Application.StartupPath & "..\fotos\nova_foto.png")
        diretorio = ""
        carregar_emprestimos()
        carregar_livros()
        carregar_usuarios()
    End Sub
    Private Sub img_capa_livro_Click(sender As Object, e As EventArgs) Handles img_capa_livro.Click
        Try
            With OpenFileDialog2
                .Title = "SELECIONE UMA CAPA"
                .InitialDirectory = Application.StartupPath & ".\fotos"
                .ShowDialog()
                diretorio = .FileName
                img_capa_livro.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub btn_emp_salv_Click(sender As Object, e As EventArgs) Handles btn_emp_salv.Click
        SQL = "SELECT * FROM tb_emprestimo WHERE cpf='" & txt_emp_cpf.Text & "' and isbn = '" & txt_emp_isbn.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = True Then
            SQL = "INSERT INTO tb_emprestimo (cpf,isbn,dt_emprestimo,dt_devol,dt_prev) VALUES ('" & txt_emp_cpf.Text &
                "', '" & txt_emp_isbn.Text & "', '" & dt_emp_emp.Value & "', '" & dt_emp_devol.Value & "'," &
                "'" & dt_emp_prev.Value & "')"
            rs = db.Execute(UCase(SQL))
            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        Else
            SQL = "UPDATE tb_emprestimo SET cpf= '" & txt_emp_cpf.Text & "', isbn ='" & txt_emp_isbn.Text & "'" &
                ", dt_prev='" & dt_emp_prev.Value & "', dt_emprestimo = '" & dt_emp_emp.Value & "', dt_devol ='" & dt_emp_devol.Value & "'" &
                "WHERE id = '" & rs.Fields(0).Value & "'"
            rs = db.Execute(UCase(SQL))
            MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        End If
        txt_emp_cpf.Clear()
        txt_emp_nome.Clear()
        txt_emp_titulo.Clear()
        txt_emp_isbn.Clear()
        dt_emp_emp.Value = Today
        dt_emp_devol.Value = Today
        dt_emp_prev.Value = Today
        txt_emp_cpf.Focus()
        previa = Today
        carregar_emprestimos()
        carregar_livros()
        carregar_usuarios()
    End Sub
    Private Sub btn_emp_limp_Click(sender As Object, e As EventArgs) Handles btn_emp_limp.Click
        txt_emp_cpf.Clear()
        txt_emp_nome.Clear()
        txt_emp_titulo.Clear()
        txt_emp_isbn.Clear()
        dt_emp_emp.Value = Today
        dt_emp_devol.Value = Today
        dt_emp_prev.Value = Today
        txt_emp_cpf.Focus()
        previa = ""
        carregar_emprestimos()
        carregar_livros()
        carregar_usuarios()
    End Sub
    Private Sub dt_emp_emp_valueChanged(sender As Object, e As EventArgs) Handles dt_emp_emp.ValueChanged
        previa = DateAdd(DateInterval.Day, 30, dt_emp_emp.Value)
        dt_emp_prev.Value = previa
    End Sub
    Private Sub txt_emp_isbn_LostFocus(sender As Object, e As EventArgs) Handles txt_emp_isbn.LostFocus
        SQL = "SELECT * FROM tb_livro WHERE isbn = '" & txt_emp_isbn.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = False Then
            txt_emp_titulo.Text = rs.Fields(2).Value
        End If
    End Sub
    Private Sub txt_emp_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_emp_cpf.LostFocus
        SQL = "SELECT * FROM tb_usuario WHERE cpf = '" & txt_emp_cpf.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = False Then
            txt_emp_nome.Text = rs.Fields(1).Value
        End If
    End Sub
    Private Sub dgv_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellContentClick
        Try
            With dgv_usuarios
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_nome = .CurrentRow.Cells(1).Value
                    SQL = "SELECT * FROM tb_usuario WHERE nome = '" & aux_nome & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        tab_cad.BringToFront()
                        tab_cad.SelectTab(0)
                        diretorio = rs.Fields(6).Value
                        txt_cad_nome.Text = rs.Fields(1).Value
                        txt_cad_cpf.Text = rs.Fields(2).Value
                        txt_email.Text = rs.Fields(3).Value
                        txt_senha.Text = rs.Fields(4).Value
                        img_foto_usuario.Load(rs.Fields(6).Value)
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_nome = .CurrentRow.Cells(1).Value
                    SQL = "SELECT * FROM tb_usuario WHERE nome = '" & aux_nome & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente excluir o usuário " & aux_nome & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO!")
                        If resp = MsgBoxResult.Yes Then
                            SQL = "DELETE FROM tb_usuario WHERE nome = '" & aux_nome & "'"
                            rs = db.Execute(SQL)
                            carregar_usuarios()
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
    Private Sub dgv_livros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_livros.CellContentClick
        Try
            With dgv_livros
                If .CurrentRow.Cells(7).Selected = True Then
                    SQL = "SELECT * FROM tb_livro WHERE isbn = '" & .CurrentRow.Cells(1).Value & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        tab_cad.BringToFront()
                        tab_cad.SelectTab(2)
                        txt_emp_isbn.Text = rs.Fields(1).Value
                        txt_emp_titulo.Text = rs.Fields(2).Value
                    End If
                ElseIf .CurrentRow.Cells(8).Selected = True Then
                    SQL = "SELECT * FROM tb_livro WHERE isbn = '" & .CurrentRow.Cells(1).Value & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        tab_cad.BringToFront()
                        tab_cad.SelectTab(1)
                        diretorio = rs.Fields(11).Value
                        txt_isbn.Text = rs.Fields(1).Value
                        txt_cad_titulo.Text = rs.Fields(2).Value
                        txt_cad_autor.Text = rs.Fields(3).Value
                        txt_editora.Text = rs.Fields(4).Value
                        txt_qtd_pag.Text = rs.Fields(5).Value
                        dt_pub.Value = rs.Fields(6).Value
                        txt_idioma.Text = rs.Fields(7).Value
                        txt_serie.Text = rs.Fields(8).Value
                        txt_qtd_livros.Text = rs.Fields(10).Value
                        txt_qtd_pag.Text = rs.Fields(5).Value
                        img_capa_livro.Load(rs.Fields(11).Value)
                    End If
                ElseIf .CurrentRow.Cells(9).Selected = True Then
                    SQL = "SELECT * FROM tb_livro WHERE isbn = '" & .CurrentRow.Cells(1).Value & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente excluir o livro " & rs.Fields(2).Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO!")
                        If resp = MsgBoxResult.Yes Then
                            SQL = "DELETE FROM tb_livro WHERE isbn = '" & .CurrentRow.Cells(1).Value & "'"
                            rs = db.Execute(SQL)
                            carregar_livros()
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
    Private Sub dgv_emprestimos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_emprestimos.CellContentClick
        Try
            With dgv_emprestimos
                If .CurrentRow.Cells(7).Selected = True Then
                    SQL = "SELECT * FROM tb_emprestimo WHERE id = '" & .CurrentRow.Cells(1).Value & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        tab_cad.BringToFront()
                        tab_cad.SelectTab(2)
                        txt_emp_isbn.Text = rs.Fields(1).Value
                        txt_emp_cpf.Text = rs.Fields(2).Value
                        dt_emp_emp.Value = rs.Fields(3).Value
                        dt_emp_prev.Value = rs.Fields(4).Value
                        dt_emp_devol.Value = rs.Fields(5).Value
                    End If
                ElseIf .CurrentRow.Cells(8).Selected = True Then
                    SQL = "SELECT * FROM tb_emprestimo WHERE id = '" & .CurrentRow.Cells(1).Value & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente excluir o empréstimo nº" & rs.Fields(0).Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO!")
                        If resp = MsgBoxResult.Yes Then
                            SQL = "DELETE FROM tb_emprestimo WHERE id = '" & .CurrentRow.Cells(1).Value & "'"
                            rs = db.Execute(SQL)
                            carregar_emprestimos()
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
End Class
