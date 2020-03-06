using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace BotMaker
{
    public partial class Window : Form
    {
        private FileWork fileStream;
        
        private Memory memory_event = new Memory();
        private Memory memory_screenshot_path = new Memory();
        private Memory memory_variables = new Memory();

        private static string path;

        private BotEvent actual_botevent_running;

        public Window()
        {
            InitializeComponent();

            if (!System.IO.File.Exists("tmp"))
            {
                System.IO.Directory.CreateDirectory("tmp");
            }

            ScreenshotPanel_Image.Image = global::BotMaker.Properties.Resources.NotSelected;
            ScreenshotPanel_Image.SizeMode = PictureBoxSizeMode.CenterImage;

        }

        private void Create_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "BotMakerFile(*.dbtm) | *.dbtm";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".dbtm"; //Задаем расширение по умолчанию
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтвердение сохранения информации.
            {
                path = new FileInfo(saveFileDialog1.FileName).Directory.FullName;
                using (File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                {
                    fileStream = new FileWork(saveFileDialog1.FileName, memory_event, memory_screenshot_path, memory_variables);
                    if (!System.IO.File.Exists(path + "\\screenshots"))
                    {
                        System.IO.Directory.CreateDirectory(path + "\\screenshots");
                    }
                }
                HideStartMenu();
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                path = Path.GetDirectoryName(openFileDialog1.FileName);
                openFileDialog1.Filter = "BotMakerFile (*.dbtm)|*.dbtm"; 
                fileStream = new FileWork(openFileDialog1.FileName, memory_event, memory_screenshot_path, memory_variables); //получаем наименование файл и путь к нему.
                fileStream.ReadFromFile();
                HideStartMenu();
                ReDraw();
            }
        }

        private void HideStartMenu()
        {
            //hide menu panel
            WelcomePanel.Visible = false;

            //show panels
            ScreenshotPanel.Visible = true;
            ToolsPanel.Visible = true;
            SidePanel.Visible = true;
            TimelinePanel.Visible = true;
            InfoPanel.Visible = true;
        }

        private void setVariable()
        {
            memory_variables.addToDictionary("$PathToTMP", System.IO.Directory.GetCurrentDirectory() + "\\tmp\\scr_tmp.png");
            memory_variables.addToDictionary("$ActualX", "0");
            memory_variables.addToDictionary("$ActualY", "0");
        }

        private void ReDraw()
        {
            TimelinePanel.Controls.Clear();
            ToolsPanel_DropDown_Screenshot.Items.Clear();

            setVariable();

            int index = 0;

            foreach (String item in memory_screenshot_path.getList())
            {
                ToolsPanel_DropDown_Screenshot.Items.Add(item);
                memory_variables.addToDictionary("$IMG" + index, (path + "\\screenshots\\scr_" + index + ".png"));
                index++;
            }

            if (memory_event.getListLenght() > 0)
            {
                foreach (BotEvent item in memory_event.getList())
                {
                    Button b = new Button();

                    b.Text = (item.getName());
                    b.Click += new System.EventHandler(this.setEvent);

                    //styles for button
                    b.BackColor = Color.FromArgb(124, 170, 244);
                    b.FlatStyle = FlatStyle.Flat;
                    b.Height = 30;
                    b.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));

                    var margin = b.Margin;
                    margin.Left = 0;
                    margin.Right = 0;
                    b.Margin = margin;

                    TimelinePanel.Controls.Add(b);
                }
                
            }
            
        }

        private void ToolsPanel_Button_Screenshot_Click(object sender, EventArgs e)
        {
            this.Hide();

            Bitmap printscreen = new Bitmap
            (SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);

            string name = "scr_" + memory_screenshot_path.getListLenght();
            printscreen.Save(path + "/screenshots/" + name + ".png", System.Drawing.Imaging.ImageFormat.Png);

            this.Show();
            
            memory_screenshot_path.addToList(name);
            ReDraw();
        }

        private void ToolsPanel_Button_Play_Click(object sender, EventArgs e)
        {

            Thread myThread = new Thread(Simulate);
            this.Hide();
            myThread.Start();
            myThread.Join();
            this.Show();
            
        }

        private void ScreenshotPanel_Image_Click(object sender, MouseEventArgs e)
        {

            int x = (int)((double)Screen.PrimaryScreen.WorkingArea.Width / ScreenshotPanel_Image.Width * e.Location.X);
            int y = (int)((double)Screen.PrimaryScreen.WorkingArea.Height / ScreenshotPanel_Image.Height * e.Location.Y);

            SetEventForm f = new SetEventForm(this, fileStream, x, y);
            f.ShowDialog();

            ReDraw();
        }

        private void TakeScreenshot_tmp()
        {

            Bitmap printscreen = new Bitmap
            (SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);

            printscreen.Save(System.IO.Directory.GetCurrentDirectory() + "\\tmp\\scr_tmp.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private string GetValue(string obj)
        {

            if (obj != "")
            {
                bool if_num = int.TryParse(obj, out int num);

                if (if_num)
                    return num.ToString();
                else
                {
                    if (memory_variables.getDictionary().TryGetValue(obj, out object a))
                        return a.ToString();
                    else
                        return obj;
                }  
            }
            else
                return "0";
        }

        private void Simulate()
        {
            for (int loop = 0; loop < int.Parse(ProjectSettings_TextField_Count.Text); loop++)
            {

                foreach (BotEvent bot in memory_event.getList())
                {
                    actual_botevent_running = bot;

                    memory_variables.getDictionary()["$ActualX"] = Cursor.Position.X.ToString();
                    memory_variables.getDictionary()["$ActualY"] = Cursor.Position.Y.ToString();

                    TakeScreenshot_tmp();

                    if (bot.getType() == "change_variable_value")
                    {
                        if (memory_variables.getDictionary().ContainsKey(bot.getDictionary().First().Value))
                        {
                            try
                            {
                                memory_variables.getDictionary()[bot.getDictionary().First().Value] = 
                                int.Parse(memory_variables.getDictionary()[bot.getDictionary().First().Value].ToString()) + int.Parse(GetValue(bot.getDictionary().ElementAt(1).Value));
                            }
                            catch
                            {
                                MessageBox.Show("Trying to change string value to integer");
                            }

                        }

                        continue;
                    }

                    string procces_path = "lib\\" + bot.getType() + ".exe";
                    string procces_args = "";

                    foreach (KeyValuePair<string, string> item in bot.getDictionary())
                    {
                        procces_args += GetValue(item.Value) + " ";
                    }

                    Console.WriteLine(procces_path + " " + procces_args);

                    Process proc = new Process();

                    proc.StartInfo.FileName = procces_path;
                    proc.StartInfo.Arguments = procces_args;
                    proc.StartInfo.UseShellExecute = false;

                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.RedirectStandardError = true;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.EnableRaisingEvents = true;
                    proc.OutputDataReceived += new DataReceivedEventHandler(OnDataReceived);
                    proc.Start();
                    proc.BeginErrorReadLine();
                    proc.BeginOutputReadLine();
                    proc.WaitForExit();

                }
                
            }           
        }

        private void OnDataReceived(object sender, DataReceivedEventArgs e)
        {
            
            if (e.Data != null)
            {
                if (memory_variables.getDictionary().ContainsKey("$" + actual_botevent_running.getName()))
                {
                    memory_variables.getDictionary()["$" + actual_botevent_running.getName()] = e.Data;
                }                
            }
        }

        private void ToolsPanel_DropDown_Screenshot_SelectedIndexChanged(object sender, EventArgs e)
        {
            string local_path = path + "\\screenshots\\" + memory_screenshot_path.getList()[ToolsPanel_DropDown_Screenshot.SelectedIndex] + ".png";
            ScreenshotPanel_Image.Image = Image.FromFile(local_path);
            ScreenshotPanel_Image.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void InfoPanel_FeedBack_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dobyvatel.000webhostapp.com/feedback.html");
        }

        private void ToolsPanel_Button_Add_Click(object sender, EventArgs e)
        {
            SetEventForm f = new SetEventForm(this, fileStream);
            f.ShowDialog();

            ReDraw();
            
        }

        private void setEvent(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            foreach(BotEvent item in memory_event.getList())
            {
                if(item.getName() == b.Text)
                {
                    ChangePropertyEventForm f = new ChangePropertyEventForm(item, memory_event);
                    f.ShowDialog();
                    break;
                }
            }

            ReDraw();
        }

        private void ToolsPanel_Button_Variable_Click(object sender, EventArgs e)
        {
            VariableForm f = new VariableForm(memory_variables);
            f.ShowDialog();
        }

        //getters and setters


        public static string getPath()
        {
            return path;
        }

        public Memory getEventMemory()
        {
            return memory_event;
        }

        public Memory getScreenshotMemory()
        {
            return memory_screenshot_path;
        }

        public Memory getVariableMemory()
        {
            return memory_variables;
        }

        private void ToolsPanel_Button_Build_Click(object sender, EventArgs e)
        {
            fileStream.WriteToFile();
        }
    }

   
}
