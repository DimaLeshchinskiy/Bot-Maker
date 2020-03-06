using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotMaker
{
    public partial class SetLocationForm : Form
    {
        private SetEventForm parent;
        private Memory memory_screenshot;

        public SetLocationForm(SetEventForm parent, Memory memory_screenshot)
        {
            InitializeComponent();
            this.parent = parent;
            this.memory_screenshot = memory_screenshot;

            foreach (String item in memory_screenshot.getList())
            {
                ScreenshotName_ComboBox.Items.Add(item);
            }
        }

        private void Image_Click(object sender, MouseEventArgs e)
        {
            parent.x = (int)((double)Screen.PrimaryScreen.WorkingArea.Width / Image_scr.Width * e.Location.X);
            parent.y = (int)((double)Screen.PrimaryScreen.WorkingArea.Height / Image_scr.Height * e.Location.Y);
            this.Close();
        }

        private void ScreenshotName_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string local_path = Window.getPath() + "\\screenshots\\" + memory_screenshot.getList()[ScreenshotName_ComboBox.SelectedIndex] + ".png";
            Image_scr.Image = Image.FromFile(local_path);
        }
    }
}
