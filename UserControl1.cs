using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotMaker
{
    public partial class UserControl_Label_TextField : UserControl
    {

        public UserControl_Label_TextField()
        {
            InitializeComponent();
        }

        public UserControl_Label_TextField(string val)
        {
            InitializeComponent();

            label1.Text = val;
        }

        public string getLabelText()
        {
            return label1.Text;
        }

        public string Name
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void UserControl_Label_TextField_Load(object sender, EventArgs e)
        {

        }
    }
}
