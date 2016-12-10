using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGAdventurePlus
{
    public partial class SaveFileName : Form
    {
        frm_MainMenu mainMenu;
        public SaveFileName(frm_MainMenu mainMenuRef)
        {
            InitializeComponent();
            mainMenu = mainMenuRef;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtboxFileName.Text == "")
            {
                MessageBox.Show("Du måste age ett giltigt filnamn");
            }
            else
            {
                mainMenu.Close();
                string filename = txtboxFileName.Text;
                frm_SkapaKaraktar characterCreation = new frm_SkapaKaraktar(filename);
                this.Close();
                characterCreation.Show();
            }
        }

    }
}
