using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileBrowser
{
    public partial class FileBrowser : Form
    {
        private const int cGrip = 15; 
        private const int cCaption = 30; 

        public FileBrowser()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);

            Color myColor = ColorTranslator.FromHtml("#1C1C1C");
            SolidBrush myBrush = new SolidBrush(myColor);
            e.Graphics.FillRectangle(myBrush, rc);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);

                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; 
                    return;
                }
            }
            base.WndProc(ref m);
        }

        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        private void FileBrowser_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                mynotifyicon.Visible = true;
                mynotifyicon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                mynotifyicon.Visible = false;
            }
            else if(FormWindowState.Maximized == this.WindowState)
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(0, 0);
                this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizeBox_Click(object sender, EventArgs e)
        {
            int displayWidth = this.Width;
            int displayHeight = this.Height;

            if (displayWidth != Screen.PrimaryScreen.WorkingArea.Width || displayHeight != Screen.PrimaryScreen.WorkingArea.Height)
            {
                this.Location = new Point(0, 0);
                this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            }
            else
            {
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - 1200) / 2, (Screen.PrimaryScreen.WorkingArea.Height - 720) /2);
                this.Size = new Size(1200, 720);
            }
        }

        private void btnMinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mynotifyicon_Click(object sender, EventArgs e)
        {
            mynotifyicon.Visible = false;
            this.Show();
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - 1200) / 2, (Screen.PrimaryScreen.WorkingArea.Height - 720) / 2);
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1200, 720);
            this.Activate();
            this.Focus();
        }

        private void FileBrowser_Load(object sender, EventArgs e)
        {
            GetUsbDriveName();
            GetAllFoldersAndFiles();
        }

        void GetUsbDriveName()
        {
            DriveInfo[] mydrives = DriveInfo.GetDrives();

            foreach (DriveInfo mydrive in mydrives)
            {
                if (mydrive.DriveType == DriveType.Removable)
                {
                    if (Directory.Exists(mydrive.Name + "\\C#"))
                    {
                        lblLocation.Text = mydrive.Name;
                        lblLocation.Text = lblLocation.Text.Remove(lblLocation.Text.Length - 1);
                    }
                }
            }
        }

        void GetAllFoldersAndFiles()
        {
            string[] files = Directory.GetFiles(lblLocation.Text, fileExtension).Select(Path.GetFileName).ToArray();
            string[] folders = Directory.GetDirectories(lblLocation.Text, fileExtension).Select(Path.GetFileName).ToArray();

            foreach (var item in folders)
            {
                listBox1.Items.Add(item);
            }

            foreach (var item in files)
            {
                listBox1.Items.Add(item);
            }
        }

        string fileExtension = "*";
        private void rBtnPdf_Click(object sender, EventArgs e)
        {
            fileExtension = "*.pdf";
        }

        private void rBtnAllFiles_Click(object sender, EventArgs e)
        {
            fileExtension = "*";
        }

        private void rBtnDoc_Click(object sender, EventArgs e)
        {
            fileExtension = "*.doc";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FileAttributes FileOrDir = File.GetAttributes(lblLocation.Text + "\\" + listBox1.SelectedItem.ToString());
                if ((FileOrDir & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    lblDirName.Text = listBox1.SelectedItem.ToString();
                    lblLocation.Text += "\\" + listBox1.SelectedItem.ToString();
                    listBox1.Items.Clear();
                    GetAllFoldersAndFiles();
                }
                else
                {
                    try
                    {
                        myWebBrowser.Navigate(lblLocation.Text + "\\" + listBox1.SelectedItem.ToString());
                        myWebBrowser.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch
            {
                
            }
        }

        private void lblDirName_DoubleClick(object sender, EventArgs e)
        {
            string newDir = lblLocation.Text.Replace("\\" + lblDirName.Text, "");
            lblLocation.Text = newDir;
            listBox1.Items.Clear();
            GetAllFoldersAndFiles();
            lblDirName.Text = new DirectoryInfo(lblLocation.Text).Name;
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.DimGray);

            e.DrawBackground();
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, Brushes.WhiteSmoke, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = listBox1.Font.Height;
        }
    }
}
