using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourInARowUI
{
    public partial class GameHomeForm : Form
    {
        public GameHomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameSettingsForm gameSettings = new GameSettingsForm();
            this.Dispose();
            gameSettings.ShowDialog();
        }
    }
}
