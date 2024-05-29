using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcolatrice
{

    public partial class Form2 : Form
    {
        int i = 0;
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            
            Visualizzazzione();
        }
        public void Reset() 
        {
            i = 0;
        }
        
        public void Visualizzazzione()
        {
            string[] Vettore = form1.OttieniVett();
            int Contatore = form1.OttieniLung();
            
            do
            {
                Cronologia.Items.Add(Vettore[i]);
                i++;

            } while (i<Contatore);

            int totaleOperazioni = 0;
            
            
            for (int n = 0; n < Vettore.Length; n++)
            {
                if (Vettore[n] != null)
                {
                    totaleOperazioni++;
                }

                
                
            }

                string TotaleOperazioniString = totaleOperazioni.ToString();
                TotaleOperazioniString = TotaleOperazioniString + "" + "" + "Operazioni Eseguite";
                label1.Text = TotaleOperazioniString;

        }

        private void buttonPulisciCronologia_Click(object sender, EventArgs e)
        {
            string[] Vettore = form1.OttieniVett();
            Cronologia.Items.Clear();
            string CronologiaVuota = "Cronologia Vuota";
            for (int i = 0; i < Vettore.Length; i++)
            {
                if (Vettore[i] != null)
                {
                    Vettore[i] = null;
                    
                }
                else 
                {
                i = Vettore.Length;
                }

                label1.Text = CronologiaVuota;
            }
            Reset();
            form1.Reset();
            

        }
    }
}
