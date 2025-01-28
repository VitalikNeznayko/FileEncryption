namespace FileEncryption
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ChooseFIleEncoding = new System.Windows.Forms.Button();
            this.tb_4FileEncoding = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_keyEncoding = new System.Windows.Forms.TextBox();
            this.btn_encoding = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ChooseFIleDecoding = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_4FileDecoding = new System.Windows.Forms.TextBox();
            this.tb_keyDecoding = new System.Windows.Forms.TextBox();
            this.btn_decoding = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroBgWorkerundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_ChooseFIleEncoding);
            this.panel1.Controls.Add(this.tb_4FileEncoding);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_keyEncoding);
            this.panel1.Controls.Add(this.btn_encoding);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 234);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Вставте файл";
            // 
            // btn_ChooseFIleEncoding
            // 
            this.btn_ChooseFIleEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChooseFIleEncoding.Location = new System.Drawing.Point(192, 40);
            this.btn_ChooseFIleEncoding.Name = "btn_ChooseFIleEncoding";
            this.btn_ChooseFIleEncoding.Size = new System.Drawing.Size(44, 41);
            this.btn_ChooseFIleEncoding.TabIndex = 4;
            this.btn_ChooseFIleEncoding.Text = "🗃️";
            this.btn_ChooseFIleEncoding.UseVisualStyleBackColor = true;
            this.btn_ChooseFIleEncoding.Click += new System.EventHandler(this.btn_ChooseFIleEncoding_Click);
            // 
            // tb_4FileEncoding
            // 
            this.tb_4FileEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_4FileEncoding.Location = new System.Drawing.Point(26, 49);
            this.tb_4FileEncoding.Name = "tb_4FileEncoding";
            this.tb_4FileEncoding.ReadOnly = true;
            this.tb_4FileEncoding.Size = new System.Drawing.Size(160, 30);
            this.tb_4FileEncoding.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введіть ключ";
            // 
            // tb_keyEncoding
            // 
            this.tb_keyEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_keyEncoding.Location = new System.Drawing.Point(21, 121);
            this.tb_keyEncoding.Name = "tb_keyEncoding";
            this.tb_keyEncoding.Size = new System.Drawing.Size(215, 30);
            this.tb_keyEncoding.TabIndex = 1;
            // 
            // btn_encoding
            // 
            this.btn_encoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_encoding.Location = new System.Drawing.Point(21, 161);
            this.btn_encoding.Name = "btn_encoding";
            this.btn_encoding.Size = new System.Drawing.Size(215, 65);
            this.btn_encoding.TabIndex = 0;
            this.btn_encoding.Text = "Зашифрувати";
            this.btn_encoding.UseVisualStyleBackColor = true;
            this.btn_encoding.Click += new System.EventHandler(this.btn_encoding_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_ChooseFIleDecoding);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tb_4FileDecoding);
            this.panel2.Controls.Add(this.tb_keyDecoding);
            this.panel2.Controls.Add(this.btn_decoding);
            this.panel2.Location = new System.Drawing.Point(286, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 234);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Вставте файл";
            // 
            // btn_ChooseFIleDecoding
            // 
            this.btn_ChooseFIleDecoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChooseFIleDecoding.Location = new System.Drawing.Point(191, 40);
            this.btn_ChooseFIleDecoding.Name = "btn_ChooseFIleDecoding";
            this.btn_ChooseFIleDecoding.Size = new System.Drawing.Size(44, 41);
            this.btn_ChooseFIleDecoding.TabIndex = 7;
            this.btn_ChooseFIleDecoding.Text = "🗃️";
            this.btn_ChooseFIleDecoding.UseVisualStyleBackColor = true;
            this.btn_ChooseFIleDecoding.Click += new System.EventHandler(this.btn_ChooseFIleDecoding_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введіть ключ";
            // 
            // tb_4FileDecoding
            // 
            this.tb_4FileDecoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_4FileDecoding.Location = new System.Drawing.Point(25, 49);
            this.tb_4FileDecoding.Name = "tb_4FileDecoding";
            this.tb_4FileDecoding.ReadOnly = true;
            this.tb_4FileDecoding.Size = new System.Drawing.Size(160, 30);
            this.tb_4FileDecoding.TabIndex = 6;
            // 
            // tb_keyDecoding
            // 
            this.tb_keyDecoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_keyDecoding.Location = new System.Drawing.Point(25, 121);
            this.tb_keyDecoding.Name = "tb_keyDecoding";
            this.tb_keyDecoding.Size = new System.Drawing.Size(215, 30);
            this.tb_keyDecoding.TabIndex = 2;
            // 
            // btn_decoding
            // 
            this.btn_decoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_decoding.Location = new System.Drawing.Point(25, 161);
            this.btn_decoding.Name = "btn_decoding";
            this.btn_decoding.Size = new System.Drawing.Size(215, 65);
            this.btn_decoding.TabIndex = 1;
            this.btn_decoding.Text = "Розшифрувати";
            this.btn_decoding.UseVisualStyleBackColor = true;
            this.btn_decoding.Click += new System.EventHandler(this.btn_decoding_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Шифратор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(278, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дешифратор";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 293);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(529, 23);
            this.progressBar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 323);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Шифратор ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_encoding;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_decoding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_keyEncoding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_keyDecoding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ChooseFIleEncoding;
        private System.Windows.Forms.TextBox tb_4FileEncoding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ChooseFIleDecoding;
        private System.Windows.Forms.TextBox tb_4FileDecoding;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroBgWorkerundWorker1;
    }
}

