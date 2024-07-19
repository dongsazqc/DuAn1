﻿using System;
using System.Collections.Generic;

namespace PRL.Models;

public partial class HoaDonChiTiet
{
    public int HoaDonChiTietId { get; set; }

    public int? HoaDonId { get; set; }

    public int? SanPhamId { get; set; }

    public string? MaSanPham { get; set; }

    public int SoLuong { get; set; }

    public decimal Gia { get; set; }

    public decimal? GiamGia { get; set; }

    public virtual HoaDon? HoaDon { get; set; }

    public virtual SanPham? SanPham { get; set; }
}