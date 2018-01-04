namespace Silent_Miner_Builder
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pool = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.threads = new System.Windows.Forms.NumericUpDown();
            this.algo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.startup = new System.Windows.Forms.CheckBox();
            this.obfuscator = new System.Windows.Forms.CheckBox();
            this.silentmode = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.proxyprotocole = new System.Windows.Forms.ComboBox();
            this.proxyhost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threads)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pool
            // 
            this.pool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pool.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pool.ForeColor = System.Drawing.SystemColors.Window;
            this.pool.Location = new System.Drawing.Point(3, 110);
            this.pool.Name = "pool";
            this.pool.Size = new System.Drawing.Size(394, 22);
            this.pool.TabIndex = 0;
            this.pool.Text = "POOL : HOST:PORT";
            this.pool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Silent_Miner_Builder.Properties.Resources.xCryptocurrency_logo_1845x580;
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user.ForeColor = System.Drawing.SystemColors.Window;
            this.user.Location = new System.Drawing.Point(3, 138);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(394, 22);
            this.user.TabIndex = 2;
            this.user.Text = "User : WALLET";
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.ForeColor = System.Drawing.SystemColors.Window;
            this.password.Location = new System.Drawing.Point(3, 166);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(394, 22);
            this.password.TabIndex = 3;
            this.password.Text = "Password : ( x or empty)";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Build";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // threads
            // 
            this.threads.Location = new System.Drawing.Point(6, 21);
            this.threads.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.threads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(44, 22);
            this.threads.TabIndex = 8;
            this.threads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // algo
            // 
            this.algo.BackColor = System.Drawing.SystemColors.Window;
            this.algo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algo.FormattingEnabled = true;
            this.algo.Items.AddRange(new object[] {
            "cryptonight",
            "scrypt",
            "sha256d",
            "keccak",
            "quark",
            "heavy",
            "skein",
            "shavite3",
            "blake",
            "x11"});
            this.algo.Location = new System.Drawing.Point(12, 21);
            this.algo.Name = "algo";
            this.algo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.algo.Size = new System.Drawing.Size(93, 22);
            this.algo.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.threads);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(39, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(62, 53);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threads";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.algo);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(107, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 53);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algorithm";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button2.Location = new System.Drawing.Point(8, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 20);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button3.Location = new System.Drawing.Point(54, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 20);
            this.button3.TabIndex = 15;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 49);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profiles";
            // 
            // startup
            // 
            this.startup.AutoSize = true;
            this.startup.ForeColor = System.Drawing.Color.White;
            this.startup.Location = new System.Drawing.Point(237, 236);
            this.startup.Name = "startup";
            this.startup.Size = new System.Drawing.Size(129, 18);
            this.startup.TabIndex = 15;
            this.startup.Text = "Startup + Persistence";
            this.startup.UseVisualStyleBackColor = true;
            // 
            // obfuscator
            // 
            this.obfuscator.AutoSize = true;
            this.obfuscator.ForeColor = System.Drawing.Color.White;
            this.obfuscator.Location = new System.Drawing.Point(237, 215);
            this.obfuscator.Name = "obfuscator";
            this.obfuscator.Size = new System.Drawing.Size(136, 18);
            this.obfuscator.TabIndex = 16;
            this.obfuscator.Text = "Obfuscate + Compress";
            this.obfuscator.UseVisualStyleBackColor = true;
            // 
            // silentmode
            // 
            this.silentmode.AutoSize = true;
            this.silentmode.ForeColor = System.Drawing.Color.White;
            this.silentmode.Location = new System.Drawing.Point(237, 260);
            this.silentmode.Name = "silentmode";
            this.silentmode.Size = new System.Drawing.Size(85, 18);
            this.silentmode.TabIndex = 17;
            this.silentmode.Text = "Silent Mode";
            this.silentmode.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.proxyhost);
            this.groupBox4.Controls.Add(this.proxyprotocole);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(114, 293);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 49);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proxy settings";
            // 
            // proxyprotocole
            // 
            this.proxyprotocole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proxyprotocole.FormattingEnabled = true;
            this.proxyprotocole.Items.AddRange(new object[] {
            "http",
            "https"});
            this.proxyprotocole.Location = new System.Drawing.Point(6, 19);
            this.proxyprotocole.Name = "proxyprotocole";
            this.proxyprotocole.Size = new System.Drawing.Size(58, 22);
            this.proxyprotocole.TabIndex = 0;
            // 
            // proxyhost
            // 
            this.proxyhost.Location = new System.Drawing.Point(70, 19);
            this.proxyhost.Name = "proxyhost";
            this.proxyhost.Size = new System.Drawing.Size(132, 22);
            this.proxyhost.TabIndex = 1;
            this.proxyhost.Text = "IP:PORT";
            this.proxyhost.TextChanged += new System.EventHandler(this.proxyhost_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(399, 345);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.silentmode);
            this.Controls.Add(this.obfuscator);
            this.Controls.Add(this.startup);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pool);
            this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU Crypto Miner | By Artist ";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threads)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pool;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown threads;
        private System.Windows.Forms.ComboBox algo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox startup;
        private System.Windows.Forms.CheckBox obfuscator;
        private System.Windows.Forms.CheckBox silentmode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox proxyhost;
        private System.Windows.Forms.ComboBox proxyprotocole;
    }
}

