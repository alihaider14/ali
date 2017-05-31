using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ERP2
{
    public partial class Form3 : Form
    {
        Class1 c1 = new Class1();
        public Form3()
        {
            InitializeComponent();
            #region "Conn"
            c1.constring();
            #endregion
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            #region "Properties"
            TextBox tb1 = new TextBox();
            tb1.Text = "Module";
            tb1.TextAlign = HorizontalAlignment.Center;
            tb1.Font = new Font("", 14, FontStyle.Regular);
            tb1.ForeColor = Color.White;
            tb1.Multiline = true;
            tb1.Size = new Size(146,45);
            tb1.ReadOnly = true;
            tb1.BackColor = Color.DodgerBlue;
            tb1.BorderStyle = BorderStyle.None;
            tb1.Location = new Point(0, 90);
            panel3.Controls.Add(tb1);
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.DeepSkyBlue;
            this.Text = "A.H Organization";
            this.ActiveControl = label1;
            button1.Cursor = Cursors.Hand;
            button2.Cursor = Cursors.Hand;
            panel1.Visible = false;
            panel2.Visible = false;
            //panel1.Paint+=panel1_Paint;
            panel3.Size = new Size(148, 710);
            panel3.BackColor = Color.DodgerBlue;
            button3.Size = new Size(148, 50);
            button4.Size = new Size(148, 50);
            button3.Text = "Pruchase Data";
            button4.Text = "Sell Data";
            button3.BackColor = Color.DeepSkyBlue;
            button4.BackColor = Color.DeepSkyBlue;
            button3.ForeColor = Color.WhiteSmoke;
            button4.ForeColor = Color.WhiteSmoke;
            button3.Click+=button3_Click;
            button4.Click += button4_Click;
            textBox18.Size = new Size(146, 90);
            textBox18.BackColor = Color.DodgerBlue;
            textBox18.Text = "Administrarion Only";
            textBox18.Font = new Font("Bold", 16, FontStyle.Regular);
            textBox18.ForeColor = Color.WhiteSmoke;
            textBox9.Text = "Enterprise Resource Planning";
            textBox9.TextAlign = HorizontalAlignment.Center;
            textBox9.Font = new Font("Bold", 40, FontStyle.Regular);
            textBox9.BackColor = Color.DeepSkyBlue;
            textBox9.ForeColor = Color.SlateGray;
            textBox9.Size = new Size(1019, 88);
            #region "Sell Data"
            groupBox2.Size = new Size(555, 431);
            panel2.Size = new Size(587, 516);
            button2.Text = "OK";
            button2.Font = new Font("Bold", 18, FontStyle.Regular);
            button2.BackColor = Color.LightSkyBlue;
            button2.ForeColor = Color.White;
            groupBox2.Text = "All Sell Data";
            label11.Text = "Sell Order I.D's";
            label12.Text = "Receiving Date";
            label13.Text = "Group";
            label14.Text = "Name";
            label15.Text = "CPPH";
            label16.Text = "Vendor I.D";
            label17.Text = "Contect Person";
            label18.Text = "Approval status";
            label19.Text = "Set Approval";
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton3.Text = "Approve";
            radioButton4.Text = "Not Approve";
            textBox10.Size = new Size(602, 61);
            textBox10.BackColor = Color.Beige;
            textBox10.ForeColor = Color.DeepSkyBlue;
            textBox10.Text = "Sell Order Data";
            textBox10.TextAlign = HorizontalAlignment.Center;
            textBox10.Font = new Font("Bold", 40, FontStyle.Regular);
            textBox10.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(220, 140);
            groupBox2.BackColor = Color.Snow;
            c1.c.Open();
            OleDbCommand cm1 = new OleDbCommand("select soid from so where approve='not approved'", c1.c);
            OleDbDataReader dir1 = cm1.ExecuteReader();
            while (dir1.Read())
            {
                comboBox1.Items.Add(dir1["soid"].ToString());
            }
            c1.c.Close();
            comboBox1.GotFocus += focgo;
            comboBox1.LostFocus += foclo;
            comboBox1.Text = "Select Sell I.D";
            #endregion
            #region "Purchase Data"
            groupBox1.Size = new Size(546, 418);
            panel1.Size = new Size(587, 506);
            button1.Text = "OK";
            button1.Font = new Font("Bold", 18, FontStyle.Regular);
            button1.BackColor = Color.LightSkyBlue;
            button1.ForeColor = Color.White;
            panel1.Location = new Point(220, 140); 
            label2.Text = "Approval Status";
            radioButton1.Text = "Approve";
            radioButton2.Text = "Not Approve";
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            groupBox1.BackColor = Color.Snow;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.DeepSkyBlue;
            textBox1.Text ="Customer Purchasing Order Data";
            textBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Text = "Purchasing Data";
            label1.Text = "Delivery Date";
            label3.Text = "Name";
            label4.Text = "Contect Person";
            label5.Text = "CPPH";
            label6.Text = "Vender I.D";
            label7.Text = "Group";
            label8.Text = "Approval";
            label10.Text = "P.O I.D";
            c1.c.Open();
            OleDbCommand cm = new OleDbCommand("select poid from po ", c1.c);
            OleDbDataReader dir = cm.ExecuteReader();
            while (dir.Read())
            {
                comboBox2.Items.Add(dir["poid"].ToString());
            }
            c1.c.Close();
            comboBox2.GotFocus += focgo1;
            comboBox2.LostFocus += foclo1;
            comboBox2.Text = "Select Purchase I.D";
            #endregion      
            #endregion
        }
        #region "Focus"
        public void focgo(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            {
                if (cb.Text == "Select Sell I.D") { cb.Text = ""; cb.ForeColor = Color.Black; }
            }
        }
        public void foclo(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            {
                if (cb.Text == "") { cb.Text = "Select Sell I.D"; cb.ForeColor = Color.Gray; }
            }
        }
        public void focgo1(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            {
                if (cb.Text == "Select Purchase I.D") { cb.Text = ""; cb.ForeColor = Color.Black; }
            }
        }
        public void foclo1(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            {
                if (cb.Text == "") { cb.Text = "Select Purchase I.D"; cb.ForeColor = Color.Gray; }
            }
        }
        #endregion 
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region "Purchase combo2 Select"
            if (comboBox2.Text != "'") { radioButton1.Visible = true; radioButton2.Visible = true; }
            c1.c.Open();
            OleDbCommand cd = new OleDbCommand("select* from po where poid='" + comboBox2.Text + "'", c1.c);
            OleDbDataReader d = cd.ExecuteReader();
            if (d.Read())
            {
                textBox2.Text = d["DCDate"].ToString();
                textBox3.Text = d["VDept"].ToString();
                textBox4.Text = d["VName"].ToString();
                textBox5.Text = d["VID"].ToString();
                textBox6.Text = d["VContectPerson"].ToString();
                textBox7.Text = d["VCPPH"].ToString();
                textBox8.Text = d["approve"].ToString();
            }
            c1.c.Close();
            OleDbDataAdapter da = new OleDbDataAdapter("select pmodel,pqty from poproducts where poid='" + comboBox2.Text + "'", c1.c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            #endregion 
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            #region "Sell Combo1 Select"
            c1.c.Open();
            OleDbCommand cd2 = new OleDbCommand("select* from so where soid='" + comboBox1.Text + "'", c1.c);
            OleDbDataReader d2 = cd2.ExecuteReader();
            if (d2.Read())
            {
                textBox11.Text = d2["DCDate"].ToString();
                textBox12.Text = d2["VDept"].ToString();
                textBox13.Text = d2["VName"].ToString();
                textBox14.Text = d2["vcpph"].ToString();
                textBox15.Text = d2["Vid"].ToString();
                textBox16.Text = d2["vcontectperson"].ToString();
                textBox17.Text = d2["approve"].ToString();
            }
            c1.c.Close();
            if (comboBox2.Text != "'") { radioButton3.Visible = true; radioButton4.Visible = true; }
            OleDbDataAdapter da = new OleDbDataAdapter("select pid,pqty from soproducts where soid='" + comboBox1.Text + "'", c1.c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            #endregion 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            #region "Sell Approval"
            string v = "";
            if (radioButton3.Checked) { v = radioButton3.Text; } else { v = radioButton4.Text; }
            if (radioButton3.Checked || radioButton4.Checked)
            {
                c1.c.Open();
                OleDbCommand cmd1 = new OleDbCommand("UPDATE so SET approve=@approve WHERE soid='" + comboBox1.Text + "'", c1.c);
                cmd1.Parameters.AddWithValue("@Approve", v);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Approval Has Been Added");
                c1.c.Close();
                if (radioButton3.Checked || radioButton4.Checked)
                {
                    Form4 f4 = new Form4();
                    f4.Show();
                    f4.panel2.Visible = true;
                }
                else { MessageBox.Show("Set The Approval"); }
            }
            #endregion
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            #region "Purchase Approval"
            string v = "";
            if (radioButton1.Checked) { v = radioButton1.Text; } else { v = radioButton2.Text; }
            if (radioButton1.Checked || radioButton2.Checked)
            {
                c1.c.Open();
                OleDbCommand cmd1 = new OleDbCommand("UPDATE po SET approve=@approve WHERE poid= '" + comboBox2.Text + "'", c1.c);
                cmd1.Parameters.AddWithValue("@Approve", v);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Approval Has Been Added");
                c1.c.Close();
            }
            if (radioButton1.Checked || radioButton2.Checked)
            {
                Form4 f4 = new Form4();
                f4.Show();
                f4.panel1.Visible = true;
            }
            else { MessageBox.Show("Set The Approval"); }
            #endregion
        }
        void button3_Click(object sender, EventArgs e) { panel1.Visible = true; panel2.Visible = false; }
        void button4_Click(object sender, EventArgs e) { panel2.Visible = true; panel1.Visible = false; }
        //void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = panel1.CreateGraphics(); Pen p1 = new Pen(Color.DarkGray); g.DrawLine(p1, 100, 210, 180, 210); g.DrawLine(p1, 220, 210, 299, 210); ControlPaint.DrawBorder(e.Graphics, panel1.DisplayRectangle, Color.Yellow, ButtonBorderStyle.Inset);
        //}
    }
}
