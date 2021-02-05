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


namespace 携帯会社販売管理システム
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Inventory_Control;Integrated Security=True");
            try
            {
                con.Open();
                string empID = textBoxID.Text;
                string empPass = textBoxPass.Text;
                string sql = "select * from M_Employee where EmID = '" + empID + "' and Passwork = '" + empPass + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read() == true)
                {
                    MessageBox.Show("ログインは成功しました！");
                    //Menu form 表示する
                    Menu menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("ログインは失敗しました！");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("DB接続に失敗しました！");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 画面でメッセージを表示する
            if(MessageBox.Show("プログラムを閉めたいですか？", "メッセージ",MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
