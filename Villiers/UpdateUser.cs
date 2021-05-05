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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        string connectBDD = "server=localhost; user id=root; database=villiers";

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "" || tbNom.Text == "" || tbPrenom.Text == "" || tbPseudo.Text == "" || tbEmail.Text == "" || tbMdp.Text == "")
            {
                MessageBox.Show("Les champs ne doivent pas être vides !");
            }
            else
            {
                try
                {
                    string id = tbID.Text;
                    string nom = tbNom.Text;
                    string prenom = tbPrenom.Text;
                    string pseudo = tbPseudo.Text;
                    string email = tbEmail.Text;
                    string motdepasse = (SHA.petitsha(tbMdp.Text));

                    MySqlConnection conn = new MySqlConnection(connectBDD);
                    conn.Open();

                    string sql = $"UPDATE utilisateurs SET nom = '{nom}', prenom  = '{prenom}', pseudo = '{pseudo}', email = '{email}', motdepasse = '{motdepasse}' WHERE id = '{id}' ";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Mise à jour de l'utilisateur réussi !");
                        this.DialogResult = DialogResult.Cancel;
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
        }
    }
}
