namespace MainForm
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
            this.btn_Cashier = new System.Windows.Forms.Button();
            this.btn_Warehouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cashier
            // 
            this.btn_Cashier.Location = new System.Drawing.Point(47, 50);
            this.btn_Cashier.Name = "btn_Cashier";
            this.btn_Cashier.Size = new System.Drawing.Size(130, 87);
            this.btn_Cashier.TabIndex = 0;
            this.btn_Cashier.Text = "Cashier";
            this.btn_Cashier.UseVisualStyleBackColor = true;
            this.btn_Cashier.Click += new System.EventHandler(this.btn_Cashier_Click);
            // 
            // btn_Warehouse
            // 
            this.btn_Warehouse.Location = new System.Drawing.Point(238, 50);
            this.btn_Warehouse.Name = "btn_Warehouse";
            this.btn_Warehouse.Size = new System.Drawing.Size(125, 87);
            this.btn_Warehouse.TabIndex = 1;
            this.btn_Warehouse.Text = "Warehouse";
            this.btn_Warehouse.UseVisualStyleBackColor = true;
            this.btn_Warehouse.Click += new System.EventHandler(this.btn_Warehouse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 185);
            this.Controls.Add(this.btn_Warehouse);
            this.Controls.Add(this.btn_Cashier);
            this.Name = "MainForm";
            this.Text = "Main Log Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cashier;
        private System.Windows.Forms.Button btn_Warehouse;
    }
}

