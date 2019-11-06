using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class TaoTaiKhoan : Form
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length - 1 < 6)
                MessageBox.Show("Tên tài khoản quá ngắn");
            else
                    if (textBox1.Text.Length - 1 > 15)
                MessageBox.Show("Tên tài khoản quá dài");
            else
                        if (textBox1.Text.Trim().IndexOf(" ") != -1)
                MessageBox.Show("Tên tài khoản có khoảng trắng");
            else
                        if (textBox2.Text.Length - 1 < 8)
                MessageBox.Show("Mật khẩu quá ngắn");
            else
                            if (textBox2.Text.Length - 1 > 20)
                MessageBox.Show("Mật khẩu quá dài");
            else
                                if (textBox2.Text != textBox3.Text)
                MessageBox.Show("Password không trùng nhau");
            else
            {
                try
                {
                    cls.ThucThiSQLTheoPKN("insert into tblNhanVien(TAIKHOAN,MATKHAU,QUYENHAN)values('" + textBox1.Text + "','" + textBox2.Text + "','user')");
                    MessageBox.Show("Tạo tài khoản thành công hãy cập nhật thông tin cho tài khoản");
                }
                catch { MessageBox.Show("Không thể tạo được tài khoản"); }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool checkAcc(string Acc)
        {
            var a = Acc.Length;
            if(a>=6 && a<=15)
            {
                return true;
            }
            return false;
        }

        public bool checkPass(string Pass)
        {
            var a = Pass.Length;
            if (a >= 8 && a <= 20)
            {
                return true;
            }
            return false;
        }

        public bool checkSpace(string Space)
        {
            if(Space.IndexOf(" ") != -1)
            {
                return true;
            }
            return false;
        }

    }
}
