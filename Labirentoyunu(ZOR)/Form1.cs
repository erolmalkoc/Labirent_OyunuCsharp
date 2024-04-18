namespace Labirentoyunu_ZOR_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int süre = 15;
        DialogResult deger;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTNÝZ ","KENARA DEYDÝNÝZ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Kazandýnýz"," Tebrikler",MessageBoxButtons.OK,MessageBoxIcon.Information);
            timer1.Stop();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (süre==0)
            {
                timer1.Enabled= false;

               deger= MessageBox.Show("Süre bitti","Tekrar oynamak ister misinz ? ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (deger==DialogResult.Yes)
                {
                    süre = 15;
                    süre --;
                    timer1.Enabled = true;
                    
                }
                else if (deger==DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                süre--;
                label2.Text = Convert.ToString(süre);
                timer1.Enabled = true;
            }
        }
    }
}