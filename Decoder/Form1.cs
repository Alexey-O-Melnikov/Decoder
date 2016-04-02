using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decoder
{
    public partial class Form1 : Form
    {
        char[] ciphertext;
        char[] decryptedText;
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadOnlyFalseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_decryptedText.ReadOnly = false;
        }

        private void GoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validation();

            List<Letter> alphabetEcrypted = new List<Letter>();
            int countNoValidateSymbol = 0;

            for (int i = 0; i < ciphertext.Length; i++)
            {
                //если буква не английская и не цифра, смотрим следующую
                if ( (ciphertext[i] < 48 || ciphertext[i] > 57) && (ciphertext[i] < 65 || ciphertext[i] > 122))
                {
                    countNoValidateSymbol++;
                    continue;
                }

                //если символ есть в словаре, увеличиваем его количество на 1
                if (alphabetEcrypted.Exists(x => x.Symbol == ciphertext[i]))
                    alphabetEcrypted.Find(x => x.Symbol == ciphertext[i]).CountInText++;
                //если нет добавляем в словарь новый символ
                else
                    alphabetEcrypted.Add(new Letter(ciphertext[i], 1));
            }

            //если текст не состоит из английских символов и цифр больше чем на 90%, то ошибка
            if ((double)countNoValidateSymbol / ciphertext.Length > 0.3)
            {
                MessageBox.Show("Текст должен состоять преимущественно из английских символов и цифр", "Error");
                return;
            }

            //подсчет частоты
            alphabetEcrypted.ForEach(x => x.Chastota = (double)x.CountInText / ciphertext.Length);
            //сортировка по частоте
            alphabetEcrypted.Sort((l1, l2) => l2.Chastota.CompareTo(l1.Chastota));

            List<Letter> alphabetRus = CreateAlphabetRus();
            SearchCoincidences(alphabetEcrypted, alphabetRus);
            //вывод информации
            textBox_decryptedText.Text = new String(decryptedText);
            textBox_Chastotiy.Text = "";
            alphabetEcrypted.ForEach(letter => 
                textBox_Chastotiy.Text += String.Format("{0} = {1:0.0000}\r\n", letter.Symbol, letter.Chastota));
        }

        private void SearchCoincidences(List<Letter> alphabetEcrypted, List<Letter> alphabetRus)
        {
            decryptedText = new char[ciphertext.Length];

            for (int i = 0; i < decryptedText.Length; i++)
            {
                //находим какое место в словаре занимает символ
                int index = alphabetEcrypted.FindIndex(x => x.Symbol == ciphertext[i]);
                //записываем русскую букву соответствующей позиции 
                decryptedText[i] = index == -1 ? ciphertext[i] : alphabetRus[index].Symbol;
            }

        }

        private void Validation()
        {
            string ciphertextStr = textBox_ciphertext.Text;
            ciphertext = ciphertextStr
                .ToLower()
                .ToCharArray();

            if (ciphertext.Length == 0)
                MessageBox.Show("Введите текст", "Error");
        }

        private List<Letter> CreateAlphabetRus()
        {
            List<Letter> alphabet = new List<Letter>() {
                new Letter ( 'а', 0.062 ),
                new Letter ( 'б', 0.062 ),
                new Letter ( 'в', 0.048 ),
                new Letter ( 'г', 0.062 ),
                new Letter ( 'д', 0.025 ),
                new Letter ( 'е', 0.072 ),
                //new Letter ( 'ё', 0.072 ),
                new Letter ( 'ж', 0.007 ),
                new Letter ( 'з', 0.016 ),
                new Letter ( 'и', 0.062 ),
                new Letter ( 'й', 0.010 ),
                new Letter ( 'к', 0.028 ),
                new Letter ( 'л', 0.035 ),
                new Letter ( 'м', 0.026 ),
                new Letter ( 'н', 0.053 ),
                new Letter ( 'о', 0.09 ),
                new Letter ( 'п', 0.023 ),
                new Letter ( 'р', 0.04 ),
                new Letter ( 'с', 0.045 ),
                new Letter ( 'т', 0.053 ),
                new Letter ( 'у', 0.021 ),
                new Letter ( 'ф', 0.002 ),
                new Letter ( 'х', 0.009 ),
                new Letter ( 'ц', 0.004 ),
                new Letter ( 'ч', 0.062 ),
                new Letter ( 'ш', 0.006 ),
                new Letter ( 'щ', 0.062 ),
                new Letter ( 'ь', 0.014 ),
                new Letter ( 'ы', 0.016 ),
                new Letter ( 'ъ', 0.014 ),
                new Letter ( 'э', 0.003 ),
                new Letter ( 'ю', 0.006 ),
                new Letter ( 'я', 0.018 ),
            };

            alphabet.Sort((l1, l2) => l2.Chastota.CompareTo(l1.Chastota));
            return alphabet;
        }
    }
}
