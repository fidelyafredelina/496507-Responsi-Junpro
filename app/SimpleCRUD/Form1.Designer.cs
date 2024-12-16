namespace SimpleCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvKaryawan = new DataGridView();
            tbNamaKaryawan = new TextBox();
            cbDepartemen = new ComboBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            lbKaryawan = new Label();
            lbDepartemen = new Label();
            cbJabatan = new ComboBox();
            lbJabatan = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).BeginInit();
            SuspendLayout();
            // 
            // dgvKaryawan
            // 
            dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKaryawan.Location = new Point(12, 223);
            dgvKaryawan.Name = "dgvKaryawan";
            dgvKaryawan.Size = new Size(776, 215);
            dgvKaryawan.TabIndex = 0;
            dgvKaryawan.CellClick += dgvKaryawan_CellClick;
            // 
            // tbNamaKaryawan
            // 
            tbNamaKaryawan.Location = new Point(216, 36);
            tbNamaKaryawan.Name = "tbNamaKaryawan";
            tbNamaKaryawan.Size = new Size(194, 23);
            tbNamaKaryawan.TabIndex = 1;
            // 
            // cbDepartemen
            // 
            cbDepartemen.FormattingEnabled = true;
            cbDepartemen.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDepartemen.Location = new Point(216, 80);
            cbDepartemen.Name = "cbDepartemen";
            cbDepartemen.Size = new Size(194, 23);
            cbDepartemen.TabIndex = 2;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 168);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(115, 35);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(216, 168);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 35);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(427, 168);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(673, 168);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(115, 35);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lbKaryawan
            // 
            lbKaryawan.AutoSize = true;
            lbKaryawan.Location = new Point(23, 44);
            lbKaryawan.Name = "lbKaryawan";
            lbKaryawan.Size = new Size(93, 15);
            lbKaryawan.TabIndex = 7;
            lbKaryawan.Text = "Nama Karyawan";
            // 
            // lbDepartemen
            // 
            lbDepartemen.AutoSize = true;
            lbDepartemen.Location = new Point(23, 83);
            lbDepartemen.Name = "lbDepartemen";
            lbDepartemen.Size = new Size(85, 15);
            lbDepartemen.TabIndex = 8;
            lbDepartemen.Text = "Dep. Karyawan";
            // 
            // cbJabatan
            // 
            cbJabatan.FormattingEnabled = true;
            cbJabatan.Items.AddRange(new object[] { "Intern", "Employee", "Manager" });
            cbJabatan.Location = new Point(216, 124);
            cbJabatan.Name = "cbJabatan";
            cbJabatan.Size = new Size(194, 23);
            cbJabatan.TabIndex = 9;
            // 
            // lbJabatan
            // 
            lbJabatan.AutoSize = true;
            lbJabatan.Location = new Point(23, 127);
            lbJabatan.Name = "lbJabatan";
            lbJabatan.Size = new Size(81, 15);
            lbJabatan.TabIndex = 10;
            lbJabatan.Text = "Jab. Karyawan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbJabatan);
            Controls.Add(cbJabatan);
            Controls.Add(lbDepartemen);
            Controls.Add(lbKaryawan);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(cbDepartemen);
            Controls.Add(tbNamaKaryawan);
            Controls.Add(dgvKaryawan);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKaryawan;
        private TextBox tbNamaKaryawan;
        private ComboBox cbDepartemen;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnLoad;
        private Label lbKaryawan;
        private Label lbDepartemen;
        private ComboBox cbJabatan;
        private Label lbJabatan;
    }
}
