namespace MathSimulator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.b_Sum = new System.Windows.Forms.Button();
            this.b_Diff = new System.Windows.Forms.Button();
            this.b_Mul = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.b_Div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Sum
            // 
            this.b_Sum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b_Sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Sum.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Sum.Location = new System.Drawing.Point(175, 654);
            this.b_Sum.Name = "b_Sum";
            this.b_Sum.Size = new System.Drawing.Size(279, 47);
            this.b_Sum.TabIndex = 0;
            this.b_Sum.Text = "Додавання чисел";
            this.b_Sum.UseVisualStyleBackColor = false;
            this.b_Sum.Click += new System.EventHandler(this.AdditionOfNumber);
            // 
            // b_Diff
            // 
            this.b_Diff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b_Diff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Diff.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Diff.Location = new System.Drawing.Point(225, 707);
            this.b_Diff.Name = "b_Diff";
            this.b_Diff.Size = new System.Drawing.Size(279, 47);
            this.b_Diff.TabIndex = 1;
            this.b_Diff.Text = "Віднімання чисел";
            this.b_Diff.UseVisualStyleBackColor = false;
            this.b_Diff.Click += new System.EventHandler(this.b_Diff_Click);
            // 
            // b_Mul
            // 
            this.b_Mul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.b_Mul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Mul.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Mul.Location = new System.Drawing.Point(275, 760);
            this.b_Mul.Name = "b_Mul";
            this.b_Mul.Size = new System.Drawing.Size(279, 47);
            this.b_Mul.TabIndex = 2;
            this.b_Mul.Text = "Множення чисел";
            this.b_Mul.UseVisualStyleBackColor = false;
            this.b_Mul.Click += new System.EventHandler(this.b_Mul_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(622, 760);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(279, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Склад числа";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(572, 707);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(279, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "Порівняння чисел";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // b_Div
            // 
            this.b_Div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.b_Div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Div.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Div.Location = new System.Drawing.Point(522, 654);
            this.b_Div.Name = "b_Div";
            this.b_Div.Size = new System.Drawing.Size(279, 47);
            this.b_Div.TabIndex = 3;
            this.b_Div.Text = "Ділення чисел";
            this.b_Div.UseVisualStyleBackColor = false;
            this.b_Div.Click += new System.EventHandler(this.b_Div_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1326, 1055);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.b_Div);
            this.Controls.Add(this.b_Mul);
            this.Controls.Add(this.b_Diff);
            this.Controls.Add(this.b_Sum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Математичний тренажер";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Sum;
        private System.Windows.Forms.Button b_Diff;
        private System.Windows.Forms.Button b_Mul;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button b_Div;
    }
}

