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
    public partial class Form4 : Form
    {
        Class1 c1 = new Class1();
        public Form4()
        {
            InitializeComponent();
            #region "Conn"
            c1.constring();
            #endregion
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            #region "All Properties"
            //panel1.Visible = false;
            panel2.Visible = false;
            this.ActiveControl = label1;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Thistle;
            this.BackColor = Color.DeepSkyBlue;
            this.Text = "A.H Organization";
            textBox16.Size = new Size(1019, 88);
            textBox16.Text = "Enterprise Resource Planning";
            textBox16.TextAlign = HorizontalAlignment.Center;
            textBox16.Font = new Font("Bold", 40, FontStyle.Regular);
            textBox16.BackColor = Color.DeepSkyBlue;
            textBox16.ForeColor = Color.SlateGray;
            #region "Pruchase Order"
            button1.Cursor = Cursors.Hand;
            button2.Cursor = Cursors.Hand;
            panel1.Location = new Point(155, 130);
            textBox12.Text = "Goods Receiving Receipt";
            groupBox1.Text = "Product Pruchasing Information";
            groupBox1.BackColor = Color.Snow;
            groupBox2.Text = "Product Receving";
            groupBox2.BackColor = Color.Snow;
            textBox12.TextAlign = HorizontalAlignment.Center;
            textBox12.Font = new Font("Rockwell", 44);
            textBox12.ForeColor = Color.SkyBlue;
            textBox12.BackColor = Color.WhiteSmoke;
            textBox13.Text = "Open";
            panel1.BackColor = Color.WhiteSmoke;
            button1.BackColor = Color.LightSkyBlue;
            button2.BackColor = Color.LightSkyBlue;
            label6.Text = "Pruchase I.D:";
            label1.Text = "Product Information";
            label8.Text = "Contect Person:";
            label9.Text = "Vendor Name:";
            label4.Text = "Purchase I.D:";
            label14.Text = "Make My Goods Receiving Note ";
            button1.Text = "Make Note";
            label3.Text = "Goods Receive Click Ok !";
            button2.Text = "OK";
            label12.Text = "Purchase Order Date";
            label13.Text = "Goods Receiving Date";
            label5.Text = "New Goods Receiving I.D";
            label7.Text = "Goods Receiving I.D's";
            label11.Text = "Product I.D:";
            label10.Text = "Product Quantity:";
            textBox13.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            //textBox4.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            //groupBox2.Visible = false;
            //label7.Visible = false;
            //comboBox2.Visible = false;
            //button3.Visible = false;
            c1.c.Open();
            OleDbCommand cm1 = new OleDbCommand("select poid from po where approve='approved'", c1.c);
            OleDbDataReader dir1 = cm1.ExecuteReader();
            while (dir1.Read())
            {
                comboBox1.Items.Add(dir1["poid"].ToString());//WHERE grnid = ' AND p_ID = '"
            }
            c1.c.Close();
            //con.Open();
            //OleDbCommand m1 = new OleDbCommand("SELECT grnid FROM grnproducts ", con);
            //OleDbDataReader dq = m1.ExecuteReader();
            //while (dq.Read()) { comboBox2.Items.Add(dq["grnid"].ToString()); comboBox2.Refresh(); }
            //con.Close();
            #endregion
            #region "Sell Order"
            panel2.Location = new Point(155, 130);
            panel2.BackColor = Color.WhiteSmoke;
            textBox3.Text = "Selling Receipt ";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.Font = new Font("Bold", 50, FontStyle.Regular);
            textBox3.ForeColor = Color.SkyBlue;
            textBox3.BackColor = Color.WhiteSmoke;
            label16.Text = "Products Information";
            label18.Text = "Products I.D's";
            label19.Text = "Quantity";
            label20.Text = "Contect Person";
            label21.Text = "Vendor Name";
            label22.Text = "Sell Order Date";
            label23.Text = "Sell I.D";
            label24.Text = "New SON I.D";
            label25.Text = "New Goods Selling I.D";
            label26.Text = "Goods Deliver Click OK!";
            label27.Text = "SO I.D";
            label29.Text = "SON I.D's";
            textBox28.Text = "Open";
            textBox28.Visible = false;
            textBox27.Visible = false;
            textBox26.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            button4.Text = "Make Note";
            button6.Text = "OK";
            button4.BackColor = Color.LightSkyBlue;
            button4.Cursor = Cursors.Hand;
            button6.BackColor = Color.LightSkyBlue;
            groupBox3.Text = "Products Selling Information";
            groupBox3.BackColor = Color.Snow;
            groupBox4.Text = "Products Delivering";
            groupBox4.BackColor = Color.Snow;
            c1.c.Open();
            OleDbCommand cm11 = new OleDbCommand("select soid from so ", c1.c);
            OleDbDataReader dir11 = cm11.ExecuteReader();
            while (dir11.Read())
            {
                comboBox3.Items.Add(dir11["soid"].ToString());
            }
            c1.c.Close();
            #endregion
            #region "Receipt Purchase"
            panel3.Visible = false;
            panel3.Location = new Point(155, 130);
            textBox29.Text = "Thank You For Purchasing From Us";
            textBox29.TextAlign = HorizontalAlignment.Center;
            textBox29.BackColor = Color.GhostWhite;
            textBox37.Text = "A.H Organization"+Environment.NewLine+"Purchasing Receipt";
            textBox37.BackColor = Color.GhostWhite;
            label30.Text = "Purchasing I.D";
            label31.Text = "Vendor I.D";
            label32.Text = "Vendor Name";
            label33.Text = "Contect Person";
            label34.Text = "CPPH";
            label35.Text = "Date";
            label37.Text = "Supervisior Signature";
            panel3.BackColor = Color.GhostWhite;
            label36.Text = "Amount Paid";
            c1.c.Open();
            OleDbCommand cd = new OleDbCommand("select* from invoice where grnid='" + textBox30.Text + "'", c1.c);
            OleDbDataReader d = cd.ExecuteReader();
            if (d.Read())
            {
                textBox31.Text = d["Vendorid"].ToString();
                textBox32.Text = d["vendorname"].ToString();
                textBox33.Text = d["Contectperson"].ToString();
                textBox34.Text = d["cpph"].ToString();
                textBox35.Text = d["dcdate"].ToString();
                // textBox35.Text = d["vname"].ToString();
                textBox36.Text = d["amountpayable"].ToString();
            }
            c1.c.Close();
            #endregion
            #region "Receipt Sell"
            panel4.Visible = false;
            panel4.Location = new Point(155, 130);
            panel4.BackColor = Color.GhostWhite;
            textBox46.Text = "Thank You For Purchasing From Us";
            textBox46.TextAlign = HorizontalAlignment.Center;
            textBox46.BackColor = Color.GhostWhite;
            textBox38.Text = "A.H Organization" + Environment.NewLine + "Sell Receipt";
            textBox38.BackColor = Color.GhostWhite;
            label38.Text = "Supervisior Signature";
            label45.Text = "Sell I.D";
            label44.Text = "Customer I.D";
            label43.Text = "Customer Name";
            label42.Text = "Contect Person";
            label41.Text = "CPPH";
            label40.Text = "Date";
            label39.Text = "Total Amount";
            c1.c.Open();
            OleDbCommand cd21 = new OleDbCommand("select* from invoiceso where sonid='" + textBox45.Text + "'", c1.c);
            OleDbDataReader d21 = cd21.ExecuteReader();
            if (d21.Read())
            {
                textBox44.Text = d21["Vendorid"].ToString();
                textBox43.Text = d21["vendorname"].ToString();
                textBox42.Text = d21["Contectperson"].ToString();
                textBox41.Text = d21["cpph"].ToString();
                textBox40.Text = d21["dcdate"].ToString();
                // textBox35.Text = d["vname"].ToString();
                textBox39.Text = d21["AmountReceivable"].ToString();
            }
            c1.c.Close();
            #endregion
            #endregion

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region "Purchase Combox1"
            c1.c.Open();
            OleDbCommand cd = new OleDbCommand("select* from poproducts where poid='" + comboBox1.Text + "'", c1.c);
            OleDbDataReader d = cd.ExecuteReader();
            if (d.Read())
            {
                textBox1.Text = d["pmodel"].ToString();
                textBox2.Text = d["pqty"].ToString();
            }
            c1.c.Close();
            OleDbDataAdapter da = new OleDbDataAdapter("select pmodel,pqty from poproducts where poid='" + comboBox1.Text + "'", c1.c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            if (comboBox1.Text != "")
            {
                int c = 0;
                c1.c.Open();
                OleDbCommand cn = new OleDbCommand("select count(grnid) from grnproducts", c1.c);
                OleDbDataReader de = cn.ExecuteReader();
                while (de.Read())
                {
                    c = Convert.ToInt32(de[0]);
                    c++;
                }
                textBox5.Text = "GRN-00" + c.ToString() + "/" + comboBox1.Text;
                c1.c.Close();
            }
            #endregion
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region "Purchase Make GRN button 1 And combo I.D's"
            //groupBox2.Visible = true;
            //label7.Visible = true;
            //comboBox2.Visible = true;
            c1.c.Open();
            OleDbCommand cmd2 = new OleDbCommand("insert into grnproducts(grnid,pmodel,pqty) values(@grnid,@pmodel,@pqty)", c1.c);
            cmd2.Parameters.AddWithValue("@grnid", textBox5.Text);
            cmd2.Parameters.AddWithValue("@pmodel", textBox1.Text);
            cmd2.Parameters.AddWithValue("@pqty", textBox2.Text);
            cmd2.ExecuteNonQuery();
            c1.c.Close();
            c1.c.Open();
            OleDbCommand cmd1 = new OleDbCommand("UPDATE po SET status=@status WHERE poid= '" + comboBox1.Text + "'", c1.c);
            cmd1.Parameters.AddWithValue("@status", "Closed");
            cmd1.ExecuteNonQuery();
            c1.c.Close();
            MessageBox.Show("Information has enter");
            c1.c.Open();
            OleDbCommand m1 = new OleDbCommand("SELECT grnid FROM grnproducts ", c1.c);
            OleDbDataReader dq = m1.ExecuteReader();
            while (dq.Read()) { comboBox2.Items.Add(dq["grnid"].ToString()); comboBox2.Refresh(); }
            c1.c.Close();
            #endregion
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region "Purchase Combox 2"
            c1.c.Open();
            OleDbCommand cd = new OleDbCommand("select* from grnproducts where grnid='" + comboBox2.Text + "'", c1.c);
            OleDbDataReader d = cd.ExecuteReader();
            if (d.Read())
            {
                textBox9.Text = d["pmodel"].ToString();
                textBox8.Text = d["pqty"].ToString();
            }
            c1.c.Close();
            if (comboBox2.Text != "'")
            {
                textBox4.Visible = true;
                textBox4.Text = comboBox1.Text;
            }
            #endregion
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            #region "Purchase Selected Index Of Txtbox"
            if (textBox4.Visible == true)
            {
                c1.c.Open();
                OleDbCommand cd = new OleDbCommand("select* from po where poid='" + textBox4.Text + "'", c1.c);
                OleDbDataReader d = cd.ExecuteReader();
                if (d.Read())
                {
                    textBox10.Text = d["dcdate"].ToString();
                    textBox7.Text = d["vname"].ToString();
                }
                c1.c.Close();
                c1.c.Open();
                OleDbCommand cd6 = new OleDbCommand("select* from vendor where vname='" + textBox7.Text + "'", c1.c);
                OleDbDataReader d6 = cd6.ExecuteReader();
                if (d6.Read())
                {
                    textBox14.Text = d6["cpph"].ToString();
                    textBox15.Text = d6["vid"].ToString();
                    textBox6.Text = d6["cpname"].ToString();
                }
                c1.c.Close();
            #endregion
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region "Purchase Ok Button"
            c1.c.Open();
            OleDbCommand cmd4 = new OleDbCommand(" insert into grn(grnid,basedocument,status,vname,dcdate) values(@grnid,@basedocument,@status,@vname,@dcdate)", c1.c);
            cmd4.Parameters.AddWithValue("@grnid", comboBox2.Text);
            cmd4.Parameters.AddWithValue("@basedocument", textBox4.Text);
            cmd4.Parameters.AddWithValue("@status", textBox13.Text);
            cmd4.Parameters.AddWithValue("@vname", textBox7.Text);
            cmd4.Parameters.AddWithValue("@dcdate", textBox11.Text);
            cmd4.ExecuteNonQuery();
            c1.c.Close();
            c1.c.Open();
            OleDbCommand cmd44 = new OleDbCommand(" insert into invoice(vendorid,vendorname,contectperson,cpph,dcdate,grnid) values(@vendorid,@vendorname,@contectperson,@cpph,@dcdate,@grnid)", c1.c);
            cmd44.Parameters.AddWithValue("@vendorid", textBox15.Text);
            cmd44.Parameters.AddWithValue("@vendorname", textBox7.Text);
            cmd44.Parameters.AddWithValue("@contectperson", textBox6.Text);
            cmd44.Parameters.AddWithValue("@cpph", textBox14.Text);
            cmd44.Parameters.AddWithValue("@dcdate", textBox11.Text);
            cmd44.Parameters.AddWithValue("@grnid", comboBox3.Text);
            cmd44.ExecuteNonQuery();
            c1.c.Close();
            c1.c.Open();
            OleDbCommand cmd11 = new OleDbCommand("UPDATE grn SET status=@status WHERE grnid= '" + comboBox2.Text + "'", c1.c);
            cmd11.Parameters.AddWithValue("@status", "Closed");
            cmd11.ExecuteNonQuery();
            MessageBox.Show("Goods are received and Amount has been Paid");
            c1.c.Close();
            panel3.Visible = true;
            panel1.Visible = false;
            textBox30.Text = comboBox2.Text;
           
            #endregion
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region "Sell And Combo I.D's"
            c1.c.Open();
            OleDbCommand cmd2 = new OleDbCommand("insert into sodnproducts(sonid,pid,pqty) values(@sonid,@pid,@pqty)", c1.c);
            cmd2.Parameters.AddWithValue("@grnid", textBox17.Text);
            cmd2.Parameters.AddWithValue("@pid", textBox18.Text);
            cmd2.Parameters.AddWithValue("@pqty", textBox19.Text);
            cmd2.ExecuteNonQuery();
            c1.c.Close();
            MessageBox.Show("Add");
            c1.c.Open();
            OleDbCommand m1 = new OleDbCommand("SELECT sonid FROM sodnproducts ", c1.c);
            OleDbDataReader dq = m1.ExecuteReader();
            while (dq.Read()) { comboBox4.Items.Add(dq["sonid"].ToString()); comboBox4.Refresh(); }
            c1.c.Close();
            #endregion
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            #region "Sell Combox 3"
            c1.c.Open();
            OleDbCommand cd = new OleDbCommand("select* from soproducts where soid='" + comboBox3.Text + "'", c1.c);
            OleDbDataReader d = cd.ExecuteReader();
            if (d.Read())
            {
                textBox18.Text = d["pid"].ToString();
                textBox19.Text = d["pqty"].ToString();
            }
            c1.c.Close();
            OleDbDataAdapter da = new OleDbDataAdapter("select pid,pqty from soproducts where soid='" + comboBox3.Text + "'", c1.c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if (comboBox3.Text != "")
            {
                int c = 0;
                c1.c.Open();
                OleDbCommand cn = new OleDbCommand("select count(sonid) from sodnproducts", c1.c);
                OleDbDataReader de = cn.ExecuteReader();
                while (de.Read())
                {
                    c = Convert.ToInt32(de[0]);
                    c++;
                }
                c1.c.Close();
                textBox17.Text = "SON-00" + c.ToString() + "/" + comboBox3.Text;
            }
#endregion
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region "Sell Combox 4"
            c1.c.Open();
            OleDbCommand cd = new OleDbCommand("select* from sodnproducts where sonid='" + comboBox4.Text + "'", c1.c);
            OleDbDataReader d = cd.ExecuteReader();
            if (d.Read())
            {
                textBox20.Text = d["pid"].ToString();
                textBox21.Text = d["pqty"].ToString();
            }
            c1.c.Close();
            if (comboBox4.Text != "'")
            {
                //textBox4.Visible = true;
                textBox25.Text = comboBox3.Text;
            }
            #endregion
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            #region "SELL Txtbox Selected Index"
            // if (textBox4.Visible == true)
            //{
            c1.c.Open();
            OleDbCommand cd = new OleDbCommand("select* from so where soid='" + textBox25.Text + "'", c1.c);
            OleDbDataReader d = cd.ExecuteReader();
            if (d.Read())
            {
                textBox24.Text = d["dcdate"].ToString();
                textBox23.Text = d["vname"].ToString();
            }
            c1.c.Close();
            c1.c.Open();
            OleDbCommand cd6 = new OleDbCommand("select* from customer where cname='" + textBox23.Text + "'", c1.c);
            OleDbDataReader d6 = cd6.ExecuteReader();
            if (d6.Read())
            {
                textBox26.Text = d6["cpph"].ToString();
                textBox27.Text = d6["cid"].ToString();
                textBox22.Text = d6["contectperson"].ToString();
            }
            c1.c.Close();
            #endregion
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            #region "SEll OK Button"
            c1.c.Open();
            OleDbCommand cmd4 = new OleDbCommand(" insert into sodn(sonid,basedocument,status,vname,dcdate) values(@sonid,@basedocument,@status,@vname,@dcdate)", c1.c);
            cmd4.Parameters.AddWithValue("@sonid", comboBox4.Text);
            cmd4.Parameters.AddWithValue("@basedocument", textBox25.Text);
            cmd4.Parameters.AddWithValue("@status", textBox28.Text);
            cmd4.Parameters.AddWithValue("@vname", textBox23.Text);
            cmd4.Parameters.AddWithValue("@dcdate", textBox24.Text);
            cmd4.ExecuteNonQuery();
            c1.c.Close();
            c1.c.Open();
            OleDbCommand cmd44 = new OleDbCommand(" insert into invoiceso(vendorid,vendorname,contectperson,cpph,dcdate,sonid) values(@vendorid,@vendorname,@contectperson,@cpph,@dcdate,@sonid)", c1.c);
            cmd44.Parameters.AddWithValue("@vendorid", textBox27.Text);
            cmd44.Parameters.AddWithValue("@vendorname", textBox23.Text);
            cmd44.Parameters.AddWithValue("@contectperson", textBox22.Text);
            cmd44.Parameters.AddWithValue("@cpph", textBox26.Text);
            cmd44.Parameters.AddWithValue("@dcdate", textBox24.Text);
            cmd44.Parameters.AddWithValue("@sonid", comboBox4.Text);
            cmd44.ExecuteNonQuery();
            c1.c.Close();  
            c1.c.Open();
            OleDbCommand cmd11 = new OleDbCommand("UPDATE sodn SET status=@status WHERE sonid= '" + comboBox4.Text + "'", c1.c);
            cmd11.Parameters.AddWithValue("@status", "Closed");
            cmd11.ExecuteNonQuery();
            MessageBox.Show("Goods are Sell and Amount has been Paid");
            c1.c.Close();
            panel4.Visible = true;
            panel2.Visible = false;
            textBox45.Text = comboBox4.Text;
            #endregion
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.Cursor = Cursors.Hand;
        }
        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.Cursor = Cursors.Hand;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
        }
        }
    }
