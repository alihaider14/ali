using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Third_Semister_Project
{
    public partial class Form1 : Form
    {
        #region "Control Box"
        Panel controlbx = new Panel();
        Button exit = new Button();
        Button min = new Button();
        Label name = new Label();
        Label create = new Label();
        #endregion
        string id = "";
        int price ;
        int z ;
        string custid = "";
        string[] prds = new string[100];
        int[] qty = new int[100];
        string[] nam = new string[100];
        int[] itsq = new int[100];
        int[] tot = new int[10000];
        int counter = 0;
        Class1 c1 = new Class1();
        public Form1()
        {
            InitializeComponent();
            c1.consqlstng();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region "Indicator"
            label19.Visible = false;
            label51.Visible = false;
            label52.Visible = false;
            label53.Visible = false;
            label54.Visible = false;
            label56.Visible = false;
            label70.Visible = false;
            label71.Visible = false;
            label67.Visible = false;
            label68.Visible = false;
            label24.Visible = false;
            label22.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            lineShape5.Visible = false;
            lineShape50.Visible = false;
            lineShape6.Visible = false;
            lineShape7.Visible = false;
            lineShape9.Visible = false;
            lineShape11.Visible = false;
            lineShape23.Visible = false;
            lineShape24.Visible = false;
            lineShape25.Visible = false;
            lineShape26.Visible = false;
            lineShape29.Visible = false;
            lineShape35.Visible = false;
            lineShape56.Visible = false;
            lineShape57.Visible = false;
            #endregion
            panel1.Visible = false;
            panel2.Visible = false;
            //panel3.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            textBox10.Visible = false;
            textBox29.Visible = false;
            this.ActiveControl = label1;
            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;
            //this.BackgroundImage = Properties.Resources.light_grey_422c__1207_p;
            this.WindowState = FormWindowState.Maximized;
            this.Controls.Add(controlbx);
            this.Controls.Add(create);
            #region "Login panel 1"
            panel1.Size = new Size(416, 351);
            panel1.BackColor = Color.LightCoral;
            panel1.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - panel1.Size.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - panel1.Size.Height / 2);
            textBox3.Text = "Sign In to create Account"+Environment.NewLine+"So you can avail our best Offers";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.BackColor = Color.LightCoral;
            textBox3.ForeColor = Color.White;
            textBox2.PasswordChar = '*';
            label10.Text = "Login To Al-Bazar Utility Store";
            label10.BackColor = Color.LightCoral;
            label10.ForeColor = Color.White;
            label1.Text = "Username";
            label1.ForeColor = Color.White;
            label2.Text = "Password";
            label2.ForeColor = Color.White;
            button1.Text = "Login";
            button1.ForeColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.Cursor = Cursors.Hand;
            button1.BackColor = Color.Red;
            button2.Text = "Sign In";
            button2.Cursor = Cursors.Hand;
            button2.Click += button2_Click;
            button2.ForeColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.BackColor = Color.Red;
            pictureBox15.Size = new Size(61, 58);
            #endregion
            #region "Customer Panel 2"
            panel2.Size = new Size(492, 506);
            panel2.Visible = false;
            panel2.BackColor = Color.LightCoral;
            panel2.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - panel2.Size.Width / 2, 160);
            label3.Text = "Name";
            label3.ForeColor = Color.White;
            label4.Text = "Address";
            label4.ForeColor = Color.White;
            label5.Text = "Phone no.";
            label5.ForeColor = Color.White;
            label6.Text = "Province";
            label6.ForeColor = Color.White;
            label7.Text = "City";
            label7.ForeColor = Color.White;
            label8.Text = "Email";
            label8.ForeColor = Color.White;
            label9.Text = "Name";
            label9.ForeColor = Color.White;
            label38.Text = "Gender";
            label38.ForeColor = Color.White;
            label62.Text = "Date Set";
            label62.ForeColor = Color.White;
            radioButton1.Text = "Male";
            radioButton1.ForeColor = Color.White;
            radioButton2.Text = "Female";
            radioButton2.ForeColor = Color.White;
            label11.Text = "Customer Information Form";
            label11.ForeColor = Color.White;
            panel2.Paint += panel2_Paint;
            button3.Click+=button3_Click;
            button3.Text = "Register";
            button3.ForeColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.BackColor = Color.Red;
            button3.Cursor = Cursors.Hand;
            button4.Text = "X";
            button4.Click += button4_Click;
            button4.Paint += button4_Paint;
            button4.BackColor = Color.LightSlateGray;
            button4.ForeColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.Cursor = Cursors.Hand;
            int q = 1;
            c1.sql.Open();
            SqlCommand cn = new SqlCommand("select count(custid) from customer", c1.sql);
            SqlDataReader de = cn.ExecuteReader();
            while (de.Read())
            {
                q = Convert.ToInt32(de[0]);
                q++;
            }
            textBox10.Text = "Customer-00" + q.ToString();
            c1.sql.Close();
            c1.sql.Open();
            SqlCommand cmd = new SqlCommand("select provincename from province", c1.sql);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["provincename"]);

            }
            c1.sql.Close();
            #endregion
            #region "Control Box"
            create.Font = new Font("", 10);
            create.Text = "Program by Ali";
            create.BackColor = Color.White;
            create.ForeColor = Color.Black;
            create.BorderStyle = BorderStyle.None;
            create.Location = new Point(920, 745);
            controlbx.BorderStyle = BorderStyle.FixedSingle;
            controlbx.Dock = DockStyle.Top;
            controlbx.Size = new Size(0, 35);
            controlbx.Location = new Point(0, 0);
            controlbx.BackColor = Color.DodgerBlue;
            controlbx.Controls.Add(exit);
            controlbx.Controls.Add(min);
            controlbx.Controls.Add(name);
            exit.Text = "X";
            exit.Left = 985;
            exit.Click += exit_Click;
            exit.Size = new Size(50, 35);
            exit.BackColor = Color.LightSkyBlue;
            exit.ForeColor = Color.White;
            exit.FlatStyle = FlatStyle.Flat;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatAppearance.BorderColor = Color.White;
            min.Text = "-";
            min.Left = 935;
            min.Click += min_Click;
            min.Size = new Size(50, 35);
            min.BackColor = Color.LightSkyBlue;
            min.ForeColor = Color.White;
            min.FlatStyle = FlatStyle.Flat;
            min.FlatAppearance.BorderSize = 0;
            min.FlatAppearance.BorderColor = Color.White;
            name.Text = "Project By Code";
            name.ForeColor = Color.WhiteSmoke;
            name.Location = new Point(5, 15);
            #endregion
            #region "Home Page"
            panel3.MouseEnter += panel3_MouseEnter;
            panel4.MouseEnter += panel4_MouseEnter;
            panel4.Size = new Size(1013, 208);
            panel4.BackColor = Color.LightCoral;
            panel4.Location = new Point(3, 4);
            panel3.BackColor = Color.Red;
            panel3.Size = new Size(1015, 713);
            panel3.Location = new Point(6, 35);
            panel7.Size = new Size(339, 110);
            panel7.Paint += panel7_Paint;
            panel7.Location = new Point(panel3.Size.Width / 18 - panel7.Size.Width / 18, 250);
            label12.Text = "Al-Bazar Mission";
            label12.ForeColor = Color.White;
            textBox9.BackColor = Color.Red;
            textBox9.ForeColor = Color.White;
            textBox9.Text = "Provide best Quality Items " + Environment.NewLine + "and maintain the trust of our customer";
            textBox9.TextAlign = HorizontalAlignment.Center;
            button8.Text = "Contect Us";
            button8.Visible = false;
            button8.Click += button8_Click;
            button8.BackColor = Color.Crimson;
            button8.ForeColor = Color.White;
            button8.FlatAppearance.BorderColor = Color.White;
            button9.Text = "Made By";
            button9.Visible = false;
            button9.Click += button9_Click;
            button9.BackColor = Color.Crimson;
            button9.ForeColor = Color.White;
            button9.FlatAppearance.BorderColor = Color.White;
            button10.Text = "About Al-Bazar";
            button10.Visible = false;
            button10.Click += button10_Click;
            button10.BackColor = Color.Crimson;
            button10.ForeColor = Color.White;
            button10.FlatAppearance.BorderColor = Color.White;
            button11.Text = "Buy Online";
            button11.Visible = false;
            button11.BackColor = Color.Crimson;
            button11.ForeColor = Color.White;
            button11.FlatAppearance.BorderColor = Color.White;
            button13.Text = "Products List";
            button13.Visible = false;
            button13.BackColor = Color.Crimson;
            button13.ForeColor = Color.White;
            button13.FlatAppearance.BorderColor = Color.White;
            button5.MouseEnter += button5_MouseEnter;
            button5.Text = "Home";
            button5.Cursor = Cursors.Hand;
            button5.ForeColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.BackColor = Color.Red;
            button5.Left = 510;
            button6.MouseHover += button6_MouseEnter;
            button6.Text = "About";
            button6.Cursor = Cursors.Hand;
            button6.ForeColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.BackColor = Color.Red;
            button6.Left = 655;
            pictureBox4.Size = new Size(154, 199);
            pictureBox8.Size = new Size(174, 140);
            pictureBox11.Size = new Size(770, 250);
            pictureBox11.Location = new Point(8, 380);
            pictureBox9.Size = new Size(770, 250);
            pictureBox9.Location = new Point(8, 380);
            pictureBox10.Size = new Size(770, 250);
            pictureBox10.Location = new Point(8, 380);
            timer1.Start();
            label25.Location = new Point(8, 380);
            label25.Text = "Advertisment";
            label25.ForeColor = Color.Blue;
            button7.MouseHover += button7_MouseHover;
            button7.Text = "Products";
            button7.Cursor = Cursors.Hand;
            button7.ForeColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.BackColor = Color.Red;
            button7.Left = 800;
            button12.Text = "Login";
            button12.Cursor = Cursors.Hand;
            button12.ForeColor = Color.White;
            button12.FlatAppearance.BorderSize = 0;
            button12.BackColor = Color.Red;
            button12.Left = 890;
            panel5.MouseLeave += panel5_MouseLeave;
            panel5.Visible = false;
            panel5.Left = 655;
            panel5.Size = new Size(145, 95);
            panel5.BackColor = Color.Red;
            panel6.Visible = false;
            panel6.Left = 800;
            panel6.Size = new Size(148, 67);
            panel6.BackColor = Color.Red;
            panel6.MouseLeave += panel6_MouseLeave;
            pictureBox1.Location = new Point(818, 660);
            label15.Location = new Point(860, 670);
            label15.Text = "/AlBazar.pk";
            label15.ForeColor = Color.White;
            #endregion
            #region "Contect Us"
            panel8.Size = new Size(482, 408);
            panel8.BackColor = Color.LightCoral;
            panel8.Location = new Point(this.Size.Width / 2 - panel8.Size.Width / 2, 200);
            textBox11.Size = new Size(475, 43);
            textBox11.BackColor = Color.LightCoral;
            textBox11.Text = "Contect Us";
            textBox11.ForeColor = Color.White;
            label16.Text = "Your name";
            label16.ForeColor = Color.White;
            label17.Text = "Your email address";
            label17.ForeColor = Color.White;
            label18.Text = "Your Message";
            label18.ForeColor = Color.White;
            button14.Text = "Send";
            button14.BackColor = Color.Red;
            button14.ForeColor = Color.White;
            button14.FlatAppearance.BorderSize = 0;
            button14.Cursor = Cursors.Hand;
            button16.Text = "Back";
            button16.Click += button15_Click;
            button16.Paint += button15_Paint;
            button16.BackColor = Color.Red;
            button16.ForeColor = Color.White;
            button16.FlatAppearance.BorderSize = 0;
            button16.Cursor = Cursors.Hand;
            #endregion
            #region "About us"
            panel10.BackColor = Color.LightCoral;
            panel10.Paint += panel10_Paint;
            panel10.Size = new Size(613, 254);
            panel10.Location = new Point(this.Size.Width / 2 - panel10.Size.Width / 2, 200);
            pictureBox3.Size = new Size(150, 232);
            button17.Text = "X";
            button17.Click += button17_Click;
            button17.Paint += button17_Paint;
            button17.BackColor = Color.LightSlateGray;
            button17.ForeColor = Color.White;
            button17.FlatAppearance.BorderSize = 0;
            button17.Cursor = Cursors.Hand;
            textBox15.Size = new Size(394, 119);
            textBox15.Text = "Al-Bazar is a non Govt. Online Utility Store" + Environment.NewLine + "our moto is to give best quality products to our customer"
                + Environment.NewLine + "Al-Bazar employee are specially train to deal patiently with customer.";
            textBox15.ForeColor = Color.White;
            textBox15.BackColor = Color.LightCoral;
            label23.Text = "Al-Bazar";
            label23.ForeColor = Color.White;
            #endregion
            #region "Made By"
            panel9.BackColor = Color.LightCoral;
            panel9.Location = new Point(this.Size.Width / 3 - panel9.Size.Width / 3, 200);
            panel9.Size = new Size(447, 362);
            panel9.Paint += panel9_Paint;
            pictureBox2.Size = new Size(185, 225);
            pictureBox2.Location = new Point(panel9.Size.Width / 20 - pictureBox2.Size.Width / 20, 10);
            label21.Text = "The Application is Made by";
            label21.ForeColor = Color.White;
            label20.Text = "Ali Haider";
            label20.ForeColor = Color.Blue;
            textBox16.BackColor = Color.LightCoral;
            textBox16.ForeColor = Color.White;
            textBox16.Size = new Size(420, 110);
            textBox16.Text = Environment.NewLine + " He is a student Computer Science Department in Third  Semister of  Fedural Urdu Univerty Of Arts Science And Technology  Karachi Campus." + Environment.NewLine +
                " This is the Project of third Semister";
            button15.Text = "X";
            button15.Click += button15_Click;
            button15.Paint += button15_Paint;
            button15.BackColor = Color.LightSlateGray;
            button15.ForeColor = Color.White;
            button15.FlatAppearance.BorderSize = 0;
            button15.Cursor = Cursors.Hand;
            #endregion
            #region "Buy products"
            panel13.Location = new Point(8, 380);
            panel13.Size = new Size(1013, 290);
            panel13.BackColor = Color.Red;
            button19.Location = new Point(100, 170);
            button18.Location = new Point(100, 20);
            button21.Location = new Point(365, 170);
            button20.Location = new Point(365, 20);
            button22.Location = new Point(635, 20);
            button18.Cursor = Cursors.Hand;
            button19.Cursor = Cursors.Hand;
            button20.Cursor = Cursors.Hand;
            button21.Cursor = Cursors.Hand;
            button22.Cursor = Cursors.Hand;
            button18.FlatAppearance.BorderSize = 0;
            button19.FlatAppearance.BorderSize = 0;
            button20.FlatAppearance.BorderSize = 0;
            button21.FlatAppearance.BorderSize = 0;
            button22.FlatAppearance.BorderSize = 0;
            button18.BackColor = Color.Gray;
            button19.BackColor = Color.Gray;
            button20.BackColor = Color.Gray;
            button21.BackColor = Color.Gray;
            button22.BackColor = Color.Gray;
            label26.Location = new Point(panel13.Size.Width / 2 - label26.Size.Width / 2, 310);
            label26.Text = "Al-Bazar Online Store";
            label26.ForeColor = Color.White;
            label26.Visible = false;
            label27.Location = new Point(100, 1);
            label27.Text = "Rice";
            label27.ForeColor = Color.White;
            label28.Location = new Point(100, 150);
            label28.Text = "Atta";
            label28.ForeColor = Color.White;
            label29.Location = new Point(365, 150);
            label29.Text = "Daal";
            label29.ForeColor = Color.White;
            label30.Location = new Point(365, 1);
            label30.Text = "Species";
            label30.ForeColor = Color.White;
            label31.Location = new Point(635, 1);
            label31.Text = "Cosmetic";
            label31.ForeColor = Color.White;
            panel3.Controls.Add(label26);
            #endregion//work to do on it
            #region "Rice"
            panel11.MouseEnter += panel11_MouseEnter;
            panel11.BackColor = Color.LightCoral;
            panel11.Location = new Point(5, 150);
            panel11.Size = new Size(772, 513);
            comboBox3.GotFocus += focgo;
            comboBox3.LostFocus += foclo;
            label32.Text = "Choose Item";
            label32.ForeColor = Color.White;
            label33.Text = "Choose Quantity";
            label33.ForeColor = Color.White;
            label34.Text = "Items Details";
            label34.ForeColor = Color.White;
            label35.Text = "Enter Item Pack Quantity";
            label35.ForeColor = Color.White;
            label37.Location = new Point(panel11.Size.Width / 3 - label37.Size.Width / 3, 20);
            label37.Text = "Select Rice Items";
            label37.ForeColor = Color.White;
            button23.FlatAppearance.BorderSize = 0;
            button23.Text = "Add To My Cart";
            button23.BackColor = Color.Red;
            button23.ForeColor = Color.White;
            button23.Cursor = Cursors.Hand;
            button42.BackColor = Color.Red;
            button42.ForeColor = Color.White;
            button42.FlatAppearance.BorderSize = 0;
            button42.Cursor = Cursors.Hand;
            button24.Text = "Choose Next Items";
            button24.BackColor = Color.Red;
            button24.ForeColor = Color.White;
            button24.FlatAppearance.BorderSize = 0;
            button24.Cursor = Cursors.Hand;
            button24.Click += button24_Click;
            button24.MouseEnter += button24_MouseEnter;
            button25.Text = "Rice";
            button25.Visible = false;
            button25.BackColor = Color.Crimson;
            button25.ForeColor = Color.White;
            button25.FlatAppearance.BorderSize = 0;
            button25.Cursor = Cursors.Hand;
            button26.Text = "Atta";
            button26.Visible = false;
            button26.BackColor = Color.Crimson;
            button26.ForeColor = Color.White;
            button26.FlatAppearance.BorderSize = 0;
            button26.Cursor = Cursors.Hand;
            button27.Text = "Daal";
            button27.Visible = false;
            button27.BackColor = Color.Crimson;
            button27.ForeColor = Color.White;
            button27.FlatAppearance.BorderSize = 0;
            button27.Cursor = Cursors.Hand;
            button28.Text = "Species";
            button28.Visible = false;
            button28.BackColor = Color.Crimson;
            button28.ForeColor = Color.White;
            button28.FlatAppearance.BorderSize = 0;
            button28.Cursor = Cursors.Hand;
            button29.Text = "Cosmatic";
            button29.Visible = false;
            button29.BackColor = Color.Crimson;
            button29.ForeColor = Color.White;
            button29.FlatAppearance.BorderSize = 0;
            button29.Cursor = Cursors.Hand;
            button66.BackColor = Color.Red;
            button66.Text = "Remove Items";
            button66.ForeColor = Color.White;
            button66.FlatAppearance.BorderSize = 0;
            button66.Cursor = Cursors.Hand;
            string r="";
            textBox18.Text = Environment.NewLine + r.ToString();
            c1.sql.Open();
            SqlCommand cmd1 = new SqlCommand("select rname from rice", c1.sql);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox3.Items.Add(dr1["rname"]);

            }
            c1.sql.Close();
            #endregion
            #region "Atta"
            panel12.MouseEnter+=panel12_MouseEnter;
            panel12.BackColor = Color.LightCoral;
            panel12.Location = new Point(5, 150);
            panel12.Size = new Size(772, 513);
            comboBox4.GotFocus += focgo;
            comboBox4.LostFocus += foclo;
            label44.Text = "Choose Item";
            label44.ForeColor = Color.White;
            label43.Text = "Choose Quantity";
            label43.ForeColor = Color.White;
            label42.Text = "Items Details";
            label42.ForeColor = Color.White;
            label41.Text = "Enter Item Pack Quantity";
            label41.ForeColor = Color.White;
            label39.Location = new Point(panel12.Size.Width / 3 - label39.Size.Width / 3, 20);
            label39.Text = "Select Atta Items";
            label39.ForeColor = Color.White;
            button36.FlatAppearance.BorderSize = 0;
            button36.Text = "Add To My Cart";
            button36.BackColor = Color.Red;
            button36.ForeColor = Color.White;
            button36.Cursor = Cursors.Hand;
            button35.Text = "Choose Next Items";
            button35.BackColor = Color.Red;
            button35.ForeColor = Color.White;
            button35.FlatAppearance.BorderSize = 0;
            button35.Cursor = Cursors.Hand;
            button35.Click+=button35_Click;
            button35.MouseEnter+=button35_MouseEnter;
            button30.Text = "Rice";
            button30.Visible = false;
            button30.BackColor = Color.Crimson;
            button30.ForeColor = Color.White;
            button30.FlatAppearance.BorderSize = 0;
            button30.Cursor = Cursors.Hand;
            button31.Text = "Atta";
            button31.Visible = false;
            button31.BackColor = Color.Crimson;
            button31.ForeColor = Color.White;
            button31.FlatAppearance.BorderSize = 0;
            button31.Cursor = Cursors.Hand;
            button32.Text = "Daal";
            button32.Visible = false;
            button32.BackColor = Color.Crimson;
            button32.ForeColor = Color.White;
            button32.FlatAppearance.BorderSize = 0;
            button32.Cursor = Cursors.Hand;
            button33.Text = "Species";
            button33.Visible = false;
            button33.BackColor = Color.Crimson;
            button33.ForeColor = Color.White;
            button33.FlatAppearance.BorderSize = 0;
            button33.Cursor = Cursors.Hand;
            button34.Text = "Cosmatic";
            button34.Visible = false;
            button34.BackColor = Color.Crimson;
            button34.ForeColor = Color.White;
            button34.FlatAppearance.BorderSize = 0;
            button34.Cursor = Cursors.Hand;
            button67.BackColor = Color.Red;
            button67.Text = "Remove Items";
            button67.ForeColor = Color.White;
            button67.FlatAppearance.BorderSize = 0;
            button67.Cursor = Cursors.Hand;
            string t = "";
            textBox23.Text = Environment.NewLine + t.ToString();
            c1.sql.Open();
            SqlCommand cmd2 = new SqlCommand("select atname from atta", c1.sql);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox4.Items.Add(dr2["atname"]);

            }
            c1.sql.Close();
            #endregion
            #region "daal"
            panel14.MouseEnter+=panel14_MouseEnter;
            panel14.BackColor = Color.LightCoral;
            panel14.Location = new Point(5, 150);
            panel14.Size = new Size(772, 513);
            comboBox5.GotFocus += focgo;
            comboBox5.LostFocus += foclo;
            label50.Text = "Choose Item";
            label50.ForeColor = Color.White;
            label49.Text = "Choose Quantity";
            label49.ForeColor = Color.White;
            label48.Text = "Items Details";
            label48.ForeColor = Color.White;
            label47.Text = "Enter Item Pack Quantity";
            label47.ForeColor = Color.White;
            label45.Location = new Point(panel14.Size.Width / 3 - label45.Size.Width / 3, 20);
            label45.Text = "Select Daal Items";
            label45.ForeColor = Color.White;
            button43.FlatAppearance.BorderSize = 0;
            button43.Text = "Add To My Cart";
            button43.BackColor = Color.Red;
            button43.ForeColor = Color.White;
            button43.Cursor = Cursors.Hand;
            button42.Text = "Choose Next Items";
            button42.BackColor = Color.Red;
            button42.ForeColor = Color.White;
            button42.FlatAppearance.BorderSize = 0;
            button42.Cursor = Cursors.Hand;
            button42.Click+=button42_Click;
            button42.MouseEnter+=button42_MouseEnter;
            button37.Text = "Rice";
            button37.Visible = false;
            button37.BackColor = Color.Crimson;
            button37.ForeColor = Color.White;
            button37.FlatAppearance.BorderSize = 0;
            button37.Cursor = Cursors.Hand;
            button38.Text = "Atta";
            button38.Visible = false;
            button38.BackColor = Color.Crimson;
            button38.ForeColor = Color.White;
            button38.FlatAppearance.BorderSize = 0;
            button38.Cursor = Cursors.Hand;
            button39.Text = "Daal";
            button39.Visible = false;
            button39.BackColor = Color.Crimson;
            button39.ForeColor = Color.White;
            button39.FlatAppearance.BorderSize = 0;
            button39.Cursor = Cursors.Hand;
            button40.Text = "Species";
            button40.Visible = false;
            button40.BackColor = Color.Crimson;
            button40.ForeColor = Color.White;
            button40.FlatAppearance.BorderSize = 0;
            button40.Cursor = Cursors.Hand;
            button41.Text = "Cosmatic";
            button41.Visible = false;
            button41.BackColor = Color.Crimson;
            button41.ForeColor = Color.White;
            button41.FlatAppearance.BorderSize = 0;
            button41.Cursor = Cursors.Hand;
            button68.BackColor = Color.Red;
            button68.Text = "Remove Items";
            button68.ForeColor = Color.White;
            button68.FlatAppearance.BorderSize = 0;
            button68.Cursor = Cursors.Hand;
            string d = "";
            textBox27.Text = Environment.NewLine + d.ToString();
            c1.sql.Open();
            SqlCommand cmd3 = new SqlCommand("select dalname from daal", c1.sql);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox5.Items.Add(dr3["dalname"]);

            }
            c1.sql.Close();
            #endregion
            #region "Species"
            panel15.MouseEnter+=panel15_MouseEnter;
            panel15.BackColor = Color.LightCoral;
            panel15.Location = new Point(5, 150);
            panel15.Size = new Size(772, 513);
            comboBox6.GotFocus += focgo;
            comboBox6.LostFocus += foclo;
            label60.Text = "Choose Item";
            label60.ForeColor = Color.White;
            label59.Text = "Choose Quantity";
            label59.ForeColor = Color.White;
            label58.Text = "Items Details";
            label58.ForeColor = Color.White;
            label57.Text = "Enter Item Pack Quantity";
            label57.ForeColor = Color.White;
            label55.Location = new Point(panel15.Size.Width / 3 - label55.Size.Width / 3, 20);
            label55.Text = "Select Species Items";
            label55.ForeColor = Color.White;
            button50.FlatAppearance.BorderSize = 0;
            button50.Text = "Add To My Cart";
            button50.BackColor = Color.Red;
            button50.ForeColor = Color.White;
            button50.Cursor = Cursors.Hand;
            button49.Text = "Choose Next Items";
            button49.BackColor = Color.Red;
            button49.ForeColor = Color.White;
            button49.FlatAppearance.BorderSize = 0;
            button49.Cursor = Cursors.Hand;
            button49.Click+=button49_Click;
            button49.MouseEnter+=button49_MouseEnter;
            button48.Text = "Rice";
            button48.Visible = false;
            button48.BackColor = Color.Crimson;
            button48.ForeColor = Color.White;
            button48.FlatAppearance.BorderSize = 0;
            button48.Cursor = Cursors.Hand;
            button47.Text = "Atta";
            button47.Visible = false;
            button47.BackColor = Color.Crimson;
            button47.ForeColor = Color.White;
            button47.FlatAppearance.BorderSize = 0;
            button47.Cursor = Cursors.Hand;
            button46.Text = "Daal";
            button46.Visible = false;
            button46.BackColor = Color.Crimson;
            button46.ForeColor = Color.White;
            button46.FlatAppearance.BorderSize = 0;
            button46.Cursor = Cursors.Hand;
            button45.Text = "Species";
            button45.Visible = false;
            button45.BackColor = Color.Crimson;
            button45.ForeColor = Color.White;
            button45.FlatAppearance.BorderSize = 0;
            button45.Cursor = Cursors.Hand;
            button44.Text = "Cosmatic";
            button44.Visible = false;
            button44.BackColor = Color.Crimson;
            button44.ForeColor = Color.White;
            button44.FlatAppearance.BorderSize = 0;
            button44.Cursor = Cursors.Hand;
            button69.BackColor = Color.Red;
            button69.Text = "Remove Items";
            button69.ForeColor = Color.White;
            button69.FlatAppearance.BorderSize = 0;
            button69.Cursor = Cursors.Hand;
            string s = "";
            textBox31.Text = Environment.NewLine + s.ToString();
            c1.sql.Open();
            SqlCommand cmd4 = new SqlCommand("select specname from species", c1.sql);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                comboBox6.Items.Add(dr4["specname"]);

            }
            c1.sql.Close();
            #endregion
            #region "Cosmatic"
            panel16.MouseEnter+=panel16_MouseEnter;
            panel16.BackColor = Color.LightCoral;
            panel16.Location = new Point(5, 150);
            panel16.Size = new Size(772, 513);
            comboBox7.GotFocus += focgo;
            comboBox7.LostFocus += foclo;
            label66.Text = "Choose Item";
            label66.ForeColor = Color.White;
            label65.Text = "Choose Quantity";
            label65.ForeColor = Color.White;
            label64.Text = "Items Details";
            label64.ForeColor = Color.White;
            label63.Text = "Enter Item Pack Quantity";
            label63.ForeColor = Color.White;
            label61.Location = new Point(panel16.Size.Width / 3 - label61.Size.Width / 3, 20);
            label61.Text = "Select Cosmatic Items";
            label61.ForeColor = Color.White;
            button57.FlatAppearance.BorderSize = 0;
            button57.Text = "Add To My Cart";
            button57.BackColor = Color.Red;
            button57.ForeColor = Color.White;
            button57.Cursor = Cursors.Hand;
            button56.Text = "Choose Next Items";
            button56.BackColor = Color.Red;
            button56.ForeColor = Color.White;
            button56.FlatAppearance.BorderSize = 0;
            button56.Cursor = Cursors.Hand;
            button56.Click+=button56_Click;
            button56.MouseEnter+=button56_MouseEnter;
            button55.Text = "Rice";
            button55.Visible = false;
            button55.BackColor = Color.Crimson;
            button55.ForeColor = Color.White;
            button55.FlatAppearance.BorderSize = 0;
            button55.Cursor = Cursors.Hand;
            button54.Text = "Atta";
            button54.Visible = false;
            button54.BackColor = Color.Crimson;
            button54.ForeColor = Color.White;
            button54.FlatAppearance.BorderSize = 0;
            button54.Cursor = Cursors.Hand;
            button53.Text = "Daal";
            button53.Visible = false;
            button53.BackColor = Color.Crimson;
            button53.ForeColor = Color.White;
            button53.FlatAppearance.BorderSize = 0;
            button53.Cursor = Cursors.Hand;
            button52.Text = "Species";
            button52.Visible = false;
            button52.BackColor = Color.Crimson;
            button52.ForeColor = Color.White;
            button52.FlatAppearance.BorderSize = 0;
            button52.Cursor = Cursors.Hand;
            button51.Text = "Cosmatic";
            button51.Visible = false;
            button51.BackColor = Color.Crimson;
            button51.ForeColor = Color.White;
            button51.FlatAppearance.BorderSize = 0;
            button51.Cursor = Cursors.Hand;
            button70.BackColor = Color.Red;
            button70.Text = "Remove Items";
            button70.ForeColor = Color.White;
            button70.FlatAppearance.BorderSize = 0;
            button70.Cursor = Cursors.Hand;
            string c = "";
            textBox35.Text = Environment.NewLine + c.ToString();
            c1.sql.Open();
            SqlCommand cmd5 = new SqlCommand("select cosmatname from cosmatic", c1.sql);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                comboBox7.Items.Add(dr5["cosmatname"]);

            }
            c1.sql.Close();
            #endregion
            #region Cart
            panel17.Paint+=panel17_Paint;
            panel17.Location = new Point(760 , 150);
            panel17.Size = new Size(260, 592);
            panel17.BackColor = Color.LightCoral;
            listView1.Size = new Size(247, 395);
            listView1.ForeColor = Color.Black;
            listView1.BackColor = Color.White;
            button58.Location = new Point(panel17.Size.Width / 30 - button58.Size.Width / 30, 533);
            button58.Size = new Size(250, 55);
            button58.Text = "Make My Order";
            button58.FlatAppearance.BorderSize = 2;
            button58.FlatAppearance.BorderColor = Color.White;
            button58.FlatStyle = FlatStyle.Flat;
            button58.BackColor = Color.Red;
            button58.ForeColor = Color.White;
            button58.Cursor = Cursors.Hand;
            textBox38.Visible = false;
            textBox38.Text = "Closed";
            textBox25.Visible = false;
            dateTimePicker1.Visible = false;
            int count = 0;
            c1.sql.Open();
            SqlCommand sq = new SqlCommand("select count(custid) from selling", c1.sql);
            SqlDataReader dq = sq.ExecuteReader();
            while (dq.Read())
            {
                count = Convert.ToInt32(dq[0]);
                count++;
            }
            custid = "Customer-" + count.ToString();
            c1.sql.Close();
            //c1.sql.Open();
            //SqlCommand sq1 = new SqlCommand("select count(custid) from sellingitems", c1.sql);
            //SqlDataReader dq1 = sq1.ExecuteReader();
            //while (dq1.Read())
            //{
            //    count = Convert.ToInt32(dq1[0]);
            //    count++;
            //}
            //custid = "Customer-" + count.ToString();
            //c1.sql.Close();
            #endregion
            //datetime or txtbox ko insert karna hai button sa
            #region Top panel
            panel18.Paint+=panel18_Paint;
            panel18.Location = new Point(0, 35);
            panel18.Size = new Size(1100, 115);
            panel18.BackColor = Color.Crimson;
            pictureBox13.Location = new Point(-10, 2);
            pictureBox13.Size = new Size(149, 106);
            label69.Location = new Point(panel18.Size.Width / 6 - label69.Size.Width / 6, 22);
            label69.Text = "The Online Utility Store";
            label69.ForeColor = Color.White;
            #endregion  
            #region Bottom Panel
            panel19.Paint+=panel19_Paint;
            panel19.MouseEnter+=panel19_MouseEnter;
            panel19.Location = new Point(5, 663);
            panel19.Size = new Size(755, 90);
            panel19.BackColor = Color.LightCoral;
            button59.BackColor = Color.Red;
            button59.ForeColor = Color.White;
            button59.Text = "Home";
            button59.FlatAppearance.BorderSize = 2;
            button59.FlatAppearance.BorderColor = Color.White;
            button59.Cursor = Cursors.Hand;
            button60.MouseEnter+=button60_MouseEnter;
            button60.BackColor = Color.Red;
            button60.ForeColor = Color.White;
            button60.Text = "About";
            button60.FlatAppearance.BorderSize = 2;
            button60.FlatAppearance.BorderColor = Color.White;
            button60.Cursor = Cursors.Hand;
            button61.BackColor = Color.Crimson;
            button61.ForeColor = Color.White;
            button61.Text = "Contect Us";
            button61.FlatAppearance.BorderSize = 1;
            button61.FlatAppearance.BorderColor = Color.White;
            button61.Cursor = Cursors.Hand;
            button61.Visible = false;
            button62.BackColor = Color.Crimson;
            button62.ForeColor = Color.White;
            button62.Text = "About AlBazar";
            button62.FlatAppearance.BorderSize = 1;
            button62.FlatAppearance.BorderColor = Color.White;
            button62.Cursor = Cursors.Hand;
            button62.Visible = false;
            button63.BackColor = Color.Crimson;
            button63.ForeColor = Color.White;
            button63.Text = "Made By";
            button63.FlatAppearance.BorderSize = 1;
            button63.FlatAppearance.BorderColor = Color.White;
            button63.Cursor = Cursors.Hand;
            button63.Visible = false;
            label72.Text = "/AlBazar.pk";
            label72.ForeColor = Color.White;
            #endregion
            #region approval
            panel20.Paint+=panel20_Paint;
            panel20.Location = new Point(10, 150);
            panel20.BackColor = Color.GhostWhite;
            panel20.Size = new Size(731, 538);
            button64.BackColor = Color.Gray;
            button64.ForeColor = Color.White;
            button64.Text = "Proceed";
            button64.FlatAppearance.BorderSize = 2;
            button64.FlatAppearance.BorderColor = Color.LightGray;
            button64.Cursor = Cursors.Hand;
            #endregion
            #region receipt
            panel21.Paint+=panel21_Paint;
            panel21.Location = new Point(this.Size.Width / 2 - panel21.Size.Width / 2, 180);
            panel21.Size = new Size(238, 504);
            panel21.BackColor = Color.White;
            label81.Text = "AlBazar Store";
            label81.ForeColor = Color.Black; 
            textBox45.ForeColor = Color.Black;
            textBox45.BackColor = Color.White;
            textBox45.Size = new Size(226, 423);
           #endregion
            #region enterning name
            panel22.Location = new Point(this.Size.Width / 3 - panel22.Size.Width / 3, 200);
            panel22.Size = new Size(411, 202);
            panel22.BackColor = Color.LightCoral;
            panel22.Paint+=panel22_Paint;
            label46.Text = "Customer Information";
            label46.ForeColor = Color.White;
            label36.Text = "Name";
            label36.ForeColor = Color.White;
            label40.Text = "Address";
            label40.ForeColor = Color.White;
            button65.Text = "Proceed";
            button65.BackColor = Color.Red;
            button65.ForeColor = Color.White;
            button65.Cursor = Cursors.Hand;
            #endregion    
        }
        #region "ControlBox Button "
        void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel18.Visible = true;
            panel1.Visible = false;
        }
        #region "Customer button Click Event"
        void button3_Click(object sender, EventArgs e)
        {
            string gen="";
            if (radioButton1.Checked == true)
            {
                gen = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                gen = radioButton2.Text;
            }
            c1.sql.Open();
            SqlCommand cmd2 = new SqlCommand("insert into customer (custid,name,address,ph,province,city,gender,email) values(@custid,@name,@address,@ph,@province,@city,@gender,@email)", c1.sql);
            cmd2.Parameters.AddWithValue("@custid", textBox10.Text);
            cmd2.Parameters.AddWithValue("@name", textBox4.Text);
            cmd2.Parameters.AddWithValue("@address", textBox5.Text);
            cmd2.Parameters.AddWithValue("@ph", textBox6.Text);
            cmd2.Parameters.AddWithValue("@province", comboBox1.Text);
            cmd2.Parameters.AddWithValue("@city", comboBox2.Text);
            cmd2.Parameters.AddWithValue("@email", textBox7.Text);
            cmd2.Parameters.AddWithValue("@gender", gen);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Insert");
            c1.sql.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1.sql.Open();
            SqlCommand cmd1 = new SqlCommand("select cityname from city where CONVERT(VARCHAR,provincename)='" + comboBox1.Text + "';", c1.sql);
            SqlDataReader dr = cmd1.ExecuteReader();
            comboBox2.Items.Clear();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["cityname"]);

            }
            comboBox2.Text = "";
            c1.sql.Close();
        }
        void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel18.Visible = false;           
            panel1.Visible = true;
        }
        void button4_Paint(object sender, EventArgs e)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(0, 0, 32, 32);
            button4.Region = new Region(p);
        }
        void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.White);
            p.Width = 2;
            p.DashStyle = DashStyle.Dot;
            g.DrawRectangle(p, 8, 14, 474, 480);
        }
        #endregion
        #region "Setting MouseHover Property For Button Home Page "
        private void button6_Click(object sender, EventArgs e)
        {
            if (button8.Visible == true && button9.Visible == true && button10.Visible == true && panel5.Visible == true)
            {
                button8.Visible = false; button9.Visible = false; button10.Visible = false; panel5.Visible = false;
            }
            else
            {
                button8.Visible = true; button9.Visible = true; button10.Visible = true; panel5.Visible = true;
            }
        }
        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Tomato;
            button7.BackColor = Color.Red;
            if (button8.Visible == false && button9.Visible == false && button10.Visible == false && panel5.Visible == false)
            {
                button8.Visible = true; button9.Visible = true; button10.Visible = true; panel5.Visible = true;
            }
            button11.Visible = false; button13.Visible = false; panel6.Visible = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (button11.Visible == true && button13.Visible == true && panel6.Visible == true)
            {
                button11.Visible = false; button13.Visible = false; panel6.Visible = false;
            }
            else
            {
                button11.Visible = true; button13.Visible = true; panel6.Visible = true;
            }
        }
        private void button7_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button7.BackColor = Color.Tomato;
            button6.BackColor = Color.Red;
            if (button11.Visible == false && button13.Visible == false && panel6.Visible == false)
            {
                button11.Visible = true; button13.Visible = true; panel6.Visible = true;
            }
            button8.Visible = false; button9.Visible = false; button10.Visible = false; panel5.Visible = false;
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Tomato;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            panel5.Visible = false;
            panel6.Visible = false;
        }
        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            panel5.Visible = false;
            button6.BackColor = Color.Red;
        }
        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            panel6.Visible = false;
            button6.BackColor = Color.Red;
        }
        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            panel5.Visible = false;
            panel6.Visible = false;
            button6.BackColor = Color.Red;
        }
        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            panel5.Visible = false;
            panel6.Visible = false;
            button6.BackColor = Color.Red;
        }
        void panel7_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel7.CreateGraphics();
            Pen p = new Pen(Color.White);
            p.Width = 1;
            p.DashStyle = DashStyle.Dash;
            g.DrawRectangle(p, 2, 14, 330, 85);
        }
        void button8_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel18.Visible = true;
            panel4.Visible = true;
            panel9.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel13.Visible = false;
            label26.Visible = false;
            pictureBox11.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            panel7.Visible = true;
            label25.Visible = true;
        }
        void button9_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel18.Visible = true;
            panel9.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel13.Visible = false;
            label26.Visible = false;
            pictureBox11.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            panel7.Visible = true;
            label25.Visible = true;
        }
        void button10_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
            panel18.Visible = true;
            panel8.Visible = false;
            panel9.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel13.Visible = false;
            label26.Visible = false;
            pictureBox11.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            panel7.Visible = true;
            label25.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            panel7.Visible = true;
            label25.Visible = true;
            panel13.Visible = false;
            label26.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox11.Visible == true)
            {
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox9.Visible = true;
            }
            else if (pictureBox9.Visible == true)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
                pictureBox11.Visible = false;
            }
            else if (pictureBox10.Visible == true)
            {
                pictureBox9.Visible = false;
                pictureBox11.Visible = true;
                pictureBox10.Visible = false;
            }
        }
        #endregion
        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
            panel2.Visible = false;
            panel13.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel18.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel13.Visible = false;
        }
        #region "Contect Us"
        void button16_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
            panel7.Visible = true;
            panel18.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
        }
        #endregion
        #region "About us"
        void button17_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
            panel7.Visible = true;
            panel10.Visible = false;
            panel18.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
        }
        void button17_Paint(object sender, EventArgs e)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(0, 0, 32, 32);
            button17.Region = new Region(p);
        }
        void panel10_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel10.CreateGraphics();
            Pen p = new Pen(Color.White);
            p.Width = 1;
            p.DashStyle = DashStyle.DashDotDot;
            g.DrawRectangle(p, 5, 4, 600, 245);
        }
        #endregion
        #region "Made By"
        void panel9_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel9.CreateGraphics();
            Pen p = new Pen(Color.White);
            p.Width = 1;
            p.DashStyle = DashStyle.Dash;
            g.DrawRectangle(p, 2, 2, 440, 355);
        }
        void button15_Paint(object sender, EventArgs e)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(0, 0, 32, 32);
            button15.Region = new Region(p);
        }
        void button15_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
            panel7.Visible = true;
            panel18.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
        }
        #endregion
        private void button11_Click(object sender, EventArgs e)
        {
            panel13.Visible = true;
            label26.Visible = true;
            panel2.Visible = false;
            pictureBox11.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            panel7.Visible = false;
            label25.Visible = false;
        }
        #region focus
        public void focgo(object sender, EventArgs e)
        {
            ComboBox cb2 = (ComboBox)sender;
            {
                if (cb2.Text == "Select Products") { cb2.Text = ""; cb2.ForeColor = Color.Gray; }
            }
        }
        public void foclo(object sender, EventArgs e)
        {
            ComboBox cb2 = (ComboBox)sender;
            {
                if (cb2.Text == "") { cb2.Text = "Select Products"; cb2.ForeColor = Color.Gray; }
            }
        }
        #endregion
        #region "Rice"
        private void button24_MouseEnter(object sender, EventArgs e)
        {
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (button25.Visible == true && button26.Visible == true && button27.Visible == true && button28.Visible == true && button29.Visible == true)
            {
                button25.Visible = false;
                button26.Visible = false;
                button27.Visible = false;
                button28.Visible = false;
                button29.Visible = false;
            }
            else
            {
                button25.Visible = true;
                button26.Visible = true;
                button27.Visible = true;
                button28.Visible = true;
                button29.Visible = true;
            }
        }
        private void panel11_MouseEnter(object sender, EventArgs e)
        {
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
        }
        private void button29_Click(object sender, EventArgs e)
        {
            panel16.Visible = true;
            panel15.Visible = false;
            panel14.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
        }
        private void button28_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = true;
            panel14.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
        }
        private void button27_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = true;
            panel12.Visible = false;
            panel11.Visible = false;
        }
        private void button26_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel12.Visible = true;
            panel11.Visible = false;
        }
        private void button25_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel12.Visible = false;
            panel11.Visible = true;
        }
        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            { MessageBox.Show("Enter Number Only"); e.Handled = true; 
            }
            if (textBox17.Text == "")
            { 
                textBox19.Enabled = false;
            }
            else
            { 
                textBox19.Enabled = true; 
            }

        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            { MessageBox.Show("Enter Number Only"); e.Handled = true; }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
                c1.sql.Open();
                SqlCommand cmd1 = new SqlCommand("select* from rice where CONVERT(VARCHAR,rname)='" + comboBox3.Text + "';", c1.sql);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    textBox18.Text = dr["rdetailed"].ToString() + Environment.NewLine + "Rs-" + dr["Price"].ToString();
                    price = Convert.ToInt32(dr["Price"]);
                    textBox25.Text = dr["rid"].ToString();
                }
                textBox17.Text = "";
                c1.sql.Close();
        }
        private void button23_Click(object sender, EventArgs e)
        {
                try
                {
                    int b = Convert.ToInt32(price);
                    int a = Convert.ToInt32(textBox17.Text);
                    z = Convert.ToInt32(a * b);
                    ListViewItem li = new ListViewItem(textBox20.Text);
                    li.SubItems.Add(comboBox3.Text);
                    li.SubItems.Add(textBox17.Text + "/Rs-" + z);
                    li.SubItems.Add(textBox18.Text);
                    listView1.Items.Add(li);
                    textBox29.Text += "Item Name:" + comboBox3.Text + "Price & Quantity:" + textBox17.Text + "Rs-" + z;           
                }
                catch (Exception)
                { MessageBox.Show("Because Of some circumstance this service is not availble"); }
                prds[counter] = textBox25.Text;
                nam[counter] = comboBox3.Text.ToString();
                qty[counter] = Convert.ToInt32(price);
                try
                {
                    itsq[counter] = Convert.ToInt32(textBox17.Text);
                }
                catch (FormatException) { MessageBox.Show("Not Avaiable"); }
                catch (Exception) { MessageBox.Show("Not Avaiable"); }
                tot[counter] = z;
                counter++;
        }
        private void button66_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.CheckedItems[0].Remove();
                listView1.SelectedItems[0].Remove();
            }
            catch (ArgumentException) { MessageBox.Show("Please Select the item To remove"); }
            catch (FormatException) { MessageBox.Show("Please Add Item To the Cart"); }
            catch (Exception) { MessageBox.Show("Please Select the item To remove"); }
        }
        #endregion
        #region "Atta"
        private void button35_MouseEnter(object sender, EventArgs e)
        {
            button30.Visible = true;
            button31.Visible = true;
            button32.Visible = true;
            button33.Visible = true;
            button34.Visible = true;
        }
        private void button35_Click(object sender, EventArgs e)
        {
            if (button30.Visible == true && button31.Visible == true && button32.Visible == true && button33.Visible == true && button34.Visible == true)
            {
                button30.Visible = false;
                button31.Visible = false;
                button32.Visible = false;
                button33.Visible = false;
                button34.Visible = false;
            }
            else
            {
                button30.Visible = true;
                button31.Visible = true;
                button32.Visible = true;
                button33.Visible = true;
                button34.Visible = true;
            }
        }
        private void panel12_MouseEnter(object sender, EventArgs e)
        {
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            button34.Visible = false;
        }
        private void button34_Click(object sender, EventArgs e)
        {
            panel16.Visible = true;
            panel11.Visible = false;
            panel12.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
        }
        private void button33_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel14.Visible = false;
            panel15.Visible = true;
        }
        private void button32_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel14.Visible = true;
            panel15.Visible = false;
        }
        private void button31_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel11.Visible = false;
            panel12.Visible = true;
            panel14.Visible = false;
            panel15.Visible = false;
        }
        private void button30_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel11.Visible = true;
            panel12.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
        }
        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            { MessageBox.Show("Enter Number Only"); e.Handled = true; }
            if (textBox24.Text == "")
            { textBox22.Enabled = false; }
            else { textBox22.Enabled = true; }
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            { MessageBox.Show("Enter Number Only"); e.Handled = true; }
        }
         private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
              c1.sql.Open();
            SqlCommand cmd1 = new SqlCommand("select* from atta where CONVERT(VARCHAR,atname)='" + comboBox4.Text + "';", c1.sql);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                textBox23.Text = dr["atdetailed"].ToString() + Environment.NewLine + "Rs-" + dr["Price"].ToString();
                price = Convert.ToInt32(dr["Price"]);
                textBox25.Text = dr["atid"].ToString();
            }
            textBox24.Text = "";
            c1.sql.Close();
        }
         private void button36_Click(object sender, EventArgs e)
         {
                 try
                 {
                     int b = Convert.ToInt32(price);
                     int a = Convert.ToInt32(textBox24.Text);
                     z = Convert.ToInt32(a * b);
                     ListViewItem li = new ListViewItem(textBox20.Text);
                     li.SubItems.Add(comboBox4.Text);
                     li.SubItems.Add(textBox24.Text + "/Rs-" + z);
                     li.SubItems.Add(textBox23.Text);
                     listView1.Items.Add(li);
                     textBox29.Text = "Customer Name:" + textBox20.Text + Environment.NewLine + "Item Name:" + comboBox4.Text + "Price & Quantity:" + textBox17.Text + "Rs-" + z;
                 }
                 catch (Exception)
                 { MessageBox.Show("Because Of some circumstance this service is not availble"); }
                 prds[counter] = textBox25.Text;
                 nam[counter] = comboBox4.Text.ToString();
                 qty[counter] = Convert.ToInt32(price);
                 try { itsq[counter] = Convert.ToInt32(textBox24.Text); }
                 catch (FormatException) { MessageBox.Show("Not Avaiable"); }
                 catch (Exception) { MessageBox.Show("Not Avaiable"); }
                 tot[counter] = z;
                 counter++;
         }
         private void button67_Click(object sender, EventArgs e)
         {
             try
             {
                 listView1.SelectedItems[0].Remove();
                 listView1.CheckedItems[0].Remove();
             }
             catch (ArgumentException) { MessageBox.Show("Please Select the item To remove"); }
             catch (FormatException) { MessageBox.Show("Please Add Item To the Cart"); }
             catch (Exception) { MessageBox.Show("Please Select the item To remove"); }
         }
        #endregion
        #region "Daal"
        private void button42_MouseEnter(object sender, EventArgs e)
        {
            button37.Visible = true;
            button38.Visible = true;
            button39.Visible = true;
            button40.Visible = true;
            button41.Visible = true;
        }
        private void button42_Click(object sender, EventArgs e)
        {
            if (button37.Visible == true && button38.Visible == true && button39.Visible == true && button40.Visible == true && button41.Visible == true)
            {
                button37.Visible = false;
                button38.Visible = false;
                button39.Visible = false;
                button40.Visible = false;
                button41.Visible = false;
            }
            else
            {
                button37.Visible = true;
                button38.Visible = true;
                button39.Visible = true;
                button40.Visible = true;
                button41.Visible = true;
            }
        }
        private void panel14_MouseEnter(object sender, EventArgs e)
        {
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
        }
        private void button41_Click(object sender, EventArgs e)
        {
            panel16.Visible = true;
            panel15.Visible = false;
            panel14.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
        }
        private void button40_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = true;
            panel14.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
        }
        private void button39_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = true;
            panel11.Visible = false;
            panel12.Visible = false;
        }
        private void button38_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel11.Visible = false;
            panel12.Visible = true;
        }
        private void button37_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel11.Visible = false;
            panel12.Visible = true;
        }
        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {MessageBox.Show("Enter Number Only"); e.Handled = true;}
            if (textBox28.Text == "")
            { textBox26.Enabled = false; }
            else { textBox26.Enabled = true; }
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            { MessageBox.Show("Enter Number Only"); e.Handled = true; }
        }
         private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1.sql.Open();
            SqlCommand cmd1 = new SqlCommand("select* from daal where CONVERT(VARCHAR,dalname)='" + comboBox5.Text + "';", c1.sql);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                textBox27.Text = dr["daldetailed"].ToString() + Environment.NewLine + "Rs-" + dr["Price"].ToString();
                price = Convert.ToInt32(dr["Price"]);
                textBox25.Text = dr["dalid"].ToString();
            }
            textBox28.Text = "";
            c1.sql.Close();
        }
         private void button43_Click(object sender, EventArgs e)
         {
                 try
                 {
                     int b = Convert.ToInt32(price);
                     int a = Convert.ToInt32(textBox28.Text);
                     z = Convert.ToInt32(a * b);
                     ListViewItem li = new ListViewItem(textBox20.Text);
                     li.SubItems.Add(comboBox5.Text);
                     li.SubItems.Add(textBox28.Text + "/Rs-" + z);
                     li.SubItems.Add(textBox27.Text);
                     listView1.Items.Add(li);
                     textBox29.Text = "Customer Name:" + textBox20.Text + Environment.NewLine + "Item Name:" + comboBox5.Text + "Price & Quantity:" + textBox17.Text + "Rs-" + z;
                 }
                 catch (Exception)
                 { MessageBox.Show("Because Of some circumstance this service is not availble"); }
                 prds[counter] = textBox25.Text;
                 nam[counter] = comboBox5.Text;
                 try { itsq[counter] = Convert.ToInt32(textBox28.Text); }
                 catch (FormatException) { MessageBox.Show("Not Avaiable"); }
                 catch (Exception) { MessageBox.Show("Not Avaiable"); }
                 tot[counter] = z;
                 counter++;
                 qty[counter] = Convert.ToInt32(price);
         }
         private void button68_Click(object sender, EventArgs e)
         {
             try
             {
                 listView1.SelectedItems[0].Remove();
                 listView1.CheckedItems[0].Remove();
             }
             catch (ArgumentException) { MessageBox.Show("Please Select the item To remove"); }
             catch (FormatException) { MessageBox.Show("Please Add Item To the Cart"); }
             catch (Exception) { MessageBox.Show("Please Select the item To remove"); }
         }
        #endregion
        #region "Species"
        private void button49_MouseEnter(object sender, EventArgs e)
        {
            button44.Visible = true;
            button45.Visible = true;
            button46.Visible = true;
            button47.Visible = true;
            button48.Visible = true;
        }
        private void button49_Click(object sender, EventArgs e)
        {
            if (button44.Visible == true && button45.Visible == true && button46.Visible == true && button47.Visible == true && button48.Visible == true)
            {
                button44.Visible = false;
                button45.Visible = false;
                button46.Visible = false;
                button47.Visible = false;
                button48.Visible = false;
            }
            else
            {
                button44.Visible = true;
                button45.Visible = true;
                button46.Visible = true;
                button47.Visible = true;
                button48.Visible = true;
            }
        }
        private void panel15_MouseEnter(object sender, EventArgs e)
        {
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
        }
        private void button44_Click(object sender, EventArgs e)
        {
            panel16.Visible = true;
            panel15.Visible = false;
            panel14.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
        }
        private void button45_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = true;
            panel14.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
        }
        private void button46_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = true;
            panel11.Visible = false;
            panel12.Visible = false;
        }
        private void button47_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel11.Visible = false;
            panel12.Visible = true;
        }
        private void button48_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel11.Visible = true;
            panel12.Visible = false;
        }
        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            { MessageBox.Show("Enter Number Only"); e.Handled = true; }
            if (textBox32.Text == "")
            { textBox30.Enabled = false; }
            else { textBox30.Enabled = true; }
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            { MessageBox.Show("Enter Number Only"); e.Handled = true; }
        }
         private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1.sql.Open();
            SqlCommand cmd1 = new SqlCommand("select* from species where CONVERT(VARCHAR,specname)='" + comboBox6.Text + "';", c1.sql);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                textBox31.Text = dr["specdetailed"].ToString() + Environment.NewLine + "Rs-" + dr["Price"].ToString();
                price = Convert.ToInt32(dr["Price"]);
                textBox25.Text = dr["specid"].ToString();
            }
            textBox32.Text = "";
            c1.sql.Close();
        }
         private void button50_Click(object sender, EventArgs e)
         {
                 try
                 {
                     int b = Convert.ToInt32(price);
                     int a = Convert.ToInt32(textBox32.Text);
                     z = Convert.ToInt32(a * b);
                     ListViewItem li = new ListViewItem(textBox20.Text);
                     li.SubItems.Add(comboBox6.Text);
                     li.SubItems.Add(textBox32.Text + "/Rs-" + z);
                     li.SubItems.Add(textBox32.Text);
                     listView1.Items.Add(li);
                     textBox29.Text = "Customer Name:" + textBox20.Text + Environment.NewLine + "Item Name:" + comboBox6.Text + "Price & Quantity:" + textBox17.Text + "Rs-" + z;
                 }
                 catch (Exception)
                 { MessageBox.Show("Because Of some circumstance this service is not availble"); }
                 prds[counter] = textBox25.Text;
                 qty[counter] = Convert.ToInt32(price);
                 nam[counter] = comboBox6.Text;
                 try { itsq[counter] = Convert.ToInt32(textBox32.Text); }
                 catch (FormatException) { MessageBox.Show("Not Avaiable"); }
                 catch (Exception) { MessageBox.Show("Not Avaiable"); }
                 tot[counter] = z;
                 counter++;
         }
         private void button69_Click(object sender, EventArgs e)
         {
             try
             {
                 listView1.SelectedItems[0].Remove();
                 listView1.CheckedItems[0].Remove();
             }
             catch (ArgumentException) { MessageBox.Show("Please Select the item To remove"); }
             catch (FormatException) { MessageBox.Show("Please Add Item To the Cart"); }
             catch (Exception) { MessageBox.Show("Please Select the item To remove"); }
         }
        #endregion
        #region Cosmatic
        private void button56_MouseEnter(object sender, EventArgs e)
        {
            button51.Visible = true;
            button52.Visible = true;
            button53.Visible = true;
            button54.Visible = true;
            button55.Visible = true;
        }
        private void button56_Click(object sender, EventArgs e)
        {
            if (button51.Visible == true && button52.Visible == true && button53.Visible == true && button54.Visible == true && button55.Visible == true)
            {
                button51.Visible = false;
                button52.Visible = false;
                button53.Visible = false;
                button54.Visible = false;
                button55.Visible = false;
            }
            else
            {
                button51.Visible = true;
                button52.Visible = true;
                button53.Visible = true;
                button54.Visible = true;
                button55.Visible = true;
            }
        }
        private void panel16_MouseEnter(object sender, EventArgs e)
        {
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
        }
        private void button51_Click(object sender, EventArgs e)
        {
            panel16.Visible = true;
            panel15.Visible = false;
            panel14.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
        }
        private void button52_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = true;
            panel14.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
        }
        private void button53_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = true;
            panel11.Visible = false;
            panel12.Visible = false;
        }
        private void button54_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel11.Visible = false;
            panel12.Visible = true;
        }
        private void button55_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel11.Visible = true;
            panel12.Visible = false;
        }
        private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            { MessageBox.Show("Enter Number Only"); e.Handled = true; }
            if (textBox26.Text == "")
            { textBox34.Enabled = false; }
            else { textBox34.Enabled = true; }
        }

        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            { MessageBox.Show("Enter Number Only"); e.Handled = true; }
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1.sql.Open();
            SqlCommand cmd1 = new SqlCommand("select* from cosmatic where CONVERT(VARCHAR,cosmatname)='" + comboBox7.Text + "';", c1.sql);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                textBox35.Text = dr["cosmatdetailed"].ToString() + Environment.NewLine + "Rs-" + dr["cosmatprice"].ToString();
                price = Convert.ToInt32(dr["cosmatprice"]);
                textBox25.Text = dr["cosmatid"].ToString();
            }
            textBox36.Text = "";
            c1.sql.Close();
        }
          private void button57_Click(object sender, EventArgs e)
        {
                try{ int b = Convert.ToInt32(price);
                int a = Convert.ToInt32(textBox36.Text);
                z = Convert.ToInt32(a * b);
                ListViewItem li = new ListViewItem(textBox20.Text);
                li.SubItems.Add(comboBox7.Text);
                li.SubItems.Add(textBox36.Text + "/Rs-" + z);
                li.SubItems.Add(textBox35.Text);
                listView1.Items.Add(li);
                textBox29.Text = "Customer Name:" + textBox20.Text + Environment.NewLine + "Item Name:" + comboBox7.Text + "Price & Quantity:" + textBox17.Text + "Rs-" + z;
                }
                catch (Exception)
                { MessageBox.Show("Because Of some circumstance this service is not availble"); }
                prds[counter] = textBox25.Text;
                nam[counter] = comboBox7.Text;
                try { itsq[counter] = Convert.ToInt32(textBox36.Text); }
                catch (FormatException) { MessageBox.Show("Not Avaiable"); }
                catch (Exception) { MessageBox.Show("Not Avaiable"); }
                tot[counter] = z;
                counter++;
                qty[counter] = Convert.ToInt32(price);
        }
          private void button70_Click(object sender, EventArgs e)
          {
              try
              {
                  listView1.SelectedItems[0].Remove();
                  listView1.CheckedItems[0].Remove();
              }
              catch (ArgumentException) { MessageBox.Show("Please Select the item To remove"); }
              catch (FormatException) { MessageBox.Show("Please Add Item To the Cart"); }
              catch (Exception) { MessageBox.Show("Please Select the item To remove"); }
          }
        #endregion
        #region Buttons Items Home
        private void button18_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
            panel22.Visible = true;
            panel11.Enabled = false;
            panel12.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel13.Visible = false;
            panel19.Visible = true;
            panel18.Visible = true;
            panel17.Visible = true;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel22.Visible = true;
            panel12.Visible = true;
            panel12.Enabled = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel13.Visible = false;
            panel19.Visible = true;
            panel18.Visible = true;
            panel17.Visible = true;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel22.Visible = true;
            panel15.Enabled = false;
            panel12.Visible = false;
            panel14.Visible = false;
            panel15.Visible = true;
            panel16.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel13.Visible = false;
            panel19.Visible = true;
            panel18.Visible = true;
            panel17.Visible = true;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel14.Enabled = false;
            panel22.Visible = true;
            panel12.Visible = false;
            panel14.Visible = true;
            panel15.Visible = false;
            panel16.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel13.Visible = false;
            panel19.Visible = true;
            panel18.Visible = true;
            panel17.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel16.Enabled = false;
            panel22.Visible = true;
            panel12.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel13.Visible = false;
            panel19.Visible = true;
            panel18.Visible = true;
            panel17.Visible = true;
        }
        #endregion
        #region toppanel
        void panel18_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel18.CreateGraphics();
            Pen p = new Pen(Color.White);
            p.Width = 1;
            p.DashStyle = DashStyle.DashDotDot;
            g.DrawRectangle(p, 1, 1, 1100, 110);
        }
        #endregion
        #region Cart
        void panel17_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel17.CreateGraphics();
            Pen p = new Pen(Color.White);
            p.Width = 1;
            p.DashStyle = DashStyle.DashDotDot;
            g.DrawRectangle(p, 2, 1, 254,587);
        }
        private void button58_Click(object sender, EventArgs e)
        {
            if (listView1.Text == "")
            {
                panel21.Visible = true;
                panel11.Visible = false;
                panel12.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
            }
            else { MessageBox.Show("You didn't Select any Product"); }
            c1.sql.Open();
            SqlCommand cmd2 = new SqlCommand("insert into selling(custid,customername,purchasingdate,purstatus) values(@custid,@customername,@purchasingdate,@purstatus)", c1.sql);
            cmd2.Parameters.AddWithValue("@custid", custid);
            cmd2.Parameters.AddWithValue("@customername", textBox20.Text);
            cmd2.Parameters.AddWithValue("@purchasingdate", DateTime.Today.Date);
            cmd2.Parameters.AddWithValue("@purstatus", textBox38.Text);
            cmd2.ExecuteNonQuery();
            c1.sql.Close();
            c1.sql.Open();
            for (int i = 0; i < counter; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into sellingitems(custid,itemsname,itemsid) values(@custid,@itemsname,@itemsid)", c1.sql);
                cmd.Parameters.AddWithValue("@custid", custid);
                cmd.Parameters.AddWithValue("@itemsname", nam[i]);
                cmd.Parameters.AddWithValue("@itemsid", prds[i]);
                cmd.ExecuteNonQuery();
            }
            c1.sql.Close();
            //c1.sql.Open();
            //for (int i = 0; i < counter; i++)
            //{
            //    string itqp = "Not avaiable";
            //    SqlCommand cmd = new SqlCommand("insert into itemsqty(itemsid,itemsqtysingle,itemsqtypack) values(@itemsid,@itemsqtysingle,@itemsqtypack)", c1.sql);
            //    cmd.Parameters.AddWithValue("@itemsid", prds[i]);
            //    cmd.Parameters.AddWithValue("@itemsqtysingle", itsq[i]);
            //    //cmd.Parameters.AddWithValue("@itemsqtysingle", textBox24.Text);
            //    //cmd.Parameters.AddWithValue("@itemsqtysingle", textBox28.Text);
            //    //cmd.Parameters.AddWithValue("@itemsqtysingle", textBox32.Text);
            //    //cmd.Parameters.AddWithValue("@itemsqtysingle", textBox36.Text);
            //    cmd.Parameters.AddWithValue("@itemsqtypack", itqp);
            //    cmd.ExecuteNonQuery();
            //}
            //c1.sql.Close();
            panel21.Visible = true;
            textBox45.Text = "              Cash Memo" + Environment.NewLine + "*-  *-  *-  *-  *-  *-  *-  *-  *-  *-  *-" + Environment.NewLine
                + "Pruchase I.D:" + custid + Environment.NewLine + "Date:" + DateTime.Now.Date + "   Time:" + DateTime.Now.TimeOfDay + Environment.NewLine
             +"*-  *-  *-  *-  *-  *-  *-  *-  *-  *-" +"Customer Name:"+textBox20.Text+textBox29.Text;
            //textBox45.Text=(z++).ToString();
            //for (int i = 0; i < counter; i++)
            //{
            //    int s= Convert.ToInt32(tot[i]);
            //    textBox45.Text = s.ToString();
            //}
            MessageBox.Show("Your Order Complete.");
        }
        #endregion
        #region Bottom Panel
        void panel19_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel19.CreateGraphics();
            Pen p = new Pen(Color.White);
            p.Width = 1;
            p.DashStyle = DashStyle.DashDot;
            g.DrawRectangle(p, 2, 2, 749, 84);
        }
        private void button59_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
            panel7.Visible = true;
            pictureBox11.Visible = true;
            pictureBox10.Visible = true;
            pictureBox9.Visible = true;
            label26.Visible = false;
            label25.Visible = true;
            panel19.Visible = false;
            panel22.Visible = false;
            panel18.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
        }
        private void button60_MouseEnter(object sender, EventArgs e)
        {
            button61.Visible = true;
            button62.Visible = true;
            button63.Visible = true;
        }
        private void panel19_MouseEnter(object sender, EventArgs e)
        {
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
        }
        private void button61_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel22.Visible = false;
            panel18.Visible = true;
            panel19.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
        }
        private void button62_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
            panel22.Visible = false;
            panel18.Visible = true;
            panel19.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
        }
        private void button63_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel22.Visible = false;
            panel18.Visible = true;
            panel19.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
        }
        #endregion
        #region approval
        void panel20_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel20.CreateGraphics();
            Pen p = new Pen(Color.White);
            p.Width = 2;
            p.DashStyle = DashStyle.Dash;
            g.DrawRectangle(p, 2, 2, 725, 533);
        }
        #endregion
        #region receipt
        void panel21_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel21.CreateGraphics();
            Pen p = new Pen(Color.Gray);
            p.Width = 2;
            p.DashStyle = DashStyle.Dot;
            g.DrawRectangle(p, 2, 2, 234, 500);
        }
        #endregion
        #region enterning name
        private void button65_Click(object sender, EventArgs e)
        {
            if (textBox20.Text != "" && textBox21.Text != "")
            {
                panel22.Visible = false;
                panel11.Enabled = true;
                panel12.Enabled = true;
                panel14.Enabled = true;
                panel15.Enabled = true;
                panel16.Enabled = true;
                panel17.Enabled = true;
            }
            else { MessageBox.Show("You Can not Enter With out Enterning Your Name Or Address"); }
        }
        void panel22_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel22.CreateGraphics();
            Pen p = new Pen(Color.White);
            p.Width = 2;
            p.DashStyle = DashStyle.Dash;
            g.DrawRectangle(p, 4, 4, 404, 195);
        }
        #endregion
        }
    }