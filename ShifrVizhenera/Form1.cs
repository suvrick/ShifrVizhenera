using System.Windows.Forms;

namespace ShifrVizhenera
{
    public partial class Form1 : Form
    {
        private char[] chars = new char[]{};

        private char[] UpperChars = new char[] {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж',
            'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О',
            'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц',
            'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю',
            'Я',
        }; 

        private char[] LowerChars = new char[] {
            'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж',
            'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о',
            'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц',
            'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю',
            'я',
        }; 

        private char[] DigitlChars = new char[] {
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
        }; 

        private char[] DoteChars = new char[] {
            ' ', '.', ',', '!', '?', '-', '_', '@', '%'
        };

        private int Count => chars.Length;

        private bool Invalid => CheckIncorrectInputText(textBox1.Text) || CheckIncorrectInputText(textBox2.Text) || CheckIncorrectInputText(textBox3.Text);

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Зашифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox2.Text;

            string keyword = textBox1.Text;

            textBox3.Text = Encode(input, keyword);
        }

        /// <summary>
        /// Разшифровть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;

            string input = textBox3.Text;

            textBox2.Text = Decode(input, keyword);
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            label1.Visible = Invalid;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (Invalid) return;

            var keywordEmpty = string.IsNullOrEmpty(textBox1.Text);

            var b = !string.IsNullOrEmpty(textBox2.Text);

            var c = !string.IsNullOrEmpty(textBox3.Text);

            string input = ((Control)sender).Text;

            if (keywordEmpty)
            {
                button1.Enabled = button2.Enabled = false;

                return;
            }

            button1.Enabled = b;

            button2.Enabled = c;
        }

        private string Encode(string message, string keyword)
        {
            string result = "";

            int pointer = 0;

            if (checkBox1.Checked && !checkBox2.Checked)
            {
                keyword = keyword.ToUpper();

                message = message.ToUpper();
            }

            for (int i = 0; i < message.Length; i++)
            {
                char symbol = message[i];

                int a = Array.IndexOf(chars, symbol);

                int b = Array.IndexOf(chars, keyword[pointer]);

                int c = (a + b) % Count;

                result = result + chars[c];

                pointer++;

                if ((pointer + 1) == keyword.Length)
                {
                    pointer = 0;
                }
            }

            return result;
        }

        private string Decode(string message, string keyword)
        {
            string result = "";

            int pointer = 0;

            if (checkBox1.Checked && !checkBox2.Checked)
            {
                keyword = keyword.ToUpper();

                message = message.ToUpper();
            }

            for (int i = 0; i < message.Length; i++)
            {
                char symbol = message[i];

                int A = Array.IndexOf(chars, symbol) + Count;

                int B = Array.IndexOf(chars, keyword[pointer]);

                int index = (A - B) % Count;

                result = result + chars[index];

                pointer++;

                if ((pointer + 1) == keyword.Length)
                {
                    pointer = 0;
                }
            }

            return result;
        }

        //Проверяем на валидность переданную строку.
        // Возвращаем TRUE если в веденном тексте есть неподдерживаемые символы
        private bool CheckIncorrectInputText(string input)
        {
            return input.Any(x => !chars.Contains(x));
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            var list = new List<char>();

            bool useUpper = checkBox1.Checked;

            bool useLower = checkBox2.Checked;

            bool useDigitl = checkBox3.Checked;
            
            bool useDote = checkBox4.Checked;

            if (useUpper) list.AddRange(UpperChars);

            if (useLower) list.AddRange(LowerChars);

            if (useDigitl) list.AddRange(DigitlChars);

            if (useDote) list.AddRange(DoteChars);

            chars = list.ToArray();

            textBox1_Validating(new object(), new System.ComponentModel.CancelEventArgs());
        }
    }
}