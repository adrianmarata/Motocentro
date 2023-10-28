namespace Motocentro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonLogs = new System.Windows.Forms.Button();
            this.buttonNotify = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonAccounts = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Controls.Add(this.panelLogo);
            this.MainPanel.Controls.Add(this.panelButtons);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(319, 838);
            this.MainPanel.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(4, 4);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(315, 176);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonReports);
            this.panelButtons.Controls.Add(this.buttonLogs);
            this.panelButtons.Controls.Add(this.buttonNotify);
            this.panelButtons.Controls.Add(this.buttonProducts);
            this.panelButtons.Controls.Add(this.buttonAccounts);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(4, 188);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(315, 651);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonReports
            // 
            this.buttonReports.BackColor = System.Drawing.Color.Black;
            this.buttonReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReports.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold);
            this.buttonReports.ForeColor = System.Drawing.Color.White;
            this.buttonReports.Location = new System.Drawing.Point(0, 516);
            this.buttonReports.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(315, 129);
            this.buttonReports.TabIndex = 4;
            this.buttonReports.Text = "Reports";
            this.buttonReports.UseVisualStyleBackColor = false;
            // 
            // buttonLogs
            // 
            this.buttonLogs.BackColor = System.Drawing.Color.Black;
            this.buttonLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogs.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold);
            this.buttonLogs.ForeColor = System.Drawing.Color.White;
            this.buttonLogs.Location = new System.Drawing.Point(0, 387);
            this.buttonLogs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogs.Name = "buttonLogs";
            this.buttonLogs.Size = new System.Drawing.Size(315, 129);
            this.buttonLogs.TabIndex = 3;
            this.buttonLogs.Text = "Logs";
            this.buttonLogs.UseVisualStyleBackColor = false;
            // 
            // buttonNotify
            // 
            this.buttonNotify.BackColor = System.Drawing.Color.Black;
            this.buttonNotify.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNotify.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotify.ForeColor = System.Drawing.Color.White;
            this.buttonNotify.Location = new System.Drawing.Point(0, 258);
            this.buttonNotify.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNotify.Name = "buttonNotify";
            this.buttonNotify.Size = new System.Drawing.Size(315, 129);
            this.buttonNotify.TabIndex = 2;
            this.buttonNotify.Text = "Notify";
            this.buttonNotify.UseVisualStyleBackColor = false;
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.Color.Black;
            this.buttonProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProducts.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold);
            this.buttonProducts.ForeColor = System.Drawing.Color.White;
            this.buttonProducts.Location = new System.Drawing.Point(0, 129);
            this.buttonProducts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(315, 129);
            this.buttonProducts.TabIndex = 1;
            this.buttonProducts.Text = "Products";
            this.buttonProducts.UseVisualStyleBackColor = false;
            // 
            // buttonAccounts
            // 
            this.buttonAccounts.BackColor = System.Drawing.Color.Black;
            this.buttonAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAccounts.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold);
            this.buttonAccounts.ForeColor = System.Drawing.Color.White;
            this.buttonAccounts.Location = new System.Drawing.Point(0, 0);
            this.buttonAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAccounts.Name = "buttonAccounts";
            this.buttonAccounts.Size = new System.Drawing.Size(315, 129);
            this.buttonAccounts.TabIndex = 0;
            this.buttonAccounts.Text = "Accounts";
            this.buttonAccounts.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(319, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1366, 64);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Motocentro";
            this.MainPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAccounts;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonLogs;
        private System.Windows.Forms.Button buttonNotify;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

