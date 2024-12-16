CREATE OR REPLACE FUNCTION ka_insert(
		_nama_karyawan VARCHAR(50),
		_id_dep INT,
		_id_jabatan INT
) 
RETURNS INT AS 
'
BEGIN
INSERT INTO karyawan (nama_karyawan, id_dep, id_jabatan) VALUES (_nama_karyawan, _id_dep, id_jabatan)
IF THEN
	RETURN 1;
ELSE
	RETURN 0;
END IF;
END;
'
LANGUAGE PGPSQL