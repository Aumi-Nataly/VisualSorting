namespace VisualSorting
{
    partial class frmError
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
            this.richTextBoxError = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxError
            // 
            this.richTextBoxError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richTextBoxError.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxError.Name = "richTextBoxError";
            this.richTextBoxError.Size = new System.Drawing.Size(580, 158);
            this.richTextBoxError.TabIndex = 0;
            this.richTextBoxError.Text = "";
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 158);
            this.Controls.Add(this.richTextBoxError);
            this.MaximumSize = new System.Drawing.Size(596, 197);
            this.Name = "frmError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ошибка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmError_FormClosed);
            this.Load += new System.EventHandler(this.frmError_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxError;
    }
}