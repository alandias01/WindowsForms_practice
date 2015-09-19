namespace WindowsForms_practice.MVCPrac
{
    partial class GenericView
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
            this.labelMain = new System.Windows.Forms.Label();
            this.labelShow1 = new System.Windows.Forms.Label();
            this.labelShow2 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTextbox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(93, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(35, 13);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "label1";
            // 
            // labelShow1
            // 
            this.labelShow1.AutoSize = true;
            this.labelShow1.Location = new System.Drawing.Point(12, 52);
            this.labelShow1.Name = "labelShow1";
            this.labelShow1.Size = new System.Drawing.Size(54, 13);
            this.labelShow1.TabIndex = 1;
            this.labelShow1.Text = "labelshow";
            // 
            // labelShow2
            // 
            this.labelShow2.AutoSize = true;
            this.labelShow2.Location = new System.Drawing.Point(12, 77);
            this.labelShow2.Name = "labelShow2";
            this.labelShow2.Size = new System.Drawing.Size(54, 13);
            this.labelShow2.TabIndex = 2;
            this.labelShow2.Text = "labelshow";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(96, 111);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(15, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Inc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(120, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "dec";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTextbox
            // 
            this.labelTextbox.AutoSize = true;
            this.labelTextbox.Location = new System.Drawing.Point(12, 118);
            this.labelTextbox.Name = "labelTextbox";
            this.labelTextbox.Size = new System.Drawing.Size(35, 13);
            this.labelTextbox.TabIndex = 6;
            this.labelTextbox.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(120, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GenericView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 234);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTextbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelShow2);
            this.Controls.Add(this.labelShow1);
            this.Controls.Add(this.labelMain);
            this.Name = "GenericView";
            this.Text = "GenericView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelShow1;
        private System.Windows.Forms.Label labelShow2;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}