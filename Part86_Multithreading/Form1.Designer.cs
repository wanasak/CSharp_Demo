namespace Part86_Multithreading
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
            this.btnDoTimeConsumingWork = new System.Windows.Forms.Button();
            this.btnPrintNumbers = new System.Windows.Forms.Button();
            this.listBoxNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDoTimeConsumingWork
            // 
            this.btnDoTimeConsumingWork.Location = new System.Drawing.Point(12, 12);
            this.btnDoTimeConsumingWork.Name = "btnDoTimeConsumingWork";
            this.btnDoTimeConsumingWork.Size = new System.Drawing.Size(260, 36);
            this.btnDoTimeConsumingWork.TabIndex = 0;
            this.btnDoTimeConsumingWork.Text = "Do Time Consuming Work";
            this.btnDoTimeConsumingWork.UseVisualStyleBackColor = true;
            this.btnDoTimeConsumingWork.Click += new System.EventHandler(this.btnDoTimeConsumingWork_Click);
            // 
            // btnPrintNumbers
            // 
            this.btnPrintNumbers.Location = new System.Drawing.Point(12, 54);
            this.btnPrintNumbers.Name = "btnPrintNumbers";
            this.btnPrintNumbers.Size = new System.Drawing.Size(260, 36);
            this.btnPrintNumbers.TabIndex = 1;
            this.btnPrintNumbers.Text = "Print Numbers";
            this.btnPrintNumbers.UseVisualStyleBackColor = true;
            this.btnPrintNumbers.Click += new System.EventHandler(this.btnPrintNumbers_Click);
            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.FormattingEnabled = true;
            this.listBoxNumbers.Location = new System.Drawing.Point(12, 96);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(260, 147);
            this.listBoxNumbers.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBoxNumbers);
            this.Controls.Add(this.btnPrintNumbers);
            this.Controls.Add(this.btnDoTimeConsumingWork);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoTimeConsumingWork;
        private System.Windows.Forms.Button btnPrintNumbers;
        private System.Windows.Forms.ListBox listBoxNumbers;
    }
}

