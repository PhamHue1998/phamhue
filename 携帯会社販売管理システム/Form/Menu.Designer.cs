namespace 携帯会社販売管理システム
{
    partial class Menu
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
            this.buttonPrManage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrManage
            // 
            this.buttonPrManage.BackgroundImage = global::携帯会社販売管理システム.Properties.Resources.商品1;
            this.buttonPrManage.Location = new System.Drawing.Point(74, 141);
            this.buttonPrManage.Name = "buttonPrManage";
            this.buttonPrManage.Size = new System.Drawing.Size(184, 157);
            this.buttonPrManage.TabIndex = 20;
            this.buttonPrManage.Text = "button3";
            this.buttonPrManage.UseVisualStyleBackColor = true;
            this.buttonPrManage.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "商品管理";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::携帯会社販売管理システム.Properties.Resources.在庫;
            this.button4.Location = new System.Drawing.Point(357, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 153);
            this.button4.TabIndex = 22;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "在庫管理";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(653, 21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 29);
            this.button7.TabIndex = 30;
            this.button7.Text = "ログアウト";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button7);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.buttonPrManage);
            this.panelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(776, 426);
            this.panelMenu.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.panelMenu);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "メニュー画面";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPrManage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panelMenu;
    }
}