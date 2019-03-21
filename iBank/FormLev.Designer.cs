namespace iBank
{
    partial class FormLev
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLev));
            this.gb_tmov = new System.Windows.Forms.GroupBox();
            this.rb_lev = new System.Windows.Forms.RadioButton();
            this.rb_dep = new System.Windows.Forms.RadioButton();
            this.gb_lev = new System.Windows.Forms.GroupBox();
            this.lbl_conta = new System.Windows.Forms.Label();
            this.cb_conta = new System.Windows.Forms.ComboBox();
            this.lbl_titular = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_tmov = new System.Windows.Forms.Label();
            this.tb_titular = new System.Windows.Forms.TextBox();
            this.tb_saldo = new System.Windows.Forms.TextBox();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gb_tmov.SuspendLayout();
            this.gb_lev.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_tmov
            // 
            this.gb_tmov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_tmov.Controls.Add(this.rb_dep);
            this.gb_tmov.Controls.Add(this.rb_lev);
            this.gb_tmov.Location = new System.Drawing.Point(12, 12);
            this.gb_tmov.Name = "gb_tmov";
            this.gb_tmov.Size = new System.Drawing.Size(431, 58);
            this.gb_tmov.TabIndex = 0;
            this.gb_tmov.TabStop = false;
            this.gb_tmov.Text = "Tipo de Movimento";
            // 
            // rb_lev
            // 
            this.rb_lev.AutoSize = true;
            this.rb_lev.Location = new System.Drawing.Point(201, 19);
            this.rb_lev.Name = "rb_lev";
            this.rb_lev.Size = new System.Drawing.Size(93, 17);
            this.rb_lev.TabIndex = 0;
            this.rb_lev.TabStop = true;
            this.rb_lev.Text = "Levantamento";
            this.rb_lev.UseVisualStyleBackColor = true;
            this.rb_lev.CheckedChanged += new System.EventHandler(this.rb_lev_CheckedChanged);
            // 
            // rb_dep
            // 
            this.rb_dep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_dep.AutoSize = true;
            this.rb_dep.Location = new System.Drawing.Point(336, 19);
            this.rb_dep.Name = "rb_dep";
            this.rb_dep.Size = new System.Drawing.Size(67, 17);
            this.rb_dep.TabIndex = 1;
            this.rb_dep.TabStop = true;
            this.rb_dep.Text = "Depósito";
            this.rb_dep.UseVisualStyleBackColor = true;
            this.rb_dep.CheckedChanged += new System.EventHandler(this.rb_dep_CheckedChanged);
            // 
            // gb_lev
            // 
            this.gb_lev.Controls.Add(this.tb_valor);
            this.gb_lev.Controls.Add(this.tb_saldo);
            this.gb_lev.Controls.Add(this.tb_titular);
            this.gb_lev.Controls.Add(this.lbl_tmov);
            this.gb_lev.Controls.Add(this.lbl_saldo);
            this.gb_lev.Controls.Add(this.lbl_titular);
            this.gb_lev.Controls.Add(this.cb_conta);
            this.gb_lev.Controls.Add(this.lbl_conta);
            this.gb_lev.Location = new System.Drawing.Point(13, 77);
            this.gb_lev.Name = "gb_lev";
            this.gb_lev.Size = new System.Drawing.Size(430, 154);
            this.gb_lev.TabIndex = 1;
            this.gb_lev.TabStop = false;
            this.gb_lev.Text = "Levantamento";
            // 
            // lbl_conta
            // 
            this.lbl_conta.AutoSize = true;
            this.lbl_conta.Location = new System.Drawing.Point(25, 33);
            this.lbl_conta.Name = "lbl_conta";
            this.lbl_conta.Size = new System.Drawing.Size(38, 13);
            this.lbl_conta.TabIndex = 0;
            this.lbl_conta.Text = "Conta:";
            // 
            // cb_conta
            // 
            this.cb_conta.FormattingEnabled = true;
            this.cb_conta.Location = new System.Drawing.Point(132, 25);
            this.cb_conta.Name = "cb_conta";
            this.cb_conta.Size = new System.Drawing.Size(121, 21);
            this.cb_conta.TabIndex = 1;
            this.cb_conta.SelectedIndexChanged += new System.EventHandler(this.cb_conta_SelectedIndexChanged);
            // 
            // lbl_titular
            // 
            this.lbl_titular.AutoSize = true;
            this.lbl_titular.Location = new System.Drawing.Point(25, 66);
            this.lbl_titular.Name = "lbl_titular";
            this.lbl_titular.Size = new System.Drawing.Size(39, 13);
            this.lbl_titular.TabIndex = 2;
            this.lbl_titular.Text = "Titular:";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(25, 94);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(64, 13);
            this.lbl_saldo.TabIndex = 3;
            this.lbl_saldo.Text = "Saldo Atual:";
            // 
            // lbl_tmov
            // 
            this.lbl_tmov.AutoSize = true;
            this.lbl_tmov.Location = new System.Drawing.Point(25, 122);
            this.lbl_tmov.Name = "lbl_tmov";
            this.lbl_tmov.Size = new System.Drawing.Size(88, 13);
            this.lbl_tmov.TabIndex = 4;
            this.lbl_tmov.Text = "Valor a Levantar:";
            // 
            // tb_titular
            // 
            this.tb_titular.Enabled = false;
            this.tb_titular.Location = new System.Drawing.Point(132, 63);
            this.tb_titular.Name = "tb_titular";
            this.tb_titular.Size = new System.Drawing.Size(270, 20);
            this.tb_titular.TabIndex = 5;
            this.tb_titular.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_saldo
            // 
            this.tb_saldo.Enabled = false;
            this.tb_saldo.Location = new System.Drawing.Point(132, 91);
            this.tb_saldo.Name = "tb_saldo";
            this.tb_saldo.Size = new System.Drawing.Size(161, 20);
            this.tb_saldo.TabIndex = 6;
            this.tb_saldo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(132, 119);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(161, 20);
            this.tb_valor.TabIndex = 7;
            this.tb_valor.Leave += new System.EventHandler(this.tb_lev_Leave);
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImage = global::iBank.Properties.Resources.icons8_ok_96;
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ok.Location = new System.Drawing.Point(310, 252);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(55, 55);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Visible = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::iBank.Properties.Resources.Cancelar_1;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.Location = new System.Drawing.Point(388, 252);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(55, 55);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FormLev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 331);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.gb_lev);
            this.Controls.Add(this.gb_tmov);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLev";
            this.Load += new System.EventHandler(this.FormLev_Load);
            this.gb_tmov.ResumeLayout(false);
            this.gb_tmov.PerformLayout();
            this.gb_lev.ResumeLayout(false);
            this.gb_lev.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_tmov;
        private System.Windows.Forms.RadioButton rb_dep;
        private System.Windows.Forms.RadioButton rb_lev;
        private System.Windows.Forms.GroupBox gb_lev;
        private System.Windows.Forms.TextBox tb_titular;
        private System.Windows.Forms.Label lbl_tmov;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label lbl_titular;
        private System.Windows.Forms.ComboBox cb_conta;
        private System.Windows.Forms.Label lbl_conta;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.TextBox tb_saldo;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}