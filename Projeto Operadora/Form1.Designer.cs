namespace Projeto_Operadora
{
    partial class Frm_Abertura
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
            this.Grp_Dadosrec = new System.Windows.Forms.GroupBox();
            this.Lbl_Caracteres = new System.Windows.Forms.Label();
            this.Txt_Ddd = new System.Windows.Forms.TextBox();
            this.Txt_RgS = new System.Windows.Forms.TextBox();
            this.Pic_operadoras = new System.Windows.Forms.PictureBox();
            this.Txt_Nm = new System.Windows.Forms.TextBox();
            this.Lbl_Ddd = new System.Windows.Forms.Label();
            this.Lbl_RgSl = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Grp_regiao = new System.Windows.Forms.GroupBox();
            this.Rad_Sp = new System.Windows.Forms.RadioButton();
            this.Rad_Rj = new System.Windows.Forms.RadioButton();
            this.Rad_Mg = new System.Windows.Forms.RadioButton();
            this.Rad_Es = new System.Windows.Forms.RadioButton();
            this.Pic_estado = new System.Windows.Forms.PictureBox();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Grp_Dadosrec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_operadoras)).BeginInit();
            this.Grp_regiao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_estado)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp_Dadosrec
            // 
            this.Grp_Dadosrec.Controls.Add(this.Lbl_Caracteres);
            this.Grp_Dadosrec.Controls.Add(this.Txt_Ddd);
            this.Grp_Dadosrec.Controls.Add(this.Txt_RgS);
            this.Grp_Dadosrec.Controls.Add(this.Pic_operadoras);
            this.Grp_Dadosrec.Controls.Add(this.Txt_Nm);
            this.Grp_Dadosrec.Controls.Add(this.Lbl_Ddd);
            this.Grp_Dadosrec.Controls.Add(this.Lbl_RgSl);
            this.Grp_Dadosrec.Controls.Add(this.Lbl_Nome);
            this.Grp_Dadosrec.Controls.Add(this.Grp_regiao);
            this.Grp_Dadosrec.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Dadosrec.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Grp_Dadosrec.Location = new System.Drawing.Point(12, 47);
            this.Grp_Dadosrec.Name = "Grp_Dadosrec";
            this.Grp_Dadosrec.Size = new System.Drawing.Size(1180, 656);
            this.Grp_Dadosrec.TabIndex = 0;
            this.Grp_Dadosrec.TabStop = false;
            this.Grp_Dadosrec.Text = "Dados de Recarga";
            // 
            // Lbl_Caracteres
            // 
            this.Lbl_Caracteres.AutoSize = true;
            this.Lbl_Caracteres.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Caracteres.Location = new System.Drawing.Point(234, 168);
            this.Lbl_Caracteres.Name = "Lbl_Caracteres";
            this.Lbl_Caracteres.Size = new System.Drawing.Size(211, 24);
            this.Lbl_Caracteres.TabIndex = 9;
            this.Lbl_Caracteres.Text = "No Mínimo 2 caracteres";
            // 
            // Txt_Ddd
            // 
            this.Txt_Ddd.Enabled = false;
            this.Txt_Ddd.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Ddd.Location = new System.Drawing.Point(1069, 579);
            this.Txt_Ddd.Name = "Txt_Ddd";
            this.Txt_Ddd.Size = new System.Drawing.Size(54, 33);
            this.Txt_Ddd.TabIndex = 8;
            // 
            // Txt_RgS
            // 
            this.Txt_RgS.Enabled = false;
            this.Txt_RgS.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RgS.Location = new System.Drawing.Point(711, 579);
            this.Txt_RgS.Name = "Txt_RgS";
            this.Txt_RgS.Size = new System.Drawing.Size(225, 33);
            this.Txt_RgS.TabIndex = 7;
            // 
            // Pic_operadoras
            // 
            this.Pic_operadoras.Image = global::Projeto_Operadora.Properties.Resources.operadoras;
            this.Pic_operadoras.Location = new System.Drawing.Point(36, 206);
            this.Pic_operadoras.Name = "Pic_operadoras";
            this.Pic_operadoras.Size = new System.Drawing.Size(429, 311);
            this.Pic_operadoras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_operadoras.TabIndex = 6;
            this.Pic_operadoras.TabStop = false;
            // 
            // Txt_Nm
            // 
            this.Txt_Nm.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nm.Location = new System.Drawing.Point(36, 125);
            this.Txt_Nm.MaxLength = 30;
            this.Txt_Nm.Name = "Txt_Nm";
            this.Txt_Nm.Size = new System.Drawing.Size(429, 33);
            this.Txt_Nm.TabIndex = 5;
            this.Txt_Nm.TextChanged += new System.EventHandler(this.Txt_Nm_TextChanged);
            this.Txt_Nm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nm_KeyPress);
            // 
            // Lbl_Ddd
            // 
            this.Lbl_Ddd.AutoSize = true;
            this.Lbl_Ddd.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ddd.Location = new System.Drawing.Point(976, 586);
            this.Lbl_Ddd.Name = "Lbl_Ddd";
            this.Lbl_Ddd.Size = new System.Drawing.Size(68, 26);
            this.Lbl_Ddd.TabIndex = 4;
            this.Lbl_Ddd.Text = "DDD :";
            // 
            // Lbl_RgSl
            // 
            this.Lbl_RgSl.AutoSize = true;
            this.Lbl_RgSl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RgSl.Location = new System.Drawing.Point(496, 582);
            this.Lbl_RgSl.Name = "Lbl_RgSl";
            this.Lbl_RgSl.Size = new System.Drawing.Size(209, 26);
            this.Lbl_RgSl.TabIndex = 3;
            this.Lbl_RgSl.Text = "Região Selecionada :";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.Location = new System.Drawing.Point(31, 82);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(89, 28);
            this.Lbl_Nome.TabIndex = 2;
            this.Lbl_Nome.Text = "Nome :";
            // 
            // Grp_regiao
            // 
            this.Grp_regiao.Controls.Add(this.Rad_Sp);
            this.Grp_regiao.Controls.Add(this.Rad_Rj);
            this.Grp_regiao.Controls.Add(this.Rad_Mg);
            this.Grp_regiao.Controls.Add(this.Rad_Es);
            this.Grp_regiao.Controls.Add(this.Pic_estado);
            this.Grp_regiao.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_regiao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Grp_regiao.Location = new System.Drawing.Point(501, 111);
            this.Grp_regiao.Name = "Grp_regiao";
            this.Grp_regiao.Size = new System.Drawing.Size(622, 420);
            this.Grp_regiao.TabIndex = 1;
            this.Grp_regiao.TabStop = false;
            this.Grp_regiao.Text = "Região Sudeste";
            // 
            // Rad_Sp
            // 
            this.Rad_Sp.AutoSize = true;
            this.Rad_Sp.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Sp.Location = new System.Drawing.Point(300, 267);
            this.Rad_Sp.Name = "Rad_Sp";
            this.Rad_Sp.Size = new System.Drawing.Size(135, 32);
            this.Rad_Sp.TabIndex = 11;
            this.Rad_Sp.Text = "São Paulo";
            this.Rad_Sp.UseVisualStyleBackColor = true;
            this.Rad_Sp.CheckedChanged += new System.EventHandler(this.Rad_Sp_CheckedChanged);
            // 
            // Rad_Rj
            // 
            this.Rad_Rj.AutoSize = true;
            this.Rad_Rj.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Rj.Location = new System.Drawing.Point(298, 192);
            this.Rad_Rj.Name = "Rad_Rj";
            this.Rad_Rj.Size = new System.Drawing.Size(180, 32);
            this.Rad_Rj.TabIndex = 10;
            this.Rad_Rj.Text = "Rio de Janeiro";
            this.Rad_Rj.UseVisualStyleBackColor = true;
            this.Rad_Rj.CheckedChanged += new System.EventHandler(this.Rad_Rj_CheckedChanged);
            // 
            // Rad_Mg
            // 
            this.Rad_Mg.AutoSize = true;
            this.Rad_Mg.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Mg.Location = new System.Drawing.Point(298, 123);
            this.Rad_Mg.Name = "Rad_Mg";
            this.Rad_Mg.Size = new System.Drawing.Size(165, 32);
            this.Rad_Mg.TabIndex = 9;
            this.Rad_Mg.Text = "Minas Gerais";
            this.Rad_Mg.UseVisualStyleBackColor = true;
            this.Rad_Mg.CheckedChanged += new System.EventHandler(this.Rad_Mg_CheckedChanged);
            // 
            // Rad_Es
            // 
            this.Rad_Es.AutoSize = true;
            this.Rad_Es.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Es.Location = new System.Drawing.Point(300, 57);
            this.Rad_Es.Name = "Rad_Es";
            this.Rad_Es.Size = new System.Drawing.Size(178, 32);
            this.Rad_Es.TabIndex = 8;
            this.Rad_Es.Text = "Espírito Santo";
            this.Rad_Es.UseVisualStyleBackColor = true;
            this.Rad_Es.CheckedChanged += new System.EventHandler(this.Rad_Es_CheckedChanged);
            // 
            // Pic_estado
            // 
            this.Pic_estado.Location = new System.Drawing.Point(27, 49);
            this.Pic_estado.Name = "Pic_estado";
            this.Pic_estado.Size = new System.Drawing.Size(247, 250);
            this.Pic_estado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_estado.TabIndex = 7;
            this.Pic_estado.TabStop = false;
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Confirmar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Confirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Confirmar.Location = new System.Drawing.Point(1057, 719);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(133, 35);
            this.Btn_Confirmar.TabIndex = 1;
            this.Btn_Confirmar.Text = "Confirmar";
            this.Btn_Confirmar.UseVisualStyleBackColor = false;
            this.Btn_Confirmar.Visible = false;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fechar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Fechar.Location = new System.Drawing.Point(1198, 12);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(46, 37);
            this.Btn_Fechar.TabIndex = 2;
            this.Btn_Fechar.Text = "X";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Frm_Abertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1256, 803);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.Grp_Dadosrec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Abertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABERTURA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_abertura_FormClosed);
            this.Grp_Dadosrec.ResumeLayout(false);
            this.Grp_Dadosrec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_operadoras)).EndInit();
            this.Grp_regiao.ResumeLayout(false);
            this.Grp_regiao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_estado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Grp_regiao;
        private System.Windows.Forms.PictureBox Pic_operadoras;
        private System.Windows.Forms.Label Lbl_Ddd;
        private System.Windows.Forms.Label Lbl_RgSl;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.RadioButton Rad_Sp;
        private System.Windows.Forms.RadioButton Rad_Rj;
        private System.Windows.Forms.RadioButton Rad_Mg;
        private System.Windows.Forms.RadioButton Rad_Es;
        private System.Windows.Forms.PictureBox Pic_estado;
        private System.Windows.Forms.TextBox Txt_Ddd;
        private System.Windows.Forms.TextBox Txt_RgS;
        private System.Windows.Forms.Button Btn_Confirmar;
        public System.Windows.Forms.GroupBox Grp_Dadosrec;
        public System.Windows.Forms.TextBox Txt_Nm;
        private System.Windows.Forms.Label Lbl_Caracteres;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}

