using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void customizeDesing()
        {
            subOS.Visible = false;
            subVeiculos.Visible = false;
            subFUNC.Visible = false;
            subMatEquip.Visible = false;
            subServ.Visible = false;
            panelGerarOS.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelGerarOS.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (subOS.Visible == false)
            {
                subOS.Visible = true;
            }
            else
            {
                subOS.Visible = false;
            }
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (subVeiculos.Visible == false)
            {
                subVeiculos.Visible = true;
            }
            else
            {
                subVeiculos.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void subVeiculos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (subFUNC.Visible == false)
            {
                subFUNC.Visible = true;
            }
            else
            {
               subFUNC.Visible = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (subMatEquip.Visible == false)
            {
                subMatEquip.Visible = true;
            }
            else
            {
                subMatEquip.Visible = false;
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void button21_Click(object sender, EventArgs e)
        {
            if (subServ.Visible == false)
            {
                subServ.Visible = true;
            }
            else
            {
                subServ.Visible = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panelGerarOS.Visible = false;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelGerarOS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
           
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDemandante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
