using CaesarCipherApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            CaesarCipher cipher = new CaesarCipher();
            int shift = (int)numericUpDownShift.Value;
            string inputText = textBoxInput.Text;

            string encryptedText = cipher.Encrypt(inputText, shift);
            textBoxOutput.Text = encryptedText;
        }
    }
}
