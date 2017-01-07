using System;
using System.Web;
using System.Collections.Generic;
using System.Text;

namespace TimezoneDetector
{
	public class TimezoneDetectorControl : IHtmlString
    {
		private string RenderScript()
		{
			StringBuilder scripts = new StringBuilder();
			scripts.AppendLine("<script type='text/javascript'>");
			scripts.AppendLine(@"$().ready(function () {
	setTimezoneCookie();
});
function setTimezoneCookie() {

    var timezone_cookie = 'timezoneid';

    // if the timezone cookie not exists create one.
    if (!$.cookie(timezone_cookie)) {

        //// check if the browser supports cookie
        //var test_cookie = 'test cookie';
        //$.cookie(test_cookie, true);

        //// browser supports cookie
        //if ($.cookie(test_cookie)) {

        // delete the test cookie
        //$.cookie(test_cookie, null);

        // create a new cookie
        $.cookie(timezone_cookie, jstz.determine().name(), { path: '/' });

        // re-load the page
        location.reload();
        //}
    }
        // if the current timezone and the one stored in cookie are different
        // then store the new timezone in the cookie and refresh the page.
    else {

        var storedTimezone = $.cookie(timezone_cookie);
        var currentTimezone = jstz.determine().name();

        // user may have changed the timezone
        if (storedTimezone !== currentTimezone) {
            $.cookie(timezone_cookie, currentTimezone, { path: '/' });
            location.reload();
        }
    }
}");
			scripts.AppendLine("</script>");
			return scripts.ToString();
		}
		public override string ToString()
		{
			var content = new StringBuilder();
			content.AppendLine(RenderScript());
			return content.ToString();
		}
		public string ToHtmlString()
		{
			return ToString();
		}
    }
}