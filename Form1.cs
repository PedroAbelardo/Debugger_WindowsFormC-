using AcessoFacilSqlServer;
using ServiceStack.Configuration;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;

namespace Debugger_Tasken_2020
{
    public partial class debugger : Form
    {
        public debugger()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = DateTime.Now.Date.ToString("dd/MM/yyyy");
            horaAtual.Text = string.Concat(data, " ", DateTime.Now.ToLongTimeString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void servidor_process(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CaminhoScheduler_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pag2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!VerificarCamposVaziosNoCarregarScheduler()) //se for falso entra
            {
                try
                {
                    string path = CaminhoScheduler.Text;
                    ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
                    configMap.ExeConfigFilename = path;
                    var settings = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None).AppSettings.Settings;

                    NomearDadosDeAcesso(settings);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Um erro foi encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Informe o caminho do Process Scheduler", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void horaAtual_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgendaId_ConfProcessamentoId_TipoProcessoId_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(AgendaId_ConfProcessamentoId_TipoProcessoId.Text, TextDataFormat.Text);
            MessageBox.Show("Argumentos Copiados !!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sp_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServidorProcess_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Localizar Arquivo Scheduler.Config";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                CaminhoScheduler.Text = openFileDialog.FileName;
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void NomearDadosDeAcesso(KeyValueConfigurationCollection dados)
        {
            ServProcess.Text = dados["ServidorProcessServico"].Value;

            // configurações process Serviço
            prc_nbasedados.Text = dados["DatabaseProcessServico"].Value;
            prc_usuario.Text = dados["UsuarioProcessServico"].Value;
            prc_password.Text = dados["SenhaProcessServico"].Value;
            prc_password.PasswordChar = '*';

            //configurações SRC Serviço
            src_nbasedados.Text = dados["DatabaseSRCServico"].Value;
            src_usu.Text = dados["UsuarioSRCServico"].Value;
            src_password.Text = dados["SenhaSRCServico"].Value;
            src_password.PasswordChar = '*';

            //configurações Stage Serviço
            stage_nbasedados.Text = dados["pSmartwayStageBanco"].Value;
            stage_usu.Text = dados["pSmartwayStageUsuario"].Value;
            stage_password.Text = dados["pSmartwayStageSenha"].Value;
            stage_password.PasswordChar = '*';
        }

        private void Gerar_Argumentos_Executor_Click(object sender, EventArgs e)
        {
            if (!VerificarCamposVaziosNoGerarArgumentosExecutor())
            {
                try
                {
                    using (var query = new Query($"Server={ServProcess.Text};Database={prc_nbasedados.Text};User Id={prc_usuario.Text};Password={prc_password.Text};"))
                    {
                        query.Script = $"SELECT LIM_AGE_ID, LIM_CPR_ID FROM SPR_TBL_LOG_PROCESSO WHERE LIM_ID = {prc.Text}";
                        query.Abrir();

                        if (query.RetornouDados())
                        {
                            while (query.Proximo())
                            {
                                string agendaId = query.ObterInteiro("LIM_AGE_ID").ToString();
                                string configuracaoProcessamentoID = query.ObterInteiro("LIM_CPR_ID").ToString();
                                string tipoProcesso = (tipoDoProcesso.SelectedIndex + 1).ToString();

                                AgendaId_ConfProcessamentoId_TipoProcessoId.Text = string.Concat(agendaId, " ", configuracaoProcessamentoID, " ", tipoProcesso);
                            }
                        }
                        SalvarConfiguracoes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public bool VerificarCamposVaziosNoCarregarScheduler()
        {
            if (string.IsNullOrEmpty(CaminhoScheduler.Text))
                return true;

            return false;
        }

        public bool VerificarCamposVaziosNoGerarArgumentosExecutor()
        {
            if (string.IsNullOrEmpty(CaminhoScheduler.Text))
            {
                MessageBox.Show("Informe o caminho do arquivo Scheduler.Config", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else if (string.IsNullOrEmpty(prc.Text))
            {
                MessageBox.Show("Informe o Nº do processamento", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else if (string.IsNullOrEmpty(ServProcess.Text))
            {
                MessageBox.Show("Informe o servidor de banco do Process e SRC", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else
            {
                foreach (Control t in bd.Controls)
                {
                    if (t is TabPage)
                    {
                        foreach (Control text in t.Controls)
                        {
                            if (text is TextBox)
                            {
                                if (text.Text == string.Empty && text.Name.Equals("prc_nbasedados"))
                                {
                                    MessageBox.Show($"Preencha o campo {prc_Nome_Da_Base_De_Dados.Text} do {pag1.Text}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return true;
                                }
                                else if (text.Text == string.Empty && text.Name.Equals("prc_usuario"))
                                {
                                    MessageBox.Show($"Preencha o campo {prc_Usu.Text} do {pag1.Text}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return true;
                                }
                                else if (text.Text == string.Empty && text.Name.Equals("prc_password"))
                                {
                                    MessageBox.Show($"Preencha o campo {prc_Senha.Text} do {pag1.Text}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return true;
                                }
                                else if (text.Text == string.Empty && text.Name.Equals("src_nbasedados"))
                                {
                                    MessageBox.Show($"Preencha o campo {src_Nome_Da_Base_De_Dados.Text} do {pag2.Text}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return true;
                                }
                                else if (text.Text == string.Empty && text.Name.Equals("src_usuario"))
                                {
                                    MessageBox.Show($"Preencha o campo {src_usu.Text} do {pag2.Text}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return true;
                                }
                                else if (text.Text == string.Empty && text.Name.Equals("src_password"))
                                {
                                    MessageBox.Show($"Preencha o campo {src_senha.Text} do {pag2.Text}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return true;
                                }
                                else if (text.Text == string.Empty && text.Name.Equals("stage_nbasedados"))
                                {
                                    MessageBox.Show($"Preencha o campo {stage_DataBase.Text} da {pag3.Text}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return true;
                                }
                                else if (text.Text == string.Empty && text.Name.Equals("stage_usu"))
                                {
                                    MessageBox.Show($"Preencha o campo {stage_u.Text} da {pag3.Text}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return true;
                                }
                                else if (text.Text == string.Empty && text.Name.Equals("stage_password"))
                                {
                                    MessageBox.Show($"Preencha o campo {stage_pw.Text} da {pag3.Text}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return true;
                                }
                            }
                        }
                    }

                }

                if (string.IsNullOrEmpty(tipoDoProcesso.Text))
                {
                    MessageBox.Show($"Preencha o campo {tipo_do_processo.Text}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
            }

            return false;
            //if (bd.SelectedTab != null)
            //{
            //    if (bd.SelectedTab.Controls.Count > 0)
            //    {
            //        if (bd.SelectedTab.Controls[0] is debugger)
            //        {
            //            debugger d = bd.SelectedTab.Controls[0] as debugger;

            //            if (string.IsNullOrEmpty(d.prc_nbasedados.ToString()))
            //            {

            //            }
            //        }
            //    }
            //}
        }

        public void SalvarConfiguracoes()
        {
            string path = CaminhoScheduler.Text;
            ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
            configMap.ExeConfigFilename = path;
            var settings = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None).AppSettings.Settings;

            //PASSANDO AS CONFIGURAÇÕES DO EXECUTAVEL PARA O ARQUIVO NO SERVIDOR PROCESS
            settings["ServidorProcessServico"].Value = ServProcess.Text;

            //PASSANDO AS CONFIGURAÇÕES DO EXECUTAVEL PARA O ARQUIVO NA PARTE DO PROCESS
            settings["DatabaseProcessServico"].Value = prc_nbasedados.Text;
            settings["UsuarioProcessServico"].Value = prc_usuario.Text;
            settings["SenhaProcessServico"].Value = prc_password.Text;

            //PASSANDO AS CONFIGURAÇÕES DO EXECUTAVEL PARA O ARQUIVO NA PARTE DO SRC
            settings["DatabaseSRCServico"].Value = src_nbasedados.Text;
            settings["UsuarioSRCServico"].Value = src_usu.Text;
            settings["SenhaSRCServico"].Value = src_password.Text;

            //PASSANDO AS CONFIGURAÇÕES DO EXECUTAVEL PARA O ARQUIVO NA PARTE DA STAGE
            settings["pSmartwayStageBanco"].Value = stage_nbasedados.Text;
            settings["pSmartwayStageUsuario"].Value = stage_usu.Text;
            settings["pSmartwayStageSenha"].Value = stage_password.Text;

            //SALVA AS CONFIGURAÇÕES NO ARQUIVO
            settings.CurrentConfiguration.Save();
        }
    }
}
