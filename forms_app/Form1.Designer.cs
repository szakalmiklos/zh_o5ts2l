namespace forms_app
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
            this.buttonUC1 = new System.Windows.Forms.Button();
            this.buttonUC2 = new System.Windows.Forms.Button();
            this.buttonUC3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonUC1
            // 
            this.buttonUC1.Location = new System.Drawing.Point(12, 12);
            this.buttonUC1.Name = "buttonUC1";
            this.buttonUC1.Size = new System.Drawing.Size(97, 56);
            this.buttonUC1.TabIndex = 0;
            this.buttonUC1.Text = "UC1";
            this.buttonUC1.UseVisualStyleBackColor = true;
            this.buttonUC1.Click += new System.EventHandler(this.buttonUC1_Click);
            // 
            // buttonUC2
            // 
            this.buttonUC2.Location = new System.Drawing.Point(192, 12);
            this.buttonUC2.Name = "buttonUC2";
            this.buttonUC2.Size = new System.Drawing.Size(97, 56);
            this.buttonUC2.TabIndex = 1;
            this.buttonUC2.Text = "UC2";
            this.buttonUC2.UseVisualStyleBackColor = true;
            this.buttonUC2.Click += new System.EventHandler(this.buttonUC2_Click);
            // 
            // buttonUC3
            // 
            this.buttonUC3.Location = new System.Drawing.Point(409, 12);
            this.buttonUC3.Name = "buttonUC3";
            this.buttonUC3.Size = new System.Drawing.Size(97, 56);
            this.buttonUC3.TabIndex = 2;
            this.buttonUC3.Text = "UC3";
            this.buttonUC3.UseVisualStyleBackColor = true;
            this.buttonUC3.Click += new System.EventHandler(this.buttonUC3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(595, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 347);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonUC3);
            this.Controls.Add(this.buttonUC2);
            this.Controls.Add(this.buttonUC1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonUC1;
        private Button buttonUC2;
        private Button buttonUC3;
        private Button button4;
        private Panel panel1;
    }
}