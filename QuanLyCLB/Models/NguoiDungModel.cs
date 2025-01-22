﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Models
{
    public class NguoiDungModel : Model<NguoiDungModel>
    {
        public const string QuyenHan_Admin = "Q-Admin";
        public const string QuyenHan_User = "Q-User";
        public NguoiDungModel() { }

        public string MaNguoiDung { get; set; }
        public string Ho { get; set; }
        public string Lot { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string MSSV { get; set; }
        public string MaQuyenHan { get; set; }
        public string TenQuyenHan { get; private set; }
        public string TenDangNhap { get; set; }
        [Browsable(false)]
        public string MatKhau { get; set; }
        [Browsable(false)]
        public string MaBaoMat { get; set; }
        public Stream AnhDaiDien { get; set; } // nullable
        public DateTime ThoiGianTao { get; set; }
        public CheDoDuyet Duyet { get; set; }

        [Browsable(false)]
        public string HoTen { get { return $"{Ho}{(string.IsNullOrEmpty(Lot) ? "" : $" {Lot}")} {Ten}"; } }
        [Browsable(false)]
        public string GioiTinhChuoi { get { return GioiTinh ? "Nữ" : "Nam"; } }
        [Browsable(false)]
        public string NgaySinhChuoi { get { return NgaySinh.ToString("dd/MM/yyyy"); } }
        [Browsable(false)]
        public string NgayTaoChuoi { get { return ThoiGianTao.ToString("dd/MM/yyyy"); } }

        public override string ToString()
        {
            return MaNguoiDung;
        }

        public override NguoiDungModel FromDataReader(SqlDataReader reader)
        {
            List<string> columns = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
                columns.Add(reader.GetName(i));
            if (columns.Contains("MaNguoiDung"))
                MaNguoiDung = reader.GetString(reader.GetOrdinal("MaNguoiDung"));
            if (columns.Contains("Ho"))
                Ho = reader.GetString(reader.GetOrdinal("Ho"));
            if (columns.Contains("Lot"))
                Lot = reader.GetString(reader.GetOrdinal("Lot"));
            if (columns.Contains("Ten"))
                Ten = reader.GetString(reader.GetOrdinal("Ten"));
            if (columns.Contains("SDT"))
                SDT = reader.GetString(reader.GetOrdinal("SDT"));
            if (columns.Contains("GioiTinh"))
                GioiTinh = reader.GetBoolean(reader.GetOrdinal("GioiTinh"));
            if (columns.Contains("NgaySinh"))
                NgaySinh = reader.GetDateTime(reader.GetOrdinal("NgaySinh"));
            if (columns.Contains("Email"))
                Email = reader.GetString(reader.GetOrdinal("Email"));
            if (columns.Contains("MSSV"))
                MSSV = reader.GetString(reader.GetOrdinal("MSSV"));
            if (columns.Contains("MaQuyenHan"))
                MaQuyenHan = reader.GetString(reader.GetOrdinal("MaQuyenHan"));
            if (columns.Contains("TenQuyenHan"))
                TenQuyenHan = reader.GetString(reader.GetOrdinal("TenQuyenHan"));
            if (columns.Contains("TenDangNhap"))
                TenDangNhap = reader.GetString(reader.GetOrdinal("TenDangNhap"));
            if (columns.Contains("MatKhau"))
                MatKhau = reader.GetString(reader.GetOrdinal("MatKhau"));
            if (columns.Contains("MaBaoMat"))
                MaBaoMat = reader.GetString(reader.GetOrdinal("MaBaoMat"));
            if (columns.Contains("AnhDaiDien"))
                AnhDaiDien = reader.IsDBNull(reader.GetOrdinal("AnhDaiDien")) ? null : reader.GetStream(reader.GetOrdinal("AnhDaiDien"));
            if (columns.Contains("ThoiGianTao"))
                ThoiGianTao = reader.GetDateTime(reader.GetOrdinal("ThoiGianTao"));
            if (columns.Contains("Duyet"))
                Duyet = (CheDoDuyet)reader.GetByte(reader.GetOrdinal("Duyet"));
            return this;
        }
    }

    public enum CheDoDuyet
    {
        ChuaDuyet, DuocDuyet, TuChoi
    }
}
