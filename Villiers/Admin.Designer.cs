
namespace Villiers
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.tabPageSalons = new System.Windows.Forms.TabPage();
            this.tabPageJournal = new System.Windows.Forms.TabPage();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonAddUsers = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.tabPageSalons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mairie de Villiers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administration";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUsers);
            this.tabControl1.Controls.Add(this.tabPageSalons);
            this.tabControl1.Controls.Add(this.tabPageJournal);
            this.tabControl1.Location = new System.Drawing.Point(35, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 345);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.button1);
            this.tabPageUsers.Controls.Add(this.buttonEditUser);
            this.tabPageUsers.Controls.Add(this.buttonAddUsers);
            this.tabPageUsers.Controls.Add(this.dataGridViewUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(705, 319);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "Utilisateurs";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // tabPageSalons
            // 
            this.tabPageSalons.Controls.Add(this.dataGridView1);
            this.tabPageSalons.Location = new System.Drawing.Point(4, 22);
            this.tabPageSalons.Name = "tabPageSalons";
            this.tabPageSalons.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSalons.Size = new System.Drawing.Size(705, 319);
            this.tabPageSalons.TabIndex = 1;
            this.tabPageSalons.Text = "Evenements";
            this.tabPageSalons.UseVisualStyleBackColor = true;
            // 
            // tabPageJournal
            // 
            this.tabPageJournal.Location = new System.Drawing.Point(4, 22);
            this.tabPageJournal.Name = "tabPageJournal";
            this.tabPageJournal.Size = new System.Drawing.Size(705, 319);
            this.tabPageJournal.TabIndex = 2;
            this.tabPageJournal.Text = "Journal de connexion";
            this.tabPageJournal.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(695, 258);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // buttonAddUsers
            // 
            this.buttonAddUsers.Location = new System.Drawing.Point(21, 281);
            this.buttonAddUsers.Name = "buttonAddUsers";
            this.buttonAddUsers.Size = new System.Drawing.Size(124, 23);
            this.buttonAddUsers.TabIndex = 1;
            this.buttonAddUsers.Text = "Ajouter un utilisateur";
            this.buttonAddUsers.UseVisualStyleBackColor = true;
            this.buttonAddUsers.Click += new System.EventHandler(this.buttonAddUsers_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(174, 281);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(129, 23);
            this.buttonEditUser.TabIndex = 2;
            this.buttonEditUser.Text = "Modifier un utilisateur";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Supprimer un utilisateur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Villiers";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageSalons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TabPage tabPageSalons;
        private System.Windows.Forms.TabPage tabPageJournal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonAddUsers;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}