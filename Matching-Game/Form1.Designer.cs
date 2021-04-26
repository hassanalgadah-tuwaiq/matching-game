
namespace Matching_Game
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.Label();
            this.box2 = new System.Windows.Forms.Label();
            this.box4 = new System.Windows.Forms.Label();
            this.box3 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.Label();
            this.pic2 = new System.Windows.Forms.Label();
            this.pic4 = new System.Windows.Forms.Label();
            this.pic3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-256, -81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.box1.Location = new System.Drawing.Point(-13, 0);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(403, 400);
            this.box1.TabIndex = 1;
            this.box1.Text = "label2";
            this.box1.Click += new System.EventHandler(this.box1_Click);
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.box2.Location = new System.Drawing.Point(395, 0);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(400, 400);
            this.box2.TabIndex = 2;
            this.box2.Text = "label3";
            this.box2.Click += new System.EventHandler(this.box2_Click);
            // 
            // box4
            // 
            this.box4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.box4.Location = new System.Drawing.Point(396, 409);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(400, 400);
            this.box4.TabIndex = 4;
            this.box4.Text = "label4";
            this.box4.Click += new System.EventHandler(this.box3_Click);
            // 
            // box3
            // 
            this.box3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.box3.Location = new System.Drawing.Point(-13, 409);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(403, 400);
            this.box3.TabIndex = 3;
            this.box3.Text = "label5";
            this.box3.Click += new System.EventHandler(this.box4_Click);
            // 
            // pic1
            // 
            this.pic1.AutoSize = true;
            this.pic1.Location = new System.Drawing.Point(207, 186);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(22, 25);
            this.pic1.TabIndex = 5;
            this.pic1.Text = "1";
            this.pic1.Visible = false;
            // 
            // pic2
            // 
            this.pic2.AutoSize = true;
            this.pic2.Location = new System.Drawing.Point(565, 186);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(22, 25);
            this.pic2.TabIndex = 6;
            this.pic2.Text = "2";
            this.pic2.Visible = false;
            // 
            // pic4
            // 
            this.pic4.AutoSize = true;
            this.pic4.Location = new System.Drawing.Point(565, 559);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(22, 25);
            this.pic4.TabIndex = 7;
            this.pic4.Text = "1";
            this.pic4.Visible = false;
            // 
            // pic3
            // 
            this.pic3.AutoSize = true;
            this.pic3.Location = new System.Drawing.Point(169, 559);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(22, 25);
            this.pic3.TabIndex = 8;
            this.pic3.Text = "2";
            this.pic3.Visible = false;
            this.pic3.Click += new System.EventHandler(this.pic3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label box1;
        private System.Windows.Forms.Label box2;
        private System.Windows.Forms.Label box4;
        private System.Windows.Forms.Label box3;
        private System.Windows.Forms.Label pic1;
        private System.Windows.Forms.Label pic2;
        private System.Windows.Forms.Label pic4;
        private System.Windows.Forms.Label pic3;
        private System.Windows.Forms.Timer timer1;
    }
}

