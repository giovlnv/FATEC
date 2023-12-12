using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic;

namespace leevre
{

    public partial class frmLeevre : Form
    {
        byte dias_para_devolver = 30;
        SqlConnection conexao;
        SqlCommand comando;
        String SQL;
        String sqlSelecionaUsuarios = "select cpf as CPF, nome as Nome, email as Email from tb_usuarios";
        String sqlSelecionaLivros = "select isbn as ISBN, titulo as Titulo, autor as Autor, editora as Editora," +
                                    "qtd_paginas as Paginas, qtd_disponivel as Estoque, dt_publicacao as Publica��o," +
                                    "case when qtd_disponivel > 0 then 'sim' else 'n�o' end as Dispon�vel from tb_livros";
        String sqlSelecionaEmprestimos = "select id, isbn as ISBN, titulo as T�tulo, cpf as CPF, nome as Nome, dt_emprestimo as 'Emprestado em'," +
                                         "dt_previsao_devolucao as 'Prev. devolu��o', dt_devolucao as 'Devolvido em' from tb_emprestimos";



        public frmLeevre()
        {
            InitializeComponent();
            tbcCadastros.BringToFront();
        }


        private void frmLeevre_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=GIGIBIGS\\SQL2022;Initial Catalog=biblioteca_leevre;Integrated Security=True");
                MessageBox.Show("Conex�o bem sucedida com o banco!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizaDgvUsuarios();
                atualizaDgvLivros();
                atualizaDgvEmprestimos();
                limparDadosCadastro("usuario");
                limparDadosCadastro("livro");
                limparDadosCadastro("emprestimo");

            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o banco!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }

        }

        private void atualizaDgvUsuarios()
        {
            SQL = sqlSelecionaUsuarios;
            SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
            DataSet tabela_usuarios = new DataSet();
            data.Fill(tabela_usuarios);
            dgvConsultaUsuarios.DataSource = tabela_usuarios.Tables[0];
            dgvConsultaUsuarios.Refresh();
        }


        private void atualizaDgvLivros()
        {
            SQL = sqlSelecionaLivros;
            SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
            DataSet tabela_livros = new DataSet();
            data.Fill(tabela_livros);
            dgvConsultaLivros.DataSource = tabela_livros.Tables[0];
            dgvConsultaLivros.Refresh();
        }

        private void atualizaDgvEmprestimos()
        {
            SQL = sqlSelecionaEmprestimos;
            SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
            DataSet tabela_emprestimos = new DataSet();
            data.Fill(tabela_emprestimos);
            dgvConsultaEmprestimos.DataSource = tabela_emprestimos.Tables[0];
            dgvConsultaEmprestimos.Refresh();
        }

