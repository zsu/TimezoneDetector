using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TimezoneDetector
{
	public class TimezoneDetectorUtil
	{
		public const string CookieKeyTimezoneId = "timezoneid";
		public static string GetClientTimeZone()
		{
			string timezoneId = null;
			try
			{
				if (HttpContext.Current != null && HttpContext.Current.Request != null && HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies.AllKeys.Contains(CookieKeyTimezoneId))
					timezoneId = HttpContext.Current.Server.UrlDecode(HttpContext.Current.Request.Cookies[CookieKeyTimezoneId].Value);
				var windowsTimeZone = IanaToWindows(timezoneId);
				if (!string.IsNullOrEmpty(windowsTimeZone))
				{
					return windowsTimeZone;
				}
			}
			catch (Exception exception)
			{
				//Logger.Log(LogLevel.Error, string.Format("Invalid timezone {0}", timezoneId), exception);
				throw new Exception(string.Format("Invalid timezone {0}", timezoneId),exception);
			}
			return null;
		}
		private static string IanaToWindows(string ianaZoneId)
		{
			var tzdbSource = NodaTime.TimeZones.TzdbDateTimeZoneSource.Default;
			var mappings = tzdbSource.WindowsMapping.MapZones;
			var item = mappings.FirstOrDefault(x => x.TzdbIds.Contains(ianaZoneId));
			if (item == null) return null;
			return item.WindowsId;
		}
	}
}
