
namespace Glowish_Fashion_System
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAbrirLogin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // btnAbrirLogin
            // 
            this.btnAbrirLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbrirLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbrirLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbrirLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbrirLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbrirLogin.ForeColor = System.Drawing.Color.White;
            this.btnAbrirLogin.Location = new System.Drawing.Point(12, 12);
            this.btnAbrirLogin.Name = "btnAbrirLogin";
            this.btnAbrirLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAbrirLogin.Size = new System.Drawing.Size(70, 67);
            this.btnAbrirLogin.TabIndex = 0;
            this.btnAbrirLogin.Text = "Abrir Login";
            this.btnAbrirLogin.Click += new System.EventHandler(this.btnAbrirLogin_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 263);
            this.Controls.Add(this.btnAbrirLogin);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnAbrirLogin;
    }
}

