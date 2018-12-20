using File_Manager_Winforms._01___Util;
using File_Manager_Winforms._02___Importar;
using File_Manager_Winforms._03___Paste_File;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Manager_Winforms
{
    public class FileManager
    {
        public frm_Importar_Arquivo frm;
        public SQL db;
        private static int indexImg = 0;

        public FileManager(frm_Importar_Arquivo frm_Importar) {
            this.frm = frm_Importar;
            this.db = new SQL();

        }

        public void Carregar_Arquivos_Importados()
        {
            DataTable dt;
            string query = "SELECT * FROM TB_ARQUIVOS";

            dt = db.Select(query).Tables[0];

            frm.dgv_Arquivos.DataSource = dt;

            frm.dgv_Arquivos.Columns["ARQUIVO"].Visible = false;

            foreach (DataGridViewColumn col in frm.dgv_Arquivos.Columns)
            {
                col.HeaderText = col.HeaderText.Replace("_", " ");
            }
        }

        public void Selecionar_Arquivo()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecionar Arquivo";
            ofd.Multiselect = true;

            string arquivos = "";

            if (DialogResult.Cancel == ofd.ShowDialog()) {
                return;
            }

            foreach (var file in ofd.FileNames)
            {
                arquivos += file + ";";
            }


            frm.txt_Caminho_Arquivo.Text = arquivos;
        }

        public void Importar_Arquivo()
        {

            foreach (var filePath in frm.txt_Caminho_Arquivo.Text.Split(';'))
            {
                if(filePath != "")
                {
                    db.Importar_Arquivo(filePath);
                }
            }

            Carregar_Arquivos_Importados();
        }

        public void Abrir_Arquivo()
        {
            frm_Abrir_Arquivo frm_Arquivo = new frm_Abrir_Arquivo(this);

            frm_Arquivo.txt_Nome_Arquivo.Text = frm.dgv_Arquivos.SelectedRows[0].Cells["NOME_ARQUIVO"].Value.ToString();
            double tamanho = (Convert.ToInt64(frm.dgv_Arquivos.SelectedRows[0].Cells["TAMANHO_ARQUIVO"].Value) / 1024);
            frm_Arquivo.txt_Tamanho_Arquivo.Text = tamanho.ToString() + " KB";
            frm_Arquivo.txt_Data_Importacao.Text = frm.dgv_Arquivos.SelectedRows[0].Cells["DATA_IMPORTACAO"].Value.ToString();

            frm_Arquivo.pb_Imagem.Image = ByteToImage((byte[])frm.dgv_Arquivos.SelectedRows[0].Cells["ARQUIVO"].Value);

            indexImg = Convert.ToInt32(frm.dgv_Arquivos.SelectedRows[0].Index);

            frm_Arquivo.ShowDialog();
            
        }

        public void Avancar_Imagem(frm_Abrir_Arquivo frm_Arquivo)
        {
            if(indexImg < (frm.dgv_Arquivos.Rows.Count - 1))
            {           
                indexImg++;

                frm_Arquivo.txt_Nome_Arquivo.Text = frm.dgv_Arquivos.Rows[indexImg].Cells["NOME_ARQUIVO"].Value.ToString();
                double tamanho = (Convert.ToInt64(frm.dgv_Arquivos.Rows[indexImg].Cells["TAMANHO_ARQUIVO"].Value) / 1024);
                frm_Arquivo.txt_Tamanho_Arquivo.Text = tamanho.ToString() + " KB";
                frm_Arquivo.txt_Data_Importacao.Text = frm.dgv_Arquivos.Rows[indexImg].Cells["DATA_IMPORTACAO"].Value.ToString();

                frm_Arquivo.pb_Imagem.Image = ByteToImage((byte[])frm.dgv_Arquivos.Rows[indexImg].Cells["ARQUIVO"].Value);
            }
        }

        public void Voltar_Imagem(frm_Abrir_Arquivo frm_Arquivo)
        {
            if(indexImg > 0)
            {
                indexImg--;

                frm_Arquivo.txt_Nome_Arquivo.Text = frm.dgv_Arquivos.Rows[indexImg].Cells["NOME_ARQUIVO"].Value.ToString();
                double tamanho = (Convert.ToInt64(frm.dgv_Arquivos.Rows[indexImg].Cells["TAMANHO_ARQUIVO"].Value) / 1024);
                frm_Arquivo.txt_Tamanho_Arquivo.Text = tamanho.ToString() + " KB";
                frm_Arquivo.txt_Data_Importacao.Text = frm.dgv_Arquivos.Rows[indexImg].Cells["DATA_IMPORTACAO"].Value.ToString();

                frm_Arquivo.pb_Imagem.Image = ByteToImage((byte[])frm.dgv_Arquivos.Rows[indexImg].Cells["ARQUIVO"].Value);
            }
                        
        }

        public void Get_Image_Clipboard()
        {
            System.Drawing.Image returnImage = null;
            if (Clipboard.ContainsImage())
            {
                returnImage = Clipboard.GetImage();
            }

            frm_Abrir_Arquivo frm_Abrir = new frm_Abrir_Arquivo(this);

            frm_Abrir.pb_Imagem.Image = returnImage;

            frm_Abrir.ShowDialog();
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public void Detectar_Arquivo()
        {
            frm.Visible = false;

            frm_Paste_File frm_Paste = new frm_Paste_File(this);

            frm_Paste.panel_Evidencias.Controls.Clear();

            frm_Paste.ShowDialog();

            frm.Visible = true;
        }

        public void Capturar_Arquivo(frm_Paste_File frm_Paste)
        {
            System.Drawing.Image returnImage = null;
            if (Clipboard.ContainsImage())
            {
                returnImage = Clipboard.GetImage();

                PictureBox pb_Imagem = new PictureBox();

                pb_Imagem.Width = returnImage.Width;
                pb_Imagem.Height = returnImage.Height;

                //pb_Imagem.Width = 250;
                //pb_Imagem.Height = 125;

                pb_Imagem.Image = returnImage;

                frm_Paste.panel_Evidencias.Controls.Add(pb_Imagem);
            }
        }

        

    }
}
