using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5_GOST_89
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] encrByteData, byte_Key, deEcrByteData;

        private void Random_genetate_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            string key=null;
            for (int i = 0; i < 32; i++)
            {
                key += Convert.ToString(rd.Next(0, 10));
            }
            text_key.Text = key;
        }

        private void DeEncrypt_Click(object sender, EventArgs e)
        {
            DeEncryptor DeEncrypt;
            int count_t = text_Encript.Text.Length;
            if (text_Encript.Text == "" || count_t%2!=0)
                MessageBox.Show("Сообщение для расшифровки отсутствует/введенно некорректно!");
            else
            {
                try
                {
                    byte[] DeEncryptData = Encoding.Default.GetBytes(text_Encript.Text);
                    if ((byte_Key == null) || (byte_Key.Length != 32))
                        MessageBox.Show("Введдите 256-битный ключ!!!");
                    else
                    {
                        DeEncrypt = new DeEncryptor(DeEncryptData, byte_Key);
                        deEcrByteData = DeEncrypt.GetDeEncryptFile;
                        text_deEncrypt.Text = Encoding.Default.GetString(deEcrByteData);
                    }
                }
                catch(Exception ex){MessageBox.Show("Сообщение для расшифровки введенно некорректно!\n"+ ex.Message);}
            }
        }

        private void btn_encr_Click(object sender, EventArgs e)
        {
            Encryptor encrypt;

            if (text_Sms.Text == "")
                MessageBox.Show("Введите данные для шифрования!!!");
            else
            {
                byte[] Data = Encoding.Default.GetBytes(text_Sms.Text);
                byte_Key = Encoding.Default.GetBytes(text_key.Text);
                if ((byte_Key == null) || (byte_Key.Length != 32))
                    MessageBox.Show("Введдите 256-битный ключ!!!");
                else
                {
                    encrypt = new Encryptor(Data, byte_Key);
                    encrByteData = encrypt.GetEncryptFile;
                    text_Encript.Text = Encoding.Default.GetString(encrByteData);
                }
            }
        }
    }
}
