
namespace ConactAppp
{
    partial class AddUser
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
            this.txtMobileNomber = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMobileNomber
            // 
            this.txtMobileNomber.Location = new System.Drawing.Point(349, 83);
            this.txtMobileNomber.Name = "txtMobileNomber";
            this.txtMobileNomber.Size = new System.Drawing.Size(231, 22);
            this.txtMobileNomber.TabIndex = 14;
            this.txtMobileNomber.Validating += new System.ComponentModel.CancelEventHandler(this.txtMobileNomber_Validating);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(349, 136);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(231, 55);
            this.txtAdress.TabIndex = 13;
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(213, 88);
            this.lblMobileNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(75, 17);
            this.lblMobileNumber.TabIndex = 12;
            this.lblMobileNumber.Text = "mobile No.";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(213, 141);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(52, 17);
            this.lblAdress.TabIndex = 11;
            this.lblAdress.Text = "Adress";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(349, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 22);
            this.txtName.TabIndex = 10;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(213, 39);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(216, 228);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 277);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtMobileNomber);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lblMobileNumber);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMobileNomber;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}