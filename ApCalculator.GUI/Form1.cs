using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApCalculator.GUI
{
    public partial class Form1 : Form
    {
        double ThetaMax, Tau, delta, t, F, Delta;

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            ParseTextBoxes();
            if (rboAlignmentError.Checked)
            {
                double result = SolveForDeltaErr();
                string strResult = String.Format("{0:0,0.0}", result);
                txtThetaMax.Text = strResult;
            }
            if (rboTargetDeclination.Checked)
            {
                
            }
            if (rboExposureTIme.Checked)
            {
                double result = SolveForMaxExposureTime();
                string strResult = String.Format("{0:0,0.0}", result);
                txtT.Text = strResult;
            }
            if (rboMaxFocalLength.Checked)
            {
                double result = SolveForMaxFocalLength();
                string strResult = String.Format("{0:0,0.0}", result);
                txtF.Text = strResult;
            }
            if (rboMaxFieldRotation.Checked)
            {
                double result = SolveForFieldRotation();
                string strResult = String.Format("{0:0,0.0}", result);
                txtTau.Text = strResult;
            }
            if (rboGuideStarAngle.Checked)
            {
                double result = SolveForMaxGudeStarAngle();
                string strResult = String.Format("{0:0,0.0}", result);
                txtDeltaUP.Text = strResult;
            }
            ShowEquationDetails();

        }

       



        private void ShowEquationDetails()
        {
            lblTau.Text = Tau.ToString();
            lblDeltaLC.Text = delta.ToString();
            lblt.Text = t.ToString();
            lblF.Text = F.ToString();
            lblDeltaUC.Text = Delta.ToString();
            lblThetaMax.Text = ThetaMax.ToString();
        }





        public Form1()
        {
            InitializeComponent();
            lnkPDF.Links.Add(0, 10, "http://www.ibm.com");
        }



        public void ParseTextBoxes()
        {
            bool parseError = false;
            if (!double.TryParse(txtTau.Text, out Tau))
            {
                parseError = true;
            }

            if (!double.TryParse(txtDeltaLC.Text, out delta))
            {
                parseError = true;
            }

            if (!double.TryParse(txtT.Text, out t))
            {
                parseError = true;
            }

            if (!double.TryParse(txtF.Text, out F))
            {
                parseError = true;
            }
            if (!double.TryParse(txtDeltaUP.Text, out Delta))
            {
                parseError = true;
            }
            if (!double.TryParse(txtThetaMax.Text, out ThetaMax))
            {
                parseError = true;
            }


            if (!double.TryParse(txtDeltaUP.Text, out Delta))
            {
                parseError = true;
            }
            if (parseError)
            {
                MessageBox.Show("Not all values are numbers. PLease fix them");
                return;
            }
        }

        #region CheckBoxes
        private void rboSolveForAlignmentError_CheckedChanged(object sender, EventArgs e)
        {
          
            if (rboAlignmentError.Checked)
            {
                txtThetaMax.BackColor = Color.Red;
                txtThetaMax.Enabled = false;
            }
            else
            {
                txtThetaMax.BackColor = Color.White;
                txtThetaMax.Enabled = true;
            }
        }

        private void rboSolveForMaxFocalLength_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rboMaxFocalLength.Checked)
            {
                txtF.BackColor = Color.Red;
                txtF.Enabled = false;
            }
            else
            {
                txtF.BackColor = Color.White;
                txtF.Enabled = true;
            }
        }

        private void rboTargetDeclination_CheckedChanged(object sender, EventArgs e)
        {
          
            if (rboTargetDeclination.Checked)
            {
                txtDeltaLC.BackColor = Color.Red;
                txtDeltaLC.Enabled = false;
            }
            else
            {
                txtDeltaLC.BackColor = Color.White;
                txtDeltaLC.Enabled = true;
            }
        }

        private void rboExposureTIme_CheckedChanged(object sender, EventArgs e)
        {
            if (rboExposureTIme.Checked)
            {
                txtT.BackColor = Color.Red;
                txtT.Enabled = false;
            }
            else
            {
                txtT.BackColor = Color.White;
                txtT.Enabled = true;
            }
        }

        private void rboMaxFieldRotation_CheckedChanged(object sender, EventArgs e)
        {
            if (rboMaxFieldRotation.Checked)
            {
                txtTau.BackColor = Color.Red;
                txtTau.Enabled = false;
            }
            else
            {
                txtTau.BackColor = Color.White;
                txtTau.Enabled = true;
            }
        }

        private void rboGuideStarAngle_CheckedChanged(object sender, EventArgs e)
        {
            if (rboGuideStarAngle.Checked)
            {
                txtDeltaUP.BackColor = Color.Red;
                txtDeltaUP.Enabled = false;
            }
            else
            {
                txtDeltaUP.BackColor = Color.White;
                txtDeltaUP.Enabled = true;
            }
        }
        #endregion





  
        #region "Solve Equations"
        private double SolveForMaxFocalLength()
        {
            double top = 45000 * Tau * Math.Cos(delta.ToRadians());
            double bot = ThetaMax * t * Delta;
            return top / bot;
        }

        private double SolveForMaxGudeStarAngle()
        {
            double top = 45000 * Tau * Math.Cos(delta.ToRadians());
            double bot = ThetaMax * t * F;
            return top / bot;
        }
        public double SolveForDeltaErr()
        {
            double top = 45000 * Tau * Math.Cos(delta.ToRadians());
            double bot = t * F * Delta;
            return top / bot;
        }

        private double SolveForMaxExposureTime()
        {
            double top = 45000 * Tau * Math.Cos(delta.ToRadians());
            double bot = ThetaMax * F * Delta;
            return top / bot;
        }
        private double SolveForFieldRotation()
        {
            double top = ThetaMax * t * F * Delta;
            double bot = 45000 * Math.Cos(delta.ToRadians());
            return top / bot;
        }
        #endregion
    }
    public static class NumericExtensions
    {
        public static double ToRadians(this double val)
        {
            return (Math.PI / 180) * val;
        }
    }
}
