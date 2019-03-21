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
    public partial class Fconta : Form
    {
        private int xLength = 0;
        private int xPosicao = 0;
        public Fconta()
        {
            InitializeComponent();
            //MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fconta_Load(object sender, EventArgs e)
        {

            //iBank.Program.ArrayContas = new Conta[5];

            xLength = iBank.Program.ArrayContas.Length;
            //for (int i = 0; i < xLength; i++)
            //{
            //    iBank.Program.ArrayContas[i] = new Conta();
            //    iBank.Program.ArrayContas[i].Nconta = i;
            //}

            if (Program.XOpMenu == 0)
            {
                gbox_nova.Visible = true;
                gbox_encerrar.Visible = false;
                gbox_nova.Text = "Nova Conta";
                lbl_conta.Text = Convert.ToString(xLength + 1);

            }
            else 
            {
                gbox_nova.Visible = false;
                gbox_encerrar.Visible = true;
                gbox_nova.Text = "Aivar/Desativar Conta";
                cbox_conta.Focus();
                if (xLength == 0) {
                    MessageBox.Show("Não existem contas", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } else {
                    cbox_conta.Items.Clear();
                    for(int i = 0; i< xLength; i++)
                    {
                        cbox_conta.Items.Add(iBank.Program.ArrayContas[i].Nconta);
                    }
                }
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (Program.XOpMenu == 0) {
                Array.Resize(ref iBank.Program.ArrayContas, xLength + 1);
                iBank.Program.ArrayContas[xLength] = new Conta();
                iBank.Program.ArrayContas[xLength].Nconta = Convert.ToInt32(lbl_conta.Text);
                iBank.Program.ArrayContas[xLength].Saldo = Convert.ToDouble(tbox_saldo.Text);
                iBank.Program.ArrayContas[xLength].Titular = tbox_titular.Text;
                iBank.Program.ArrayContas[xLength].Desativa = false;
                MessageBox.Show("Conta criada para o cliente: " + tbox_titular.Text, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xLength++;
                this.Close();
            } else {
                iBank.Program.ArrayContas[xPosicao].Desativa = chbox_desativa.Checked;
                this.Close();                
            }
        }

        private void tbox_saldo_Leave(object sender, EventArgs e)
        {
            btn_ok.Visible = true;
            btn_cancel.Visible = true;            
        }

        private void cbox_conta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            for (i=0; i<xLength; i++) {
                if(iBank.Program.ArrayContas[i].Nconta == Convert.ToInt16(cbox_conta.Text)) {
                    xPosicao = i;
                    tbox_titular2.Text = iBank.Program.ArrayContas[i].Titular;
                    tbox_saldo2.Text = Convert.ToString(iBank.Program.ArrayContas[i].Saldo);
                    chbox_desativa.Checked = iBank.Program.ArrayContas[i].Desativa;
                    chbox_desativa.Enabled = true;
                    btn_cancel.Visible = true;
                    btn_ok.Visible = true;
                    break;
                }

            }
        }
    }
}
