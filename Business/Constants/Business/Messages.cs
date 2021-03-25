using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Business
{
    public class Messages
    {
        //CarManager
        public static string CarAdded = "Araç başarıyla eklendi.";
        public static string CarDeleted = "Araç başarıyla silindi.";
        public static string CarUpdated = "Araç başarıyla güncellendi.";
        
        public static string CarsListed = "Araçlar Listelendi.";
        public static string CarListed = "Araç bulundu.";
        public static string CarListedForBrandId = "İstenilen markadaki araçlar listelendi.";
        public static string CarListedForColorId = "İstenilen renkteki araçlar listelendi.";

        //BrandManager
        public static string BrandsListed = "Markalar listelendi.";
        public static string BrandListed = "İstenilen marka araçlar listelendi.";

        public static string BrandAdded = "Yeni marka başarıyla eklendi.";
        public static string BrandDeleted = "Marka başarıyla silindi.";
        public static string BrandUpdated = "Marka başarıyla güncellendi.";

        //ColorManager
        public static string ColorsListed = "Araç renkleri listelendi.";
        public static string ColorListed = "İstenilen renkteki araçlar listelendi.";

        public static string ColorAdded = "Yeni renk başarıyla eklendi.";
        public static string ColorDeleted = "Renk başarıyla silindi.";
        public static string ColorUpdated = "Renk başarıyla güncellendi.";
    }
}
