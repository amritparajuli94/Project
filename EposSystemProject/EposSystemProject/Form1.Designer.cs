namespace EposSystemProject
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
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnOpenTill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddProducts.Location = new System.Drawing.Point(45, 25);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(340, 43);
            this.btnAddProducts.TabIndex = 0;
            this.btnAddProducts.Text = "Add Products";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewProducts.Location = new System.Drawing.Point(45, 87);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(340, 48);
            this.btnViewProducts.TabIndex = 1;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = false;
            this.btnViewProducts.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOpenTill
            // 
            this.btnOpenTill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenTill.Location = new System.Drawing.Point(45, 159);
            this.btnOpenTill.Name = "btnOpenTill";
            this.btnOpenTill.Size = new System.Drawing.Size(340, 47);
            this.btnOpenTill.TabIndex = 2;
            this.btnOpenTill.Text = "Open Till";
            this.btnOpenTill.UseVisualStyleBackColor = false;
            this.btnOpenTill.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 427);
            this.Controls.Add(this.btnOpenTill);
            this.Controls.Add(this.btnViewProducts);
            this.Controls.Add(this.btnAddProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button btnOpenTill;
    }
}

