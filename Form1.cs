using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4D1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String UserName = textBox1.Text;
            String PassWord = textBox2.Text;
            string message = "";

            switch (UserName)
            {
                case "BilgeAdam":
                        switch(PassWord)
                    {
                        case "1234":
                            message = "Tebrikler";
                            break;
                        default:
                            message = "Kullanıcı doğru, Şifre Yanlış";
                            break;
                    }
                    break;

                default:
                    message = "Kullanıcı adı yanlış, Şifreye Bakmıyoruz";
                    break;
            }

            MessageBox.Show(message);
        }
    }
}
