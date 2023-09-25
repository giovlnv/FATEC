Module Module1
    Public diretorio, SQL, aux_nome, resp, quant As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public cont As Integer
    Public brutus, inss, liquid, qtd As Double
    Sub carregar_pesq()
        Try
            With cad_funcionarios.cbbx_pesq.Items
                .Add("Nome")
                .Add("Cargo")
            End With
            cad_funcionarios.cbbx_pesq.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        End Try
    End Sub
    Sub carregar_tipo()
        Try
            With cad_funcionarios.cbbx_cargo.Items
                .Add("ANALISTA")
                .Add("CEO")
                .Add("ENGENHEIRO")
                .Add("ESTAGIÁRIO")
                .Add("GERENTE")
                .Add("SUPERVISOR")
                .Add("PROGRAMADOR")
                .Add("ZELADOR")
            End With
            cad_funcionarios.cbbx_cargo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        End Try
    End Sub
    Sub carregar_dados()
        Try
            SQL = "SELECT nome,cargo,salarioBruto,salarioLiquido FROM tb_funcionario ORDER BY nome ASC"
            rs = db.Execute(SQL)
            With cad_funcionarios.dgv_info
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
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=GIGIBIGS\SQL2022;Initial Catalog=cad_funcionario;trusted_connection=yes;")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module
