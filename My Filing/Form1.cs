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

namespace My_Filing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            this.BackColor = Color.DeepSkyBlue;
            this.ActiveControl = panel1;
            this.WindowState = FormWindowState.Maximized;
            panel1.Location = new Point(this.Size.Width / 2 - panel1.Size.Width / 2, 106);
            #region "Colors Change Properties"
            panel1.BackColor = Color.WhiteSmoke;
            groupBox1.Text = "";
            groupBox1.BackColor = Color.Snow;
            button1.BackColor = Color.DodgerBlue;
            button2.BackColor = Color.DodgerBlue;
            button3.BackColor = Color.DodgerBlue;
            button4.BackColor = Color.DodgerBlue;
            button5.BackColor = Color.DodgerBlue;
            button6.BackColor = Color.DodgerBlue;
            button7.BackColor = Color.DodgerBlue;
            button8.BackColor = Color.DodgerBlue;
            button9.BackColor = Color.DodgerBlue;
            button10.BackColor = Color.DodgerBlue;
            button11.BackColor = Color.DodgerBlue;
            button12.BackColor = Color.DodgerBlue;
            button13.BackColor = Color.DodgerBlue;
            button14.BackColor = Color.DeepSkyBlue;
            button15.BackColor = Color.DeepSkyBlue;
            button16.BackColor = Color.DeepSkyBlue;
            button15.BackColor = Color.DeepSkyBlue;
            button17.BackColor = Color.DeepSkyBlue;
            button18.BackColor = Color.DeepSkyBlue;
            button19.BackColor = Color.DeepSkyBlue;
            button20.BackColor = Color.DeepSkyBlue;
            button21.BackColor = Color.DeepSkyBlue;
            button22.BackColor = Color.DeepSkyBlue;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button9.ForeColor = Color.White;
            button10.ForeColor = Color.White;
            button11.ForeColor = Color.White;
            button12.ForeColor = Color.White;
            button13.ForeColor = Color.White;
            button14.ForeColor = Color.White;
            button15.ForeColor = Color.White;
            button16.ForeColor = Color.White;
            button17.ForeColor = Color.White;
            button18.ForeColor = Color.White;
            button19.ForeColor = Color.White;
            button20.ForeColor = Color.White;
            button21.ForeColor = Color.White;
            button22.ForeColor = Color.White;
            #endregion
            #region "Text Properties"
            button1.Text = "Search";
            button2.Text = "Make Directory";
            button3.Text = "Make File";
            button4.Text = "Copy File";
            button5.Text = "Move File";
            button6.Text = "Delete File";
            button7.Text = "Search Directories";
            button8.Text = "Create Folder";
            button9.Text = "Create File";
            button10.Text = "Copy File";
            button11.Text = "Move File";
            button12.Text = "Delete File";
            button13.Text = "Streaming";
            button14.Text = "Stream Reader";
            button15.Text = "Stream Writer";
            button16.Text = "File Streaming";
            button17.Text = "Read Txt";
            button18.Text = "Write Txt ";
            button19.Text = "Read";
            button20.Text = "Write";
            button21.Text = "Read File";
            button22.Text = "Write File";
            label1.Text = "Select Drive";
            label2.Text = "Create Directory";
            label3.Text = "Name the Directory";
            label4.Text = "Select the Drive";
            label5.Text = "Select the Folder";
            label6.Text = "Name the File";
            label7.Text = "Name the Deleting File";
            label8.Text = "Select the File To Be Copy";
            label9.Text = "Select the File To Be Move";
            label10.Text = "Enter Your Text Here...!";
            label11.Text = "Select File To Read";
            label12.Text = "Select File To Write";
            textBox5.Text = "Select File";
            textBox1.Text = "Select Any Operation";
            #endregion
            #region "Focus other Properties"
            textBox1.BackColor = Color.Snow;
            textBox1.ForeColor = Color.Blue;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox4.Text = "Select Folder To Be Paste";
            textBox4.BackColor = Color.Snow;
            textBox5.BackColor = Color.Snow;
            textBox3.GotFocus += txtgofocus;
            textBox3.LostFocus += txtlofocus;
            textBox3.ForeColor = Color.LightSkyBlue;
            comboBox1.GotFocus += new EventHandler(this.txtgofocuscom);
            comboBox1.LostFocus += new EventHandler(this.txtlofocuscom);
            comboBox1.Text = "Select Drive";
            comboBox1.ForeColor = Color.LightSkyBlue;
            comboBox1.Items.AddRange(drives);
            comboBox4.Items.AddRange(drives);
            comboBox2.GotFocus += new EventHandler(this.txtgofocuscom1);
            comboBox2.LostFocus += new EventHandler(this.txtlofocuscom1);
            comboBox3.GotFocus += txtgofocuscom1;
            comboBox3.LostFocus += txtlofocuscom1;
            comboBox3.Text = "Select Directory";
            comboBox3.ForeColor = Color.LightSkyBlue;
            comboBox4.GotFocus += txtgofocuscom;
            comboBox4.LostFocus += txtlofocuscom;
            comboBox4.ForeColor = Color.LightSkyBlue;
            comboBox2.ForeColor = Color.LightSkyBlue;
            comboBox4.Text = "Select Drive";
            comboBox2.Text = "Select Directory";
            #endregion
            #region "All Visibility Off"
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            textBox3.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            #endregion
        }
        #region "Focus"
        public void txtgofocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Text") { tb.Text = ""; tb.ForeColor = Color.Black; }
        }
        public void txtlofocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "") { tb.Text = "Text"; tb.ForeColor = Color.Gray; } 
        }
        public void txtgofocuscom(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Text == "Select Drive") { cb.Text = ""; cb.ForeColor = Color.Black; }
        }
        public void txtlofocuscom(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Text == "") { cb.Text = "Select Drive"; cb.ForeColor = Color.Gray; }
        }
        public void txtgofocuscom1(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Text == "Select Directory") { cb.Text = ""; cb.ForeColor = Color.Black; }
        }
        public void txtlofocuscom1(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Text == "") { cb.Text = "Select Directory"; cb.ForeColor = Color.Gray; }
        }
        #endregion
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region "Populate Directories Code"
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            try {
                DirectoryInfo[] d = dir.GetDirectories();
                comboBox2.Items.Clear();
                foreach (DirectoryInfo di in d) { comboBox2.Items.Add(di + "\\"); }
                FileInfo[] f = dir.GetFiles();
                foreach (FileInfo fi in f) { comboBox5.Items.Add(fi.ToString()); }
                comboBox2.Visible = true;
                //textBox6.Visible = true;
                //button7.Visible = true;
                label2.Visible = true;
                if (textBox3.Visible == true)
                {
                    textBox6.Visible = false;
                    button7.Visible = false;
                }
                else
                {
                    textBox6.Visible=true;
                    button7.Visible = true;
                }
            }
            catch (IOException )
            {
                comboBox2.Visible = false;
                textBox6.Visible = false;
                button7.Visible = false;
                label2.Visible = false;
                MessageBox.Show("Select Your PC Drive");
            }
            #endregion
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region "Getting Directories Show in Txtbx"
            string a = comboBox1.Text + comboBox2.Text;
            DirectoryInfo d = new DirectoryInfo(a);
            try
            {
                DirectoryInfo[] f = d.GetDirectories();
                foreach (DirectoryInfo fi in f)
                {
                    textBox6.Text += fi.ToString()+Environment.NewLine;
                }
            }
            catch (UnauthorizedAccessException) { MessageBox.Show("First Select Correct Path"); }
            #endregion
        }
        private void button8_Click(object sender, EventArgs e)
        {
            #region "Creating Folder Code"
            string dpath = comboBox1.Text + comboBox2.Text;
            DirectoryInfo d = new DirectoryInfo(dpath);
            d.CreateSubdirectory(textBox3.Text);
            //try { 
            //MessageBox.Show("Folder Is Created");
            //}
            //catch(IOException ){MessageBox.Show("Folder Is Already Created"); }
            #endregion
        }
        private void button9_Click(object sender, EventArgs e)
        {
            #region "File Creating Code"
            string fpath = comboBox1.Text + comboBox2.Text + "\\" + textBox3.Text;
            try
            {
                try { File.CreateText(fpath);  MessageBox.Show("File Is Created"); }
                catch (UnauthorizedAccessException) { MessageBox.Show("Select Correct Path"); }

            }
            catch (IOException) { MessageBox.Show("File Already Exists"); }
            #endregion
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text+ comboBox2.Text);
            FileInfo[] f = dir.GetFiles();
            foreach (FileInfo fi in f) { comboBox5.Items.Add(fi.ToString()); }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            #region "Copying File Code"
            string spath = comboBox1.Text + comboBox2.Text +comboBox5.Text;
            string dpath = comboBox4.Text + comboBox3.Text + comboBox5.Text;
            try { File.Copy(spath, dpath); MessageBox.Show("File Is Copy"); }
            catch (IOException) { MessageBox.Show("File Is Already Exists"); }
            #endregion
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region "Populate Directories Code in Combo4"
            DirectoryInfo dir = new DirectoryInfo(comboBox4.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d) { comboBox3.Items.Add(di + "\\"); }
            #endregion
        }
        private void button12_Click(object sender, EventArgs e)
        {
            #region "File Deleting Code"
            string dlpath = comboBox1.Text + "\\" + comboBox2.Text + "\\" + textBox3.Text;
            try {
                try { File.Delete(dlpath); MessageBox.Show("File Is Deleted"); }
                catch (UnauthorizedAccessException) { MessageBox.Show("Select the Correct Path"); }
            }
            catch (IOException) { MessageBox.Show("File Already Exists"); }
            #endregion
        }
        private void button11_Click(object sender, EventArgs e)
        {
            #region "File Moving Code"
            string spath = comboBox1.Text + comboBox2.Text + comboBox5.Text;
            string dpath = comboBox4.Text + comboBox3.Text + comboBox5.Text;
            try { File.Move(spath, dpath); MessageBox.Show("File Is Moved"); }
            catch (IOException) { MessageBox.Show("File Is Already Exists"); }
            #endregion
        }
        private void button17_Click(object sender, EventArgs e)
        {
            #region "Stream Reader Code"
            string fs = comboBox1.Text + comboBox2.Text + comboBox5.Text ;  
            try
            {
                try
                {
                    StreamReader s = new StreamReader(fs);
                    textBox6.Text = s.ReadToEnd();
                    s.Close();
                }
                catch (UnauthorizedAccessException) { MessageBox.Show("Select the Correct Path"); }
            }
            catch (IOException) { MessageBox.Show("Select Only .txt Files"); }
            #endregion
        }
        private void button18_Click(object sender, EventArgs e)
        {
            #region "Stream Writer Code"
            string fs = comboBox1.Text + comboBox2.Text + comboBox5.Text;
            try
            {
                try
                {
                    StreamWriter s = new StreamWriter(fs);
                    s.Write(textBox2.Text);
                    s.Close();
                }
                catch (UnauthorizedAccessException) { MessageBox.Show("Select the Correct Path"); }
            }
            catch (IOException) { MessageBox.Show("Select Only .txt Files"); }
            #endregion
        }
        private void button21_Click(object sender, EventArgs e)
        {
            #region "File Reading Code"
            byte [] b=new byte[100];
            char [] c=new char[100];
            string re = comboBox1.Text + comboBox2.Text + comboBox5.Text;
            try {
                try
                {
                    FileStream fs = new FileStream(re, FileMode.Open, FileAccess.Read);
                    fs.Seek(0, SeekOrigin.Begin);
                    fs.Read(b, 0, 99);
                    Decoder de = Encoding.UTF8.GetDecoder();
                    de.GetChars(b, 0, b.Length, c, 0);
                    string s = new string(c);
                    textBox6.Text = s;
                    fs.Close();
                }
                catch (UnauthorizedAccessException) { MessageBox.Show("Select the Correct Path"); }
            }
            catch (IOException) { MessageBox.Show("File Not Found"); }
            #endregion
        }
        private void button22_Click(object sender, EventArgs e)
        {
            #region "File Writing Code"
            byte[] b = new byte[100];
            char[] c = new char[100];
            string re = comboBox1.Text + comboBox2.Text + comboBox5.Text;
            c = textBox2.Text.ToCharArray();
            try
            {
                try
                {
                    FileStream fs = new FileStream(re, FileMode.Append, FileAccess.Write);
                    Encoder ec = Encoding.UTF8.GetEncoder();
                    ec.GetBytes(c, 0, c.Length, b, 0, true);
                    fs.Write(b, 0, b.Length);
                    fs.Close();
                }
                catch (UnauthorizedAccessException) { MessageBox.Show("Select the Correct Path"); }
            }
            catch (IOException) { MessageBox.Show("Not Found"); }
            #endregion
        }
        #region "Visibility Of Buttons and Other"
        private void button1_Click(object sender, EventArgs e)
        {
            #region "Search Visibility Buttons"
            button7.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            textBox6.Visible = true;
            textBox2.Visible = false;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            textBox3.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            textBox4.Visible = false;
            #endregion
        }
        private void button2_Click(object sender, EventArgs e)
        {
            #region "Create Directory Visibility Buttons"
            button8.Visible = true;
            button7.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            label1.Visible = true;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            label6.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox2.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            textBox3.Visible = true;
            textBox2.Visible = false;
            textBox4.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            textBox6.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            #endregion
        }
        private void button3_Click(object sender, EventArgs e)
        {
            #region "Create File Visibility Buttons"
            button9.Visible = true;
            button8.Visible = false;
            button7.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            label1.Visible = true;
            label7.Visible = false;
            label2.Visible = true;
            label3.Visible = false;
            label6.Visible = true;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            textBox3.Visible = true;
            textBox4.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            textBox6.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            #endregion
        }
        private void button4_Click(object sender, EventArgs e)
        {
            #region "Copy File Visibilty Buttons"
            button10.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            textBox3.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            #endregion
        }
        private void button6_Click(object sender, EventArgs e)
        {
            #region "Delete Visibility Buttons"
            button7.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            textBox2.Visible = false;
            textBox6.Visible = false;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = true;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            textBox3.Visible = true;
            textBox4.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            #endregion
        }
        private void button5_Click(object sender, EventArgs e)
        {
            #region "Move Visibility Buttons"
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = true;
            button12.Visible = false;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            textBox3.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = true;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            #endregion
        }
        private void button13_Click(object sender, EventArgs e)
        {
            #region "Streaming Visibility Buttons"
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            textBox3.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            if (button14.Visible == true && button15.Visible == true && button16.Visible == true) { button14.Visible = false; button15.Visible = false; button16.Visible = false; }
            else { button14.Visible = true; button15.Visible = true; button16.Visible = true; }
            #endregion
        }
        private void button14_Click(object sender, EventArgs e)
        {
            #region "Streaming Read Visibility Buttons"
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = true;
            textBox3.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = true;
            label12.Visible = false;
            button17.Visible = true;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            #endregion
        }

        private void button15_Click(object sender, EventArgs e)
        {
            #region "Streaming Write Visibility Buttons"
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = true;
            textBox3.Visible = false;
            textBox2.Visible = true;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = true;
            label11.Visible = false;
            label12.Visible = true;
            button17.Visible = false;
            button18.Visible = true;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            #endregion
        }

        private void button16_Click(object sender, EventArgs e)
        {
            #region "File Streaming Visibility Buttons"
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            textBox3.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label10.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            if (button19.Visible == true && button20.Visible == true) { button19.Visible = false; button20.Visible = false; }
            else { button19.Visible = true; button20.Visible = true; }
            #endregion
        }
        private void button20_Click(object sender, EventArgs e)
        {
            #region "Filestream Write Visibility Buttons"
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = true;
            textBox3.Visible = false;
            textBox2.Visible = true;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = true;
            label11.Visible = false;
            label12.Visible = true;
            button17.Visible = false;
            button18.Visible = false;
            button21.Visible = false;
            button22.Visible = true;
            #endregion
        }
        private void button19_Click(object sender, EventArgs e)
        {
            #region "Filestream Read Visibility Buttons"
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = true;
            textBox3.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = true;
            label12.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button21.Visible = true;
            button22.Visible = false;
            #endregion
        }
        #endregion
        private void button16_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
