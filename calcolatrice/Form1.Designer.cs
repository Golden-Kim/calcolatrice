using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace calcolatrice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonUno = new Button();
            buttonDue = new Button();
            buttonTre = new Button();
            buttonSei = new Button();
            buttonCinque = new Button();
            buttonQuattro = new Button();
            buttonNove = new Button();
            buttonOtto = new Button();
            buttonSette = new Button();
            buttonUguale = new Button();
            buttonAddizzione = new Button();
            buttonSottrazzione = new Button();
            buttonMoltiplicazione = new Button();
            buttonDivisione = new Button();
            buttonZero = new Button();
            buttonReset = new Button();
            buttonResetTotale = new Button();
            buttonVirgola = new Button();
            buttonPercentuale = new Button();
            textBoxDisplay = new TextBox();
            buttonCronologia = new Button();
            SuspendLayout();
            // 
            // buttonUno
            // 
            buttonUno.Location = new Point(2, 255);
            buttonUno.Name = "buttonUno";
            buttonUno.Size = new Size(50, 30);
            buttonUno.TabIndex = 0;
            buttonUno.Text = "1";
            buttonUno.UseVisualStyleBackColor = true;
            buttonUno.Click += buttonUno_Click;
            // 
            // buttonDue
            // 
            buttonDue.Location = new Point(58, 255);
            buttonDue.Name = "buttonDue";
            buttonDue.Size = new Size(50, 30);
            buttonDue.TabIndex = 1;
            buttonDue.Text = "2";
            buttonDue.UseVisualStyleBackColor = true;
            buttonDue.Click += buttonDue_Click;
            // 
            // buttonTre
            // 
            buttonTre.Location = new Point(114, 255);
            buttonTre.Name = "buttonTre";
            buttonTre.Size = new Size(50, 30);
            buttonTre.TabIndex = 2;
            buttonTre.Text = "3";
            buttonTre.UseVisualStyleBackColor = true;
            buttonTre.Click += buttonTre_Click;
            // 
            // buttonSei
            // 
            buttonSei.Location = new Point(113, 226);
            buttonSei.Name = "buttonSei";
            buttonSei.Size = new Size(50, 30);
            buttonSei.TabIndex = 5;
            buttonSei.Text = "6";
            buttonSei.UseVisualStyleBackColor = true;
            buttonSei.Click += buttonSei_Click;
            // 
            // buttonCinque
            // 
            buttonCinque.Location = new Point(57, 226);
            buttonCinque.Name = "buttonCinque";
            buttonCinque.Size = new Size(50, 30);
            buttonCinque.TabIndex = 4;
            buttonCinque.Text = "5";
            buttonCinque.UseVisualStyleBackColor = true;
            buttonCinque.Click += buttonCinque_Click;
            // 
            // buttonQuattro
            // 
            buttonQuattro.Location = new Point(2, 226);
            buttonQuattro.Name = "buttonQuattro";
            buttonQuattro.Size = new Size(50, 30);
            buttonQuattro.TabIndex = 3;
            buttonQuattro.Text = "4";
            buttonQuattro.UseVisualStyleBackColor = true;
            buttonQuattro.Click += buttonQuattro_Click;
            // 
            // buttonNove
            // 
            buttonNove.Location = new Point(113, 197);
            buttonNove.Name = "buttonNove";
            buttonNove.Size = new Size(50, 30);
            buttonNove.TabIndex = 8;
            buttonNove.Text = "9";
            buttonNove.UseVisualStyleBackColor = true;
            buttonNove.Click += buttonNove_Click;
            // 
            // buttonOtto
            // 
            buttonOtto.Location = new Point(58, 197);
            buttonOtto.Name = "buttonOtto";
            buttonOtto.Size = new Size(50, 30);
            buttonOtto.TabIndex = 7;
            buttonOtto.Text = "8";
            buttonOtto.UseVisualStyleBackColor = true;
            buttonOtto.Click += buttonOtto_Click;
            // 
            // buttonSette
            // 
            buttonSette.Location = new Point(2, 197);
            buttonSette.Name = "buttonSette";
            buttonSette.Size = new Size(50, 30);
            buttonSette.TabIndex = 6;
            buttonSette.Text = "7";
            buttonSette.UseVisualStyleBackColor = true;
            buttonSette.Click += buttonSette_Click;
            // 
            // buttonUguale
            // 
            buttonUguale.Location = new Point(169, 284);
            buttonUguale.Name = "buttonUguale";
            buttonUguale.Size = new Size(30, 30);
            buttonUguale.TabIndex = 9;
            buttonUguale.Text = "=";
            buttonUguale.UseVisualStyleBackColor = true;
            buttonUguale.Click += buttonUguale_Click;
            // 
            // buttonAddizzione
            // 
            buttonAddizzione.Location = new Point(169, 255);
            buttonAddizzione.Name = "buttonAddizzione";
            buttonAddizzione.Size = new Size(30, 30);
            buttonAddizzione.TabIndex = 10;
            buttonAddizzione.Text = "+";
            buttonAddizzione.UseVisualStyleBackColor = true;
            buttonAddizzione.Click += buttonAddizzione_Click;
            // 
            // buttonSottrazzione
            // 
            buttonSottrazzione.Location = new Point(169, 228);
            buttonSottrazzione.Name = "buttonSottrazzione";
            buttonSottrazzione.Size = new Size(30, 30);
            buttonSottrazzione.TabIndex = 11;
            buttonSottrazzione.Text = "-";
            buttonSottrazzione.UseVisualStyleBackColor = true;
            // 
            // buttonMoltiplicazione
            // 
            buttonMoltiplicazione.Location = new Point(169, 199);
            buttonMoltiplicazione.Name = "buttonMoltiplicazione";
            buttonMoltiplicazione.Size = new Size(30, 30);
            buttonMoltiplicazione.TabIndex = 12;
            buttonMoltiplicazione.Text = "X";
            buttonMoltiplicazione.UseVisualStyleBackColor = true;
            buttonMoltiplicazione.Click += buttonMoltiplicazione_Click;
            // 
            // buttonDivisione
            // 
            buttonDivisione.Location = new Point(169, 161);
            buttonDivisione.Name = "buttonDivisione";
            buttonDivisione.Size = new Size(30, 30);
            buttonDivisione.TabIndex = 13;
            buttonDivisione.Text = "÷";
            buttonDivisione.UseVisualStyleBackColor = true;
            buttonDivisione.Click += buttonDivisione_Click;
            // 
            // buttonZero
            // 
            buttonZero.Location = new Point(2, 284);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(106, 30);
            buttonZero.TabIndex = 14;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += buttonZero_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(58, 161);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(50, 30);
            buttonReset.TabIndex = 17;
            buttonReset.Text = "C";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonResetTotale
            // 
            buttonResetTotale.Location = new Point(2, 161);
            buttonResetTotale.Name = "buttonResetTotale";
            buttonResetTotale.Size = new Size(50, 30);
            buttonResetTotale.TabIndex = 18;
            buttonResetTotale.Text = "CE";
            buttonResetTotale.UseVisualStyleBackColor = true;
            buttonResetTotale.Click += buttonResetTotale_Click;
            // 
            // buttonVirgola
            // 
            buttonVirgola.Location = new Point(113, 284);
            buttonVirgola.Name = "buttonVirgola";
            buttonVirgola.Size = new Size(50, 30);
            buttonVirgola.TabIndex = 19;
            buttonVirgola.Text = ",";
            buttonVirgola.UseVisualStyleBackColor = true;
            buttonVirgola.Click += buttonVirgola_Click;
            // 
            // buttonPercentuale
            // 
            buttonPercentuale.Location = new Point(113, 161);
            buttonPercentuale.Name = "buttonPercentuale";
            buttonPercentuale.Size = new Size(50, 30);
            buttonPercentuale.TabIndex = 20;
            buttonPercentuale.Text = "%";
            buttonPercentuale.UseVisualStyleBackColor = true;
            buttonPercentuale.Click += buttonPercentuale_Click;
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.Location = new Point(0, 0);
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.Size = new Size(212, 23);
            textBoxDisplay.TabIndex = 21;
            textBoxDisplay.Text = "0";
            textBoxDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonCronologia
            // 
            buttonCronologia.Location = new Point(2, 29);
            buttonCronologia.Name = "buttonCronologia";
            buttonCronologia.Size = new Size(84, 30);
            buttonCronologia.TabIndex = 22;
            buttonCronologia.Text = "Cronologia";
            buttonCronologia.UseVisualStyleBackColor = true;
            buttonCronologia.Click += buttonCronologia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(211, 326);
            Controls.Add(buttonCronologia);
            Controls.Add(textBoxDisplay);
            Controls.Add(buttonPercentuale);
            Controls.Add(buttonVirgola);
            Controls.Add(buttonResetTotale);
            Controls.Add(buttonReset);
            Controls.Add(buttonZero);
            Controls.Add(buttonDivisione);
            Controls.Add(buttonMoltiplicazione);
            Controls.Add(buttonSottrazzione);
            Controls.Add(buttonAddizzione);
            Controls.Add(buttonUguale);
            Controls.Add(buttonNove);
            Controls.Add(buttonOtto);
            Controls.Add(buttonSette);
            Controls.Add(buttonSei);
            Controls.Add(buttonCinque);
            Controls.Add(buttonQuattro);
            Controls.Add(buttonTre);
            Controls.Add(buttonDue);
            Controls.Add(buttonUno);
            Name = "Form1";
            Text = "Calcolatrice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonUno;
        private Button buttonDue;
        private Button buttonTre;
        private Button buttonSei;
        private Button buttonCinque;
        private Button buttonQuattro;
        private Button buttonNove;
        private Button buttonOtto;
        private Button buttonSette;
        private Button buttonUguale;
        private Button buttonAddizzione;
        private Button buttonSottrazzione;
        private Button buttonMoltiplicazione;
        private Button buttonDivisione;
        private Button buttonZero;
        private Button buttonReset;
        private Button buttonResetTotale;
        private Button buttonVirgola;
        private Button buttonPercentuale;
        private TextBox textBoxDisplay;
        private Button buttonCronologia;
    }
}