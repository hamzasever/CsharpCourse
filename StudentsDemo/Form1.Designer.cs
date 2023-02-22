namespace StudentsDemo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwStudent = new System.Windows.Forms.DataGridView();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxnumUpdate = new System.Windows.Forms.TextBox();
            this.tbxLnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxFNameUpdate = new System.Windows.Forms.TextBox();
            this.lblNumUpdate = new System.Windows.Forms.Label();
            this.lblLNameUpdate = new System.Windows.Forms.Label();
            this.lblFnameUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwStudent
            // 
            this.dgwStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudent.Location = new System.Drawing.Point(34, 61);
            this.dgwStudent.Name = "dgwStudent";
            this.dgwStudent.Size = new System.Drawing.Size(662, 150);
            this.dgwStudent.TabIndex = 0;
            this.dgwStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudent_CellClick);
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(31, 261);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(57, 13);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "First Name";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(31, 308);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(58, 13);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Last Name";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(31, 353);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Number";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(108, 254);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(114, 20);
            this.tbxFirstName.TabIndex = 4;
            // 
            // tbxLastname
            // 
            this.tbxLastname.Location = new System.Drawing.Point(108, 301);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(114, 20);
            this.tbxLastname.TabIndex = 5;
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(108, 346);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(114, 20);
            this.tbxNumber.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(108, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(573, 394);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 29);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxnumUpdate
            // 
            this.tbxnumUpdate.Location = new System.Drawing.Point(573, 350);
            this.tbxnumUpdate.Name = "tbxnumUpdate";
            this.tbxnumUpdate.Size = new System.Drawing.Size(114, 20);
            this.tbxnumUpdate.TabIndex = 13;
            // 
            // tbxLnameUpdate
            // 
            this.tbxLnameUpdate.Location = new System.Drawing.Point(573, 305);
            this.tbxLnameUpdate.Name = "tbxLnameUpdate";
            this.tbxLnameUpdate.Size = new System.Drawing.Size(114, 20);
            this.tbxLnameUpdate.TabIndex = 12;
            // 
            // tbxFNameUpdate
            // 
            this.tbxFNameUpdate.Location = new System.Drawing.Point(573, 258);
            this.tbxFNameUpdate.Name = "tbxFNameUpdate";
            this.tbxFNameUpdate.Size = new System.Drawing.Size(114, 20);
            this.tbxFNameUpdate.TabIndex = 11;
            // 
            // lblNumUpdate
            // 
            this.lblNumUpdate.AutoSize = true;
            this.lblNumUpdate.Location = new System.Drawing.Point(496, 357);
            this.lblNumUpdate.Name = "lblNumUpdate";
            this.lblNumUpdate.Size = new System.Drawing.Size(44, 13);
            this.lblNumUpdate.TabIndex = 10;
            this.lblNumUpdate.Text = "Number";
            // 
            // lblLNameUpdate
            // 
            this.lblLNameUpdate.AutoSize = true;
            this.lblLNameUpdate.Location = new System.Drawing.Point(496, 312);
            this.lblLNameUpdate.Name = "lblLNameUpdate";
            this.lblLNameUpdate.Size = new System.Drawing.Size(58, 13);
            this.lblLNameUpdate.TabIndex = 9;
            this.lblLNameUpdate.Text = "Last Name";
            // 
            // lblFnameUpdate
            // 
            this.lblFnameUpdate.AutoSize = true;
            this.lblFnameUpdate.Location = new System.Drawing.Point(496, 265);
            this.lblFnameUpdate.Name = "lblFnameUpdate";
            this.lblFnameUpdate.Size = new System.Drawing.Size(57, 13);
            this.lblFnameUpdate.TabIndex = 8;
            this.lblFnameUpdate.Text = "First Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxnumUpdate);
            this.Controls.Add(this.tbxLnameUpdate);
            this.Controls.Add(this.tbxFNameUpdate);
            this.Controls.Add(this.lblNumUpdate);
            this.Controls.Add(this.lblLNameUpdate);
            this.Controls.Add(this.lblFnameUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.tbxLastname);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.dgwStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStudent;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxnumUpdate;
        private System.Windows.Forms.TextBox tbxLnameUpdate;
        private System.Windows.Forms.TextBox tbxFNameUpdate;
        private System.Windows.Forms.Label lblNumUpdate;
        private System.Windows.Forms.Label lblLNameUpdate;
        private System.Windows.Forms.Label lblFnameUpdate;
    }
}

