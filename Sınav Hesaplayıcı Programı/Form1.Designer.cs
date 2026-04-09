namespace Sınav_Hesaplayıcı_Programı
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
            label1 = new Label();
            label2 = new Label();
            textVize = new TextBox();
            textFinal = new TextBox();
            hesapla = new Button();
            lblHarfNotu = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(59, 64);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 0;
            label1.Text = "Vize Puanınız";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.Location = new Point(59, 145);
            label2.Name = "label2";
            label2.Size = new Size(154, 31);
            label2.TabIndex = 1;
            label2.Text = "Final Puanınız";
            // 
            // textVize
            // 
            textVize.Font = new Font("Segoe UI", 17F);
            textVize.Location = new Point(311, 64);
            textVize.Name = "textVize";
            textVize.Size = new Size(338, 38);
            textVize.TabIndex = 2;
            // 
            // textFinal
            // 
            textFinal.Font = new Font("Segoe UI", 17F);
            textFinal.Location = new Point(311, 145);
            textFinal.Name = "textFinal";
            textFinal.Size = new Size(338, 38);
            textFinal.TabIndex = 3;
            // 
            // hesapla
            // 
            hesapla.Location = new Point(278, 281);
            hesapla.Name = "hesapla";
            hesapla.Size = new Size(171, 66);
            hesapla.TabIndex = 4;
            hesapla.Text = "Hesapla";
            hesapla.UseVisualStyleBackColor = true;
            hesapla.Click += hesapla_Click;
            // 
            // lblHarfNotu
            // 
            lblHarfNotu.Font = new Font("Segoe UI", 20F);
            lblHarfNotu.Location = new Point(4, 241);
            lblHarfNotu.Name = "lblHarfNotu";
            lblHarfNotu.Size = new Size(770, 37);
            lblHarfNotu.TabIndex = 5;
            lblHarfNotu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 458);
            Controls.Add(lblHarfNotu);
            Controls.Add(hesapla);
            Controls.Add(textFinal);
            Controls.Add(textVize);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sınav Hesaplayıcı";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textVize;
        private TextBox textFinal;
        private Button hesapla;
        private Label lblHarfNotu;
    }
}
