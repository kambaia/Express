namespace express.views
{
    partial class frm_addUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addUsuario));
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.pb_FotoUser = new System.Windows.Forms.PictureBox();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Salvar_usuario = new System.Windows.Forms.Button();
            this.txtNivelAcesso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Limpar_Prof = new System.Windows.Forms.Button();
            this.btn_Voltar_Prof = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoUser)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.Location = new System.Drawing.Point(793, 207);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(90, 30);
            this.btn_adicionar.TabIndex = 37;
            this.btn_adicionar.Text = "add";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // pb_FotoUser
            // 
            this.pb_FotoUser.Location = new System.Drawing.Point(739, 73);
            this.pb_FotoUser.Name = "pb_FotoUser";
            this.pb_FotoUser.Size = new System.Drawing.Size(208, 122);
            this.pb_FotoUser.TabIndex = 35;
            this.pb_FotoUser.TabStop = false;
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUser.Location = new System.Drawing.Point(232, 177);
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(269, 24);
            this.txtNomeUser.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nome Completo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_Salvar_usuario);
            this.groupBox2.Controls.Add(this.txtNivelAcesso);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_Limpar_Prof);
            this.groupBox2.Controls.Add(this.btn_Voltar_Prof);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSenha);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(85, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 200);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Profissionais";
            // 
            // btn_Salvar_usuario
            // 
            this.btn_Salvar_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salvar_usuario.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Salvar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar_usuario.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar_usuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salvar_usuario.Image")));
            this.btn_Salvar_usuario.Location = new System.Drawing.Point(696, 150);
            this.btn_Salvar_usuario.Name = "btn_Salvar_usuario";
            this.btn_Salvar_usuario.Size = new System.Drawing.Size(84, 30);
            this.btn_Salvar_usuario.TabIndex = 24;
            this.btn_Salvar_usuario.UseVisualStyleBackColor = true;
            this.btn_Salvar_usuario.Click += new System.EventHandler(this.btn_Salvar_usuario_Click);
            // 
            // txtNivelAcesso
            // 
            this.txtNivelAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivelAcesso.Location = new System.Drawing.Point(155, 93);
            this.txtNivelAcesso.Name = "txtNivelAcesso";
            this.txtNivelAcesso.Size = new System.Drawing.Size(167, 24);
            this.txtNivelAcesso.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nivel de Acesso:";
            // 
            // btn_Limpar_Prof
            // 
            this.btn_Limpar_Prof.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Limpar_Prof.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Limpar_Prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar_Prof.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar_Prof.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpar_Prof.Image")));
            this.btn_Limpar_Prof.Location = new System.Drawing.Point(609, 150);
            this.btn_Limpar_Prof.Name = "btn_Limpar_Prof";
            this.btn_Limpar_Prof.Size = new System.Drawing.Size(81, 30);
            this.btn_Limpar_Prof.TabIndex = 21;
            this.btn_Limpar_Prof.UseVisualStyleBackColor = true;
            // 
            // btn_Voltar_Prof
            // 
            this.btn_Voltar_Prof.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Voltar_Prof.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Voltar_Prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar_Prof.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar_Prof.Image = ((System.Drawing.Image)(resources.GetObject("btn_Voltar_Prof.Image")));
            this.btn_Voltar_Prof.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Voltar_Prof.Location = new System.Drawing.Point(533, 150);
            this.btn_Voltar_Prof.Name = "btn_Voltar_Prof";
            this.btn_Voltar_Prof.Size = new System.Drawing.Size(70, 30);
            this.btn_Voltar_Prof.TabIndex = 20;
            this.btn_Voltar_Prof.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(83, 51);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 24);
            this.txtEmail.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(83, 140);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(258, 24);
            this.txtSenha.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Senha:";
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(767, 44);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(177, 24);
            this.txtURL.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(733, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "url:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(442, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_addUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 490);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.pb_FotoUser);
            this.Controls.Add(this.txtNomeUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_addUsuario";
            this.Text = "frm_addUsuario";
            this.Load += new System.EventHandler(this.frm_addUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoUser)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.PictureBox pb_FotoUser;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Salvar_usuario;
        private System.Windows.Forms.TextBox txtNivelAcesso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Limpar_Prof;
        private System.Windows.Forms.Button btn_Voltar_Prof;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}