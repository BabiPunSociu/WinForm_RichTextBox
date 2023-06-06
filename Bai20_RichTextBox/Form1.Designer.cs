namespace Bai20_RichTextBox
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
			this.rtfText = new System.Windows.Forms.RichTextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnFont = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rtfText
			// 
			this.rtfText.BackColor = System.Drawing.Color.LightGreen;
			this.rtfText.Location = new System.Drawing.Point(18, 20);
			this.rtfText.Name = "rtfText";
			this.rtfText.Size = new System.Drawing.Size(776, 526);
			this.rtfText.TabIndex = 0;
			this.rtfText.Text = "";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(816, 501);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(170, 44);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnFont
			// 
			this.btnFont.Location = new System.Drawing.Point(816, 436);
			this.btnFont.Name = "btnFont";
			this.btnFont.Size = new System.Drawing.Size(170, 44);
			this.btnFont.TabIndex = 2;
			this.btnFont.Text = "&Font";
			this.btnFont.UseVisualStyleBackColor = true;
			this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(816, 358);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(170, 44);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(816, 284);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(170, 44);
			this.btnOpen.TabIndex = 4;
			this.btnOpen.Text = "&Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(1000, 562);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnFont);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.rtfText);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Red;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bài 20: RichTextBox";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfText;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
    }
}

