using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BotMaker
{
    public class Memory
    {
        private ArrayList list = new ArrayList();
        private Dictionary<object, object> dictionary = new Dictionary<object, object>();

        //work with list
        public void addToList(BotEvent bot)
        {
            list.Add(bot);
        }

        public void addToList(Object obj)
        {
            list.Add(obj);
        }

        public ArrayList getList()
        {
            return list;
        }

        public int getListLenght()
        {
            return list.Count;
        }

        public void deleteItemFromList(int index)
        {
            list.RemoveAt(index);
        }

        //work with ditionary

        public void addToDictionary(Object obj, Object obj2)
        {
            if(!dictionary.ContainsKey(obj.ToString()))
                dictionary.Add(obj, obj2);
        }

        public Dictionary<Object, Object> getDictionary()
        {
            return dictionary;
        }

        public int getDictionaryLength()
        {
            return dictionary.Count;
        }

        public void deleteItemFromDictionary(Object index)
        {
            dictionary.Remove(index);
        }

        public void clearAllDictionary()
        {
            dictionary.Clear();
        }
    }
}
