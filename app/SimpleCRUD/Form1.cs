using Npgsql;
using System.Data;

namespace SimpleCRUD
{
    // Form1 inherits Form
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connString = "Host=localhost;Port=5433;Username=postgres;Password=test123;Database=Responsi";
        NpgsqlConnection conn;
        string sql;
        NpgsqlCommand cmd;
        public DataTable dt;
        private DataGridViewRow row;

        // Functions use private access identifier so that only the Form1 class can access it. If there are other forms, they cannot access these functions.
        private void btnInsert_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                sql = @"select * from ka_insert(:_nama, :_id_dep, :_id_jabatan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNamaKaryawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDepartemen.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("_id_jabatan", cbJabatan.SelectedIndex + 1);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diinputkan!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNamaKaryawan.Clear();
                    cbDepartemen.SelectedIndex = -1;
                    cbJabatan.SelectedIndex = -1;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);

            if (row == null)
            {
                MessageBox.Show("Pilih baris terlebih dahulu!", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();
                sql = @"select * from ka_edit(:_id_karyawan, :_nama, :_id_dep, :_id_jabatan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", Convert.ToInt32(row.Cells["_id_karyawan"].Value));
                cmd.Parameters.AddWithValue("_nama", tbNamaKaryawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDepartemen.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("_id_jabatan", cbJabatan.SelectedIndex + 1);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diubah!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNamaKaryawan.Clear();
                    cbDepartemen.SelectedIndex = -1;
                    cbJabatan.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);

            if (row == null)
            {
                MessageBox.Show("Pilih baris terlebih dahulu!", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();
                sql = @"select * from ka_delete(:_id_karyawan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", Convert.ToInt32(row.Cells["_id_karyawan"].Value));

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil dihapus!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNamaKaryawan.Clear();
                    cbDepartemen.SelectedIndex = -1;
                    cbJabatan.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                dgvKaryawan.DataSource = null;
                sql = "select * from ka_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgvKaryawan.DataSource = dt;
                conn.Close();   
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                row = dgvKaryawan.Rows[e.RowIndex];
                tbNamaKaryawan.Text = row.Cells["_nama_karyawan"].Value.ToString();
                cbDepartemen.SelectedIndex = Convert.ToInt32(row.Cells["_id_dep"].Value) - 1;
                cbJabatan.SelectedIndex = Convert.ToInt32(row.Cells["_id_jabatan"].Value) - 1;
            }
        }
    }
}
