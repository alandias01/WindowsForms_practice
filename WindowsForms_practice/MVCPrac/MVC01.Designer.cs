namespace WindowsForms_practice.MVCPrac
{
    partial class MVC01
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
            this.buttonViewA = new System.Windows.Forms.Button();
            this.buttonViewB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonViewA
            // 
            this.buttonViewA.Location = new System.Drawing.Point(13, 13);
            this.buttonViewA.Name = "buttonViewA";
            this.buttonViewA.Size = new System.Drawing.Size(75, 23);
            this.buttonViewA.TabIndex = 0;
            this.buttonViewA.Text = "View A";
            this.buttonViewA.UseVisualStyleBackColor = true;
            this.buttonViewA.Click += new System.EventHandler(this.buttonViewA_Click);
            // 
            // buttonViewB
            // 
            this.buttonViewB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewB.Location = new System.Drawing.Point(151, 13);
            this.buttonViewB.Name = "buttonViewB";
            this.buttonViewB.Size = new System.Drawing.Size(75, 23);
            this.buttonViewB.TabIndex = 1;
            this.buttonViewB.Text = "View B";
            this.buttonViewB.UseVisualStyleBackColor = true;
            // 
            // MVC01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 63);
            this.Controls.Add(this.buttonViewB);
            this.Controls.Add(this.buttonViewA);
            this.Name = "MVC01";
            this.Text = "MVC01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewA;
        private System.Windows.Forms.Button buttonViewB;
    }
}