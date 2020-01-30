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
      bool addValid = double.TryParse(txtAdd.Text, out double toAdd);
      if (addValid)
      {
        scoreTotal += toAdd;
        scoreCount++;
        double scoreAverage = scoreTotal / scoreCount;
        txtAverage.Text = scoreAverage.ToString();
        txtTotal.Text = scoreTotal.ToString();
        txtCount.Text = scoreCount.ToString();
      }
      else
      {
        MessageBox.Show("Please enter a number with no units.");
      }
    }
  }
}
