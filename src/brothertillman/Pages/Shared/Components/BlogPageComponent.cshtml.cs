using System.Threading.Tasks;
using Vue.Net;

namespace BrotherTillman.Pages.Shared.Components
{
    public class BlogPageComponent : VueModel
    {
        public const string AddVueNugetExample = @"
```xml
    // Razor is required!
    <PackageReference Include = ""Microsoft.AspNetCore.Razor.Design"" Version=""2.2.0"" PrivateAssets=""All"" />

    // Add Vue.Net Package
    <PackageReference Include = ""Vue.Net"" Version=""0.0.1-alpha2"" />
```
";
        public const string AddVueServiceExample = @"
```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Setup Other Services

    services.AddMvc();

    // Add Vue.Net
    services.AddVue();
}
```";

        public const string AddVueToLayoutExample = @"
```html
<!DOCTYPE html>
<html>
<body>
    @RenderBody()

    <!-- Include VueJs Version you desire -->
    <script src=""https://cdn.jsdelivr.net/npm/vue""><//script>

    <!-- Javascript TagHelper places all Javascript neccesary for rendered html -->
    <javascript></javascript>
</body>
</html>
```";

        public const string AddVueTagHelpersExample = @"
```html
@addTagHelper *, Vue.Net
```
";

        public const string CreateVueModelExample = @"
```csharp
using Vue.Net;

namespace MyApplication
{
    // Components must be in Shared/Components Directory
    public class ApplicationComponent : VueModel
    {
        public int Count { get; set; }

        public void IncrementCount() => Count++;
    }
}
```";

        public const string CreateVueTemplateExample = @"
```html
<div>
    <p>{{ Count }}</p>
    <button v-on:click=""IncrementCount()"">Increment Count</button>
</div>
```";

        public const string VueComponentRegistrationExample = @"
```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Setup Other Services

    services.AddMvc();

    // Add Vue.Net
    services
        .AddVue()
        .Configure(options=>
        {
            // Add ApplicationComponent for use in Vue Applications
            options.RegisterComponent<ApplicationComponent>();
        };
}
```";


        public const string VueApplicationExample = @"
```html
@page

<!-- You must wrap all Vue components in the vue-application tag -->
<!-- This makes all your vue components accessible for use -->
<vue-application>

    <!-- Insert our ApplicationComponent -->
    <application-component></application-component>

</vue-application>
```";

        public string AddVueNugetMarkdown { get; set; }

        public string AddVueServiceMarkdown { get; set; }

        public string AddVueTagHelpersMarkdown { get; set; }

        public string AddVueToLayoutMarkdown { get; set; }

        public string CreateVueModelMarkdown { get; set; }

        public string CreateVueTemplateMarkdown { get; set; }

        public string VueComponentRegistrationMarkdown { get; set; }

        public string VueApplicationMarkdown { get; set; }

        protected override void created()
        {
            // Setup Vue.Net
            AddVueNugetMarkdown = MarkedJs.Marked(AddVueNugetExample);
            AddVueServiceMarkdown = MarkedJs.Marked(AddVueServiceExample);
            AddVueTagHelpersMarkdown = MarkedJs.Marked(AddVueTagHelpersExample);
            AddVueToLayoutMarkdown = MarkedJs.Marked(AddVueToLayoutExample);

            // Create Vue Components
            CreateVueModelMarkdown = MarkedJs.Marked(CreateVueModelExample);
            CreateVueTemplateMarkdown = MarkedJs.Marked(CreateVueTemplateExample);
            VueComponentRegistrationMarkdown = MarkedJs.Marked(VueComponentRegistrationExample);

            // Creating Vue Application
            VueApplicationMarkdown = MarkedJs.Marked(VueApplicationExample);

        }
    }
}