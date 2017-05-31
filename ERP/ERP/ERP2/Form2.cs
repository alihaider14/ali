using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP2
{
    public partial class Form2 : Form
    {
        string[] prds = new string[50];
        int[] qty = new int[50];
       int[] tot=new int[50];
        int counter = 0;

        Class1 c1 = new Class1();
        public Form2()
        {
            InitializeComponent();
            #region "Conn"
            c1.constring();
            #endregion
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            #region"Properties"
            textBox21.BackColor = Color.DodgerBlue;
            textBox22.BackColor = Color.DodgerBlue;
            textBox21.Text = Environment.NewLine + "Administration";
            textBox21.Font = new Font("Bold", 15, FontStyle.Bold);
            textBox22.TextAlign = HorizontalAlignment.Center;
            textBox22.Text = "Module";
            textBox22.Font = new Font("Bold", 18, FontStyle.Bold);
            textBox21.ForeColor = Color.Snow;
            textBox22.ForeColor = Color.WhiteSmoke; 
            textBox8.Size = new Size(867, 92);
            textBox8.BackColor = Color.DeepSkyBlue;
            textBox8.Text = "Enterprise Resource Planning";
            textBox8.TextAlign = HorizontalAlignment.Center;
            textBox8.Font = new Font("Bold", 40, FontStyle.Regular);
            textBox8.ForeColor = Color.SlateGray;
            button8.Location = new Point(950, 0);
            button8.Size = new Size(68, 60);
            button8.BackColor = Color.DeepSkyBlue;
            button8.Text = "Logout";
            button8.ForeColor = Color.Blue;
            this.Text = "A.H Organization";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DeepSkyBlue;
            button4.Cursor = Cursors.Hand;
            button5.Cursor = Cursors.Hand;
            button4.Text = "Make Purchase";
            button5.Text = "Make Sell";
            button4.ForeColor = Color.WhiteSmoke;
            button5.ForeColor = Color.WhiteSmoke;
            button4.BackColor = Color.DeepSkyBlue;
            button5.BackColor = Color.DeepSkyBlue;
            panel4.BackColor = Color.DodgerBlue;
            panel4.Size = new Size(148, 617);
            //panel3.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            panel5.Location = new Point(250, 100);
            panel6.Location = new Point(250, 100);
           // panel5.Left = (this.Width - Size.Width) / 4;
            //panel5.Size = new Size(840, 690);
            //groupBox5.Location = new Point(10, 10);
            //dataGridView1.Location = new Point(10, 470);
            //textBox34.Location = new Point(310, 470);
            //button6.Location = new Point(308, 660);
            //button7.Location = new Point(761, 500);  
            //panel1.Visible = false;
            //panel2.Visible = false;
            //panel3.Visible = false;
            panel6.Visible = false;
            panel5.Visible = false;
            panel6.BackColor = Color.DodgerBlue;
            panel5.BackColor = Color.DodgerBlue;
            // groupBox4.Font = new Font("Arial", 12, FontStyle.Bold);
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            #region "Sell"
            groupBox5.Text = "Buy Products From A.H Organization";
            groupBox4.Text = "";
            groupBox6.Text = "Choose Items To Buy";
            label19.Text = "Phone No.1";
            label12.Text = "Choose Customer";
            label20.Text = "Phone No.2";
            label21.Text = "Address";
            label22.Text = "Group";
            label23.Text = "CPPH";
            label24.Text = "Vendor I.D";
            label25.Text = "Contect Person";
            label26.Text = "Choose Delivery Date";
            label27.Text = "Name";
            label28.Text = "I.D";
            label29.Text = "Price";
            label30.Text = "Quantity";
            label31.Text = "Sell I.D";
            label32.Text = "Date";
            textBox30.Text = "Not Approved";
            textBox30.Visible = false;
            textBox36.Text = "Open";
            button6.Text = "Add To My Cart";
            button6.BackColor = Color.LightSkyBlue;
            button7.Text = "Order";
            button7.BackColor = Color.LightSkyBlue;
            textBox36.Visible = false;
            groupBox5.BackColor = Color.WhiteSmoke;
            groupBox4.BackColor = Color.WhiteSmoke;
            groupBox6.BackColor = Color.WhiteSmoke;
            panel7.BackColor = Color.WhiteSmoke;
            c1.c.Open();
            OleDbCommand cm = new OleDbCommand("select cname from customer", c1.c);
            OleDbDataReader dir = cm.ExecuteReader();
            while (dir.Read())
            {
                comboBox4.Items.Add(dir["cname"].ToString());
            }
            c1.c.Close();
            comboBox4.GotFocus += focgo1;
            comboBox4.LostFocus += foclo1;
            comboBox4.Text = "Select Customer:-";
            c1.c.Open();
            OleDbCommand cm0 = new OleDbCommand("select pname from products", c1.c);
            OleDbDataReader dir0 = cm0.ExecuteReader();
            while (dir0.Read())
            {
                comboBox5.Items.Add(dir0["pname"].ToString());
            }
            int c = 0;
            c1.c.Close();
            c1.c.Open();
            OleDbCommand cn = new OleDbCommand("select count(soid) from so", c1.c);
            OleDbDataReader de = cn.ExecuteReader();
            while (de.Read())
            {
                c = Convert.ToInt32(de[0]);
                c++;
            }
            textBox11.Text = "Sel-00" + c.ToString()+"-" + System.DateTime.Today.Year;
            c1.c.Close();
            #endregion
            #region "Purchase"
            ControlBox = false;
            comboBox1.Text = "Choose I.D";
            label1.Text = "Name";
            textBox10.Text = "Open";
            textBox19.Text = "Not approved";
            textBox10.Visible = false;
            textBox19.Visible = false;
            label2.Text = "Code";
            label3.Text = "City";
            label4.Text = "Phone no.1";
            label5.Text = "Phone no.2";
            label6.Text = "Address";
            label7.Text = "Group";
            label8.Text = "CPPH";
            label11.Text = "Vendor I.D";
            label10.Text = "Select Product Receving Date";
            label9.Text = "Select Department";
            label13.Text = "Purchase I.D";
            button1.Text = "ADD";
            button1.BackColor = Color.LightSkyBlue;
            label14.Text = "Product Name";
            label15.Text = "Product I.D";
            label16.Text = "Price";
            label17.Text = "Product Quantity";
            label18.Text = "Contect Person";
            label33.Text = "Name";
            label34.Text = "Contect No.";
            button2.Text = "Order";
            button2.BackColor = Color.LightSkyBlue;
            button3.Text = "";
            button3.BackColor = Color.LightSkyBlue;
            groupBox3.Text = "Product Name";
            groupBox2.Text = "Customer I.D Generator";
            groupBox1.Text = "Choose A Vender For Your Order";
            textBox17.Text = "Your Selected Product";
            groupBox1.BackColor = Color.Snow;
            groupBox2.BackColor = Color.Snow;
            groupBox3.BackColor = Color.Snow;
            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            c1.c.Open();
            OleDbCommand cmd = new OleDbCommand("select vgroup from vendor", c1.c);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["vgroup"].ToString());
            }
            c1.c.Close();
            comboBox2.Text = "Select Group:-";
            comboBox2.GotFocus += focgo;
            comboBox2.LostFocus += foclo;
            c1.c.Open();
            OleDbCommand cm3 = new OleDbCommand("select vid from vendor", c1.c);
            OleDbDataReader dir3 = cm3.ExecuteReader();
            while (dir3.Read())
            {
                comboBox1.Items.Add(dir3["vid"].ToString());
            }
            c1.c.Close();
            c1.c.Open();
            OleDbCommand cm1 = new OleDbCommand("select pname from products", c1.c);
            OleDbDataReader dir1 = cm1.ExecuteReader();
            while (dir1.Read())
            {
                comboBox3.Items.Add(dir1["pname"].ToString());
            }
            c1.c.Close();
            #endregion   
            #endregion
        }
        #region "Focus"
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
             public void focgo1(object sender, EventArgs e)
        {
            ComboBox cb2 = (ComboBox)sender;
            {
                if (cb2.Text == "Select Customer:-") { cb2.Text = ""; cb2.ForeColor = Color.Black; }
            }
        }
        public void foclo1(object sender, EventArgs e)
        {
            ComboBox cb2 = (ComboBox)sender;
            {
                if (cb2.Text == "") { cb2.Text = "Select Customer:-"; cb2.ForeColor = Color.Gray; }
            }
        }
        #endregion
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region "Combox 1"
            if (comboBox1.Text != "")
            {
                //panel1.Visible = true;
            }
            c1.c.Open();
            OleDbCommand cd = new OleDbCommand("select* from vendor where Vid='"
            + comboBox1.Text + "'", c1.c);
            OleDbDataReader d = cd.ExecuteReader();
            if (d.Read())
            {
                textBox1.Text = d["vname"].ToString();
                textBox2.Text = d["vcode"].ToString();
                textBox3.Text = d["vcity"].ToString();
                textBox4.Text = d["ph1"].ToString();
                textBox5.Text = d["ph2"].ToString();
                textBox6.Text = d["vaddress"].ToString();
                textBox7.Text = d["vgroup"].ToString();
                textBox9.Text = d["CPPH"].ToString();
                textBox18.Text = d["CPName"].ToString();
            }
            c1.c.Close();
            #endregion
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region "Purchase I.D Combo 2"
            if (comboBox2.Text != "")
            {
                panel3.Visible = true;
            }
            if (comboBox2.Text != "") { panel2.Visible = true; }
            int c = 0;
            c1.c.Open();
            OleDbCommand cmd1 = new OleDbCommand("select count(poid) from po " + comboBox2.Text, c1.c);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                c = Convert.ToInt32(dr1[0]); c++;
            }
            if (comboBox2.Text == "Consumer")
            {textBox12.Text = "Cons-00" + c.ToString() + "-" + System.DateTime.Today.Year;}
          if(comboBox2.Text == "HR")  {textBox12.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year; }
         if (comboBox2.Text == "Sales")  { textBox12.Text = "Sals-00" + c.ToString() + "-" + System.DateTime.Today.Year; }
         c1.c.Close();
