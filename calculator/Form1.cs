namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal; // varibel f�r att lara calculation total 
        int number1; // Variabel f�r att lagra f�rsta numret 
        int number2;// Variabel f�r att lagra andra numret 
        string option;// Variabel f�r att lagra vald operation
        int result;// Variabel f�r att lagra resultat av calculation


        // H�ndelsehanterare f�r att klicka p� nummerknappen
        private void num1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + num1.Text;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + num2.Text;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + num3.Text;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + num4.Text;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + num5.Text;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + num6.Text;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + num7.Text;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + num8.Text;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + num9.Text;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + num0.Text;
        }



        // H�ndelsehanterare f�r att klicka p� till�ggsknappen
        private void btnAdd_Click(object sender, EventArgs e)
        {
            option = "+";
                number1 = int.Parse(txtBox.Text);

            txtBox.Clear();
        }

        // H�ndelsehanterare f�r att klicka p� subtraktionsknappen
        private void btnSub_Click(object sender, EventArgs e)
        {
            option = "-";
            number1 = int.Parse(txtBox.Text);

            txtBox.Clear();
        }

        // H�ndelsehanterare f�r att klicka p� multiplikationsknappen
        private void btnMult_Click(object sender, EventArgs e)
        {
            option = "*";
            number1 = int.Parse(txtBox.Text);

            txtBox.Clear();
        }

        // H�ndelsehanterare f�r att klicka p� divisionsknappen
        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            number1 = int.Parse(txtBox.Text);

            txtBox.Clear();
        }

        // H�ndelsehanterare f�r att klicka p� lika-knappen
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox.Text))
                return;

            number2 = int.Parse(txtBox.Text);

            if (option == null)
                return; 

            if (option.Equals("+"))
                result = number1 + number2;
            else if (option.Equals("-"))
                result = number1 - number2;
            else if (option.Equals("*"))
                result = number1 * number2;
            else if (option.Equals("/"))
                result = number1 / number2;

            txtBox.Text = result.ToString();

            // Reset variabler
            number1 = 0;
            number2 = 0;
            option = null;
        }




        // H�ndelsehanterare f�r att klicka p� �terst�llningsknappen
        private void btnC_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
            result = (0);
            number1 = (0);
            number2 = (0);
        }

        // H�ndelsehanterare f�r att klicka p� procentknappen
        private void btnProcent_Click(object sender, EventArgs e)
{
    if (txtBox.Text != "")
    {
        double value = double.Parse(txtBox.Text);
        double percentage = value / 100;

        txtBox.Text = percentage.ToString();
    }
}
        // H�ndelsehanterare f�r att klicka p� potensknappen
        private void btnPotens_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                double baseNumber = double.Parse(txtBox.Text);
                double exponent = 2; // Set the exponent value to 2 by default

                double result = Math.Pow(baseNumber, exponent);

                txtBox.Text = result.ToString();
            }
        }
        // H�ndelsehanterare f�r att klicka p� kvadratrotsknappen
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                double value = double.Parse(txtBox.Text);
                double squareRoot = Math.Sqrt(value);

                txtBox.Text = squareRoot.ToString();
            }
        }

        // H�ndelsehanterare f�r att klicka p� ta bort-knappen
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
            }
        }

    }
}