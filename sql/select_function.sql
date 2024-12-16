CREATE OR REPLACE FUNCTION ka_select() 
RETURNS TABLE (
	_id_karyawan INT,
	_id_dep INT,
	_id_jabatan INT,
	_nama_karyawan VARCHAR,
	_nama_dep VARCHAR,
	_nama_jabatan VARCHAR,
	_salary NUMERIC(12,2)
) AS
'
BEGIN
RETURN QUERY
SELECT id_karyawan, k.id_dep, k.id_jabatan,  nama_karyawan, nama_dep, nama_jabatan, salary 
	FROM karyawan k
	JOIN departemen d
	ON k.id_dep = d.id_dep
	JOIN jabatan j
	ON k.id_jabatan = j.id_jabatan;
END;
'
LANGUAGE PLPGSQL;