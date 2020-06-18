namespace MathSimulator
{
    partial class Comparison
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comparison));
            this.diff_string = new System.Windows.Forms.Label();
            this.InformationOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.more = new System.Windows.Forms.PictureBox();
            this.less = new System.Windows.Forms.PictureBox();
            this.equally = new System.Windows.Forms.PictureBox();
            this.label_res = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.more)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.less)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equally)).BeginInit();
            this.SuspendLayout();
            // 
            // diff_string
            // 
            this.diff_string.AutoSize = true;
            this.diff_string.BackColor = System.Drawing.Color.Transparent;
            this.diff_string.Font = new System.Drawing.Font("Monotype Corsiva", 100.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diff_string.ForeColor = System.Drawing.Color.Black;
            this.diff_string.Location = new System.Drawing.Point(121, 150);
            this.diff_string.Name = "diff_string";
            this.diff_string.Size = new System.Drawing.Size(609, 202);
            this.diff_string.TabIndex = 1;
            this.diff_string.Text = "25      17";
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
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 64.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(114, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(798, 134);
            this.label2.TabIndex = 5;
            this.label2.Text = "Порівняння чисел";
            // 
            // more
            // 
            this.more.BackColor = System.Drawing.Color.Transparent;
            this.more.Image = ((System.Drawing.Image)(resources.GetObject("more.Image")));
            this.more.Location = new System.Drawing.Point(297, 381);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(189, 134);
            this.more.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.more.TabIndex = 8;
            this.more.TabStop = false;
            this.more.Click += new System.EventHandler(this.more_Click);
            this.more.MouseLeave += new System.EventHandler(this.more_MouseLeave);
            this.more.MouseMove += new System.Windows.Forms.MouseEventHandler(this.more_MouseMove);
            // 
            // less
            // 
            this.less.BackColor = System.Drawing.Color.Transparent;
            this.less.Image = ((System.Drawing.Image)(resources.GetObject("less.Image")));
            this.less.Location = new System.Drawing.Point(752, 381);
            this.less.Name = "less";
            this.less.Size = new System.Drawing.Size(189, 134);
            this.less.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.less.TabIndex = 9;
            this.less.TabStop = false;
            this.less.Click += new System.EventHandler(this.less_Click);
            this.less.MouseLeave += new System.EventHandler(this.less_MouseLeave);
            this.less.MouseHover += new System.EventHandler(this.less_MouseHover);
            // 
            // equally
            // 
            this.equally.BackColor = System.Drawing.Color.Transparent;
            this.equally.Image = ((System.Drawing.Image)(resources.GetObject("equally.Image")));
            this.equally.Location = new System.Drawing.Point(526, 381);
            this.equally.Name = "equally";
            this.equally.Size = new System.Drawing.Size(189, 134);
            this.equally.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.equally.TabIndex = 10;
            this.equally.TabStop = false;
            this.equally.Click += new System.EventHandler(this.equally_Click);
            this.equally.MouseLeave += new System.EventHandler(this.equally_MouseLeave);
            this.equally.MouseHover += new System.EventHandler(this.equally_MouseHover);
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.BackColor = System.Drawing.Color.Transparent;
            this.label_res.Font = new System.Drawing.Font("Monotype Corsiva", 100.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_res.ForeColor = System.Drawing.Color.Black;
            this.label_res.Location = new System.Drawing.Point(432, 150);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(0, 202);
            this.label_res.TabIndex = 11;
            // 
            // Comparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 748);
            this.Controls.Add(this.label_res);
            this.Controls.Add(this.equally);
            this.Controls.Add(this.less);
            this.Controls.Add(this.more);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InformationOutput);
            this.Controls.Add(this.diff_string);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Comparison";
            this.Text = "Порівняння чисел";
            this.Load += new System.EventHandler(this.AdditionLoad);
            ((System.ComponentModel.ISupportInitialize)(this.more)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.less)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equally)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label diff_string;
        private System.Windows.Forms.Label InformationOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox more;
        private System.Windows.Forms.PictureBox less;
        private System.Windows.Forms.PictureBox equally;
        private System.Windows.Forms.Label label_res;
    }
}