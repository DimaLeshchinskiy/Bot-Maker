using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotMaker
{
    public class BotEvent
    {
        private int list_position;
        private string name;
        private string type;

        private Dictionary<String, String> properties = new Dictionary<String, String>();


        private const string pattern_middle = ";";

        public BotEvent()
        {
        }

        public string ToPrint()
        {
            string str_args = "";

            foreach (KeyValuePair<string, string> item in getDictionary())
            {
                str_args += pattern_middle + item.Key + pattern_middle + item.Value;
            }

            return "BOT" + pattern_middle +
                   getName() + pattern_middle +
                   getType() + str_args;
        }


        //getters
        public string getName()
        {
            return name;
        }

        public string getType()
        {
            return type;
        }

        //setters
        public void setName(string name)
        {
            this.name = name;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        //dictionary
        public void addToDictionary(string obj, string obj2)
        {
            properties.Add(obj, obj2);
        }

        public Dictionary<string, string> getDictionary()
        {
            return properties;
        }

        public int getDictionaryLength()
        {
            return properties.Count;
        }

    }
}
