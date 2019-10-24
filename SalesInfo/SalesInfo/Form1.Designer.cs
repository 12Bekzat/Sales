namespace SalesInfo
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
      this.GetBuyer = new System.Windows.Forms.Button();
      this.GetSellers = new System.Windows.Forms.Button();
      this.GetSales = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // GetBuyer
      // 
      this.GetBuyer.Location = new System.Drawing.Point(103, 64);
      this.GetBuyer.Name = "GetBuyer";
      this.GetBuyer.Size = new System.Drawing.Size(191, 49);
      this.GetBuyer.TabIndex = 0;
      this.GetBuyer.Text = "dbo.Buyers";
      this.GetBuyer.UseVisualStyleBackColor = true;
      this.GetBuyer.Click += new System.EventHandler(this.GetBuyer_Click);
      // 
      // GetSellers
      // 
      this.GetSellers.Location = new System.Drawing.Point(103, 166);
      this.GetSellers.Name = "GetSellers";
      this.GetSellers.Size = new System.Drawing.Size(191, 49);
      this.GetSellers.TabIndex = 1;
      this.GetSellers.Text = "dbo.Sellers";
      this.GetSellers.UseVisualStyleBackColor = true;
      this.GetSellers.Click += new System.EventHandler(this.GetSellers_Click);
      // 
      // GetSales
      // 
      this.GetSales.Location = new System.Drawing.Point(103, 265);
      this.GetSales.Name = "GetSales";
      this.GetSales.Size = new System.Drawing.Size(191, 49);
      this.GetSales.TabIndex = 2;
      this.GetSales.Text = "dbo.Sales";
      this.GetSales.UseVisualStyleBackColor = true;
      this.GetSales.Click += new System.EventHandler(this.GetSales_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.GetSales);
      this.Controls.Add(this.GetSellers);
      this.Controls.Add(this.GetBuyer);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button GetBuyer;
    private System.Windows.Forms.Button GetSellers;
    private System.Windows.Forms.Button GetSales;
  }
}

