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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_leftScore = new System.Windows.Forms.Label();
            this.lbl_scoreRight = new System.Windows.Forms.Label();
            this.lbl_matchId = new System.Windows.Forms.Label();
            this.btn_setNull = new System.Windows.Forms.Button();
            this.nud_leftScore = new System.Windows.Forms.NumericUpDown();
            this.nud_rightScore = new System.Windows.Forms.NumericUpDown();
            this.nud_matchId = new System.Windows.Forms.NumericUpDown();
            this.btn_setScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_leftScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rightScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_matchId)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(69, 220);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(137, 27);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "refresh resources";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_leftScore
            // 
            this.lbl_leftScore.AutoSize = true;
            this.lbl_leftScore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leftScore.Location = new System.Drawing.Point(41, 13);
            this.lbl_leftScore.Name = "lbl_leftScore";
            this.lbl_leftScore.Size = new System.Drawing.Size(70, 19);
            this.lbl_leftScore.TabIndex = 4;
            this.lbl_leftScore.Text = "score left";
            // 
            // lbl_scoreRight
            // 
            this.lbl_scoreRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_scoreRight.AutoSize = true;
            this.lbl_scoreRight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreRight.Location = new System.Drawing.Point(173, 13);
            this.lbl_scoreRight.Name = "lbl_scoreRight";
            this.lbl_scoreRight.Size = new System.Drawing.Size(78, 19);
            this.lbl_scoreRight.TabIndex = 5;
            this.lbl_scoreRight.Text = "score right";
            // 
            // lbl_matchId
            // 
            this.lbl_matchId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_matchId.AutoSize = true;
            this.lbl_matchId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matchId.Location = new System.Drawing.Point(108, 139);
            this.lbl_matchId.Name = "lbl_matchId";
            this.lbl_matchId.Size = new System.Drawing.Size(68, 19);
            this.lbl_matchId.TabIndex = 6;
            this.lbl_matchId.Text = "match-ID";
            // 
            // btn_setNull
            // 
            this.btn_setNull.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_setNull.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setNull.Location = new System.Drawing.Point(104, 187);
            this.btn_setNull.Name = "btn_setNull";
            this.btn_setNull.Size = new System.Drawing.Size(75, 27);
            this.btn_setNull.TabIndex = 7;
            this.btn_setNull.Text = "set zero";
            this.btn_setNull.UseVisualStyleBackColor = true;
            this.btn_setNull.Click += new System.EventHandler(this.btn_setNull_Click);
            // 
            // nud_leftScore
            // 
            this.nud_leftScore.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_leftScore.Location = new System.Drawing.Point(12, 35);
            this.nud_leftScore.Name = "nud_leftScore";
            this.nud_leftScore.Size = new System.Drawing.Size(114, 86);
            this.nud_leftScore.TabIndex = 8;
            this.nud_leftScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_leftScore.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud_leftScore.ValueChanged += new System.EventHandler(this.nud_leftScore_ValueChanged);
            // 
            // nud_rightScore
            // 
            this.nud_rightScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_rightScore.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_rightScore.Location = new System.Drawing.Point(158, 35);
            this.nud_rightScore.Name = "nud_rightScore";
            this.nud_rightScore.Size = new System.Drawing.Size(120, 86);
            this.nud_rightScore.TabIndex = 9;
            this.nud_rightScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_rightScore.ValueChanged += new System.EventHandler(this.nud_rightScore_ValueChanged);
            // 
            // nud_matchId
            // 
            this.nud_matchId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nud_matchId.Location = new System.Drawing.Point(86, 161);
            this.nud_matchId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_matchId.Name = "nud_matchId";
            this.nud_matchId.Size = new System.Drawing.Size(120, 20);
            this.nud_matchId.TabIndex = 10;
            this.nud_matchId.ValueChanged += new System.EventHandler(this.nud_matchId_ValueChanged);
            this.nud_matchId.Leave += new System.EventHandler(this.nud_matchId_ValueChanged);
            // 
            // btn_setScore
            // 
            this.btn_setScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_setScore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setScore.Location = new System.Drawing.Point(92, 254);
            this.btn_setScore.Name = "btn_setScore";
            this.btn_setScore.Size = new System.Drawing.Size(93, 29);
            this.btn_setScore.TabIndex = 11;
            this.btn_setScore.Text = "set score";
            this.btn_setScore.UseVisualStyleBackColor = true;
            this.btn_setScore.Click += new System.EventHandler(this.btn_setScore_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HeroesLoungeMatchHandler.Properties.Resources.heroes_lounge_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(304, 311);
            this.Controls.Add(this.btn_setScore);
            this.Controls.Add(this.nud_matchId);
            this.Controls.Add(this.nud_rightScore);
            this.Controls.Add(this.nud_leftScore);
            this.Controls.Add(this.btn_setNull);
            this.Controls.Add(this.lbl_matchId);
            this.Controls.Add(this.lbl_scoreRight);
            this.Controls.Add(this.lbl_leftScore);
            this.Controls.Add(this.btn_refresh);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "Main";
            this.Text = "HeroesLoungeMatchHandler";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_leftScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rightScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_matchId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_leftScore;
        private System.Windows.Forms.Label lbl_scoreRight;
        private System.Windows.Forms.Label lbl_matchId;
        private System.Windows.Forms.Button btn_setNull;
        private System.Windows.Forms.NumericUpDown nud_leftScore;
        private System.Windows.Forms.NumericUpDown nud_rightScore;
        private System.Windows.Forms.NumericUpDown nud_matchId;
        private System.Windows.Forms.Button btn_setScore;
    }
}

