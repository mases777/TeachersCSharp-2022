namespace Exams03
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
            this.tBoxA = new System.Windows.Forms.TextBox();
            this.tBoxB = new System.Windows.Forms.TextBox();
            this.labVal = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSubstr = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxA
            // 
            this.tBoxA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBoxA.Location = new System.Drawing.Point(12, 12);
            this.tBoxA.Name = "tBoxA";
            this.tBoxA.Size = new System.Drawing.Size(300, 38);
            this.tBoxA.TabIndex = 5;
            this.tBoxA.Text = "0";
            this.tBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tBoxB
            // 
            this.tBoxB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBoxB.Location = new System.Drawing.Point(349, 12);
            this.tBoxB.Name = "tBoxB";
            this.tBoxB.Size = new System.Drawing.Size(300, 38);
            this.tBoxB.TabIndex = 6;
            this.tBoxB.Text = "0";
            this.tBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labVal
            // 
            this.labVal.AutoSize = true;
            this.labVal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labVal.Location = new System.Drawing.Point(12, 75);
            this.labVal.Name = "labVal";
            this.labVal.Size = new System.Drawing.Size(27, 31);
            this.labVal.TabIndex = 10;
            this.labVal.Text = "0";
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSum.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSum.Location = new System.Drawing.Point(349, 75);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(60, 38);
            this.btnSum.TabIndex = 12;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSubstr
            // 
            this.btnSubstr.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSubstr.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubstr.Location = new System.Drawing.Point(429, 75);
            this.btnSubstr.Name = "btnSubstr";
            this.btnSubstr.Size = new System.Drawing.Size(60, 38);
            this.btnSubstr.TabIndex = 13;
            this.btnSubstr.Text = "-";
            this.btnSubstr.UseVisualStyleBackColor = false;
            this.btnSubstr.Click += new System.EventHandler(this.btnSubstr_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.LightGreen;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProduct.Location = new System.Drawing.Point(509, 75);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(60, 38);
            this.btnProduct.TabIndex = 14;
            this.btnProduct.Text = "*";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDivision.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivision.Location = new System.Drawing.Point(589, 75);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(60, 38);
            this.btnDivision.TabIndex = 15;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnMod.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMod.Location = new System.Drawing.Point(669, 75);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(76, 38);
            this.btnMod.TabIndex = 16;
            this.btnMod.Text = "mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Moccasin;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(669, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 38);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(765, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 101);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Край";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 138);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnSubstr);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.labVal);
            this.Controls.Add(this.tBoxB);
            this.Controls.Add(this.tBoxA);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tBoxA;
        private TextBox tBoxB;
        private Label labVal;
        private Button btnSum;
        private Button btnSubstr;
        private Button btnProduct;
        private Button btnDivision;
        private Button btnMod;
        private Button btnClear;
        private Button btnExit;
    }
}