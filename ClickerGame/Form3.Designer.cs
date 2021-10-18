
namespace ClickerGame
{
    partial class frmClickUpgrade
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
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.lblInfoAmount = new System.Windows.Forms.Label();
            this.lblUpgradeAmount = new System.Windows.Forms.Label();
            this.tbrUpgradeAmount = new System.Windows.Forms.TrackBar();
            this.lblInfoCost = new System.Windows.Forms.Label();
            this.lblUpgradeCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbrUpgradeAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Location = new System.Drawing.Point(12, 125);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(258, 23);
            this.btnUpgrade.TabIndex = 1;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // lblInfoAmount
            // 
            this.lblInfoAmount.AutoSize = true;
            this.lblInfoAmount.Location = new System.Drawing.Point(12, 73);
            this.lblInfoAmount.Name = "lblInfoAmount";
            this.lblInfoAmount.Size = new System.Drawing.Size(89, 13);
            this.lblInfoAmount.TabIndex = 2;
            this.lblInfoAmount.Text = "Upgrade amount:";
            // 
            // lblUpgradeAmount
            // 
            this.lblUpgradeAmount.AutoSize = true;
            this.lblUpgradeAmount.Location = new System.Drawing.Point(107, 73);
            this.lblUpgradeAmount.Name = "lblUpgradeAmount";
            this.lblUpgradeAmount.Size = new System.Drawing.Size(92, 13);
            this.lblUpgradeAmount.TabIndex = 3;
            this.lblUpgradeAmount.Text = "*UpgradeAmount*";
            // 
            // tbrUpgradeAmount
            // 
            this.tbrUpgradeAmount.LargeChange = 1;
            this.tbrUpgradeAmount.Location = new System.Drawing.Point(12, 12);
            this.tbrUpgradeAmount.Minimum = 1;
            this.tbrUpgradeAmount.Name = "tbrUpgradeAmount";
            this.tbrUpgradeAmount.Size = new System.Drawing.Size(258, 45);
            this.tbrUpgradeAmount.TabIndex = 0;
            this.tbrUpgradeAmount.Value = 1;
            this.tbrUpgradeAmount.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblInfoCost
            // 
            this.lblInfoCost.AutoSize = true;
            this.lblInfoCost.Location = new System.Drawing.Point(12, 95);
            this.lblInfoCost.Name = "lblInfoCost";
            this.lblInfoCost.Size = new System.Drawing.Size(31, 13);
            this.lblInfoCost.TabIndex = 4;
            this.lblInfoCost.Text = "Cost:";
            // 
            // lblUpgradeCost
            // 
            this.lblUpgradeCost.AutoSize = true;
            this.lblUpgradeCost.Location = new System.Drawing.Point(49, 95);
            this.lblUpgradeCost.Name = "lblUpgradeCost";
            this.lblUpgradeCost.Size = new System.Drawing.Size(77, 13);
            this.lblUpgradeCost.TabIndex = 5;
            this.lblUpgradeCost.Text = "*UpgradeCost*";
            // 
            // frmClickUpgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblUpgradeCost);
            this.Controls.Add(this.lblInfoCost);
            this.Controls.Add(this.lblUpgradeAmount);
            this.Controls.Add(this.lblInfoAmount);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.tbrUpgradeAmount);
            this.Name = "frmClickUpgrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Click Upgrades";
            this.Load += new System.EventHandler(this.frmClickUpgrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbrUpgradeAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Label lblInfoAmount;
        private System.Windows.Forms.Label lblUpgradeAmount;
        private System.Windows.Forms.TrackBar tbrUpgradeAmount;
        private System.Windows.Forms.Label lblInfoCost;
        private System.Windows.Forms.Label lblUpgradeCost;
    }
}