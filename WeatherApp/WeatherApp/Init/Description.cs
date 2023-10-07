using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Init
{
    internal class Description
    {
        public static Dictionary<int, string> DescriptionMapper = generationDescriptionDictionary();

        // "https://openweathermap.org/weather-conditions#How-to-get-icon-URL"
        public static Dictionary<int, string> generationDescriptionDictionary()
        {
            Dictionary<int, string> Description = new Dictionary<int, string>();
            Description.Add(200, "giông bão kèm theo mưa nhỏ");
            Description.Add(201, "giông bão có mưa");
            Description.Add(202, "giông bão kèm theo mưa lớn");
            Description.Add(210, "giông bão nhẹ");
            Description.Add(211, "giông");
            Description.Add(212, "giông bão lớn");
            Description.Add(221, "giông bão dữ dội");
            Description.Add(230, "giông bão kèm mưa phùn nhẹ");
            Description.Add(231, "giông bão kèm mưa phùn");
            Description.Add(232, "giông bão kèm mưa phùn lớn");
            Description.Add(300, "mưa phùn nhẹ");
            Description.Add(301, "mưa phùn");
            Description.Add(302, "mưa phùn mạnh");
            Description.Add(310, "mưa phùn nhẹ");
            Description.Add(311, "mưa phùn");
            Description.Add(312, "mưa phùn mạnh");
            Description.Add(313, "mưa phùn");
            Description.Add(314, "mưa phùn mạnh");
            Description.Add(321, "mưa phùn dữ dội");
            Description.Add(500, "mưa nhẹ");
            Description.Add(501, "mưa vừa");
            Description.Add(502, "mưa to");
            Description.Add(503, "mưa rất to");
            Description.Add(504, "mưa cực to");
            Description.Add(511, "mưa lạnh");
            Description.Add(520, "mưa nhẹ có mưa phùn nhẹ");
            Description.Add(521, "mưa có mưa phùn");
            Description.Add(522, "mưa to có mưa phùn");
            Description.Add(531, "mưa dữ dội");
            Description.Add(600, "tuyết nhẹ");
            Description.Add(601, "tuyết");
            Description.Add(602, "tuyết to");
            Description.Add(611, "tuyết lạnh");
            Description.Add(612, "tuyết lạnh nhẹ");
            Description.Add(613, "tuyết lạnh");
            Description.Add(615, "mưa nhẹ và tuyết nhẹ");
            Description.Add(616, "mưa và tuyết");
            Description.Add(620, "mưa nhẹ có tuyết nhẹ");
            Description.Add(621, "mưa có tuyết");
            Description.Add(622, "mưa to có tuyết");
            Description.Add(701, "sương mù");
            Description.Add(711, "khói");
            Description.Add(721, "sương mù");
            Description.Add(731, "cát và bụi xoáy");
            Description.Add(741, "sương mù");
            Description.Add(751, "cát");
            Description.Add(761, "bụi");
            Description.Add(762, "tro núi lửa");
            Description.Add(771, "giông gió");
            Description.Add(781, "vòi rồng");
            Description.Add(800, "trời quang");
            Description.Add(801, "ít mây");
            Description.Add(802, "mây phân tán");
            Description.Add(803, "nhiều mây");
            Description.Add(804, "mây u ám");


            return Description;
        }
    }
}
