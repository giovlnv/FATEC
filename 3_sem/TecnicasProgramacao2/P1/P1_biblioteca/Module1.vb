Module Module1
    Public diretorio, SQL, aux_nome, resp, quant As String
    Public previa As Date
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public cont As Integer
    Sub carregar_usuarios()
        Try
            SQL = "SELECT nome,email,saldo FROM tb_usuario ORDER BY nome ASC"
            rs = db.Execute(SQL)
            With Biblioteca.dgv_usuarios
                .Rows.Clear()
                cont = 1
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                    cont += 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Sub carregar_livros()
        Try
            SQL = "SELECT isbn,titulo,autor,serie,quant,ds_status FROM tb_livro ORDER BY titulo ASC"
            rs = db.Execute(SQL)
            With Biblioteca.dgv_livros
                .Rows.Clear()
                cont = 1
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing, Nothing)
                    cont += 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Sub carregar_emprestimos()
        Try
            SQL = "SELECT id,isbn,cpf,dt_emprestimo,dt_prev,dt_devol FROM tb_emprestimo ORDER BY dt_emprestimo DESC"
            rs = db.Execute(SQL)
            With Biblioteca.dgv_emprestimos
                .Rows.Clear()
                cont = 1
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
                    cont += 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=GIGIBIGS\SQL2022;Initial Catalog=p1_biblio;trusted_connection=yes;")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module
