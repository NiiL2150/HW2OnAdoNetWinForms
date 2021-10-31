
namespace HW2OnAdoNetWinForms
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
            this.infoBox = new System.Windows.Forms.TextBox();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.dgData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(530, 71);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(258, 20);
            this.infoBox.TabIndex = 0;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(647, 12);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(141, 23);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "Show products";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(518, 12);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(123, 23);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "Show types";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(380, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(132, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Show managers";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 13);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(175, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Show min bought products";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(193, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(181, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Show max bought products";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(629, 42);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(159, 23);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "Show the cheapest product";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(424, 42);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(199, 23);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "Show the most expensive product";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(266, 42);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(152, 23);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "Show the most recent sale";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(12, 42);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(248, 23);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "Show average number of products for every type";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(12, 71);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(153, 23);
            this.btn10.TabIndex = 10;
            this.btn10.Text = "Show products sold by ...";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(171, 71);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(162, 23);
            this.btn11.TabIndex = 11;
            this.btn11.Text = "Show products bought by ...";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(339, 71);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(185, 23);
            this.btn12.TabIndex = 12;
            this.btn12.Text = "Show products with the type of ...";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn_Click);
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(12, 100);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(776, 338);
            this.dgData.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.infoBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.DataGridView dgData;
    }
}

