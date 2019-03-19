using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iBank
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static int XOpMenu = 0; //variável publica XopMenu 0-> Nova Conta; 1-> Desativar Conta

        public static Conta[] ArrayContas = new Conta[0]; //Array de contas

        [STAThread]
        static void Main()
        {
            //ArrayContas = new Conta[5];

            //for (int i = 0; i < ArrayContas.Length; i++)
            //{
            //    iBank.Program.ArrayContas[i] = new Conta();
            //    iBank.Program.ArrayContas[i].Nconta = i;
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Fmain());
        }
    }
}
