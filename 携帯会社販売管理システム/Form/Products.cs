using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using 携帯会社販売管理システム.Model.Entities.DB;
using 携帯会社販売管理システム.Service;
using FastMember;

namespace 携帯会社販売管理システム
{
    public partial class Products : Form
    {

        private InventoryManage db = new InventoryManage();
        private ProductService productService = new ProductService();
        // 入力チェックモジュール
        private InputCheck _ic = new InputCheck();

        // メッセージ
        private Messages _ms = new Messages();
        public Products()
        {
            InitializeComponent();
        }
      
        public void ShowProductList()
        {
            //M_Product テブールを表示する
            //var query = db.M_Product;
            //dataGridViewPr.DataSource = query.ToList();
            //Linqで使う
            var query = from pr in db.M_Product
                        select new
                        {
                            商品ID = pr.PrID,
                            商品名 = pr.PrName,
                            営業所 = pr.M_SalesOffice.SOName,
                            商品番号 = pr.Mnumber,
                            カラー名 = pr.Color,
                            商品コード = pr.PrCode,
                            単価 = pr.PrUnitPrice,
                            合計金額 = pr.PrTotal,
                            発売日 = pr.Rdate,
                            グラフ = pr.PDFlag,
                            非常示理由 = pr.PrHidden
                        };
            dataGridViewPr.DataSource = query.ToList();
        }

        public void ShowProductList(String prID, String prName)
        {
            if (!String.IsNullOrEmpty(prID))
            {
                var queryId = from pr in db.M_Product
                                  //where(pr => pr.PrName.Contains(prName))
                                  //where (String.IsNullOrEmpty(prName) ? false : (pr.PrName.Contains(prName)) | String.IsNullOrEmpty(prID)?false:(pr.PrID.Contains(prID)))
                              where pr.PrID.Contains(prID)
                              select new
                              {
                                  商品ID = pr.PrID,
                                  商品名 = pr.PrName,
                                  営業所 = pr.M_SalesOffice.SOName,
                                  商品番号 = pr.Mnumber,
                                  カラー名 = pr.Color,
                                  商品コード = pr.PrCode,
                                  単価 = pr.PrUnitPrice,
                                  合計金額 = pr.PrTotal,
                                  発売日 = pr.Rdate,
                                  グラフ = pr.PDFlag,
                                  非常示理由 = pr.PrHidden
                              };
                if (queryId.Count() != 0)
                {
                    dataGridViewPr.DataSource = queryId.ToList();
                }
            }
            if (!String.IsNullOrEmpty(prName))
            {
                var queryName = from pr in db.M_Product
                                    //where(pr => pr.PrName.Contains(prName))
                                    //where (String.IsNullOrEmpty(prName) ? false : (pr.PrName.Contains(prName)) | String.IsNullOrEmpty(prID)?false:(pr.PrID.Contains(prID)))
                                where pr.PrName.Contains(prName)
                                select new
                                {
                                    商品ID = pr.PrID,
                                    商品名 = pr.PrName,
                                    営業所 = pr.M_SalesOffice.SOName,
                                    商品番号 = pr.Mnumber,
                                    カラー名 = pr.Color,
                                    商品コード = pr.PrCode,
                                    単価 = pr.PrUnitPrice,
                                    合計金額 = pr.PrTotal,
                                    発売日 = pr.Rdate,
                                    グラフ = pr.PDFlag,
                                    非常示理由 = pr.PrHidden
                                };
                if (queryName.Count() != 0)
                {
                    dataGridViewPr.DataSource = queryName.ToList();
                }
            }
        }


        private void Products_Load(object sender, EventArgs e)
        {
            ShowProductList();
            SaleOfficeService saleOfficeService = new SaleOfficeService();

            var list = saleOfficeService.GetSaleOffice();
            //tao 1 bang
            DataTable dataTable = new DataTable();
            using (var reader = ObjectReader.Create(list))
            {
                dataTable.Load(reader);
            }
            cbSaleOf.DataSource = dataTable;
            //hthi tren giao dien
            cbSaleOf.DisplayMember = "SOName";
            //gtri thuc
            cbSaleOf.ValueMember = "SOID";
        }

        private void btPrList_Click(object sender, EventArgs e)
        {

            ShowProductList();
        }

        private void btPrRegistration_Click(object sender, EventArgs e)
        {
            M_Product pr = new M_Product();
            pr.PrID = textBoxPrID.Text;
            pr.PrName = textBoxPrName.Text;
            pr.PrCode = textBoxPrCode.Text;
            pr.SOID = (int)cbSaleOf.SelectedValue;
            pr.PrTotal = textBoxPrTotal.Text;
            pr.Mnumber = int.Parse(textBoxPrNum.Text);
            pr.Color = textBoxPrColor.Text;
            pr.PrUnitPrice = double.Parse(textBoxPrUnitPrice.Text);
            pr.Rdate = dtPrDate.Value;
            if (cbPrFlag.Text == "1")
            {
                pr.PDFlag = true;
            }
            else
            {
                pr.PDFlag = false;
            }
            bool check = productService.AddPr(pr);
            if (check)
            {
                MessageBox.Show("登録できました！");
            }
            else
            {
                MessageBox.Show("エーラ！");
            }
            ShowProductList();
        }

