using System;
namespace zepllin.Extra
{
    public static class UrlPaths
    {
        /*Zman İmzası*/
        #region
        private static long tickchange = DateTime.Now.Ticks;
        /*Zaman İmzası*/

        /*meta ve title*/
        public static string metadecription => "Review and vote on the work of professional and amateur photographers";

        public static string title => "Review Digital Photography And Works Vote | Zepllin";

        public static string canonicalurl => BaseUrl.baseurl;

        /*meta ve title*/
        public static string logo => BaseUrl.baseurl + $"Contents/img/logo.png?dt={tickchange}";

        public static string user => BaseUrl.baseurl + $"Contents/img/user.png?dt={tickchange}";
        /*fav icons*/
        public static string favicon180x180 => BaseUrl.baseurl + $"Contents/img/favicons/apple-touch-icon.png?dt={tickchange}";

        public static string favicon32x32 => BaseUrl.baseurl + $"Contents/img/favicons/favicon-32x32.png?dt={tickchange}";

        public static string favicon16x16 => BaseUrl.baseurl + $"Contents/img/favicons/favicon-16x16.png?dt={tickchange}";

        /*favicons*/

        /*css local*/

        public static string pwapath => BaseUrl.baseurl + $"Contents/manifest.json?dt={tickchange}";

        public static string sitecss => BaseUrl.baseurl + $"Contents/css/Site.css?dt={tickchange}";

        public static string backtotopcss => BaseUrl.baseurl + $"Contents/css/backTop.css?dt={tickchange}";


        /*minified css*/

        public static string minsitecss => BaseUrl.baseurl + $"Contents/css/min/Site.min.css?dt={tickchange}";

        public static string dropzonecss => BaseUrl.baseurl + $"Contents/css/min/dropzone.min.css?dt={tickchange}";

        public static string backtotopmincss => BaseUrl.baseurl + $"Contents/css/min/backTop.min.css?dt={tickchange}";


        /*minified css son*/

        /*scripts local*/
        public static string startscript => BaseUrl.baseurl + $"Contents/js/start.js?dt={tickchange}";

        public static string infoscript => BaseUrl.baseurl + $"Contents/js/info.js?dt={tickchange}";

        public static string modalscript => BaseUrl.baseurl + $"Contents/js/modal.js?dt={tickchange}";

        public static string uploadscript => BaseUrl.baseurl + $"Contents/js/upload.js?dt={tickchange}";

        /*Script Url*/

        /*minified js scripts*/

        public static string minstartscript => BaseUrl.baseurl + $"Contents/js/min/start.min.js?dt={tickchange}";

        public static string mininfoscript => BaseUrl.baseurl + $"Contents/js/min/info.min.js?dt={tickchange}";

        public static string dropzonescript => BaseUrl.baseurl + $"Contents/js/min/dropzone.min.js?dt={tickchange}";

        public static string minmodalscript => BaseUrl.baseurl + $"Contents/js/min/modal.min.js?dt={tickchange}";

        public static string minuploadscript => BaseUrl.baseurl + $"Contents/js/min/upload.min.js?dt={tickchange}";

        public static string backtotopscript => BaseUrl.baseurl + $"Contents/js/min/jquery.backTop.min.js?dt={tickchange}";


        /*minified js scripts*/


        public static string jquery => $"https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js?dt={tickchange}";

        public static string justifiedgalleryscript => $"https://cdnjs.cloudflare.com/ajax/libs/justifiedGallery/3.8.1/js/jquery.justifiedGallery.min.js?dt={tickchange}";

        public static string jqueryvalidatescript => $"https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.2/jquery.validate.min.js?dt={tickchange}";

        public static string jqueryunobtrusiveajax => $"https://cdnjs.cloudflare.com/ajax/libs/jquery-ajax-unobtrusive/3.2.6/jquery.unobtrusive-ajax.min.js?dt={tickchange}";

        public static string jquerynotifyscript => $"https://cdnjs.cloudflare.com/ajax/libs/notify/0.4.2/notify.min.js?dt={tickchange}";

        public static string jqueryuisearchscript => $"https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js?dt={tickchange}";

        /*css url*/

        public static string bulmacss => $"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.9.1/css/bulma.min.css?dt={tickchange}";

        public static string bulmasocialcss => $"https://cdn.jsdelivr.net/npm/bulma-social@2.0.0/css/all.min.css?dt={tickchange}";

        public static string justifiedgallerycss => $"https://cdnjs.cloudflare.com/ajax/libs/justifiedGallery/3.8.1/css/justifiedGallery.min.css?dt={tickchange}";

        public static string fontawesomecss => $"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/fontawesome.min.css?dt={tickchange}";

        public static string fontawesomeallcss => $"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css?dt={tickchange}";

        public static string jqueryuibasethemecss => $"https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css?dt={tickchange}";

        /*css*/

        /*scripts*/
        #endregion
    }

}
