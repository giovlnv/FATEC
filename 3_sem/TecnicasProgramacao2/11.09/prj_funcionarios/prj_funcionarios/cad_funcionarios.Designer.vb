<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cad_funcionarios
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cad_funcionarios))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.salario = New System.Windows.Forms.GroupBox()
        Me.txt_liquid = New System.Windows.Forms.TextBox()
        Me.txt_inss = New System.Windows.Forms.TextBox()
        Me.txt_brutus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_qtd_sal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_dtAdmissao = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbx_cargo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_info = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_salvar_editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cbbx_pesq = New System.Windows.Forms.ToolStripComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.salario.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 28)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(777, 401)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.salario)
        Me.TabPage1.Controls.Add(Me.txt_qtd_sal)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_dtAdmissao)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cbbx_cargo)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.img_foto)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(769, 372)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Funcionário"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(267, 161)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(271, 22)
        Me.txt_cpf.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(263, 142)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "CPF:"
        '
        'salario
        '
        Me.salario.Controls.Add(Me.txt_liquid)
        Me.salario.Controls.Add(Me.txt_inss)
        Me.salario.Controls.Add(Me.txt_brutus)
        Me.salario.Controls.Add(Me.Label7)
        Me.salario.Controls.Add(Me.Label6)
        Me.salario.Controls.Add(Me.Label5)
        Me.salario.Location = New System.Drawing.Point(27, 210)
        Me.salario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.salario.Name = "salario"
        Me.salario.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.salario.Size = New System.Drawing.Size(717, 149)
        Me.salario.TabIndex = 9
        Me.salario.TabStop = False
        Me.salario.Text = "Demonstrativo Rendimentos"
        '
        'txt_liquid
        '
        Me.txt_liquid.Location = New System.Drawing.Point(495, 47)
        Me.txt_liquid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_liquid.Name = "txt_liquid"
        Me.txt_liquid.ReadOnly = True
        Me.txt_liquid.Size = New System.Drawing.Size(185, 22)
        Me.txt_liquid.TabIndex = 5
        '
        'txt_inss
        '
        Me.txt_inss.Location = New System.Drawing.Point(259, 47)
        Me.txt_inss.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_inss.Name = "txt_inss"
        Me.txt_inss.ReadOnly = True
        Me.txt_inss.Size = New System.Drawing.Size(185, 22)
        Me.txt_inss.TabIndex = 4
        '
        'txt_brutus
        '
        Me.txt_brutus.Location = New System.Drawing.Point(35, 47)
        Me.txt_brutus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_brutus.Name = "txt_brutus"
        Me.txt_brutus.ReadOnly = True
        Me.txt_brutus.Size = New System.Drawing.Size(180, 22)
        Me.txt_brutus.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(492, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Salário Líquido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "INSS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Salário Bruto:"
        '
        'txt_qtd_sal
        '
        Me.txt_qtd_sal.Location = New System.Drawing.Point(27, 160)
        Me.txt_qtd_sal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_qtd_sal.Name = "txt_qtd_sal"
        Me.txt_qtd_sal.Size = New System.Drawing.Size(215, 22)
        Me.txt_qtd_sal.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Quantidade Salários:"
        '
        'txt_dtAdmissao
        '
        Me.txt_dtAdmissao.CustomFormat = "dd/mm/yyyy"
        Me.txt_dtAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_dtAdmissao.Location = New System.Drawing.Point(267, 97)
        Me.txt_dtAdmissao.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_dtAdmissao.Name = "txt_dtAdmissao"
        Me.txt_dtAdmissao.Size = New System.Drawing.Size(271, 22)
        Me.txt_dtAdmissao.TabIndex = 6
        Me.txt_dtAdmissao.Value = New Date(2023, 9, 25, 19, 31, 10, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Data de Admissão:"
        '
        'cbbx_cargo
        '
        Me.cbbx_cargo.FormattingEnabled = True
        Me.cbbx_cargo.Location = New System.Drawing.Point(27, 97)
        Me.cbbx_cargo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbbx_cargo.Name = "cbbx_cargo"
        Me.cbbx_cargo.Size = New System.Drawing.Size(215, 24)
        Me.cbbx_cargo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cargo:"
        '
        'img_foto
        '
        Me.img_foto.Image = Global.prj_funcionarios.My.Resources.Resources.Iconoir_Team_Iconoir_Add_user_512
        Me.img_foto.Location = New System.Drawing.Point(619, 17)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(125, 140)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 2
        Me.img_foto.TabStop = False
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(27, 36)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(511, 22)
        Me.txt_nome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome Funcionário:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_info)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(769, 372)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listagem Geral Rendimentos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_info
        '
        Me.dgv_info.AllowUserToAddRows = False
        Me.dgv_info.AllowUserToDeleteRows = False
        Me.dgv_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_info.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_info.ColumnHeadersHeight = 40
        Me.dgv_info.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column11, Me.Column6, Me.Column7, Me.Column3, Me.Column4})
        Me.dgv_info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_info.Location = New System.Drawing.Point(3, 2)
        Me.dgv_info.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_info.Name = "dgv_info"
        Me.dgv_info.RowHeadersWidth = 51
        Me.dgv_info.Size = New System.Drawing.Size(763, 368)
        Me.dgv_info.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "#"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 43
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 73
        '
        'Column11
        '
        Me.Column11.HeaderText = "Cargo"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 73
        '
        'Column6
        '
        Me.Column6.HeaderText = "Salário Bruto"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 104
        '
        'Column7
        '
        Me.Column7.HeaderText = "Salário Líquido"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 116
        '
        'Column3
        '
        Me.Column3.HeaderText = "Editar"
        Me.Column3.Image = Global.prj_funcionarios.My.Resources.Resources.edit
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 48
        '
        'Column4
        '
        Me.Column4.HeaderText = "Apagar"
        Me.Column4.Image = Global.prj_funcionarios.My.Resources.Resources.delete
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 58
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_salvar_editar, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.txt_busca, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.cbbx_pesq})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(820, 28)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_salvar_editar
        '
        Me.btn_salvar_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_salvar_editar.Image = CType(resources.GetObject("btn_salvar_editar.Image"), System.Drawing.Image)
        Me.btn_salvar_editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salvar_editar.Name = "btn_salvar_editar"
        Me.btn_salvar_editar.Size = New System.Drawing.Size(29, 25)
        Me.btn_salvar_editar.Text = "Salvar/Atualizar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(68, 25)
        Me.ToolStripLabel1.Text = "Pesquise:"
        '
        'txt_busca
        '
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(100, 28)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(80, 25)
        Me.ToolStripLabel2.Text = "Parâmetro:"
        '
        'cbbx_pesq
        '
        Me.cbbx_pesq.Name = "cbbx_pesq"
        Me.cbbx_pesq.Size = New System.Drawing.Size(121, 28)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Editar"
        Me.DataGridViewImageColumn1.Image = Global.prj_funcionarios.My.Resources.Resources.edit
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 125
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Apagar"
        Me.DataGridViewImageColumn2.Image = Global.prj_funcionarios.My.Resources.Resources.delete
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 125
        '
        'cad_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 478)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "cad_funcionarios"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.salario.ResumeLayout(False)
        Me.salario.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_salvar_editar As ToolStripButton
    Friend WithEvents cbbx_cargo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_qtd_sal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_dtAdmissao As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents salario As GroupBox
    Friend WithEvents txt_liquid As TextBox
    Friend WithEvents txt_inss As TextBox
    Friend WithEvents txt_brutus As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv_info As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cbbx_pesq As ToolStripComboBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
End Class
