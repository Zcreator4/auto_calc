namespace automobile_calculator
{
    partial class frmAutoCost
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
            this.carNote = new System.Windows.Forms.Label();
            this.carInsure = new System.Windows.Forms.Label();
            this.Gas = new System.Windows.Forms.Label();
            this.Oil = new System.Windows.Forms.Label();
            this.Repairs = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.Label();
            this.inTxtCarNote = new System.Windows.Forms.TextBox();
            this.inTxtOil = new System.Windows.Forms.TextBox();
            this.inTxtCarInsurance = new System.Windows.Forms.TextBox();
            this.inTxtRepairs = new System.Windows.Forms.TextBox();
            this.inTxtRegistration = new System.Windows.Forms.TextBox();
            this.inTxtGas = new System.Windows.Forms.TextBox();
            this.outTxtResults = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carNote
            // 
            this.carNote.AutoSize = true;
            this.carNote.Location = new System.Drawing.Point(44, 59);
            this.carNote.Name = "carNote";
            this.carNote.Size = new System.Drawing.Size(72, 20);
            this.carNote.TabIndex = 0;
            this.carNote.Text = "Car Note";
            // 
            // carInsure
            // 
            this.carInsure.AutoSize = true;
            this.carInsure.Location = new System.Drawing.Point(10, 107);
            this.carInsure.Name = "carInsure";
            this.carInsure.Size = new System.Drawing.Size(109, 20);
            this.carInsure.TabIndex = 1;
            this.carInsure.Text = "Car Insurance";
            // 
            // Gas
            // 
            this.Gas.AutoSize = true;
            this.Gas.Location = new System.Drawing.Point(80, 150);
            this.Gas.Name = "Gas";
            this.Gas.Size = new System.Drawing.Size(39, 20);
            this.Gas.TabIndex = 2;
            this.Gas.Text = "Gas";
            // 
            // Oil
            // 
            this.Oil.AutoSize = true;
            this.Oil.Location = new System.Drawing.Point(89, 196);
            this.Oil.Name = "Oil";
            this.Oil.Size = new System.Drawing.Size(27, 20);
            this.Oil.TabIndex = 3;
            this.Oil.Text = "Oil";
            // 
            // Repairs
            // 
            this.Repairs.AutoSize = true;
            this.Repairs.Location = new System.Drawing.Point(55, 233);
            this.Repairs.Name = "Repairs";
            this.Repairs.Size = new System.Drawing.Size(64, 20);
            this.Repairs.TabIndex = 4;
            this.Repairs.Text = "Repairs";
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Location = new System.Drawing.Point(24, 273);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(95, 20);
            this.Registration.TabIndex = 5;
            this.Registration.Text = "Registration";
            // 
            // inTxtCarNote
            // 
            this.inTxtCarNote.Location = new System.Drawing.Point(136, 59);
            this.inTxtCarNote.Name = "inTxtCarNote";
            this.inTxtCarNote.Size = new System.Drawing.Size(167, 26);
            this.inTxtCarNote.TabIndex = 6;
            // 
            // inTxtOil
            // 
            this.inTxtOil.Location = new System.Drawing.Point(136, 196);
            this.inTxtOil.Name = "inTxtOil";
            this.inTxtOil.Size = new System.Drawing.Size(167, 26);
            this.inTxtOil.TabIndex = 7;
            // 
            // inTxtCarInsurance
            // 
            this.inTxtCarInsurance.Location = new System.Drawing.Point(136, 107);
            this.inTxtCarInsurance.Name = "inTxtCarInsurance";
            this.inTxtCarInsurance.Size = new System.Drawing.Size(167, 26);
            this.inTxtCarInsurance.TabIndex = 8;
            // 
            // inTxtRepairs
            // 
            this.inTxtRepairs.Location = new System.Drawing.Point(136, 233);
            this.inTxtRepairs.Name = "inTxtRepairs";
            this.inTxtRepairs.Size = new System.Drawing.Size(167, 26);
            this.inTxtRepairs.TabIndex = 9;
            // 
            // inTxtRegistration
            // 
            this.inTxtRegistration.Location = new System.Drawing.Point(136, 273);
            this.inTxtRegistration.Name = "inTxtRegistration";
            this.inTxtRegistration.Size = new System.Drawing.Size(167, 26);
            this.inTxtRegistration.TabIndex = 10;
            // 
            // inTxtGas
            // 
            this.inTxtGas.Location = new System.Drawing.Point(136, 150);
            this.inTxtGas.Name = "inTxtGas";
            this.inTxtGas.Size = new System.Drawing.Size(167, 26);
            this.inTxtGas.TabIndex = 11;
            // 
            // outTxtResults
            // 
            this.outTxtResults.Location = new System.Drawing.Point(28, 432);
            this.outTxtResults.Multiline = true;
            this.outTxtResults.Name = "outTxtResults";
            this.outTxtResults.Size = new System.Drawing.Size(300, 100);
            this.outTxtResults.TabIndex = 12;
            this.outTxtResults.Text = "***Final Results***\r\nTotal Monthly Cost: $\r\nTotal Annual Cost: $";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(211, 357);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(92, 40);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.submitExpense);
            // 
            // frmAutoCost
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 544);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.outTxtResults);
            this.Controls.Add(this.inTxtGas);
            this.Controls.Add(this.inTxtRegistration);
            this.Controls.Add(this.inTxtRepairs);
            this.Controls.Add(this.inTxtCarInsurance);
            this.Controls.Add(this.inTxtOil);
            this.Controls.Add(this.inTxtCarNote);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Repairs);
            this.Controls.Add(this.Oil);
            this.Controls.Add(this.Gas);
            this.Controls.Add(this.carInsure);
            this.Controls.Add(this.carNote);
            this.Name = "frmAutoCost";
            this.Text = "Auto Cost";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ForeColorChanged += new System.EventHandler(this.frmAutoCost_ForeColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carNote;
        private System.Windows.Forms.Label carInsure;
        private System.Windows.Forms.Label Gas;
        private System.Windows.Forms.Label Oil;
        private System.Windows.Forms.Label Repairs;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.TextBox inTxtCarNote;
        private System.Windows.Forms.TextBox inTxtOil;
        private System.Windows.Forms.TextBox inTxtCarInsurance;
        private System.Windows.Forms.TextBox inTxtRepairs;
        private System.Windows.Forms.TextBox inTxtRegistration;
        private System.Windows.Forms.TextBox inTxtGas;
        private System.Windows.Forms.TextBox outTxtResults;
        private System.Windows.Forms.Button btnCalculate;
    }
}

