namespace express
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Salvar_usuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Salvar_usuario
            // 
            this.btn_Salvar_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salvar_usuario.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Salvar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar_usuario.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar_usuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salvar_usuario.Image")));
            this.btn_Salvar_usuario.Location = new System.Drawing.Point(438, 404);
            this.btn_Salvar_usuario.Name = "btn_Salvar_usuario";
            this.btn_Salvar_usuario.Size = new System.Drawing.Size(84, 30);
            this.btn_Salvar_usuario.TabIndex = 24;
            this.btn_Salvar_usuario.UseVisualStyleBackColor = true;
            this.btn_Salvar_usuario.Click += new System.EventHandler(this.btn_Salvar_usuario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 534);
            this.Controls.Add(this.btn_Salvar_usuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Salvar_usuario;
    }
}

