namespace ScoreCounter
{
  partial class Form1
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
      this.txtAdd = new System.Windows.Forms.TextBox();
      this.txtAverage = new System.Windows.Forms.TextBox();
      this.txtCount = new System.Windows.Forms.TextBox();
      this.txtTotal = new System.Windows.Forms.TextBox();
      this.buttAdd = new System.Windows.Forms.Button();
      this.buttClear = new System.Windows.Forms.Button();
      this.buttExit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtAdd
      // 
      this.txtAdd.Location = new System.Drawing.Point(134, 43);
      this.txtAdd.Name = "txtAdd";
      this.txtAdd.Size = new System.Drawing.Size(100, 31);
      this.txtAdd.TabIndex = 0;
      // 
      // txtAverage
      // 
      this.txtAverage.Location = new System.Drawing.Point(134, 222);
      this.txtAverage.Name = "txtAverage";
      this.txtAverage.ReadOnly = true;
      this.txtAverage.Size = new System.Drawing.Size(100, 31);
      this.txtAverage.TabIndex = 1;
      this.txtAverage.TabStop = false;
      // 
      // txtCount
      // 
      this.txtCount.Location = new System.Drawing.Point(134, 161);
      this.txtCount.Name = "txtCount";
      this.txtCount.ReadOnly = true;
      this.txtCount.Size = new System.Drawing.Size(100, 31);
      this.txtCount.TabIndex = 2;
      this.txtCount.TabStop = false;
      // 
      // txtTotal
      // 
      this.txtTotal.Location = new System.Drawing.Point(134, 101);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.ReadOnly = true;
      this.txtTotal.Size = new System.Drawing.Size(100, 31);
      this.txtTotal.TabIndex = 3;
      this.txtTotal.TabStop = false;
      // 
      // buttAdd
      // 
      this.buttAdd.Location = new System.Drawing.Point(258, 43);
      this.buttAdd.Name = "buttAdd";
      this.buttAdd.Size = new System.Drawing.Size(128, 37);
      this.buttAdd.TabIndex = 4;
      this.buttAdd.Text = "Add";
      this.buttAdd.UseVisualStyleBackColor = true;
      this.buttAdd.Click += new System.EventHandler(this.buttAdd_Click);
      // 
      // buttClear
      // 
      this.buttClear.Location = new System.Drawing.Point(258, 128);
      this.buttClear.Name = "buttClear";
      this.buttClear.Size = new System.Drawing.Size(128, 37);
      this.buttClear.TabIndex = 5;
      this.buttClear.Text = "Clear All";
      this.buttClear.UseVisualStyleBackColor = true;
      // 
      // buttExit
      // 
      this.buttExit.Location = new System.Drawing.Point(258, 216);
      this.buttExit.Name = "buttExit";
      this.buttExit.Size = new System.Drawing.Size(128, 37);
      this.buttExit.TabIndex = 6;
      this.buttExit.Text = "Exit";
      this.buttExit.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(55, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 25);
      this.label1.TabIndex = 7;
      this.label1.Text = "Score";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(63, 107);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 25);
      this.label2.TabIndex = 8;
      this.label2.Text = "Total";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(54, 167);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(69, 25);
      this.label3.TabIndex = 9;
      this.label3.Text = "Count";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(31, 228);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(92, 25);
      this.label4.TabIndex = 10;
      this.label4.Text = "Average";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(426, 298);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttExit);
      this.Controls.Add(this.buttClear);
      this.Controls.Add(this.buttAdd);
      this.Controls.Add(this.txtTotal);
      this.Controls.Add(this.txtCount);
      this.Controls.Add(this.txtAverage);
      this.Controls.Add(this.txtAdd);
      this.Name = "Form1";
      this.Text = "Score Counter";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtAdd;
    private System.Windows.Forms.TextBox txtAverage;
    private System.Windows.Forms.TextBox txtCount;
    private System.Windows.Forms.TextBox txtTotal;
    private System.Windows.Forms.Button buttAdd;
    private System.Windows.Forms.Button buttClear;
    private System.Windows.Forms.Button buttExit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
  }
}

