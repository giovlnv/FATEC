<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Biblioteca
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Biblioteca))
        ToolStrip1 = New ToolStrip()
        btn_cad = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        ToolStripSeparator2 = New ToolStripSeparator()
        btn_cons = New ToolStripButton()
        tab_cons = New TabControl()
        TabPage2 = New TabPage()
        dgv_usuarios = New DataGridView()
        Column23 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewImageColumn()
        Column5 = New DataGridViewImageColumn()
        TabPage1 = New TabPage()
        dgv_livros = New DataGridView()
        Column24 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column21 = New DataGridViewImageColumn()
        Column12 = New DataGridViewImageColumn()
        Column13 = New DataGridViewImageColumn()
        TabPage3 = New TabPage()
        dgv_emprestimos = New DataGridView()
        Column22 = New DataGridViewTextBoxColumn()
        Column25 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        Column18 = New DataGridViewTextBoxColumn()
        Column17 = New DataGridViewTextBoxColumn()
        Column19 = New DataGridViewImageColumn()
        Column20 = New DataGridViewImageColumn()
        OpenFileDialog1 = New OpenFileDialog()
        cad_usuario = New TabPage()
        btn_user_salvar = New Button()
        btn_user_limp = New Button()
        img_foto_usuario = New PictureBox()
        img_perfil = New PictureBox()
        txt_cad_cpf = New MaskedTextBox()
        txt_senha = New TextBox()
        txt_email = New TextBox()
        txt_cad_nome = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cad_livro = New TabPage()
        txt_qtd_livros = New NumericUpDown()
        Label13 = New Label()
        dt_pub = New DateTimePicker()
        Label12 = New Label()
        txt_isbn = New MaskedTextBox()
        Label11 = New Label()
        txt_qtd_pag = New NumericUpDown()
        Label10 = New Label()
        txt_idioma = New TextBox()
        Label9 = New Label()
        txt_serie = New TextBox()
        Label8 = New Label()
        txt_editora = New TextBox()
        Label7 = New Label()
        btn_cadl_salv = New Button()
        btn_cadl_limp = New Button()
        img_capa_livro = New PictureBox()
        txt_cad_autor = New TextBox()
        txt_cad_titulo = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        tab_cad = New TabControl()
        cad_emp = New TabPage()
        txt_emp_titulo = New TextBox()
        Label20 = New Label()
        txt_emp_nome = New TextBox()
        Label19 = New Label()
        btn_emp_salv = New Button()
        btn_emp_limp = New Button()
        dt_emp_devol = New DateTimePicker()
        dt_emp_prev = New DateTimePicker()
        dt_emp_emp = New DateTimePicker()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        txt_emp_isbn = New MaskedTextBox()
        Label15 = New Label()
        txt_emp_cpf = New MaskedTextBox()
        Label14 = New Label()
        OpenFileDialog2 = New OpenFileDialog()
        ToolStrip1.SuspendLayout()
        tab_cons.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(dgv_usuarios, ComponentModel.ISupportInitialize).BeginInit()
        TabPage1.SuspendLayout()
        CType(dgv_livros, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(dgv_emprestimos, ComponentModel.ISupportInitialize).BeginInit()
        cad_usuario.SuspendLayout()
        CType(img_foto_usuario, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_perfil, ComponentModel.ISupportInitialize).BeginInit()
        cad_livro.SuspendLayout()
        CType(txt_qtd_livros, ComponentModel.ISupportInitialize).BeginInit()
        CType(txt_qtd_pag, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_capa_livro, ComponentModel.ISupportInitialize).BeginInit()
        tab_cad.SuspendLayout()
        cad_emp.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {btn_cad, ToolStripSeparator1, ToolStripSeparator2, btn_cons})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1149, 27)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' btn_cad
        ' 
        btn_cad.DisplayStyle = ToolStripItemDisplayStyle.Text
        btn_cad.Image = CType(resources.GetObject("btn_cad.Image"), Image)
        btn_cad.ImageTransparentColor = Color.Magenta
        btn_cad.Name = "btn_cad"
        btn_cad.Size = New Size(78, 24)
        btn_cad.Text = "Cadastros"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 27)
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 27)
        ' 
        ' btn_cons
        ' 
        btn_cons.DisplayStyle = ToolStripItemDisplayStyle.Text
        btn_cons.Image = CType(resources.GetObject("btn_cons.Image"), Image)
        btn_cons.ImageTransparentColor = Color.Magenta
        btn_cons.Name = "btn_cons"
        btn_cons.Size = New Size(76, 24)
        btn_cons.Text = "Consultas"
        ' 
        ' tab_cons
        ' 
        tab_cons.Controls.Add(TabPage2)
        tab_cons.Controls.Add(TabPage1)
        tab_cons.Controls.Add(TabPage3)
        tab_cons.Location = New Point(12, 28)
        tab_cons.Name = "tab_cons"
        tab_cons.SelectedIndex = 0
        tab_cons.Size = New Size(1125, 598)
        tab_cons.TabIndex = 2
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgv_usuarios)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1117, 565)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Consultar Usuários"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgv_usuarios
        ' 
        dgv_usuarios.AllowUserToAddRows = False
        dgv_usuarios.AllowUserToDeleteRows = False
        dgv_usuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_usuarios.Columns.AddRange(New DataGridViewColumn() {Column23, Column1, Column2, Column3, Column4, Column5})
        dgv_usuarios.Location = New Point(0, 0)
        dgv_usuarios.Name = "dgv_usuarios"
        dgv_usuarios.RowHeadersWidth = 51
        dgv_usuarios.RowTemplate.Height = 29
        dgv_usuarios.Size = New Size(1121, 560)
        dgv_usuarios.TabIndex = 0
        ' 
        ' Column23
        ' 
        Column23.HeaderText = "#"
        Column23.MinimumWidth = 6
        Column23.Name = "Column23"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Nome"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "E-mail"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Saldo"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Editar"
        Column4.Image = My.Resources.Resources.edit
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Apagar"
        Column5.Image = My.Resources.Resources.delete
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(dgv_livros)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1117, 565)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Consultar Livros"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' dgv_livros
        ' 
        dgv_livros.AllowUserToAddRows = False
        dgv_livros.AllowUserToDeleteRows = False
        dgv_livros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_livros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_livros.Columns.AddRange(New DataGridViewColumn() {Column24, Column7, Column6, Column8, Column9, Column10, Column11, Column21, Column12, Column13})
        dgv_livros.Location = New Point(0, 0)
        dgv_livros.Name = "dgv_livros"
        dgv_livros.RowHeadersWidth = 51
        dgv_livros.RowTemplate.Height = 29
        dgv_livros.Size = New Size(1111, 559)
        dgv_livros.TabIndex = 0
        ' 
        ' Column24
        ' 
        Column24.HeaderText = "#"
        Column24.MinimumWidth = 6
        Column24.Name = "Column24"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "ISBN"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Título"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Autor"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Série"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Quantidade"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Status"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        ' 
        ' Column21
        ' 
        Column21.HeaderText = "Emprestar"
        Column21.Image = My.Resources.Resources.icons8_adicionar_961
        Column21.MinimumWidth = 6
        Column21.Name = "Column21"
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Editar"
        Column12.Image = My.Resources.Resources.edit
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "Apagar"
        Column13.Image = My.Resources.Resources.delete
        Column13.MinimumWidth = 6
        Column13.Name = "Column13"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(dgv_emprestimos)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1117, 565)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Empréstimos"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' dgv_emprestimos
        ' 
        dgv_emprestimos.AllowUserToAddRows = False
        dgv_emprestimos.AllowUserToDeleteRows = False
        dgv_emprestimos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_emprestimos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_emprestimos.Columns.AddRange(New DataGridViewColumn() {Column22, Column25, Column14, Column15, Column16, Column18, Column17, Column19, Column20})
        dgv_emprestimos.Location = New Point(0, 0)
        dgv_emprestimos.Name = "dgv_emprestimos"
        dgv_emprestimos.RowHeadersWidth = 51
        dgv_emprestimos.RowTemplate.Height = 29
        dgv_emprestimos.Size = New Size(1114, 562)
        dgv_emprestimos.TabIndex = 0
        ' 
        ' Column22
        ' 
        Column22.HeaderText = "#"
        Column22.MinimumWidth = 6
        Column22.Name = "Column22"
        ' 
        ' Column25
        ' 
        Column25.HeaderText = "nº"
        Column25.MinimumWidth = 6
        Column25.Name = "Column25"
        ' 
        ' Column14
        ' 
        Column14.HeaderText = "ISBN"
        Column14.MinimumWidth = 6
        Column14.Name = "Column14"
        ' 
        ' Column15
        ' 
        Column15.HeaderText = "CPF"
        Column15.MinimumWidth = 6
        Column15.Name = "Column15"
        ' 
        ' Column16
        ' 
        Column16.HeaderText = "Data Empréstimo"
        Column16.MinimumWidth = 6
        Column16.Name = "Column16"
        ' 
        ' Column18
        ' 
        Column18.HeaderText = "Data Prevista"
        Column18.MinimumWidth = 6
        Column18.Name = "Column18"
        ' 
        ' Column17
        ' 
        Column17.HeaderText = "Data Devolução"
        Column17.MinimumWidth = 6
        Column17.Name = "Column17"
        ' 
        ' Column19
        ' 
        Column19.HeaderText = "Editar"
        Column19.Image = My.Resources.Resources.edit
        Column19.MinimumWidth = 6
        Column19.Name = "Column19"
        ' 
        ' Column20
        ' 
        Column20.HeaderText = "Apagar"
        Column20.Image = My.Resources.Resources.delete
        Column20.MinimumWidth = 6
        Column20.Name = "Column20"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' cad_usuario
        ' 
        cad_usuario.Controls.Add(btn_user_salvar)
        cad_usuario.Controls.Add(btn_user_limp)
        cad_usuario.Controls.Add(img_foto_usuario)
        cad_usuario.Controls.Add(img_perfil)
        cad_usuario.Controls.Add(txt_cad_cpf)
        cad_usuario.Controls.Add(txt_senha)
        cad_usuario.Controls.Add(txt_email)
        cad_usuario.Controls.Add(txt_cad_nome)
        cad_usuario.Controls.Add(Label4)
        cad_usuario.Controls.Add(Label3)
        cad_usuario.Controls.Add(Label2)
        cad_usuario.Controls.Add(Label1)
        cad_usuario.Location = New Point(4, 29)
        cad_usuario.Name = "cad_usuario"
        cad_usuario.Padding = New Padding(3)
        cad_usuario.Size = New Size(1113, 559)
        cad_usuario.TabIndex = 1
        cad_usuario.Text = "Cadastro de Usuário"
        cad_usuario.UseVisualStyleBackColor = True
        ' 
        ' btn_user_salvar
        ' 
        btn_user_salvar.Location = New Point(185, 264)
        btn_user_salvar.Name = "btn_user_salvar"
        btn_user_salvar.Size = New Size(94, 29)
        btn_user_salvar.TabIndex = 12
        btn_user_salvar.Text = "Salvar"
        btn_user_salvar.UseVisualStyleBackColor = True
        ' 
        ' btn_user_limp
        ' 
        btn_user_limp.Location = New Point(51, 264)
        btn_user_limp.Name = "btn_user_limp"
        btn_user_limp.Size = New Size(94, 29)
        btn_user_limp.TabIndex = 11
        btn_user_limp.Text = "Limpar"
        btn_user_limp.UseVisualStyleBackColor = True
        ' 
        ' img_foto_usuario
        ' 
        img_foto_usuario.Image = My.Resources.Resources.nova_foto
        img_foto_usuario.Location = New Point(562, 16)
        img_foto_usuario.Name = "img_foto_usuario"
        img_foto_usuario.Size = New Size(168, 224)
        img_foto_usuario.SizeMode = PictureBoxSizeMode.StretchImage
        img_foto_usuario.TabIndex = 10
        img_foto_usuario.TabStop = False
        ' 
        ' img_perfil
        ' 
        img_perfil.Location = New Point(556, 28)
        img_perfil.Name = "img_perfil"
        img_perfil.Size = New Size(0, 0)
        img_perfil.TabIndex = 9
        img_perfil.TabStop = False
        ' 
        ' txt_cad_cpf
        ' 
        txt_cad_cpf.Location = New Point(20, 213)
        txt_cad_cpf.Mask = "000.000.000-00"
        txt_cad_cpf.Name = "txt_cad_cpf"
        txt_cad_cpf.Size = New Size(125, 27)
        txt_cad_cpf.TabIndex = 8
        ' 
        ' txt_senha
        ' 
        txt_senha.Location = New Point(185, 213)
        txt_senha.Name = "txt_senha"
        txt_senha.PasswordChar = "*"c
        txt_senha.Size = New Size(185, 27)
        txt_senha.TabIndex = 7
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(20, 129)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(350, 27)
        txt_email.TabIndex = 5
        ' 
        ' txt_cad_nome
        ' 
        txt_cad_nome.Location = New Point(20, 49)
        txt_cad_nome.Name = "txt_cad_nome"
        txt_cad_nome.Size = New Size(350, 27)
        txt_cad_nome.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(185, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 20)
        Label4.TabIndex = 3
        Label4.Text = "Senha"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 20)
        Label3.TabIndex = 2
        Label3.Text = "CPF"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 20)
        Label2.TabIndex = 1
        Label2.Text = "E-mail"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nome"
        ' 
        ' cad_livro
        ' 
        cad_livro.Controls.Add(txt_qtd_livros)
        cad_livro.Controls.Add(Label13)
        cad_livro.Controls.Add(dt_pub)
        cad_livro.Controls.Add(Label12)
        cad_livro.Controls.Add(txt_isbn)
        cad_livro.Controls.Add(Label11)
        cad_livro.Controls.Add(txt_qtd_pag)
        cad_livro.Controls.Add(Label10)
        cad_livro.Controls.Add(txt_idioma)
        cad_livro.Controls.Add(Label9)
        cad_livro.Controls.Add(txt_serie)
        cad_livro.Controls.Add(Label8)
        cad_livro.Controls.Add(txt_editora)
        cad_livro.Controls.Add(Label7)
        cad_livro.Controls.Add(btn_cadl_salv)
        cad_livro.Controls.Add(btn_cadl_limp)
        cad_livro.Controls.Add(img_capa_livro)
        cad_livro.Controls.Add(txt_cad_autor)
        cad_livro.Controls.Add(txt_cad_titulo)
        cad_livro.Controls.Add(Label5)
        cad_livro.Controls.Add(Label6)
        cad_livro.Location = New Point(4, 29)
        cad_livro.Name = "cad_livro"
        cad_livro.Padding = New Padding(3)
        cad_livro.Size = New Size(1113, 559)
        cad_livro.TabIndex = 0
        cad_livro.Text = "Cadastro de Livro"
        cad_livro.UseVisualStyleBackColor = True
        ' 
        ' txt_qtd_livros
        ' 
        txt_qtd_livros.Location = New Point(368, 175)
        txt_qtd_livros.Name = "txt_qtd_livros"
        txt_qtd_livros.Size = New Size(59, 27)
        txt_qtd_livros.TabIndex = 33
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(368, 151)
        Label13.Name = "Label13"
        Label13.Size = New Size(87, 20)
        Label13.TabIndex = 32
        Label13.Text = "Quantidade"
        ' 
        ' dt_pub
        ' 
        dt_pub.Format = DateTimePickerFormat.Short
        dt_pub.Location = New Point(270, 246)
        dt_pub.Name = "dt_pub"
        dt_pub.Size = New Size(121, 27)
        dt_pub.TabIndex = 31
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(270, 223)
        Label12.Name = "Label12"
        Label12.Size = New Size(138, 20)
        Label12.TabIndex = 30
        Label12.Text = "Data de Publicação"
        ' 
        ' txt_isbn
        ' 
        txt_isbn.Location = New Point(29, 246)
        txt_isbn.Mask = "000-00-00000-00-0"
        txt_isbn.Name = "txt_isbn"
        txt_isbn.Size = New Size(213, 27)
        txt_isbn.TabIndex = 29
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(30, 223)
        Label11.Name = "Label11"
        Label11.Size = New Size(41, 20)
        Label11.TabIndex = 28
        Label11.Text = "ISBN"
        ' 
        ' txt_qtd_pag
        ' 
        txt_qtd_pag.Location = New Point(270, 175)
        txt_qtd_pag.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        txt_qtd_pag.Name = "txt_qtd_pag"
        txt_qtd_pag.Size = New Size(59, 27)
        txt_qtd_pag.TabIndex = 27
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(270, 151)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 20)
        Label10.TabIndex = 26
        Label10.Text = "Páginas"
        ' 
        ' txt_idioma
        ' 
        txt_idioma.Location = New Point(30, 174)
        txt_idioma.Name = "txt_idioma"
        txt_idioma.Size = New Size(213, 27)
        txt_idioma.TabIndex = 25
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(31, 151)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 20)
        Label9.TabIndex = 24
        Label9.Text = "Idioma"
        ' 
        ' txt_serie
        ' 
        txt_serie.Location = New Point(269, 108)
        txt_serie.Name = "txt_serie"
        txt_serie.Size = New Size(213, 27)
        txt_serie.TabIndex = 23
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(270, 85)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 20)
        Label8.TabIndex = 22
        Label8.Text = "Série"
        ' 
        ' txt_editora
        ' 
        txt_editora.Location = New Point(29, 108)
        txt_editora.Name = "txt_editora"
        txt_editora.Size = New Size(213, 27)
        txt_editora.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(30, 85)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 20)
        Label7.TabIndex = 20
        Label7.Text = "Editora"
        ' 
        ' btn_cadl_salv
        ' 
        btn_cadl_salv.Location = New Point(269, 300)
        btn_cadl_salv.Name = "btn_cadl_salv"
        btn_cadl_salv.Size = New Size(94, 29)
        btn_cadl_salv.TabIndex = 19
        btn_cadl_salv.Text = "Salvar"
        btn_cadl_salv.UseVisualStyleBackColor = True
        ' 
        ' btn_cadl_limp
        ' 
        btn_cadl_limp.Location = New Point(151, 300)
        btn_cadl_limp.Name = "btn_cadl_limp"
        btn_cadl_limp.Size = New Size(94, 29)
        btn_cadl_limp.TabIndex = 18
        btn_cadl_limp.Text = "Limpar"
        btn_cadl_limp.UseVisualStyleBackColor = True
        ' 
        ' img_capa_livro
        ' 
        img_capa_livro.Image = My.Resources.Resources.nova_foto
        img_capa_livro.Location = New Point(575, 38)
        img_capa_livro.Name = "img_capa_livro"
        img_capa_livro.Size = New Size(168, 224)
        img_capa_livro.SizeMode = PictureBoxSizeMode.StretchImage
        img_capa_livro.TabIndex = 17
        img_capa_livro.TabStop = False
        ' 
        ' txt_cad_autor
        ' 
        txt_cad_autor.Location = New Point(269, 38)
        txt_cad_autor.Name = "txt_cad_autor"
        txt_cad_autor.Size = New Size(213, 27)
        txt_cad_autor.TabIndex = 16
        ' 
        ' txt_cad_titulo
        ' 
        txt_cad_titulo.Location = New Point(29, 38)
        txt_cad_titulo.Name = "txt_cad_titulo"
        txt_cad_titulo.Size = New Size(213, 27)
        txt_cad_titulo.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(269, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 14
        Label5.Text = "Autor"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(29, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 20)
        Label6.TabIndex = 13
        Label6.Text = "Título"
        ' 
        ' tab_cad
        ' 
        tab_cad.Controls.Add(cad_usuario)
        tab_cad.Controls.Add(cad_livro)
        tab_cad.Controls.Add(cad_emp)
        tab_cad.Location = New Point(12, 30)
        tab_cad.Name = "tab_cad"
        tab_cad.SelectedIndex = 0
        tab_cad.Size = New Size(1121, 592)
        tab_cad.TabIndex = 0
        ' 
        ' cad_emp
        ' 
        cad_emp.Controls.Add(txt_emp_titulo)
        cad_emp.Controls.Add(Label20)
        cad_emp.Controls.Add(txt_emp_nome)
        cad_emp.Controls.Add(Label19)
        cad_emp.Controls.Add(btn_emp_salv)
        cad_emp.Controls.Add(btn_emp_limp)
        cad_emp.Controls.Add(dt_emp_devol)
        cad_emp.Controls.Add(dt_emp_prev)
        cad_emp.Controls.Add(dt_emp_emp)
        cad_emp.Controls.Add(Label18)
        cad_emp.Controls.Add(Label17)
        cad_emp.Controls.Add(Label16)
        cad_emp.Controls.Add(txt_emp_isbn)
        cad_emp.Controls.Add(Label15)
        cad_emp.Controls.Add(txt_emp_cpf)
        cad_emp.Controls.Add(Label14)
        cad_emp.Location = New Point(4, 29)
        cad_emp.Name = "cad_emp"
        cad_emp.Padding = New Padding(3)
        cad_emp.Size = New Size(1113, 559)
        cad_emp.TabIndex = 2
        cad_emp.Text = "Cadastro de Empréstimo"
        cad_emp.UseVisualStyleBackColor = True
        ' 
        ' txt_emp_titulo
        ' 
        txt_emp_titulo.Location = New Point(267, 125)
        txt_emp_titulo.Name = "txt_emp_titulo"
        txt_emp_titulo.Size = New Size(213, 27)
        txt_emp_titulo.TabIndex = 43
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(267, 102)
        Label20.Name = "Label20"
        Label20.Size = New Size(47, 20)
        Label20.TabIndex = 42
        Label20.Text = "Título"
        ' 
        ' txt_emp_nome
        ' 
        txt_emp_nome.Location = New Point(213, 46)
        txt_emp_nome.Name = "txt_emp_nome"
        txt_emp_nome.Size = New Size(350, 27)
        txt_emp_nome.TabIndex = 41
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(213, 23)
        Label19.Name = "Label19"
        Label19.Size = New Size(50, 20)
        Label19.TabIndex = 40
        Label19.Text = "Nome"
        ' 
        ' btn_emp_salv
        ' 
        btn_emp_salv.Location = New Point(349, 304)
        btn_emp_salv.Name = "btn_emp_salv"
        btn_emp_salv.Size = New Size(94, 29)
        btn_emp_salv.TabIndex = 39
        btn_emp_salv.Text = "Salvar"
        btn_emp_salv.UseVisualStyleBackColor = True
        ' 
        ' btn_emp_limp
        ' 
        btn_emp_limp.Location = New Point(213, 304)
        btn_emp_limp.Name = "btn_emp_limp"
        btn_emp_limp.Size = New Size(94, 29)
        btn_emp_limp.TabIndex = 38
        btn_emp_limp.Text = "Limpar"
        btn_emp_limp.UseVisualStyleBackColor = True
        ' 
        ' dt_emp_devol
        ' 
        dt_emp_devol.Format = DateTimePickerFormat.Short
        dt_emp_devol.Location = New Point(478, 218)
        dt_emp_devol.Name = "dt_emp_devol"
        dt_emp_devol.Size = New Size(146, 27)
        dt_emp_devol.TabIndex = 37
        ' 
        ' dt_emp_prev
        ' 
        dt_emp_prev.Format = DateTimePickerFormat.Short
        dt_emp_prev.Location = New Point(243, 218)
        dt_emp_prev.Name = "dt_emp_prev"
        dt_emp_prev.Size = New Size(146, 27)
        dt_emp_prev.TabIndex = 36
        ' 
        ' dt_emp_emp
        ' 
        dt_emp_emp.Format = DateTimePickerFormat.Short
        dt_emp_emp.Location = New Point(23, 218)
        dt_emp_emp.Name = "dt_emp_emp"
        dt_emp_emp.Size = New Size(146, 27)
        dt_emp_emp.TabIndex = 35
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(478, 195)
        Label18.Name = "Label18"
        Label18.Size = New Size(164, 20)
        Label18.TabIndex = 34
        Label18.Text = "Data real de devolução"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(243, 195)
        Label17.Name = "Label17"
        Label17.Size = New Size(191, 20)
        Label17.TabIndex = 33
        Label17.Text = "Data prevista de devolução"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(23, 195)
        Label16.Name = "Label16"
        Label16.Size = New Size(146, 20)
        Label16.TabIndex = 32
        Label16.Text = "Data de empréstimo"
        ' 
        ' txt_emp_isbn
        ' 
        txt_emp_isbn.Location = New Point(23, 125)
        txt_emp_isbn.Mask = "000-00-00000-00-0"
        txt_emp_isbn.Name = "txt_emp_isbn"
        txt_emp_isbn.Size = New Size(213, 27)
        txt_emp_isbn.TabIndex = 31
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(24, 102)
        Label15.Name = "Label15"
        Label15.Size = New Size(41, 20)
        Label15.TabIndex = 30
        Label15.Text = "ISBN"
        ' 
        ' txt_emp_cpf
        ' 
        txt_emp_cpf.Location = New Point(23, 46)
        txt_emp_cpf.Mask = "000.000.000-00"
        txt_emp_cpf.Name = "txt_emp_cpf"
        txt_emp_cpf.Size = New Size(125, 27)
        txt_emp_cpf.TabIndex = 10
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(23, 23)
        Label14.Name = "Label14"
        Label14.Size = New Size(33, 20)
        Label14.TabIndex = 9
        Label14.Text = "CPF"
        ' 
        ' OpenFileDialog2
        ' 
        OpenFileDialog2.FileName = "OpenFileDialog2"
        ' 
        ' Biblioteca
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1149, 629)
        Controls.Add(ToolStrip1)
        Controls.Add(tab_cad)
        Controls.Add(tab_cons)
        Name = "Biblioteca"
        Text = "Biblioteca"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        tab_cons.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        CType(dgv_usuarios, ComponentModel.ISupportInitialize).EndInit()
        TabPage1.ResumeLayout(False)
        CType(dgv_livros, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        CType(dgv_emprestimos, ComponentModel.ISupportInitialize).EndInit()
        cad_usuario.ResumeLayout(False)
        cad_usuario.PerformLayout()
        CType(img_foto_usuario, ComponentModel.ISupportInitialize).EndInit()
        CType(img_perfil, ComponentModel.ISupportInitialize).EndInit()
        cad_livro.ResumeLayout(False)
        cad_livro.PerformLayout()
        CType(txt_qtd_livros, ComponentModel.ISupportInitialize).EndInit()
        CType(txt_qtd_pag, ComponentModel.ISupportInitialize).EndInit()
        CType(img_capa_livro, ComponentModel.ISupportInitialize).EndInit()
        tab_cad.ResumeLayout(False)
        cad_emp.ResumeLayout(False)
        cad_emp.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_cad As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btn_cons As ToolStripButton
    Friend WithEvents tab_cons As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cad_usuario As TabPage
    Friend WithEvents btn_user_salvar As Button
    Friend WithEvents btn_user_limp As Button
    Friend WithEvents img_foto_usuario As PictureBox
    Friend WithEvents img_perfil As PictureBox
    Friend WithEvents txt_cad_cpf As MaskedTextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_cad_nome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cad_livro As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_idioma As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_serie As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_editora As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_cadl_salv As Button
    Friend WithEvents btn_cadl_limp As Button
    Friend WithEvents img_capa_livro As PictureBox
    Friend WithEvents txt_cad_autor As TextBox
    Friend WithEvents txt_cad_titulo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tab_cad As TabControl
    Friend WithEvents txt_qtd_pag As NumericUpDown
    Friend WithEvents txt_isbn As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dt_pub As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_qtd_livros As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgv_usuarios As DataGridView
    Friend WithEvents dgv_livros As DataGridView
    Friend WithEvents dgv_emprestimos As DataGridView
    Friend WithEvents cad_emp As TabPage
    Friend WithEvents txt_emp_cpf As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_emp_salv As Button
    Friend WithEvents btn_emp_limp As Button
    Friend WithEvents dt_emp_devol As DateTimePicker
    Friend WithEvents dt_emp_prev As DateTimePicker
    Friend WithEvents dt_emp_emp As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_emp_isbn As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_emp_titulo As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_emp_nome As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewImageColumn
    Friend WithEvents Column12 As DataGridViewImageColumn
    Friend WithEvents Column13 As DataGridViewImageColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column25 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewImageColumn
    Friend WithEvents Column20 As DataGridViewImageColumn
End Class