        public void atualizaEstoque(string ISBN)
        {
            try
            {
                ISBN = limpaTextos(ISBN);
                if (conexao.State == ConnectionState.Closed) conexao.Open();
                SQL = "update tb_livros set qtd_disponivel = qtd_total - (select count(id) from tb_emprestimos where isbn=@ID and dt_devolucao is null) " +
                    " where isbn=@ID";
                comando = new SqlCommand(SQL, conexao);
                comando.Parameters.AddWithValue("@ID", ISBN);
                comando.ExecuteNonQuery();
                SQL = "update tb_livros set flag_disponivel = CASE WHEN qtd_disponivel <= 0 then 0 ELSE 1 END";
                comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
                atualizaDgvLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o estoque. " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }

        }

        private string limpaTextos(string s)
        {
            s = s.Replace("-", "").Replace(".", "").Replace(" ", "");
            return s;
        }

        public void limparDadosCadastro(String formulario)
        {
            switch (formulario)
            {
                case "usuario":
                    lblEditarUsuario.Visible = false;
                    btnNovoUsuariaLimpar.Text = "limpar";
                    btnNovoUsuarioCadastrar.Text = "cadastrar";
                    txtNovoUsuarioCPF.Clear();
                    txtNovoUsuarioEmail.Clear();
                    txtNovoUsuarioNome.Clear();
                    txtNovoUsuarioSenha.Clear();
                    lblEditarUsuario.Visible = false;
                    imgNovoUsuario.Image = imgNovoUsuario.InitialImage;
                    break;

                case "livro":
                    lblEditarLivro.Visible = false;
                    btnNovoLivroCadastrar.Text = "cadastrar";
                    btnNovoLivroLimpar.Text = "limpar";
                    numNovoLivroQtd.Minimum = 0;
                    txtNovoLivroAutor.Clear();
                    txtNovoLivroEditora.Clear();
                    txtNovoLivroIdioma.Clear();
                    txtNovoLivroISBN.Clear();
                    txtNovoLivroSerie.Clear();
                    txtNovoLivroTitulo.Clear();
                    numNovoLivroPaginas.Value = 1;
                    numNovoLivroQtd.Value = 0;
                    dtNovoLivroPublicacao.MaxDate = DateTime.Now.AddMinutes(1);
                    dtNovoLivroPublicacao.Value = DateTime.Now;
                    lblEditarLivro.Visible = false;
                    imgNovoLivro.Image = imgNovoLivro.InitialImage;
                    break;

                case "emprestimo":
                    btnNovoEmprestimoCadastrar.Text = "cadastrar";
                    btnNovoEmprestimoLimpar.Text = "limpar";
                    txtNovoEmprestimoISBN.Enabled = true;
                    chkNovoEmprestimoDevolvido.Checked = false;
                    txtNovoEmprestimoCPF.Clear();
                    txtNovoEmprestimoISBN.Clear();
                    txtNovoEmprestimoNome.Clear();
                    txtNovoEmprestimoTitulo.Clear();
                    dtNovoEmprestimoData.MaxDate = DateTime.Now.AddMinutes(1);
                    dtNovoEmprestimoData.Value = DateTime.Now;
                    dtNovoEmprestimoPrevisao.Value = DateTime.Now.AddDays(dias_para_devolver);
                    dtNovoEmprestimoDevolucao.Value = DateTime.Now;
                    lblEditarEmprestimo.Visible = false;
                    lblEmprestimoID.Visible = false;
                    break;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tbcConsulta.BringToFront();
            toolStripButton2.BackColor = Color.Black;
            toolStripButton2.ForeColor = Color.White;
            toolStripButton1.BackColor = Color.White;
            toolStripButton1.ForeColor = Color.Black;
            limparDadosCadastro("usuario");
            limparDadosCadastro("livro");
            limparDadosCadastro("emprestimo");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tbcCadastros.BringToFront();
            toolStripButton2.BackColor = Color.White;
            toolStripButton2.ForeColor = Color.Black;
            toolStripButton1.BackColor = Color.Black;
            toolStripButton1.ForeColor = Color.White;
        }

        /*---------------------------------------------------------------------------------------------------------------------------
         * --------------------------------------------------- RELACIONADOS AOS USU�RIOS  -------------------------------------------
         * ---------------------------------------------------------------------------------------------------------------------------*/

        private void btnNovoUsuariaLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblEditarUsuario.Visible)
                {
                    DialogResult resposta = MessageBox.Show("Caso exclua o usu�rio, todos os empr�stimos associados � ele tamb�m ser�o exlu�dos. \nDeseja prosseguir com a exclus�o?", "Excluir usu�rio", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resposta == DialogResult.Yes)
                    {
                        if (conexao.State == ConnectionState.Closed) if (conexao.State == ConnectionState.Closed) conexao.Open();
                        SQL = "delete from tb_emprestimos where cpf=@CPF; delete from tb_usuarios where cpf=@CPF";
                        comando = new SqlCommand(SQL, conexao);
                        comando.Parameters.AddWithValue("@CPF", limpaTextos(txtNovoUsuarioCPF.Text));
                        comando.ExecuteNonQuery();
                        limparDadosCadastro("usuario");
                        atualizaDgvUsuarios();
                        atualizaDgvEmprestimos();
                        MessageBox.Show("Usu�rio e empr�stimos exclu�dos com sucesso.", "Usu�rio exclu�do", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    limparDadosCadastro("usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O sistema retornou a seguinte mensagem:\n" + ex.Message, "Algo deu errado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }
        }


        private void tabUsuarioNovo_Leave(object sender, EventArgs e)
        {
            limparDadosCadastro("usuario");
        }

        private void btnNovoUsuarioCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (lblEditarUsuario.Visible)
                {
                    SQL = "update tb_usuarios set nome=@NOME,email=@EMAIL,senha=@SENHA, dir_img=@IMAGEM where cpf=@CPF";
                }
                else
                {
                    SQL = "insert into tb_usuarios (cpf, nome, email, senha, dir_img) values (@CPF,@NOME,@EMAIL,@SENHA, @IMAGEM)";
                }

                if (limpaTextos(txtNovoUsuarioCPF.Text).Length != 11)
                {
                    MessageBox.Show("CPF inv�lido. Digite todos os d�gitos, incluindo zeros � esquerda.", "Usu�rio n�o cadastrado");
                }
                else if (string.IsNullOrEmpty(txtNovoUsuarioEmail.Text)
                        || string.IsNullOrEmpty(txtNovoUsuarioNome.Text)
                        || string.IsNullOrEmpty(txtNovoUsuarioSenha.Text)
                        )
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                }
                else
                {
                    if (conexao.State == ConnectionState.Closed) conexao.Open();
                    comando = new SqlCommand(SQL, conexao);
                    comando.Parameters.AddWithValue("@CPF", limpaTextos(txtNovoUsuarioCPF.Text));
                    comando.Parameters.AddWithValue("@NOME", txtNovoUsuarioNome.Text.ToUpper());
                    comando.Parameters.AddWithValue("@EMAIL", txtNovoUsuarioEmail.Text.ToUpper());
                    comando.Parameters.AddWithValue("@SENHA", txtNovoUsuarioSenha.Text);
                    if (lblNovoUsuarioImagem.Text == "" || lblNovoUsuarioImagem.Text.Equals(null))
                    {
                        comando.Parameters.AddWithValue("@IMAGEM", DBNull.Value);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@IMAGEM", lblNovoUsuarioImagem.Text);
                    }
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dados gravados com sucesso!", "Usu�rio Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizaDgvUsuarios();
                    limparDadosCadastro("usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar dados! O sistema retornou a seguinte mensagem: \n" + ex.Message, "Usu�rio n�o cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }
        }


        private void txtNovoUsuarioCPF_Leave(object sender, EventArgs e)
        {
            try
            {
                string confirma_senha, senha;
                if (conexao.State == ConnectionState.Closed) conexao.Open();
                SQL = "select nome, email, senha, dir_img from tb_usuarios where cpf = '" + limpaTextos(txtNovoUsuarioCPF.Text) + "'";
                SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                senha = tabela.Tables[0].Rows[0]["senha"].ToString();
                confirma_senha = Interaction.InputBox("Usu�rio j� existente! Para qualquer altera��o informe a senha.");
                if (confirma_senha != senha)
                {
                    MessageBox.Show("Senha incorreta!", "Senha inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNovoUsuarioCPF.Focus();
                    throw new Exception("Senha incorreta");
                }
                btnNovoUsuarioCadastrar.Text = "atualizar";
                btnNovoUsuariaLimpar.Text = "excluir";
                txtNovoUsuarioNome.Text = tabela.Tables[0].Rows[0]["nome"].ToString();
                txtNovoUsuarioEmail.Text = tabela.Tables[0].Rows[0]["email"].ToString();
                txtNovoUsuarioSenha.Text = tabela.Tables[0].Rows[0]["senha"].ToString();
                lblNovoUsuarioImagem.Text = tabela.Tables[0].Rows[0]["dir_img"].ToString();
                if (!(lblNovoUsuarioImagem.Text == "" || lblNovoUsuarioImagem.Text.Equals(null)))
                {
                    imgNovoUsuario.Image = System.Drawing.Image.FromFile(lblNovoUsuarioImagem.Text);
                }
                else
                {
                    imgNovoUsuario.Image = imgNovoUsuario.InitialImage;
                }
                lblEditarUsuario.Visible = true;
            }
            catch (Exception ex)
            {
                btnNovoUsuarioCadastrar.Text = "cadastrar";
                btnNovoUsuariaLimpar.Text = "limpar";
                txtNovoUsuarioNome.Clear();
                txtNovoUsuarioEmail.Clear();
                txtNovoUsuarioSenha.Clear();
                lblEditarUsuario.Visible = false;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }
        }

        private void dgvConsultaUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbcCadastros.SelectedTab = tabUsuarioNovo;
            tbcCadastros.BringToFront();
            toolStripButton2.BackColor = Color.White;
            toolStripButton2.ForeColor = Color.Black;
            toolStripButton1.BackColor = Color.Black;
            toolStripButton1.ForeColor = Color.White;
            txtNovoUsuarioCPF.Text = dgvConsultaUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtNovoUsuarioCPF.Focus();
            txtNovoUsuarioEmail.Focus();
        }

        private void imgNovoUsuario_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Drawing.Image novo_usuario_foto = System.Drawing.Image.FromFile(ofd.FileName);
                imgNovoUsuario.Image = novo_usuario_foto;
                lblNovoUsuarioImagem.Text = ofd.FileName;
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------
         * --------------------------------------------------- RELACIONADOS AOS LIVROS ----------------------------------------------
         * ---------------------------------------------------------------------------------------------------------------------------*/


        private void btnNovoLivroCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                byte disponivel = 0;
                if (lblEditarLivro.Visible)
                {
                    SQL = "update tb_livros set titulo=@TITULO,autor=@AUTOR,serie=@SERIE, editora=@EDITORA, idioma=@IDIOMA, qtd_paginas=@QTD_PAGINAS," +
                        "qtd_total=@QTD_DISPONIVEL, dt_publicacao=@DT_PUBLICACAO, flag_disponivel=@FLAG_DISPONIVEL, dir_img=@IMAGEM where isbn=@ISBN";
                }
                else
                {
                    SQL = "insert into tb_livros values (@ISBN,@TITULO,@AUTOR,@SERIE, @EDITORA, @IDIOMA, @QTD_PAGINAS," +
                    "@QTD_DISPONIVEL, @DT_PUBLICACAO, @FLAG_DISPONIVEL,@QTD_DISPONIVEL,@IMAGEM)";
                }

                if (limpaTextos(txtNovoLivroISBN.Text).Length != 13)
                {
                    MessageBox.Show("ISBN inv�lido. Digite todos os d�gitos, incluindo zeros � esquerda.", "Livro n�o cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(txtNovoLivroTitulo.Text)
                        || string.IsNullOrEmpty(txtNovoLivroAutor.Text)
                        || string.IsNullOrEmpty(txtNovoLivroSerie.Text)
                        || string.IsNullOrEmpty(txtNovoLivroEditora.Text)
                        || string.IsNullOrEmpty(txtNovoLivroIdioma.Text)
                        )
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                }
                else if (numNovoLivroPaginas.Value == 0)
                {
                    MessageBox.Show("Um livro n�o pode ter 0 p�ginas", "Livro n�o cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (conexao.State == ConnectionState.Closed) conexao.Open();
                    if (numNovoLivroQtd.Value > 0) disponivel = 1;
                    comando = new SqlCommand(SQL, conexao);
                    comando.Parameters.AddWithValue("@ISBN", limpaTextos(txtNovoLivroISBN.Text));
                    comando.Parameters.AddWithValue("@TITULO", txtNovoLivroTitulo.Text.ToUpper());
                    comando.Parameters.AddWithValue("@AUTOR", txtNovoLivroAutor.Text.ToUpper());
                    comando.Parameters.AddWithValue("@SERIE", txtNovoLivroSerie.Text.ToUpper());
                    comando.Parameters.AddWithValue("@EDITORA", txtNovoLivroEditora.Text.ToUpper());
                    comando.Parameters.AddWithValue("@IDIOMA", txtNovoLivroIdioma.Text.ToUpper());
                    comando.Parameters.AddWithValue("@QTD_PAGINAS", numNovoLivroPaginas.Value);
                    comando.Parameters.AddWithValue("@QTD_DISPONIVEL", numNovoLivroQtd.Value);
                    comando.Parameters.AddWithValue("@DT_PUBLICACAO",
                        dtNovoLivroPublicacao.Value.Day.ToString() + "-" + dtNovoLivroPublicacao.Value.Month.ToString() + "-"
                        + dtNovoLivroPublicacao.Value.Year.ToString());
                    comando.Parameters.AddWithValue("@FLAG_DISPONIVEL", disponivel);
                    comando.Parameters.AddWithValue("@IMAGEM", imgNovoLivro.ImageLocation);
                    comando.ExecuteNonQuery();
                    atualizaEstoque(txtNovoLivroISBN.Text);
                    atualizaDgvLivros();
                    limparDadosCadastro("livro");
                    MessageBox.Show("Dados gravados com sucesso!", "Livro Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar os dados. O sistema retornou a seguinte mensagem: \n" + ex.Message, "Livro n�o cadastrado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }
        }


        private void btnNovoLivroLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblEditarLivro.Visible)
                {
                    DialogResult resposta = MessageBox.Show("Caso exclua o livro, todos os empr�stimos associados � ele tamb�m ser�o exlu�dos.\nCaso queira apenas zerar o estoque, diminua o campo de 'Quantidade' at� o m�nimo.\nDeseja prosseguir com a exclus�o?", "Excluir empr�stimo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resposta == DialogResult.Yes)
                    {
                        if (conexao.State == ConnectionState.Closed) if (conexao.State == ConnectionState.Closed) conexao.Open();
                        SQL = "delete from tb_emprestimos where isbn=@ISBN; delete from tb_livros where isbn=@ISBN";
                        comando = new SqlCommand(SQL, conexao);
                        comando.Parameters.AddWithValue("@ISBN", limpaTextos(txtNovoLivroISBN.Text));
                        comando.ExecuteNonQuery();
                        limparDadosCadastro("livro");
                        atualizaDgvLivros();
                        atualizaDgvEmprestimos();
                        MessageBox.Show("Livro e empr�stimos exclu�dos com sucesso.", "Livro exclu�do", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    limparDadosCadastro("livro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O sistema retornou a seguinte mensagem:\n" + ex.Message, "Algo deu errado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }

        }


        private void txtNovoLivroISBN_Leave(object sender, EventArgs e)
        {
            try
            {
                if (conexao.State == ConnectionState.Closed) conexao.Open();
                SQL = "select titulo, autor, editora, serie, idioma, qtd_paginas, qtd_total, (qtd_total - qtd_disponivel) as qtd_emprestados, dt_publicacao, dir_img from tb_livros where isbn = '" + limpaTextos(txtNovoLivroISBN.Text) + "'";
                SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                btnNovoLivroCadastrar.Text = "atualizar";
                btnNovoLivroLimpar.Text = "excluir";
                txtNovoLivroTitulo.Text = tabela.Tables[0].Rows[0]["titulo"].ToString();
                txtNovoLivroAutor.Text = tabela.Tables[0].Rows[0]["autor"].ToString();
                txtNovoLivroEditora.Text = tabela.Tables[0].Rows[0]["editora"].ToString();
                txtNovoLivroSerie.Text = tabela.Tables[0].Rows[0]["serie"].ToString();
                txtNovoLivroIdioma.Text = tabela.Tables[0].Rows[0]["idioma"].ToString();
                numNovoLivroPaginas.Value = Convert.ToInt32(tabela.Tables[0].Rows[0]["qtd_paginas"].ToString());
                numNovoLivroQtd.Value = Convert.ToInt32(tabela.Tables[0].Rows[0]["qtd_total"].ToString());
                dtNovoLivroPublicacao.Text = tabela.Tables[0].Rows[0]["dt_publicacao"].ToString();
                lblNovoLivroImagem.Text = tabela.Tables[0].Rows[0]["dir_img"].ToString();
                numNovoLivroQtd.Minimum = Convert.ToInt32(tabela.Tables[0].Rows[0]["qtd_emprestados"].ToString());
                if (lblNovoLivroImagem.Text == "" || lblNovoLivroImagem.Text.Equals(null))
                {
                    imgNovoLivro.Image = imgNovoLivro.InitialImage;
                }
                else
                {
                    imgNovoLivro.Image = System.Drawing.Image.FromFile(lblNovoLivroImagem.Text);
                }

                if (lblEditarLivro.Visible != true) MessageBox.Show("O livro j� existe. Prossiga para atualiz�-lo.", "Atualizar livro.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblEditarLivro.Visible = true;
            }
            catch
            {
                lblEditarLivro.Visible = false;
                btnNovoLivroCadastrar.Text = "cadastrar";
                btnNovoLivroLimpar.Text = "limpar";
                txtNovoLivroTitulo.Clear();
                txtNovoLivroAutor.Clear();
                txtNovoLivroEditora.Clear();
                txtNovoLivroSerie.Clear();
                txtNovoLivroIdioma.Clear();
                numNovoLivroPaginas.Value = 1;
                numNovoLivroQtd.Value = 0;
                dtNovoLivroPublicacao.Text = DateTime.Now.ToString();
                numNovoLivroQtd.Minimum = 0;
                imgNovoLivro.Image = imgNovoLivro.InitialImage;

            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }
        }


        private void dgvConsultaLivros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblEditarLivro.Visible = true;
            tbcCadastros.SelectedTab = tabLivroNovo;
            tbcCadastros.BringToFront();
            toolStripButton2.BackColor = Color.White;
            toolStripButton2.ForeColor = Color.Black;
            toolStripButton1.BackColor = Color.Black;
            toolStripButton1.ForeColor = Color.White;
            btnNovoLivroCadastrar.Text = "atualizar";
            btnNovoLivroLimpar.Text = "excluir";
            txtNovoLivroISBN.Text = dgvConsultaLivros.CurrentRow.Cells[0].Value.ToString();
            txtNovoLivroISBN.Focus();
            txtNovoLivroTitulo.Focus();
        }


        private void imgNovoLivro_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Drawing.Image novo_livro_foto = System.Drawing.Image.FromFile(ofd.FileName);
                imgNovoLivro.Image = novo_livro_foto;
                imgNovoLivro.ImageLocation = ofd.FileName;
            }

        }

        /*---------------------------------------------------------------------------------------------------------------------------
         * --------------------------------------------------- RELACIONADOS AOS EMPR�STIMOS -----------------------------------------
         * ---------------------------------------------------------------------------------------------------------------------------*/

        private void btnNovoEmprestimoLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblEditarEmprestimo.Visible)
                {
                    DialogResult resposta = MessageBox.Show("Deseja realmente excluir o empr�stimo?", "Excluir empr�stimo", MessageBoxButtons.YesNo);
                    if (resposta == DialogResult.Yes)
                    {
                        if (conexao.State == ConnectionState.Closed) if (conexao.State == ConnectionState.Closed) conexao.Open();
                        SQL = "delete from tb_emprestimos where id=@ID";
                        comando = new SqlCommand(SQL, conexao);
                        comando.Parameters.AddWithValue("@ID", Convert.ToInt32(lblEmprestimoID.Text));
                        comando.ExecuteNonQuery();
                        atualizaEstoque(txtNovoEmprestimoISBN.Text);
                        limparDadosCadastro("emprestimo");
                        atualizaDgvEmprestimos();
                        MessageBox.Show("Empr�stimo exclu�do com sucesso.", "Empr�stimo exclu�do", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    limparDadosCadastro("emprestimo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O sistema retornou a seguinte mensagem:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexao.State == ConnectionState.Open) if (conexao.State == ConnectionState.Open) conexao.Close();
            }
        }

        private void dtNovoEmprestimoData_ValueChanged(object sender, EventArgs e)
        {
            dtNovoEmprestimoPrevisao.Value = dtNovoEmprestimoData.Value.AddDays(dias_para_devolver);
        }

        private void txtNovoEmprestimoCPF_Leave(object sender, EventArgs e)
        {
            try
            {
                if (conexao.State == ConnectionState.Closed) conexao.Open();
                SQL = "select nome from tb_usuarios where cpf = '" + limpaTextos(txtNovoEmprestimoCPF.Text) + "'";
                SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                txtNovoEmprestimoNome.Text = tabela.Tables[0].Rows[0]["nome"].ToString();
            }
            catch
            {
                if (limpaTextos(txtNovoEmprestimoCPF.Text).Length > 0)
                {
                    MessageBox.Show("Somente usu�rios cadastrados podem realizarm empr�stimos", "�su�rio inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtNovoEmprestimoNome.Clear();
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }

        }

        private void chkNovoEmprestimoDevolvido_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNovoEmprestimoDevolvido.Checked)
            {
                dtNovoEmprestimoDevolucao.Visible = true;
            }
            else
            {
                dtNovoEmprestimoDevolucao.Visible = false;
            }
        }

        private void btnNovoEmprestimoCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                byte disponivel = 0;
                if (limpaTextos(txtNovoEmprestimoISBN.Text).Length != 13)
                {
                    MessageBox.Show("ISBN inv�lido. Digite todos os d�gitos, incluindo zeros � esquerda.", "Empr�stimo n�o registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (limpaTextos(txtNovoEmprestimoCPF.Text).Length != 11)
                {
                    MessageBox.Show("CNPJ inv�lido. Digite todos os d�gitos, incluindo zeros � esquerda.", "Empr�stimo n�o registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(limpaTextos(txtNovoEmprestimoCPF.Text))
                        || string.IsNullOrEmpty(txtNovoEmprestimoNome.Text)
                        || string.IsNullOrEmpty(limpaTextos(txtNovoEmprestimoISBN.Text))
                        || string.IsNullOrEmpty(txtNovoEmprestimoTitulo.Text)
                        )
                {
                    MessageBox.Show("O usu�rio e o livro precisam estar cadastrados.");
                }
                else
                {
                    if (numNovoLivroQtd.Value > 0) disponivel = 1;
                    if (conexao.State == ConnectionState.Closed) conexao.Open();
                    if (lblEditarEmprestimo.Visible)
                    {
                        SQL = "update tb_emprestimos set cpf=@CPF, nome=@NOME, isbn=@ISBN, titulo=@TITULO, dt_emprestimo=@DT_EMPRESTIMO, dt_previsao_devolucao=@DT_PREVISAO, dt_devolucao=@DT_DEVOLUCAO" +
                            " where id=@ID";

                        comando = new SqlCommand(SQL, conexao);

                        comando.Parameters.AddWithValue("@CPF", limpaTextos(txtNovoEmprestimoCPF.Text));
                        comando.Parameters.AddWithValue("@NOME", txtNovoEmprestimoNome.Text.ToUpper());
                        comando.Parameters.AddWithValue("@ISBN", limpaTextos(txtNovoEmprestimoISBN.Text));
                        comando.Parameters.AddWithValue("@TITULO", txtNovoEmprestimoTitulo.Text.ToUpper());
                        comando.Parameters.AddWithValue("@DT_EMPRESTIMO",
                            dtNovoEmprestimoData.Value.Day.ToString() + "-" + dtNovoEmprestimoData.Value.Month.ToString() + "-"
                            + dtNovoEmprestimoData.Value.Year.ToString());

                        comando.Parameters.AddWithValue("@DT_PREVISAO",
                            dtNovoEmprestimoPrevisao.Value.Day.ToString() + "-" + dtNovoEmprestimoPrevisao.Value.Month.ToString() + "-"
                            + dtNovoEmprestimoPrevisao.Value.Year.ToString());

                        if (chkNovoEmprestimoDevolvido.Checked)
                        {
                            comando.Parameters.AddWithValue("@DT_DEVOLUCAO",
                                dtNovoEmprestimoDevolucao.Value.Day.ToString() + "-" + dtNovoEmprestimoDevolucao.Value.Month.ToString() + "-"
                                + dtNovoEmprestimoDevolucao.Value.Year.ToString());
                        }
                        else
                        {
                            comando.Parameters.AddWithValue("@DT_DEVOLUCAO", DBNull.Value);
                        }

                        comando.Parameters.AddWithValue("@ID", Int32.Parse(lblEmprestimoID.Text));

                    }
                    else
                    {
                        SQL = "insert into tb_emprestimos (cpf, nome, isbn, titulo, dt_emprestimo, dt_previsao_devolucao, dt_devolucao)" +
                            "values (@CPF,@NOME,@ISBN,@TITULO, @DT_EMPRESTIMO, @DT_PREVISAO, @DT_DEVOLUCAO)";
                        comando = new SqlCommand(SQL, conexao);
                        comando.Parameters.AddWithValue("@CPF", limpaTextos(txtNovoEmprestimoCPF.Text));
                        comando.Parameters.AddWithValue("@NOME", txtNovoEmprestimoNome.Text.ToUpper());
                        comando.Parameters.AddWithValue("@ISBN", limpaTextos(txtNovoEmprestimoISBN.Text));
                        comando.Parameters.AddWithValue("@TITULO", txtNovoEmprestimoTitulo.Text.ToUpper());
                        comando.Parameters.AddWithValue("@DT_EMPRESTIMO",
                            dtNovoEmprestimoData.Value.Day.ToString() + "-" + dtNovoEmprestimoData.Value.Month.ToString() + "-"
                            + dtNovoEmprestimoData.Value.Year.ToString());
                        comando.Parameters.AddWithValue("@DT_PREVISAO",
                            dtNovoEmprestimoPrevisao.Value.Day.ToString() + "-" + dtNovoEmprestimoPrevisao.Value.Month.ToString() + "-"
                            + dtNovoEmprestimoPrevisao.Value.Year.ToString());
                        if (chkNovoEmprestimoDevolvido.Checked)
                        {
                            comando.Parameters.AddWithValue("@DT_DEVOLUCAO",
                                dtNovoEmprestimoDevolucao.Value.Day.ToString() + "-" + dtNovoEmprestimoDevolucao.Value.Month.ToString() + "-"
                                + dtNovoEmprestimoDevolucao.Value.Year.ToString());
                        }
                        else
                        {
                            comando.Parameters.AddWithValue("@DT_DEVOLUCAO", DBNull.Value);
                        }


                    }
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dados gravados com sucesso!", "Livro Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizaDgvEmprestimos();
                    if (conexao.State == ConnectionState.Open) conexao.Close();
                    atualizaEstoque(txtNovoEmprestimoISBN.Text);
                    limparDadosCadastro("emprestimo");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar os dados. O sistema retornou a seguinte mensagem: " + ex.Message, "Livro n�o cadastrado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }
        }

        private void txtNovoEmprestimoISBN_Leave(object sender, EventArgs e)
        {
            try
            {
                if (conexao.State == ConnectionState.Closed) conexao.Open();
                SQL = "select titulo from tb_livros where isbn = '" + limpaTextos(txtNovoEmprestimoISBN.Text) + "' and flag_disponivel = 1";
                SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                txtNovoEmprestimoTitulo.Text = tabela.Tables[0].Rows[0]["titulo"].ToString();
            }
            catch
            {
                if (lblEditarEmprestimo.Visible && limpaTextos(txtNovoEmprestimoISBN.Text) != dgvConsultaEmprestimos.CurrentRow.Cells[1].Value.ToString())
                {
                    MessageBox.Show("Este livro n�o existe ou n�o est� dispon�vel em nossa biblioteca. Consulte os livros dispon�veis na aba de consulta.", "Livro n�o dispon�vel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNovoEmprestimoTitulo.Clear();
                }
                else if (limpaTextos(txtNovoEmprestimoISBN.Text).Length > 0)
                {
                    MessageBox.Show("Este livro n�o existe ou n�o est� dispon�vel em nossa biblioteca. Consulte os livros dispon�veis na aba de consulta.", "Livro n�o dispon�vel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNovoEmprestimoTitulo.Clear();
                }

            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }
        }

        private void tabEmprestimoNovo_Leave(object sender, EventArgs e)
        {
            limparDadosCadastro("emprestimo");
        }


        private void tabLivroNovo_Leave(object sender, EventArgs e)
        {
            limparDadosCadastro("livro");
        }

        private void dgvConsultaEmprestimos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblEmprestimoID.Text = dgvConsultaEmprestimos.CurrentRow.Cells[0].Value.ToString();

            lblEmprestimoID.Visible = true;
            lblEditarEmprestimo.Visible = true;
            tbcCadastros.SelectedTab = tabEmprestimoNovo;
            tbcCadastros.BringToFront();
            toolStripButton2.BackColor = Color.White;
            toolStripButton2.ForeColor = Color.Black;
            toolStripButton1.BackColor = Color.Black;
            toolStripButton1.ForeColor = Color.White;
            btnNovoEmprestimoCadastrar.Text = "atualizar";
            btnNovoEmprestimoLimpar.Text = "excluir";

            txtNovoEmprestimoISBN.Text = dgvConsultaEmprestimos.CurrentRow.Cells[1].Value.ToString();
            txtNovoEmprestimoTitulo.Text = dgvConsultaEmprestimos.CurrentRow.Cells[2].Value.ToString();
            txtNovoEmprestimoCPF.Text = dgvConsultaEmprestimos.CurrentRow.Cells[3].Value.ToString();
            txtNovoEmprestimoNome.Text = dgvConsultaEmprestimos.CurrentRow.Cells[4].Value.ToString();
            dtNovoEmprestimoData.Text = dgvConsultaEmprestimos.CurrentRow.Cells[5].Value.ToString();
            if (!dgvConsultaEmprestimos.CurrentRow.Cells[7].Value.ToString().Equals(""))
            {
                dtNovoEmprestimoDevolucao.Text = dgvConsultaEmprestimos.CurrentRow.Cells[7].Value.ToString();
                dtNovoEmprestimoDevolucao.Visible = true;
                chkNovoEmprestimoDevolvido.Checked = true;
            }
            else
            {
                dtNovoEmprestimoDevolucao.Visible = false;
                chkNovoEmprestimoDevolvido.Checked = false;
            }
        }
    }


}
