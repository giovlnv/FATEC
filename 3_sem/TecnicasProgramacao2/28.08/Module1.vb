Module Module1
    Public diretorio, SQL, aux_cpf, resp As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public cont As Integer

    Sub carregar_tipo()
        Try
            With frm_clientes.cmb_tipo.Items
                .Add("CPF")
                .Add("Nome")
            End With
            frm_clientes.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        End Try
    End Sub

    Sub carregar_dados()
        Try
            SQL = "select * from tb_cadastro order by nome asc"
            rs = db.Execute(SQL)
            With frm_clientes.dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=GIGIBIGS\SQL2022;Initial Catalog=prj_2808;trusted_connection=yes;")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Module
