using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DKC.Data.Helper
{
    public static class Helper
    {
        //public static List<DanhMucModel> GetEnums(Type e)
        //{
        //    var list = new List<DanhMucModel>();
        //    Array values = System.Enum.GetValues(e);
        //    //var array = Enum.GetValues(e).Cast<int>().Select(k => new DanhMucModel { Id = k, Ten = GetEnumDescription(k, e) }).ToList();
        //    foreach (int val in values)
        //    {
        //        string description = "";
        //        var memInfo = e.GetMember(e.GetEnumName(val));
        //        var descriptionAttributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
        //        description = descriptionAttributes.Length > 0 ? ((DescriptionAttribute)descriptionAttributes[0]).Description : val.ToString();
        //        list.Add(new DanhMucModel() { Id = val, Ten = description });
        //    }
        //    return list;
        //}
        public static string GetEnumDescription(this int value, Type e)
        {
            string description = null;
            Array values = Enum.GetValues(e);
            foreach (int val in values)
            {
                if (val != value) continue;
                var memInfo = e.GetMember(e.GetEnumName(val));
                var descriptionAttributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                description = descriptionAttributes.Length > 0 ? ((DescriptionAttribute)descriptionAttributes[0]).Description : val.ToString();
                break;
            }
            return description;
        }

        public static string SinhMa(string chuoibatdau,string chuoiketthuc,string kytunoi = "0", int dodai = 6)
        {
            var kytunoi_length = dodai - chuoibatdau.Length - chuoiketthuc.Length;
            if (kytunoi_length <=0)  return chuoibatdau + chuoiketthuc;
            var chuoinoi = kytunoi;
            for (int i = 0; i < kytunoi_length-1; i++)
            {
                chuoinoi += kytunoi;
            }
            return chuoibatdau + chuoinoi + chuoiketthuc;
        }

        public static string NumberToLaMa(int number)
        {
            string[] SoLaMa = {"I","II","III","IV","V","VI","VII","VIII","IX","X"
                ,"XI","XII","XIII","XIV","XV","XVI","XVII","XVIII","XIV","XX"
                ,"XXI","XXII","XXIII","XXIV","XXV","XXVI","XXVII","XXVIII","XXIX","XXX"};
            return SoLaMa[number];
        }

        #region Đọc số ra chữ
        private static string join_unit(string n)
        {
            int sokytu = n.Length;
            int sodonvi = (sokytu % 3 > 0) ? (sokytu / 3 + 1) : (sokytu / 3);
            n = n.PadLeft(sodonvi * 3, '0');
            sokytu = n.Length;
            string chuoi = "";
            int i = 1;
            while (i <= sodonvi)
            {
                if (i == sodonvi) chuoi = join_number((int.Parse(n.Substring(sokytu - (i * 3), 3))).ToString()) + unit(i) + chuoi;
                else chuoi = join_number(n.Substring(sokytu - (i * 3), 3)) + unit(i) + chuoi;
                i += 1;
            }
            return chuoi;
        }
        private static string join_number(string n)
        {
            string chuoi = "";
            int i = 1, j = n.Length;
            while (i <= j)
            {
                if (i == 1) chuoi = convert_number(n.Substring(j - i, 1)) + chuoi;
                else if (i == 2) chuoi = convert_number(n.Substring(j - i, 1)) + " mươi " + chuoi;
                else if (i == 3) chuoi = convert_number(n.Substring(j - i, 1)) + " trăm " + chuoi;
                i += 1;
            }
            return chuoi;
        }
        private static string convert_number(string n)
        {
            string chuoi = "";
            if (n == "0") chuoi = "không";
            else if (n == "1") chuoi = "một";
            else if (n == "2") chuoi = "hai";
            else if (n == "3") chuoi = "ba";
            else if (n == "4") chuoi = "bốn";
            else if (n == "5") chuoi = "năm";
            else if (n == "6") chuoi = "sáu";
            else if (n == "7") chuoi = "bảy";
            else if (n == "8") chuoi = "tám";
            else if (n == "9") chuoi = "chín";
            return chuoi;
        }
        private static string replace_special_word(string chuoi)
        {
            chuoi = chuoi.Replace("không mươi không ", "");
            chuoi = chuoi.Replace("không mươi", "lẻ");
            chuoi = chuoi.Replace("i không", "i");
            chuoi = chuoi.Replace("i năm", "i lăm");
            chuoi = chuoi.Replace("một mươi", "mười");
            chuoi = chuoi.Replace("mươi một", "mươi mốt");
            return chuoi;
        }
        private static string unit(int n)
        {
            string chuoi = "";
            if (n == 1) chuoi = "";
            else if (n == 2) chuoi = " nghìn ";
            else if (n == 3) chuoi = " triệu ";
            else if (n == 4) chuoi = " tỷ ";
            else if (n == 5) chuoi = " nghìn tỷ ";
            else if (n == 6) chuoi = " triệu tỷ ";
            else if (n == 7) chuoi = " tỷ tỷ ";
            return chuoi;
        }

        /// <summary>
        /// Viết hoa chữ cái đầu
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string VietHoaChuCaiDau(string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            if (value.Length == 1)
                return value.ToUpper();

            return string.Concat(char.ToUpper(value[0]), value.Substring(1).ToLower());
        }

        public static string DocSo(string _number)
        {
            return replace_special_word(join_unit(_number)).Trim();
        }

        public static string VietHoa(string s)
        {
            if (String.IsNullOrEmpty(s))
                return s;

            string result = "";

            //lấy danh sách các từ  

            string[] words = s.Split(' ');

            foreach (string word in words)
            {
                // từ nào là các khoảng trắng thừa thì bỏ  
                if (word.Trim() != "")
                {
                    if (word.Length > 1)
                        result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    else
                        result += word.ToUpper() + " ";
                }

            }
            return result.Trim();
        }

        #endregion
    }
}
