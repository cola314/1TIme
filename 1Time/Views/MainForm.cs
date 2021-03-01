using _1Time.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Time.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            return;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            SettingPopup popup = new SettingPopup();
            popup.Show();
        }
    }
}
