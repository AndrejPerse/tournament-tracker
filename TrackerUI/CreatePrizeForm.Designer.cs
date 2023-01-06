
namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.prizeMaterialValue = new System.Windows.Forms.TextBox();
            this.prizeMaterialLabel = new System.Windows.Forms.Label();
            this.prizeMoneyValue = new System.Windows.Forms.TextBox();
            this.prizeMoneyLabel = new System.Windows.Forms.Label();
            this.prizeNameValue = new System.Windows.Forms.TextBox();
            this.prizeNameLabel = new System.Windows.Forms.Label();
            this.prizePlaceValue = new System.Windows.Forms.TextBox();
            this.prizePlaceLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.White;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.Location = new System.Drawing.Point(84, 303);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(178, 47);
            this.createPrizeButton.TabIndex = 30;
            this.createPrizeButton.Text = "Ustvari nagrado";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // prizeMaterialValue
            // 
            this.prizeMaterialValue.Location = new System.Drawing.Point(24, 239);
            this.prizeMaterialValue.Name = "prizeMaterialValue";
            this.prizeMaterialValue.Size = new System.Drawing.Size(294, 29);
            this.prizeMaterialValue.TabIndex = 29;
            // 
            // prizeMaterialLabel
            // 
            this.prizeMaterialLabel.AutoSize = true;
            this.prizeMaterialLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeMaterialLabel.ForeColor = System.Drawing.Color.White;
            this.prizeMaterialLabel.Location = new System.Drawing.Point(19, 206);
            this.prizeMaterialLabel.Name = "prizeMaterialLabel";
            this.prizeMaterialLabel.Size = new System.Drawing.Size(194, 30);
            this.prizeMaterialLabel.TabIndex = 28;
            this.prizeMaterialLabel.Text = "Materialna nagrada";
            // 
            // prizeMoneyValue
            // 
            this.prizeMoneyValue.Location = new System.Drawing.Point(199, 159);
            this.prizeMoneyValue.Name = "prizeMoneyValue";
            this.prizeMoneyValue.Size = new System.Drawing.Size(114, 29);
            this.prizeMoneyValue.TabIndex = 27;
            // 
            // prizeMoneyLabel
            // 
            this.prizeMoneyLabel.AutoSize = true;
            this.prizeMoneyLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeMoneyLabel.ForeColor = System.Drawing.Color.White;
            this.prizeMoneyLabel.Location = new System.Drawing.Point(19, 158);
            this.prizeMoneyLabel.Name = "prizeMoneyLabel";
            this.prizeMoneyLabel.Size = new System.Drawing.Size(174, 30);
            this.prizeMoneyLabel.TabIndex = 26;
            this.prizeMoneyLabel.Text = "Denarna nagrada";
            // 
            // prizeNameValue
            // 
            this.prizeNameValue.Location = new System.Drawing.Point(96, 111);
            this.prizeNameValue.Name = "prizeNameValue";
            this.prizeNameValue.Size = new System.Drawing.Size(217, 29);
            this.prizeNameValue.TabIndex = 25;
            // 
            // prizeNameLabel
            // 
            this.prizeNameLabel.AutoSize = true;
            this.prizeNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeNameLabel.ForeColor = System.Drawing.Color.White;
            this.prizeNameLabel.Location = new System.Drawing.Point(19, 110);
            this.prizeNameLabel.Name = "prizeNameLabel";
            this.prizeNameLabel.Size = new System.Drawing.Size(65, 30);
            this.prizeNameLabel.TabIndex = 24;
            this.prizeNameLabel.Text = "Naziv";
            // 
            // prizePlaceValue
            // 
            this.prizePlaceValue.Location = new System.Drawing.Point(96, 63);
            this.prizePlaceValue.Name = "prizePlaceValue";
            this.prizePlaceValue.Size = new System.Drawing.Size(217, 29);
            this.prizePlaceValue.TabIndex = 23;
            // 
            // prizePlaceLabel
            // 
            this.prizePlaceLabel.AutoSize = true;
            this.prizePlaceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePlaceLabel.ForeColor = System.Drawing.Color.White;
            this.prizePlaceLabel.Location = new System.Drawing.Point(19, 62);
            this.prizePlaceLabel.Name = "prizePlaceLabel";
            this.prizePlaceLabel.Size = new System.Drawing.Size(71, 30);
            this.prizePlaceLabel.TabIndex = 22;
            this.prizePlaceLabel.Text = "Mesto";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(206, 37);
            this.headerLabel.TabIndex = 21;
            this.headerLabel.Text = "Ustvari nagrado";
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(347, 416);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.prizeMaterialValue);
            this.Controls.Add(this.prizeMaterialLabel);
            this.Controls.Add(this.prizeMoneyValue);
            this.Controls.Add(this.prizeMoneyLabel);
            this.Controls.Add(this.prizeNameValue);
            this.Controls.Add(this.prizeNameLabel);
            this.Controls.Add(this.prizePlaceValue);
            this.Controls.Add(this.prizePlaceLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.TextBox prizeMaterialValue;
        private System.Windows.Forms.Label prizeMaterialLabel;
        private System.Windows.Forms.TextBox prizeMoneyValue;
        private System.Windows.Forms.Label prizeMoneyLabel;
        private System.Windows.Forms.TextBox prizeNameValue;
        private System.Windows.Forms.Label prizeNameLabel;
        private System.Windows.Forms.TextBox prizePlaceValue;
        private System.Windows.Forms.Label prizePlaceLabel;
        private System.Windows.Forms.Label headerLabel;
    }
}