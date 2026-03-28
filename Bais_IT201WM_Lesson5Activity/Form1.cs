using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bais_IT201WM_Lesson5Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void middlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void civilstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void qds_TextChanged(object sender, EventArgs e)
        {

        }

        private void paydate_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeestatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void department_TextChanged(object sender, EventArgs e)
        {

        }

        private void basicincomerh_TextChanged(object sender, EventArgs e)
        {

        }

        private void basicincomenoofhours_TextChanged(object sender, EventArgs e)
        {

        }

        private void basicincomecutoff_TextChanged(object sender, EventArgs e)
        {

        }

        private void otherincomeratehour_TextChanged(object sender, EventArgs e)
        {

        }

        private void otherincomenoofhours_TextChanged(object sender, EventArgs e)
        {

        }

        private void othercutoff_TextChanged(object sender, EventArgs e)
        {

        }

        private void honorariumratehour_TextChanged(object sender, EventArgs e)
        {

        }

        private void honorariumnoofhours_TextChanged(object sender, EventArgs e)
        {

        }

        private void honorariumincome_TextChanged(object sender, EventArgs e)
        {

        }

        private void sssloan_TextChanged(object sender, EventArgs e)
        {

        }

        private void pagibigloan_TextChanged(object sender, EventArgs e)
        {

        }

        private void fsd_TextChanged(object sender, EventArgs e)
        {

        }

        private void grossbutton_Click(object sender, EventArgs e)
        {
            decimal basicRate, basicHours, basicCutoff;
            decimal otherRate, otherHours, otherCutoff;
            decimal honorRate, honorHours;


            decimal.TryParse(basicincomerh.Text, out basicRate);
            decimal.TryParse(basicincomenoofhours.Text, out basicHours);
            decimal.TryParse(basicincomecutoff.Text, out basicCutoff);
            decimal basicIncome = basicRate * basicHours * basicCutoff;

     
            decimal.TryParse(otherincomeratehour.Text, out otherRate);
            decimal.TryParse(otherincomenoofhours.Text, out otherHours);
            decimal.TryParse(othercutoff.Text, out otherCutoff);
            decimal otherIncome = otherRate * otherHours * otherCutoff;

            
            decimal.TryParse(honorariumratehour.Text, out honorRate);
            decimal.TryParse(honorariumnoofhours.Text, out honorHours);
            decimal honorariumIncome = honorRate * honorHours;

            decimal gross = basicIncome + otherIncome + honorariumIncome;

            textBox31.Text = gross.ToString("N2");

        }



        private void salaryloan_TextChanged(object sender, EventArgs e)
        {

        }

        private void fsl_TextChanged(object sender, EventArgs e)
        {

        }

        private void otherloan_TextChanged(object sender, EventArgs e)
        {

        }

        private void incometaxcontri_TextChanged(object sender, EventArgs e)
        {

        }

        private void pagibigcontri_TextChanged(object sender, EventArgs e)
        {

        }

        private void phlcontri_TextChanged(object sender, EventArgs e)
        {

        }

        private void ssscontri_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {

        }

        private void updbutton_Click(object sender, EventArgs e)
        {

        }

        private void newbutton_Click(object sender, EventArgs e)
        {

        }

        private void netincomebutton_Click(object sender, EventArgs e)
        {
            decimal gross;
            decimal.TryParse(textBox31.Text, out gross);


            decimal sssLoan, pagibigLoan, salaryLoan, otherLoan;
            decimal.TryParse(sssloan.Text, out sssLoan);
            decimal.TryParse(pagibigloan.Text, out pagibigLoan);
            decimal.TryParse(salaryloan.Text, out salaryLoan);
            decimal.TryParse(otherloan.Text, out otherLoan);

            decimal sssRate, pagibigRate, phlRate, taxRate;
            decimal.TryParse(ssscontri.Text, out sssRate);
            decimal.TryParse(pagibigcontri.Text, out pagibigRate);
            decimal.TryParse(phlcontri.Text, out phlRate);
            decimal.TryParse(incometaxcontri.Text, out taxRate);


            decimal sssFloor = 1000m;
            decimal sssCeiling = 20000m;

            decimal pagibigFloor = 1000m;
            decimal pagibigCeiling = 5000m;

            decimal phlFloor = 10000m;
            decimal phlCeiling = 60000m;


            decimal sssBase = Math.Min(Math.Max(gross, sssFloor), sssCeiling);
            decimal pagibigBase = Math.Min(Math.Max(gross, pagibigFloor), pagibigCeiling);
            decimal phlBase = Math.Min(Math.Max(gross, phlFloor), phlCeiling);

            decimal sssContri = sssBase * sssRate;
            decimal pagibigContri = pagibigBase * pagibigRate;
            decimal phlContri = phlBase * phlRate;
            decimal taxContri = gross * taxRate;


            decimal totalDeductions = sssLoan + pagibigLoan + salaryLoan + otherLoan
                                    + sssContri + pagibigContri + phlContri + taxContri;

            decimal netIncome = gross - totalDeductions;

            netincomebutton.Text = netIncome.ToString("N2");

        }
    }
}
