using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotMaker
{
    public partial class SetEventForm : Form
    {
        private Window form_main;
        private FileWork file_work;
        private Memory memory_event;

        private ArrayList list = new ArrayList();

        public  int x = 0;
        public int y = 0;

        public SetEventForm(Window form_main, FileWork file_work)
        {
            InitializeComponent();

            this.form_main = form_main;
            this.file_work = file_work;
            this.memory_event = form_main.getEventMemory();
        }

        public SetEventForm(Window form_main, FileWork file_work, int x, int y)
        {
            InitializeComponent();

            this.form_main = form_main;
            this.file_work = file_work;
            this.memory_event = form_main.getEventMemory();
            this.x = x;
            this.y = y;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            FileInfo[] Files = new DirectoryInfo("lib\\").GetFiles("*.pbt");

            foreach (FileInfo file in Files)
            {
                string[] loc = file.Name.Split('.');
                comboBox1.Items.Add(loc[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                BotEvent bot = new BotEvent();

                bot.setType(comboBox1.SelectedItem.ToString());

                bot.setName(textBox1.Text);

                foreach (UserControl_Label_TextField item in list)
                {
                    string[] value = item.Name.Split(new char[] { '$' } );

                    if (value.Count() > 1)
                    {
                        if (value[1].ToLower() == "x")
                        {
                            bot.addToDictionary(item.getLabelText(), x.ToString());
                            continue;
                        }
                        if(value[1].ToLower() == "y")
                        {
                            bot.addToDictionary(item.getLabelText(), y.ToString());
                            continue;
                        }
                    }
                        bot.addToDictionary(item.getLabelText(), item.Name);
                    
                }

                memory_event.addToList(bot);
                form_main.getVariableMemory().addToDictionary("$" + textBox1.Text, 0);

                this.Close();
            }
            
        }

        private void OnBotTypeChangedProperty(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            Draw_Presset_Property(file_work.LoadPressetProperty(cmb.SelectedItem.ToString()));
        }

        

        private void Draw_Presset_Property(Dictionary<String, String> presset_name)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (KeyValuePair<string, string> item in presset_name)
            {
                UserControl_Label_TextField ult = new UserControl_Label_TextField(item.Key);
                ult.Name = item.Value;
                list.Add(ult);
                flowLayoutPanel1.Controls.Add(ult);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetLocationForm f = new SetLocationForm(this, form_main.getScreenshotMemory());
            f.ShowDialog();
        }
    }
}
