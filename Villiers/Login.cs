using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Villiers
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public int lvl = 1;

        string connectBDD = "server=localhost; user id=root; database=villiers";

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (tbPseudo.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Veuillez compléter tous les champs !");
                return;
            }
            else
            {
                try
                {
                    string pseudo = tbPseudo.Text;
                    string motdepasse = (SHA.petitsha(tbPassword.Text));

                    MySqlConnection conn = new MySqlConnection(connectBDD);
                    conn.Open();

                    string sql = $"SELECT id, pseudo, motdepasse, lvl FROM utilisateurs WHERE pseudo = '{pseudo}' AND motdepasse = '{motdepasse}'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        lvl = int.Parse(rdr[0].ToString());
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Identifians incorrects !");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
