using ChanhThuStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChanhThuStore.Models.BUS
{
    public class ChanhThuStoreBUS
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new ChanhThuStoreDB();
            return db.Query<SanPham>("Select * from SanPham where TinhTrang = 1");
        }
        public static SanPham ChiTiet(String a)
        {
            var db = new ChanhThuStoreDB();
            return db.SingleOrDefault<SanPham>("select * from SanPham where MaSanPham = @0 ", a);
        }
    }
}