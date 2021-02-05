
namespace 携帯会社販売管理システム
{
    partial class Stock
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btClear = new System.Windows.Forms.Button();
            this.btList_St = new System.Windows.Forms.Button();
            this.btUpdate_St = new System.Windows.Forms.Button();
            this.btSearch_St = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStockID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStockSquantity = new System.Windows.Forms.TextBox();
            this.tbStockPr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dtGridViewStock = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewStock)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.dtGridViewStock);
            this.panel1.Location = new System.Drawing.Point(28, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 607);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Location = new System.Drawing.Point(467, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 106);
            this.panel3.TabIndex = 48;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(133, 17);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "登録・更新日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "登録・更新者";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 22);
            this.textBox3.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btClear);
            this.panel2.Controls.Add(this.btList_St);
            this.panel2.Controls.Add(this.btUpdate_St);
            this.panel2.Controls.Add(this.btSearch_St);
            this.panel2.Location = new System.Drawing.Point(14, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 62);
            this.panel2.TabIndex = 47;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.Silver;
            this.btClear.Location = new System.Drawing.Point(326, 14);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(59, 28);
            this.btClear.TabIndex = 44;
            this.btClear.Text = "クリア";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click_1);
            // 
            // btList_St
            // 
            this.btList_St.BackColor = System.Drawing.Color.Silver;
            this.btList_St.Location = new System.Drawing.Point(222, 16);
            this.btList_St.Name = "btList_St";
            this.btList_St.Size = new System.Drawing.Size(67, 26);
            this.btList_St.TabIndex = 31;
            this.btList_St.Text = "一覧表表示";
            this.btList_St.UseVisualStyleBackColor = false;
            this.btList_St.Click += new System.EventHandler(this.btList_St_Click_1);
            // 
            // btUpdate_St
            // 
            this.btUpdate_St.BackColor = System.Drawing.Color.Silver;
            this.btUpdate_St.Location = new System.Drawing.Point(7, 15);
            this.btUpdate_St.Name = "btUpdate_St";
            this.btUpdate_St.Size = new System.Drawing.Size(73, 27);
            this.btUpdate_St.TabIndex = 29;
            this.btUpdate_St.Text = "更新";
            this.btUpdate_St.UseVisualStyleBackColor = false;
            this.btUpdate_St.Click += new System.EventHandler(this.btUpdate_St_Click_1);
            // 
            // btSearch_St
            // 
            this.btSearch_St.BackColor = System.Drawing.Color.Silver;
            this.btSearch_St.Location = new System.Drawing.Point(122, 15);
            this.btSearch_St.Name = "btSearch_St";
            this.btSearch_St.Size = new System.Drawing.Size(73, 27);
            this.btSearch_St.TabIndex = 30;
            this.btSearch_St.Text = "検索";
            this.btSearch_St.UseVisualStyleBackColor = false;
            this.btSearch_St.Click += new System.EventHandler(this.btSearch_St_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbColor);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tbStockID);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.tbStockSquantity);
            this.panel4.Controls.Add(this.tbStockPr);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(14, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 279);
            this.panel4.TabIndex = 46;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(122, 135);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(153, 22);
            this.tbColor.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "カーラー";
            // 
            // tbStockID
            // 
            this.tbStockID.Location = new System.Drawing.Point(122, 21);
            this.tbStockID.Name = "tbStockID";
            this.tbStockID.Size = new System.Drawing.Size(153, 22);
            this.tbStockID.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "在庫ID";
            // 
            // tbStockSquantity
            // 
            this.tbStockSquantity.Location = new System.Drawing.Point(122, 188);
            this.tbStockSquantity.Name = "tbStockSquantity";
            this.tbStockSquantity.Size = new System.Drawing.Size(153, 22);
            this.tbStockSquantity.TabIndex = 44;
            // 
            // tbStockPr
            // 
            this.tbStockPr.Location = new System.Drawing.Point(122, 83);
            this.tbStockPr.Name = "tbStockPr";
            this.tbStockPr.Size = new System.Drawing.Size(153, 22);
            this.tbStockPr.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "数量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "商品名";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(885, 11);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(67, 39);
            this.buttonBack.TabIndex = 45;
            this.buttonBack.Text = "戻る";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click_1);
            // 
            // dtGridViewStock
            // 
            this.dtGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewStock.Location = new System.Drawing.Point(467, 157);
            this.dtGridViewStock.Name = "dtGridViewStock";
            this.dtGridViewStock.RowHeadersWidth = 51;
            this.dtGridViewStock.RowTemplate.Height = 24;
            this.dtGridViewStock.Size = new System.Drawing.Size(485, 437);
            this.dtGridViewStock.TabIndex = 44;
            this.dtGridViewStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewStock_CellClick_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(28, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(991, 58);
            this.panel5.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(399, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 35);
            this.label7.TabIndex = 48;
            this.label7.Text = "在庫管理";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 676);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在庫管理";
            this.Load += new System.EventHandler(this.PrStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewStock)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btList_St;
        private System.Windows.Forms.Button btUpdate_St;
        private System.Windows.Forms.Button btSearch_St;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStockID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStockSquantity;
        private System.Windows.Forms.TextBox tbStockPr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dtGridViewStock;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
    }
}