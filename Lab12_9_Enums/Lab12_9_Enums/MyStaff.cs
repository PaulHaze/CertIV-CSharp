using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_9_Enums
{
    public class MyStaff
    {
        public enum Titles
        {
            Mr, Ms, Mrs, Dr
        }

        private string name;
        private string title;

        public string Name { get => name; set => name = value; }
        public string Title { get => title; set => title = value; }



        // constructor

        public MyStaff(string name, string title)
        {
            this.name = name;
            this.Title = title;

        }

        public string ReturnInfo()
        {
            string msg = "";
            msg += $"Name: {name}\n";
            msg += $"Title: {Title}\n";
            msg += "\n";
            return msg;
        }
    }
}
