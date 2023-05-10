using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_Csharp_Homework
{
    public partial class Frm_HW11_Notepad : Form
    {
        public Frm_HW11_Notepad()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeStatusLab.Text = DateTime.Now.ToString();
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.Clear();
            this.Text = "Notepad";
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "開啟";
            open.Filter = "文字文件 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                richTxt.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = open.FileName;
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "存檔";
            save.Filter = "文字文件 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTxt.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = save.FileName;
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "另存新檔";
            save.Filter = "文字文件 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTxt.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = save.FileName;
        }

        System.Drawing.Printing.PrintDocument document = new System.Drawing.Printing.PrintDocument();

        private void 列印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = document;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void 預覽列印VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = document;
            printPreviewDialog1.ShowDialog();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.Undo();
        }

        private void 取消復原RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.Redo();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTxt.Font= fnt.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTxt.ForeColor = fnt.Color;
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.ForeColor = SystemColors.WindowText;
        }

        private void newLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            richTxt.WordWrap = true;
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            richTxt.Clear();
            this.Text = "Notepad";
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "開啟";
            open.Filter = "文字文件 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                richTxt.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = open.FileName;
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "存檔";
            save.Filter = "文字文件 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTxt.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = save.FileName;
        }

        private void 列印PToolStripButton_Click(object sender, EventArgs e)
        {
            printDialog1.Document = document;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            richTxt.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            richTxt.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            richTxt.Paste();
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HW11_NotepadAbout frm = new Frm_HW11_NotepadAbout();
            frm.ShowDialog();
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            Frm_HW11_NotepadAbout frm = new Frm_HW11_NotepadAbout();
            frm.ShowDialog();
        }

        private void toUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Upper = richTxt.Text.ToUpper();
            richTxt.Text = Upper;
        }

        private void toLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Lower = richTxt.Text.ToLower();
            richTxt.Text = Lower;
        }
    }
}
