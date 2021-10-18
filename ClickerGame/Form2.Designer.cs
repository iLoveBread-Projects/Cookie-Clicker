
namespace ClickerGame
{
    partial class frmShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShop));
            this.btnBuy = new System.Windows.Forms.Button();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblExplained = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(13, 236);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(184, 23);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lbxItems
            // 
            this.lbxItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.Items.AddRange(new object[] {
            "Google Click Bot",
            "Juice Creator",
            "Stepsis",
            "Cow Milker",
            "Russian Dancer",
            "Cookie Extractor",
            "Milky Miner",
            "Invalid Cookie Discarder",
            "Price Checker",
            "Dad\'s Juice",
            "Cookie Generator"});
            this.lbxItems.Location = new System.Drawing.Point(13, 16);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(184, 147);
            this.lbxItems.TabIndex = 4;
            this.lbxItems.SelectedIndexChanged += new System.EventHandler(this.lbxItems_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 166);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(88, 13);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "What does it do?";
            // 
            // lblExplained
            // 
            this.lblExplained.AutoSize = true;
            this.lblExplained.Location = new System.Drawing.Point(12, 188);
            this.lblExplained.Name = "lblExplained";
            this.lblExplained.Size = new System.Drawing.Size(61, 13);
            this.lblExplained.TabIndex = 6;
            this.lblExplained.Text = "*Explained*";
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 265);
            this.Controls.Add(this.lblExplained);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.btnBuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.frmShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblExplained;
    }
}