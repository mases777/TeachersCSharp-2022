namespace Exams02
{
    public partial class Form1 : Form
    {
        double a, b, c;
        public Form1()
        {
            InitializeComponent();
            rBKv.Checked = false;
            rBPr.Checked = false;
            rBTr.Checked = false;
        }
        private void GetData()
        {
            a = double.Parse(tBoxA.Text);
            b = double.Parse(tBoxB.Text);
            c = double.Parse(tBoxC.Text);
        }
        private void rBKv_Click(object sender, EventArgs e)
        {
            CleanBoxes();
            tBoxA.Visible = true;
            tBoxB.Visible = false;
            tBoxC.Visible = false;
            labA.Visible = true;
            labB.Visible = false;
            labC.Visible = false;
        }
        private void rBPr_Click(object sender, EventArgs e)
        {
            CleanBoxes();
            tBoxA.Visible = true;
            tBoxB.Visible = true;
            tBoxC.Visible = false;
            labA.Visible = true;
            labB.Visible = true;
            labC.Visible = false;
        }
        private void rBTr_Click(object sender, EventArgs e)
        {
            CleanBoxes();
            tBoxA.Visible = true;
            tBoxB.Visible = true;
            tBoxC.Visible = true;
            labA.Visible = true;
            labB.Visible = true;
            labC.Visible = true;
        }
        private void CleanBoxes()
        {
            tBoxA.Text = 0.ToString();
            tBoxB.Text = 0.ToString();
            tBoxC.Text = 0.ToString();
            labPerVal.Text = 0.ToString();
            labLiceVal.Text = 0.ToString();
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double p, perimeter, area;
            if (rBKv.Checked)
            {
                GetData();
                perimeter = 4 * a;
                area = a * a;
                labPerVal.Text = $"{perimeter:f2}";
                labLiceVal.Text = $"{area:f2}";
            }
            else if (rBPr.Checked)
            {
                GetData();
                perimeter = 2 * (a + b);
                area = a * b;
                labPerVal.Text = $"{perimeter:f2}";
                labLiceVal.Text = $"{area:f2}";
            }
            else
            {
                GetData();
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    MessageBox.Show("Не са страни на триъгълник");
                }
                else
                {
                    perimeter = a + b + c;
                    p = perimeter / 2.0;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    labPerVal.Text = $"{perimeter:f2}";
                    labLiceVal.Text = $"{area:f2}";
                }
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}