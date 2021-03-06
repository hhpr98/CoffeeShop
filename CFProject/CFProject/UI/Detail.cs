﻿using CFProject.BUS;
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

            // declare
            var billInfo = new DetailBUS().findBillByID(id);
            var accInfo = new AccountBUS().findAccountByID((int)billInfo.MaTaiKhoan);
            var manInfo = new AccountBUS().findManager((int)billInfo.MaTaiKhoan);
            var l = new DetailBUS().findBillDetailByID(id);
            int[] xLocation = { 10, 60, 230, 300, 400 };
            var yLocation = 10;
            int stt = 1;

            // set data
            lblMaNV.Text = "NV" + accInfo.MaTaiKhoan.ToString();
            lblName.Text = manInfo.HoTen;
            lblDate.Text = billInfo.NgayLapHoaDon.ToString();
            lblCost.Text = billInfo.TongTien.ToString() + " VNĐ";
            
            foreach (var index in l)
            {
                Label lblID = new Label();
                lblID.Size = new Size(50, 20);
                lblID.Text = stt.ToString();
                lblID.Font = new Font("Time New Roman", 9.75F, FontStyle.Regular);
                lblID.Location = new System.Drawing.Point(xLocation[0], yLocation);
                pnDetail.Controls.Add(lblID);

                Label lblName = new Label();
                lblName.Size = new Size(150, 20);
                lblName.Text = new DetailBUS().findProductByID(index.MaSanPham).TenSanPham;
                lblName.Font = new Font("Time New Roman", 9.75F, FontStyle.Regular);
                lblName.Location = new System.Drawing.Point(xLocation[1], yLocation);
                pnDetail.Controls.Add(lblName);

                Label lblNumber = new Label();
                lblNumber.Size = new Size(70, 20);
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

                Label lblTotal = new Label();
                lblTotal.Size = new Size(100, 20);
                lblTotal.Text = (index.DonGia * index.SoLuong).ToString() + " đ";
                lblTotal.Font = new Font("Time New Roman", 9.75F, FontStyle.Regular);
                lblTotal.Location = new System.Drawing.Point(xLocation[4], yLocation);
                pnDetail.Controls.Add(lblTotal);

                yLocation += 40;
                stt++;
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
