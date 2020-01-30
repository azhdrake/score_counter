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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.buttAdd = new System.Windows.Forms.Button();
      this.buttClear = new System.Windows.Forms.Button();
      this.buttExit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(134, 43);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 31);
      this.textBox1.TabIndex = 0;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(134, 222);
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new System.Drawing.Size(100, 31);
      this.textBox2.TabIndex = 1;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(134, 161);
      this.textBox3.Name = "textBox3";
      this.textBox3.ReadOnly = true;
      this.textBox3.Size = new System.Drawing.Size(100, 31);
      this.textBox3.TabIndex = 2;
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(134, 101);
      this.textBox4.Name = "textBox4";
      this.textBox4.ReadOnly = true;
      this.textBox4.Size = new System.Drawing.Size(100, 31);
      this.textBox4.TabIndex = 3;
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
      this.label3.Click += new System.EventHandler(this.label3_Click);
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
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Score Counter";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Button buttAdd;
    private System.Windows.Forms.Button buttClear;
    private System.Windows.Forms.Button buttExit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
  }
}

