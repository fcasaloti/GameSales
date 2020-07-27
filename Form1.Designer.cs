namespace Assignment2
{
    partial class GameSales
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.resultsLb = new System.Windows.Forms.ListBox();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.SearchLb = new System.Windows.Forms.Label();
            this.totalBt = new System.Windows.Forms.Button();
            this.errorCb = new System.Windows.Forms.CheckBox();
            this.companyGb = new System.Windows.Forms.GroupBox();
            this.blizzardRb = new System.Windows.Forms.RadioButton();
            this.eaRb = new System.Windows.Forms.RadioButton();
            this.microsoftRb = new System.Windows.Forms.RadioButton();
            this.totalGb = new System.Windows.Forms.GroupBox();
            this.outputLb = new System.Windows.Forms.Label();
            this.companyGb.SuspendLayout();
            this.totalGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Arial", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(151, 91);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(125, 58);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "Clear \r\nSearch";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // resultsLb
            // 
            this.resultsLb.BackColor = System.Drawing.SystemColors.Info;
            this.resultsLb.FormattingEnabled = true;
            this.resultsLb.ItemHeight = 18;
            this.resultsLb.Location = new System.Drawing.Point(386, 39);
            this.resultsLb.Name = "resultsLb";
            this.resultsLb.Size = new System.Drawing.Size(408, 220);
            this.resultsLb.TabIndex = 1;
            // 
            // searchTb
            // 
            this.searchTb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchTb.ForeColor = System.Drawing.Color.Yellow;
            this.searchTb.Location = new System.Drawing.Point(111, 185);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(165, 26);
            this.searchTb.TabIndex = 2;
            // 
            // SearchLb
            // 
            this.SearchLb.AutoSize = true;
            this.SearchLb.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLb.Location = new System.Drawing.Point(35, 188);
            this.SearchLb.Name = "SearchLb";
            this.SearchLb.Size = new System.Drawing.Size(63, 19);
            this.SearchLb.TabIndex = 3;
            this.SearchLb.Text = "Search";
            // 
            // totalBt
            // 
            this.totalBt.Font = new System.Drawing.Font("Arial", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBt.Location = new System.Drawing.Point(58, 351);
            this.totalBt.Name = "totalBt";
            this.totalBt.Size = new System.Drawing.Size(218, 58);
            this.totalBt.TabIndex = 4;
            this.totalBt.Text = "Total\r\nSales";
            this.totalBt.UseVisualStyleBackColor = true;
            this.totalBt.Click += new System.EventHandler(this.TotalBt_Click);
            // 
            // errorCb
            // 
            this.errorCb.AutoSize = true;
            this.errorCb.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCb.Location = new System.Drawing.Point(94, 262);
            this.errorCb.Name = "errorCb";
            this.errorCb.Size = new System.Drawing.Size(135, 23);
            this.errorCb.TabIndex = 5;
            this.errorCb.Text = "Display Error";
            this.errorCb.UseVisualStyleBackColor = true;
            this.errorCb.CheckedChanged += new System.EventHandler(this.errorCb_CheckedChanged);
            // 
            // companyGb
            // 
            this.companyGb.Controls.Add(this.blizzardRb);
            this.companyGb.Controls.Add(this.eaRb);
            this.companyGb.Controls.Add(this.microsoftRb);
            this.companyGb.Font = new System.Drawing.Font("Arial", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyGb.Location = new System.Drawing.Point(386, 296);
            this.companyGb.Name = "companyGb";
            this.companyGb.Size = new System.Drawing.Size(408, 71);
            this.companyGb.TabIndex = 6;
            this.companyGb.TabStop = false;
            this.companyGb.Text = "Company";
            // 
            // blizzardRb
            // 
            this.blizzardRb.AutoSize = true;
            this.blizzardRb.Location = new System.Drawing.Point(292, 26);
            this.blizzardRb.Name = "blizzardRb";
            this.blizzardRb.Size = new System.Drawing.Size(90, 22);
            this.blizzardRb.TabIndex = 2;
            this.blizzardRb.TabStop = true;
            this.blizzardRb.Text = "Blizzard";
            this.blizzardRb.UseVisualStyleBackColor = true;
            // 
            // eaRb
            // 
            this.eaRb.AutoSize = true;
            this.eaRb.Location = new System.Drawing.Point(170, 26);
            this.eaRb.Name = "eaRb";
            this.eaRb.Size = new System.Drawing.Size(56, 22);
            this.eaRb.TabIndex = 1;
            this.eaRb.TabStop = true;
            this.eaRb.Text = "EA";
            this.eaRb.UseVisualStyleBackColor = true;
            // 
            // microsoftRb
            // 
            this.microsoftRb.AutoSize = true;
            this.microsoftRb.Location = new System.Drawing.Point(20, 26);
            this.microsoftRb.Name = "microsoftRb";
            this.microsoftRb.Size = new System.Drawing.Size(104, 22);
            this.microsoftRb.TabIndex = 0;
            this.microsoftRb.TabStop = true;
            this.microsoftRb.Text = "Microsoft";
            this.microsoftRb.UseVisualStyleBackColor = true;
            // 
            // totalGb
            // 
            this.totalGb.Controls.Add(this.outputLb);
            this.totalGb.Font = new System.Drawing.Font("Arial", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalGb.Location = new System.Drawing.Point(386, 386);
            this.totalGb.Name = "totalGb";
            this.totalGb.Size = new System.Drawing.Size(408, 96);
            this.totalGb.TabIndex = 7;
            this.totalGb.TabStop = false;
            this.totalGb.Text = "Total Sales";
            //this.totalGb.Enter += new System.EventHandler(this.totalGb_Enter);
            // 
            // outputLb
            // 
            this.outputLb.BackColor = System.Drawing.Color.Yellow;
            this.outputLb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLb.Font = new System.Drawing.Font("Arial", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLb.ForeColor = System.Drawing.Color.Blue;
            this.outputLb.Location = new System.Drawing.Point(27, 31);
            this.outputLb.Name = "outputLb";
            this.outputLb.Size = new System.Drawing.Size(354, 48);
            this.outputLb.TabIndex = 8;
            this.outputLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 494);
            this.Controls.Add(this.totalGb);
            this.Controls.Add(this.companyGb);
            this.Controls.Add(this.errorCb);
            this.Controls.Add(this.totalBt);
            this.Controls.Add(this.SearchLb);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.resultsLb);
            this.Controls.Add(this.clearBtn);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GameSales";
            this.Text = "Fernando Game Sales";
            this.Load += new System.EventHandler(this.GameSales_Load);
            this.companyGb.ResumeLayout(false);
            this.companyGb.PerformLayout();
            this.totalGb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ListBox resultsLb;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Label SearchLb;
        private System.Windows.Forms.Button totalBt;
        private System.Windows.Forms.CheckBox errorCb;
        private System.Windows.Forms.GroupBox companyGb;
        private System.Windows.Forms.RadioButton blizzardRb;
        private System.Windows.Forms.RadioButton eaRb;
        private System.Windows.Forms.RadioButton microsoftRb;
        private System.Windows.Forms.GroupBox totalGb;
        private System.Windows.Forms.Label outputLb;
    }
}

