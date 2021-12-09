namespace Coffee_Shop_Management
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.SellCoffee = new System.Windows.Forms.Button();
            this.AdminB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 759);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(352, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 73);
            this.button3.TabIndex = 1;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SellCoffee
            // 
            this.SellCoffee.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellCoffee.ForeColor = System.Drawing.Color.Gold;
            this.SellCoffee.Location = new System.Drawing.Point(524, 162);
            this.SellCoffee.Name = "SellCoffee";
            this.SellCoffee.Size = new System.Drawing.Size(353, 141);
            this.SellCoffee.TabIndex = 0;
            this.SellCoffee.Text = "Sell Coffee";
            this.SellCoffee.UseVisualStyleBackColor = true;
            this.SellCoffee.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminB
            // 
            this.AdminB.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminB.ForeColor = System.Drawing.Color.Gold;
            this.AdminB.Location = new System.Drawing.Point(37, 162);
            this.AdminB.Name = "AdminB";
            this.AdminB.Size = new System.Drawing.Size(355, 141);
            this.AdminB.TabIndex = 0;
            this.AdminB.Text = "Admin";
            this.AdminB.UseVisualStyleBackColor = true;
            this.AdminB.Click += new System.EventHandler(this.AdminB_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AdminB);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.SellCoffee);
            this.panel2.Location = new System.Drawing.Point(40, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 672);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 795);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AdminB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SellCoffee;
        private System.Windows.Forms.Panel panel2;
    }
}