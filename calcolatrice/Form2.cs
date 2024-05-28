using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcolatrice
{

    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            //Caricamento();
            Visualizzazzione();
        }
        /*public void Caricamento()
        {
            string[] myArray = form1.OttieniVett();
            int arrayLength = form1.OttieniLung();
            string Risultato = form1.OttieniRisultato();
            for (int i = 0; i < arrayLength; i++)
            {
                myArray[i] = Risultato;
            }

        }*/
        public void Visualizzazzione()
        {
            string[] Vettore = form1.OttieniVett();
            int Contatore = form1.OttieniLung();
            for (int i = 0; i < Contatore; i++)
            {
                Cronologia.Items.Add(Vettore[i]);
            }
        }

        private void buttonPulisciCronologia_Click(object sender, EventArgs e)
        {
            Cronologia.Items.Clear();
        }
    }
}
