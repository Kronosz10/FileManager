namespace File_Manager_Winforms._03___Paste_File
{
    partial class frm_Paste_File
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
            this.lbl_Arquivo = new System.Windows.Forms.Label();
            this.panel_Evidencias = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Colar_Arquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Arquivo
            // 
            this.lbl_Arquivo.AutoSize = true;
            this.lbl_Arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Arquivo.Location = new System.Drawing.Point(12, 24);
            this.lbl_Arquivo.Name = "lbl_Arquivo";
            this.lbl_Arquivo.Size = new System.Drawing.Size(195, 25);
            this.lbl_Arquivo.TabIndex = 1;
            this.lbl_Arquivo.Text = "Arquivos Evidências:";
            // 
            // panel_Evidencias
            // 
            this.panel_Evidencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Evidencias.AutoScroll = true;
            this.panel_Evidencias.BackColor = System.Drawing.Color.White;
            this.panel_Evidencias.Location = new System.Drawing.Point(12, 52);
            this.panel_Evidencias.Name = "panel_Evidencias";
            this.panel_Evidencias.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Evidencias.Size = new System.Drawing.Size(776, 386);
            this.panel_Evidencias.TabIndex = 2;
            this.panel_Evidencias.TabStop = true;
            this.panel_Evidencias.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Evidencias_MouseDown);
            this.panel_Evidencias.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panel_Evidencias_PreviewKeyDown);
            // 
            // btn_Colar_Arquivo
            // 
            this.btn_Colar_Arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Colar_Arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Colar_Arquivo.Location = new System.Drawing.Point(565, 5);
            this.btn_Colar_Arquivo.Name = "btn_Colar_Arquivo";
            this.btn_Colar_Arquivo.Size = new System.Drawing.Size(223, 41);
            this.btn_Colar_Arquivo.TabIndex = 13;
            this.btn_Colar_Arquivo.Text = "Colar Arquivo";
            this.btn_Colar_Arquivo.UseVisualStyleBackColor = true;
            this.btn_Colar_Arquivo.Click += new System.EventHandler(this.btn_Colar_Arquivo_Click);
            // 
            // frm_Paste_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Colar_Arquivo);
            this.Controls.Add(this.panel_Evidencias);
            this.Controls.Add(this.lbl_Arquivo);
            this.KeyPreview = true;
            this.Name = "frm_Paste_File";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paste File";
            this.Load += new System.EventHandler(this.frm_Paste_File_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Paste_File_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_Arquivo;
        public System.Windows.Forms.Button btn_Colar_Arquivo;
        public System.Windows.Forms.FlowLayoutPanel panel_Evidencias;
    }
}