USE TTN_QLNHANSU_01

---Thu tuc can cho bai quanlynhansu


CREATE PROC DEL_HoSoNV @MaNV NCHAR(20) AS
BEGIN
  DELETE FROM dbo.TTNhanVienCoBan WHERE MaNV=@MaNV
  DELETE FROM dbo.CDBaoHiemXaHoi WHERE MaNV=@MaNV
  DELETE FROM dbo.CDThaiSan WHERE MaNV=@MaNV
  UPDATE dbo.PhongBan SET MaTruongPhong=NULL WHERE MaTruongPhong=@MaNV
  DELETE FROM dbo.HoSoNV WHERE MaNV=@MaNV
   
END

--EXEC dbo.DEL_HoSoNV @MaNV =N''

---Thủ tục xóa một bậc lương

CREATE PROC DEL_Luong @MaLuong NCHAR(20) AS
BEGIN
  UPDATE dbo.HoSoNV SET MaLuong=NULL WHERE MaLuong=@MaLuong 
  DELETE FROM dbo.Luong WHERE MaLuong=@MaLuong
END

-- Thủ tục xóa 1 Phòng Ban
CREATE PROC DEL_PB @MaPB NCHAR(20) AS
BEGIN
  UPDATE dbo.HoSoNV SET MaPB=NULL WHERE MaPB=@MaPB 
  UPDATE dbo.CDThaiSan SET MaPB=NULL WHERE MaPB=@MaPB 
  DELETE FROM dbo.PhongBan WHERE MaPB=@MaPB
END
