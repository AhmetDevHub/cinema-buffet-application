namespace Sinema_Büfe_Satış_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(Txtm.Text);
            bilet = Convert.ToInt16(Txtb.Text);
            su = Convert.ToInt16(Txts.Text);
            cay = Convert.ToInt16(Txtç.Text);

            toplam = misir * 50 + cay * 15 + su * 10 + bilet * 200;
            Lblt.Text = toplam.ToString() + "TL";

            kasatutar = kasatutar + toplam;
            Lblk.Text = kasatutar.ToString() + "TL";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Txtb.Text = "";
            Txtm.Text = "";
            Txts.Text = "";
            Txtç.Text = "";
            Txtm.Focus();
        }
    }
}
