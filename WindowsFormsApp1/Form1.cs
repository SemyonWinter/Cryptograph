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
    public partial class Form1 : Form
    {
        char[] rus1 = {'А', 'Б','В','Г','Д','Е','Ж','З','И','Й','К','Л','М',
            'Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я'};
        char[] rus2 = { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о',
            'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
        char[] angl1 = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
            'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', };
        char[] angl2 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };

        public class ScytaleCipher
        {
            public string Encrypt(string text, int colum)
            {
               

                var d = (text.Length - 1) / colum + 1;
                var result = "";

                for (int i = 0; i < colum; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        if((i + colum * j)<text.Length)             
                        result += text[i + colum * j].ToString();
                    }
                }
               

                return result;
            }

            public string Decrypt(string text, int colum)
            {
                var d = (text.Length - 1) / colum + 1;
                var symbols = new char[text.Length];
                int index = 0;
                for (int i = 0; i < colum; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        if ((i + colum * j)<text.Length)
                        {
                            symbols[i + colum * j] = text[index];
                            index++;
                        }
                        
                    }
                }

                return string.Join("", symbols);
            }
        }


        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            int a;
            decrypt_text.Text = "";
            char[] sr = new char[encrypt_text.Text.Length];
            for (int i = 0; i < encrypt_text.Text.Length; i++)
            {
                if (Array.IndexOf(rus1, encrypt_text.Text[i]) != -1)
                {
                    a = Array.IndexOf(rus1, encrypt_text.Text[i]);
                    sr[i] = rus1[31 - a];
                }
                else if (Array.IndexOf(rus2, encrypt_text.Text[i]) != -1)
                {
                    a = Array.IndexOf(rus2, encrypt_text.Text[i]);
                    sr[i] = rus2[31 - a];
                }
                else if (Array.IndexOf(angl1, encrypt_text.Text[i]) != -1)
                {
                    a = Array.IndexOf(angl1, encrypt_text.Text[i]);
                    sr[i] = angl1[25 - a];
                }
                else if (Array.IndexOf(angl2, encrypt_text.Text[i]) != -1)
                {
                    a = Array.IndexOf(angl2, encrypt_text.Text[i]);
                    sr[i] = angl2[25 -a];
                }
                else
                {
                    sr[i] = encrypt_text.Text[i];
                }
                decrypt_text.Text = decrypt_text.Text + sr[i];
            }


        }
    

        private void decrypt_Click(object sender, EventArgs e)
        {
        int a;
        decrypt_text.Text = "";
            char[] sr = new char[encrypt_text.Text.Length];
            for (int i = 0; i < encrypt_text.Text.Length; i++)
        {
            if (Array.IndexOf(rus1, encrypt_text.Text[i]) != -1)
            {
                a = Array.IndexOf(rus1, encrypt_text.Text[i]);
                sr[i] = rus1[31 - a];
            }
            else if (Array.IndexOf(rus2, encrypt_text.Text[i]) != -1)
            {
                a = Array.IndexOf(rus2, encrypt_text.Text[i]);
                sr[i] = rus2[31 - a];
            }
            else if (Array.IndexOf(angl1, encrypt_text.Text[i]) != -1)
            {
                a = Array.IndexOf(angl1, encrypt_text.Text[i]);
                sr[i] = angl1[25 - a];
            }
            else if (Array.IndexOf(angl2, encrypt_text.Text[i]) != -1)
            {
                a = Array.IndexOf(angl2, encrypt_text.Text[i]);
                sr[i] = angl2[25 - a];
            }
            else
            {
                sr[i] = encrypt_text.Text[i];
            }
                decrypt_text.Text = decrypt_text.Text + sr[i];
        }


    }


        private void encrypt_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void decrypt_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void origintext_TextChanged(object sender, EventArgs e)
        {

        }

        private void outText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var scytale = new ScytaleCipher();
            var message = origintext.Text;
            if (diametr.Text == "")
            {
                outText.Text = "Ошибка! Неверные данные";
            }
            else
            {
                try
                {
                    var diameter = Convert.ToInt32(diametr.Text);
                }
                catch (System.FormatException)
                {
                    outText.Text =  "Вы ввели символ! Пожалуйста,введите цифрy";
                    diametr.Text = "0";

                }
                int newdiametr = Convert.ToInt32(diametr.Text);
                if ((newdiametr <= 0)||(newdiametr>=origintext.Text.Length))
                { 
                    outText.Text = "Ошибка! Неверные данные";
                }
                else
                {
                    var encText = scytale.Encrypt(message, newdiametr);
                    outText.Text = encText;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var scytale = new ScytaleCipher();
            var message = origintext.Text;
            if (diametr.Text == "")
            {
                outText.Text = "Ошибка! Неверные данные";
            }
            else
            {
                try
                {
                    var diameter = Convert.ToInt32(diametr.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
                    diametr.Text = "0";

                }
                int newdiametr = Convert.ToInt32(diametr.Text);
                if ((newdiametr <= 0) || (newdiametr >= origintext.Text.Length))
                {
                    outText.Text = "Ошибка! Неверные данные";
                }
                else
                {
                    var decText = scytale.Decrypt(message, newdiametr);
                    outText.Text = decText;
                }
            }
        }

        private void diametr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cezar_enc_Click(object sender, EventArgs e)
        {
            if (KeyCezar.Text == "")
            {
                outCezar.Text = "Ошибка! Введите ключ";
            }
            else
            {
                try
                {
                    var a = Convert.ToInt32(KeyCezar.Text);
                }
                catch (System.FormatException)
                {
                    outCezar.Text = "Вы ввели символ! Пожалуйста,введите цифрy";
                    KeyCezar.Text= "0";

                }
                var newa = Convert.ToInt32(KeyCezar.Text);
                if (newa < 0)
                {
                    outCezar.Text = "Ошибка! Неверные данные ";
                }
                else
                {
                    outCezar.Text = "";
                    char[] Czenc = new char[originCezar.Text.Length];
                    for (int i = 0; i < originCezar.Text.Length; i++)
                    {
                        if (Array.IndexOf(rus1, originCezar.Text[i]) != -1)
                        {
                            Czenc[i] = rus1[(Array.IndexOf(rus1, originCezar.Text[i]) +newa) % rus1.Length];
                        }
                        else if (Array.IndexOf(rus2, originCezar.Text[i]) != -1)
                        {
                            Czenc[i] = rus2[(Array.IndexOf(rus2, originCezar.Text[i]) + newa) % rus2.Length];
                        }
                        else if (Array.IndexOf(angl1, originCezar.Text[i]) != -1)
                        {
                            Czenc[i] = angl1[(Array.IndexOf(angl1, originCezar.Text[i]) + newa) % angl1.Length];
                        }
                        else if (Array.IndexOf(angl2, originCezar.Text[i]) != -1)
                        {
                            Czenc[i] = angl2[(Array.IndexOf(angl2, originCezar.Text[i]) + newa) % angl2.Length];
                        }
                        else
                        {
                            Czenc[i] = originCezar.Text[i];
                        }
                        outCezar.Text = outCezar.Text + Czenc[i];
                    }
                }
            }
        }

        private void Cezarus_dec_Click(object sender, EventArgs e)
        {
            if (KeyCezar.Text == "")
            {
                outCezar.Text = "Ошибка! Введите ключ";
            }
            else
            {
                try
                {
                    var a = Convert.ToInt32(KeyCezar.Text);
                }
                catch (System.FormatException)
                {
                    outCezar.Text = "Вы ввели символ! Пожалуйста,введите цифрy";
                    KeyCezar.Text = "0";

                }
                var newa = Convert.ToInt32(KeyCezar.Text);
                if (newa < 0)
                {
                    outCezar.Text = "Ошибка ключ < 0! ";
                }
                else
                {
                    outCezar.Text = "";
                    char[] Czdec = new char[originCezar.Text.Length];
                    //var Q = originCezar.Text.Length;
                    for (int i = 0; i < originCezar.Text.Length; i++)
                    {
                        if (Array.IndexOf(rus1, originCezar.Text[i]) != -1)
                        {
                            // a = Array.IndexOf(rus1, originCezar.Text[i]);
                            Czdec[i] = rus1[(Array.IndexOf(rus1, originCezar.Text[i]) - newa + rus1.Length) % rus1.Length];
                        }
                        else if (Array.IndexOf(rus2, originCezar.Text[i]) != -1)
                        {
                            // a = Array.IndexOf(rus2, originCezar.Text[i]);
                            Czdec[i] = rus2[(Array.IndexOf(rus2, originCezar.Text[i]) - newa + rus2.Length) % rus2.Length];
                        }
                        else if (Array.IndexOf(angl1, originCezar.Text[i]) != -1)
                        {
                            //  a = Array.IndexOf(angl1, originCezar.Text[i]);
                            Czdec[i] = angl1[(Array.IndexOf(angl1, originCezar.Text[i]) - newa + angl1.Length) % angl1.Length];
                        }
                        else if (Array.IndexOf(angl2, originCezar.Text[i]) != -1)
                        {
                            //  a = Array.IndexOf(angl2, originCezar.Text[i]);
                            Czdec[i] = angl2[(Array.IndexOf(angl2, originCezar.Text[i]) - newa + angl2.Length) % angl2.Length];
                        }
                        else
                        {
                            Czdec[i] = originCezar.Text[i];
                        }
                        outCezar.Text = outCezar.Text + Czdec[i];
                    }
                }
            }
        }

        private void originCezar_TextChanged(object sender, EventArgs e)
        {

        }

        private void outCezar_TextChanged(object sender, EventArgs e)
        {

        }

        private void KeyCezar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
