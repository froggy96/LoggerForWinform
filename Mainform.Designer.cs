namespace LoggerForWinform
{
    partial class Mainform
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
            this.btnLogTest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogTest
            // 
            this.btnLogTest.Location = new System.Drawing.Point(27, 32);
            this.btnLogTest.Name = "btnLogTest";
            this.btnLogTest.Size = new System.Drawing.Size(214, 85);
            this.btnLogTest.TabIndex = 0;
            this.btnLogTest.Text = "Log A Line";
            this.btnLogTest.UseVisualStyleBackColor = true;
            this.btnLogTest.Click += new System.EventHandler(this.btnLogTest_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = "Multi Thread Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 334);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLogTest);
            this.Name = "Mainform";
            this.Text = "Dummy Form To Test Logger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogTest;
        private System.Windows.Forms.Button button2;
    }
}

