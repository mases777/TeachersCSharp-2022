namespace Exams03
{
    public partial class Form1 : Form
    {
        double a, b, c;
        public Form1()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            a = double.Parse(tBoxA.Text);
            b = double.Parse(tBoxB.Text);
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            GetData();
            c = a + b;
            labVal.Text = $"{c:f2}";
        }
        private void btnSubstr_Click(object sender, EventArgs e)
        {
            GetData();
            c = a - b;
            labVal.Text = $"{c:f2}";
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            GetData();
            c = a * b;
            labVal.Text = $"{c:f2}";
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            GetData();
            c = a / b;
            labVal.Text = $"{c:f2}";
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            GetData();
            c = a % b;
            labVal.Text = $"{c:f2}";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tBoxA.Text = 0.ToString();
            tBoxB.Text = 0.ToString();
            labVal.Text = 0.ToString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}