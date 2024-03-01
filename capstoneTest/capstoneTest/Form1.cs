namespace capstoneTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Fruits & Vegetables")
            {
                comboBox2.Enabled = true;
            }
            else if (comboBox1.SelectedItem == "Creative Crafts")
            {

            }
        }

        //with letter
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //without letter
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
