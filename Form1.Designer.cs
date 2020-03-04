namespace Debugger_Tasken_2020
{
    partial class debugger
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(debugger));
            this.CaminhoScheduler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.dadosDeAcesso = new System.Windows.Forms.GroupBox();
            this.ServProcess = new System.Windows.Forms.TextBox();
            this.bd = new System.Windows.Forms.TabControl();
            this.pag1 = new System.Windows.Forms.TabPage();
            this.prc_usuario = new System.Windows.Forms.TextBox();
            this.prc_password = new System.Windows.Forms.TextBox();
            this.prc_nbasedados = new System.Windows.Forms.TextBox();
            this.prc_Senha = new System.Windows.Forms.Label();
            this.prc_Usu = new System.Windows.Forms.Label();
            this.prc_Nome_Da_Base_De_Dados = new System.Windows.Forms.Label();
            this.pag2 = new System.Windows.Forms.TabPage();
            this.ipBaseSrc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.src_senha = new System.Windows.Forms.Label();
            this.src_password = new System.Windows.Forms.TextBox();
            this.src_usu = new System.Windows.Forms.TextBox();
            this.src_Usuario = new System.Windows.Forms.Label();
            this.src_nbasedados = new System.Windows.Forms.TextBox();
            this.src_Nome_Da_Base_De_Dados = new System.Windows.Forms.Label();
            this.pag3 = new System.Windows.Forms.TabPage();
            this.stage_pw = new System.Windows.Forms.Label();
            this.stage_password = new System.Windows.Forms.TextBox();
            this.stage_usu = new System.Windows.Forms.TextBox();
            this.stage_u = new System.Windows.Forms.Label();
            this.stage_nbasedados = new System.Windows.Forms.TextBox();
            this.stage_DataBase = new System.Windows.Forms.Label();
            this.ServidorProcess = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipoDoProcesso = new System.Windows.Forms.ComboBox();
            this.tipo_do_processo = new System.Windows.Forms.Label();
            this.nProcessamento = new System.Windows.Forms.Label();
            this.prc = new System.Windows.Forms.TextBox();
            this.Carregar_Scheduler = new System.Windows.Forms.Button();
            this.Gerar_Argumentos_Executor = new System.Windows.Forms.Button();
            this.horaAtual = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.OpenFileDialog();
            this.AgendaId_ConfProcessamentoId_TipoProcessoId = new System.Windows.Forms.Button();
            this.dadosDeAcesso.SuspendLayout();
            this.bd.SuspendLayout();
            this.pag1.SuspendLayout();
            this.pag2.SuspendLayout();
            this.pag3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CaminhoScheduler
            // 
            this.CaminhoScheduler.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CaminhoScheduler.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaminhoScheduler.Location = new System.Drawing.Point(17, 39);
            this.CaminhoScheduler.Name = "CaminhoScheduler";
            this.CaminhoScheduler.Size = new System.Drawing.Size(680, 30);
            this.CaminhoScheduler.TabIndex = 0;
            this.CaminhoScheduler.TextChanged += new System.EventHandler(this.CaminhoScheduler_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho Scheduler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Buscar
            // 
            this.Buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Buscar.BackColor = System.Drawing.SystemColors.Window;
            this.Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Buscar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(703, 39);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(85, 30);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // dadosDeAcesso
            // 
            this.dadosDeAcesso.Controls.Add(this.ServProcess);
            this.dadosDeAcesso.Controls.Add(this.bd);
            this.dadosDeAcesso.Controls.Add(this.ServidorProcess);
            this.dadosDeAcesso.Location = new System.Drawing.Point(17, 88);
            this.dadosDeAcesso.Name = "dadosDeAcesso";
            this.dadosDeAcesso.Size = new System.Drawing.Size(771, 390);
            this.dadosDeAcesso.TabIndex = 3;
            this.dadosDeAcesso.TabStop = false;
            this.dadosDeAcesso.Text = "Dados de Acesso";
            this.dadosDeAcesso.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ServProcess
            // 
            this.ServProcess.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServProcess.Location = new System.Drawing.Point(23, 54);
            this.ServProcess.Multiline = true;
            this.ServProcess.Name = "ServProcess";
            this.ServProcess.Size = new System.Drawing.Size(723, 26);
            this.ServProcess.TabIndex = 4;
            this.ServProcess.TextChanged += new System.EventHandler(this.sp_TextChanged);
            // 
            // bd
            // 
            this.bd.Controls.Add(this.pag1);
            this.bd.Controls.Add(this.pag2);
            this.bd.Controls.Add(this.pag3);
            this.bd.Location = new System.Drawing.Point(23, 101);
            this.bd.Name = "bd";
            this.bd.SelectedIndex = 0;
            this.bd.Size = new System.Drawing.Size(723, 262);
            this.bd.TabIndex = 5;
            // 
            // pag1
            // 
            this.pag1.BackColor = System.Drawing.Color.Transparent;
            this.pag1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pag1.Controls.Add(this.prc_usuario);
            this.pag1.Controls.Add(this.prc_password);
            this.pag1.Controls.Add(this.prc_nbasedados);
            this.pag1.Controls.Add(this.prc_Senha);
            this.pag1.Controls.Add(this.prc_Usu);
            this.pag1.Controls.Add(this.prc_Nome_Da_Base_De_Dados);
            this.pag1.Location = new System.Drawing.Point(4, 22);
            this.pag1.Name = "pag1";
            this.pag1.Padding = new System.Windows.Forms.Padding(3);
            this.pag1.Size = new System.Drawing.Size(715, 236);
            this.pag1.TabIndex = 0;
            this.pag1.Text = "Process";
            this.pag1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // prc_usuario
            // 
            this.prc_usuario.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prc_usuario.Location = new System.Drawing.Point(20, 113);
            this.prc_usuario.Multiline = true;
            this.prc_usuario.Name = "prc_usuario";
            this.prc_usuario.Size = new System.Drawing.Size(300, 25);
            this.prc_usuario.TabIndex = 5;
            // 
            // prc_password
            // 
            this.prc_password.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.prc_password.Location = new System.Drawing.Point(20, 183);
            this.prc_password.Multiline = true;
            this.prc_password.Name = "prc_password";
            this.prc_password.Size = new System.Drawing.Size(300, 25);
            this.prc_password.TabIndex = 4;
            // 
            // prc_nbasedados
            // 
            this.prc_nbasedados.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prc_nbasedados.Location = new System.Drawing.Point(20, 45);
            this.prc_nbasedados.Multiline = true;
            this.prc_nbasedados.Name = "prc_nbasedados";
            this.prc_nbasedados.Size = new System.Drawing.Size(300, 25);
            this.prc_nbasedados.TabIndex = 3;
            // 
            // prc_Senha
            // 
            this.prc_Senha.AutoSize = true;
            this.prc_Senha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prc_Senha.Location = new System.Drawing.Point(17, 153);
            this.prc_Senha.Name = "prc_Senha";
            this.prc_Senha.Size = new System.Drawing.Size(45, 18);
            this.prc_Senha.TabIndex = 2;
            this.prc_Senha.Text = "Senha";
            // 
            // prc_Usu
            // 
            this.prc_Usu.AutoSize = true;
            this.prc_Usu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prc_Usu.Location = new System.Drawing.Point(17, 82);
            this.prc_Usu.Name = "prc_Usu";
            this.prc_Usu.Size = new System.Drawing.Size(55, 18);
            this.prc_Usu.TabIndex = 1;
            this.prc_Usu.Text = "Usuário";
            // 
            // prc_Nome_Da_Base_De_Dados
            // 
            this.prc_Nome_Da_Base_De_Dados.AutoSize = true;
            this.prc_Nome_Da_Base_De_Dados.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prc_Nome_Da_Base_De_Dados.Location = new System.Drawing.Point(17, 14);
            this.prc_Nome_Da_Base_De_Dados.Name = "prc_Nome_Da_Base_De_Dados";
            this.prc_Nome_Da_Base_De_Dados.Size = new System.Drawing.Size(152, 18);
            this.prc_Nome_Da_Base_De_Dados.TabIndex = 0;
            this.prc_Nome_Da_Base_De_Dados.Text = "Nome da Base de Dados";
            // 
            // pag2
            // 
            this.pag2.BackColor = System.Drawing.Color.Transparent;
            this.pag2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pag2.Controls.Add(this.ipBaseSrc);
            this.pag2.Controls.Add(this.label6);
            this.pag2.Controls.Add(this.label5);
            this.pag2.Controls.Add(this.src_senha);
            this.pag2.Controls.Add(this.src_password);
            this.pag2.Controls.Add(this.src_usu);
            this.pag2.Controls.Add(this.src_Usuario);
            this.pag2.Controls.Add(this.src_nbasedados);
            this.pag2.Controls.Add(this.src_Nome_Da_Base_De_Dados);
            this.pag2.Location = new System.Drawing.Point(4, 22);
            this.pag2.Name = "pag2";
            this.pag2.Padding = new System.Windows.Forms.Padding(3);
            this.pag2.Size = new System.Drawing.Size(715, 236);
            this.pag2.TabIndex = 1;
            this.pag2.Text = "SRC";
            this.pag2.Click += new System.EventHandler(this.pag2_Click);
            // 
            // ipBaseSrc
            // 
            this.ipBaseSrc.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.ipBaseSrc.Location = new System.Drawing.Point(385, 50);
            this.ipBaseSrc.Multiline = true;
            this.ipBaseSrc.Name = "ipBaseSrc";
            this.ipBaseSrc.Size = new System.Drawing.Size(300, 25);
            this.ipBaseSrc.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(532, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "(Não Obrigatório)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "IP Base SRC";
            // 
            // src_senha
            // 
            this.src_senha.AutoSize = true;
            this.src_senha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.src_senha.Location = new System.Drawing.Point(18, 156);
            this.src_senha.Name = "src_senha";
            this.src_senha.Size = new System.Drawing.Size(45, 18);
            this.src_senha.TabIndex = 8;
            this.src_senha.Text = "Senha";
            // 
            // src_password
            // 
            this.src_password.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.src_password.Location = new System.Drawing.Point(21, 186);
            this.src_password.Multiline = true;
            this.src_password.Name = "src_password";
            this.src_password.Size = new System.Drawing.Size(300, 25);
            this.src_password.TabIndex = 7;
            // 
            // src_usu
            // 
            this.src_usu.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.src_usu.Location = new System.Drawing.Point(21, 118);
            this.src_usu.Multiline = true;
            this.src_usu.Name = "src_usu";
            this.src_usu.Size = new System.Drawing.Size(300, 25);
            this.src_usu.TabIndex = 6;
            // 
            // src_Usuario
            // 
            this.src_Usuario.AutoSize = true;
            this.src_Usuario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.src_Usuario.Location = new System.Drawing.Point(18, 87);
            this.src_Usuario.Name = "src_Usuario";
            this.src_Usuario.Size = new System.Drawing.Size(55, 18);
            this.src_Usuario.TabIndex = 5;
            this.src_Usuario.Text = "Usuário";
            // 
            // src_nbasedados
            // 
            this.src_nbasedados.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.src_nbasedados.Location = new System.Drawing.Point(21, 50);
            this.src_nbasedados.Multiline = true;
            this.src_nbasedados.Name = "src_nbasedados";
            this.src_nbasedados.Size = new System.Drawing.Size(300, 25);
            this.src_nbasedados.TabIndex = 4;
            // 
            // src_Nome_Da_Base_De_Dados
            // 
            this.src_Nome_Da_Base_De_Dados.AutoSize = true;
            this.src_Nome_Da_Base_De_Dados.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.src_Nome_Da_Base_De_Dados.Location = new System.Drawing.Point(18, 19);
            this.src_Nome_Da_Base_De_Dados.Name = "src_Nome_Da_Base_De_Dados";
            this.src_Nome_Da_Base_De_Dados.Size = new System.Drawing.Size(152, 18);
            this.src_Nome_Da_Base_De_Dados.TabIndex = 1;
            this.src_Nome_Da_Base_De_Dados.Text = "Nome da Base de Dados";
            // 
            // pag3
            // 
            this.pag3.BackColor = System.Drawing.Color.Transparent;
            this.pag3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pag3.Controls.Add(this.stage_pw);
            this.pag3.Controls.Add(this.stage_password);
            this.pag3.Controls.Add(this.stage_usu);
            this.pag3.Controls.Add(this.stage_u);
            this.pag3.Controls.Add(this.stage_nbasedados);
            this.pag3.Controls.Add(this.stage_DataBase);
            this.pag3.Location = new System.Drawing.Point(4, 22);
            this.pag3.Name = "pag3";
            this.pag3.Padding = new System.Windows.Forms.Padding(3);
            this.pag3.Size = new System.Drawing.Size(715, 236);
            this.pag3.TabIndex = 2;
            this.pag3.Text = "Stage";
            // 
            // stage_pw
            // 
            this.stage_pw.AutoSize = true;
            this.stage_pw.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stage_pw.Location = new System.Drawing.Point(16, 154);
            this.stage_pw.Name = "stage_pw";
            this.stage_pw.Size = new System.Drawing.Size(45, 18);
            this.stage_pw.TabIndex = 14;
            this.stage_pw.Text = "Senha";
            // 
            // stage_password
            // 
            this.stage_password.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.stage_password.Location = new System.Drawing.Point(19, 184);
            this.stage_password.Multiline = true;
            this.stage_password.Name = "stage_password";
            this.stage_password.Size = new System.Drawing.Size(300, 25);
            this.stage_password.TabIndex = 13;
            // 
            // stage_usu
            // 
            this.stage_usu.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.stage_usu.Location = new System.Drawing.Point(19, 116);
            this.stage_usu.Multiline = true;
            this.stage_usu.Name = "stage_usu";
            this.stage_usu.Size = new System.Drawing.Size(300, 25);
            this.stage_usu.TabIndex = 12;
            // 
            // stage_u
            // 
            this.stage_u.AutoSize = true;
            this.stage_u.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stage_u.Location = new System.Drawing.Point(16, 85);
            this.stage_u.Name = "stage_u";
            this.stage_u.Size = new System.Drawing.Size(55, 18);
            this.stage_u.TabIndex = 11;
            this.stage_u.Text = "Usuário";
            // 
            // stage_nbasedados
            // 
            this.stage_nbasedados.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.stage_nbasedados.Location = new System.Drawing.Point(19, 48);
            this.stage_nbasedados.Multiline = true;
            this.stage_nbasedados.Name = "stage_nbasedados";
            this.stage_nbasedados.Size = new System.Drawing.Size(300, 25);
            this.stage_nbasedados.TabIndex = 10;
            // 
            // stage_DataBase
            // 
            this.stage_DataBase.AutoSize = true;
            this.stage_DataBase.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stage_DataBase.Location = new System.Drawing.Point(16, 17);
            this.stage_DataBase.Name = "stage_DataBase";
            this.stage_DataBase.Size = new System.Drawing.Size(152, 18);
            this.stage_DataBase.TabIndex = 9;
            this.stage_DataBase.Text = "Nome da Base de Dados";
            // 
            // ServidorProcess
            // 
            this.ServidorProcess.AutoSize = true;
            this.ServidorProcess.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServidorProcess.Location = new System.Drawing.Point(19, 28);
            this.ServidorProcess.Name = "ServidorProcess";
            this.ServidorProcess.Size = new System.Drawing.Size(134, 23);
            this.ServidorProcess.TabIndex = 4;
            this.ServidorProcess.Text = "Servidor Process";
            this.ServidorProcess.Click += new System.EventHandler(this.ServidorProcess_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipoDoProcesso);
            this.groupBox1.Controls.Add(this.tipo_do_processo);
            this.groupBox1.Controls.Add(this.nProcessamento);
            this.groupBox1.Controls.Add(this.prc);
            this.groupBox1.Location = new System.Drawing.Point(17, 499);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Do Processo";
            // 
            // tipoDoProcesso
            // 
            this.tipoDoProcesso.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoDoProcesso.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tipoDoProcesso.FormattingEnabled = true;
            this.tipoDoProcesso.Items.AddRange(new object[] {
            "Importação",
            "Exportação",
            "Captação de Arquivos",
            "Expurgo de Arquivos",
            "Rotinas do Sistema",
            "Mensagem",
            "Teste",
            "Envio de Sms",
            "Envio de E-mail"});
            this.tipoDoProcesso.Location = new System.Drawing.Point(393, 50);
            this.tipoDoProcesso.Name = "tipoDoProcesso";
            this.tipoDoProcesso.Size = new System.Drawing.Size(353, 28);
            this.tipoDoProcesso.TabIndex = 9;
            // 
            // tipo_do_processo
            // 
            this.tipo_do_processo.AutoSize = true;
            this.tipo_do_processo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_do_processo.Location = new System.Drawing.Point(389, 26);
            this.tipo_do_processo.Name = "tipo_do_processo";
            this.tipo_do_processo.Size = new System.Drawing.Size(125, 20);
            this.tipo_do_processo.TabIndex = 8;
            this.tipo_do_processo.Text = "Tipo do processo";
            // 
            // nProcessamento
            // 
            this.nProcessamento.AutoSize = true;
            this.nProcessamento.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nProcessamento.Location = new System.Drawing.Point(19, 27);
            this.nProcessamento.Name = "nProcessamento";
            this.nProcessamento.Size = new System.Drawing.Size(135, 20);
            this.nProcessamento.TabIndex = 7;
            this.nProcessamento.Text = "Nº Processamento";
            // 
            // prc
            // 
            this.prc.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prc.Location = new System.Drawing.Point(23, 50);
            this.prc.Multiline = true;
            this.prc.Name = "prc";
            this.prc.Size = new System.Drawing.Size(346, 28);
            this.prc.TabIndex = 5;
            this.prc.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Carregar_Scheduler
            // 
            this.Carregar_Scheduler.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Carregar_Scheduler.BackColor = System.Drawing.SystemColors.Window;
            this.Carregar_Scheduler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Carregar_Scheduler.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Carregar_Scheduler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Carregar_Scheduler.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carregar_Scheduler.Location = new System.Drawing.Point(17, 619);
            this.Carregar_Scheduler.Name = "Carregar_Scheduler";
            this.Carregar_Scheduler.Size = new System.Drawing.Size(369, 30);
            this.Carregar_Scheduler.TabIndex = 5;
            this.Carregar_Scheduler.Text = "Carregar Scheduler";
            this.Carregar_Scheduler.UseVisualStyleBackColor = false;
            this.Carregar_Scheduler.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gerar_Argumentos_Executor
            // 
            this.Gerar_Argumentos_Executor.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Gerar_Argumentos_Executor.BackColor = System.Drawing.SystemColors.Window;
            this.Gerar_Argumentos_Executor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gerar_Argumentos_Executor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gerar_Argumentos_Executor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Gerar_Argumentos_Executor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerar_Argumentos_Executor.Location = new System.Drawing.Point(410, 619);
            this.Gerar_Argumentos_Executor.Name = "Gerar_Argumentos_Executor";
            this.Gerar_Argumentos_Executor.Size = new System.Drawing.Size(378, 30);
            this.Gerar_Argumentos_Executor.TabIndex = 6;
            this.Gerar_Argumentos_Executor.Text = "Gerar Argumentos Executor";
            this.Gerar_Argumentos_Executor.UseVisualStyleBackColor = false;
            this.Gerar_Argumentos_Executor.Click += new System.EventHandler(this.Gerar_Argumentos_Executor_Click);
            // 
            // horaAtual
            // 
            this.horaAtual.AutoSize = true;
            this.horaAtual.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaAtual.Location = new System.Drawing.Point(13, 736);
            this.horaAtual.Name = "horaAtual";
            this.horaAtual.Size = new System.Drawing.Size(99, 23);
            this.horaAtual.TabIndex = 7;
            this.horaAtual.Text = "Data e Hora";
            this.horaAtual.Click += new System.EventHandler(this.horaAtual_Click);
            // 
            // folderBrowser
            // 
            this.folderBrowser.FileName = "openFileDialog1";
            this.folderBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // AgendaId_ConfProcessamentoId_TipoProcessoId
            // 
            this.AgendaId_ConfProcessamentoId_TipoProcessoId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgendaId_ConfProcessamentoId_TipoProcessoId.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgendaId_ConfProcessamentoId_TipoProcessoId.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgendaId_ConfProcessamentoId_TipoProcessoId.Location = new System.Drawing.Point(17, 675);
            this.AgendaId_ConfProcessamentoId_TipoProcessoId.Name = "AgendaId_ConfProcessamentoId_TipoProcessoId";
            this.AgendaId_ConfProcessamentoId_TipoProcessoId.Size = new System.Drawing.Size(771, 45);
            this.AgendaId_ConfProcessamentoId_TipoProcessoId.TabIndex = 8;
            this.AgendaId_ConfProcessamentoId_TipoProcessoId.UseVisualStyleBackColor = true;
            this.AgendaId_ConfProcessamentoId_TipoProcessoId.Click += new System.EventHandler(this.AgendaId_ConfProcessamentoId_TipoProcessoId_Click);
            // 
            // debugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(801, 768);
            this.Controls.Add(this.AgendaId_ConfProcessamentoId_TipoProcessoId);
            this.Controls.Add(this.horaAtual);
            this.Controls.Add(this.Gerar_Argumentos_Executor);
            this.Controls.Add(this.Carregar_Scheduler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dadosDeAcesso);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CaminhoScheduler);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "debugger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasken";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dadosDeAcesso.ResumeLayout(false);
            this.dadosDeAcesso.PerformLayout();
            this.bd.ResumeLayout(false);
            this.pag1.ResumeLayout(false);
            this.pag1.PerformLayout();
            this.pag2.ResumeLayout(false);
            this.pag2.PerformLayout();
            this.pag3.ResumeLayout(false);
            this.pag3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CaminhoScheduler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.GroupBox dadosDeAcesso;
        private System.Windows.Forms.Label ServidorProcess;
        private System.Windows.Forms.TextBox ServProcess;
        private System.Windows.Forms.TabControl bd;
        private System.Windows.Forms.TabPage pag1;
        private System.Windows.Forms.TabPage pag2;
        private System.Windows.Forms.TabPage pag3;
        private System.Windows.Forms.TextBox prc_usuario;
        private System.Windows.Forms.TextBox prc_password;
        private System.Windows.Forms.TextBox prc_nbasedados;
        private System.Windows.Forms.Label prc_Senha;
        private System.Windows.Forms.Label prc_Usu;
        private System.Windows.Forms.Label prc_Nome_Da_Base_De_Dados;
        private System.Windows.Forms.TextBox src_nbasedados;
        private System.Windows.Forms.Label src_Nome_Da_Base_De_Dados;
        private System.Windows.Forms.Label src_senha;
        private System.Windows.Forms.TextBox src_password;
        private System.Windows.Forms.TextBox src_usu;
        private System.Windows.Forms.Label src_Usuario;
        private System.Windows.Forms.Label stage_pw;
        private System.Windows.Forms.TextBox stage_password;
        private System.Windows.Forms.TextBox stage_usu;
        private System.Windows.Forms.Label stage_u;
        private System.Windows.Forms.TextBox stage_nbasedados;
        private System.Windows.Forms.Label stage_DataBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tipo_do_processo;
        private System.Windows.Forms.Label nProcessamento;
        private System.Windows.Forms.TextBox prc;
        private System.Windows.Forms.Button Carregar_Scheduler;
        private System.Windows.Forms.Button Gerar_Argumentos_Executor;
        private System.Windows.Forms.Label horaAtual;
        private System.Windows.Forms.TextBox ipBaseSrc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog folderBrowser;
        private System.Windows.Forms.Button AgendaId_ConfProcessamentoId_TipoProcessoId;
        private System.Windows.Forms.ComboBox tipoDoProcesso;
    }
}

