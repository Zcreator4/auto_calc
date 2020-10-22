using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace automobile_calculator
{
    public partial class frmAutoCost : Form
    {
        public frmAutoCost()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ForeColor = Color.BlueViolet;
            BackColor = Color.Aqua;
        }

        private void submitExpense(object sender, EventArgs e)
        {
            string carNoteStr = inTxtCarNote.Text;
            string carInsureStr = inTxtCarInsurance.Text;
            string carGasStr = inTxtGas.Text;
            string carOilStr = inTxtOil.Text;
            string carRepairStr = inTxtRepairs.Text;
            string carRegStr = inTxtRepairs.Text;

            double carNoteDbl = Convert.ToDouble(carNoteStr);
            double carInsureDbl = Convert.ToDouble(carInsureStr);
            double carGasDbl = Convert.ToDouble(carGasStr);
            double carOilDbl = Convert.ToDouble(carOilStr);
            double carRegDbl = Convert.ToDouble(carRegStr);
            double carRepairDbl = Convert.ToDouble(carRepairStr);

            double monthlyExpense = carNoteDbl + carInsureDbl + carGasDbl + carOilDbl + carRepairDbl + carRegDbl;
            double yearlyExpense = monthlyExpense * 12;

            outTxtResults.Text = "";
            outTxtResults.Text = "***Final Results***" + Environment.NewLine;
            outTxtResults.AppendText("Total Monthly Cost: " + monthlyExpense.ToString("C") + Environment.NewLine);
            outTxtResults.AppendText("Total Yearly Cost: " + yearlyExpense.ToString("C") + Environment.NewLine);
        }

        private void frmAutoCost_ForeColorChanged(object sender, EventArgs e)
        {

        }
    }
}
