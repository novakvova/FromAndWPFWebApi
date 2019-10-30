namespace WFClient
{
    partial class EditProductForm
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
            this.btnSelectФото = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectФото
            // 
            this.btnSelectФото.Location = new System.Drawing.Point(594, 111);
            this.btnSelectФото.Name = "btnSelectФото";
            this.btnSelectФото.Size = new System.Drawing.Size(163, 41);
            this.btnSelectФото.TabIndex = 13;
            this.btnSelectФото.Text = "Обрати фото";
            this.btnSelectФото.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(18, 156);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(142, 90);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(610, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 54);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(103, 118);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(475, 20);
            this.txtImagePath.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фото";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(103, 70);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(475, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ціна";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(475, 20);
            this.txtName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Назва";
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 279);
            this.Controls.Add(this.btnSelectФото);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "EditProductForm";
            this.Text = "EditProductForm";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectФото;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}