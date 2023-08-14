using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constanst
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz.";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        internal static string AuthorizationDenied;

        public static string CarNameInvalid { get; internal set; }
    }
}