#endregion
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region "Purchase Items"
            c1.c.Open();
            OleDbCommand cd1 = new OleDbCommand("select* from products where pname='" + comboBox3.Text + "'", c1.c);
            OleDbDataReader d1 = cd1.ExecuteReader();
            if (d1.Read())
            {
                textBox14.Text = d1["pmodel"].ToString();
                textBox15.Text = d1["baseprice"].ToString();
            }
            c1.c.Close();
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region "Purchase Adding Items"
            int b = Convert.ToInt32(textBox16.Text);
            int a = Convert.ToInt32(textBox15.Text);
            try {
                textBox13.Text += "Product I.D=" + textBox14.Text + Environment.NewLine + "Product Qantity=" + textBox16.Text + Environment.NewLine;
                textBox13.Text += "Total of Products=" + ((a * b).ToString()) + Environment.NewLine;
                prds[counter] = textBox14.Text;
                counter++;
                b = Convert.ToInt32(textBox16.Text); qty[counter] = Convert.ToInt32(textBox16.Text); 
            }
            catch (Exception) {
                MessageBox.Show("Enter Correct In Quantity");
                textBox13.Clear();
            }     
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region "Transaction Button"
            c1.c.Open();
            for (int i = 0; i < counter; i++)
            {
                OleDbCommand cmd = new OleDbCommand("insert into poproducts(poid,pmodel,pqty) values(@poid,@pmodel,@pqty)", c1.c);
                cmd.Parameters.AddWithValue("@poid", textBox12.Text);
                cmd.Parameters.AddWithValue("@pmodel", textBox14.Text);
                cmd.Parameters.AddWithValue("@pqty", textBox16.Text);
                cmd.ExecuteNonQuery();
            }
            c1.c.Close();

            c1.c.Open();
            OleDbCommand cmd2 = new OleDbCommand("insert into po(dcdate,vcpph,poid,status,vdept,vname,vid,vcontectperson,approve) values(@dcdate,@vcpph,@poid,@status,@vdept,@vname,@vid,@vcontectperson,@approve)", c1.c);
            cmd2.Parameters.AddWithValue("@dcdate", dateTimePicker1.Value.Date);
            cmd2.Parameters.AddWithValue("@vcpph", textBox9.Text);
            cmd2.Parameters.AddWithValue("@poid", textBox12.Text);
            cmd2.Parameters.AddWithValue("@status", textBox10.Text);
            cmd2.Parameters.AddWithValue("@vdept", textBox7.Text);
            cmd2.Parameters.AddWithValue("@vname", textBox1.Text);
            cmd2.Parameters.AddWithValue("@vid", comboBox1.Text);
            cmd2.Parameters.AddWithValue("@vcontectperson", textBox18.Text);
            cmd2.Parameters.AddWithValue("@approve", textBox19.Text);
            cmd2.ExecuteNonQuery();
            c1.c.Close();
            MessageBox.Show("Transaction done!!");
            Form3 f3 = new Form3();
            f3.ShowDialog();
            f3.panel1.Visible = true;
             #endregion
        }
        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            string st = "0123456789"+(char)8;
            if (st.IndexOf(e.KeyChar) == 1)
            {  e.Handled = true; }//MessageBox.Show("please enter digits only");
            //else
            //    MessageBox.Show("please enter digits only");
            //if (e.KeyChar)
            //{
            //    MessageBox.Show("Please Enter Digit Only");
            //    e.Handled = true;
            //}
            //else
            //{  }
        }
        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            //if (textBox20.Text != "'")
            //{
                //int c = Convert.ToInt32(textBox20.Text);
                //int q = Convert.ToInt32(textBox20.Text);
                //int rs = c + q;
                //textBox20.Text += rs.ToString();
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel5.Visible = false;
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region "Sell Customer"
            c1.c.Open();
            OleDbCommand cd1 = new OleDbCommand("select* from customer where cname='" + comboBox4.Text + "'", c1.c);
            OleDbDataReader d1 = cd1.ExecuteReader();
            if (d1.Read())
            {
                textBox23.Text = d1["ph1"].ToString();
                textBox24.Text = d1["ph2"].ToString();
                textBox25.Text = d1["caddress"].ToString();
                textBox26.Text = d1["cgroup"].ToString();
                textBox27.Text = d1["cpph"].ToString();
                textBox28.Text = d1["cid"].ToString();
                textBox29.Text = d1["contectperson"].ToString();
            }
            c1.c.Close();
            #endregion
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1.c.Open();
            OleDbCommand cd1 = new OleDbCommand("select* from products where pname='" + comboBox5.Text + "'", c1.c);
            OleDbDataReader d1 = cd1.ExecuteReader();
            if (d1.Read())
            {
                textBox32.Text = d1["pmodel"].ToString();
                textBox31.Text = d1["baseprice"].ToString();
            }
            c1.c.Close();
            #region "Picture Box" 
            if (comboBox5.Text == "gvg")
            {
                pictureBox4.Visible = true; pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
            }
            if (comboBox5.Text == "Equa Cleaner")
            {
                pictureBox4.Visible = false; pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
            }
            if (comboBox5.Text == "LG")
            {
                pictureBox4.Visible = false; pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
            }
            if (comboBox5.Text == "Lipton Tea")
            {
                pictureBox4.Visible = false; pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
            }
            if (comboBox5.Text == "L’Oreal")
            {
                pictureBox4.Visible = false; pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
            }
            if (comboBox5.Text == "Nortair")
            {
                pictureBox4.Visible = false; pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
                pictureBox10.Visible = false;
            }
            if (comboBox5.Text == "Urban Decay")
            {
                pictureBox4.Visible = false; pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
            }
            #endregion
        }

        private void button6_Click(object sender, EventArgs e)
        {
            #region "Sell Adding Items"
            try {
                int x = Convert.ToInt32(textBox33.Text);
                int f = Convert.ToInt32(textBox31.Text);
                textBox34.Text += "Product I.D=" + textBox32.Text + Environment.NewLine + "Product Qantity=" + textBox33.Text + Environment.NewLine;
                textBox34.Text += "Total Of One Product=" + ((x * f).ToString()) + Environment.NewLine;
                prds[counter] = textBox32.Text;
                counter++;
                x = Convert.ToInt32(textBox33.Text);
            qty[counter] = Convert.ToInt32(textBox33.Text);
            }
            catch (Exception) { 
                MessageBox.Show("Enter Correct In Quantity");
                textBox34.Clear();
            }
            #endregion
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region "Sell Order"
            c1.c.Open();
            for (int i = 0; i < counter; i++)
            {
                OleDbCommand cmd = new OleDbCommand("insert into soproducts(soid,pid,pqty) values(@soid,@pid,@pqty)", c1.c);
                cmd.Parameters.AddWithValue("@soid", textBox11.Text);
                cmd.Parameters.AddWithValue("@pid", textBox32.Text);
                cmd.Parameters.AddWithValue("@pqty", textBox33.Text);
                cmd.ExecuteNonQuery();
            }
            c1.c.Close();
            c1.c.Open();
            OleDbCommand cmd2 = new OleDbCommand("insert into so(soid,dcdate,status,approve,vname,vid,vdept,vcontectperson,vcpph) values(@soid,@dcdate,@status,@approve,@vname,@vid,@vdept,@vcontectperson,@vcpph)", c1.c);
            cmd2.Parameters.AddWithValue("@soid", textBox11.Text);
            cmd2.Parameters.AddWithValue("@dcdate", dateTimePicker2.Value.Date);
            cmd2.Parameters.AddWithValue("@status", textBox36.Text);
            cmd2.Parameters.AddWithValue("@approve", textBox30.Text);
            cmd2.Parameters.AddWithValue("@vname", comboBox4.Text);
            cmd2.Parameters.AddWithValue("@vid", textBox28.Text);
            cmd2.Parameters.AddWithValue("@vdept", textBox26.Text);
            cmd2.Parameters.AddWithValue("@contectperson", textBox29.Text);
            cmd2.Parameters.AddWithValue("@vcpph", textBox27.Text);
            cmd2.ExecuteNonQuery();
            c1.c.Close();
            MessageBox.Show("Order Has Been Added");
            //this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
               f3.panel2.Visible = true;
            #endregion
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel6.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
