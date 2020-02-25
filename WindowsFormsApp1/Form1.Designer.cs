namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.encrypt_text = new System.Windows.Forms.TextBox();
            this.decrypt_text = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.diametr = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.origintext = new System.Windows.Forms.TextBox();
            this.outText = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyCezar = new System.Windows.Forms.TextBox();
            this.originCezar = new System.Windows.Forms.TextBox();
            this.outCezar = new System.Windows.Forms.TextBox();
            this.Cezar_enc = new System.Windows.Forms.Button();
            this.Cezarus_dec = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // encrypt_text
            // 
            this.encrypt_text.Location = new System.Drawing.Point(8, 36);
            this.encrypt_text.Multiline = true;
            this.encrypt_text.Name = "encrypt_text";
            this.encrypt_text.Size = new System.Drawing.Size(343, 492);
            this.encrypt_text.TabIndex = 0;
            this.encrypt_text.TextChanged += new System.EventHandler(this.encrypt_text_TextChanged);
            // 
            // decrypt_text
            // 
            this.decrypt_text.Location = new System.Drawing.Point(611, 36);
            this.decrypt_text.Multiline = true;
            this.decrypt_text.Name = "decrypt_text";
            this.decrypt_text.Size = new System.Drawing.Size(343, 492);
            this.decrypt_text.TabIndex = 1;
            this.decrypt_text.TextChanged += new System.EventHandler(this.decrypt_text_TextChanged);
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(357, 120);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(248, 60);
            this.encrypt.TabIndex = 2;
            this.encrypt.Text = "Зашифровать";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(357, 186);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(248, 60);
            this.decrypt.TabIndex = 3;
            this.decrypt.Text = "Расшифровать";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(970, 565);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.encrypt_text);
            this.tabPage1.Controls.Add(this.decrypt);
            this.tabPage1.Controls.Add(this.decrypt_text);
            this.tabPage1.Controls.Add(this.encrypt);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(962, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Атбаш";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.diametr);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.origintext);
            this.tabPage2.Controls.Add(this.outText);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(962, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сцитала";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите диаметр цилиндра";
            // 
            // diametr
            // 
            this.diametr.Location = new System.Drawing.Point(424, 266);
            this.diametr.Name = "diametr";
            this.diametr.Size = new System.Drawing.Size(117, 22);
            this.diametr.TabIndex = 9;
            this.diametr.TextChanged += new System.EventHandler(this.diametr_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 60);
            this.button2.TabIndex = 8;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // origintext
            // 
            this.origintext.Location = new System.Drawing.Point(8, 24);
            this.origintext.Multiline = true;
            this.origintext.Name = "origintext";
            this.origintext.Size = new System.Drawing.Size(343, 492);
            this.origintext.TabIndex = 5;
            this.origintext.TextChanged += new System.EventHandler(this.origintext_TextChanged);
            // 
            // outText
            // 
            this.outText.Location = new System.Drawing.Point(613, 24);
            this.outText.Multiline = true;
            this.outText.Name = "outText";
            this.outText.Size = new System.Drawing.Size(343, 492);
            this.outText.TabIndex = 6;
            this.outText.TextChanged += new System.EventHandler(this.outText_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.KeyCezar);
            this.tabPage3.Controls.Add(this.originCezar);
            this.tabPage3.Controls.Add(this.outCezar);
            this.tabPage3.Controls.Add(this.Cezar_enc);
            this.tabPage3.Controls.Add(this.Cezarus_dec);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(962, 536);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Цезаря";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(435, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите ключ";
            // 
            // KeyCezar
            // 
            this.KeyCezar.Location = new System.Drawing.Point(424, 266);
            this.KeyCezar.Name = "KeyCezar";
            this.KeyCezar.Size = new System.Drawing.Size(117, 22);
            this.KeyCezar.TabIndex = 4;
            this.KeyCezar.TextChanged += new System.EventHandler(this.KeyCezar_TextChanged);
            // 
            // originCezar
            // 
            this.originCezar.Location = new System.Drawing.Point(8, 24);
            this.originCezar.Multiline = true;
            this.originCezar.Name = "originCezar";
            this.originCezar.Size = new System.Drawing.Size(343, 492);
            this.originCezar.TabIndex = 3;
            this.originCezar.TextChanged += new System.EventHandler(this.originCezar_TextChanged);
            // 
            // outCezar
            // 
            this.outCezar.Location = new System.Drawing.Point(613, 24);
            this.outCezar.Multiline = true;
            this.outCezar.Name = "outCezar";
            this.outCezar.Size = new System.Drawing.Size(343, 492);
            this.outCezar.TabIndex = 2;
            this.outCezar.TextChanged += new System.EventHandler(this.outCezar_TextChanged);
            // 
            // Cezar_enc
            // 
            this.Cezar_enc.Location = new System.Drawing.Point(357, 120);
            this.Cezar_enc.Name = "Cezar_enc";
            this.Cezar_enc.Size = new System.Drawing.Size(248, 60);
            this.Cezar_enc.TabIndex = 1;
            this.Cezar_enc.Text = "Зашифровать";
            this.Cezar_enc.UseVisualStyleBackColor = true;
            this.Cezar_enc.Click += new System.EventHandler(this.Cezar_enc_Click);
            // 
            // Cezarus_dec
            // 
            this.Cezarus_dec.Location = new System.Drawing.Point(357, 187);
            this.Cezarus_dec.Name = "Cezarus_dec";
            this.Cezarus_dec.Size = new System.Drawing.Size(248, 60);
            this.Cezarus_dec.TabIndex = 0;
            this.Cezarus_dec.Text = "Расшифровать";
            this.Cezarus_dec.UseVisualStyleBackColor = true;
            this.Cezarus_dec.Click += new System.EventHandler(this.Cezarus_dec_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(698, 201);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(698, 201);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 565);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Криптография";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox encrypt_text;
        private System.Windows.Forms.TextBox decrypt_text;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox diametr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox origintext;
        private System.Windows.Forms.TextBox outText;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyCezar;
        private System.Windows.Forms.TextBox originCezar;
        private System.Windows.Forms.TextBox outCezar;
        private System.Windows.Forms.Button Cezar_enc;
        private System.Windows.Forms.Button Cezarus_dec;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

