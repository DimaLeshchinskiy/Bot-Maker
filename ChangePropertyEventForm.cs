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
    public partial class ChangePropertyEventForm : Form
    {
        private BotEvent bot;
        private Memory memory_event;

        private ArrayList list = new ArrayList();

        public ChangePropertyEventForm(BotEvent bot, Memory memory_event)
        {
            InitializeComponent();

            this.bot = bot;
            this.memory_event = memory_event;

            LoadForm();
        }

        private void LoadForm()
        {
            foreach(KeyValuePair<string, string> item in bot.getDictionary())
            {
                UserControl_Label_TextField ult = new UserControl_Label_TextField(item.Key);
                ult.Name = item.Value;

                list.Add(ult);

                flowLayoutPanel1.Controls.Add(ult);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bot.getDictionary().Clear();

            foreach(UserControl_Label_TextField item in list)
            {
                bot.addToDictionary(item.getLabelText(), item.Name);
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            memory_event.getList().Remove(bot);
            this.Close();
        }
    }
}
