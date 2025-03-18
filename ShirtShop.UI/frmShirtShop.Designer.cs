namespace ShirtShop.UI
{
    partial class frmShirtShop
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbxFabric = new System.Windows.Forms.ComboBox();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.cbxSleeveLength = new System.Windows.Forms.ComboBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.ckbEasyIroning = new System.Windows.Forms.CheckBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbxShirts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 20);
            this.txtName.TabIndex = 0;
            // 
            // cbxFabric
            // 
            this.cbxFabric.FormattingEnabled = true;
            this.cbxFabric.Location = new System.Drawing.Point(13, 40);
            this.cbxFabric.Name = "cbxFabric";
            this.cbxFabric.Size = new System.Drawing.Size(163, 21);
            this.cbxFabric.TabIndex = 1;
            // 
            // cbxSize
            // 
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(12, 67);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(163, 21);
            this.cbxSize.TabIndex = 2;
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(13, 94);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(163, 21);
            this.cbxColor.TabIndex = 3;
            // 
            // cbxSleeveLength
            // 
            this.cbxSleeveLength.FormattingEnabled = true;
            this.cbxSleeveLength.Location = new System.Drawing.Point(12, 121);
            this.cbxSleeveLength.Name = "cbxSleeveLength";
            this.cbxSleeveLength.Size = new System.Drawing.Size(163, 21);
            this.cbxSleeveLength.TabIndex = 4;
            // 
            // cbxBrand
            // 
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(13, 148);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(163, 21);
            this.cbxBrand.TabIndex = 5;
            // 
            // ckbEasyIroning
            // 
            this.ckbEasyIroning.AutoSize = true;
            this.ckbEasyIroning.Location = new System.Drawing.Point(13, 176);
            this.ckbEasyIroning.Name = "ckbEasyIroning";
            this.ckbEasyIroning.Size = new System.Drawing.Size(81, 17);
            this.ckbEasyIroning.TabIndex = 6;
            this.ckbEasyIroning.Text = "EasyIroning";
            this.ckbEasyIroning.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(13, 200);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(162, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Shirt toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lbxShirts
            // 
            this.lbxShirts.FormattingEnabled = true;
            this.lbxShirts.Location = new System.Drawing.Point(182, 13);
            this.lbxShirts.Name = "lbxShirts";
            this.lbxShirts.Size = new System.Drawing.Size(120, 238);
            this.lbxShirts.TabIndex = 9;
            // 
            // frmShirtShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 270);
            this.Controls.Add(this.lbxShirts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.ckbEasyIroning);
            this.Controls.Add(this.cbxBrand);
            this.Controls.Add(this.cbxSleeveLength);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.cbxSize);
            this.Controls.Add(this.cbxFabric);
            this.Controls.Add(this.txtName);
            this.Name = "frmShirtShop";
            this.Text = "ShirtShop";
            this.Load += new System.EventHandler(this.FrmShirtShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbxFabric;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.ComboBox cbxSleeveLength;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.CheckBox ckbEasyIroning;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxShirts;
    }
}

