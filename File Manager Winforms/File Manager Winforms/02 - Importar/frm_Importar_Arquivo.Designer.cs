namespace File_Manager_Winforms
{
    partial class frm_Importar_Arquivo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Arquivo = new System.Windows.Forms.Label();
            this.txt_Caminho_Arquivo = new System.Windows.Forms.TextBox();
            this.btn_Selecionar_Arquivo = new System.Windows.Forms.Button();
            this.btn_Importar = new System.Windows.Forms.Button();
            this.lbl_Arquivos_Importados = new System.Windows.Forms.Label();
            this.dgv_Arquivos = new System.Windows.Forms.DataGridView();
            this.btn_Abrir_Arquivo = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Get_Print = new System.Windows.Forms.Button();
            this.btn_Detectar_Arquivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Arquivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Arquivo
            // 
            this.lbl_Arquivo.AutoSize = true;
            this.lbl_Arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Arquivo.Location = new System.Drawing.Point(12, 26);
            this.lbl_Arquivo.Name = "lbl_Arquivo";
            this.lbl_Arquivo.Size = new System.Drawing.Size(85, 25);
            this.lbl_Arquivo.TabIndex = 0;
            this.lbl_Arquivo.Text = "Arquivo:";
            // 
            // txt_Caminho_Arquivo
            // 
            this.txt_Caminho_Arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Caminho_Arquivo.Enabled = false;
            this.txt_Caminho_Arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Caminho_Arquivo.Location = new System.Drawing.Point(103, 23);
            this.txt_Caminho_Arquivo.Name = "txt_Caminho_Arquivo";
            this.txt_Caminho_Arquivo.Size = new System.Drawing.Size(717, 30);
            this.txt_Caminho_Arquivo.TabIndex = 1;
            // 
            // btn_Selecionar_Arquivo
            // 
            this.btn_Selecionar_Arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Selecionar_Arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Selecionar_Arquivo.Location = new System.Drawing.Point(826, 23);
            this.btn_Selecionar_Arquivo.Name = "btn_Selecionar_Arquivo";
            this.btn_Selecionar_Arquivo.Size = new System.Drawing.Size(58, 30);
            this.btn_Selecionar_Arquivo.TabIndex = 2;
            this.btn_Selecionar_Arquivo.Text = "...";
            this.btn_Selecionar_Arquivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Selecionar_Arquivo.UseVisualStyleBackColor = true;
            this.btn_Selecionar_Arquivo.Click += new System.EventHandler(this.btn_Selecionar_Arquivo_Click);
            // 
            // btn_Importar
            // 
            this.btn_Importar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Importar.Location = new System.Drawing.Point(103, 59);
            this.btn_Importar.Name = "btn_Importar";
            this.btn_Importar.Size = new System.Drawing.Size(249, 41);
            this.btn_Importar.TabIndex = 3;
            this.btn_Importar.Text = "Importar Arquivo";
            this.btn_Importar.UseVisualStyleBackColor = true;
            this.btn_Importar.Click += new System.EventHandler(this.btn_Importar_Click);
            // 
            // lbl_Arquivos_Importados
            // 
            this.lbl_Arquivos_Importados.AutoSize = true;
            this.lbl_Arquivos_Importados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Arquivos_Importados.Location = new System.Drawing.Point(12, 124);
            this.lbl_Arquivos_Importados.Name = "lbl_Arquivos_Importados";
            this.lbl_Arquivos_Importados.Size = new System.Drawing.Size(197, 25);
            this.lbl_Arquivos_Importados.TabIndex = 4;
            this.lbl_Arquivos_Importados.Text = "Arquivos Importados:";
            // 
            // dgv_Arquivos
            // 
            this.dgv_Arquivos.AllowUserToAddRows = false;
            this.dgv_Arquivos.AllowUserToDeleteRows = false;
            this.dgv_Arquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Arquivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Arquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Arquivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Arquivos.Location = new System.Drawing.Point(17, 160);
            this.dgv_Arquivos.Name = "dgv_Arquivos";
            this.dgv_Arquivos.ReadOnly = true;
            this.dgv_Arquivos.RowHeadersVisible = false;
            this.dgv_Arquivos.RowTemplate.Height = 24;
            this.dgv_Arquivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Arquivos.Size = new System.Drawing.Size(867, 345);
            this.dgv_Arquivos.TabIndex = 5;
            // 
            // btn_Abrir_Arquivo
            // 
            this.btn_Abrir_Arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Abrir_Arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abrir_Arquivo.Location = new System.Drawing.Point(17, 518);
            this.btn_Abrir_Arquivo.Name = "btn_Abrir_Arquivo";
            this.btn_Abrir_Arquivo.Size = new System.Drawing.Size(223, 41);
            this.btn_Abrir_Arquivo.TabIndex = 6;
            this.btn_Abrir_Arquivo.Text = "Abrir Arquivo";
            this.btn_Abrir_Arquivo.UseVisualStyleBackColor = true;
            this.btn_Abrir_Arquivo.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atualizar.Location = new System.Drawing.Point(768, 116);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(116, 41);
            this.btn_Atualizar.TabIndex = 7;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Get_Print
            // 
            this.btn_Get_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Get_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Get_Print.Location = new System.Drawing.Point(750, 59);
            this.btn_Get_Print.Name = "btn_Get_Print";
            this.btn_Get_Print.Size = new System.Drawing.Size(134, 41);
            this.btn_Get_Print.TabIndex = 8;
            this.btn_Get_Print.Text = "Get Print";
            this.btn_Get_Print.UseVisualStyleBackColor = true;
            this.btn_Get_Print.Click += new System.EventHandler(this.btn_Get_Print_Click);
            // 
            // btn_Detectar_Arquivo
            // 
            this.btn_Detectar_Arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Detectar_Arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detectar_Arquivo.Location = new System.Drawing.Point(661, 518);
            this.btn_Detectar_Arquivo.Name = "btn_Detectar_Arquivo";
            this.btn_Detectar_Arquivo.Size = new System.Drawing.Size(223, 41);
            this.btn_Detectar_Arquivo.TabIndex = 9;
            this.btn_Detectar_Arquivo.Text = "Capturar Arquivo";
            this.btn_Detectar_Arquivo.UseVisualStyleBackColor = true;
            this.btn_Detectar_Arquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Importar_Arquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 571);
            this.Controls.Add(this.btn_Detectar_Arquivo);
            this.Controls.Add(this.btn_Get_Print);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Abrir_Arquivo);
            this.Controls.Add(this.dgv_Arquivos);
            this.Controls.Add(this.lbl_Arquivos_Importados);
            this.Controls.Add(this.btn_Importar);
            this.Controls.Add(this.btn_Selecionar_Arquivo);
            this.Controls.Add(this.txt_Caminho_Arquivo);
            this.Controls.Add(this.lbl_Arquivo);
            this.Name = "frm_Importar_Arquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Arquivos";
            this.Load += new System.EventHandler(this.frm_Importar_Arquivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Arquivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_Atualizar;
        public System.Windows.Forms.Label lbl_Arquivo;
        public System.Windows.Forms.TextBox txt_Caminho_Arquivo;
        public System.Windows.Forms.Button btn_Selecionar_Arquivo;
        public System.Windows.Forms.Button btn_Importar;
        public System.Windows.Forms.Label lbl_Arquivos_Importados;
        public System.Windows.Forms.DataGridView dgv_Arquivos;
        public System.Windows.Forms.Button btn_Abrir_Arquivo;
        public System.Windows.Forms.Button btn_Get_Print;
        public System.Windows.Forms.Button btn_Detectar_Arquivo;
    }
}

