using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Manager_Winforms._03___Paste_File
{
    public partial class frm_Paste_File : Form
    {
        private FileManager manager;

        public frm_Paste_File(FileManager fileManager)
        {
            InitializeComponent();
            this.manager = fileManager;
        }

        private void panel_Evidencias_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode == Keys.V && e.Control))
            {
                manager.Capturar_Arquivo(this);
            }
        }

        private void btn_Colar_Arquivo_Click(object sender, EventArgs e)
        {
            manager.Capturar_Arquivo(this);
        }

        private void frm_Paste_File_Load(object sender, EventArgs e)
        {
            this.panel_Evidencias.Focus();
        }

        private void frm_Paste_File_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void panel_Evidencias_MouseDown(object sender, MouseEventArgs e)
        {
            panel_Evidencias.Focus();
        }
    }
}
