namespace Prog88a
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAbs = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LawnGreen;
            this.textBox1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 33);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LawnGreen;
            this.textBox2.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 33);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(247, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(247, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(473, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sum:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSum
            // 
            this.lblSum.BackColor = System.Drawing.Color.PaleGreen;
            this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSum.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.lblSum.Location = new System.Drawing.Point(247, 128);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(238, 38);
            this.lblSum.TabIndex = 6;
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSum.Click += new System.EventHandler(this.lblSum_Click);
            // 
            // lblDiff
            // 
            this.lblDiff.BackColor = System.Drawing.Color.PaleGreen;
            this.lblDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiff.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.lblDiff.Location = new System.Drawing.Point(247, 166);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(238, 38);
            this.lblDiff.TabIndex = 8;
            this.lblDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDiff.Click += new System.EventHandler(this.lblDiff_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SpringGreen;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Difference:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvg
            // 
            this.lblAvg.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvg.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.lblAvg.Location = new System.Drawing.Point(247, 242);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(238, 38);
            this.lblAvg.TabIndex = 12;
            this.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAvg.Click += new System.EventHandler(this.lblAvg_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SpringGreen;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.label6.Location = new System.Drawing.Point(12, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 38);
            this.label6.TabIndex = 11;
            this.label6.Text = "Average:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProd
            // 
            this.lblProd.BackColor = System.Drawing.Color.PaleGreen;
            this.lblProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProd.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.lblProd.Location = new System.Drawing.Point(247, 204);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(238, 38);
            this.lblProd.TabIndex = 10;
            this.lblProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProd.Click += new System.EventHandler(this.lblProd_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SpringGreen;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.label8.Location = new System.Drawing.Point(12, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 38);
            this.label8.TabIndex = 9;
            this.label8.Text = "Product:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMax
            // 
            this.lblMax.BackColor = System.Drawing.Color.PaleGreen;
            this.lblMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMax.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.lblMax.Location = new System.Drawing.Point(247, 356);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(238, 38);
            this.lblMax.TabIndex = 18;
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.SpringGreen;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.label10.Location = new System.Drawing.Point(12, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 38);
            this.label10.TabIndex = 17;
            this.label10.Text = "Max:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMin
            // 
            this.lblMin.BackColor = System.Drawing.Color.PaleGreen;
            this.lblMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMin.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.lblMin.Location = new System.Drawing.Point(247, 318);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(238, 38);
            this.lblMin.TabIndex = 16;
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.SpringGreen;
            this.label12.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.label12.Location = new System.Drawing.Point(12, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 38);
            this.label12.TabIndex = 15;
            this.label12.Text = "Min:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbs
            // 
            this.lblAbs.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAbs.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.lblAbs.Location = new System.Drawing.Point(247, 280);
            this.lblAbs.Name = "lblAbs";
            this.lblAbs.Size = new System.Drawing.Size(238, 38);
            this.lblAbs.TabIndex = 14;
            this.lblAbs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAbs.Click += new System.EventHandler(this.lblAbs_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.SpringGreen;
            this.label14.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.label14.Location = new System.Drawing.Point(12, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(229, 38);
            this.label14.TabIndex = 13;
            this.label14.Text = "Abs. Value:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(497, 407);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblAbs);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDiff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAbs;
        private System.Windows.Forms.Label label14;
    }
}

