namespace calcolatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "0";
        }

        private void buttonUno_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "1";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "1";
            }

        }

        private void buttonDue_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "2";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "2";
            }
        }

        private void buttonTre_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "3";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "3";
            }
        }

        private void buttonQuattro_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "4";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "4";
            }
        }

        private void buttonCinque_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "5";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "5";
            }
        }

        private void buttonSei_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "6";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "6";
            }
        }

        private void buttonSette_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "7";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "7";
            }
        }

        private void buttonOtto_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "8";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "8";
            }
        }

        private void buttonNove_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "9";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "9";
            }
        }
    }
}