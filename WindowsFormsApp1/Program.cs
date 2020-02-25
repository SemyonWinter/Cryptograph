using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public class Atbash
        {
            //алфавит языка
            private const string alphabet = "abcdefghijklmnopqrstuvwxyz";

            //метод для переворачивания строки
            private string Reverse(string inputText)
            {
                //переменная для хранения результата
                var reversedText = string.Empty;
                foreach (var s in inputText)
                {
                    //добавляем символ в начало строки
                    reversedText = s + reversedText;
                }

                return reversedText;
            }
            private string EncryptDecrypt(string text, string symbols, string cipher)
            {
                //переводим текст в нижний регистр
                text = text.ToLower();

                var outputText = string.Empty;
                for (var i = 0; i < text.Length; i++)
                {
                    //поиск позиции символа в строке алфавита
                    var index = symbols.IndexOf(text[i]);
                    if (index >= 0)
                    {
                        //замена символа на шифр
                        outputText += cipher[index].ToString();
                    }
                }

                return outputText;
            }
            public string EncryptText(string plainText)
            {
                return EncryptDecrypt(plainText, alphabet, Reverse(alphabet));
            }

            //расшифровка текста
            public string DecryptText(string encryptedText)
            {
                return EncryptDecrypt(encryptedText, Reverse(alphabet), alphabet);
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
