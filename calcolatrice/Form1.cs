using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace calcolatrice
{
    public partial class Form1 : Form
    {

        decimal primaCifra = 0;
        decimal secondaCifra = 0;
        string operazione = "";
        decimal RisultatoFinale = 0;
        public string[] VettRisultato = new string[50];
        public string RisultatoFinaleString = "";
        public int Cont = 1;
        public string RisultatoFinaleCron = "";
        int loop = 0;



        public Form1()
        {
            InitializeComponent();
        }
        public string[] OttieniVett()
        {
            return VettRisultato;
        }
        public int OttieniLung()
        {
            return loop;
        }
        public string OttieniRisultato() 
        {

            return RisultatoFinaleCron;
        
        }
        private decimal Calcolo(decimal numero1, decimal numero2, string TipoOperazione)
        {
            decimal risultato = 0;
            switch (TipoOperazione)
            {
                case "+":
                    risultato = numero1 + numero2;
                    break;

                case "-":
                    risultato = numero1 - numero2;
                    break;

                case "*":
                    risultato = numero1 * numero2;
                    break;

                case "/":
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
                    break;
                case "%":
                    risultato = numero1 / 100;
                    break;

                default:
                    break;
            }



            return risultato;
        }
        public string FuncCronologia(string primNum, string secNum, string OperString, string Risultato)
        {
            string RisultatoString = "";

            RisultatoString = Risultato + "=" + primNum + "" + OperString + "" + secNum;


            return RisultatoString;
            
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
            
            
            Cont++;
            secondaCifra = Convert.ToDecimal(textBoxDisplay.Text);
            RisultatoFinale = Calcolo(primaCifra, secondaCifra, operazione);
            textBoxDisplay.Text = Convert.ToString(RisultatoFinale);
            string RisultatoFinaleCronologia = "";
            
                
                string PrimoNumeroCron = "";
                string SecondoNumeroCron = "";

                string OperazioneCron = "";

                PrimoNumeroCron = primaCifra.ToString();
                SecondoNumeroCron = primaCifra.ToString();
                RisultatoFinaleString = RisultatoFinale.ToString();
                OperazioneCron = operazione.ToString();

            do
            {

                RisultatoFinaleCronologia =FuncCronologia(PrimoNumeroCron, SecondoNumeroCron,OperazioneCron , RisultatoFinaleString);
                VettRisultato[loop] = RisultatoFinaleCronologia;
                loop++;

            } while (Cont<loop);
               
                

                
            


        }

        private void buttonCronologia_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }
}

