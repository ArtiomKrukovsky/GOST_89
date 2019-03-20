namespace Lab_5_GOST_89
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
            this.components = new System.ComponentModel.Container();
            this.text_Sms = new System.Windows.Forms.TextBox();
            this.text_Encript = new System.Windows.Forms.TextBox();
            this.btn_encr = new System.Windows.Forms.Button();
            this.text_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Random_genetate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_deEncrypt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DeEncrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_Sms
            // 
            this.text_Sms.Location = new System.Drawing.Point(21, 49);
            this.text_Sms.Name = "text_Sms";
            this.text_Sms.Size = new System.Drawing.Size(153, 20);
            this.text_Sms.TabIndex = 0;
            // 
            // text_Encript
            // 
            this.text_Encript.Location = new System.Drawing.Point(216, 75);
            this.text_Encript.Name = "text_Encript";
            this.text_Encript.Size = new System.Drawing.Size(131, 20);
            this.text_Encript.TabIndex = 0;
            // 
            // btn_encr
            // 
            this.btn_encr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_encr.ForeColor = System.Drawing.Color.Maroon;
            this.btn_encr.Location = new System.Drawing.Point(42, 75);
            this.btn_encr.Name = "btn_encr";
            this.btn_encr.Size = new System.Drawing.Size(119, 28);
            this.btn_encr.TabIndex = 1;
            this.btn_encr.Text = "Зашифровать";
            this.btn_encr.UseVisualStyleBackColor = true;
            this.btn_encr.Click += new System.EventHandler(this.btn_encr_Click);
            // 
            // text_key
            // 
            this.text_key.Location = new System.Drawing.Point(216, 27);
            this.text_key.Name = "text_key";
            this.text_key.Size = new System.Drawing.Size(62, 20);
            this.text_key.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поле ввода сообщения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(213, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ключ:";
            // 
            // Random_genetate
            // 
            this.Random_genetate.Location = new System.Drawing.Point(275, 27);
            this.Random_genetate.Name = "Random_genetate";
            this.Random_genetate.Size = new System.Drawing.Size(15, 15);
            this.Random_genetate.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Random_genetate, "Сгенерировать рандомный ключ");
            this.Random_genetate.UseVisualStyleBackColor = true;
            this.Random_genetate.Click += new System.EventHandler(this.Random_genetate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(213, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Полученный шифр:";
            // 
            // text_deEncrypt
            // 
            this.text_deEncrypt.Location = new System.Drawing.Point(102, 139);
            this.text_deEncrypt.Name = "text_deEncrypt";
            this.text_deEncrypt.Size = new System.Drawing.Size(131, 20);
            this.text_deEncrypt.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(90, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Расшифрованное смс:";
            // 
            // DeEncrypt
            // 
            this.DeEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeEncrypt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.DeEncrypt.Location = new System.Drawing.Point(273, 92);
            this.DeEncrypt.Name = "DeEncrypt";
            this.DeEncrypt.Size = new System.Drawing.Size(74, 20);
            this.DeEncrypt.TabIndex = 4;
            this.DeEncrypt.Text = "DeEncrypt";
            this.DeEncrypt.UseVisualStyleBackColor = true;
            this.DeEncrypt.Click += new System.EventHandler(this.DeEncrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 177);
            this.Controls.Add(this.DeEncrypt);
            this.Controls.Add(this.Random_genetate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_encr);
            this.Controls.Add(this.text_deEncrypt);
            this.Controls.Add(this.text_Encript);
            this.Controls.Add(this.text_key);
            this.Controls.Add(this.text_Sms);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laba_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Sms;
        private System.Windows.Forms.TextBox text_Encript;
        private System.Windows.Forms.Button btn_encr;
        private System.Windows.Forms.TextBox text_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Random_genetate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_deEncrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeEncrypt;
    }
}

