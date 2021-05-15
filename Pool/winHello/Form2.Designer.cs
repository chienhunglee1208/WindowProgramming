namespace winHello
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.home_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hit_button = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.friction_label = new System.Windows.Forms.Label();
            this.force_label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pullBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(50, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 387);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(858, 494);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(75, 23);
            this.home_button.TabIndex = 2;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 36;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hit_button
            // 
            this.hit_button.Location = new System.Drawing.Point(833, 432);
            this.hit_button.Name = "hit_button";
            this.hit_button.Size = new System.Drawing.Size(75, 23);
            this.hit_button.TabIndex = 3;
            this.hit_button.Text = "Hit!";
            this.hit_button.UseVisualStyleBackColor = true;
            this.hit_button.Click += new System.EventHandler(this.hit_button_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(814, 68);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(30, 334);
            this.vScrollBar1.TabIndex = 4;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(878, 68);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(30, 334);
            this.vScrollBar2.TabIndex = 5;
            // 
            // friction_label
            // 
            this.friction_label.AutoSize = true;
            this.friction_label.Location = new System.Drawing.Point(876, 32);
            this.friction_label.Name = "friction_label";
            this.friction_label.Size = new System.Drawing.Size(41, 12);
            this.friction_label.TabIndex = 6;
            this.friction_label.Text = "Friction";
            // 
            // force_label
            // 
            this.force_label.AutoSize = true;
            this.force_label.Location = new System.Drawing.Point(812, 32);
            this.force_label.Name = "force_label";
            this.force_label.Size = new System.Drawing.Size(31, 12);
            this.force_label.TabIndex = 7;
            this.force_label.Text = "Force";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(474, 479);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 16);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Stop";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pullBackButton
            // 
            this.pullBackButton.Location = new System.Drawing.Point(547, 471);
            this.pullBackButton.Name = "pullBackButton";
            this.pullBackButton.Size = new System.Drawing.Size(75, 23);
            this.pullBackButton.TabIndex = 9;
            this.pullBackButton.Text = "Pull Back";
            this.pullBackButton.UseVisualStyleBackColor = true;
            this.pullBackButton.Click += new System.EventHandler(this.pullBackButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 529);
            this.Controls.Add(this.pullBackButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.force_label);
            this.Controls.Add(this.friction_label);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hit_button);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button hit_button;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Label friction_label;
        private System.Windows.Forms.Label force_label;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button pullBackButton;
    }
}