using System.Data;
using System.Globalization;
using System.Reflection;

namespace mhmdhidry
{
    public static partial class Extensions
    {
        public static partial class ExtendingCultureInfo
        {
            static void Main(string[] args)
            {
                var culture = new CultureInfo("en-us");
                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;
            }
        }
        public static string currency = "تومان";
        public static string free = "رایگان";
        public static List<T> ToList<T>(this DataTable dt)
        {
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
            var columnNames = dt.Columns.Cast<DataColumn>()
                .Select(c => c.ColumnName)
                .ToList();
            var objectProperties = typeof(T).GetProperties(flags);
            var targetList = dt.AsEnumerable().Select(dataRow =>
            {
                var instanceOfT = Activator.CreateInstance<T>();

                foreach (var properties in objectProperties.Where(properties => columnNames.Contains(properties.Name) && dataRow[properties.Name] != DBNull.Value))
                {
                    properties.SetValue(instanceOfT, dataRow[properties.Name], null);
                }
                return instanceOfT;
            }).ToList();

            return targetList;
        }
        public static DataTable ToDataTable<T>(this List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
        public static DateTime ToDateTime(this object value)
        {
            if (value == null) return default;
            DateTime date = DateTime.Parse(value.ToString(), new CultureInfo("fa-IR"));
            return date;
        }
        public static string ToShamsi(this object value)
        {
            if (value == null) return string.Empty;
            if (value == default) return string.Empty;
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(Convert.ToDateTime(value)) + "/" + pc.GetMonth(Convert.ToDateTime(value)).ToString("00") + "/" +
                   pc.GetDayOfMonth(Convert.ToDateTime(value)).ToString("00");
        }
        public static string ToShamsiFull(this object value)
        {
            if (value == null) return string.Empty;
            if (value == default) return string.Empty;
            PersianCalendar pc = new PersianCalendar();
            string date = pc.GetYear(Convert.ToDateTime(value)) + "/" + pc.GetMonth(Convert.ToDateTime(value)).ToString("00") + "/" +
                   pc.GetDayOfMonth(Convert.ToDateTime(value)).ToString("00") + " " +
                   pc.GetHour(Convert.ToDateTime(value)).ToString("00") + ":" +
                   pc.GetMinute(Convert.ToDateTime(value)).ToString("00") + ":" +
                   pc.GetSecond(Convert.ToDateTime(value)).ToString("00");
            DateTime Date = Convert.ToDateTime(date);
            return Date.ToString();
        }
        public static string ToShamsiDateTime(this object value)
        {
            try
            {
                if (value == null) return string.Empty;
                if (value == default) return string.Empty;
                PersianCalendar pc = new PersianCalendar();
                return
                       pc.GetYear(Convert.ToDateTime(value)) + "/" +
                       pc.GetMonth(Convert.ToDateTime(value)).ToString("00") + "/" +
                       pc.GetDayOfMonth(Convert.ToDateTime(value)).ToString("00") + " " +
                       pc.GetHour(Convert.ToDateTime(value)).ToString("00") + ":" +
                       pc.GetMinute(Convert.ToDateTime(value)).ToString("00") + ":" +
                       pc.GetSecond(Convert.ToDateTime(value)).ToString("00");
            }
            catch {
                return string.Empty;
            }
        }
        public static string ToMiladi(this object value)
        {
            if (value == null) return string.Empty;
            if (value == default) return string.Empty;
            return value.ToDateTime().ToString("yyyy/MM/dd");
        }
        public static string ToMiladiJson(this object value)
        {
            if (value == null) return string.Empty;
            if (value == default) return string.Empty;
            return Convert.ToDateTime(value).Year + "-" + Convert.ToDateTime(value).Month.ToString("00") + "-" + Convert.ToDateTime(value).Day.ToString("00") + "T" + Convert.ToDateTime(value).Hour.ToString("00") + ":" + Convert.ToDateTime(value).Minute.ToString("00") + ":" + Convert.ToDateTime(value).Second.ToString("00") + ".000Z";
        }
        public static DateTime ToDate(this string value)
        {
            if (value == null) return default;
            return Convert.ToDateTime(value.ToMiladi());
        }
        public static string ToTime(this object value)
        {
            if (value == null) return string.Empty;
            if (value == default) return string.Empty;
            PersianCalendar pc = new PersianCalendar();
            return pc.GetHour(Convert.ToDateTime(value)).ToString("00") + ":" +
                   pc.GetMinute(Convert.ToDateTime(value)).ToString("00") + ":" +
                   pc.GetSecond(Convert.ToDateTime(value)).ToString("00");
        }
        public static int Week(this string value)
        {
            if (value == null) return 0;
            DateTime dt = DateTime.Parse(value, new CultureInfo("fa-IR"));
            return GetWeek(dt.DayOfWeek);
        }
        public static int WeekOfMonth(this string value)
        {
            if (value == null) return 0;
            DateTime dt = DateTime.Parse(value.Substring(0, 8) + "01", new CultureInfo("fa-IR"));
            return GetWeek(dt.DayOfWeek);
        }
        public static int GetWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Saturday:
                    return 1;
                case DayOfWeek.Sunday:
                    return 2;
                case DayOfWeek.Monday:
                    return 3;
                case DayOfWeek.Tuesday:
                    return 4;
                case DayOfWeek.Wednesday:
                    return 5;
                case DayOfWeek.Thursday:
                    return 6;
                case DayOfWeek.Friday:
                    return 7;
                default:
                    return 0;
            }
        }
        public static string ToShamsiWeek(this DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Saturday:
                    return "شنبه";
                case DayOfWeek.Sunday:
                    return "یکشنبه";
                case DayOfWeek.Monday:
                    return "دوشنبه";
                case DayOfWeek.Tuesday:
                    return "سه شنبه";
                case DayOfWeek.Wednesday:
                    return "چهارشنبه";
                case DayOfWeek.Thursday:
                    return "پنج شنبه";
                case DayOfWeek.Friday:
                    return "جمعه";
                default:
                    return "";
            }
        }
        public static bool IsLeap(this string value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.IsLeapYear(value.Substring(0, 4).ToInt());
        }
        public static string FullTime(this double seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"hh\:mm\:ss");
        }
        public static string ToFirstCharUpper(this object value)
        {
            char[] array = value.ToString().ToCharArray();
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
        public static string ToFirstCharLower(this object value)
        {
            char[] array = value.ToString().ToCharArray();
            if (array.Length >= 1)
            {
                if (char.IsUpper(array[0]))
                {
                    array[0] = char.ToLower(array[0]);
                }
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsUpper(array[i]))
                    {
                        array[i] = char.ToLower(array[i]);
                    }
                }
            }
            return new string(array);
        }
        public static string ToNumeric(string value, string[] except, bool hasNegative = false)
        {

            string number = string.Empty;
            string result = "0";
            for (int i = 0; i < value.Length; i++)
            {
                if (except == null)
                {
                    if (Char.IsDigit(value[i]) || (value[i].ToString().StartsWith("-") && hasNegative))
                        number += value[i];
                }
                else
                {
                    if (Char.IsDigit(value[i]) || (value[i].ToString().StartsWith("-") && hasNegative) || Contains(except, value[i].ToString()))
                        number += value[i];
                }
            }
            if (number.Length > 0)
                result = number;
            return result;
        }
        public static bool Contains(string[] array, string value)
        {
            foreach (string x in array)
            {
                if (value.Contains(x))
                    return true;
            }
            return false;
        }
        public static string ToNumber(this object value)
        {
            if (value == null) value = "0";
            return ToNumeric(value.ToString(), null);
        }
        public static bool ToBoolean(this object value)
        {
            if (value == null) return false;
            if (value.ToString().ToLower() == "on" || value.ToString().ToLower() == "true" || value.ToString().Substring(0, 1).ToInt() > 0)
                return true;
            else
                return false;
        }
        public static string ToCurrency(this object value) => value.ToLong().ToString("#,0");
        public static string Currency(this string value) => ToNumeric(value, new string[] { "," });
        public static string ToPriceCurrency(this object value) => value.ToLong() == 0 ? "0" : value.ToCurrency() + " " + currency;
        public static string ToPriceFree(this object value) => value.ToLong() == 0 ? free : value.ToCurrency();
        public static string ToFullPrice(this object value) => value.ToLong() == 0 ? free : value.ToCurrency() + " " + currency;
        public static int ToInt(this object value) => Convert.ToInt32(value.ToNumber());
        public static long ToLong(this object value) => Convert.ToInt64(value.ToNumber());
        public static decimal ToDecimal(this object value) => Convert.ToDecimal(value.ToNumber());
        public static bool IsNumeric(this string value) => int.TryParse(value, out int n);
    }
}