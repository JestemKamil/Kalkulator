namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dzialanie = "nic";
        private void wyswietlacz_TextChanged(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (wyswietlacz.Text == "0")
            {
                wyswietlacz.Text = "";
            }
            wyswietlacz.Text = wyswietlacz.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wyswietlacz.Text == "0")
            {
                wyswietlacz.Text = "";
            }
            wyswietlacz.Text = wyswietlacz.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (wyswietlacz.Text == "0")
            {
                wyswietlacz.Text = "";
            }
            wyswietlacz.Text = wyswietlacz.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (wyswietlacz.Text == "0")
            {
                wyswietlacz.Text = "";
            }
            wyswietlacz.Text = wyswietlacz.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (wyswietlacz.Text == "0")
            {
                wyswietlacz.Text = "";
            }
            wyswietlacz.Text = wyswietlacz.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (wyswietlacz.Text == "0")
            {
                wyswietlacz.Text = "";
            }
            wyswietlacz.Text = wyswietlacz.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (wyswietlacz.Text == "0")
            {
                wyswietlacz.Text = "";
            }
            wyswietlacz.Text = wyswietlacz.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (wyswietlacz.Text == "0")
            {
                wyswietlacz.Text = "";
            }
            wyswietlacz.Text = wyswietlacz.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (wyswietlacz.Text == "0")
            {
                wyswietlacz.Text = "";
            }
            wyswietlacz.Text = wyswietlacz.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (wyswietlacz.Text == "0")
            {
                wyswietlacz.Text = "";
            }
            wyswietlacz.Text = wyswietlacz.Text + "9";
        }

        
        int liczba1 = 0;
        int liczba2 = 0;
        
        private void buttonrown_Click(object sender, EventArgs e)
        {
            int wynik = 0;
            liczba2 = Convert.ToInt16(wyswietlacz.Text);
            if (dzialanie == "dodawanie")
            {
                wynik = liczba1 + liczba2;
            }
            else if (dzialanie == "odejmowanie")
            {
                wynik = liczba1 - liczba2;
            }
            else if (dzialanie == "mnozenie")
            {
                wynik = liczba1 * liczba2;
            }
            else if (dzialanie == "dzielenie")
            {
                wynik = liczba1 / liczba2;
            }
            wyswietlacz.Text = Convert.ToString(wynik);
        }
        private void plus_Click(object sender, EventArgs e)
        {
            liczba1 = Convert.ToInt16(wyswietlacz.Text);
            wyswietlacz.Text = "0";
            dzialanie = "dodawanie";
        }
        private void minus_Click(object sender, EventArgs e)
        {
            liczba1 = Convert.ToInt16(wyswietlacz.Text);
            wyswietlacz.Text = "0";
            dzialanie = "odejmowanie";
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            liczba1 = Convert.ToInt16(wyswietlacz.Text);
            wyswietlacz.Text = "0";
            dzialanie = "mnozenie";
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            liczba1 = Convert.ToInt16(wyswietlacz.Text);
            wyswietlacz.Text = "0";
            dzialanie = "dzielenie";
        }

        private void C_Click(object sender, EventArgs e)
        {
            dzialanie = "nic";
            wyswietlacz.Text = "0";
        }
    }
}