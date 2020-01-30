using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCounter
{
  public partial class Form1 : Form
  {
    double scoreTotal = 0;
    int scoreCount = 0;
    public Form1()
    {
      InitializeComponent();
    }

    private void buttAdd_Click(object sender, EventArgs e)
    {
      // Ensuring valid input
      bool addValid = double.TryParse(txtAdd.Text, out double toAdd);
      if (addValid)
      {
        //doing the caculations
        scoreTotal += toAdd;
        scoreCount++;
        double scoreAverage = scoreTotal / scoreCount;

        //desplaying the caculations
        txtAverage.Text = scoreAverage.ToString();
        txtTotal.Text = scoreTotal.ToString();
        txtCount.Text = scoreCount.ToString();

        //resetting for more input.
        txtAdd.Text = "";
        txtAdd.Focus();
      }
      else
      {
        MessageBox.Show("Please enter a number with no units.");
      }
    }

    private void buttClear_Click(object sender, EventArgs e)
    {
      //resetting everything
      scoreTotal = 0;
      scoreCount = 0;
      txtAverage.Text = "";
      txtTotal.Text = "";
      txtCount.Text = "";
      txtAdd.Focus();
    }

    private void buttExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
