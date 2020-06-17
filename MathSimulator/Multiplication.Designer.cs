namespace MathSimulator
{
    partial class Multiplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multiplication));
            this.mul_string = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.check_button = new System.Windows.Forms.Button();
            this.InformationOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mul_string
            // 
            this.mul_string.AutoSize = true;
            this.mul_string.BackColor = System.Drawing.Color.Transparent;
            this.mul_string.Font = new System.Drawing.Font("Monotype Corsiva", 100.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mul_string.ForeColor = System.Drawing.Color.Black;
            this.mul_string.Location = new System.Drawing.Point(143, 230);
            this.mul_string.Name = "mul_string";
            this.mul_string.Size = new System.Drawing.Size(469, 202);
            this.mul_string.TabIndex = 1;
            this.mul_string.Text = "25+17";
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Font = new System.Drawing.Font("Monotype Corsiva", 100.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.Black;
            this.result.Location = new System.Drawing.Point(640, 230);
            this.result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(277, 188);
            this.result.TabIndex = 2;
            this.result.Click += new System.EventHandler(this.ClearInformation);
            // 
            // check_button
            // 
            this.check_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.check_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_button.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_button.ForeColor = System.Drawing.Color.White;
            this.check_button.Location = new System.Drawing.Point(363, 466);
            this.check_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(412, 64);
            this.check_button.TabIndex = 3;
            this.check_button.Text = "Перевірити";
            this.check_button.UseVisualStyleBackColor = false;
            this.check_button.Click += new System.EventHandler(this.СalculationСheck);
            // 
            // InformationOutput
            // 
            this.InformationOutput.AutoSize = true;
            this.InformationOutput.BackColor = System.Drawing.Color.Transparent;
            this.InformationOutput.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InformationOutput.Location = new System.Drawing.Point(309, 558);
            this.InformationOutput.Name = "InformationOutput";
            this.InformationOutput.Size = new System.Drawing.Size(216, 97);
            this.InformationOutput.TabIndex = 4;
            this.InformationOutput.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 100.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(115, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(775, 202);
            this.label2.TabIndex = 5;
            this.label2.Text = "Множення";
            // 
            // Multiplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 748);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InformationOutput);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.result);
            this.Controls.Add(this.mul_string);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Multiplication";
            this.Text = "Множення чисел";
            this.Load += new System.EventHandler(this.AdditionLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mul_string;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Label InformationOutput;
        private System.Windows.Forms.Label label2;
    }
}