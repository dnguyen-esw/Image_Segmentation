namespace XLA_Project6_Fix
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
            this.pictureBox_hinhgoc = new System.Windows.Forms.PictureBox();
            this.label_hingoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_seg = new System.Windows.Forms.PictureBox();
            this.button_seg = new System.Windows.Forms.Button();
            this.label_X1 = new System.Windows.Forms.Label();
            this.label_Y1 = new System.Windows.Forms.Label();
            this.label_Y2 = new System.Windows.Forms.Label();
            this.label_X2 = new System.Windows.Forms.Label();
            this.textBox_threshold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hinhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_seg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_hinhgoc
            // 
            this.pictureBox_hinhgoc.Location = new System.Drawing.Point(12, 33);
            this.pictureBox_hinhgoc.Name = "pictureBox_hinhgoc";
            this.pictureBox_hinhgoc.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_hinhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_hinhgoc.TabIndex = 0;
            this.pictureBox_hinhgoc.TabStop = false;
            this.pictureBox_hinhgoc.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_hinhgoc_Paint);
            this.pictureBox_hinhgoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_hinhgoc_MouseDown);
            this.pictureBox_hinhgoc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_hinhgoc_MouseMove);
            this.pictureBox_hinhgoc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_hinhgoc_MouseUp);
            // 
            // label_hingoc
            // 
            this.label_hingoc.AutoSize = true;
            this.label_hingoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hingoc.Location = new System.Drawing.Point(201, 9);
            this.label_hingoc.Name = "label_hingoc";
            this.label_hingoc.Size = new System.Drawing.Size(83, 21);
            this.label_hingoc.TabIndex = 1;
            this.label_hingoc.Text = "Hinh Goc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1077, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Segmentation Image";
            // 
            // pictureBox_seg
            // 
            this.pictureBox_seg.Location = new System.Drawing.Point(899, 33);
            this.pictureBox_seg.Name = "pictureBox_seg";
            this.pictureBox_seg.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_seg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_seg.TabIndex = 2;
            this.pictureBox_seg.TabStop = false;
            // 
            // button_seg
            // 
            this.button_seg.Location = new System.Drawing.Point(810, 228);
            this.button_seg.Name = "button_seg";
            this.button_seg.Size = new System.Drawing.Size(83, 70);
            this.button_seg.TabIndex = 4;
            this.button_seg.Text = "Segmentation";
            this.button_seg.UseVisualStyleBackColor = true;
            this.button_seg.Click += new System.EventHandler(this.button_seg_Click);
            // 
            // label_X1
            // 
            this.label_X1.AutoSize = true;
            this.label_X1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X1.Location = new System.Drawing.Point(567, 216);
            this.label_X1.Name = "label_X1";
            this.label_X1.Size = new System.Drawing.Size(43, 21);
            this.label_X1.TabIndex = 5;
            this.label_X1.Text = "X1: ";
            // 
            // label_Y1
            // 
            this.label_Y1.AutoSize = true;
            this.label_Y1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Y1.Location = new System.Drawing.Point(652, 216);
            this.label_Y1.Name = "label_Y1";
            this.label_Y1.Size = new System.Drawing.Size(41, 21);
            this.label_Y1.TabIndex = 6;
            this.label_Y1.Text = "Y1: ";
            // 
            // label_Y2
            // 
            this.label_Y2.AutoSize = true;
            this.label_Y2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Y2.Location = new System.Drawing.Point(652, 267);
            this.label_Y2.Name = "label_Y2";
            this.label_Y2.Size = new System.Drawing.Size(41, 21);
            this.label_Y2.TabIndex = 8;
            this.label_Y2.Text = "Y2: ";
            // 
            // label_X2
            // 
            this.label_X2.AutoSize = true;
            this.label_X2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X2.Location = new System.Drawing.Point(567, 267);
            this.label_X2.Name = "label_X2";
            this.label_X2.Size = new System.Drawing.Size(43, 21);
            this.label_X2.TabIndex = 7;
            this.label_X2.Text = "X2: ";
            // 
            // textBox_threshold
            // 
            this.textBox_threshold.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_threshold.Location = new System.Drawing.Point(701, 148);
            this.textBox_threshold.Name = "textBox_threshold";
            this.textBox_threshold.Size = new System.Drawing.Size(69, 29);
            this.textBox_threshold.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(655, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "D0:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_threshold);
            this.Controls.Add(this.label_Y2);
            this.Controls.Add(this.label_X2);
            this.Controls.Add(this.label_Y1);
            this.Controls.Add(this.label_X1);
            this.Controls.Add(this.button_seg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_seg);
            this.Controls.Add(this.label_hingoc);
            this.Controls.Add(this.pictureBox_hinhgoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hinhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_seg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_hinhgoc;
        private System.Windows.Forms.Label label_hingoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_seg;
        private System.Windows.Forms.Button button_seg;
        private System.Windows.Forms.Label label_X1;
        private System.Windows.Forms.Label label_Y1;
        private System.Windows.Forms.Label label_Y2;
        private System.Windows.Forms.Label label_X2;
        private System.Windows.Forms.TextBox textBox_threshold;
        private System.Windows.Forms.Label label2;
    }
}

