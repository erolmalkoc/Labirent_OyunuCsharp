namespace Labirentoyunu_ZOR_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s�re = 15;
        DialogResult deger;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTN�Z ","KENARA DEYD�N�Z",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Kazand�n�z"," Tebrikler",MessageBoxButtons.OK,MessageBoxIcon.Information);
            timer1.Stop();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s�re==0)
            {
                timer1.Enabled= false;

               deger= MessageBox.Show("S�re bitti","Tekrar oynamak ister misinz ? ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (deger==DialogResult.Yes)
                {
                    s�re = 15;
                    s�re --;
                    timer1.Enabled = true;
                    
                }
                else if (deger==DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                s�re--;
                label2.Text = Convert.ToString(s�re);
                timer1.Enabled = true;
            }
        }
    }
}