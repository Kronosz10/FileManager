using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Manager_Winforms._02___Importar
{
    public partial class frm_Abrir_Arquivo : Form
    {
        private FileManager manager;

        public frm_Abrir_Arquivo(FileManager fileManager)
        {
            InitializeComponent();
            manager = fileManager;
        }

        private void btn_Fechar_Arquivo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Proxima_Click(object sender, EventArgs e)
        {
            manager.Avancar_Imagem(this);
        }

        private void btn_Anterior_Click(object sender, EventArgs e)
        {
            manager.Voltar_Imagem(this);

        }
    }
}
