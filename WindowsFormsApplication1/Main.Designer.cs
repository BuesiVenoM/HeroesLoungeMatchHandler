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
            this.btn_switch = new System.Windows.Forms.Button();
            this.btn_writeSouces = new System.Windows.Forms.Button();
            this.nud_matchId = new System.Windows.Forms.NumericUpDown();
            this.nud_rightScore = new System.Windows.Forms.NumericUpDown();
            this.nud_leftScore = new System.Windows.Forms.NumericUpDown();
            this.btn_setNull = new System.Windows.Forms.Button();
            this.lbl_matchId = new System.Windows.Forms.Label();
            this.lbl_scoreRight = new System.Windows.Forms.Label();
            this.lbl_leftScore = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tb_page2 = new System.Windows.Forms.TabPage();
            this.btn_createTeamStatistics = new System.Windows.Forms.Button();
            this.tb_ctrl1.SuspendLayout();
            this.tb_page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_matchId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rightScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_leftScore)).BeginInit();
            this.tb_page2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ctrl1
            // 
            this.tb_ctrl1.Controls.Add(this.tb_page1);
            this.tb_ctrl1.Controls.Add(this.tb_page2);
            this.tb_ctrl1.Location = new System.Drawing.Point(13, 13);
            this.tb_ctrl1.Name = "tb_ctrl1";
            this.tb_ctrl1.SelectedIndex = 0;
            this.tb_ctrl1.Size = new System.Drawing.Size(583, 604);
            this.tb_ctrl1.TabIndex = 0;
            // 
            // tb_page1
            // 
            this.tb_page1.Controls.Add(this.btn_switch);
            this.tb_page1.Controls.Add(this.btn_writeSouces);
            this.tb_page1.Controls.Add(this.nud_matchId);
            this.tb_page1.Controls.Add(this.nud_rightScore);
            this.tb_page1.Controls.Add(this.nud_leftScore);
            this.tb_page1.Controls.Add(this.btn_setNull);
            this.tb_page1.Controls.Add(this.lbl_matchId);
            this.tb_page1.Controls.Add(this.lbl_scoreRight);
            this.tb_page1.Controls.Add(this.lbl_leftScore);
            this.tb_page1.Controls.Add(this.btn_refresh);
            this.tb_page1.Location = new System.Drawing.Point(8, 39);
            this.tb_page1.Name = "tb_page1";
            this.tb_page1.Padding = new System.Windows.Forms.Padding(3);
            this.tb_page1.Size = new System.Drawing.Size(567, 557);
            this.tb_page1.TabIndex = 0;
            this.tb_page1.Text = "Casters";
            this.tb_page1.UseVisualStyleBackColor = true;
            // 
            // btn_switch
            // 
            this.btn_switch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_switch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_switch.Location = new System.Drawing.Point(275, 335);
            this.btn_switch.Margin = new System.Windows.Forms.Padding(6);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(188, 52);
            this.btn_switch.TabIndex = 22;
            this.btn_switch.Text = "switch sides";
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
            // 
            // btn_writeSouces
            // 
            this.btn_writeSouces.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_writeSouces.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_writeSouces.Location = new System.Drawing.Point(154, 463);
            this.btn_writeSouces.Margin = new System.Windows.Forms.Padding(6);
            this.btn_writeSouces.Name = "btn_writeSouces";
            this.btn_writeSouces.Size = new System.Drawing.Size(228, 56);
            this.btn_writeSouces.TabIndex = 21;
            this.btn_writeSouces.Text = "write sources";
            this.btn_writeSouces.UseVisualStyleBackColor = true;
            this.btn_writeSouces.Click += new System.EventHandler(this.btn_writeSources_Click);
            // 
            // nud_matchId
            // 
            this.nud_matchId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nud_matchId.Location = new System.Drawing.Point(164, 286);
            this.nud_matchId.Margin = new System.Windows.Forms.Padding(6);
            this.nud_matchId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_matchId.Name = "nud_matchId";
            this.nud_matchId.Size = new System.Drawing.Size(240, 31);
            this.nud_matchId.TabIndex = 20;
            this.nud_matchId.ValueChanged += new System.EventHandler(this.nud_matchId_ValueChanged);
            // 
            // nud_rightScore
            // 
            this.nud_rightScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_rightScore.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_rightScore.Location = new System.Drawing.Point(309, 46);
            this.nud_rightScore.Margin = new System.Windows.Forms.Padding(6);
            this.nud_rightScore.Name = "nud_rightScore";
            this.nud_rightScore.Size = new System.Drawing.Size(240, 164);
            this.nud_rightScore.TabIndex = 19;
            this.nud_rightScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_rightScore.ValueChanged += new System.EventHandler(this.nud_rightScore_ValueChanged);
            // 
            // nud_leftScore
            // 
            this.nud_leftScore.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_leftScore.Location = new System.Drawing.Point(17, 46);
            this.nud_leftScore.Margin = new System.Windows.Forms.Padding(6);
            this.nud_leftScore.Name = "nud_leftScore";
            this.nud_leftScore.Size = new System.Drawing.Size(228, 164);
            this.nud_leftScore.TabIndex = 18;
            this.nud_leftScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_leftScore.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud_leftScore.ValueChanged += new System.EventHandler(this.nud_leftScore_ValueChanged);
            // 
            // btn_setNull
            // 
            this.btn_setNull.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_setNull.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setNull.Location = new System.Drawing.Point(81, 335);
            this.btn_setNull.Margin = new System.Windows.Forms.Padding(6);
            this.btn_setNull.Name = "btn_setNull";
            this.btn_setNull.Size = new System.Drawing.Size(178, 52);
            this.btn_setNull.TabIndex = 17;
            this.btn_setNull.Text = "set zero";
            this.btn_setNull.UseVisualStyleBackColor = true;
            this.btn_setNull.Click += new System.EventHandler(this.btn_setNull_Click);
            // 
            // lbl_matchId
            // 
            this.lbl_matchId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_matchId.AutoSize = true;
            this.lbl_matchId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matchId.Location = new System.Drawing.Point(208, 243);
            this.lbl_matchId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_matchId.Name = "lbl_matchId";
            this.lbl_matchId.Size = new System.Drawing.Size(138, 39);
            this.lbl_matchId.TabIndex = 16;
            this.lbl_matchId.Text = "match-ID";
            // 
            // lbl_scoreRight
            // 
            this.lbl_scoreRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_scoreRight.AutoSize = true;
            this.lbl_scoreRight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreRight.Location = new System.Drawing.Point(339, 4);
            this.lbl_scoreRight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_scoreRight.Name = "lbl_scoreRight";
            this.lbl_scoreRight.Size = new System.Drawing.Size(156, 39);
            this.lbl_scoreRight.TabIndex = 15;
            this.lbl_scoreRight.Text = "score right";
            // 
            // lbl_leftScore
            // 
            this.lbl_leftScore.AutoSize = true;
            this.lbl_leftScore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leftScore.Location = new System.Drawing.Point(75, 4);
            this.lbl_leftScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_leftScore.Name = "lbl_leftScore";
            this.lbl_leftScore.Size = new System.Drawing.Size(138, 39);
            this.lbl_leftScore.TabIndex = 14;
            this.lbl_leftScore.Text = "score left";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(130, 399);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(6);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(274, 52);
            this.btn_refresh.TabIndex = 13;
            this.btn_refresh.Text = "initiate resources";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // tb_page2
            // 
            this.tb_page2.Controls.Add(this.btn_createTeamStatistics);
            this.tb_page2.Location = new System.Drawing.Point(8, 39);
            this.tb_page2.Name = "tb_page2";
            this.tb_page2.Padding = new System.Windows.Forms.Padding(3);
            this.tb_page2.Size = new System.Drawing.Size(567, 557);
            this.tb_page2.TabIndex = 1;
            this.tb_page2.Text = "Statistics";
            this.tb_page2.UseVisualStyleBackColor = true;
            // 
            // btn_createTeamStatistics
            // 
            this.btn_createTeamStatistics.Location = new System.Drawing.Point(19, 17);
            this.btn_createTeamStatistics.Name = "btn_createTeamStatistics";
            this.btn_createTeamStatistics.Size = new System.Drawing.Size(222, 65);
            this.btn_createTeamStatistics.TabIndex = 0;
            this.btn_createTeamStatistics.Text = "team statistics";
            this.btn_createTeamStatistics.UseVisualStyleBackColor = true;
            this.btn_createTeamStatistics.Click += new System.EventHandler(this.btn_createTeamStatistics_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HeroesLoungeMatchHandler.Properties.Resources.heroes_lounge_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(608, 629);
            this.Controls.Add(this.tb_ctrl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(574, 608);
            this.Name = "Main";
            this.Text = "HeroesLoungeMatchHandler";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tb_ctrl1.ResumeLayout(false);
            this.tb_page1.ResumeLayout(false);
            this.tb_page1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_matchId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rightScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_leftScore)).EndInit();
            this.tb_page2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_createTeamStatistics;
    }
}

