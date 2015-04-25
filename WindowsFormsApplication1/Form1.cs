using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            languageComboBox.SelectedIndex = 0;
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            //validate the Input Number
            if (String.IsNullOrWhiteSpace(numberTextbox.Text))
            {
                MessageBox.Show("The input number must have a value!");
                numberTextbox.Focus();
                return;
            }

            //translate the number to the selected language
            int numberToTranslate = Int32.Parse(numberTextbox.Text);
            string selectedLanguage = languageComboBox.Text;
            CultureInfo selectedCulture = null;

            switch (selectedLanguage)
            {
                case "English":
                    selectedCulture = new CultureInfo("en");
                    break;
                case "German":
                    selectedCulture = new CultureInfo("de");
                    break;
                case "Spanish":
                    selectedCulture = new CultureInfo("es");
                    break;
                case "French":
                    selectedCulture = new CultureInfo("fr");
                    break;
            }
            string result = numberToTranslate.ToWords(selectedCulture);

            //show the result
            MessageBox.Show(result, "The number is:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

