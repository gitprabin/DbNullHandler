using System;

namespace Fooditter.Library
{
    public static class PrabinNullHandler
    {
        /// <summary>
        /// Convert database value to DateTime or null  if DBNull   
        /// </summary>
        public static DateTime? DateTime(this object value)
        {
            if (value != DBNull.Value)
            {
                if (value == null)
                    return Convert.ToDateTime("1999/01/01");
                else
                    return Convert.ToDateTime(value);
            }
            else
            {
                return Convert.ToDateTime("1999/01/01");

            }
        }

        /// <summary>
        /// Convert database value to DateTime or defaultValue  if DBNull 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static DateTime? DateTime(this object value, DateTime defaultValue)
        {
            if (value != DBNull.Value)
            {
                return Convert.ToDateTime(value);
            }
            else
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// Only for Eng. Date like '2014-06-14 00:00:00.000'
        /// Returns Format like 'YYYY/MM/DD'
        /// </summary>
        public static string FormatDate(this object value)
        {
            try
            {
                DateTime dt = Convert.ToDateTime(value);
                string a = "";
                a = dt.Year + "/" + dt.Month.ToString().PadLeft(2, '0') + "/" + dt.Day.ToString().PadLeft(2, '0');
                return a;
            }
            catch (Exception)
            {
                return "";
            }
        }
        public static string FormatDecimal(this object value)
        {
            if (value != DBNull.Value)
            {
                try
                {
                    return Convert.ToDecimal(value).ToString("0.00");
                    // return string.Format("{0:0.00}", value);
                }
                catch { return "0.00"; }
            }
            else
            {
                return "0.00";
            }
        }
        public static string RemoveDrCr(this object value)
        {
            if (value != DBNull.Value)
            {
                try
                {
                    if (value.ToString().StartsWith("D"))
                        return value.ToString().Remove(0, 2);
                    else if (value.ToString().StartsWith("C"))
                        return value.ToString().Remove(0, 2);
                    else
                        return value.ToString();
                }
                catch { return ""; }
            }
            else
            {
                return "";
            }
        }
        public static decimal RoundOff(this object value)
        {
            if (value != DBNull.Value)
            {
                try
                {
                    return Math.Round(Convert.ToDecimal(value.ToString()));
                    // return string.Format("{0:0.00}", value);
                }
                catch { return 0; }
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Convert database value to int or defaultValue  if DBNull   
        /// </summary>
        public static int Int(this object value, int defaultValue)
        {
            try
            {
                if (value != DBNull.Value)
                {
                    return int.Parse(value.ToString());
                }
                else
                {
                    return defaultValue;
                }
            }
            catch { return defaultValue; }
        }

        /// <summary>
        /// Convert database value to Int32 or null  if DBNull   
        /// </summary>
        public static int? Int(this object value)
        {
            if (value != DBNull.Value)
            {
                try
                {
                    return int.Parse(value.ToString());
                }
                catch { return 0; }
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Convert database value to Int32 or null  if DBNull   
        /// </summary>
        public static Int32? Int32(this object value)
        {
            if (value != DBNull.Value)
            {
                try
                {
                    return Convert.ToInt32(value);
                }
                catch { return 0; }
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Convert database value to Int32 or null  if DBNull   contains .
        /// </summary>
        public static Int32? RemInt32(this object value)
        {
            if (value != DBNull.Value)
            {
                try
                {
                    if (value.ToString().Contains("."))
                        return Convert.ToInt32(value.ToString().Remove(value.ToString().IndexOf("."), 5));
                    else
                        return Convert.ToInt32(value);
                }
                catch { return 0; }
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Convert database value to Int32 or defaultValue  if DBNull   
        /// </summary>
        public static Int32 Int32(this object value, int defaultValue)
        {
            try
            {
                if (value != DBNull.Value)
                {
                    return Convert.ToInt32(value);
                }
                else
                {
                    return defaultValue;
                }
            }
            catch { return defaultValue; }
        }

        /// <summary>
        /// Convert database value to Int16 or null  if DBNull   
        /// </summary>
        public static Int16? Int16(this object value)
        {
            if (value != DBNull.Value)
            {
                return Convert.ToInt16(value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Convert database value to Double or null  if DBNull   
        /// </summary>
        public static Double? Double(this object value)
        {
            if (value != DBNull.Value)
            {
                try
                {
                    return Convert.ToDouble(value);
                }
                catch { return 0; }
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Convert database value to Decimal or null  if DBNull   
        /// </summary>
        public static Decimal? Decimal(this object value)
        {
            if (value != DBNull.Value)
            {
                try
                {
                    return Convert.ToDecimal(value);
                }
                catch { return 0; }
            }
            else
            {
                return 0;
            }
        }

        public static Decimal Decimal(this object value, decimal defaultValue)
        {
            try
            {
                if (value != DBNull.Value)
                {
                    return Convert.ToDecimal(value);
                }
                else
                {
                    return defaultValue;
                }
            }
            catch { return defaultValue; }
        }

        /// <summary>
        /// Convert database value to Boolean or false  if DBNull   
        /// </summary>
        public static Boolean Boolean(this object value)
        {
            if (Convert.ToString(value).Equals(""))
                return false;
            return value != DBNull.Value ? Convert.ToBoolean(value) : false;
        }


        /// <summary>
        /// Convert database value to String or empty string  if DBNull   
        /// </summary>
        public static string String(this object value)
        {
            try
            {
                if (value != DBNull.Value)
                {
                    return value.ToString();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }

        /// <summary>
        /// Convert database value to String or empty string  if DBNull   
        /// </summary>
        public static char? Char(this object value)
        {
            if (value != DBNull.Value)
            {
                return Convert.ToChar(value);
            }
            else
            {
                return null;
            }
        }

    }
}
