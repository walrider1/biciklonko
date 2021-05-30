
namespace Biciklino
{
    partial class PopupCalc
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDovoz = new System.Windows.Forms.CheckBox();
            this.buttonRacunanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 236);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 95);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PayPal     5.5% + 1.5e";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Banka (konverzija + provizija)      2%";
            // 
            // checkBoxDovoz
            // 
            this.checkBoxDovoz.AutoSize = true;
            this.checkBoxDovoz.Location = new System.Drawing.Point(24, 132);
            this.checkBoxDovoz.Name = "checkBoxDovoz";
            this.checkBoxDovoz.Size = new System.Drawing.Size(122, 17);
            this.checkBoxDovoz.TabIndex = 4;
            this.checkBoxDovoz.Text = "Dovoz do Srbije 10e";
            this.checkBoxDovoz.UseVisualStyleBackColor = true;
            this.checkBoxDovoz.CheckedChanged += new System.EventHandler(this.checkBoxDovoz_CheckedChanged);
            // 
            // buttonRacunanje
            // 
            this.buttonRacunanje.Location = new System.Drawing.Point(200, 25);
            this.buttonRacunanje.Name = "buttonRacunanje";
            this.buttonRacunanje.Size = new System.Drawing.Size(75, 23);
            this.buttonRacunanje.TabIndex = 5;
            this.buttonRacunanje.Text = "Racunaj";
            this.buttonRacunanje.UseVisualStyleBackColor = true;
            this.buttonRacunanje.Click += new System.EventHandler(this.buttonRacunanje_Click);
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 374);
            this.Controls.Add(this.buttonRacunanje);
            this.Controls.Add(this.checkBoxDovoz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "PopupForm";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.PopupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDovoz;
        private System.Windows.Forms.Button buttonRacunanje;
    }
}