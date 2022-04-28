
namespace ConactAppp
{
    partial class EditUser
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
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.txtMobileNomber = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(220, 331);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(72, 41);
            this.BtnUpdate.TabIndex = 22;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtMobileNomber
            // 
            this.txtMobileNomber.Location = new System.Drawing.Point(353, 145);
            this.txtMobileNomber.Name = "txtMobileNomber";
            this.txtMobileNomber.Size = new System.Drawing.Size(231, 22);
            this.txtMobileNomber.TabIndex = 21;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(353, 198);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(231, 55);
            this.txtAdress.TabIndex = 20;
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(217, 150);
            this.lblMobileNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(75, 17);
            this.lblMobileNumber.TabIndex = 19;
            this.lblMobileNumber.Text = "mobile No.";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(217, 203);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(52, 17);
            this.lblAdress.TabIndex = 18;
            this.lblAdress.Text = "Adress";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(353, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 22);
            this.txtName.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(217, 101);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.txtMobileNomber);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lblMobileNumber);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtMobileNomber;
        public System.Windows.Forms.TextBox txtAdress;
        public System.Windows.Forms.TextBox txtName;
    }
}