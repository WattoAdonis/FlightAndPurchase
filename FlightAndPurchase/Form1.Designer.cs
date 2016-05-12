namespace FlightAndPurchase
{
    partial class FlightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtBoxDestination = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1253, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestination.Location = new System.Drawing.Point(63, 87);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(62, 15);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Destination";
            // 
            // txtBoxDestination
            // 
            this.txtBoxDestination.Location = new System.Drawing.Point(163, 84);
            this.txtBoxDestination.Name = "txtBoxDestination";
            this.txtBoxDestination.Size = new System.Drawing.Size(324, 20);
            this.txtBoxDestination.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Flight 01:",
            "Flight 02:",
            "Flight 03:",
            "Flight 04:",
            "Flight 05:",
            "Flight 06:",
            "Flight 07:",
            "Flight 08:",
            "Flight 09:",
            "Flight 10:"});
            this.listBox1.Location = new System.Drawing.Point(163, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(324, 134);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(901, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-mail address:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1004, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Location = new System.Drawing.Point(1004, 47);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(83, 13);
            this.lblSignIn.TabIndex = 6;
            this.lblSignIn.Text = "Account Sign-In";
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlightAndPurchase.Properties.Resources.glider_h6w;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1355, 625);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtBoxDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlightForm";
            this.Text = "Flight Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtBoxDestination;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSignIn;
    }
}

