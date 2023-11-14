namespace EjemploABM
{
    partial class frmLogin
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
            this.btnCrearCliente = new MaterialSkin.Controls.MaterialButton();
            this.txtContrasenia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.AutoSize = false;
            this.btnCrearCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCrearCliente.Depth = 0;
            this.btnCrearCliente.HighEmphasis = true;
            this.btnCrearCliente.Icon = null;
            this.btnCrearCliente.Location = new System.Drawing.Point(229, 246);
            this.btnCrearCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrearCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCrearCliente.Size = new System.Drawing.Size(162, 36);
            this.btnCrearCliente.TabIndex = 9;
            this.btnCrearCliente.Text = "Crear Cliente";
            this.btnCrearCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCrearCliente.UseAccentColor = false;
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.AnimateReadOnly = false;
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.Depth = 0;
            this.txtContrasenia.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtContrasenia.LeadingIcon = null;
            this.txtContrasenia.Location = new System.Drawing.Point(197, 151);
            this.txtContrasenia.MaxLength = 50;
            this.txtContrasenia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasenia.Multiline = false;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(232, 50);
            this.txtContrasenia.TabIndex = 8;
            this.txtContrasenia.Text = "Ingrese contraseña";
            this.txtContrasenia.TrailingIcon = null;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(197, 76);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 50);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "Ingrese email";
            this.txtEmail.TrailingIcon = null;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(229, 307);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(162, 36);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Iniciar Sesion";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 352);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Text = "Inicio Sesion";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCrearCliente;
        private MaterialSkin.Controls.MaterialTextBox txtContrasenia;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialButton btnLogin;
    }
}