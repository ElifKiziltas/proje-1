namespace Birinci
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
            bSelamla = new Button();
            bKapat = new Button();
            label1 = new Label();
            tbAd = new TextBox();
            SuspendLayout();
            // 
            // bSelamla
            // 
            bSelamla.Location = new Point(86, 107);
            bSelamla.Name = "bSelamla";
            bSelamla.Size = new Size(94, 30);
            bSelamla.TabIndex = 0;
            bSelamla.Text = "&Selamla";
            bSelamla.UseVisualStyleBackColor = true;
            bSelamla.Click += bSelamla_Click;
            bSelamla.MouseLeave += bSelamla_MouseLeave;
            bSelamla.MouseHover += bSelamla_MouseHover;
            // 
            // bKapat
            // 
            bKapat.Location = new Point(86, 158);
            bKapat.Name = "bKapat";
            bKapat.Size = new Size(94, 30);
            bKapat.TabIndex = 1;
            bKapat.Text = "&Kapat";
            bKapat.UseVisualStyleBackColor = true;
            bKapat.Click += bKapat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 33);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "&Adınız:";
            // 
            // tbAd
            // 
            tbAd.Location = new Point(68, 30);
            tbAd.Name = "tbAd";
            tbAd.Size = new Size(155, 23);
            tbAd.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 239);
            Controls.Add(tbAd);
            Controls.Add(label1);
            Controls.Add(bKapat);
            Controls.Add(bSelamla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSelamla;
        private Button bKapat;
        private Label label1;
        private TextBox tbAd;
    }
}
