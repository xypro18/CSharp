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
    public partial class Fmain : Form
    {
        public Fmain()
        {
            InitializeComponent();
            
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iBank.Program.XOpMenu = 0; //nova conta
            Fconta Form2 = new Fconta();
            Form2.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iBank.Program.XOpMenu = 1; //encerrar conta
            string resposta;
            resposta = Convert.ToString(MessageBox.Show("Quer mesmo sair do iBank?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (resposta == "Yes")
            {
                Application.Exit();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iBank.Program.XOpMenu = 1; //encerrar conta
            Fconta Form2 = new Fconta();
            Form2.ShowDialog();
        }
    }
}
