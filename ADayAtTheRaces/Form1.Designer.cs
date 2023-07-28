namespace ADayAtTheRaces
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.img_RacingLine = new System.Windows.Forms.PictureBox();
            this.img_Dog1 = new System.Windows.Forms.PictureBox();
            this.img_Dog2 = new System.Windows.Forms.PictureBox();
            this.img_Dog3 = new System.Windows.Forms.PictureBox();
            this.img_Dog4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_Name2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_JoeBet = new System.Windows.Forms.Label();
            this.lbl_BobBet = new System.Windows.Forms.Label();
            this.lbl_AlBet = new System.Windows.Forms.Label();
            this.lbl_CurrentMoney = new System.Windows.Forms.Label();
            this.lbl_InitialMoney = new System.Windows.Forms.Label();
            this.lbl_Name1 = new System.Windows.Forms.Label();
            this.nrc_DogNum = new System.Windows.Forms.NumericUpDown();
            this.lbl_BucksTxt = new System.Windows.Forms.Label();
            this.nrc_Bucks = new System.Windows.Forms.NumericUpDown();
            this.btn_Bet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Apostadores = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Joe = new System.Windows.Forms.RadioButton();
            this.btn_Bob = new System.Windows.Forms.RadioButton();
            this.btn_Al = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.img_RacingLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dog4)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrc_DogNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrc_Bucks)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_RacingLine
            // 
            this.img_RacingLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.img_RacingLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img_RacingLine.Image = ((System.Drawing.Image)(resources.GetObject("img_RacingLine.Image")));
            this.img_RacingLine.Location = new System.Drawing.Point(12, 11);
            this.img_RacingLine.Name = "img_RacingLine";
            this.img_RacingLine.Size = new System.Drawing.Size(484, 168);
            this.img_RacingLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_RacingLine.TabIndex = 0;
            this.img_RacingLine.TabStop = false;
            // 
            // img_Dog1
            // 
            this.img_Dog1.Image = ((System.Drawing.Image)(resources.GetObject("img_Dog1.Image")));
            this.img_Dog1.Location = new System.Drawing.Point(18, 14);
            this.img_Dog1.Name = "img_Dog1";
            this.img_Dog1.Size = new System.Drawing.Size(46, 35);
            this.img_Dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Dog1.TabIndex = 1;
            this.img_Dog1.TabStop = false;
            this.img_Dog1.Click += new System.EventHandler(this.img_Dog1_Click);
            // 
            // img_Dog2
            // 
            this.img_Dog2.Image = ((System.Drawing.Image)(resources.GetObject("img_Dog2.Image")));
            this.img_Dog2.Location = new System.Drawing.Point(18, 55);
            this.img_Dog2.Name = "img_Dog2";
            this.img_Dog2.Size = new System.Drawing.Size(46, 35);
            this.img_Dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Dog2.TabIndex = 2;
            this.img_Dog2.TabStop = false;
            this.img_Dog2.Click += new System.EventHandler(this.img_Dog2_Click);
            // 
            // img_Dog3
            // 
            this.img_Dog3.Image = ((System.Drawing.Image)(resources.GetObject("img_Dog3.Image")));
            this.img_Dog3.Location = new System.Drawing.Point(18, 96);
            this.img_Dog3.Name = "img_Dog3";
            this.img_Dog3.Size = new System.Drawing.Size(46, 35);
            this.img_Dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Dog3.TabIndex = 3;
            this.img_Dog3.TabStop = false;
            this.img_Dog3.Click += new System.EventHandler(this.img_Dog3_Click);
            // 
            // img_Dog4
            // 
            this.img_Dog4.Image = ((System.Drawing.Image)(resources.GetObject("img_Dog4.Image")));
            this.img_Dog4.Location = new System.Drawing.Point(18, 137);
            this.img_Dog4.Name = "img_Dog4";
            this.img_Dog4.Size = new System.Drawing.Size(46, 35);
            this.img_Dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Dog4.TabIndex = 4;
            this.img_Dog4.TabStop = false;
            this.img_Dog4.Click += new System.EventHandler(this.img_Dog4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbl_Name2);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.lbl_CurrentMoney);
            this.panel1.Controls.Add(this.lbl_InitialMoney);
            this.panel1.Controls.Add(this.lbl_Name1);
            this.panel1.Controls.Add(this.nrc_DogNum);
            this.panel1.Controls.Add(this.lbl_BucksTxt);
            this.panel1.Controls.Add(this.nrc_Bucks);
            this.panel1.Controls.Add(this.btn_Bet);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Apostadores);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 165);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(6, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(469, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Start Race nº 1 !";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Name2
            // 
            this.lbl_Name2.AutoSize = true;
            this.lbl_Name2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name2.Location = new System.Drawing.Point(133, 100);
            this.lbl_Name2.Name = "lbl_Name2";
            this.lbl_Name2.Size = new System.Drawing.Size(31, 17);
            this.lbl_Name2.TabIndex = 17;
            this.lbl_Name2.Text = "Joe";
            this.lbl_Name2.Click += new System.EventHandler(this.label12_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Controls.Add(this.lbl_JoeBet);
            this.flowLayoutPanel2.Controls.Add(this.lbl_BobBet);
            this.flowLayoutPanel2.Controls.Add(this.lbl_AlBet);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(313, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(167, 68);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // lbl_JoeBet
            // 
            this.lbl_JoeBet.AutoSize = true;
            this.lbl_JoeBet.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JoeBet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_JoeBet.Location = new System.Drawing.Point(10, 0);
            this.lbl_JoeBet.Name = "lbl_JoeBet";
            this.lbl_JoeBet.Size = new System.Drawing.Size(150, 20);
            this.lbl_JoeBet.TabIndex = 13;
            this.lbl_JoeBet.Text = "Les Fous are the guys!";
            this.lbl_JoeBet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_JoeBet.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbl_BobBet
            // 
            this.lbl_BobBet.AutoSize = true;
            this.lbl_BobBet.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BobBet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_BobBet.Location = new System.Drawing.Point(73, 20);
            this.lbl_BobBet.Name = "lbl_BobBet";
            this.lbl_BobBet.Size = new System.Drawing.Size(87, 20);
            this.lbl_BobBet.TabIndex = 14;
            this.lbl_BobBet.Text = "Max Bet: $15";
            this.lbl_BobBet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_BobBet.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbl_AlBet
            // 
            this.lbl_AlBet.AutoSize = true;
            this.lbl_AlBet.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlBet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_AlBet.Location = new System.Drawing.Point(82, 40);
            this.lbl_AlBet.Name = "lbl_AlBet";
            this.lbl_AlBet.Size = new System.Drawing.Size(78, 20);
            this.lbl_AlBet.TabIndex = 15;
            this.lbl_AlBet.Text = "Min Bet: $5";
            this.lbl_AlBet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_CurrentMoney
            // 
            this.lbl_CurrentMoney.AutoSize = true;
            this.lbl_CurrentMoney.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_CurrentMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_CurrentMoney.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentMoney.Location = new System.Drawing.Point(250, 69);
            this.lbl_CurrentMoney.Name = "lbl_CurrentMoney";
            this.lbl_CurrentMoney.Size = new System.Drawing.Size(42, 19);
            this.lbl_CurrentMoney.TabIndex = 12;
            this.lbl_CurrentMoney.Text = "100$";
            // 
            // lbl_InitialMoney
            // 
            this.lbl_InitialMoney.AutoSize = true;
            this.lbl_InitialMoney.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_InitialMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_InitialMoney.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InitialMoney.Location = new System.Drawing.Point(250, 39);
            this.lbl_InitialMoney.Name = "lbl_InitialMoney";
            this.lbl_InitialMoney.Size = new System.Drawing.Size(42, 19);
            this.lbl_InitialMoney.TabIndex = 11;
            this.lbl_InitialMoney.Text = "100$";
            // 
            // lbl_Name1
            // 
            this.lbl_Name1.AutoSize = true;
            this.lbl_Name1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Name1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Name1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name1.Location = new System.Drawing.Point(250, 9);
            this.lbl_Name1.Name = "lbl_Name1";
            this.lbl_Name1.Size = new System.Drawing.Size(33, 19);
            this.lbl_Name1.TabIndex = 10;
            this.lbl_Name1.Text = "Joe";
            this.lbl_Name1.Click += new System.EventHandler(this.label6_Click);
            // 
            // nrc_DogNum
            // 
            this.nrc_DogNum.Location = new System.Drawing.Point(417, 98);
            this.nrc_DogNum.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nrc_DogNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrc_DogNum.Name = "nrc_DogNum";
            this.nrc_DogNum.Size = new System.Drawing.Size(38, 20);
            this.nrc_DogNum.TabIndex = 9;
            this.nrc_DogNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_BucksTxt
            // 
            this.lbl_BucksTxt.AutoSize = true;
            this.lbl_BucksTxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BucksTxt.Location = new System.Drawing.Point(296, 100);
            this.lbl_BucksTxt.Name = "lbl_BucksTxt";
            this.lbl_BucksTxt.Size = new System.Drawing.Size(114, 17);
            this.lbl_BucksTxt.TabIndex = 8;
            this.lbl_BucksTxt.Text = "Bucks on dog nº";
            this.lbl_BucksTxt.Click += new System.EventHandler(this.label5_Click);
            // 
            // nrc_Bucks
            // 
            this.nrc_Bucks.Location = new System.Drawing.Point(251, 98);
            this.nrc_Bucks.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nrc_Bucks.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nrc_Bucks.Name = "nrc_Bucks";
            this.nrc_Bucks.Size = new System.Drawing.Size(38, 20);
            this.nrc_Bucks.TabIndex = 7;
            this.nrc_Bucks.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_Bet
            // 
            this.btn_Bet.Location = new System.Drawing.Point(171, 95);
            this.btn_Bet.Name = "btn_Bet";
            this.btn_Bet.Size = new System.Drawing.Size(73, 27);
            this.btn_Bet.TabIndex = 6;
            this.btn_Bet.Text = "Bets";
            this.btn_Bet.UseVisualStyleBackColor = true;
            this.btn_Bet.Click += new System.EventHandler(this.btn_Bet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bets";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(122, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Money:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(141, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Initial Money:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(194, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Apostadores
            // 
            this.lbl_Apostadores.AutoSize = true;
            this.lbl_Apostadores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apostadores.Location = new System.Drawing.Point(7, 4);
            this.lbl_Apostadores.Name = "lbl_Apostadores";
            this.lbl_Apostadores.Size = new System.Drawing.Size(80, 18);
            this.lbl_Apostadores.TabIndex = 1;
            this.lbl_Apostadores.Text = "Les Fous";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.btn_Joe);
            this.flowLayoutPanel1.Controls.Add(this.btn_Bob);
            this.flowLayoutPanel1.Controls.Add(this.btn_Al);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(112, 94);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btn_Joe
            // 
            this.btn_Joe.AutoSize = true;
            this.btn_Joe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Joe.Location = new System.Drawing.Point(3, 3);
            this.btn_Joe.Name = "btn_Joe";
            this.btn_Joe.Size = new System.Drawing.Size(50, 24);
            this.btn_Joe.TabIndex = 0;
            this.btn_Joe.TabStop = true;
            this.btn_Joe.Text = "Joe";
            this.btn_Joe.UseVisualStyleBackColor = true;
            this.btn_Joe.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_Bob
            // 
            this.btn_Bob.AutoSize = true;
            this.btn_Bob.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bob.Location = new System.Drawing.Point(3, 33);
            this.btn_Bob.Name = "btn_Bob";
            this.btn_Bob.Size = new System.Drawing.Size(52, 24);
            this.btn_Bob.TabIndex = 1;
            this.btn_Bob.TabStop = true;
            this.btn_Bob.Text = "Bob";
            this.btn_Bob.UseVisualStyleBackColor = true;
            this.btn_Bob.CheckedChanged += new System.EventHandler(this.btn_Bob_CheckedChanged);
            // 
            // btn_Al
            // 
            this.btn_Al.AutoSize = true;
            this.btn_Al.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Al.Location = new System.Drawing.Point(3, 63);
            this.btn_Al.Name = "btn_Al";
            this.btn_Al.Size = new System.Drawing.Size(39, 24);
            this.btn_Al.TabIndex = 2;
            this.btn_Al.TabStop = true;
            this.btn_Al.Text = "Al";
            this.btn_Al.UseVisualStyleBackColor = true;
            this.btn_Al.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(25, 358);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(464, 24);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            this.progressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(508, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_Dog4);
            this.Controls.Add(this.img_Dog3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.img_Dog2);
            this.Controls.Add(this.img_Dog1);
            this.Controls.Add(this.img_RacingLine);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Apostadog";
            ((System.ComponentModel.ISupportInitialize)(this.img_RacingLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dog4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrc_DogNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrc_Bucks)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_RacingLine;
        private System.Windows.Forms.PictureBox img_Dog1;
        private System.Windows.Forms.PictureBox img_Dog2;
        private System.Windows.Forms.PictureBox img_Dog3;
        private System.Windows.Forms.PictureBox img_Dog4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton btn_Joe;
        private System.Windows.Forms.Label lbl_Apostadores;
        private System.Windows.Forms.RadioButton btn_Bob;
        private System.Windows.Forms.RadioButton btn_Al;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_BucksTxt;
        private System.Windows.Forms.NumericUpDown nrc_Bucks;
        private System.Windows.Forms.Button btn_Bet;
        private System.Windows.Forms.NumericUpDown nrc_DogNum;
        private System.Windows.Forms.Label lbl_Name1;
        private System.Windows.Forms.Label lbl_CurrentMoney;
        private System.Windows.Forms.Label lbl_InitialMoney;
        private System.Windows.Forms.Label lbl_JoeBet;
        private System.Windows.Forms.Label lbl_BobBet;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lbl_AlBet;
        private System.Windows.Forms.Label lbl_Name2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
    }
}

