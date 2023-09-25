Module Module1
    Public diretorio, SQL, aux_n, resp As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public cont As Integer
    Sub carregar_tipo()
        Try
            With frm_func.cmb_tipo.Items
                .Add("Nome")
                .Add("Cargo")
            End With
            frm_func.cmb_tipo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        End Try
    End Sub
    Sub carregar_cargo()
        Try
            With frm_func.menu_cargo.Items
                .Add("Analista de Marketing")
                .Add("CEO")
                .Add("Contador")
                .Add("Desenvolvedor de Software")
                .Add("Gerente de Operações")
                .Add("Gerente de RH")
                .Add("Suporte ao Cliente")
                .Add("Vendedor")
            End With
            frm_func.menu_cargo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        End Try
    End Sub
    Sub carregar_dados()
        Try
            SQL = "select * from tb_cadastro order by nome asc"
            rs = db.Execute(SQL)
            With frm_func.dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=GIGIBIGS\SQL2022;Initial Catalog=crud_0409;trusted_connection=yes;")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Module
