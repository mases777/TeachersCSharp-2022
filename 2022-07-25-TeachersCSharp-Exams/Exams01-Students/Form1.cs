namespace Exams01_Students
{
    public partial class Form1 : Form
    {
        string[] a = new string[32];
        int fileRows, rtbCount;
        string[] rEl = new string[8];
        public Form1()
        {
            InitializeComponent();
        }
        private void parseRec(string record)
        {
            int comma, next;
            comma = record.IndexOf(','); 
            rEl[0] = record.Substring(0, comma);
            for (int i = 1; i < 7; i++)
            {
                next = record.IndexOf(',', comma + 1);
                rEl[i] = record.Substring(comma + 1, next - comma - 1);
                comma = next;
            }
            rEl[7] = record.Substring(comma + 1);
            textBName.Text = rEl[1];
            comBBEL.Text = rEl[2]; comBMat.Text = rEl[3];
            comBFiz.Text = rEl[4]; comBHim.Text = rEl[5];
            comBBio.Text = rEl[6]; comBInf.Text = rEl[7];
        }
        private void cleanRec()
        {
            textBox2.Text = "";
            textBName.Text = "";
            comBBEL.Text = "";
            comBMat.Text = "";
            comBFiz.Text = "";
            comBHim.Text = "";
            comBBio.Text = "";
            comBInf.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = textBox1.Text;
            StreamReader r = new StreamReader(fileName + ".txt");
            richTextBox1.Text = r.ReadToEnd();
            //чете файла
            // ако потребителят не е въвел нов ред в края
            rtbCount = fileRows = richTextBox1.Lines.Count();
            if (richTextBox1.Lines[rtbCount - 1] == "") fileRows--;
            else richTextBox1.Text += "\n";
            // Създваме редактируемото копие  
            for (int i = 0; i < fileRows; i++)
            { a[i + 1] = richTextBox1.Lines[i]; }
            r.Close();
        }

        //private void textBox2_Leave(object sender, EventArgs e)
        //{
        //    int i = int.Parse(textBox2.Text);
        //    if (i > 0 && i <= fileRows)
        //        parseRec(a[i]);
        //    else cleanRec();
        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    cleanRec();
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox2.Text);
            if (i < 0 || i > fileRows)
            { fileRows++; i = fileRows; }
            string newRec = fileRows.ToString() + "," + textBName.Text +
            "," + comBBEL.Text + "," + comBMat.Text + "," + comBFiz.Text +
            "," + comBHim.Text + "," + comBBio.Text + "," + comBInf.Text;
            a[i] = newRec;
            textBox2.Text = fileRows.ToString();
            richTextBox1.Text = "";
            for (int j = 1; j <= fileRows; j++) richTextBox1.Text += (a[j] + "\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter w = new StreamWriter(textBox1.Text + ".txt", true);
            for (int i = 1; i <= fileRows; i++) w.WriteLine(a[i]);
            w.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileRows = 0; richTextBox1.Clear();
        }
    }
}