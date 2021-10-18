
namespace ClickerGame
{
    partial class frmClicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClicker));
            this.btnClicker = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblClickCounter = new System.Windows.Forms.Label();
            this.btnShop = new System.Windows.Forms.Button();
            this.lbxOwnedItems = new System.Windows.Forms.ListBox();
            this.lblOwned = new System.Windows.Forms.Label();
            this.tmrAutoClick = new System.Windows.Forms.Timer(this.components);
            this.lblNeededToUpgrade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClicker
            // 
            this.btnClicker.Image = ((System.Drawing.Image)(resources.GetObject("btnClicker.Image")));
            this.btnClicker.Location = new System.Drawing.Point(12, 32);
            this.btnClicker.Name = "btnClicker";
            this.btnClicker.Size = new System.Drawing.Size(100, 100);
            this.btnClicker.TabIndex = 0;
            this.btnClicker.UseVisualStyleBackColor = true;
            this.btnClicker.Click += new System.EventHandler(this.btnClicker_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(12, 9);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(75, 13);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = "Current points:";
            // 
            // lblClickCounter
            // 
            this.lblClickCounter.AutoSize = true;
            this.lblClickCounter.Location = new System.Drawing.Point(93, 9);
            this.lblClickCounter.Name = "lblClickCounter";
            this.lblClickCounter.Size = new System.Drawing.Size(43, 13);
            this.lblClickCounter.TabIndex = 3;
            this.lblClickCounter.Text = "*Clicks*";
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(258, 148);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(109, 23);
            this.btnShop.TabIndex = 16;
            this.btnShop.Text = "Open Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // lbxOwnedItems
            // 
            this.lbxOwnedItems.FormattingEnabled = true;
            this.lbxOwnedItems.Location = new System.Drawing.Point(258, 25);
            this.lbxOwnedItems.Name = "lbxOwnedItems";
            this.lbxOwnedItems.Size = new System.Drawing.Size(109, 121);
            this.lbxOwnedItems.TabIndex = 17;
            // 
            // lblOwned
            // 
            this.lblOwned.AutoSize = true;
            this.lblOwned.Location = new System.Drawing.Point(278, 9);
            this.lblOwned.Name = "lblOwned";
            this.lblOwned.Size = new System.Drawing.Size(69, 13);
            this.lblOwned.TabIndex = 19;
            this.lblOwned.Text = "Owned Items";
            // 
            // tmrAutoClick
            // 
            this.tmrAutoClick.Interval = 1000;
            // 
            // lblNeededToUpgrade
            // 
            this.lblNeededToUpgrade.AutoSize = true;
            this.lblNeededToUpgrade.Location = new System.Drawing.Point(12, 153);
            this.lblNeededToUpgrade.Name = "lblNeededToUpgrade";
            this.lblNeededToUpgrade.Size = new System.Drawing.Size(107, 13);
            this.lblNeededToUpgrade.TabIndex = 20;
            this.lblNeededToUpgrade.Text = "*NeededToUpgrade*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Next cheapest upgrade:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Upgrade Clicks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 183);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNeededToUpgrade);
            this.Controls.Add(this.lblOwned);
            this.Controls.Add(this.lbxOwnedItems);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.lblClickCounter);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnClicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cookie Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClicker_FormClosing);
            this.Load += new System.EventHandler(this.frmApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClicker;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblClickCounter;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.ListBox lbxOwnedItems;
        private System.Windows.Forms.Label lblOwned;
        private System.Windows.Forms.Timer tmrAutoClick;
        private System.Windows.Forms.Label lblNeededToUpgrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

