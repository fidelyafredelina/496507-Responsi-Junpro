CREATE OR REPLACE FUNCTION ka_edit(
	_id_karyawan INT,
	_nama_karyawan VARCHAR(50),
	_id_dep INT,
	_id_jabatan INT
)
RETURNS INT AS
'
BEGIN
UPDATE karyawan
SET nama_karyawan = _nama_karyawan, _id_dep = id_dep, _id_jabatan = id_jabatan
WHERE id_karyawan = _id_karyawan;
IF FOUND THEN
	RETURN 1;
ELSE
	RETURN 0;
END IF;
END;
'
LANGUAGE PLPGSQL;