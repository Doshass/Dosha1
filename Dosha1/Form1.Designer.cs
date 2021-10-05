
namespace Dosha1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvklients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDobavit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvklients)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "knopka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgvklients
            // 
            this.dgvklients.AllowUserToAddRows = false;
            this.dgvklients.AllowUserToDeleteRows = false;
            this.dgvklients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvklients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvklients.Location = new System.Drawing.Point(91, 31);
            this.dgvklients.Name = "dgvklients";
            this.dgvklients.ReadOnly = true;
            this.dgvklients.Size = new System.Drawing.Size(441, 150);
            this.dgvklients.TabIndex = 1;
            this.dgvklients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvklients_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "логин";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "пароль";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btDobavit
            // 
            this.btDobavit.Location = new System.Drawing.Point(231, 202);
            this.btDobavit.Name = "btDobavit";
            this.btDobavit.Size = new System.Drawing.Size(124, 48);
            this.btDobavit.TabIndex = 2;
            this.btDobavit.Text = "button2";
            this.btDobavit.UseVisualStyleBackColor = true;
            this.btDobavit.Click += new System.EventHandler(this.btDobavit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(380, 202);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(125, 48);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 290);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btDobavit);
            this.Controls.Add(this.dgvklients);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvklients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvklients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btDobavit;
        private System.Windows.Forms.Button Delete;
    }
}

