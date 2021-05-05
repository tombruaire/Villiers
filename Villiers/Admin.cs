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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        List<Utilisateurs> lesutilisateurs = new List<Utilisateurs>();
        List<Salon> lessalons = new List<Salon>();

        MySqlConnection conn = null;

        private void load_utilisateurs()
        {
            lesutilisateurs.Clear();

            string sql = "SELECT id, nom, prenom, pseudo, email, date_inscription FROM utilisateurs";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Utilisateurs UtilisateursView = new Utilisateurs(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), DateTime.Parse(rdr[5].ToString()));
                lesutilisateurs.Add(UtilisateursView);
            }
            rdr.Close();

            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = lesutilisateurs;

        }

        private void load_salons()
        {
            //
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            conn = Database.openConnection();
            load_utilisateurs();
            load_salons();
        }

        private void buttonAddUsers_Click(object sender, EventArgs e)
        {
            InsertUser insertion = new InsertUser();
            insertion.ShowDialog();

            if (insertion.DialogResult == DialogResult.OK)
            {
                insertion.Close();
                conn = Database.openConnection();
                load_utilisateurs();
                return;
            }

            lesutilisateurs.Clear();

            string sql = "SELECT id, nom, prenom, pseudo, email, date_inscription FROM utilisateurs";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Utilisateurs UtilisateursView = new Utilisateurs(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), DateTime.Parse(rdr[5].ToString()));
                lesutilisateurs.Add(UtilisateursView);
            }
            rdr.Close();

            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = lesutilisateurs;

        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            UpdateUser update = new UpdateUser();
            update.ShowDialog();

            if (update.DialogResult == DialogResult.OK)
            {
                update.Close();
                conn = Database.openConnection();
                load_utilisateurs();
                return;
            }

            lesutilisateurs.Clear();

            string sql = "SELECT id, nom, prenom, pseudo, email, date_inscription FROM utilisateurs";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Utilisateurs UtilisateursView = new Utilisateurs(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), DateTime.Parse(rdr[5].ToString()));
                lesutilisateurs.Add(UtilisateursView);
            }
            rdr.Close();

            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = lesutilisateurs;
        }

        private void button1_Click(object sender, EventArgs e) // Bouton supprimer
        {
            DeleteUser delete = new DeleteUser();
            delete.ShowDialog();

            if (delete.DialogResult == DialogResult.OK)
            {
                delete.Close();
                conn = Database.openConnection();
                load_utilisateurs();
                return;
            }

            lesutilisateurs.Clear();

            string sql = "SELECT id, nom, prenom, pseudo, email, date_inscription FROM utilisateurs";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Utilisateurs UtilisateursView = new Utilisateurs(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), DateTime.Parse(rdr[5].ToString()));
                lesutilisateurs.Add(UtilisateursView);
            }
            rdr.Close();

            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = lesutilisateurs;
        }
    }
}
