using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Engine;
using RPGAdventurePlus.View_Layer;

namespace RPGAdventurePlus
{
    public partial class frm_LaddaSpel : Form
    {
        frm_MainMenu menu;
        public frm_LaddaSpel(frm_MainMenu mainMenu)
        {
            InitializeComponent();
            menu = mainMenu;
            try
            {
                XmlDocument saveFileData = new XmlDocument();
                saveFileData.LoadXml(File.ReadAllText(GlobalSetting.SAVE_FILES_NAME));
             
                foreach(XmlNode node in saveFileData.SelectNodes("/Saves/Save"))
                {
                    cbSavesList.Items.Add(string.Join(Environment.NewLine, node.InnerText.Replace(".xml","")));
                }        
            }
            catch
            {
                Application.Exit();
            }
         }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            menu.Close();
            this.Close();
            try
            {
                Player player = Player.LoadPlayerInformationFromXml(File.ReadAllText(cbSavesList.SelectedItem.ToString() + ".xml"));
                MainFrm formAdventurePlus = new MainFrm(player, cbSavesList.SelectedItem.ToString() + ".xml");
                formAdventurePlus.Show();
            }
            catch
            {
                if (MessageBox.Show("Applikationen kunde inte ladda vald fil. Filen kan vara flyttat eller skadad.", "Felmeddelande", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.menu.Show();
                }
            }
        }
    }
}
