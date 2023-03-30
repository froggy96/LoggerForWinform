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
            this.btnMTSTest = new System.Windows.Forms.Button();
            this.btnLoggingBuilderTest = new System.Windows.Forms.Button();
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
            // btnMTSTest
            // 
            this.btnMTSTest.Location = new System.Drawing.Point(27, 160);
            this.btnMTSTest.Name = "btnMTSTest";
            this.btnMTSTest.Size = new System.Drawing.Size(214, 85);
            this.btnMTSTest.TabIndex = 1;
            this.btnMTSTest.Text = "Multi Thread Test";
            this.btnMTSTest.UseVisualStyleBackColor = true;
            this.btnMTSTest.Click += new System.EventHandler(this.btnMTSTest_Click);
            // 
            // btnLoggingBuilderTest
            // 
            this.btnLoggingBuilderTest.Location = new System.Drawing.Point(340, 160);
            this.btnLoggingBuilderTest.Name = "btnLoggingBuilderTest";
            this.btnLoggingBuilderTest.Size = new System.Drawing.Size(214, 85);
            this.btnLoggingBuilderTest.TabIndex = 2;
            this.btnLoggingBuilderTest.Text = "ILoggingBuilder Test";
            this.btnLoggingBuilderTest.UseVisualStyleBackColor = true;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 334);
            this.Controls.Add(this.btnLoggingBuilderTest);
            this.Controls.Add(this.btnMTSTest);
            this.Controls.Add(this.btnLogTest);
            this.Name = "Mainform";
            this.Text = "Dummy Form To Test Logger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogTest;
        private System.Windows.Forms.Button btnMTSTest;
        private System.Windows.Forms.Button btnLoggingBuilderTest;
    }
}

