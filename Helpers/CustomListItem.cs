using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DefaultMIx64.Helpers
{
    public class CustomListItem
    {
        public string Text { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string Text4 { get; set; }
        public string Text5 { get; set; }
        public object Value { get; set; }

        public CustomListItem()
        {
            this.Text = string.Empty;
        }

        public CustomListItem(string text, string text2, string text3, string text4,string text5, object value)
        {
            Text = text;
            Text2 = text2;
            Text3 = text3;
            Text4 = text4;
            Text5 = text5;
            Value = value;
        }

        public override string ToString()
        {
            return Text + " " + Text2 + " " + Text3;
        }
        
        
    }
}
