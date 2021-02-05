namespace 携帯会社販売管理システム
{
    partial class Products
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btDeletePr = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btPrList = new System.Windows.Forms.Button();
            this.btPrUpdate = new System.Windows.Forms.Button();
            this.btPrRegistration = new System.Windows.Forms.Button();
            this.btPrSearch = new System.Windows.Forms.Button();
            this.dataGridViewPr = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btClear = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.cbSaleOf = new System.Windows.Forms.ComboBox();
            this.cbPrFlag = new System.Windows.Forms.ComboBox();
            this.dtPrDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrCode = new System.Windows.Forms.TextBox();
            this.textBoxPrColor = new System.Windows.Forms.TextBox();
            this.textBoxPrNum = new System.Windows.Forms.TextBox();
            this.textBoxPrHidden = new System.Windows.Forms.TextBox();
            this.textBoxPrTotal = new System.Windows.Forms.TextBox();
            this.textBoxPrUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxPrName = new System.Windows.Forms.TextBox();
            this.textBoxPrID = new System.Windows.Forms.TextBox();
            this.labelPrFlag = new System.Windows.Forms.Label();
            this.labelPrDate = new System.Windows.Forms.Label();
            this.labelPrCode = new System.Windows.Forms.Label();
            this.labelPrColor = new System.Windows.Forms.Label();
            this.labelPrNum = new System.Windows.Forms.Label();
            this.labelPrHidden = new System.Windows.Forms.Label();
            this.labelPrTotal = new System.Windows.Forms.Label();
            this.labelPrUnitPrice = new System.Windows.Forms.Label();
            this.labelPrSaleOf = new System.Windows.Forms.Label();
            this.labelPrName = new System.Windows.Forms.Label();
            this.labelPrID = new System.Windows.Forms.Label();
            this.mProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPr)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridViewPr);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 696);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(23, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(807, 39);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(333, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "商品管理";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btDeletePr);
            this.panel3.Controls.Add(this.btBack);
            this.panel3.Controls.Add(this.btPrList);
            this.panel3.Controls.Add(this.btPrUpdate);
            this.panel3.Controls.Add(this.btPrRegistration);
            this.panel3.Controls.Add(this.btPrSearch);
            this.panel3.Location = new System.Drawing.Point(23, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 62);
            this.panel3.TabIndex = 2;
            // 
            // btDeletePr
            // 
            this.btDeletePr.Location = new System.Drawing.Point(519, 22);
            this.btDeletePr.Name = "btDeletePr";
            this.btDeletePr.Size = new System.Drawing.Size(75, 23);
            this.btDeletePr.TabIndex = 5;
            this.btDeletePr.Text = "削除";
            this.btDeletePr.UseVisualStyleBackColor = true;
            this.btDeletePr.Click += new System.EventHandler(this.btDeletePr_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(655, 22);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(76, 23);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "戻る";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btPrList
            // 
            this.btPrList.Location = new System.Drawing.Point(391, 22);
            this.btPrList.Name = "btPrList";
            this.btPrList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btPrList.Size = new System.Drawing.Size(75, 23);
            this.btPrList.TabIndex = 3;
            this.btPrList.Text = "一覧表示";
            this.btPrList.UseVisualStyleBackColor = true;
            this.btPrList.Click += new System.EventHandler(this.btPrList_Click);
            // 
            // btPrUpdate
            // 
            this.btPrUpdate.Location = new System.Drawing.Point(274, 22);
            this.btPrUpdate.Name = "btPrUpdate";
            this.btPrUpdate.Size = new System.Drawing.Size(75, 23);
            this.btPrUpdate.TabIndex = 2;
            this.btPrUpdate.Text = "更新";
            this.btPrUpdate.UseVisualStyleBackColor = true;
            this.btPrUpdate.Click += new System.EventHandler(this.btPrUpdate_Click);
            // 
            // btPrRegistration
            // 
            this.btPrRegistration.Location = new System.Drawing.Point(159, 22);
            this.btPrRegistration.Name = "btPrRegistration";
            this.btPrRegistration.Size = new System.Drawing.Size(75, 23);
            this.btPrRegistration.TabIndex = 1;
            this.btPrRegistration.Text = "登録";
            this.btPrRegistration.UseVisualStyleBackColor = true;
            this.btPrRegistration.Click += new System.EventHandler(this.btPrRegistration_Click);
            // 
            // btPrSearch
            // 
            this.btPrSearch.Location = new System.Drawing.Point(53, 22);
            this.btPrSearch.Name = "btPrSearch";
            this.btPrSearch.Size = new System.Drawing.Size(75, 23);
            this.btPrSearch.TabIndex = 0;
            this.btPrSearch.Text = "検索";
            this.btPrSearch.UseVisualStyleBackColor = true;
            this.btPrSearch.Click += new System.EventHandler(this.btPrSearch_Click);
            // 
            // dataGridViewPr
            // 
            this.dataGridViewPr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPr.Location = new System.Drawing.Point(23, 431);
            this.dataGridViewPr.Name = "dataGridViewPr";
            this.dataGridViewPr.RowHeadersWidth = 51;
            this.dataGridViewPr.RowTemplate.Height = 24;
            this.dataGridViewPr.Size = new System.Drawing.Size(807, 238);
            this.dataGridViewPr.TabIndex = 1;
            this.dataGridViewPr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPr_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btClear);
            this.panel2.Controls.Add(this.btClose);
            this.panel2.Controls.Add(this.cbSaleOf);
            this.panel2.Controls.Add(this.cbPrFlag);
            this.panel2.Controls.Add(this.dtPrDate);
            this.panel2.Controls.Add(this.textBoxPrCode);
            this.panel2.Controls.Add(this.textBoxPrColor);
            this.panel2.Controls.Add(this.textBoxPrNum);
            this.panel2.Controls.Add(this.textBoxPrHidden);
            this.panel2.Controls.Add(this.textBoxPrTotal);
            this.panel2.Controls.Add(this.textBoxPrUnitPrice);
            this.panel2.Controls.Add(this.textBoxPrName);
            this.panel2.Controls.Add(this.textBoxPrID);
            this.panel2.Controls.Add(this.labelPrFlag);
            this.panel2.Controls.Add(this.labelPrDate);
            this.panel2.Controls.Add(this.labelPrCode);
            this.panel2.Controls.Add(this.labelPrColor);
            this.panel2.Controls.Add(this.labelPrNum);
            this.panel2.Controls.Add(this.labelPrHidden);
            this.panel2.Controls.Add(this.labelPrTotal);
            this.panel2.Controls.Add(this.labelPrUnitPrice);
            this.panel2.Controls.Add(this.labelPrSaleOf);
            this.panel2.Controls.Add(this.labelPrName);
            this.panel2.Controls.Add(this.labelPrID);
            this.panel2.Location = new System.Drawing.Point(23, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 315);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(671, 289);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 24;
            this.btClear.Text = "クリア";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(671, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 23;
            this.btClose.Text = "閉じる";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // cbSaleOf
            // 
            this.cbSaleOf.FormattingEnabled = true;
            this.cbSaleOf.Location = new System.Drawing.Point(104, 122);
            this.cbSaleOf.Name = "cbSaleOf";
            this.cbSaleOf.Size = new System.Drawing.Size(100, 23);
            this.cbSaleOf.TabIndex = 22;
            // 
            // cbPrFlag
            // 
            this.cbPrFlag.FormattingEnabled = true;
            this.cbPrFlag.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbPrFlag.Location = new System.Drawing.Point(478, 276);
            this.cbPrFlag.Name = "cbPrFlag";
            this.cbPrFlag.Size = new System.Drawing.Size(121, 23);
            this.cbPrFlag.TabIndex = 21;
            // 
            // dtPrDate
            // 
            this.dtPrDate.CustomFormat = "yyyy/MM/dd";
            this.dtPrDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPrDate.Location = new System.Drawing.Point(478, 232);
            this.dtPrDate.Name = "dtPrDate";
            this.dtPrDate.Size = new System.Drawing.Size(170, 22);
            this.dtPrDate.TabIndex = 20;
            // 
            // textBoxPrCode
            // 
            this.textBoxPrCode.Location = new System.Drawing.Point(478, 181);
            this.textBoxPrCode.Name = "textBoxPrCode";
            this.textBoxPrCode.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrCode.TabIndex = 19;
            // 
            // textBoxPrColor
            // 
            this.textBoxPrColor.Location = new System.Drawing.Point(478, 128);
            this.textBoxPrColor.Name = "textBoxPrColor";
            this.textBoxPrColor.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrColor.TabIndex = 18;
            // 
            // textBoxPrNum
            // 
            this.textBoxPrNum.Location = new System.Drawing.Point(478, 77);
            this.textBoxPrNum.Name = "textBoxPrNum";
            this.textBoxPrNum.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrNum.TabIndex = 17;
            // 
            // textBoxPrHidden
            // 
            this.textBoxPrHidden.Location = new System.Drawing.Point(478, 22);
            this.textBoxPrHidden.Name = "textBoxPrHidden";
            this.textBoxPrHidden.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrHidden.TabIndex = 16;
            // 
            // textBoxPrTotal
            // 
            this.textBoxPrTotal.Location = new System.Drawing.Point(104, 239);
            this.textBoxPrTotal.Name = "textBoxPrTotal";
            this.textBoxPrTotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrTotal.TabIndex = 15;
            // 
            // textBoxPrUnitPrice
            // 
            this.textBoxPrUnitPrice.Location = new System.Drawing.Point(104, 181);
            this.textBoxPrUnitPrice.Name = "textBoxPrUnitPrice";
            this.textBoxPrUnitPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrUnitPrice.TabIndex = 14;
            this.textBoxPrUnitPrice.TextChanged += new System.EventHandler(this.textBoxPrUnitPrice_TextChanged);
            // 
            // textBoxPrName
            // 
            this.textBoxPrName.Location = new System.Drawing.Point(104, 70);
            this.textBoxPrName.Name = "textBoxPrName";
            this.textBoxPrName.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrName.TabIndex = 12;
            // 
            // textBoxPrID
            // 
            this.textBoxPrID.Location = new System.Drawing.Point(104, 19);
            this.textBoxPrID.Name = "textBoxPrID";
            this.textBoxPrID.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrID.TabIndex = 11;
            // 
            // labelPrFlag
            // 
            this.labelPrFlag.AutoSize = true;
            this.labelPrFlag.Location = new System.Drawing.Point(380, 276);
            this.labelPrFlag.Name = "labelPrFlag";
            this.labelPrFlag.Size = new System.Drawing.Size(39, 15);
            this.labelPrFlag.TabIndex = 10;
            this.labelPrFlag.Text = "フラグ";
            // 
            // labelPrDate
            // 
            this.labelPrDate.AutoSize = true;
            this.labelPrDate.Location = new System.Drawing.Point(380, 232);
            this.labelPrDate.Name = "labelPrDate";
            this.labelPrDate.Size = new System.Drawing.Size(52, 15);
            this.labelPrDate.TabIndex = 9;
            this.labelPrDate.Text = "発売日";
            // 
            // labelPrCode
            // 
            this.labelPrCode.AutoSize = true;
            this.labelPrCode.Location = new System.Drawing.Point(380, 184);
            this.labelPrCode.Name = "labelPrCode";
            this.labelPrCode.Size = new System.Drawing.Size(70, 15);
            this.labelPrCode.TabIndex = 8;
            this.labelPrCode.Text = "商品コード";
            // 
            // labelPrColor
            // 
            this.labelPrColor.AutoSize = true;
            this.labelPrColor.Location = new System.Drawing.Point(380, 128);
            this.labelPrColor.Name = "labelPrColor";
            this.labelPrColor.Size = new System.Drawing.Size(55, 15);
            this.labelPrColor.TabIndex = 7;
            this.labelPrColor.Text = "カラー名";
            // 
            // labelPrNum
            // 
            this.labelPrNum.AutoSize = true;
            this.labelPrNum.Location = new System.Drawing.Point(380, 80);
            this.labelPrNum.Name = "labelPrNum";
            this.labelPrNum.Size = new System.Drawing.Size(37, 15);
            this.labelPrNum.TabIndex = 6;
            this.labelPrNum.Text = "番号";
            // 
            // labelPrHidden
            // 
            this.labelPrHidden.AutoSize = true;
            this.labelPrHidden.Location = new System.Drawing.Point(380, 25);
            this.labelPrHidden.Name = "labelPrHidden";
            this.labelPrHidden.Size = new System.Drawing.Size(82, 15);
            this.labelPrHidden.TabIndex = 5;
            this.labelPrHidden.Text = "非表示理由";
            // 
            // labelPrTotal
            // 
            this.labelPrTotal.AutoSize = true;
            this.labelPrTotal.Location = new System.Drawing.Point(31, 242);
            this.labelPrTotal.Name = "labelPrTotal";
            this.labelPrTotal.Size = new System.Drawing.Size(67, 15);
            this.labelPrTotal.TabIndex = 4;
            this.labelPrTotal.Text = "合計金額";
            // 
            // labelPrUnitPrice
            // 
            this.labelPrUnitPrice.AutoSize = true;
            this.labelPrUnitPrice.Location = new System.Drawing.Point(44, 181);
            this.labelPrUnitPrice.Name = "labelPrUnitPrice";
            this.labelPrUnitPrice.Size = new System.Drawing.Size(37, 15);
            this.labelPrUnitPrice.TabIndex = 3;
            this.labelPrUnitPrice.Text = "単価";
            // 
            // labelPrSaleOf
            // 
            this.labelPrSaleOf.AutoSize = true;
            this.labelPrSaleOf.Location = new System.Drawing.Point(44, 122);
            this.labelPrSaleOf.Name = "labelPrSaleOf";
            this.labelPrSaleOf.Size = new System.Drawing.Size(52, 15);
            this.labelPrSaleOf.TabIndex = 2;
            this.labelPrSaleOf.Text = "営業所";
            // 
            // labelPrName
            // 
            this.labelPrName.AutoSize = true;
            this.labelPrName.Location = new System.Drawing.Point(44, 67);
            this.labelPrName.Name = "labelPrName";
            this.labelPrName.Size = new System.Drawing.Size(52, 15);
            this.labelPrName.TabIndex = 1;
            this.labelPrName.Text = "商品名";
            // 
            // labelPrID
            // 
            this.labelPrID.AutoSize = true;
            this.labelPrID.Location = new System.Drawing.Point(44, 22);
            this.labelPrID.Name = "labelPrID";
            this.labelPrID.Size = new System.Drawing.Size(51, 15);
            this.labelPrID.TabIndex = 0;
            this.labelPrID.Text = "商品ID";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 760);
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPr)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtPrDate;
        private System.Windows.Forms.TextBox textBoxPrCode;
        private System.Windows.Forms.TextBox textBoxPrColor;
        private System.Windows.Forms.TextBox textBoxPrNum;
        private System.Windows.Forms.TextBox textBoxPrHidden;
        private System.Windows.Forms.TextBox textBoxPrTotal;
        private System.Windows.Forms.TextBox textBoxPrUnitPrice;
        private System.Windows.Forms.TextBox textBoxPrName;
        private System.Windows.Forms.TextBox textBoxPrID;
        private System.Windows.Forms.Label labelPrFlag;
        private System.Windows.Forms.Label labelPrDate;
        private System.Windows.Forms.Label labelPrCode;
        private System.Windows.Forms.Label labelPrColor;
        private System.Windows.Forms.Label labelPrNum;
        private System.Windows.Forms.Label labelPrHidden;
        private System.Windows.Forms.Label labelPrTotal;
        private System.Windows.Forms.Label labelPrUnitPrice;
        private System.Windows.Forms.Label labelPrSaleOf;
        private System.Windows.Forms.Label labelPrName;
        private System.Windows.Forms.Label labelPrID;
        private System.Windows.Forms.ComboBox cbPrFlag;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btPrList;
        private System.Windows.Forms.Button btPrUpdate;
        private System.Windows.Forms.Button btPrRegistration;
        private System.Windows.Forms.Button btPrSearch;
        private System.Windows.Forms.DataGridView dataGridViewPr;
        private System.Windows.Forms.BindingSource mProductBindingSource;
        private System.Windows.Forms.ComboBox cbSaleOf;
        private System.Windows.Forms.Button btDeletePr;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}