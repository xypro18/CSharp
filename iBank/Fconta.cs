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
        private int XPosicao = 0;
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
            if (Program.XOpMenu == 0)
            {
                gbox_nova.Visible = true;
                gbox_encerrar.Visible = false;
                gbox_nova.Text = "Nova Conta";

            }
            else if (Program.XOpMenu == 1)
            {
                gbox_nova.Visible = false;
                gbox_encerrar.Visible = true;
                gbox_nova.Text = "Aivar/Desativar Conta";

            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

        }
    }
}