        // sự kiện CellClick
        //CellClick 処理
        private void dataGridViewPr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPrID.Text = dataGridViewPr.CurrentRow.Cells[0].Value.ToString();
            textBoxPrName.Text = dataGridViewPr.CurrentRow.Cells[1].Value.ToString();
            cbSaleOf.Text = dataGridViewPr.CurrentRow.Cells[2].Value.ToString();
            textBoxPrNum.Text = dataGridViewPr.CurrentRow.Cells[3].Value.ToString();
            textBoxPrColor.Text = dataGridViewPr.CurrentRow.Cells[4].Value.ToString();
            textBoxPrCode.Text = dataGridViewPr.CurrentRow.Cells[5].Value.ToString();
            textBoxPrUnitPrice.Text = dataGridViewPr.CurrentRow.Cells[6].Value.ToString();
           // textBoxPrTotal.Text = dataGridViewPr.CurrentRow.Cells[7].Value.ToString();
            cbPrFlag.Text = dataGridViewPr.CurrentRow.Cells[9].Value.ToString() == "True" ? "1" : "0";
            //textBoxPrHidden.Text = dataGridViewPr.CurrentRow.Cells[10].Value.ToString();
            dtPrDate.Value = Convert.ToDateTime(dataGridViewPr.CurrentRow.Cells[8].Value);
        }


        //Xoa du lieu
        private void btDeletePr_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("情報が変わる。続けたい?", "メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bool check;
                //Kiem tra chuoi ben trong textboxID co ton tai hay k?
                //Neu ton tai -> xoa, ngc lai xuat hien thong bao k ton tai sp nay
                if (!string.IsNullOrEmpty(textBoxPrID.Text))
                {
                    check = productService.DeletePr(textBoxPrID.Text);
                    if (check)
                    {
                        // xoa -> cap nhat lai danh sach
                        MessageBox.Show("削除出来た");
                        ShowProductList();
                    }
                    else
                    {
                        MessageBox.Show("削除できません");
                    }
                }
                else
                {
                    MessageBox.Show("エーラ");
                    return;
                }
            }

        }
        //Xu li don gia va tien thue
        //税込の処理
        private void textBoxPrUnitPrice_TextChanged(object sender, EventArgs e)
        {
            double price, total;
            if (textBoxPrUnitPrice.Text == "")
                price = 0;
            else
                price = Convert.ToDouble(textBoxPrUnitPrice.Text);
            total = price + (price * 10 / 100);
            textBoxPrTotal.Text = total.ToString();
        }

        private void btPrUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            M_Product pr = new M_Product();
            DialogResult dialog;
            dialog = MessageBox.Show("情報が変わりますが、続けますか？", "メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(textBoxPrID.Text))
                {
                    pr.PrID = textBoxPrID.Text;
                    check = productService.checkPr(textBoxPrID.Text);
                    if (check)
                    {
                        pr.PrName = textBoxPrName.Text;
                        pr.PrCode = textBoxPrCode.Text;
                        pr.SOID = (int)cbSaleOf.SelectedValue;
                        pr.PrTotal = textBoxPrTotal.Text;
                        pr.Mnumber = int.Parse(textBoxPrNum.Text);
                        pr.Color = textBoxPrColor.Text;
                        pr.PrUnitPrice = double.Parse(textBoxPrUnitPrice.Text);
                        pr.Rdate = dtPrDate.Value;
                        if (cbPrFlag.Text == "1")
                        {
                            pr.PDFlag = true;
                        }
                        else
                        {
                            pr.PDFlag = false;
                        }
                        MessageBox.Show("更新出来た！");
                        productService.UpdatePr(pr);
                        ShowProductList();
                    }
                    else
                    {
                        MessageBox.Show("更新できません。");
                    }
                }
                else
                {
                    MessageBox.Show("エーラ");
                    return;
                }
            }
        }

        private void btPrSearch_Click(object sender, EventArgs e)
        {
            M_Product pr = new M_Product();
            if (textBoxPrName.Text == "" && textBoxPrID.Text == "")
            {
                MessageBox.Show("商品の情報を入力してください！", "メッセージ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool check = productService.SearchPr(textBoxPrName.Text, textBoxPrID.Text);
            if (check)
            {
                ShowProductList(textBoxPrID.Text, textBoxPrName.Text);
            }
            else
            {
                MessageBox.Show("見つけませんでした！！！");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        public void Clear()
        {
            textBoxPrID.Clear();
            textBoxPrName.Clear();
            textBoxPrCode.Text = null;
            cbSaleOf.SelectedIndex = -1;
            textBoxPrTotal.Text = null;
            textBoxPrNum.Text = null;
            textBoxPrColor.Clear();
            textBoxPrUnitPrice.Text = null;
            dtPrDate.CustomFormat = "";
            cbPrFlag.SelectedIndex = -1;
            textBoxPrHidden.Clear();
        }
        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("在庫管理を終了してよろしいですか？", "終了確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

