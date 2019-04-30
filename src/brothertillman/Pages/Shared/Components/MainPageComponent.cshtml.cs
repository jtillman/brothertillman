using Vue.Net;

namespace BrotherTillman.Pages.Shared.Components
{
    public class MarkedJsOptions
    {
        public string BaseUrl { get; set; }
    }

    public class MarkedJs
    {
        public static string Marked(string mardown, MarkedJsOptions options = null) => null;
    }

    public class MainPageComponent : VueModel
    {
    }
}