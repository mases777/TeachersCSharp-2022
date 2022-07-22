namespace Exams04
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private string SignTwoWithWord(int second)
        {
            string result = "";
            switch (second)
            {
                case 1: result = "едно"; break;
                case 2: result = "две"; break;
                case 3: result = "три"; break;
                case 4: result = "четири"; break;
                case 5: result = "пет"; break;
                case 6: result = "шест"; break;
                case 7: result = "седем"; break;
                case 8: result = "осем"; break;
                case 9: result = "девет"; break;
            }
            return result;
        }
        private string SignOneWithWord(int first)
        {
            string result = "";
            switch (first)
            {                
                case 2: result = "двадесет"; break;
                case 3: result = "тридесет"; break;
                case 4: result = "четиридесет"; break;
                case 5: result = "петдесет"; break;
                case 6: result = "шестдесет"; break;
                case 7: result = "седемдесет"; break;
                case 8: result = "осемдесет"; break;
                case 9: result = "деветдесет"; break;
            }
            return result;
        }

        private void btnBringOut_Click(object sender, EventArgs e)
        {
            string resultLabel = "";
            int num = int.Parse(textBox1.Text);
            if (num >= 0 && num <= 99)
            {
                int second = num % 10;
                int first = num / 10;
                if (first == 0 && second == 0)
                {
                    resultLabel = "нула";
                }
                else if (first > 1)
                {
                    if (second == 0)
                    {
                        resultLabel = SignOneWithWord(first);
                    }
                    else
                    {
                        resultLabel = SignOneWithWord(first) + " и " + SignTwoWithWord(second);
                    }
                }
                else if (first == 1)
                {
                    switch (second)
                    {
                        case 0: resultLabel = "десет"; break;
                        case 1: resultLabel = "единадесет"; break;
                        case 2: resultLabel = "дванадесет"; break;
                        case 3: resultLabel = "тринадесет"; break;
                        case 4: resultLabel = "четиринадесет"; break;
                        case 5: resultLabel = "петнадесет"; break;
                        case 6: resultLabel = "шестнадесет"; break;
                        case 7: resultLabel = "седемнадесет"; break;
                        case 8: resultLabel = "осемнадесет"; break;
                        case 9: resultLabel = "деветнадесет"; break;
                    }
                }
                else
                {
                    resultLabel = SignTwoWithWord(second);
                }
            }
            if (num < 0 || num > 99)
            {
                label3.Text = "Числото не е едноцифрено или двуцифрено";
            }
            else
            {
                label3.Text = resultLabel;
            }            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = "";
        }
    }
}