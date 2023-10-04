using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace WeatherApp.Init
{
    class Areas
    {
        public static string[] areas = { "Sa Pa","Hanoi","Hoa Binh","Hung Yen","Ha Tinh","HaiPhong","Ha Long","Thanh Hoa","Vinh","Kwuang Binh","Hue","Turan","Quang Ngai","Qui Nhon",
            "Tuy Hoa","Nha Trang","Phan Thiet","Da Lat","Vung Tau","Ho Chi Minh City","Tan An","Cao Lanh","Vinh Long","Bac Lieu","Ca Mau"};
        public static Dictionary<string, string> areasMapper = generationAreaDictionary();
        public static Dictionary<string, string> generationAreaDictionary()
        {
            Dictionary<string, string> areasMapper = new Dictionary<string, string>();
            areasMapper.Add("Sa Pa", "Sa Pa");
            areasMapper.Add("Hanoi", "Hà Nội");
            areasMapper.Add("Hoa Binh", "Hòa Bình");
            areasMapper.Add("Hung Yen", "Hưng Yên");
            areasMapper.Add("Ha Tinh", "Hà Tĩnh");
            areasMapper.Add("HaiPhong", "Hải Phòng");
            areasMapper.Add("Ha Long", "Hạ Long");
            areasMapper.Add("Thanh Hoa", "Thanh Hóa");
            areasMapper.Add("Vinh", "Vinh");
            areasMapper.Add("Kwuang Binh", "Quảng Bình");
            areasMapper.Add("Hue", "Huế");
            areasMapper.Add("Turan", "Đà Nẵng");
            areasMapper.Add("Quang Ngai", "Quảng Ngãi");
            areasMapper.Add("Qui Nhon", "Quy Nhơn");
            areasMapper.Add("Tuy Hoa", "Tuy Hòa");
            areasMapper.Add("Nha Trang", "Nha Trang");
            areasMapper.Add("Phan Thiet", "Phan Thiết");
            areasMapper.Add("Da Lat", "Đà Lạt");
            areasMapper.Add("Vung Tau", "Vũng Tàu");
            areasMapper.Add("Ho Chi Minh City", "TP.Hồ Chí Minh");
            areasMapper.Add("Tan An", "Tân An");
            areasMapper.Add("Cao Lanh", "Cao Lãnh");
            areasMapper.Add("Vinh Long", "Vĩnh Long");
            areasMapper.Add("Bac Lieu", "Bạc Liêu");
            areasMapper.Add("Ca Mau", "Cà Mau");

            return areasMapper;
        }
        public static Dictionary<string, string> areasMapperImg = generationAreaDictionaryImg();
        public static Dictionary<string, string> generationAreaDictionaryImg()
        {
            Dictionary<string, string> areasMapper = new Dictionary<string, string>();
            areasMapper.Add("Sa Pa", "sapa.jpg");
            areasMapper.Add("Hanoi", "hanoi.jpg");
            areasMapper.Add("Hoa Binh", "hoabinh.jpg");
            areasMapper.Add("Hung Yen", "hungyen.jpg");
            areasMapper.Add("Ha Tinh", "hatinh.jpg");
            areasMapper.Add("HaiPhong", "haiphong.jpg");
            areasMapper.Add("Ha Long", "halong.jpg");
            areasMapper.Add("Thanh Hoa", "thanhhoa.jpg");
            areasMapper.Add("Vinh", "nghean.jpg");
            areasMapper.Add("Kwuang Binh", "KwuangBinh.jpg");
            areasMapper.Add("Hue", "hue.jpg");
            areasMapper.Add("Turan", "danang.jpg");
            areasMapper.Add("Quang Ngai", "quangngai.jpg");
            areasMapper.Add("Qui Nhon", "binhdinh.jpg");
            areasMapper.Add("Tuy Hoa", "phuyen.png");
            areasMapper.Add("Nha Trang", "nhatrang.jpg");
            areasMapper.Add("Phan Thiet", "phanthiet.jpg");
            areasMapper.Add("Da Lat", "dalat.jpeg");
            areasMapper.Add("Vung Tau", "vungtau.jpg");
            areasMapper.Add("Ho Chi Minh City", "hochiminh.jpg");
            areasMapper.Add("Tan An", "longan.jpg");
            areasMapper.Add("Cao Lanh", "dongthap.jpg");
            areasMapper.Add("Vinh Long", "vinhlong.jpg");
            areasMapper.Add("Bac Lieu", "baclieu.jpg");
            areasMapper.Add("Ca Mau", "camau.jpg");

            return areasMapper;
        }
    }
}
