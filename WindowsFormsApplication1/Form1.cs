using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
            
        }

        

        public string textBox1_TextChanged(object sender, EventArgs e)
        {
            
            TextBox objTextBox = (TextBox)sender;
            string insertText = objTextBox.Text;
            return insertText;
        }

        

        public string comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            return selected;

        }

        public void button1_Click(object sender, EventArgs e)
        {

            string insertText;
            string selected;
            string result;
            int number;
            number = Convert.ToInt32(insertText);
            if (selected == "English")
            {
                result = number.ToWords(culture: English);
            }
             if (selected == "German")
             {
                 result = number.ToWords(culture: German);
             }
             if (selected == "Spanish")
             {
                 result = number.ToWords(culture: Spanish);
             }
             if (selected == "French")
             {
                 result = number.ToWords(culture: French);
             }
             else
             {
                 result = number.ToWords(culture: Romanian);
             }
            MessageBox.Show( result , "The number is:",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}

