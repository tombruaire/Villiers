using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Villiers
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login MonFormLogin = new Login();

            Admin FormAdmin = null;

            Operateurs FormOperateur = null;

            MonFormLogin.ShowDialog();

            if (MonFormLogin.DialogResult == DialogResult.OK)
            {
                MonFormLogin.Close();

                if (MonFormLogin.lvl == 1)
                {
                    FormAdmin = new Admin();
                    FormAdmin.ShowDialog();
                }
                else if (MonFormLogin.lvl == 0)
                {
                    FormOperateur = new Operateurs();
                    FormOperateur.ShowDialog();
                }
            }
            else
            {
                MonFormLogin.Close();
                MessageBox.Show("A bientôt !");
            }
        }
    }
}
