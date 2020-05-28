using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class History
    {
        List<string> history = new List<string>();
        public void addToHistory(List<int> list, int final, string input)
        {
            string x = $"{input} = ";
            for (int i = 0; i < list.Count; i++)
            {
                if (i < list.Count - 1)
                {
                    x += list[i] + " + ";
                }
                else
                {
                    x += list[i] + " = " + final;
                }
            }
            history.Add(x);
        }

        public string GetHistory
        {
            get {
                string end = "";
                foreach (var item in history)
                {
                    end += $"{item}\n";
                }
                return end;
            }
        }
    }
}
