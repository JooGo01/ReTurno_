
namespace EjemploABM
{
    partial class Index
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
            this.btn_prods = new System.Windows.Forms.Button();
            this.btn_cats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_users = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_prods
            // 
            this.btn_prods.Location = new System.Drawing.Point(0, 0);
            this.btn_prods.Name = "btn_prods";
            this.btn_prods.Size = new System.Drawing.Size(75, 23);
            this.btn_prods.TabIndex = 0;
            this.btn_prods.Text = "Productos";
            this.btn_prods.UseVisualStyleBackColor = true;
            this.btn_prods.Click += new System.EventHandler(this.btn_prods_Click);
            // 
            // btn_cats
            // 
            this.btn_cats.Location = new System.Drawing.Point(90, 0);
            this.btn_cats.Name = "btn_cats";
            this.btn_cats.Size = new System.Drawing.Size(75, 23);
            this.btn_cats.TabIndex = 1;
            this.btn_cats.Text = "Categorias";
            this.btn_cats.UseVisualStyleBackColor = true;
            this.btn_cats.Click += new System.EventHandler(this.btn_cats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido: ";
            // 
            // btn_users
            // 
            this.btn_users.Location = new System.Drawing.Point(180, 0);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(75, 23);
            this.btn_users.TabIndex = 3;
            this.btn_users.Text = "Usuarios";
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 421);
            this.panel1.TabIndex = 4;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_users);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cats);
            this.Controls.Add(this.btn_prods);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_prods;
        private System.Windows.Forms.Button btn_cats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Panel panel1;
    }
}