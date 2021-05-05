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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        string connectBDD = "server=localhost; user id=root; database=villiers";

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("Le champ ne doit pas être vide !");
            }
            else
            {
                try
                {
                    string id = tbID.Text;

                    MySqlConnection conn = new MySqlConnection(connectBDD);
                    conn.Open();

                    string sql = $"DELETE FROM utilisateurs WHERE id = '{id}' ";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Suppression de l'utilisateur réussi !");
                        this.DialogResult = DialogResult.Cancel;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cette utilisateur n'existe pas !");
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
