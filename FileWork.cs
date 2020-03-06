using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotMaker
{
    public class FileWork
    {
        private string path_to_project;
        private Memory memory_event;
        private Memory memory_screenshot_path;
        private Memory memory_variables;

        public FileWork(String path, Memory memory_event, Memory memory_screenshot_path, Memory memory_variables)
        {
            this.path_to_project = path;
            this.memory_event = memory_event;
            this.memory_screenshot_path = memory_screenshot_path;
            this.memory_variables = memory_variables;
        }

        public void WriteToFile()
        {
            using (System.IO.StreamWriter writetext = new System.IO.StreamWriter(path_to_project))
            {
                foreach (BotEvent e in memory_event.getList())
                {
                    writetext.WriteLine(e.ToPrint());
                }

                writetext.WriteLine();

                foreach (string path in memory_screenshot_path.getList())
                {
                    writetext.WriteLine("SCREENSHOT;" + path);
                }

                writetext.WriteLine();

                foreach (KeyValuePair<object, object> item in memory_variables.getDictionary())
                {
                    writetext.WriteLine("VARIABLE;" + item.Key + ";" + item.Value);
                }

                writetext.WriteLine();

            }

        }

        public void ReadFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(path_to_project);

            foreach (string line in lines)
            {
                string[] loc = line.Split(';');

                if (string.Equals(loc[0], "BOT"))
                {
                    BotEvent bot = new BotEvent();
                    bot.setName(loc[1]);
                    bot.setType(loc[2]);

                    for(int i = 3; i < loc.Length;)
                    {
                        bot.addToDictionary(loc[i], loc[i + 1]);
                        i += 2;
                    }

                    memory_event.addToList(bot);
                    continue;
                }
                if (string.Equals(loc[0], "SCREENSHOT"))
                {
                    memory_screenshot_path.addToList(loc[1]);
                    continue;
                }
                if (string.Equals(loc[0], "VARIABLE"))
                {
                    memory_variables.addToDictionary(loc[1], loc[2]);
                    continue;
                }

            }
        }

        public  Dictionary<String, String> LoadPressetProperty(string presset_name)
        {
            Dictionary<String, String> d = new Dictionary<String, String>();

            string[] lines = System.IO.File.ReadAllLines("lib\\" + presset_name + ".pbt");

            foreach (string line in lines)
            {
                string[] loc = line.Split(':');

                d.Add(loc[0], loc[1]);

            }

            return d;
        }

    }
}
