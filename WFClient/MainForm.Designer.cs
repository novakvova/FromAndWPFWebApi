namespace WFClient
{
    partial class MainForm
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTredInfo = new System.Windows.Forms.Label();
            this.btnAddProductForm = new System.Windows.Forms.Button();
            this.btnShowLoginForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColPrice});
            this.dgvProducts.Location = new System.Drawing.Point(17, 74);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1098, 334);
            this.dgvProducts.TabIndex = 0;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Назва";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Ціна";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            // 
            // lblTredInfo
            // 
            this.lblTredInfo.AutoSize = true;
            this.lblTredInfo.Location = new System.Drawing.Point(13, 22);
            this.lblTredInfo.Name = "lblTredInfo";
            this.lblTredInfo.Size = new System.Drawing.Size(125, 17);
            this.lblTredInfo.TabIndex = 1;
            this.lblTredInfo.Text = "Загрузка даних ...";
            // 
            // btnAddProductForm
            // 
            this.btnAddProductForm.Location = new System.Drawing.Point(922, 18);
            this.btnAddProductForm.Name = "btnAddProductForm";
            this.btnAddProductForm.Size = new System.Drawing.Size(193, 40);
            this.btnAddProductForm.TabIndex = 2;
            this.btnAddProductForm.Text = "Додати продукт";
            this.btnAddProductForm.UseVisualStyleBackColor = true;
            this.btnAddProductForm.Click += new System.EventHandler(this.btnAddProductForm_Click);
            // 
            // btnShowLoginForm
            // 
            this.btnShowLoginForm.Location = new System.Drawing.Point(709, 18);
            this.btnShowLoginForm.Name = "btnShowLoginForm";
            this.btnShowLoginForm.Size = new System.Drawing.Size(193, 40);
            this.btnShowLoginForm.TabIndex = 2;
            this.btnShowLoginForm.Text = "Вхід";
            this.btnShowLoginForm.UseVisualStyleBackColor = true;
            this.btnShowLoginForm.Click += new System.EventHandler(this.btnShowLoginForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 446);
            this.Controls.Add(this.btnShowLoginForm);
            this.Controls.Add(this.btnAddProductForm);
            this.Controls.Add(this.lblTredInfo);
            this.Controls.Add(this.dgvProducts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.Label lblTredInfo;
        private System.Windows.Forms.Button btnAddProductForm;
        private System.Windows.Forms.Button btnShowLoginForm;
    }
}

