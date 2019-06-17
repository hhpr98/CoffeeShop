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
        private PrintDocument printDocument = new PrintDocument();
       

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
