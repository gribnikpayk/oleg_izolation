using System.Web;
using System.Web.Mvc;

namespace oleg_izolation.Helpers
{
    public static class LandingPageUrl_Helper
    {
        public static IHtmlString LandingPageUrl(this HtmlHelper helper, string pageName, string linkName)
        {
            string link = $"<a class='landingPageHref' href='/Home/LandingPage?pageName={pageName}#top'>{linkName}</a>"; ;
            return new HtmlString(link);
        }
    }
}