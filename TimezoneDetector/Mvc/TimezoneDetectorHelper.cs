using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TimezoneDetector
{
	public static class TimezoneDetectorHelper
	{
		public static TimezoneDetectorControl TimezoneDetector(this HtmlHelper helper)
		{
			return new TimezoneDetectorControl();
		}
	}
}
