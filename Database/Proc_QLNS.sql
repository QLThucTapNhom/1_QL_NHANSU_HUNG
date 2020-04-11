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

-- Thủ tục tính lương nhân viên

CREATE PROC TinhLuongNhanVien AS
BEGIN
      SELECT NV.MaPB, PB.TenPB, NV.MaNV, NV.HoDemNV, NV.TenNV,NV.ChucVu,L.LuongCB ,L.HSLuong,L.HSPhuCap, 
	  L.LuongCB*L.HSLuong+L.LuongCB*L.HSPhuCap AS TongLuong, (L.LuongCB*L.HSLuong+L.LuongCB*L.HSPhuCap)*0.05 AS Thue,
	  (L.LuongCB*L.HSLuong+L.LuongCB*L.HSPhuCap)-(L.LuongCB*L.HSLuong+L.LuongCB*L.HSPhuCap) * 0.05 AS ThucLinh
      FROM dbo.HoSoNV NV, dbo.PhongBan PB, dbo.Luong L
      WHERE NV.MaPB=PB.MaPB
      AND NV.MaLuong=L.MaLuong
END

--DROP PROCEDURE TinhLuongNhanVien

--EXEC.TinhLuongNhanVien

--- Tìm kiếm theo nhân viên
CREATE PROC TimKiemMaNV @MaNV NCHAR(20) AS
BEGIN
   SELECT NV.MaNV,NV.HoDemNV, NV.TenNV, TT.GioiTinh, TT.NgaySinh, PB.TenPB , NV.ChucVu,NV.NgayKyHD, 
   NV.NgayHetHanHD, BHXH.MaBHXH AS BHXH, BHXH.NgayCapSo
   FROM dbo.HoSoNV NV, dbo.CDBaoHiemXaHoi BHXH, dbo.TTNhanVienCoBan TT, dbo.PhongBan PB
   WHERE NV.MaNV=TT.MaNV
   AND NV.MaNV=BHXH.MaNV
   AND NV.MaPB=PB.MaPB
   AND NV.MaNV=@MaNV
END

--DROP PROCEDURE TimKiemMaNV

--EXEC.TimKiemMaNV @MaNV='NV01'