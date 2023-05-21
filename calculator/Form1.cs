namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal; // varibel för att lara calculation total 
        int number1; // Variabel för att lagra första numret 
        int number2;// Variabel för att lagra andra numret 
        string option;// Variabel för att lagra vald operation
        int result;// Variabel för att lagra resultat av calculation


        // Händelsehanterare för att klicka på nummerknappen
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



        // Händelsehanterare för att klicka på tilläggsknappen
        private void btnAdd_Click(object sender, EventArgs e)
        {
            option = "+";
                number1 = int.Parse(txtBox.Text);

            txtBox.Clear();
        }

        // Händelsehanterare för att klicka på subtraktionsknappen
        private void btnSub_Click(object sender, EventArgs e)
        {
            option = "-";
            number1 = int.Parse(txtBox.Text);

            txtBox.Clear();
        }

        // Händelsehanterare för att klicka på multiplikationsknappen
        private void btnMult_Click(object sender, EventArgs e)
        {
            option = "*";
            number1 = int.Parse(txtBox.Text);

            txtBox.Clear();
        }

        // Händelsehanterare för att klicka på divisionsknappen
        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            number1 = int.Parse(txtBox.Text);

            txtBox.Clear();
        }

        // Händelsehanterare för att klicka på lika-knappen
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




        // Händelsehanterare för att klicka på återställningsknappen
        private void btnC_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
            result = (0);
            number1 = (0);
            number2 = (0);
        }

        // Händelsehanterare för att klicka på procentknappen
        private void btnProcent_Click(object sender, EventArgs e)
{
    if (txtBox.Text != "")
    {
        double value = double.Parse(txtBox.Text);
        double percentage = value / 100;

        txtBox.Text = percentage.ToString();
    }
}
        // Händelsehanterare för att klicka på potensknappen
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
        // Händelsehanterare för att klicka på kvadratrotsknappen
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                double value = double.Parse(txtBox.Text);
                double squareRoot = Math.Sqrt(value);

                txtBox.Text = squareRoot.ToString();
            }
        }

        // Händelsehanterare för att klicka på ta bort-knappen
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
            }
        }

    }
}