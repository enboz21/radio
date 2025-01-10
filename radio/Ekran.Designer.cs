namespace radio
{
    partial class Ekran
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
            s_s = new Button();
            url = new TextBox();
            SuspendLayout();
            // 
            // s_s
            // 
            s_s.Location = new Point(12, 12);
            s_s.Name = "s_s";
            s_s.Size = new Size(94, 29);
            s_s.TabIndex = 0;
            s_s.Text = "button1";
            s_s.UseVisualStyleBackColor = true;
            s_s.Click += s_s_Click;
            // 
            // url
            // 
            url.Location = new Point(112, 12);
            url.Name = "url";
            url.Size = new Size(257, 27);
            url.TabIndex = 1;
            // 
            // Ekran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 51);
            Controls.Add(url);
            Controls.Add(s_s);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Ekran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ekran";
            FormClosing += kapat;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button s_s;
        private TextBox url;
    }
}
