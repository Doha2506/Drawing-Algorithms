namespace WindowsFormsApp1
{
    partial class Drawing_Algorithms
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
            this.Circle = new System.Windows.Forms.Button();
            this.Ellips = new System.Windows.Forms.Button();
            this.DDA = new System.Windows.Forms.Button();
            this.Bresenham = new System.Windows.Forms.Button();
            this.TwoDGeometric = new System.Windows.Forms.Button();
            this.ThreeDGeometric = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Circle
            // 
            this.Circle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Circle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Circle.Location = new System.Drawing.Point(51, 118);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(143, 38);
            this.Circle.TabIndex = 0;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = false;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Ellips
            // 
            this.Ellips.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Ellips.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ellips.Location = new System.Drawing.Point(238, 118);
            this.Ellips.Name = "Ellips";
            this.Ellips.Size = new System.Drawing.Size(143, 38);
            this.Ellips.TabIndex = 1;
            this.Ellips.Text = "Ellips";
            this.Ellips.UseVisualStyleBackColor = false;
            this.Ellips.Click += new System.EventHandler(this.Ellips_Click);
            // 
            // DDA
            // 
            this.DDA.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DDA.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDA.Location = new System.Drawing.Point(51, 34);
            this.DDA.Name = "DDA";
            this.DDA.Size = new System.Drawing.Size(143, 41);
            this.DDA.TabIndex = 2;
            this.DDA.Text = "DDA";
            this.DDA.UseVisualStyleBackColor = false;
            this.DDA.Click += new System.EventHandler(this.DDA_Click);
            // 
            // Bresenham
            // 
            this.Bresenham.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bresenham.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bresenham.Location = new System.Drawing.Point(238, 34);
            this.Bresenham.Name = "Bresenham";
            this.Bresenham.Size = new System.Drawing.Size(139, 41);
            this.Bresenham.TabIndex = 3;
            this.Bresenham.Text = "Bresenham ";
            this.Bresenham.UseVisualStyleBackColor = false;
            this.Bresenham.Click += new System.EventHandler(this.Bresenham_Click);
            // 
            // TwoDGeometric
            // 
            this.TwoDGeometric.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TwoDGeometric.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoDGeometric.Location = new System.Drawing.Point(124, 205);
            this.TwoDGeometric.Name = "TwoDGeometric";
            this.TwoDGeometric.Size = new System.Drawing.Size(187, 38);
            this.TwoDGeometric.TabIndex = 4;
            this.TwoDGeometric.Text = "2D Geometric";
            this.TwoDGeometric.UseVisualStyleBackColor = false;
            this.TwoDGeometric.Click += new System.EventHandler(this.TwoDGeometric_Click);
            // 
            // ThreeDGeometric
            // 
            this.ThreeDGeometric.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ThreeDGeometric.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeDGeometric.Location = new System.Drawing.Point(124, 281);
            this.ThreeDGeometric.Name = "ThreeDGeometric";
            this.ThreeDGeometric.Size = new System.Drawing.Size(187, 38);
            this.ThreeDGeometric.TabIndex = 5;
            this.ThreeDGeometric.Text = "3D Geometric";
            this.ThreeDGeometric.UseVisualStyleBackColor = false;
            this.ThreeDGeometric.Click += new System.EventHandler(this.ThreeDGeometric_Click);
            // 
            // Drawing_Algorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 392);
            this.Controls.Add(this.ThreeDGeometric);
            this.Controls.Add(this.TwoDGeometric);
            this.Controls.Add(this.Bresenham);
            this.Controls.Add(this.DDA);
            this.Controls.Add(this.Ellips);
            this.Controls.Add(this.Circle);
            this.Name = "Drawing_Algorithms";
            this.Text = "Drawing_Algorithms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Ellips;
        private System.Windows.Forms.Button DDA;
        private System.Windows.Forms.Button Bresenham;
        private System.Windows.Forms.Button TwoDGeometric;
        private System.Windows.Forms.Button ThreeDGeometric;
    }
}