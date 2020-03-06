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
    public partial class UserControl_Variable : UserControl
    {
        public UserControl_Variable()
        {
            InitializeComponent();
        }

        public string Name
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string Value
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
    }
}
