namespace WindowsForms_practice.MVCTest2
{
    partial class ExtraForm<T,U>
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
            this.DGVTop = new System.Windows.Forms.DataGridView();
            this.DGVBottom = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTopAge = new System.Windows.Forms.Label();
            this.labelBottomAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDifferenceAge = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTop
            // 
            this.DGVTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTop.Location = new System.Drawing.Point(12, 33);
            this.DGVTop.Name = "DGVTop";
            this.DGVTop.Size = new System.Drawing.Size(697, 150);
            this.DGVTop.TabIndex = 0;
            // 
            // DGVBottom
            // 
            this.DGVBottom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBottom.Location = new System.Drawing.Point(12, 260);
            this.DGVBottom.Name = "DGVBottom";
            this.DGVBottom.Size = new System.Drawing.Size(697, 150);
            this.DGVBottom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Top Age";
            // 
            // labelTopAge
            // 
            this.labelTopAge.AutoSize = true;
            this.labelTopAge.Location = new System.Drawing.Point(66, 212);
            this.labelTopAge.Name = "labelTopAge";
            this.labelTopAge.Size = new System.Drawing.Size(35, 13);
            this.labelTopAge.TabIndex = 3;
            this.labelTopAge.Text = "label2";
            // 
            // labelBottomAge
            // 
            this.labelBottomAge.AutoSize = true;
            this.labelBottomAge.Location = new System.Drawing.Point(215, 212);
            this.labelBottomAge.Name = "labelBottomAge";
            this.labelBottomAge.Size = new System.Drawing.Size(35, 13);
            this.labelBottomAge.TabIndex = 5;
            this.labelBottomAge.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bottom Age";
            // 
            // labelDifferenceAge
            // 
            this.labelDifferenceAge.AutoSize = true;
            this.labelDifferenceAge.Location = new System.Drawing.Point(356, 212);
            this.labelDifferenceAge.Name = "labelDifferenceAge";
            this.labelDifferenceAge.Size = new System.Drawing.Size(35, 13);
            this.labelDifferenceAge.TabIndex = 7;
            this.labelDifferenceAge.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Difference";
            // 
            // ExtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 422);
            this.Controls.Add(this.labelDifferenceAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelBottomAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTopAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVBottom);
            this.Controls.Add(this.DGVTop);
            this.Name = "ExtraForm";
            this.Text = "ExtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVTop;
        private System.Windows.Forms.DataGridView DGVBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTopAge;
        private System.Windows.Forms.Label labelBottomAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDifferenceAge;
        private System.Windows.Forms.Label label6;
    }
}