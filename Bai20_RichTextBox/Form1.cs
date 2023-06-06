using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bai20_RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            /*  Mở file */
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.FileName = "";
            ofdlg.Title = "Mở file";
            ofdlg.Filter = "rtf|*.rtf|docx|*.docx|AllFile|*.*";
            if(ofdlg.ShowDialog() == DialogResult.OK)
            {
                /*  Đọc dữ liệu vào rtfText */
                rtfText.LoadFile(ofdlg.FileName);
            }    
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofdlg = new SaveFileDialog();
            ofdlg.Title = "Save As";
            ofdlg.AddExtension = true;
            ofdlg.FileName = "";
            ofdlg.Filter = "rtf|*.rtf|docx|*.docx|AllFile|*.*";
            ofdlg.DefaultExt = ".rtf";
            if(ofdlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(ofdlg.FileName);
                writer.Write(rtfText.Text);
                writer.Close();
            }    
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (rtfText.SelectedText == "")
                return;
            FontDialog fontdlog = new FontDialog();
            fontdlog.ShowColor = true;
            
            if(fontdlog.ShowDialog() == DialogResult.OK)
            {
                rtfText.SelectionFont = fontdlog.Font;
                rtfText.SelectionColor = fontdlog.Color;
            }    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
