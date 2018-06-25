namespace WindowsFormsApplication1
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tb_ctrl1 = new System.Windows.Forms.TabControl();
            this.tb_page1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nud_leftScore = new System.Windows.Forms.NumericUpDown();
            this.lbl_scoreRight = new System.Windows.Forms.Label();
            this.nud_rightScore = new System.Windows.Forms.NumericUpDown();
            this.lbl_matchId = new System.Windows.Forms.Label();
            this.lbl_leftScore = new System.Windows.Forms.Label();
            this.nud_matchId = new System.Windows.Forms.NumericUpDown();
            this.btn_setNull = new System.Windows.Forms.Button();
            this.btn_writeSouces = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_switch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_page2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_stat_teamRight = new System.Windows.Forms.Label();
            this.webBrowser_teamLeft = new System.Windows.Forms.WebBrowser();
            this.webBrowser_teamRight = new System.Windows.Forms.WebBrowser();
            this.webBrowser_div = new System.Windows.Forms.WebBrowser();
            this.lbl_stat_teamLeft = new System.Windows.Forms.Label();
            this.btn_printCasterHelpSheet = new System.Windows.Forms.Button();
            this.tb_ctrl1.SuspendLayout();
            this.tb_page1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_leftScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rightScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_matchId)).BeginInit();
            this.tb_page2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ctrl1
            // 
            this.tb_ctrl1.Controls.Add(this.tb_page1);
            this.tb_ctrl1.Controls.Add(this.tb_page2);
            this.tb_ctrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ctrl1.Location = new System.Drawing.Point(0, 0);
            this.tb_ctrl1.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ctrl1.Name = "tb_ctrl1";
            this.tb_ctrl1.SelectedIndex = 0;
            this.tb_ctrl1.Size = new System.Drawing.Size(1144, 650);
            this.tb_ctrl1.TabIndex = 0;
            // 
            // tb_page1
            // 
            this.tb_page1.Controls.Add(this.tableLayoutPanel2);
            this.tb_page1.Location = new System.Drawing.Point(4, 22);
            this.tb_page1.Margin = new System.Windows.Forms.Padding(2);
            this.tb_page1.Name = "tb_page1";
            this.tb_page1.Padding = new System.Windows.Forms.Padding(2);
            this.tb_page1.Size = new System.Drawing.Size(1136, 624);
            this.tb_page1.TabIndex = 0;
            this.tb_page1.Text = "Casters";
            this.tb_page1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.32076F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.67924F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 756F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.Controls.Add(this.nud_leftScore, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_scoreRight, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nud_rightScore, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_matchId, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_leftScore, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nud_matchId, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_setNull, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn_writeSouces, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn_refresh, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_switch, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn_printCasterHelpSheet, 2, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.46939F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.53061F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 303F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1128, 611);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // nud_leftScore
            // 
            this.nud_leftScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_leftScore.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_leftScore.Location = new System.Drawing.Point(3, 31);
            this.nud_leftScore.Name = "nud_leftScore";
            this.nud_leftScore.Size = new System.Drawing.Size(133, 86);
            this.nud_leftScore.TabIndex = 18;
            this.nud_leftScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_leftScore.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud_leftScore.ValueChanged += new System.EventHandler(this.nud_leftScore_ValueChanged);
            // 
            // lbl_scoreRight
            // 
            this.lbl_scoreRight.AutoSize = true;
            this.lbl_scoreRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_scoreRight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreRight.Location = new System.Drawing.Point(142, 0);
            this.lbl_scoreRight.Name = "lbl_scoreRight";
            this.lbl_scoreRight.Size = new System.Drawing.Size(125, 28);
            this.lbl_scoreRight.TabIndex = 15;
            this.lbl_scoreRight.Text = "score right";
            this.lbl_scoreRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud_rightScore
            // 
            this.nud_rightScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_rightScore.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_rightScore.Location = new System.Drawing.Point(142, 31);
            this.nud_rightScore.Name = "nud_rightScore";
            this.nud_rightScore.Size = new System.Drawing.Size(125, 86);
            this.nud_rightScore.TabIndex = 19;
            this.nud_rightScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_rightScore.ValueChanged += new System.EventHandler(this.nud_rightScore_ValueChanged);
            // 
            // lbl_matchId
            // 
            this.lbl_matchId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_matchId.AutoSize = true;
            this.lbl_matchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matchId.Location = new System.Drawing.Point(3, 121);
            this.lbl_matchId.Name = "lbl_matchId";
            this.lbl_matchId.Size = new System.Drawing.Size(133, 28);
            this.lbl_matchId.TabIndex = 16;
            this.lbl_matchId.Text = "match-ID";
            this.lbl_matchId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_leftScore
            // 
            this.lbl_leftScore.AutoSize = true;
            this.lbl_leftScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_leftScore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leftScore.Location = new System.Drawing.Point(3, 0);
            this.lbl_leftScore.Name = "lbl_leftScore";
            this.lbl_leftScore.Size = new System.Drawing.Size(133, 28);
            this.lbl_leftScore.TabIndex = 14;
            this.lbl_leftScore.Text = "score left";
            this.lbl_leftScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud_matchId
            // 
            this.nud_matchId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_matchId.Location = new System.Drawing.Point(142, 124);
            this.nud_matchId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_matchId.Name = "nud_matchId";
            this.nud_matchId.Size = new System.Drawing.Size(125, 20);
            this.nud_matchId.TabIndex = 20;
            this.nud_matchId.ValueChanged += new System.EventHandler(this.nud_matchId_ValueChanged);
            // 
            // btn_setNull
            // 
            this.btn_setNull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_setNull.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setNull.Location = new System.Drawing.Point(3, 268);
            this.btn_setNull.Name = "btn_setNull";
            this.btn_setNull.Size = new System.Drawing.Size(133, 36);
            this.btn_setNull.TabIndex = 17;
            this.btn_setNull.Text = "set zero";
            this.btn_setNull.UseVisualStyleBackColor = true;
            this.btn_setNull.Click += new System.EventHandler(this.btn_setNull_Click);
            // 
            // btn_writeSouces
            // 
            this.btn_writeSouces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_writeSouces.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_writeSouces.Location = new System.Drawing.Point(142, 268);
            this.btn_writeSouces.Name = "btn_writeSouces";
            this.btn_writeSouces.Size = new System.Drawing.Size(125, 36);
            this.btn_writeSouces.TabIndex = 21;
            this.btn_writeSouces.Text = "write sources";
            this.btn_writeSouces.UseVisualStyleBackColor = true;
            this.btn_writeSouces.Click += new System.EventHandler(this.btn_writeSources_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(3, 184);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(133, 43);
            this.btn_refresh.TabIndex = 13;
            this.btn_refresh.Text = "initiate resources";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_switch
            // 
            this.btn_switch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_switch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_switch.Location = new System.Drawing.Point(142, 184);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(125, 43);
            this.btn_switch.TabIndex = 22;
            this.btn_switch.Text = "switch sides";
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "first initialisation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "switch sides";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 35);
            this.label6.TabIndex = 25;
            this.label6.Text = "reset scores\r\n(needs write)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 35);
            this.label7.TabIndex = 26;
            this.label7.Text = "write scores";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_page2
            // 
            this.tb_page2.Controls.Add(this.tableLayoutPanel1);
            this.tb_page2.Location = new System.Drawing.Point(4, 22);
            this.tb_page2.Margin = new System.Windows.Forms.Padding(2);
            this.tb_page2.Name = "tb_page2";
            this.tb_page2.Padding = new System.Windows.Forms.Padding(2);
            this.tb_page2.Size = new System.Drawing.Size(1136, 624);
            this.tb_page2.TabIndex = 1;
            this.tb_page2.Text = "Statistics";
            this.tb_page2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_stat_teamRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser_teamLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser_teamRight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser_div, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_stat_teamLeft, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.193548F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.80645F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1132, 620);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(875, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "division overview";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_stat_teamRight
            // 
            this.lbl_stat_teamRight.AutoSize = true;
            this.lbl_stat_teamRight.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_stat_teamRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_stat_teamRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_stat_teamRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stat_teamRight.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_stat_teamRight.Location = new System.Drawing.Point(439, 7);
            this.lbl_stat_teamRight.Name = "lbl_stat_teamRight";
            this.lbl_stat_teamRight.Size = new System.Drawing.Size(430, 18);
            this.lbl_stat_teamRight.TabIndex = 6;
            this.lbl_stat_teamRight.Text = "team right";
            this.lbl_stat_teamRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webBrowser_teamLeft
            // 
            this.webBrowser_teamLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_teamLeft.Location = new System.Drawing.Point(3, 28);
            this.webBrowser_teamLeft.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_teamLeft.Name = "webBrowser_teamLeft";
            this.webBrowser_teamLeft.Size = new System.Drawing.Size(430, 589);
            this.webBrowser_teamLeft.TabIndex = 1;
            this.webBrowser_teamLeft.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_teamLeft_DocumentCompleted);
            // 
            // webBrowser_teamRight
            // 
            this.webBrowser_teamRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_teamRight.Location = new System.Drawing.Point(439, 28);
            this.webBrowser_teamRight.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_teamRight.Name = "webBrowser_teamRight";
            this.webBrowser_teamRight.Size = new System.Drawing.Size(430, 589);
            this.webBrowser_teamRight.TabIndex = 2;
            this.webBrowser_teamRight.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_teamRight_DocumentCompleted);
            // 
            // webBrowser_div
            // 
            this.webBrowser_div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_div.Location = new System.Drawing.Point(875, 28);
            this.webBrowser_div.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_div.Name = "webBrowser_div";
            this.webBrowser_div.Size = new System.Drawing.Size(254, 589);
            this.webBrowser_div.TabIndex = 4;
            this.webBrowser_div.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_div_DocumentCompleted);
            // 
            // lbl_stat_teamLeft
            // 
            this.lbl_stat_teamLeft.AutoSize = true;
            this.lbl_stat_teamLeft.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_stat_teamLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_stat_teamLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_stat_teamLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stat_teamLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_stat_teamLeft.Location = new System.Drawing.Point(3, 7);
            this.lbl_stat_teamLeft.Name = "lbl_stat_teamLeft";
            this.lbl_stat_teamLeft.Size = new System.Drawing.Size(430, 18);
            this.lbl_stat_teamLeft.TabIndex = 5;
            this.lbl_stat_teamLeft.Text = "team left";
            this.lbl_stat_teamLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_printCasterHelpSheet
            // 
            this.btn_printCasterHelpSheet.Location = new System.Drawing.Point(273, 310);
            this.btn_printCasterHelpSheet.Name = "btn_printCasterHelpSheet";
            this.btn_printCasterHelpSheet.Size = new System.Drawing.Size(260, 42);
            this.btn_printCasterHelpSheet.TabIndex = 27;
            this.btn_printCasterHelpSheet.Text = "generate caster help sheet";
            this.btn_printCasterHelpSheet.UseVisualStyleBackColor = true;
            this.btn_printCasterHelpSheet.Click += new System.EventHandler(this.btn_printCasterHelpSheet_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HeroesLoungeMatchHandler.Properties.Resources.heroes_lounge_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1144, 650);
            this.Controls.Add(this.tb_ctrl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(295, 335);
            this.Name = "Main";
            this.Text = "HeroesLoungeMatchHandler";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tb_ctrl1.ResumeLayout(false);
            this.tb_page1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_leftScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rightScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_matchId)).EndInit();
            this.tb_page2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_ctrl1;
        private System.Windows.Forms.TabPage tb_page1;
        private System.Windows.Forms.Button btn_switch;
        private System.Windows.Forms.Button btn_writeSouces;
        private System.Windows.Forms.NumericUpDown nud_matchId;
        private System.Windows.Forms.NumericUpDown nud_rightScore;
        private System.Windows.Forms.NumericUpDown nud_leftScore;
        private System.Windows.Forms.Button btn_setNull;
        private System.Windows.Forms.Label lbl_matchId;
        private System.Windows.Forms.Label lbl_scoreRight;
        private System.Windows.Forms.Label lbl_leftScore;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TabPage tb_page2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.WebBrowser webBrowser_teamLeft;
        private System.Windows.Forms.WebBrowser webBrowser_teamRight;
        private System.Windows.Forms.WebBrowser webBrowser_div;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_stat_teamRight;
        private System.Windows.Forms.Label lbl_stat_teamLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_printCasterHelpSheet;
    }
}

