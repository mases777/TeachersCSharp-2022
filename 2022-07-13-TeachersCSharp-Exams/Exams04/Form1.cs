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
                case 1: result = "����"; break;
                case 2: result = "���"; break;
                case 3: result = "���"; break;
                case 4: result = "������"; break;
                case 5: result = "���"; break;
                case 6: result = "����"; break;
                case 7: result = "�����"; break;
                case 8: result = "����"; break;
                case 9: result = "�����"; break;
            }
            return result;
        }
        private string SignOneWithWord(int first)
        {
            string result = "";
            switch (first)
            {                
                case 2: result = "��������"; break;
                case 3: result = "��������"; break;
                case 4: result = "�����������"; break;
                case 5: result = "��������"; break;
                case 6: result = "���������"; break;
                case 7: result = "����������"; break;
                case 8: result = "���������"; break;
                case 9: result = "����������"; break;
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
                    resultLabel = "����";
                }
                else if (first > 1)
                {
                    if (second == 0)
                    {
                        resultLabel = SignOneWithWord(first);
                    }
                    else
                    {
                        resultLabel = SignOneWithWord(first) + " � " + SignTwoWithWord(second);
                    }
                }
                else if (first == 1)
                {
                    switch (second)
                    {
                        case 0: resultLabel = "�����"; break;
                        case 1: resultLabel = "����������"; break;
                        case 2: resultLabel = "����������"; break;
                        case 3: resultLabel = "����������"; break;
                        case 4: resultLabel = "�������������"; break;
                        case 5: resultLabel = "����������"; break;
                        case 6: resultLabel = "�����������"; break;
                        case 7: resultLabel = "������������"; break;
                        case 8: resultLabel = "�����������"; break;
                        case 9: resultLabel = "������������"; break;
                    }
                }
                else
                {
                    resultLabel = SignTwoWithWord(second);
                }
            }
            if (num < 0 || num > 99)
            {
                label3.Text = "������� �� � ����������� ��� ����������";
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