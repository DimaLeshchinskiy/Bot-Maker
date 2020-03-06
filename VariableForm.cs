using System;
using System.Collections;
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
    public partial class VariableForm : Form
    {
        private Memory memory_variables;

        private ArrayList list = new ArrayList();

        public VariableForm(Memory memory_variables)
        {
            InitializeComponent();

            this.memory_variables = memory_variables;

            panel_Init();
        }


        public void panel_Init()
        {
            foreach(KeyValuePair<object, object> item in memory_variables.getDictionary())
            {
                UserControl_Variable uv = new UserControl_Variable();
                uv.Name = item.Key.ToString();
                uv.Value = item.Value.ToString();

                list.Add(uv);

                flowLayoutPanel1.Controls.Add(uv);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl_Variable uv = new UserControl_Variable();

            uv.Name = "new";
            uv.Value = "0";

            list.Add(uv);

            flowLayoutPanel1.Controls.Add(uv);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(flowLayoutPanel1.Controls.Count - 1 > -1)
            {
                list.RemoveAt(list.Count - 1);
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            memory_variables.clearAllDictionary();

            foreach (UserControl_Variable item in list)
            {
                memory_variables.addToDictionary(item.Name, item.Value);
            }

            this.Close();
        }
    }
}
