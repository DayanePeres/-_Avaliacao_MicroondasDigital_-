namespace MicroondasDigital
{
    partial class frmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbProgramas = new System.Windows.Forms.RadioButton();
            this.cbbProgramas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbPotenciaPrograma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTempoPrograma = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbPotenciaArq = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAbrirArq = new System.Windows.Forms.Button();
            this.mskTempoArq = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ttbCaracter = new System.Windows.Forms.Label();
            this.ttbCaracterCadastro = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.cbbpotenciaCadastro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTempoCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.cbbPotencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTempo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbInformacaoAquecimento = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnAquecerPadrao = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.sfdSalvarArq = new System.Windows.Forms.SaveFileDialog();
            this.ofdAbrirArq = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnPausar);
            this.panel1.Controls.Add(this.btnAquecerPadrao);
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 426);
            this.panel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.rbProgramas);
            this.groupBox5.Controls.Add(this.cbbProgramas);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.cbbPotenciaPrograma);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.mskTempoPrograma);
            this.groupBox5.Location = new System.Drawing.Point(200, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(191, 122);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Programas de Aquecimento";
            // 
            // rbProgramas
            // 
            this.rbProgramas.AutoSize = true;
            this.rbProgramas.Location = new System.Drawing.Point(14, 16);
            this.rbProgramas.Name = "rbProgramas";
            this.rbProgramas.Size = new System.Drawing.Size(155, 17);
            this.rbProgramas.TabIndex = 13;
            this.rbProgramas.TabStop = true;
            this.rbProgramas.Text = "Programas de Aquecimento";
            this.rbProgramas.UseVisualStyleBackColor = true;
            this.rbProgramas.CheckedChanged += new System.EventHandler(this.rbProgramas_CheckedChanged);
            // 
            // cbbProgramas
            // 
            this.cbbProgramas.FormattingEnabled = true;
            this.cbbProgramas.Location = new System.Drawing.Point(103, 39);
            this.cbbProgramas.Name = "cbbProgramas";
            this.cbbProgramas.Size = new System.Drawing.Size(82, 21);
            this.cbbProgramas.TabIndex = 13;
            this.cbbProgramas.SelectedIndexChanged += new System.EventHandler(this.cbbProgramas_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Programa";
            // 
            // cbbPotenciaPrograma
            // 
            this.cbbPotenciaPrograma.FormattingEnabled = true;
            this.cbbPotenciaPrograma.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbPotenciaPrograma.Location = new System.Drawing.Point(103, 95);
            this.cbbPotenciaPrograma.Name = "cbbPotenciaPrograma";
            this.cbbPotenciaPrograma.Size = new System.Drawing.Size(82, 21);
            this.cbbPotenciaPrograma.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tempo*:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Potência*:";
            // 
            // mskTempoPrograma
            // 
            this.mskTempoPrograma.Location = new System.Drawing.Point(103, 66);
            this.mskTempoPrograma.Mask = "90:00";
            this.mskTempoPrograma.Name = "mskTempoPrograma";
            this.mskTempoPrograma.Size = new System.Drawing.Size(82, 20);
            this.mskTempoPrograma.TabIndex = 10;
            this.mskTempoPrograma.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.cbbPotenciaArq);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnAbrirArq);
            this.groupBox4.Controls.Add(this.mskTempoArq);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(397, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 192);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Abrir informações de Arquivo";
            // 
            // cbbPotenciaArq
            // 
            this.cbbPotenciaArq.FormattingEnabled = true;
            this.cbbPotenciaArq.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbPotenciaArq.Location = new System.Drawing.Point(114, 133);
            this.cbbPotenciaArq.Name = "cbbPotenciaArq";
            this.cbbPotenciaArq.Size = new System.Drawing.Size(215, 21);
            this.cbbPotenciaArq.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tempo*:";
            // 
            // btnAbrirArq
            // 
            this.btnAbrirArq.BackColor = System.Drawing.Color.White;
            this.btnAbrirArq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArq.Location = new System.Drawing.Point(18, 31);
            this.btnAbrirArq.Name = "btnAbrirArq";
            this.btnAbrirArq.Size = new System.Drawing.Size(329, 36);
            this.btnAbrirArq.TabIndex = 19;
            this.btnAbrirArq.Text = "Abrir arquivo";
            this.btnAbrirArq.UseVisualStyleBackColor = false;
            this.btnAbrirArq.Click += new System.EventHandler(this.btnAbrirArq_Click);
            // 
            // mskTempoArq
            // 
            this.mskTempoArq.Location = new System.Drawing.Point(114, 98);
            this.mskTempoArq.Mask = "90:00";
            this.mskTempoArq.Name = "mskTempoArq";
            this.mskTempoArq.Size = new System.Drawing.Size(215, 20);
            this.mskTempoArq.TabIndex = 21;
            this.mskTempoArq.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Potência*:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.ttbCaracter);
            this.groupBox3.Controls.Add(this.ttbCaracterCadastro);
            this.groupBox3.Controls.Add(this.btNovo);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ttbNome);
            this.groupBox3.Controls.Add(this.cbbpotenciaCadastro);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.mskTempoCadastro);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(397, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 198);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Criar Aquecimento Personalizado";
            // 
            // ttbCaracter
            // 
            this.ttbCaracter.AutoSize = true;
            this.ttbCaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbCaracter.Location = new System.Drawing.Point(15, 127);
            this.ttbCaracter.Name = "ttbCaracter";
            this.ttbCaracter.Size = new System.Drawing.Size(71, 17);
            this.ttbCaracter.TabIndex = 20;
            this.ttbCaracter.Text = "Caracter*:";
            // 
            // ttbCaracterCadastro
            // 
            this.ttbCaracterCadastro.Location = new System.Drawing.Point(99, 128);
            this.ttbCaracterCadastro.Name = "ttbCaracterCadastro";
            this.ttbCaracterCadastro.Size = new System.Drawing.Size(215, 20);
            this.ttbCaracterCadastro.TabIndex = 19;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.White;
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(99, 155);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(96, 33);
            this.btNovo.TabIndex = 18;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(201, 155);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 33);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nome*:";
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(99, 29);
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(215, 20);
            this.ttbNome.TabIndex = 16;
            // 
            // cbbpotenciaCadastro
            // 
            this.cbbpotenciaCadastro.FormattingEnabled = true;
            this.cbbpotenciaCadastro.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbpotenciaCadastro.Location = new System.Drawing.Point(99, 98);
            this.cbbpotenciaCadastro.Name = "cbbpotenciaCadastro";
            this.cbbpotenciaCadastro.Size = new System.Drawing.Size(215, 21);
            this.cbbpotenciaCadastro.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tempo*:";
            // 
            // mskTempoCadastro
            // 
            this.mskTempoCadastro.Location = new System.Drawing.Point(99, 63);
            this.mskTempoCadastro.Mask = "90:00";
            this.mskTempoCadastro.Name = "mskTempoCadastro";
            this.mskTempoCadastro.Size = new System.Drawing.Size(215, 20);
            this.mskTempoCadastro.TabIndex = 14;
            this.mskTempoCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Potência*:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.rbManual);
            this.groupBox2.Controls.Add(this.cbbPotencia);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mskTempo);
            this.groupBox2.Location = new System.Drawing.Point(17, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 122);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informe:";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(22, 20);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(141, 17);
            this.rbManual.TabIndex = 12;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Preencher Manualmente";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // cbbPotencia
            // 
            this.cbbPotencia.FormattingEnabled = true;
            this.cbbPotencia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbPotencia.Location = new System.Drawing.Point(103, 90);
            this.cbbPotencia.Name = "cbbPotencia";
            this.cbbPotencia.Size = new System.Drawing.Size(52, 21);
            this.cbbPotencia.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Potência*:";
            // 
            // mskTempo
            // 
            this.mskTempo.Location = new System.Drawing.Point(103, 49);
            this.mskTempo.Mask = "90:00";
            this.mskTempo.Name = "mskTempo";
            this.mskTempo.Size = new System.Drawing.Size(52, 20);
            this.mskTempo.TabIndex = 10;
            this.mskTempo.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.ttbInformacaoAquecimento);
            this.groupBox1.Location = new System.Drawing.Point(11, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 129);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações de Aquecimento";
            // 
            // ttbInformacaoAquecimento
            // 
            this.ttbInformacaoAquecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbInformacaoAquecimento.ForeColor = System.Drawing.Color.Red;
            this.ttbInformacaoAquecimento.Location = new System.Drawing.Point(6, 19);
            this.ttbInformacaoAquecimento.Multiline = true;
            this.ttbInformacaoAquecimento.Name = "ttbInformacaoAquecimento";
            this.ttbInformacaoAquecimento.Size = new System.Drawing.Size(341, 90);
            this.ttbInformacaoAquecimento.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(184, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 46);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.BackColor = System.Drawing.Color.White;
            this.btnPausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausar.Location = new System.Drawing.Point(41, 219);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(131, 46);
            this.btnPausar.TabIndex = 7;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnAquecerPadrao
            // 
            this.btnAquecerPadrao.BackColor = System.Drawing.Color.White;
            this.btnAquecerPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAquecerPadrao.Location = new System.Drawing.Point(184, 167);
            this.btnAquecerPadrao.Name = "btnAquecerPadrao";
            this.btnAquecerPadrao.Size = new System.Drawing.Size(131, 46);
            this.btnAquecerPadrao.TabIndex = 6;
            this.btnAquecerPadrao.Text = "Aquecer Padrão";
            this.btnAquecerPadrao.UseVisualStyleBackColor = false;
            this.btnAquecerPadrao.Click += new System.EventHandler(this.btnAquecerPadrao_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.White;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(39, 167);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(131, 46);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // sfdSalvarArq
            // 
            this.sfdSalvarArq.Filter = "Arquivo .xml| *.xml";

            // 
            // ofdAbrirArq
            // 
            this.ofdAbrirArq.FileName = "openFileDialog1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Micro-ondas Digital";
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnAquecerPadrao;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPotencia;
        private System.Windows.Forms.MaskedTextBox mskTempo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ttbInformacaoAquecimento;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbbProgramas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbPotenciaPrograma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTempoPrograma;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbpotenciaCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTempoCadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.SaveFileDialog sfdSalvarArq;
        private System.Windows.Forms.OpenFileDialog ofdAbrirArq;
        private System.Windows.Forms.ComboBox cbbPotenciaArq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAbrirArq;
        private System.Windows.Forms.MaskedTextBox mskTempoArq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.RadioButton rbProgramas;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Label ttbCaracter;
        private System.Windows.Forms.TextBox ttbCaracterCadastro;
    }
}

