
namespace Villiers
{
    partial class Login
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
            this.labelPseudo = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPseudo
            // 
            this.labelPseudo.AutoSize = true;
            this.labelPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPseudo.Location = new System.Drawing.Point(90, 68);
            this.labelPseudo.Name = "labelPseudo";
            this.labelPseudo.Size = new System.Drawing.Size(59, 18);
            this.labelPseudo.TabIndex = 0;
            this.labelPseudo.Text = "Pseudo";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(51, 127);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(98, 18);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Mot de passe";
            // 
            // tbPseudo
            // 
            this.tbPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPseudo.Location = new System.Drawing.Point(176, 65);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(186, 24);
            this.tbPseudo.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(176, 127);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(186, 24);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(218, 193);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(104, 30);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Connexion";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 298);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbPseudo);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelPseudo);
            this.Name = "Login";
            this.Text = "Villiers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPseudo;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button buttonLogin;
    }
}