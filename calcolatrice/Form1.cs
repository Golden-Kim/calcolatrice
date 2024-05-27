using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

namespace calcolatrice
{
    public partial class Form1 : Form
    {
        //https://www.c-sharpcorner.com/article/create-basic-calculator-using-windows-forms-and-c-sharp/
        //https://learn.microsoft.com/it-it/dotnet/api/system.windows.forms.messagebox?view=windowsdesktop-8.0
        decimal primaCifra = 0;
        decimal secondaCifra = 0;
        string operazione = "";
        decimal RisultatoFinale = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private decimal Calcolo(decimal numero1, decimal numero2, string TipoOperazione) 
        {
            decimal risultato = 0;
            if (TipoOperazione == "+")
            {

                risultato = numero1 + numero2;



            }
            else if (TipoOperazione == "-")
            {

                risultato = numero1 - numero2;



            }
            else if (TipoOperazione == "*")
            {

                risultato = numero1 * numero2;



            }
            else if (TipoOperazione == "/")
            {
                if (numero1 == 0)
                {
                    string Errore = "Impossibile dividere per 0";
                    string NomeErrore = "Errore di input";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(Errore, NomeErrore, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {

                    risultato = numero1 / numero2;




                }



            }
            else if (TipoOperazione == "%")
            {

                risultato = numero1 / 100;
            }



            return risultato;
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
        private void buttonVirgola_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + ",";
        }
        private void buttonResetTotale_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1);
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
        }
        
        private void buttonAddizzione_Click(object sender, EventArgs e)
        {
            primaCifra = Convert.ToDecimal(textBoxDisplay.Text);
            textBoxDisplay.Text = "0";
            operazione = "+";
        }

        private void buttonSottrazzione_Click(object sender, EventArgs e)
        {
            primaCifra = Convert.ToDecimal(textBoxDisplay.Text);
            textBoxDisplay.Text = "0";
            operazione = "-";
        }

        private void buttonMoltiplicazione_Click(object sender, EventArgs e)
        {
            primaCifra = Convert.ToDecimal(textBoxDisplay.Text);
            textBoxDisplay.Text = "0";
            operazione = "*";
        }

        private void buttonDivisione_Click(object sender, EventArgs e)
        {
            primaCifra = Convert.ToDecimal(textBoxDisplay.Text);
            textBoxDisplay.Text = "0";
            operazione = "/";
        }
        private void buttonPercentuale_Click(object sender, EventArgs e)
        {
            primaCifra = Convert.ToDecimal(textBoxDisplay.Text);
            operazione = "%";
            RisultatoFinale = Calcolo(primaCifra, secondaCifra, operazione);
            textBoxDisplay.Text = Convert.ToString(RisultatoFinale);
        }
        private void buttonUguale_Click(object sender, EventArgs e)
        {
            secondaCifra = Convert.ToDecimal(textBoxDisplay.Text);
            RisultatoFinale = Calcolo(primaCifra, secondaCifra, operazione);
            textBoxDisplay.Text = Convert.ToString(RisultatoFinale);


        }

        
    }
}


//aggiungere cronologia, elevamento a potenza e radice quadrata