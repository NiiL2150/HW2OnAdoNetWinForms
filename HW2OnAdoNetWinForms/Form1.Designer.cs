
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
            this.btnProd = new System.Windows.Forms.Button();
            this.btnTypes = new System.Windows.Forms.Button();
            this.btnManagers = new System.Windows.Forms.Button();
            this.btnBuyers = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn17 = new System.Windows.Forms.Button();
            this.btn18 = new System.Windows.Forms.Button();
            this.btn19 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(530, 71);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(177, 20);
            this.infoBox.TabIndex = 0;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(614, 12);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(93, 23);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "Show products";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(530, 12);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(78, 23);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "Show types";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(339, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(185, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Show managers";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 13);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(153, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Show min bought products";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(171, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(162, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Show max bought products";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(220, 129);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(245, 23);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "Show the cheapest product";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(12, 129);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(202, 23);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "Show the most expensive product";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(339, 41);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(185, 23);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "Show the most recent sale";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(12, 42);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(321, 23);
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
            this.dgData.Location = new System.Drawing.Point(12, 158);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(535, 280);
            this.dgData.TabIndex = 13;
            // 
            // btnProd
            // 
            this.btnProd.Location = new System.Drawing.Point(553, 213);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(154, 23);
            this.btnProd.TabIndex = 14;
            this.btnProd.Text = "Products";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnTypes
            // 
            this.btnTypes.Location = new System.Drawing.Point(553, 242);
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.Size = new System.Drawing.Size(154, 23);
            this.btnTypes.TabIndex = 15;
            this.btnTypes.Text = "Types";
            this.btnTypes.UseVisualStyleBackColor = true;
            this.btnTypes.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnManagers
            // 
            this.btnManagers.Location = new System.Drawing.Point(553, 271);
            this.btnManagers.Name = "btnManagers";
            this.btnManagers.Size = new System.Drawing.Size(154, 23);
            this.btnManagers.TabIndex = 16;
            this.btnManagers.Text = "Managers";
            this.btnManagers.UseVisualStyleBackColor = true;
            this.btnManagers.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnBuyers
            // 
            this.btnBuyers.Location = new System.Drawing.Point(553, 300);
            this.btnBuyers.Name = "btnBuyers";
            this.btnBuyers.Size = new System.Drawing.Size(154, 23);
            this.btnBuyers.TabIndex = 17;
            this.btnBuyers.Text = "Buyers";
            this.btnBuyers.UseVisualStyleBackColor = true;
            this.btnBuyers.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(553, 358);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 37);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(553, 329);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(154, 23);
            this.btnSales.TabIndex = 19;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(553, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 37);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(553, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2021, 11, 7, 20, 9, 20, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(553, 187);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.Value = new System.DateTime(2021, 11, 7, 20, 9, 29, 0);
            // 
            // btn14
            // 
            this.btn14.Location = new System.Drawing.Point(114, 100);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(100, 23);
            this.btn14.TabIndex = 24;
            this.btn14.Text = "Most $$$ seller";
            this.btn14.UseVisualStyleBackColor = true;
            this.btn14.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn13
            // 
            this.btn13.Location = new System.Drawing.Point(12, 100);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(96, 23);
            this.btn13.TabIndex = 23;
            this.btn13.Text = "Most sales seller";
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn15
            // 
            this.btn15.Location = new System.Drawing.Point(220, 100);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(113, 23);
            this.btn15.TabIndex = 25;
            this.btn15.Text = "Most $$$ buyer";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn16
            // 
            this.btn16.Location = new System.Drawing.Point(339, 100);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(126, 23);
            this.btn16.TabIndex = 26;
            this.btn16.Text = "Most sales type";
            this.btn16.UseVisualStyleBackColor = true;
            this.btn16.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn17
            // 
            this.btn17.Location = new System.Drawing.Point(471, 100);
            this.btn17.Name = "btn17";
            this.btn17.Size = new System.Drawing.Size(112, 23);
            this.btn17.TabIndex = 27;
            this.btn17.Text = "Most $$$ type";
            this.btn17.UseVisualStyleBackColor = true;
            this.btn17.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn18
            // 
            this.btn18.Location = new System.Drawing.Point(589, 100);
            this.btn18.Name = "btn18";
            this.btn18.Size = new System.Drawing.Size(118, 23);
            this.btn18.TabIndex = 28;
            this.btn18.Text = "Most popular prod";
            this.btn18.UseVisualStyleBackColor = true;
            this.btn18.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn19
            // 
            this.btn19.Location = new System.Drawing.Point(471, 129);
            this.btn19.Name = "btn19";
            this.btn19.Size = new System.Drawing.Size(236, 23);
            this.btn19.TabIndex = 29;
            this.btn19.Text = "Most $$$ seller between dates:";
            this.btn19.UseVisualStyleBackColor = true;
            this.btn19.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(530, 41);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(177, 23);
            this.btn20.TabIndex = 30;
            this.btn20.Text = "Products weren\'t sold in ... days";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn19);
            this.Controls.Add(this.btn18);
            this.Controls.Add(this.btn17);
            this.Controls.Add(this.btn16);
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn14);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBuyers);
            this.Controls.Add(this.btnManagers);
            this.Controls.Add(this.btnTypes);
            this.Controls.Add(this.btnProd);
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
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnTypes;
        private System.Windows.Forms.Button btnManagers;
        private System.Windows.Forms.Button btnBuyers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn17;
        private System.Windows.Forms.Button btn18;
        private System.Windows.Forms.Button btn19;
        private System.Windows.Forms.Button btn20;
    }
}

