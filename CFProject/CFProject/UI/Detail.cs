using CFProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFProject
{
    public partial class Detail : Form
    {
        private int id = -1;
       

        public Detail()
        {
            InitializeComponent();
        }

        public Detail(int i)
        {
            InitializeComponent();
            this.id = i;
            btnPrint.Click += new EventHandler(printButton_Click);
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        }

        private PrintDocument printDocument = new PrintDocument();

        private void Detail_Load(object sender, EventArgs e)
        {
            Bitmap avt = new Bitmap(Application.StartupPath + "\\Resources\\avatar.jpg");
            pbAvatar.Image = avt;

            using (var db = new QLCafeEntities())
            {
                var billInfo = db.HoaDons.Find(id);
                var accInfo = db.TaiKhoans.Find(billInfo.MaTaiKhoan);
                lblMaNV.Text = "NV" + accInfo.MaTaiKhoan.ToString();
                lblName.Text = accInfo.NguoiQuanLi.HoTen;
                lblDate.Text = billInfo.NgayLapHoaDon.ToString();
                lblCost.Text = billInfo.TongTien.ToString() + " VNĐ";

                var l = db.ChiTietHoaDons.Where(d => d.MaHoaDon == id).ToList();
                int[] xLocation = { 10, 100, 300, 400 };
                var yLocation = 10;
                int stt = 1;
                foreach (var index in l)
                {
                    Label lblID = new Label();
                    lblID.Size = new Size(90, 20);
                    lblID.Text = stt.ToString();
                    lblID.Font = new Font("Time New Roman", 9.75F, FontStyle.Regular);
                    lblID.Location = new System.Drawing.Point(xLocation[0], yLocation);
                    pnDetail.Controls.Add(lblID);

                    Label lblName = new Label();
                    lblName.Size = new Size(200, 20);
                    lblName.Text = index.SanPham.TenSanPham;
                    lblName.Font = new Font("Time New Roman", 9.75F, FontStyle.Regular);
                    lblName.Location = new System.Drawing.Point(xLocation[1], yLocation);
                    pnDetail.Controls.Add(lblName);

                    Label lblNumber = new Label();
                    lblNumber.Size = new Size(100, 20);
                    lblNumber.Text = index.SoLuong.ToString();
                    lblNumber.Font = new Font("Time New Roman", 9.75F, FontStyle.Regular);
                    lblNumber.Location = new System.Drawing.Point(xLocation[2], yLocation);
                    pnDetail.Controls.Add(lblNumber);

                    Label lblCost = new Label();
                    lblCost.Size = new Size(100, 20);
                    lblCost.Text = index.DonGia.ToString() + " đ";
                    lblCost.Font = new Font("Time New Roman", 9.75F, FontStyle.Regular);
                    lblCost.Location = new System.Drawing.Point(xLocation[3], yLocation);
                    pnDetail.Controls.Add(lblCost);

                    yLocation += 40;
                    stt++;
                }
            }
        }

        void printButton_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            PrintDialog printDlg = new PrintDialog();
            printDocument.DocumentName = "hoadon";
            printDlg.Document = printDocument;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            //Call ShowDialog
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            Size toPrint = s;
            toPrint.Width -= 20;
            toPrint.Height -= 80;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X+10, this.Location.Y+20, 0, 0, toPrint);
        }

        private void printDocument_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        
    }
}
