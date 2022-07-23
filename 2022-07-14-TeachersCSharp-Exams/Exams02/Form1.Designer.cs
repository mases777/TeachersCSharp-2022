namespace Exams02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBTr = new System.Windows.Forms.RadioButton();
            this.rBPr = new System.Windows.Forms.RadioButton();
            this.rBKv = new System.Windows.Forms.RadioButton();
            this.labA = new System.Windows.Forms.Label();
            this.labB = new System.Windows.Forms.Label();
            this.labC = new System.Windows.Forms.Label();
            this.tBoxA = new System.Windows.Forms.TextBox();
            this.tBoxB = new System.Windows.Forms.TextBox();
            this.tBoxC = new System.Windows.Forms.TextBox();
            this.labPer = new System.Windows.Forms.Label();
            this.labLice = new System.Windows.Forms.Label();
            this.labPerVal = new System.Windows.Forms.Label();
            this.labLiceVal = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rBTr);
            this.panel1.Controls.Add(this.rBPr);
            this.panel1.Controls.Add(this.rBKv);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 78);
            this.panel1.TabIndex = 0;
            // 
            // rBTr
            // 
            this.rBTr.AutoSize = true;
            this.rBTr.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBTr.Location = new System.Drawing.Point(410, 17);
            this.rBTr.Name = "rBTr";
            this.rBTr.Size = new System.Drawing.Size(168, 35);
            this.rBTr.TabIndex = 2;
            this.rBTr.TabStop = true;
            this.rBTr.Text = "Триъгълник";
            this.rBTr.UseVisualStyleBackColor = true;
            this.rBTr.Click += new System.EventHandler(this.rBTr_Click);
            // 
            // rBPr
            // 
            this.rBPr.AutoSize = true;
            this.rBPr.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBPr.Location = new System.Drawing.Point(180, 17);
            this.rBPr.Name = "rBPr";
            this.rBPr.Size = new System.Drawing.Size(200, 35);
            this.rBPr.TabIndex = 1;
            this.rBPr.TabStop = true;
            this.rBPr.Text = "Правоъгълник";
            this.rBPr.UseVisualStyleBackColor = true;
            this.rBPr.Click += new System.EventHandler(this.rBPr_Click);
            // 
            // rBKv
            // 
            this.rBKv.AutoSize = true;
            this.rBKv.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBKv.Location = new System.Drawing.Point(19, 17);
            this.rBKv.Name = "rBKv";
            this.rBKv.Size = new System.Drawing.Size(125, 35);
            this.rBKv.TabIndex = 0;
            this.rBKv.TabStop = true;
            this.rBKv.Text = "Квадрат";
            this.rBKv.UseVisualStyleBackColor = true;
            this.rBKv.Click += new System.EventHandler(this.rBKv_Click);
            // 
            // labA
            // 
            this.labA.AutoSize = true;
            this.labA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labA.Location = new System.Drawing.Point(33, 135);
            this.labA.Name = "labA";
            this.labA.Size = new System.Drawing.Size(112, 31);
            this.labA.TabIndex = 1;
            this.labA.Text = "Страна А";
            this.labA.Visible = false;
            // 
            // labB
            // 
            this.labB.AutoSize = true;
            this.labB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labB.Location = new System.Drawing.Point(33, 194);
            this.labB.Name = "labB";
            this.labB.Size = new System.Drawing.Size(111, 31);
            this.labB.TabIndex = 2;
            this.labB.Text = "Страна B";
            this.labB.Visible = false;
            // 
            // labC
            // 
            this.labC.AutoSize = true;
            this.labC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labC.Location = new System.Drawing.Point(33, 253);
            this.labC.Name = "labC";
            this.labC.Size = new System.Drawing.Size(110, 31);
            this.labC.TabIndex = 3;
            this.labC.Text = "Страна C";
            this.labC.Visible = false;
            // 
            // tBoxA
            // 
            this.tBoxA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBoxA.Location = new System.Drawing.Point(175, 135);
            this.tBoxA.Name = "tBoxA";
            this.tBoxA.Size = new System.Drawing.Size(106, 38);
            this.tBoxA.TabIndex = 4;
            this.tBoxA.Text = "0";
            this.tBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxA.Visible = false;
            // 
            // tBoxB
            // 
            this.tBoxB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBoxB.Location = new System.Drawing.Point(175, 194);
            this.tBoxB.Name = "tBoxB";
            this.tBoxB.Size = new System.Drawing.Size(106, 38);
            this.tBoxB.TabIndex = 5;
            this.tBoxB.Text = "0";
            this.tBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxB.Visible = false;
            // 
            // tBoxC
            // 
            this.tBoxC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBoxC.Location = new System.Drawing.Point(175, 253);
            this.tBoxC.Name = "tBoxC";
            this.tBoxC.Size = new System.Drawing.Size(106, 38);
            this.tBoxC.TabIndex = 6;
            this.tBoxC.Text = "0";
            this.tBoxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxC.Visible = false;
            // 
            // labPer
            // 
            this.labPer.AutoSize = true;
            this.labPer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labPer.Location = new System.Drawing.Point(363, 142);
            this.labPer.Name = "labPer";
            this.labPer.Size = new System.Drawing.Size(141, 31);
            this.labPer.TabIndex = 7;
            this.labPer.Text = "Периметър";
            this.labPer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labLice
            // 
            this.labLice.AutoSize = true;
            this.labLice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labLice.Location = new System.Drawing.Point(432, 201);
            this.labLice.Name = "labLice";
            this.labLice.Size = new System.Drawing.Size(72, 31);
            this.labLice.TabIndex = 8;
            this.labLice.Text = "Лице";
            this.labLice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labPerVal
            // 
            this.labPerVal.AutoSize = true;
            this.labPerVal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labPerVal.Location = new System.Drawing.Point(529, 142);
            this.labPerVal.Name = "labPerVal";
            this.labPerVal.Size = new System.Drawing.Size(27, 31);
            this.labPerVal.TabIndex = 9;
            this.labPerVal.Text = "0";
            // 
            // labLiceVal
            // 
            this.labLiceVal.AutoSize = true;
            this.labLiceVal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labLiceVal.Location = new System.Drawing.Point(529, 201);
            this.labLiceVal.Name = "labLiceVal";
            this.labLiceVal.Size = new System.Drawing.Size(27, 31);
            this.labLiceVal.TabIndex = 10;
            this.labLiceVal.Text = "0";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.Location = new System.Drawing.Point(316, 253);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(162, 38);
            this.btnCalc.TabIndex = 11;
            this.btnCalc.Text = "Пресметни";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEnd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnd.Location = new System.Drawing.Point(500, 253);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(116, 38);
            this.btnEnd.TabIndex = 12;
            this.btnEnd.Text = "Край";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 317);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.labLiceVal);
            this.Controls.Add(this.labPerVal);
            this.Controls.Add(this.labLice);
            this.Controls.Add(this.labPer);
            this.Controls.Add(this.tBoxC);
            this.Controls.Add(this.tBoxB);
            this.Controls.Add(this.tBoxA);
            this.Controls.Add(this.labC);
            this.Controls.Add(this.labB);
            this.Controls.Add(this.labA);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Face Perimeter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private RadioButton rBTr;
        private RadioButton rBPr;
        private RadioButton rBKv;
        private Label labA;
        private Label labB;
        private Label labC;
        private TextBox tBoxA;
        private TextBox tBoxB;
        private TextBox tBoxC;
        private Label labPer;
        private Label labLice;
        private Label labPerVal;
        private Label labLiceVal;
        private Button btnCalc;
        private Button btnEnd;
    }
}