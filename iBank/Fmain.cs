using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace iBank
{
    public partial class Fmain : Form
    {
        StreamWriter XFile;
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

        private void levantarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iBank.Program.XOpMenu = 2; //levantamento
            FormLev frm = new FormLev();
            frm.ShowDialog();
        }

        private void depositarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iBank.Program.XOpMenu = 3; //deposito
            FormLev frm = new FormLev();
            frm.ShowDialog();
        }

        private void Fmain_Load(object sender, EventArgs e)
        {

        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (File.Exists(iBank.Program.XPath))
            {
                MessageBox.Show("O ficheiro " + iBank.Program.XPath + " já existe.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                XFile = File.CreateText(iBank.Program.XPath);
                MessageBox.Show("Foi criado o ficheiro: " + iBank.Program.XPath, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XFile.Close();
            }
        }

        private void gravarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!File.Exists(iBank.Program.XPath))
            {
                MessageBox.Show("O ficheiro: " + iBank.Program.XPath + " não existe.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int xLenght = iBank.Program.ArrayContas.Length;

            if (xLenght == 0)
            {
                MessageBox.Show("Não existe informação para gravar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                using (XFile = File.CreateText(iBank.Program.XPath))
                {
                    for (int i = 0; i < xLenght; i++)
                    {
                        XFile.Write(iBank.Program.ArrayContas[i].Nconta + ";");
                        XFile.Write(iBank.Program.ArrayContas[i].Titular + ";");
                        XFile.Write(iBank.Program.ArrayContas[i].Saldo + ";");
                        XFile.WriteLine(iBank.Program.ArrayContas[i].Desativa + ";");
                    }
                }
                MessageBox.Show("Foram gravadas " + iBank.Program.ArrayContas.Length + " contas no ficheiro txt.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists(iBank.Program.XPath))
            {
                int xLength = 0;
                using (StreamReader file = File.OpenText(iBank.Program.XPath))
                {
                    iBank.Program.ArrayContas = new Conta[0];
                       while (!file.EndOfStream)
                    {
                        xLength = iBank.Program.ArrayContas.Length;
                        Array.Resize(ref iBank.Program.ArrayContas, xLength + 1);
                        iBank.Program.ArrayContas[xLength] = new Conta();

                        string[] line = file.ReadLine().Split(';');
                        iBank.Program.ArrayContas[xLength].Nconta = Convert.ToInt32(line[0]);                        
                        iBank.Program.ArrayContas[xLength].Titular = line[1];
                        iBank.Program.ArrayContas[xLength].Saldo = Convert.ToDouble(line[2]);
                        iBank.Program.ArrayContas[xLength].Desativa = Convert.ToBoolean(line[3]);
                        xLength++;
                    }
                }
                MessageBox.Show("Foram lidas " + xLength + " contas no ficheiro.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                MessageBox.Show("Não foi encontrado o fichiero: " + iBank.Program.XPath, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gerarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gerarXML3();
        }

        private void gerarXML3()
        {
            int xLength = Program.ArrayContas.Length;

            if (xLength > 0)
            {
                String xPath = @"C:\Users\mod08\Documents\CR\file01.xml";

                XmlWriterSettings xSettings = new XmlWriterSettings();
                xSettings.Indent = true;
                xSettings.NewLineOnAttributes = true;

                XmlSerializer xsSubmit = new XmlSerializer(typeof(Conta[]));

                    using (XmlWriter writer = XmlWriter.Create(xPath, xSettings))
                    {
                        xsSubmit.Serialize(writer, Program.ArrayContas);
                       // writer.Writ
                    }
                


                MessageBox.Show("Foram gravadas " + Program.ArrayContas.Length + " contas no ficheiro.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não existe informação para gravar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void gerarXML2()
        {
            int xLength = Program.ArrayContas.Length;

            if (xLength > 0)
            {
                String xPath = @"C:\Users\mod08\Documents\CR\file01.xml";

                XmlDocument XDoc = new XmlDocument();
                XmlDeclaration xmlDeclaration = XDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = XDoc.DocumentElement;
                XDoc.InsertBefore(xmlDeclaration, root);

                XmlElement XElement = XDoc.CreateElement("Contas");

                XDoc.AppendChild(XElement);

                for (int i = 0; i < xLength; i++)
                    {
                    XmlNode XNode = XElement.AppendChild(XDoc.CreateElement("Conta"));
                    XNode.AppendChild(XDoc.CreateElement("NumConta")).AppendChild(XDoc.CreateTextNode(Convert.ToString(Program.ArrayContas[i].Nconta)));
                    XNode.AppendChild(XDoc.CreateElement("Titular")).AppendChild(XDoc.CreateTextNode(Program.ArrayContas[i].Titular));
                    XNode.AppendChild(XDoc.CreateElement("Saldo")).AppendChild(XDoc.CreateTextNode(Convert.ToString(Program.ArrayContas[i].Saldo)));
                    XNode.AppendChild(XDoc.CreateElement("Desativa")).AppendChild(XDoc.CreateTextNode(Convert.ToString(Program.ArrayContas[i].Desativa)));
                }
                XDoc.Save(xPath);
    
                MessageBox.Show("Foram gravadas " + Program.ArrayContas.Length + " contas no ficheiro.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não existe informação para gravar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gerarXML1()
        {
            int xLength = Program.ArrayContas.Length;

            if (xLength > 0)
            {
                String xPath = @"C:\Users\mod08\Documents\CR\file01.xml";

                XmlWriterSettings xSettings = new XmlWriterSettings();
                xSettings.Indent = true;
                xSettings.NewLineOnAttributes = true;


                using (XmlWriter Writer = XmlWriter.Create(xPath, xSettings))
                {
                    Writer.WriteStartDocument();
                    Writer.WriteStartElement("Contas");
                    for (int i = 0; i < xLength; i++)
                    {
                        Writer.WriteStartElement("Conta");
                        Writer.WriteElementString("NumConta", Convert.ToString(Program.ArrayContas[i].Nconta));
                        Writer.WriteElementString("Titular", Program.ArrayContas[i].Titular);
                        Writer.WriteElementString("Saldo", Convert.ToString(Program.ArrayContas[i].Saldo));
                        Writer.WriteElementString("Desativa", Convert.ToString(Program.ArrayContas[i].Desativa));
                        Writer.WriteEndElement();
                    }
                    Writer.WriteEndElement();
                    Writer.WriteEndDocument();
                }
                MessageBox.Show("Foram gravadas " + Program.ArrayContas.Length + " contas no ficheiro.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não existe informação para gravar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
