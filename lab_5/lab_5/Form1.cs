using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
  
    public partial class Form1 : Form
    {
        Vehicle[] vehicle = new Vehicle[6];
        SortedListCollection st = new SortedListCollection();
        SortedGenericCol sgen = new SortedGenericCol();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void btn_ok_l_Click(object sender, EventArgs e)
        {
            string s = "";
            Boolean menu1 = true;
            Boolean menu2 = false;
            Boolean menu3 = false;
            if (radiobtn_srtl.Checked && !radiobtn_srtl_2.Checked)
            {
                
                st.addVehicles(menu1, menu2, menu3,
                    int.Parse(txt_price_l.Text), int.Parse(txt_speed_l.Text),
                    int.Parse(txt_grad_year_l.Text), int.Parse(txt_height_l.Text), 
                    s, int.Parse(txt_count_l.Text));
            }
            else if(!radiobtn_srtl.Checked && !radiobtn_srtl_2.Checked)
            {
                Plain p = new Plain(int.Parse(txt_price_l.Text), int.Parse(txt_speed_l.Text), int.Parse(txt_grad_year_l.Text), int.Parse(txt_height_l.Text), int.Parse(txt_count_l.Text));
                p.Change_price(int.Parse(txt_price_l.Text));
                p.Change_speed(int.Parse(txt_speed_l.Text));
                p.Change_grad_year(int.Parse(txt_grad_year_l.Text));
                richTextBox1.Text += p.show();
            } else if(!radiobtn_srtl.Checked && radiobtn_srtl_2.Checked)
            {
                sgen.addVehicles(menu1, menu2, menu3,
                    int.Parse(txt_price_l.Text), int.Parse(txt_speed_l.Text),
                    int.Parse(txt_grad_year_l.Text), int.Parse(txt_height_l.Text),
                    s, int.Parse(txt_count_l.Text));
            }
           
        }

        private void btn_ok_k_Click(object sender, EventArgs e)
        {
            Boolean menu1 = false;
            Boolean menu2 = true;
            Boolean menu3 = false;
            if (radiobtn_srtl.Checked && !radiobtn_srtl_2.Checked)
            {
                st.addVehicles(menu1, menu2, menu3, int.Parse(txt_price_k.Text), int.Parse(txt_speed_k.Text),
                    int.Parse(txt_grad_year_k.Text), int.Parse(txt_count_k.Text), txt_port.Text, 0);
            }
            else if (!radiobtn_srtl.Checked && !radiobtn_srtl_2.Checked)
            { 
            Ship s = new Ship(int.Parse(txt_price_k.Text), int.Parse(txt_speed_k.Text), int.Parse(txt_grad_year_k.Text), txt_port.Text, int.Parse(txt_count_k.Text));
            s.Change_price(int.Parse(txt_price_k.Text));
            s.Change_speed(int.Parse(txt_speed_k.Text));
            s.Change_grad_year(int.Parse(txt_grad_year_k.Text));
            richTextBox1.Text += s.show();
            }
            else if (!radiobtn_srtl.Checked && radiobtn_srtl_2.Checked)
            {
                sgen.addVehicles(menu1, menu2, menu3, int.Parse(txt_price_k.Text), int.Parse(txt_speed_k.Text),
                    int.Parse(txt_grad_year_k.Text), int.Parse(txt_count_k.Text), txt_port.Text, 0);
            }
        }

        private void btn_ok_m_Click(object sender, EventArgs e)
        {
            Boolean menu1 = false;
            Boolean menu2 = false;
            Boolean menu3 = true;
            if (radiobtn_srtl.Checked && !radiobtn_srtl_2.Checked)
            {
                st.addVehicles(menu1, menu2, menu3, 
                    int.Parse(txt_price_m.Text), 
                    int.Parse(txt_speed_m.Text), 
                    int.Parse(txt_grad_year_m.Text), 
                    0, "", 0);
            }
            else if (!radiobtn_srtl.Checked && !radiobtn_srtl_2.Checked)
            {
                Car c = new Car(int.Parse(txt_price_m.Text), int.Parse(txt_speed_m.Text), int.Parse(txt_grad_year_m.Text));
                c.Change_price(int.Parse(txt_price_m.Text));
                c.Change_speed(int.Parse(txt_speed_m.Text));
                c.Change_grad_year(int.Parse(txt_grad_year_m.Text));
                richTextBox1.Text += c.show();
            }
            else if (!radiobtn_srtl.Checked && radiobtn_srtl_2.Checked)
            {
                sgen.addVehicles(menu1, menu2, menu3,
                    int.Parse(txt_price_m.Text),
                    int.Parse(txt_speed_m.Text),
                    int.Parse(txt_grad_year_m.Text),
                    0, "", 0);
            }

        }

        private void btn_mas_ob_Click(object sender, EventArgs e)
        {
            Car c = new Car(int.Parse(txt_price_m.Text), int.Parse(txt_speed_m.Text), int.Parse(txt_grad_year_m.Text));
            vehicle[0] = new Car(int.Parse(txt_price_m.Text), int.Parse(txt_speed_m.Text), int.Parse(txt_grad_year_m.Text));
            vehicle[1] = new Ship(int.Parse(txt_price_k.Text), int.Parse(txt_speed_k.Text), int.Parse(txt_grad_year_k.Text), txt_port.Text, int.Parse(txt_count_k.Text));
            vehicle[2] = new Plain(int.Parse(txt_price_l.Text), int.Parse(txt_speed_l.Text), int.Parse(txt_grad_year_l.Text), int.Parse(txt_height_l.Text), int.Parse(txt_count_l.Text));

            for (int i = 0; i < 3; i++)
            {
                vehicle[i + 3] = (Vehicle)vehicle[i].Clone();
            }
            richtxt_array.Text += c.Non_sorted();
            foreach (Vehicle transport in vehicle)
            {
                richtxt_array.Text += transport.Print();
            }
            //Сортування 
            Array.Sort(vehicle);

            richtxt_array.Text += c.Sorted();
            foreach (Vehicle transport in vehicle)
            {
                richtxt_array.Text += transport.Print();
            }
        }

        private void btn_col_ok_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            if (radiobtn_srtl.Checked)
            {               
                richTextBox2.Text = st.getVehicles();
            }
            if (radiobtn_srtl_2.Checked)
            {
                richTextBox2.Text=sgen.getVehicles();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_number.Text);
                MessageBox.Show(st.getById(id));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean menu1 = true;
            Boolean menu2 = false;
            Boolean menu3 = false;
            int id = Int32.Parse(txt_number.Text);
            if (!radiobtn_srtl.Checked && radiobtn_srtl_2.Checked)
            {
                MessageBox.Show(sgen.getById(menu1,menu2,menu3,id));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean menu1 = false;
            Boolean menu2 = true;
            Boolean menu3 = false;
            int id = Int32.Parse(txt_number.Text);
            if (!radiobtn_srtl.Checked && radiobtn_srtl_2.Checked)
            {
                MessageBox.Show(sgen.getById(menu1, menu2, menu3, id));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Boolean menu1 = false;
            Boolean menu2 = false;
            Boolean menu3 = true;
            int id = Int32.Parse(txt_number.Text);
            if (!radiobtn_srtl.Checked && radiobtn_srtl_2.Checked)
            {
                MessageBox.Show(sgen.getById(menu1, menu2, menu3, id));
            }
        }
    }
}
