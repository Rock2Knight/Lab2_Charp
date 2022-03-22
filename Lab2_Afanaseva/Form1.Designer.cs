namespace Lab2_Afanaseva
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
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.drawCat1 = new System.Windows.Forms.Button();
            this.quit1 = new System.Windows.Forms.Button();
            this.drawFIO1 = new System.Windows.Forms.Button();
            this.drawA1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(12, 12);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(991, 581);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.Load += new System.EventHandler(this.AnT_Load);
            // 
            // drawCat1
            // 
            this.drawCat1.Location = new System.Drawing.Point(1033, 154);
            this.drawCat1.Name = "drawCat1";
            this.drawCat1.Size = new System.Drawing.Size(211, 34);
            this.drawCat1.TabIndex = 1;
            this.drawCat1.Text = "Нарисовать кота";
            this.drawCat1.UseVisualStyleBackColor = true;
            this.drawCat1.Click += new System.EventHandler(this.drawCat);
            // 
            // quit1
            // 
            this.quit1.Location = new System.Drawing.Point(1033, 216);
            this.quit1.Name = "quit1";
            this.quit1.Size = new System.Drawing.Size(211, 38);
            this.quit1.TabIndex = 2;
            this.quit1.Text = "Выйти";
            this.quit1.UseVisualStyleBackColor = true;
            this.quit1.Click += new System.EventHandler(this.Quit);
            // 
            // drawFIO1
            // 
            this.drawFIO1.Location = new System.Drawing.Point(1033, 99);
            this.drawFIO1.Name = "drawFIO1";
            this.drawFIO1.Size = new System.Drawing.Size(211, 32);
            this.drawFIO1.TabIndex = 3;
            this.drawFIO1.Text = "Нарисовать ФИО";
            this.drawFIO1.UseVisualStyleBackColor = true;
            this.drawFIO1.Click += new System.EventHandler(this.drawFIO);
            // 
            // drawA1
            // 
            this.drawA1.Location = new System.Drawing.Point(1033, 34);
            this.drawA1.Name = "drawA1";
            this.drawA1.Size = new System.Drawing.Size(211, 39);
            this.drawA1.TabIndex = 4;
            this.drawA1.Text = "Нарисовать А";
            this.drawA1.UseVisualStyleBackColor = true;
            this.drawA1.Click += new System.EventHandler(this.drawA);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 658);
            this.Controls.Add(this.drawA1);
            this.Controls.Add(this.drawFIO1);
            this.Controls.Add(this.quit1);
            this.Controls.Add(this.drawCat1);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "Рисование 2D-примитивов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Button drawCat1;
        private System.Windows.Forms.Button quit1;
        private System.Windows.Forms.Button drawFIO1;
        private System.Windows.Forms.Button drawA1;
    }
}

