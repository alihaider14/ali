using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP2
{
    public partial class Form1 : Form
    {
        Class1 c1 = new Class1();
        public Form1()
        {
            InitializeComponent();
            #region "Conn"
            c1.constring();
            #endregion
           // FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region "Properties"
            this.BackColor = Color.DeepSkyBlue;
            this.WindowState = FormWindowState.Maximized;
            panel1.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel4.Size = new Size(148, 715);
            panel4.BackColor = Color.DodgerBlue;
            textBox5.Size = new Size(148, 80);
            textBox5.ForeColor = Color.Snow;
            textBox5.Text = "A.H Organization";
            textBox5.Font = new Font("Bold", 16, FontStyle.Bold);
            textBox5.BackColor = Color.DodgerBlue;
            textBox6.Size = new Size(148, 65);
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.ForeColor = Color.Snow;
            textBox6.Text = "Choose Enterance";
            textBox6.Font = new Font("Bold", 14, FontStyle.Bold);
            textBox6.BackColor = Color.DodgerBlue; 
            textBox6.Location = new Point(0, 78);
            button4.Location = new Point(0, 150);
            button4.ForeColor = Color.CadetBlue;
            button4.BackColor = Color.DeepSkyBlue;
            button4.ForeColor = Color.WhiteSmoke;
            button4.Text = "As A Customer";
            button4.Cursor = Cursors.Hand;
            button4.Size = new Size(148, 40);
            button5.Location = new Point(0, 188);
            button5.ForeColor = Color.CadetBlue;
            button5.BackColor = Color.DeepSkyBlue;
            button5.ForeColor = Color.WhiteSmoke;
            button5.Text = "As A Vendor";
            button5.Cursor = Cursors.Hand;
            button5.Size = new Size(148, 40);
            button8.Location = new Point(0, 300);
            button8.ForeColor = Color.CadetBlue;
            button8.BackColor = Color.DeepSkyBlue;
            button8.ForeColor = Color.WhiteSmoke;
            button8.Text = "Go To Login";
            button8.Cursor = Cursors.Hand;
            button8.Size = new Size(148, 40);
            textBox29.Size = new Size(148,60);
            textBox29.BackColor = Color.DodgerBlue;
            textBox29.Text = "Already Have An Account"+Environment.NewLine+"Click Here!";
            textBox29.ForeColor = Color.WhiteSmoke;
            textBox29.Font = new Font("Bold", 10, FontStyle.Bold);
            textBox29.TextAlign = HorizontalAlignment.Center;
            textBox29.Location = new Point(0, 235);
            #region "Add Customer"
            groupBox3.Size = new Size(559, 396);
            panel5.Size = new Size(607, 478);
            panel5.Location = new Point(220, 110);
            label3.Text = "Name";
            label4.Text = "Address";
            label5.Text = "City";
            label6.Text = "Contect No.1";
            label7.Text = "Contect No.2";
            label8.Text = "Group";
            label9.Text = "Contect Person";
            label10.Text = "CPPH";
            label11.Text = "Email";
            label12.Text = "Credit Limit";
            label13.Text = "Click..! Here To Add";
            button6.Cursor = Cursors.Hand;
            button6.Text = "OK";
            button6.BackColor = Color.LightSkyBlue;
            button6.ForeColor = Color.White;
            c1.c.Open();
            OleDbCommand cmd2 = new OleDbCommand("select grpname from cusgroup", c1.c);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2["grpname"].ToString());
            }
            c1.c.Close();
            comboBox1.GotFocus += focgo;
            comboBox1.LostFocus += foclo;
            comboBox1.Text = "Select Group:-";
            int c = 0;
            c1.c.Open();
            OleDbCommand cn = new OleDbCommand("select count(cid) from customer", c1.c);
            OleDbDataReader de = cn.ExecuteReader();
            while (de.Read())
            {
                c = Convert.ToInt32(de[0]);
                c++;
            }
            textBox17.Text = c.ToString();
            c1.c.Close();
            comboBox1.Text = "Select Group:-";
            textBox17.Visible = false;
            textBox7.Text = "Customer Information Form";
            textBox7.TextAlign = HorizontalAlignment.Center;
            textBox7.Font = new Font("Bold", 34, FontStyle.Regular);
            textBox7.ForeColor = Color.DeepSkyBlue;
            textBox7.BackColor = Color.WhiteSmoke;
            groupBox3.Text = "";
            panel5.BackColor = Color.WhiteSmoke;
            groupBox3.BackColor = Color.Snow;
            #endregion
            #region "Add Vendor"
            panel6.Location = new Point(220, 110);
            panel6.Size = new Size(610, 504);
            groupBox4.Size = new Size(569, 409);
            label14.Text = "Name";
            label15.Text = "Address";
            label16.Text = "City";
            label17.Text = "Contect No.1";
            label18.Text = "Contect No.2";
            label19.Text = "Group";
            label20.Text = "Contect Person";
            label21.Text = "CPPH";
            label22.Text = "Email";
            label23.Text = "Credit Limit";
            label24.Text = "Click..! Here To Add";
            textBox18.Text = "Vendor Information Form";
            textBox18.TextAlign = HorizontalAlignment.Center;
            textBox18.Font = new Font("Bold", 34, FontStyle.Regular);
            textBox18.BackColor = Color.WhiteSmoke;
            textBox18.ForeColor = Color.DeepSkyBlue;
            button7.Cursor = Cursors.Hand;
            button7.Text = "OK";
            button7.BackColor = Color.LightSkyBlue;
            button7.ForeColor = Color.White;
            groupBox4.Text = "";
            panel6.BackColor = Color.WhiteSmoke;
            groupBox4.BackColor = Color.Snow;
            int q = 0;
            c1.c.Open();
            OleDbCommand cn1 = new OleDbCommand("select count(vid) from vendor", c1.c);
            OleDbDataReader de1 = cn1.ExecuteReader();
            while (de1.Read())
            {
                q = Convert.ToInt32(de1[0]);
                q++;
            }
            textBox28.Text = q.ToString();
            c1.c.Close();
            textBox28.Visible = false;
            c1.c.Open();
            OleDbCommand cmd3 = new OleDbCommand("select grpname from cusgroup", c1.c);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox2.Items.Add(dr3["grpname"].ToString());
            }
            c1.c.Close();
            comboBox2.Text = "Select Group:-";
            comboBox2.GotFocus += focgo;
            comboBox2.LostFocus += foclo;
            //comboBox2.ForeColor = Color.LightGray;
            #endregion
           
            panel1.Location = new Point(220, 110);
            textBox4.Size = new Size(1019, 88);
            textBox4.Text = "Enterprise Resource Planning";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.Font = new Font("Bold", 40, FontStyle.Regular);
            textBox4.BackColor = Color.DeepSkyBlue;
            textBox4.ForeColor = Color.SlateGray;
            label1.Text = "Username Or Email";
            label2.Text = "Password";
            groupBox1.Text = "A H Organization";
            button3.Font = new Font("Bold", 12,FontStyle.Regular);
            button3.BackColor = Color.BurlyWood;
            button1.Text = "Login From Here";
            button2.Text = "Sign Up From Here";
            button3.Text = "Login";
            textBox3.Text = "Do Not Have An Account"+Environment.NewLine +"Click!! ";
            textBox3.BackColor = Color.AliceBlue;
            groupBox1.Visible = false;
            groupBox2.Visible = false;  
            textBox3.BackColor = Color.Wheat;
            textBox3.ForeColor = Color.LightSalmon;
            panel1.BackColor = Color.Wheat;
            panel2.BackColor = Color.CadetBlue;
            button1.BackColor = Color.CadetBlue;
            button1.ForeColor = Color.FloralWhite;
            panel3.BackColor = Color.CadetBlue;
            button2.BackColor = Color.CadetBlue;
            button2.ForeColor = Color.FloralWhite;
            button3.Cursor = Cursors.Hand;
            #endregion
        }
        public void focgo(object sender, EventArgs e)
        {
            ComboBox cb2 = (ComboBox)sender;
            {
                if (cb2.Text == "Select Group:-") { cb2.Text = ""; cb2.ForeColor = Color.Black; }
            }
        }
             public void foclo(object sender, EventArgs e)
             {
            ComboBox cb2 = (ComboBox)sender;
            {
                if (cb2.Text == "") { cb2.Text = "Select Group:-"; cb2.ForeColor = Color.Gray; }
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // this.Hide();
            //Form2 f2 = new Form2();
            //f2.ShowDialog();
        }
        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Cursor = Cursors.Hand;
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            #region "Adding Customer"
            try
            {
                c1.c.Open();
                OleDbCommand cmd2 = new OleDbCommand("insert into customer (cid,cname,caddress,city,ph1,ph2,contectperson,cpph,cemail,creditlimit,cgroup) values(@cid,@cname,@caddress,@city,@ph1,@ph2,@contectperson,@cpph,@cemail,@creditlimit,@cgroup)", c1.c);
                cmd2.Parameters.AddWithValue("@cid", textBox17.Text);
                cmd2.Parameters.AddWithValue("@cname", textBox8.Text);
                cmd2.Parameters.AddWithValue("@caddress", textBox9.Text);
                cmd2.Parameters.AddWithValue("@city", textBox10.Text);
                cmd2.Parameters.AddWithValue("@ph1", textBox11.Text);
                cmd2.Parameters.AddWithValue("@ph2", textBox12.Text);
                cmd2.Parameters.AddWithValue("@contectperson", textBox13.Text);
                cmd2.Parameters.AddWithValue("@cpph", textBox14.Text);
                cmd2.Parameters.AddWithValue("@cemail", textBox15.Text);
                cmd2.Parameters.AddWithValue("@creditlimit", textBox16.Text);
                cmd2.Parameters.AddWithValue("@cgroup", comboBox1.Text);
                cmd2.ExecuteNonQuery();
                c1.c.Close();
            }
            catch (Exception) { MessageBox.Show("something written Wrong"); }
            MessageBox.Show("New Customer Has Been Added");
            #endregion
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel6.Visible = false;
            panel1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region "Adding Vendor"
            try
            {
                c1.c.Open();
                OleDbCommand cmd2 = new OleDbCommand("insert into vendor (vid,vname,vcode,vcity,ph1,ph2,vaddress,vcpname,cpph,vemail,vgroup) values(@vid,@vname,@vcode,@vcity,@ph1,@ph2,@vaddress,@vcpname,@cpph,@vemail,@vgroup)", c1.c);
                cmd2.Parameters.AddWithValue("@vid", textBox28.Text);
                cmd2.Parameters.AddWithValue("@vname", textBox19.Text);
                cmd2.Parameters.AddWithValue("@vcode", textBox20.Text);
                cmd2.Parameters.AddWithValue("@pcity", textBox21.Text);
                cmd2.Parameters.AddWithValue("@ph1", textBox22.Text);
                cmd2.Parameters.AddWithValue("@ph2", textBox23.Text);
                cmd2.Parameters.AddWithValue("@vaddress", textBox24.Text);
                cmd2.Parameters.AddWithValue("@vcpname", textBox25.Text);
                cmd2.Parameters.AddWithValue("@cpph", textBox26.Text);
                cmd2.Parameters.AddWithValue("@vemail", textBox27.Text);
                cmd2.Parameters.AddWithValue("@vgroup", comboBox2.Text);
                cmd2.ExecuteNonQuery();
                c1.c.Close();
            }
            catch (Exception) { MessageBox.Show("Something written Wrong"); }
            MessageBox.Show("New Vendor Has Been Added");
            #endregion
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = true;
            panel1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
        }
        private void minimizeButton_Click(object sender, System.EventArgs e)
        {
           WindowState = FormWindowState.Minimized;
        }
        private void maximizeButton_Click(object sender, System.EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        #region "Key Down Vendor"
        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox20.Focus(); }
        }

        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox21.Focus(); }
        }

        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox22.Focus(); }
        }

        private void textBox22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox23.Focus(); }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox25.Focus(); }
        }

        private void textBox25_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox26.Focus(); }
        }

        private void textBox26_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox27.Focus(); }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox23_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { comboBox2.Focus(); }
        }
        #endregion
        #region "Key Down Customer"
        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox9.Focus(); }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox10.Focus(); }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox11.Focus(); }
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox12.Focus(); }
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox13.Focus(); }
        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox14.Focus(); }
        }

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox15.Focus(); }
        }

        private void textBox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { textBox16.Focus(); }
        }
        #endregion
    }
}
