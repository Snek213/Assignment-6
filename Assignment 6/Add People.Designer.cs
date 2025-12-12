
namespace Assignment_6
{
    partial class frmAddPeople
    {
       
        private System.ComponentModel.IContainer components = null;

      
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
            lblName = new Label();
            txtAddName = new TextBox();
            lblPhone = new Label();
            txtAddPhone = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(83, 55);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "&Name";
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(83, 78);
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(125, 27);
            txtAddName.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(83, 170);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "&Phone";
            // 
            // txtAddPhone
            // 
            txtAddPhone.Location = new Point(83, 202);
            txtAddPhone.Name = "txtAddPhone";
            txtAddPhone.Size = new Size(125, 27);
            txtAddPhone.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(83, 290);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 4;
            btnOk.Text = "&Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(83, 351);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddPeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtAddPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtAddName);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddPeople";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Person";
            Load += frmAddPeople_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtAddName;
        private Label lblPhone;
        private TextBox txtAddPhone;
        private Button btnOk;
        private Button btnCancel;
        
    }
}