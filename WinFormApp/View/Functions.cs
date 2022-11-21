using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.Model;

namespace WinFormApp.View
{
    public class Functions
    {
        public Functions()
        {

        }
        public void turnOffButton(Button btn, PictureBox picture)
        {
            btn.Enabled = false;
            btn.BackColor = Color.FromArgb(238, 238, 238);
            picture.BackColor = Color.FromArgb(238, 238, 238);
        }
        public void turnOffButton(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.FromArgb(238, 238, 238);
        }
        public void turnOnButton(Button btn, PictureBox picture)
        {
            btn.Enabled = true;
            btn.BackColor = Color.FromArgb(23, 162, 139);
            picture.BackColor = Color.FromArgb(23, 162, 139);
        }
        public void turnOnButton(Button btn)
        {
            btn.Enabled = true;
            btn.BackColor = Color.FromArgb(23, 162, 139);
        }

        public string CreateID(string _lastID)
        {
            string firstSubID = _lastID.Substring(0, _lastID.Length - 5);
            string secondSubID = _lastID.Substring(_lastID.Length - 5);
            int secondSubIdNew = Convert.ToInt32(secondSubID) + 1;
            string newId = firstSubID + Convert.ToString(secondSubIdNew);
            return newId;
        }
        public string GetMD5(string plainText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plainText));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("X2"));
            }

            return strBuilder.ToString();
        }
        public byte[] ConvertImgToByte(string path)
        {
            FileStream fs;
            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        public Image ConvertByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            using (var ms = new MemoryStream(imgBytes))
            {
                return Image.FromStream(ms);
            }
        }
        
        public string GenerateID(int loaiHoaDon)
        {
            DateTime time = DateTime.Now;
            string MaHD_1 = time.ToString("dd") + time.ToString("MM") + time.ToString("yy");
            string MaHD_2 = "";
            if (loaiHoaDon == 1)
            {
                MaHD_2 = "X";
            }
            else
            {
                MaHD_2 = "N";
            }
            string MaHD_3 = time.ToString("HH") + time.ToString("mm") + time.ToString("ss");
            string MaHoaDon = MaHD_1 + MaHD_2 + MaHD_3;
            return MaHoaDon;
        }
    }
}
