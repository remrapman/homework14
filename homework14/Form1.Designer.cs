namespace homework14
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
            this.MyStackButton = new System.Windows.Forms.Button();
            this.DefaultStackButton = new System.Windows.Forms.Button();
            this.MyQueueButton = new System.Windows.Forms.Button();
            this.DefaultQueueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyStackButton
            // 
            this.MyStackButton.Location = new System.Drawing.Point(13, 13);
            this.MyStackButton.Name = "MyStackButton";
            this.MyStackButton.Size = new System.Drawing.Size(175, 23);
            this.MyStackButton.TabIndex = 0;
            this.MyStackButton.Text = "Run MyStack";
            this.MyStackButton.UseVisualStyleBackColor = true;
            this.MyStackButton.Click += new System.EventHandler(this.MyStackButton_Click);
            // 
            // DefaultStackButton
            // 
            this.DefaultStackButton.Location = new System.Drawing.Point(13, 67);
            this.DefaultStackButton.Name = "DefaultStackButton";
            this.DefaultStackButton.Size = new System.Drawing.Size(175, 23);
            this.DefaultStackButton.TabIndex = 0;
            this.DefaultStackButton.Text = "Run Default Stack";
            this.DefaultStackButton.UseVisualStyleBackColor = true;
            this.DefaultStackButton.Click += new System.EventHandler(this.DefaultStackButton_Click);
            // 
            // MyQueueButton
            // 
            this.MyQueueButton.Location = new System.Drawing.Point(12, 126);
            this.MyQueueButton.Name = "MyQueueButton";
            this.MyQueueButton.Size = new System.Drawing.Size(175, 23);
            this.MyQueueButton.TabIndex = 0;
            this.MyQueueButton.Text = "Run MyQueue";
            this.MyQueueButton.UseVisualStyleBackColor = true;
            this.MyQueueButton.Click += new System.EventHandler(this.MyQueueButton_Click);
            // 
            // DefaultQueueButton
            // 
            this.DefaultQueueButton.Location = new System.Drawing.Point(12, 189);
            this.DefaultQueueButton.Name = "DefaultQueueButton";
            this.DefaultQueueButton.Size = new System.Drawing.Size(175, 23);
            this.DefaultQueueButton.TabIndex = 0;
            this.DefaultQueueButton.Text = "Run Default Queue";
            this.DefaultQueueButton.UseVisualStyleBackColor = true;
            this.DefaultQueueButton.Click += new System.EventHandler(this.DefaultQueueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.DefaultQueueButton);
            this.Controls.Add(this.MyQueueButton);
            this.Controls.Add(this.DefaultStackButton);
            this.Controls.Add(this.MyStackButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MyStackButton;
        private System.Windows.Forms.Button DefaultStackButton;
        private System.Windows.Forms.Button MyQueueButton;
        private System.Windows.Forms.Button DefaultQueueButton;
    }
}

