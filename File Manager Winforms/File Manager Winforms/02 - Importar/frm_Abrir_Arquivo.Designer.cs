namespace File_Manager_Winforms._02___Importar
{
    partial class frm_Abrir_Arquivo
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
            this.lbl_Nome_Arquivo = new System.Windows.Forms.Label();
            this.txt_Nome_Arquivo = new System.Windows.Forms.TextBox();
            this.txt_Tamanho_Arquivo = new System.Windows.Forms.TextBox();
            this.lbl_Tamanho = new System.Windows.Forms.Label();
            this.txt_Data_Importacao = new System.Windows.Forms.TextBox();
            this.lbl_Data_Importacao = new System.Windows.Forms.Label();
            this.pb_Imagem = new System.Windows.Forms.PictureBox();
            this.btn_Fechar_Arquivo = new System.Windows.Forms.Button();
            this.btn_Proxima = new System.Windows.Forms.Button();
            this.btn_Anterior = new System.Windows.Forms.Button();
            this.panel_Slide_Image = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagem)).BeginInit();
            this.panel_Slide_Image.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Nome_Arquivo
            // 
            this.lbl_Nome_Arquivo.AutoSize = true;
            this.lbl_Nome_Arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome_Arquivo.Location = new System.Drawing.Point(12, 15);
            this.lbl_Nome_Arquivo.Name = "lbl_Nome_Arquivo";
            this.lbl_Nome_Arquivo.Size = new System.Drawing.Size(142, 25);
            this.lbl_Nome_Arquivo.TabIndex = 5;
            this.lbl_Nome_Arquivo.Text = "Nome Arquivo:";
            // 
            // txt_Nome_Arquivo
            // 
            this.txt_Nome_Arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nome_Arquivo.Enabled = false;
            this.txt_Nome_Arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome_Arquivo.Location = new System.Drawing.Point(160, 12);
            this.txt_Nome_Arquivo.Name = "txt_Nome_Arquivo";
            this.txt_Nome_Arquivo.Size = new System.Drawing.Size(893, 30);
            this.txt_Nome_Arquivo.TabIndex = 6;
            this.txt_Nome_Arquivo.Text = "nome.jpg";
            // 
            // txt_Tamanho_Arquivo
            // 
            this.txt_Tamanho_Arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Tamanho_Arquivo.Enabled = false;
            this.txt_Tamanho_Arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tamanho_Arquivo.Location = new System.Drawing.Point(192, 53);
            this.txt_Tamanho_Arquivo.Name = "txt_Tamanho_Arquivo";
            this.txt_Tamanho_Arquivo.Size = new System.Drawing.Size(861, 30);
            this.txt_Tamanho_Arquivo.TabIndex = 8;
            this.txt_Tamanho_Arquivo.Text = "0000 KB";
            // 
            // lbl_Tamanho
            // 
            this.lbl_Tamanho.AutoSize = true;
            this.lbl_Tamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tamanho.Location = new System.Drawing.Point(12, 56);
            this.lbl_Tamanho.Name = "lbl_Tamanho";
            this.lbl_Tamanho.Size = new System.Drawing.Size(174, 25);
            this.lbl_Tamanho.TabIndex = 7;
            this.lbl_Tamanho.Text = "Tamanho Arquivo:";
            // 
            // txt_Data_Importacao
            // 
            this.txt_Data_Importacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Data_Importacao.Enabled = false;
            this.txt_Data_Importacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Data_Importacao.Location = new System.Drawing.Point(179, 94);
            this.txt_Data_Importacao.Name = "txt_Data_Importacao";
            this.txt_Data_Importacao.Size = new System.Drawing.Size(874, 30);
            this.txt_Data_Importacao.TabIndex = 10;
            this.txt_Data_Importacao.Text = "00/00/0000 00:00:00";
            // 
            // lbl_Data_Importacao
            // 
            this.lbl_Data_Importacao.AutoSize = true;
            this.lbl_Data_Importacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data_Importacao.Location = new System.Drawing.Point(12, 97);
            this.lbl_Data_Importacao.Name = "lbl_Data_Importacao";
            this.lbl_Data_Importacao.Size = new System.Drawing.Size(161, 25);
            this.lbl_Data_Importacao.TabIndex = 9;
            this.lbl_Data_Importacao.Text = "Data Importação:";
            // 
            // pb_Imagem
            // 
            this.pb_Imagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Imagem.Location = new System.Drawing.Point(49, 1);
            this.pb_Imagem.Name = "pb_Imagem";
            this.pb_Imagem.Size = new System.Drawing.Size(938, 465);
            this.pb_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Imagem.TabIndex = 11;
            this.pb_Imagem.TabStop = false;
            // 
            // btn_Fechar_Arquivo
            // 
            this.btn_Fechar_Arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Fechar_Arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar_Arquivo.Location = new System.Drawing.Point(17, 603);
            this.btn_Fechar_Arquivo.Name = "btn_Fechar_Arquivo";
            this.btn_Fechar_Arquivo.Size = new System.Drawing.Size(223, 41);
            this.btn_Fechar_Arquivo.TabIndex = 12;
            this.btn_Fechar_Arquivo.Text = "Fechar";
            this.btn_Fechar_Arquivo.UseVisualStyleBackColor = true;
            this.btn_Fechar_Arquivo.Click += new System.EventHandler(this.btn_Fechar_Arquivo_Click);
            // 
            // btn_Proxima
            // 
            this.btn_Proxima.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Proxima.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Proxima.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_Proxima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Proxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proxima.Location = new System.Drawing.Point(987, 1);
            this.btn_Proxima.Name = "btn_Proxima";
            this.btn_Proxima.Size = new System.Drawing.Size(48, 465);
            this.btn_Proxima.TabIndex = 13;
            this.btn_Proxima.Text = ">";
            this.btn_Proxima.UseVisualStyleBackColor = false;
            this.btn_Proxima.Click += new System.EventHandler(this.btn_Proxima_Click);
            // 
            // btn_Anterior
            // 
            this.btn_Anterior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Anterior.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Anterior.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_Anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anterior.Location = new System.Drawing.Point(1, 1);
            this.btn_Anterior.Name = "btn_Anterior";
            this.btn_Anterior.Size = new System.Drawing.Size(48, 465);
            this.btn_Anterior.TabIndex = 14;
            this.btn_Anterior.Text = "<";
            this.btn_Anterior.UseVisualStyleBackColor = false;
            this.btn_Anterior.Click += new System.EventHandler(this.btn_Anterior_Click);
            // 
            // panel_Slide_Image
            // 
            this.panel_Slide_Image.Controls.Add(this.pb_Imagem);
            this.panel_Slide_Image.Controls.Add(this.btn_Anterior);
            this.panel_Slide_Image.Controls.Add(this.btn_Proxima);
            this.panel_Slide_Image.Location = new System.Drawing.Point(17, 130);
            this.panel_Slide_Image.Name = "panel_Slide_Image";
            this.panel_Slide_Image.Padding = new System.Windows.Forms.Padding(1);
            this.panel_Slide_Image.Size = new System.Drawing.Size(1036, 467);
            this.panel_Slide_Image.TabIndex = 15;
            // 
            // frm_Abrir_Arquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 656);
            this.Controls.Add(this.panel_Slide_Image);
            this.Controls.Add(this.btn_Fechar_Arquivo);
            this.Controls.Add(this.txt_Data_Importacao);
            this.Controls.Add(this.lbl_Data_Importacao);
            this.Controls.Add(this.txt_Tamanho_Arquivo);
            this.Controls.Add(this.lbl_Tamanho);
            this.Controls.Add(this.txt_Nome_Arquivo);
            this.Controls.Add(this.lbl_Nome_Arquivo);
            this.Name = "frm_Abrir_Arquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arquivo";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagem)).EndInit();
            this.panel_Slide_Image.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_Nome_Arquivo;
        public System.Windows.Forms.TextBox txt_Nome_Arquivo;
        public System.Windows.Forms.TextBox txt_Tamanho_Arquivo;
        public System.Windows.Forms.Label lbl_Tamanho;
        public System.Windows.Forms.TextBox txt_Data_Importacao;
        public System.Windows.Forms.Label lbl_Data_Importacao;
        public System.Windows.Forms.Button btn_Fechar_Arquivo;
        public System.Windows.Forms.PictureBox pb_Imagem;
        public System.Windows.Forms.Button btn_Proxima;
        public System.Windows.Forms.Button btn_Anterior;
        private System.Windows.Forms.Panel panel_Slide_Image;
    }
}