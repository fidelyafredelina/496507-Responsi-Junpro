CREATE TABLE departemen (
	id_dep SERIAL PRIMARY KEY,
	nama_dep VARCHAR(50)
);

CREATE TABLE jabatan (
	id_jabatan SERIAL PRIMARY KEY,
	nama_jabatan VARCHAR(50),
	salary NUMERIC(12,2)
);

CREATE TABLE karyawan (
	id_karyawan SERIAL PRIMARY KEY,
	nama_karyawan VARCHAR(50),
	id_dep FOREIGN KEY REFERENCES departemen(id_dep) ON DELETE CASCADE,
	id_jabatan FOREIGN KEY REFERENCES jabatan(id_jabatan) ON DELETE CASCADE
);