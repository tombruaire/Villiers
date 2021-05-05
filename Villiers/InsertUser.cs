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
    public partial class InsertUser : Form
    {

        public InsertUser()
        {
            InitializeComponent();
        }

        string connectBDD = "server=localhost; user id=root; database=villiers";

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (tbNom.Text == "" || tbPrenom.Text == "" || tbPseudo.Text == "" || tbEmail.Text == "" || tbMdp.Text == "")
            {
                MessageBox.Show("Veuillez compléter tous les champs !");
            }
            else
            {
                try
                {
                    string nom = tbNom.Text;
                    string prenom = tbPrenom.Text;
                    string pseudo = tbPseudo.Text;
                    string email = tbEmail.Text;
                    string motdepasse = (SHA.petitsha(tbMdp.Text));

                    MySqlConnection conn = new MySqlConnection(connectBDD);
                    conn.Open();

                    string sql = $"INSERT INTO utilisateurs (nom, prenom, pseudo, email, motdepasse, date_inscription, heure_inscription, numero_confirmation, confirme, lvl) VALUES ('{nom}', '{prenom}', '{pseudo}', '{email}', '{motdepasse}', CURDATE(), CURTIME(), null, 1, 1) ";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Insertion de l'utilisateur réussi !");
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
