using File_Manager_Winforms._02___Importar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Manager_Winforms
{
    public partial class frm_Importar_Arquivo : Form
    {
        private FileManager manager;


        public frm_Importar_Arquivo()
        {
            InitializeComponent();
            manager = new FileManager(this);
        }

        private void frm_Importar_Arquivo_Load(object sender, EventArgs e)
        {
            manager.Carregar_Arquivos_Importados();
        }

        private void btn_Selecionar_Arquivo_Click(object sender, EventArgs e)
        {
            manager.Selecionar_Arquivo();
        }

        private void btn_Importar_Click(object sender, EventArgs e)
        {
            manager.Importar_Arquivo();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            manager.Abrir_Arquivo();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            manager.Carregar_Arquivos_Importados();
        }

        private void btn_Get_Print_Click(object sender, EventArgs e)
        {
            manager.Get_Image_Clipboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager.Detectar_Arquivo();
        }
    }
}
