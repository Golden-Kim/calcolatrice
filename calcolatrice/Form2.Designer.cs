﻿namespace calcolatrice
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cronologia = new ListBox();
            buttonPulisciCronologia = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Cronologia
            // 
            Cronologia.FormattingEnabled = true;
            Cronologia.ItemHeight = 15;
            Cronologia.Location = new Point(2, 0);
            Cronologia.Name = "Cronologia";
            Cronologia.Size = new Size(120, 394);
            Cronologia.TabIndex = 0;
            // 
            // buttonPulisciCronologia
            // 
            buttonPulisciCronologia.Location = new Point(128, 0);
            buttonPulisciCronologia.Name = "buttonPulisciCronologia";
            buttonPulisciCronologia.Size = new Size(75, 23);
            buttonPulisciCronologia.TabIndex = 1;
            buttonPulisciCronologia.Text = "Pulisci";
            buttonPulisciCronologia.UseVisualStyleBackColor = true;
            buttonPulisciCronologia.Click += buttonPulisciCronologia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 26);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "labelContatore";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 400);
            Controls.Add(label1);
            Controls.Add(buttonPulisciCronologia);
            Controls.Add(Cronologia);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Cronologia;
        private Button buttonPulisciCronologia;
        private Label label1;
    }
}