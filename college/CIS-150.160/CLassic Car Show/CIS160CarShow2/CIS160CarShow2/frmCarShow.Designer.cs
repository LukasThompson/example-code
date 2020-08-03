namespace CIS160CarShow2
{
   partial class frmCarShow
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
         this.lstCarInventory = new System.Windows.Forms.ListBox();
         this.lblHeader = new System.Windows.Forms.Label();
         this.lblInsurance = new System.Windows.Forms.Label();
         this.lblInventory = new System.Windows.Forms.Label();
         this.lblCars = new System.Windows.Forms.Label();
         this.lblCarsTotal = new System.Windows.Forms.Label();
         this.lblValue = new System.Windows.Forms.Label();
         this.lblTotalValue = new System.Windows.Forms.Label();
         this.picCarImage = new System.Windows.Forms.PictureBox();
         this.btnCompute = new System.Windows.Forms.Button();
         this.mnuMain = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         ((System.ComponentModel.ISupportInitialize)(this.picCarImage)).BeginInit();
         this.mnuMain.SuspendLayout();
         this.SuspendLayout();
         // 
         // lstCarInventory
         // 
         this.lstCarInventory.FormattingEnabled = true;
         this.lstCarInventory.Location = new System.Drawing.Point(45, 207);
         this.lstCarInventory.Name = "lstCarInventory";
         this.lstCarInventory.Size = new System.Drawing.Size(333, 342);
         this.lstCarInventory.TabIndex = 0;
         // 
         // lblHeader
         // 
         this.lblHeader.AutoSize = true;
         this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblHeader.ForeColor = System.Drawing.Color.MidnightBlue;
         this.lblHeader.Location = new System.Drawing.Point(38, 44);
         this.lblHeader.Name = "lblHeader";
         this.lblHeader.Size = new System.Drawing.Size(313, 42);
         this.lblHeader.TabIndex = 1;
         this.lblHeader.Text = "Classic Car Show";
         // 
         // lblInsurance
         // 
         this.lblInsurance.AutoSize = true;
         this.lblInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblInsurance.ForeColor = System.Drawing.Color.MidnightBlue;
         this.lblInsurance.Location = new System.Drawing.Point(57, 86);
         this.lblInsurance.Name = "lblInsurance";
         this.lblInsurance.Size = new System.Drawing.Size(252, 25);
         this.lblInsurance.TabIndex = 2;
         this.lblInsurance.Text = "Total Value for Insurance";
         // 
         // lblInventory
         // 
         this.lblInventory.AutoSize = true;
         this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblInventory.ForeColor = System.Drawing.Color.MidnightBlue;
         this.lblInventory.Location = new System.Drawing.Point(271, 128);
         this.lblInventory.Name = "lblInventory";
         this.lblInventory.Size = new System.Drawing.Size(237, 29);
         this.lblInventory.TabIndex = 3;
         this.lblInventory.Text = "Classic Car Inventory";
         // 
         // lblCars
         // 
         this.lblCars.AutoSize = true;
         this.lblCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCars.ForeColor = System.Drawing.Color.MidnightBlue;
         this.lblCars.Location = new System.Drawing.Point(40, 174);
         this.lblCars.Name = "lblCars";
         this.lblCars.Size = new System.Drawing.Size(218, 25);
         this.lblCars.TabIndex = 4;
         this.lblCars.Text = "Total Cars in Show:";
         // 
         // lblCarsTotal
         // 
         this.lblCarsTotal.AutoSize = true;
         this.lblCarsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCarsTotal.ForeColor = System.Drawing.Color.MidnightBlue;
         this.lblCarsTotal.Location = new System.Drawing.Point(271, 174);
         this.lblCarsTotal.Name = "lblCarsTotal";
         this.lblCarsTotal.Size = new System.Drawing.Size(38, 25);
         this.lblCarsTotal.TabIndex = 5;
         this.lblCarsTotal.Text = "11";
         // 
         // lblValue
         // 
         this.lblValue.AutoSize = true;
         this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblValue.ForeColor = System.Drawing.Color.MidnightBlue;
         this.lblValue.Location = new System.Drawing.Point(402, 174);
         this.lblValue.Name = "lblValue";
         this.lblValue.Size = new System.Drawing.Size(222, 25);
         this.lblValue.TabIndex = 6;
         this.lblValue.Text = "Total Value of Cars:";
         this.lblValue.Click += new System.EventHandler(this.lblValue_Click);
         // 
         // lblTotalValue
         // 
         this.lblTotalValue.AutoSize = true;
         this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotalValue.ForeColor = System.Drawing.Color.MidnightBlue;
         this.lblTotalValue.Location = new System.Drawing.Point(630, 174);
         this.lblTotalValue.Name = "lblTotalValue";
         this.lblTotalValue.Size = new System.Drawing.Size(110, 25);
         this.lblTotalValue.TabIndex = 7;
         this.lblTotalValue.Text = "$532.957";
         // 
         // picCarImage
         // 
         this.picCarImage.Location = new System.Drawing.Point(407, 207);
         this.picCarImage.Name = "picCarImage";
         this.picCarImage.Size = new System.Drawing.Size(333, 342);
         this.picCarImage.TabIndex = 8;
         this.picCarImage.TabStop = false;
         // 
         // btnCompute
         // 
         this.btnCompute.BackColor = System.Drawing.Color.MidnightBlue;
         this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCompute.ForeColor = System.Drawing.Color.White;
         this.btnCompute.Location = new System.Drawing.Point(444, 64);
         this.btnCompute.Name = "btnCompute";
         this.btnCompute.Size = new System.Drawing.Size(256, 47);
         this.btnCompute.TabIndex = 9;
         this.btnCompute.Text = "Compute Inventory";
         this.btnCompute.UseVisualStyleBackColor = false;
         // 
         // mnuMain
         // 
         this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
         this.mnuMain.Location = new System.Drawing.Point(0, 0);
         this.mnuMain.Name = "mnuMain";
         this.mnuMain.Size = new System.Drawing.Size(778, 24);
         this.mnuMain.TabIndex = 10;
         this.mnuMain.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // clearToolStripMenuItem
         // 
         this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
         this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.clearToolStripMenuItem.Text = "Clear";
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.exitToolStripMenuItem.Text = "Exit";
         // 
         // frmCarShow
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(778, 569);
         this.Controls.Add(this.btnCompute);
         this.Controls.Add(this.picCarImage);
         this.Controls.Add(this.lblTotalValue);
         this.Controls.Add(this.lblValue);
         this.Controls.Add(this.lblCarsTotal);
         this.Controls.Add(this.lblCars);
         this.Controls.Add(this.lblInventory);
         this.Controls.Add(this.lblInsurance);
         this.Controls.Add(this.lblHeader);
         this.Controls.Add(this.lstCarInventory);
         this.Controls.Add(this.mnuMain);
         this.MainMenuStrip = this.mnuMain;
         this.Name = "frmCarShow";
         this.Text = "Classic Car Show";
         ((System.ComponentModel.ISupportInitialize)(this.picCarImage)).EndInit();
         this.mnuMain.ResumeLayout(false);
         this.mnuMain.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox lstCarInventory;
      private System.Windows.Forms.Label lblHeader;
      private System.Windows.Forms.Label lblInsurance;
      private System.Windows.Forms.Label lblInventory;
      private System.Windows.Forms.Label lblCars;
      private System.Windows.Forms.Label lblCarsTotal;
      private System.Windows.Forms.Label lblValue;
      private System.Windows.Forms.Label lblTotalValue;
      private System.Windows.Forms.PictureBox picCarImage;
      private System.Windows.Forms.Button btnCompute;
      private System.Windows.Forms.MenuStrip mnuMain;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
   }
}

