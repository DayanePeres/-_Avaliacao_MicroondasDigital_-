//**
//***************** Dayane Fernanda Souza Peres - dayane.fernandaperes@gmail.com - (18) 9 9663-1006 ******
//**


using MicroondasDigital.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MicroondasDigital
{
    public partial class frmPrincipal : Form
    {
        Thread trd;
        
        int segundos = 0, potencia = 0;
        string charAtual = ".";
        bool pausado = true;

        List<ProgramasAquecimento> listPrograma = new List<ProgramasAquecimento>();

        public frmPrincipal()
        {
            InitializeComponent();
            trd = new Thread(new ThreadStart(AtualizaLabels));

            listPrograma.Add(new ProgramasAquecimento("Peixe", 120, 7, '!'));
            listPrograma.Add(new ProgramasAquecimento("Pipoca", 90, 6, '@'));
            listPrograma.Add(new ProgramasAquecimento("Brigadeiro", 80, 5, '#'));
            listPrograma.Add(new ProgramasAquecimento("Frango", 70, 4, '$'));
            listPrograma.Add(new ProgramasAquecimento("Assados", 60, 10, '%'));
            
            
            cbbProgramas.DataSource = listPrograma; // cbb recebe a lista pré-definida
            cbbProgramas.DisplayMember = "Nome";

            cbbProgramas.SelectedIndex = -1;
            //rbManual.Checked = true;

            ttbNome.Enabled = false;
            mskTempoCadastro.Enabled = false;
            cbbpotenciaCadastro.Enabled = false;
            btNovo.Enabled = true;
        }

        //Atualiza informação na tela.
        void AtualizaLabels()
        {
            MethodInvoker update = new MethodInvoker(Atualiza);
            while (segundos > 0)
            {
                if (!pausado)
                {
                    Thread.Sleep(1000);
                    segundos--;
                    Invoke(update);
                }
            }
            MessageBox.Show("Aquecimento concluído! \n" + ttbInformacaoAquecimento.Text, "Micro-ondas", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            trd.Abort();
            
        }
        

        private void Aquecimento(string tempo, int pot, string strchar)
        {
            segundos = textoValido(tempo);
            if (segundos > 0)
            {
                if (ValidaTempo(segundos))
                {
                    charAtual = strchar;
                    potencia = pot;
                    pausado = false;
                    trd.Start();

                    // Salva arquivo 
                    if (!rbManual.Checked && !rbProgramas.Checked)
                    {
                        SaveFileDialog saveFile = new SaveFileDialog();
                        saveFile.FileName = "TesteBenner";
                        saveFile.DefaultExt = ".txt";
                        FileStream fs = new FileStream(saveFile.FileName, FileMode.Create);
                        StreamWriter writer = new StreamWriter(fs);
                        writer.Write(ttbInformacaoAquecimento.Text);
                        writer.Close();
                    }
                }
                else
                    btnCancelar.PerformClick();
            }
            else
            {
                MessageBox.Show("Tempo inválido!", "Micro-ondas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnCancelar.PerformClick();
            }
        }

        private bool ValidaTempo(int seg)
        {
            if (seg < 1)
            {
                MessageBox.Show("Tempo menor do que o mínimo(1 segundo)!", "Micro-ondas", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (seg > 120)
            {
                MessageBox.Show("Tempo maior do que o máximo(2 minutos)!", "Micro-ondas", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        public int textoValido(string texto)
        {
            try
            {
                if (texto.Length > 5) // verifica se todos os campos do tempo foram preenchidos
                    return -1;
                if (!texto.Contains(":"))// verifica se está no formato de hora
                    return -2;

                string strMinutos = texto.Substring(0, texto.IndexOf(":"));
                string strSegundos = texto.Substring(texto.IndexOf(":") + 1, texto.Length - (texto.IndexOf(":") + 1));

                if (strMinutos == "" || strSegundos == "")
                    return -3;
                else
                    return Convert.ToInt32(strMinutos) * 60 + Convert.ToInt32(strSegundos);
            }
            catch (Exception)
            {
                return -5;
            }
        }

        public String TransformaSegundosParaHora(int segundos)
        {
            int horas, minutos;

            String min = "", seg = "";
            horas = segundos / 3600;
            segundos %= 3600;
            minutos = segundos / 60;

            if (minutos < 10)
                min = "0";

            min += minutos.ToString();
            segundos %= 60;

            if (segundos < 10)
                seg = "0";
            seg += segundos.ToString();

            return min + ":" + seg;
        }

       

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!trd.IsAlive)
            {
                if (rbManual.Checked)
                {
                    string strMsg = "";
                    string[] tempo = mskTempo.Text.Split(':');

                    if (string.IsNullOrWhiteSpace(tempo[0]) && string.IsNullOrWhiteSpace(tempo[1]))
                        strMsg += "Informe o Tempo!\n";
                    if (string.IsNullOrWhiteSpace(cbbPotencia.SelectedItem.ToString()))
                        strMsg += "Informe a potência!";
                    if (string.IsNullOrEmpty(strMsg))
                    {
                        trd.Abort();
                        cbbPotencia.ValueMember = "10";
                        Aquecimento(mskTempo.Text, Convert.ToInt32(cbbPotencia.Text), ".");

                    }
                    else
                    {
                        MessageBox.Show(strMsg + "");
                    }

                }
                else
                {
                    if (rbProgramas.Checked)
                    {
                        if (cbbProgramas.Text != "")
                        {
                            Aquecimento(mskTempoPrograma.Text,
                                        Convert.ToInt32(cbbPotenciaPrograma.Text),
                                        listPrograma.ElementAt(cbbProgramas.SelectedIndex).Carcter.ToString());

                            
                        }
                        else
                            MessageBox.Show("Escolha um programa!", "Micro-ondas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        int cont = 0;
                        if (mskTempoArq.Text != "")
                        {
                            Aquecimento(mskTempoArq.Text, Convert.ToInt32(cbbPotenciaArq.Text), charAtual);
                            cont = 1;
                           
                        }
                        else
                            MessageBox.Show("Escolha um arquivo válido!", "Micro-ondas",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                    }
                }
               
            }
            else
                pausado = false;
        }

       

        private void btnPausar_Click(object sender, EventArgs e)
        {
            pausado = !pausado;
        }

        private void btnAquecerPadrao_Click(object sender, EventArgs e)
        {

            charAtual = ".";
            mskTempo.Text = "00:30";
            cbbPotencia.Text = "8";
            Thread.Sleep(300);
            segundos = textoValido(mskTempo.Text);
            potencia = Convert.ToInt32(cbbPotencia.Text);
            pausado = false;
            trd.Start();
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManual.Checked)
            {
                rbProgramas.Checked = false;
                mskTempoPrograma.Enabled = false;
                mskTempoPrograma.Text = "";
                cbbPotenciaPrograma.Enabled = false;
                cbbPotenciaPrograma.SelectedIndex = -1;

                rbManual.Checked = true; ;
                mskTempo.Enabled = true;
                cbbPotencia.Enabled = true;

            }
            
        }

        private void cbbProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbProgramas.SelectedIndex > -1)
            {
                mskTempoPrograma.Text = TransformaSegundosParaHora(listPrograma.ElementAt(cbbProgramas.SelectedIndex).Tempo);
                cbbPotenciaPrograma.SelectedItem
                    = listPrograma.ElementAt(cbbProgramas.SelectedIndex).Potencia.ToString();
            }
           
            
        }

        private void rbProgramas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProgramas.Checked)
            {
                rbManual.Checked = false;
                mskTempo.Enabled = false;
                mskTempo.Text = "";
                cbbPotencia.Enabled = false;
                cbbPotencia.SelectedIndex = -1;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            rbManual.Checked = false;
            mskTempo.Enabled = false;
            mskTempo.Text = "";
            cbbPotencia.Enabled = false;
            cbbPotencia.SelectedIndex = -1;

            rbProgramas.Checked = false;
            mskTempoPrograma.Enabled = false;
            mskTempoPrograma.Text = "";
            cbbPotenciaPrograma.Enabled = false;
            cbbPotenciaPrograma.SelectedIndex = -1;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            ttbNome.Enabled = true;
            mskTempoCadastro.Enabled = true;
            cbbpotenciaCadastro.Enabled = true;
            btNovo.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsg = "";

                string[] tempo = mskTempoCadastro.Text.Split(':');

                if (string.IsNullOrWhiteSpace(ttbNome.Text))
                    strMsg += "Informe o Nome!\n";
                if (string.IsNullOrWhiteSpace(tempo[0]) && string.IsNullOrWhiteSpace(tempo[1]))
                    strMsg += "Informe o Tempo!\n";
                if (string.IsNullOrWhiteSpace(cbbpotenciaCadastro.SelectedItem.ToString()))
                    strMsg += "Informe a potência!\n";
                if (string.IsNullOrWhiteSpace(ttbCaracterCadastro.Text) && ttbCaracterCadastro.Text.Length != 1)
                    strMsg += "Informe o Caracter!\n";

               

                if (string.IsNullOrEmpty(strMsg))
                {
                    int intTempo = Convert.ToInt32(tempo[1]) + (Convert.ToInt32(tempo[0]) * 60);
                    listPrograma.Add(new ProgramasAquecimento(ttbNome.Text, intTempo, Convert.ToInt32(cbbpotenciaCadastro.SelectedValue), Convert.ToChar(ttbCaracterCadastro.Text)));

                    MessageBox.Show("Cadastro Salvo!");
                    ttbNome.Enabled = false;
                    ttbNome.Text = "";
                    mskTempoCadastro.Enabled = false;
                    mskTempoCadastro.Text = "";
                    cbbpotenciaCadastro.Enabled = false;
                    cbbpotenciaCadastro.SelectedIndex = -1;
                    btNovo.Enabled = false;

                    cbbProgramas.DataSource = new List<ProgramasAquecimento> ();
                    cbbProgramas.DataSource = listPrograma;
                    cbbProgramas.DisplayMember = "Nome";
                }
                else
                {
                    MessageBox.Show(strMsg + "");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex+"");
            }
        }

        private void btnAbrirArq_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                var fileString = openFile.OpenFile();
                using (StreamReader reader = new StreamReader(fileString))
                {
                    var text = reader.ReadToEnd();

                    string[] verifica = text.Split(' ');
                    mskTempoArq.Text = TransformaSegundosParaHora(Convert.ToInt32(verifica[1]));
                    cbbPotenciaArq.SelectedIndex = Convert.ToInt32(verifica[2])-1 ;
                    charAtual = verifica[3];
                }
            }
        }

       
        // Atualiza tela de tempo
        private void Atualiza()
        {
            
            if (rbManual.Checked)
                mskTempo.Text = TransformaSegundosParaHora(segundos);
            else
            {
                if (rbProgramas.Checked)
                    mskTempoPrograma.Text = TransformaSegundosParaHora(segundos);
                else
                    mskTempoArq.Text = TransformaSegundosParaHora(segundos);
            }
            for (int i = 0; i < potencia; i++)
                ttbInformacaoAquecimento.Text += charAtual;

        }
    }

}

        
    

