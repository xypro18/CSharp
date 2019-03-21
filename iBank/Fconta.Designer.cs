namespace iBank
{
    partial class Fconta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fconta));
            this.gbox_nova = new System.Windows.Forms.GroupBox();
            this.lbl_conta = new System.Windows.Forms.Label();
            this.tbox_saldo = new System.Windows.Forms.TextBox();
            this.tbox_titular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbox_encerrar = new System.Windows.Forms.GroupBox();
            this.cbox_conta = new System.Windows.Forms.ComboBox();
            this.tbox_saldo2 = new System.Windows.Forms.TextBox();
            this.tbox_titular2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chbox_desativa = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gbox_nova.SuspendLayout();
            this.gbox_encerrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_nova
            // 
            this.gbox_nova.Controls.Add(this.lbl_conta);
            this.gbox_nova.Controls.Add(this.tbox_saldo);
            this.gbox_nova.Controls.Add(this.tbox_titular);
            this.gbox_nova.Controls.Add(this.label3);
            this.gbox_nova.Controls.Add(this.label2);
            this.gbox_nova.Controls.Add(this.label1);
            this.gbox_nova.Location = new System.Drawing.Point(13, 5);
            this.gbox_nova.Name = "gbox_nova";
            this.gbox_nova.Size = new System.Drawing.Size(360, 127);
            this.gbox_nova.TabIndex = 0;
            this.gbox_nova.TabStop = false;
            // 
            // lbl_conta
            // 
            this.lbl_conta.AutoSize = true;
            this.lbl_conta.Location = new System.Drawing.Point(95, 26);
            this.lbl_conta.Name = "lbl_conta";
            this.lbl_conta.Size = new System.Drawing.Size(13, 13);
            this.lbl_conta.TabIndex = 6;
            this.lbl_conta.Text = "0";
            // 
            // tbox_saldo
            // 
            this.tbox_saldo.Location = new System.Drawing.Point(95, 80);
            this.tbox_saldo.Name = "tbox_saldo";
            this.tbox_saldo.Size = new System.Drawing.Size(130, 20);
            this.tbox_saldo.TabIndex = 5;
            this.tbox_saldo.Leave += new System.EventHandler(this.tbox_saldo_Leave);
            // 
            // tbox_titular
            // 
            this.tbox_titular.Location = new System.Drawing.Point(95, 51);
            this.tbox_titular.Name = "tbox_titular";
            this.tbox_titular.Size = new System.Drawing.Size(258, 20);
            this.tbox_titular.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NConta:";
            // 
            // gbox_encerrar
            // 
            this.gbox_encerrar.Controls.Add(this.cbox_conta);
            this.gbox_encerrar.Controls.Add(this.tbox_saldo2);
            this.gbox_encerrar.Controls.Add(this.tbox_titular2);
            this.gbox_encerrar.Controls.Add(this.label4);
            this.gbox_encerrar.Controls.Add(this.label5);
            this.gbox_encerrar.Controls.Add(this.label6);
            this.gbox_encerrar.Controls.Add(this.chbox_desativa);
            this.gbox_encerrar.Location = new System.Drawing.Point(13, 5);
            this.gbox_encerrar.Name = "gbox_encerrar";
            this.gbox_encerrar.Size = new System.Drawing.Size(360, 132);
            this.gbox_encerrar.TabIndex = 1;
            this.gbox_encerrar.TabStop = false;
            // 
            // cbox_conta
            // 
            this.cbox_conta.FormattingEnabled = true;
            this.cbox_conta.Location = new System.Drawing.Point(86, 26);
            this.cbox_conta.Name = "cbox_conta";
            this.cbox_conta.Size = new System.Drawing.Size(121, 21);
            this.cbox_conta.TabIndex = 19;
            this.cbox_conta.SelectedIndexChanged += new System.EventHandler(this.cbox_conta_SelectedIndexChanged);
            // 
            // tbox_saldo2
            // 
            this.tbox_saldo2.Location = new System.Drawing.Point(86, 84);
            this.tbox_saldo2.Name = "tbox_saldo2";
            this.tbox_saldo2.Size = new System.Drawing.Size(85, 20);
            this.tbox_saldo2.TabIndex = 18;
            // 
            // tbox_titular2
            // 
            this.tbox_titular2.Location = new System.Drawing.Point(86, 55);
            this.tbox_titular2.Name = "tbox_titular2";
            this.tbox_titular2.ReadOnly = true;
            this.tbox_titular2.Size = new System.Drawing.Size(258, 20);
            this.tbox_titular2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Saldo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Titular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "NConta:";
            // 
            // chbox_desativa
            // 
            this.chbox_desativa.AutoSize = true;
            this.chbox_desativa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbox_desativa.Enabled = false;
            this.chbox_desativa.Location = new System.Drawing.Point(275, 87);
            this.chbox_desativa.Name = "chbox_desativa";
            this.chbox_desativa.Size = new System.Drawing.Size(68, 17);
            this.chbox_desativa.TabIndex = 12;
            this.chbox_desativa.Text = "Desativa";
            this.chbox_desativa.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImage = global::iBank.Properties.Resources.icons8_ok_96;
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ok.Location = new System.Drawing.Point(318, 143);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(55, 55);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Visible = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::iBank.Properties.Resources.Cancelar_1;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.Location = new System.Drawing.Point(237, 143);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(55, 55);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Fconta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 212);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.gbox_encerrar);
            this.Controls.Add(this.gbox_nova);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fconta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Conta Bancaria";
            this.Load += new System.EventHandler(this.Fconta_Load);
            this.gbox_nova.ResumeLayout(false);
            this.gbox_nova.PerformLayout();
            this.gbox_encerrar.ResumeLayout(false);
            this.gbox_encerrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_nova;
        private System.Windows.Forms.TextBox tbox_saldo;
        private System.Windows.Forms.TextBox tbox_titular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbox_encerrar;
        private System.Windows.Forms.CheckBox chbox_desativa;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox tbox_saldo2;
        private System.Windows.Forms.TextBox tbox_titular2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbox_conta;
        private System.Windows.Forms.Label lbl_conta;
    }
}