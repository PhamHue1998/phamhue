using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 携帯会社販売管理システム.Model.Entities.DB;
using 携帯会社販売管理システム.Service;

namespace 携帯会社販売管理システム
{
    public partial class Stock : Form
    {
        private InventoryManage db = new InventoryManage();
        private StockService stockService = new StockService();
        public Stock()
        {
            InitializeComponent();
        }
        public void ShowStockList()
        {
            var query = from st in db.T_Stock
                        select new
                        {
                            在庫ID = st.StockID,
                            商品名 = st.M_Product.PrName,
                            カーラー=st.M_Product.Color,
                            数量=st.Squantity
                        };
            dtGridViewStock.DataSource = query.ToList();
        }
        public void ShowStockList(string prName)
        {
            if (!String.IsNullOrEmpty(prName))
            {
                var queryId = from st in db.T_Stock
                              where st.M_Product.PrName.Contains(prName)
                              select new
                              {
                                  在庫ID = st.StockID,
                                  商品名 = st.M_Product.PrName,
                                  カーラー = st.M_Product.Color,
                                  数量 = st.Squantity
                              };
                if (queryId.Count() != 0)
                {
                    dtGridViewStock.DataSource = queryId.ToList();
                }
            }
        }
        private void PrStock_Load(object sender, EventArgs e)
        {
            ShowStockList();
        }

        private void btUpdate_St_Click_1(object sender, EventArgs e)
        {
            bool check;
            T_Stock st = new T_Stock();
            DialogResult dialog;
            dialog = MessageBox.Show("情報が変わりますが、続けますか？", "メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {

                if (!string.IsNullOrEmpty(int.Parse(tbStockID.Text).ToString()))
                {
                    
                    st.StockID = int.Parse(tbStockID.Text);
                    check = stockService.CheckStockID(int.Parse(tbStockID.Text));
                    if (check)
                    {
                        // st.PrID = tbStockPr.Text; 
                        st.Squantity = int.Parse(tbStockSquantity.Text);
                        MessageBox.Show("更新出来た！");
                        stockService.UpdateSt(st);
                        ShowStockList();
                    }
                    else
                    {
                        MessageBox.Show("更新できません!!!");
                    }
                }
                else
                {
                    MessageBox.Show("エーラ");
                    return;
                }
            }
        }

        private void btClear_Click_1(object sender, EventArgs e)
        {
            tbStockID.Clear();
            tbStockPr.Clear();
            tbColor.Clear();
            tbStockSquantity.Clear();
        }

        private void btSearch_St_Click_1(object sender, EventArgs e)
        {
            T_Stock stock = new T_Stock();
            if (tbStockPr.Text == "" && tbStockID.Text == "")
            {
                MessageBox.Show("商品の情報を入力してください！", "メッセージ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool check = stockService.SearchSt(tbStockPr.Text);
            if (check)
            {
                ShowStockList(tbStockPr.Text);
            }
            else
            {
                MessageBox.Show("見つけませんでした！！！");
            }
        }

        private void btList_St_Click_1(object sender, EventArgs e)
        {
            ShowStockList();
        }

        private void dtGridViewStock_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbStockID.Text = dtGridViewStock.CurrentRow.Cells[0].Value.ToString();
            tbStockPr.Text = dtGridViewStock.CurrentRow.Cells[1].Value.ToString();
            tbColor.Text = dtGridViewStock.CurrentRow.Cells[2].Value.ToString();
            tbStockSquantity.Text = dtGridViewStock.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("在庫管理を終了してよろしいですか？", "終了確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
