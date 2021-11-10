using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Services;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Services;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_DangNhap : Form
    {
        private IQLDangNhap _iQlDangNhap;
        private string key;
        private string pass;
        public string Ten;
        public int Quyen;
        //private Frm_GiaoDienChinh _frmGiaoDienChinh;
        public Frm_DangNhap()
        {
            key = "";
            pass = "";
          
            _iQlDangNhap = new QLDanhNhap();
            //_frmGiaoDienChinh = new Frm_GiaoDienChinh();
            InitializeComponent();
            PassWord();
            
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        void PassWord()
        {
            txt_matKhau.PasswordChar = '*';
        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            if (_iQlDangNhap.KiemtrKiemTraTKvaMK(txt_Email.Text, Encrypt(txt_matKhau.Text),1) == true)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                this.Hide();
                Frm_GiaoDienChinh frm_GiaoDienChinh = new Frm_GiaoDienChinh();
                frm_GiaoDienChinh.TenDN(txt_Email.Text);
                Frm_ThongKe tke = new Frm_ThongKe();
                tke.Quyen(1);
                frm_GiaoDienChinh.QuyenDN(1);
                frm_GiaoDienChinh.Show();
            }
            else if(_iQlDangNhap.KiemtrKiemTraTKvaMK1(txt_Email.Text, Encrypt(txt_matKhau.Text), 0) == true)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                this.Hide();
                Frm_GiaoDienND frm_GiaoDienND = new Frm_GiaoDienND();
                frm_GiaoDienND.TenDN(txt_Email.Text);
                frm_GiaoDienND.Show();
                Frm_ThongKe tke = new Frm_ThongKe();
                tke.Quyen(0);
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo");
            }
        }


        private void lbl_quenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đổi mật khẩu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pass = RandomPass(6);
                mail(txt_Email.Text, pass);
                //Lưu lại vào trong csdl
                Nhanvien NhanVien = new Nhanvien();
                NhanVien.Id = _iQlDangNhap.GetLstNhanvien().Where(c => c.Email == txt_Email.Text).Select(c => c.Id).FirstOrDefault();
                NhanVien.Manv = _iQlDangNhap.GetLstNhanvien().Where(c => c.Email == txt_Email.Text).Select(c => c.Manv).FirstOrDefault();
                NhanVien.Email = _iQlDangNhap.GetLstNhanvien().Where(c => c.Email == txt_Email.Text).Select(c => c.Email).FirstOrDefault();
                NhanVien.Tennv = _iQlDangNhap.GetLstNhanvien().Where(c => c.Email == txt_Email.Text).Select(c => c.Tennv).FirstOrDefault();
                NhanVien.Diachi = _iQlDangNhap.GetLstNhanvien().Where(c => c.Email == txt_Email.Text).Select(c => c.Diachi).FirstOrDefault();
                NhanVien.Vaitro = _iQlDangNhap.GetLstNhanvien().Where(c => c.Email == txt_Email.Text).Select(c => c.Vaitro).FirstOrDefault();
                NhanVien.Tinhtrang = _iQlDangNhap.GetLstNhanvien().Where(c => c.Email == txt_Email.Text).Select(c => c.Tinhtrang).FirstOrDefault();
                NhanVien.Matkhau = Encrypt(pass);

                _iQlDangNhap.LuuMatKhauMoi(NhanVien);
            }
            System.Windows.Forms.Application.Exit();

        }
        public void mail(string to, string mk)
        {
            string from = "congncph14366@fpt.edu.vn";
            #region Mật khẩu
            string pass = "CoNg2002";
            #endregion
            string subject = "Đổi Mật Khẩu Mới";
            string body = "Mật khẩu mới của bạn là: " + mk;
            SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
            mailclient.EnableSsl = true;
            mailclient.Credentials = new NetworkCredential(from, pass);

            MailMessage message = new MailMessage(from, to);
            message.Subject = subject;
            message.Body = body;

            mailclient.Send(message);
            MessageBox.Show("Mật khẩu đã được gửi qua email!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public string RandomPass(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public string Encrypt(string toEncrypt)
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }


    }
}

