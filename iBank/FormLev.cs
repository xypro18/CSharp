using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iBank
{
    public partial class FormLev : Form
    {
        private int xLength = 0;
        private int xPosicao = 0;
        public FormLev()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLev_Load(object sender, EventArgs e)
        {
            xLength = iBank.Program.ArrayContas.Length;
            if (xLength > 0)
            {
                
                cb_conta.Items.Clear();
                for (int i = 0; i < xLength; i++)
                {
                    if(iBank.Program.ArrayContas[i].Desativa == false)
                        cb_conta.Items.Add(iBank.Program.ArrayContas[i].Nconta);
                }
                
            } else
            {
                MessageBox.Show("Não existem contas", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            if (iBank.Program.XOpMenu == 2)
            {
                rb_lev.Select();
            }
            else
            {
                rb_dep.Select();
            }

        }

        private void rb_lev_CheckedChanged(object sender, EventArgs e)
        {
            gb_lev.Text = "Levantamento";
            lbl_tmov.Text = "Valor a levantar";
        }

        private void rb_dep_CheckedChanged(object sender, EventArgs e)
        {
            gb_lev.Text = "Depósito";
            lbl_tmov.Text = "Valor a depositar";
        }

        private void cb_conta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < xLength; i++)
            {
                if (iBank.Program.ArrayContas[i].Nconta == Convert.ToInt16(cb_conta.Text))
                {
                    xPosicao = i;
                    tb_titular.Text = iBank.Program.ArrayContas[i].Titular;
                    tb_saldo.Text = Convert.ToString(iBank.Program.ArrayContas[i].Saldo);
                    btn_cancel.Visible = true;
                    tb_valor.Enabled = true;
                    break;
                }

            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_lev_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_valor.Text)) {
                MessageBox.Show("Deve digitar um valor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_valor.Focus();
            } else if (Convert.ToDouble(tb_valor.Text) <= 0)
            {
                MessageBox.Show("O valor deve ser superior a zero!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_valor.Focus();
            } else
            {
                btn_cancel.Visible = true;
                btn_ok.Visible = true;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
