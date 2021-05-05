
namespace Villiers
{
    partial class DeleteUser
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supprimer un utilisateur";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(201, 130);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID utilisateur";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(65, 208);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 34);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(234, 208);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(104, 34);
            this.buttonSubmit.TabIndex = 27;
            this.buttonSubmit.Text = "Supprimer";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 305);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteUser";
            this.Text = "Suppression d\'un utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
    }
}