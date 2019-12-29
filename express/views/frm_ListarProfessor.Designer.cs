namespace express.views
{
    partial class frm_ListarProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ListarProfessor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btn_add_prof = new System.Windows.Forms.Button();
            this.btn_Voltar_Prof = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_PesqProf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(794, -47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 30);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(560, 24);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(273, 30);
            this.txtPesquisa.TabIndex = 39;
            // 
            // btn_add_prof
            // 
            this.btn_add_prof.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_prof.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_add_prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_prof.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_prof.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_prof.Image")));
            this.btn_add_prof.Location = new System.Drawing.Point(824, 449);
            this.btn_add_prof.Name = "btn_add_prof";
            this.btn_add_prof.Size = new System.Drawing.Size(84, 30);
            this.btn_add_prof.TabIndex = 38;
            this.btn_add_prof.UseVisualStyleBackColor = true;
            // 
            // btn_Voltar_Prof
            // 
            this.btn_Voltar_Prof.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Voltar_Prof.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Voltar_Prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar_Prof.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar_Prof.Image = ((System.Drawing.Image)(resources.GetObject("btn_Voltar_Prof.Image")));
            this.btn_Voltar_Prof.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Voltar_Prof.Location = new System.Drawing.Point(748, 449);
            this.btn_Voltar_Prof.Name = "btn_Voltar_Prof";
            this.btn_Voltar_Prof.Size = new System.Drawing.Size(70, 30);
            this.btn_Voltar_Prof.TabIndex = 37;
            this.btn_Voltar_Prof.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3, 2, 1, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.Location = new System.Drawing.Point(20, 60);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(891, 422);
            this.dataGridView.TabIndex = 36;
            // 
            // btn_PesqProf
            // 
            this.btn_PesqProf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PesqProf.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_PesqProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesqProf.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PesqProf.Image = ((System.Drawing.Image)(resources.GetObject("btn_PesqProf.Image")));
            this.btn_PesqProf.Location = new System.Drawing.Point(839, 24);
            this.btn_PesqProf.Name = "btn_PesqProf";
            this.btn_PesqProf.Size = new System.Drawing.Size(72, 30);
            this.btn_PesqProf.TabIndex = 41;
            this.btn_PesqProf.UseVisualStyleBackColor = true;
            // 
            // frm_ListarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 502);
            this.Controls.Add(this.btn_PesqProf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btn_add_prof);
            this.Controls.Add(this.btn_Voltar_Prof);
            this.Controls.Add(this.dataGridView);
            this.Name = "frm_ListarProfessor";
            this.Text = "frm_ListarProfessor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btn_add_prof;
        private System.Windows.Forms.Button btn_Voltar_Prof;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_PesqProf;
    }
}