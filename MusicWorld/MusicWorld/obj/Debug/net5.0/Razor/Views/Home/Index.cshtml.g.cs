#pragma checksum "D:\Users\FPT\Semester3\Music_World--Right\MusicWorld\MusicWorld\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2171c12ecd11e474607b247c5996031b23dbb41f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Users\FPT\Semester3\Music_World--Right\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\FPT\Semester3\Music_World--Right\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\FPT\Semester3\Music_World--Right\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2171c12ecd11e474607b247c5996031b23dbb41f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4b7d408ec3957d2417e75c4d7e8b583f55fe6be", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgalbum"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\FPT\Semester3\Music_World--Right\MusicWorld\MusicWorld\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- ##### Latest Albums Area Start ##### -->
    <section class=""latest-albums-area section-padding-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""section-heading style-2"">
                        <p>See what’s new</p>
                        <h2>Latest Albums</h2>
                    </div>
                </div>
            </div>
            <div class=""row justify-content-center"">
                <div class=""col-12 col-lg-9"">
                    <div class=""ablums-text text-center mb-70"">
                        <p>Nam tristique ex vel magna tincidunt, ut porta nisl finibus. Vivamus eu dolor eu quam varius rutrum. Fusce nec justo id sem aliquam fringilla nec non lacus. Suspendisse eget lobortis nisi, ac cursus odio. Vivamus nibh velit, rutrum at ipsum ac, dignissim iaculis ante. Donec in velit non elit pulvinar pellentesque et non eros.</p>
                    </div>
                </div>
     ");
            WriteLiteral("       </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">\r\n                    <div class=\"albums-slideshow owl-carousel\">\r\n");
#nullable restore
#line 27 "D:\Users\FPT\Semester3\Music_World--Right\MusicWorld\MusicWorld\Views\Home\Index.cshtml"
                         foreach (var item in Model.Albums)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <!-- Single Album -->\r\n                            <div class=\"single-album\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2171c12ecd11e474607b247c5996031b23dbb41f5903", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1503, "~/img/Music/Classical/", 1503, 22, true);
#nullable restore
#line 31 "D:\Users\FPT\Semester3\Music_World--Right\MusicWorld\MusicWorld\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1525, item.UrlImage, 1525, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"album-info\">\r\n                                    <a href=\"#\">\r\n                                        <h5>");
#nullable restore
#line 34 "D:\Users\FPT\Semester3\Music_World--Right\MusicWorld\MusicWorld\Views\Home\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    </a>\r\n                                    <p>Second Song</p>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 39 "D:\Users\FPT\Semester3\Music_World--Right\MusicWorld\MusicWorld\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- ##### Latest Albums Area End ##### -->
    <!-- ##### Buy Now Area Start ##### -->
    <section class=""oneMusic-buy-now-area has-fluid bg-gray section-padding-100"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""section-heading style-2"">
                        <p>See what’s new</p>
                        <h2>Buy What’s New</h2>
                    </div>
                </div>
            </div>

            <div class=""row"">

                <!-- Single Album Area -->
                <div class=""col-12 col-sm-6 col-md-4 col-lg-2"">
                    <div class=""single-album-area wow fadeInUp"" data-wow-delay=""100ms"">
                        <div class=""album-thumb"">
                            <img src=""/img/bg-img/b1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2885, "\"", 2891, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <!-- Album Price -->
                            <div class=""album-price"">
                                <p>$0.90</p>
                            </div>
                            <!-- Play Icon -->
                            <div class=""play-icon"">
                                <a href=""#"" class=""video--play--btn""><span class=""icon-play-button""></span></a>
                            </div>
                        </div>
                        <div class=""album-info"">
                            <a href=""#"">
                                <h5>Garage Band</h5>
                            </a>
                            <p>Radio Station</p>
                        </div>
                    </div>
                </div>

                <!-- Single Album Area -->
                <div class=""col-12 col-sm-6 col-md-4 col-lg-2"">
                    <div class=""single-album-area wow fadeInUp"" data-wow-delay=""200ms"">
                        <div class=""al");
            WriteLiteral("bum-thumb\">\r\n                            <img src=\"/img/bg-img/b2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3986, "\"", 3992, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""album-info"">
                            <a href=""#"">
                                <h5>Noises</h5>
                            </a>
                            <p>Buble Gum</p>
                        </div>
                    </div>
                </div>

                <!-- Single Album Area -->
                <div class=""col-12 col-sm-6 col-md-4 col-lg-2"">
                    <div class=""single-album-area wow fadeInUp"" data-wow-delay=""300ms"">
                        <div class=""album-thumb"">
                            <img src=""/img/bg-img/b3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4641, "\"", 4647, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""album-info"">
                            <a href=""#"">
                                <h5>Jess Parker</h5>
                            </a>
                            <p>The Album</p>
                        </div>
                    </div>
                </div>

                <!-- Single Album Area -->
                <div class=""col-12 col-sm-6 col-md-4 col-lg-2"">
                    <div class=""single-album-area wow fadeInUp"" data-wow-delay=""400ms"">
                        <div class=""album-thumb"">
                            <img src=""/img/bg-img/b4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5301, "\"", 5307, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""album-info"">
                            <a href=""#"">
                                <h5>Noises</h5>
                            </a>
                            <p>Buble Gum</p>
                        </div>
                    </div>
                </div>

                <!-- Single Album Area -->
                <div class=""col-12 col-sm-6 col-md-4 col-lg-2"">
                    <div class=""single-album-area wow fadeInUp"" data-wow-delay=""500ms"">
                        <div class=""album-thumb"">
                            <img src=""/img/bg-img/b1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5956, "\"", 5962, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <!-- Album Price -->
                            <div class=""album-price"">
                                <p>$0.90</p>
                            </div>
                            <!-- Play Icon -->
                            <div class=""play-icon"">
                                <a href=""#"" class=""video--play--btn""><span class=""icon-play-button""></span></a>
                            </div>
                        </div>
                        <div class=""album-info"">
                            <a href=""#"">
                                <h5>Garage Band</h5>
                            </a>
                            <p>Radio Station</p>
                        </div>
                    </div>
                </div>

                <!-- Single Album Area -->
                <div class=""col-12 col-sm-6 col-md-4 col-lg-2"">
                    <div class=""single-album-area wow fadeInUp"" data-wow-delay=""600ms"">
                        <div class=""al");
            WriteLiteral("bum-thumb\">\r\n                            <img src=\"/img/bg-img/b2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7057, "\"", 7063, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""album-info"">
                            <a href=""#"">
                                <h5>Noises</h5>
                            </a>
                            <p>Buble Gum</p>
                        </div>
                    </div>
                </div>

                <!-- Single Album Area -->
                <div class=""col-12 col-sm-6 col-md-4 col-lg-2"">
                    <div class=""single-album-area wow fadeInUp"" data-wow-delay=""100ms"">
                        <div class=""album-thumb"">
                            <img src=""/img/bg-img/b3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7712, "\"", 7718, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""album-info"">
                            <a href=""#"">
                                <h5>Jess Parker</h5>
                            </a>
                            <p>The Album</p>
                        </div>
                    </div>
                </div>

                <!-- Single Album Area -->
                <div class=""col-12 col-sm-6 col-md-4 col-lg-2"">
                    <div class=""single-album-area wow fadeInUp"" data-wow-delay=""200ms"">
                        <div class=""album-thumb"">
                            <img src=""/img/bg-img/b4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8372, "\"", 8378, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""album-info"">
                            <a href=""#"">
                                <h5>Noises</h5>
                            </a>
                            <p>Buble Gum</p>
                        </div>
                    </div>
                </div>

                <!-- Single Album Area -->
                <div class=""col-12 col-sm-6 col-md-4 col-lg-2"">
                    <div class=""single-album-area wow fadeInUp"" data-wow-delay=""300ms"">
                        <div class=""album-thumb"">
                            <img src=""/img/bg-img/b1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9027, "\"", 9033, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <!-- Album Price -->
                            <div class=""album-price"">
                                <p>$0.90</p>
                            </div>
                            <!-- Play Icon -->
                            <div class=""play-icon"">
                                <a href=""#"" class=""video--play--btn""><span class=""icon-play-button""></span></a>
                            </div>
                        </div>
                        <div class=""album-info"">
                            <a href=""#"">
                                <h5>Garage Band</h5>
                            </a>
                            <p>Radio Station</p>
                        </div>
                    </div>
                </div>

                <!-- Single Album Area -->
                <div class=""col-12 col-sm-6 col-md-4 col-lg-2"">
                    <div class=""single-album-area wow fadeInUp"" data-wow-delay=""400ms"">
                        <div class=""al");
            WriteLiteral("bum-thumb\">\r\n                            <img src=\"/img/bg-img/b2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 10128, "\"", 10134, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""album-info"">
                            <a href=""#"">
                                <h5>Noises</h5>
                            </a>
                            <p>Buble Gum</p>
                        </div>
                    </div>
                </div>

                <!-- Single Album Area -->
                <div class=""col-12 col-sm-6 col-md-4 col-lg-2"">
                    <div class=""single-album-area wow fadeInUp"" data-wow-delay=""500ms"">
                        <div class=""album-thumb"">
                            <img src=""/img/bg-img/b3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10783, "\"", 10789, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""album-info"">
                            <a href=""#"">
                                <h5>Jess Parker</h5>
                            </a>
                            <p>The Album</p>
                        </div>
                    </div>
                </div>

                <!-- Single Album Area -->
                <div class=""col-12 col-sm-6 col-md-4 col-lg-2"">
                    <div class=""single-album-area wow fadeInUp"" data-wow-delay=""600ms"">
                        <div class=""album-thumb"">
                            <img src=""/img/bg-img/b4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11443, "\"", 11449, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""album-info"">
                            <a href=""#"">
                                <h5>Noises</h5>
                            </a>
                            <p>Buble Gum</p>
                        </div>
                    </div>
                </div>

            </div>

            <div class=""row"">
                <div class=""col-12"">
                    <div class=""load-more-btn text-center wow fadeInUp"" data-wow-delay=""300ms"">
                        <a href=""#"" class=""btn oneMusic-btn"">Load More <i class=""fa fa-angle-double-right""></i></a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- ##### Buy Now Area End ##### -->
    <!-- ##### Featured Artist Area Start ##### -->
    <section class=""featured-artist-area section-padding-100 bg-img bg-overlay bg-fixed"" style=""background-image: url(img/bg-img/bg-4.jpg);"">
        <div class=""container"">
 ");
            WriteLiteral("           <div class=\"row align-items-end\">\r\n                <div class=\"col-12 col-md-5 col-lg-4\">\r\n                    <div class=\"featured-artist-thumb\">\r\n                        <img src=\"/img/bg-img/fa.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 12686, "\"", 12692, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
                <div class=""col-12 col-md-7 col-lg-8"">
                    <div class=""featured-artist-content"">
                        <!-- Section Heading -->
                        <div class=""section-heading white text-left mb-30"">
                            <p>See what’s new</p>
                            <h2>Buy What’s New</h2>
                        </div>
                        <p>Nam tristique ex vel magna tincidunt, ut porta nisl finibus. Vivamus eu dolor eu quam varius rutrum. Fusce nec justo id sem aliquam fringilla nec non lacus. Suspendisse eget lobortis nisi, ac cursus odio. Vivamus nibh velit, rutrum at ipsum ac, dignissim iaculis ante. Donec in velit non elit pulvinar pellentesque et non eros.</p>
                        <div class=""song-play-area"">
                            <div class=""song-name"">
                                <p>01. Main Hit Song</p>
                            </div>
                            <a");
            WriteLiteral(@"udio preload=""auto"" controls>
                                <source src=""/audio/Everything I Need - Skylar Grey.mp3"">
                            </audio>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- ##### Featured Artist Area End ##### -->
    <!-- ##### Miscellaneous Area Start ##### -->
    <section class=""miscellaneous-area section-padding-100-0"">
        <div class=""container"">
            <div class=""row"">
                <!-- ***** Weeks Top ***** -->
                <div class=""col-12 col-lg-4"">
                    <div class=""weeks-top-area mb-100"">
                        <div class=""section-heading text-left mb-50 wow fadeInUp"" data-wow-delay=""50ms"">
                            <p>See what’s new</p>
                            <h2>This week’s top</h2>
                        </div>

                        <!-- Single Top Item -->
                        <div class=""single-top-item");
            WriteLiteral(" d-flex wow fadeInUp\" data-wow-delay=\"100ms\">\r\n                            <div class=\"thumbnail\">\r\n                                <img src=\"/img/bg-img/wt1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 14903, "\"", 14909, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""content-"">
                                <h6>Sam Smith</h6>
                                <p>Underground</p>
                            </div>
                        </div>

                        <!-- Single Top Item -->
                        <div class=""single-top-item d-flex wow fadeInUp"" data-wow-delay=""150ms"">
                            <div class=""thumbnail"">
                                <img src=""/img/bg-img/wt2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15438, "\"", 15444, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""content-"">
                                <h6>Power Play</h6>
                                <p>In my mind</p>
                            </div>
                        </div>

                        <!-- Single Top Item -->
                        <div class=""single-top-item d-flex wow fadeInUp"" data-wow-delay=""200ms"">
                            <div class=""thumbnail"">
                                <img src=""/img/bg-img/wt3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15973, "\"", 15979, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""content-"">
                                <h6>Cristinne Smith</h6>
                                <p>My Music</p>
                            </div>
                        </div>

                        <!-- Single Top Item -->
                        <div class=""single-top-item d-flex wow fadeInUp"" data-wow-delay=""250ms"">
                            <div class=""thumbnail"">
                                <img src=""/img/bg-img/wt4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 16511, "\"", 16517, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""content-"">
                                <h6>The Music Band</h6>
                                <p>Underground</p>
                            </div>
                        </div>

                        <!-- Single Top Item -->
                        <div class=""single-top-item d-flex wow fadeInUp"" data-wow-delay=""300ms"">
                            <div class=""thumbnail"">
                                <img src=""/img/bg-img/wt5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17051, "\"", 17057, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""content-"">
                                <h6>Creative Lyrics</h6>
                                <p>Songs and stuff</p>
                            </div>
                        </div>

                        <!-- Single Top Item -->
                        <div class=""single-top-item d-flex wow fadeInUp"" data-wow-delay=""350ms"">
                            <div class=""thumbnail"">
                                <img src=""/img/bg-img/wt6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17596, "\"", 17602, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""content-"">
                                <h6>The Culture</h6>
                                <p>Pop Songs</p>
                            </div>
                        </div>

                    </div>
                </div>

                <!-- ***** New Hits Songs ***** -->
                <div class=""col-12 col-lg-4"">
                    <div class=""new-hits-area mb-100"">
                        <div class=""section-heading text-left mb-50 wow fadeInUp"" data-wow-delay=""50ms"">
                            <p>See what’s new</p>
                            <h2>New Hits</h2>
                        </div>

                        <!-- Single Top Item -->
                        <div class=""single-new-item d-flex align-items-center justify-content-between wow fadeInUp"" data-wow-delay=""100ms"">
                            <div class=""first-part d-flex align-items-center"">
                                <div cla");
            WriteLiteral("ss=\"thumbnail\">\r\n                                    <img src=\"/img/bg-img/wt7.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 18710, "\"", 18716, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""content-"">
                                    <h6>Sam Smith</h6>
                                    <p>Underground</p>
                                </div>
                            </div>
                            <audio preload=""auto"" controls>
                                <source src=""/audio/dummy-audio.mp3"">
                            </audio>
                        </div>

                        <!-- Single Top Item -->
                        <div class=""single-new-item d-flex align-items-center justify-content-between wow fadeInUp"" data-wow-delay=""150ms"">
                            <div class=""first-part d-flex align-items-center"">
                                <div class=""thumbnail"">
                                    <img src=""/img/bg-img/wt8.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 19602, "\"", 19608, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""content-"">
                                    <h6>Power Play</h6>
                                    <p>In my mind</p>
                                </div>
                            </div>
                            <audio preload=""auto"" controls>
                                <source src=""/audio/dummy-audio.mp3"">
                            </audio>
                        </div>

                        <!-- Single Top Item -->
                        <div class=""single-new-item d-flex align-items-center justify-content-between wow fadeInUp"" data-wow-delay=""200ms"">
                            <div class=""first-part d-flex align-items-center"">
                                <div class=""thumbnail"">
                                    <img src=""/img/bg-img/wt9.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 20494, "\"", 20500, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""content-"">
                                    <h6>Cristinne Smith</h6>
                                    <p>My Music</p>
                                </div>
                            </div>
                            <audio preload=""auto"" controls>
                                <source src=""/audio/dummy-audio.mp3"">
                            </audio>
                        </div>

                        <!-- Single Top Item -->
                        <div class=""single-new-item d-flex align-items-center justify-content-between wow fadeInUp"" data-wow-delay=""250ms"">
                            <div class=""first-part d-flex align-items-center"">
                                <div class=""thumbnail"">
                                    <img src=""/img/bg-img/wt10.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 21390, "\"", 21396, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""content-"">
                                    <h6>The Music Band</h6>
                                    <p>Underground</p>
                                </div>
                            </div>
                            <audio preload=""auto"" controls>
                                <source src=""/audio/dummy-audio.mp3"">
                            </audio>
                        </div>

                        <!-- Single Top Item -->
                        <div class=""single-new-item d-flex align-items-center justify-content-between wow fadeInUp"" data-wow-delay=""300ms"">
                            <div class=""first-part d-flex align-items-center"">
                                <div class=""thumbnail"">
                                    <img src=""/img/bg-img/wt11.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 22288, "\"", 22294, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""content-"">
                                    <h6>Creative Lyrics</h6>
                                    <p>Songs and stuff</p>
                                </div>
                            </div>
                            <audio preload=""auto"" controls>
                                <source src=""/audio/dummy-audio.mp3"">
                            </audio>
                        </div>

                        <!-- Single Top Item -->
                        <div class=""single-new-item d-flex align-items-center justify-content-between wow fadeInUp"" data-wow-delay=""350ms"">
                            <div class=""first-part d-flex align-items-center"">
                                <div class=""thumbnail"">
                                    <img src=""/img/bg-img/wt12.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 23191, "\"", 23197, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""content-"">
                                    <h6>The Culture</h6>
                                    <p>Pop Songs</p>
                                </div>
                            </div>
                            <audio preload=""auto"" controls>
                                <source src=""/audio/dummy-audio.mp3"">
                            </audio>
                        </div>
                    </div>
                </div>

                <!-- ***** Popular Artists ***** -->
                <div class=""col-12 col-lg-4"">
                    <div class=""popular-artists-area mb-100"">
                        <div class=""section-heading text-left mb-50 wow fadeInUp"" data-wow-delay=""50ms"">
                            <p>See what’s new</p>
                            <h2>Popular Artist</h2>
                        </div>

                        <!-- Single Artist -->
                        <");
            WriteLiteral("div class=\"single-artists d-flex align-items-center wow fadeInUp\" data-wow-delay=\"100ms\">\r\n                            <div class=\"thumbnail\">\r\n                                <img src=\"/img/bg-img/pa1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 24428, "\"", 24434, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""content-"">
                                <p>Sam Smith</p>
                            </div>
                        </div>

                        <!-- Single Artist -->
                        <div class=""single-artists d-flex align-items-center wow fadeInUp"" data-wow-delay=""150ms"">
                            <div class=""thumbnail"">
                                <img src=""/img/bg-img/pa2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 24925, "\"", 24931, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""content-"">
                                <p>William Parker</p>
                            </div>
                        </div>

                        <!-- Single Artist -->
                        <div class=""single-artists d-flex align-items-center wow fadeInUp"" data-wow-delay=""200ms"">
                            <div class=""thumbnail"">
                                <img src=""/img/bg-img/pa3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 25427, "\"", 25433, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""content-"">
                                <p>Jessica Walsh</p>
                            </div>
                        </div>

                        <!-- Single Artist -->
                        <div class=""single-artists d-flex align-items-center wow fadeInUp"" data-wow-delay=""250ms"">
                            <div class=""thumbnail"">
                                <img src=""/img/bg-img/pa4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 25928, "\"", 25934, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""content-"">
                                <p>Tha Stoves</p>
                            </div>
                        </div>

                        <!-- Single Artist -->
                        <div class=""single-artists d-flex align-items-center wow fadeInUp"" data-wow-delay=""300ms"">
                            <div class=""thumbnail"">
                                <img src=""/img/bg-img/pa5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 26426, "\"", 26432, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""content-"">
                                <p>DJ Ajay</p>
                            </div>
                        </div>

                        <!-- Single Artist -->
                        <div class=""single-artists d-flex align-items-center wow fadeInUp"" data-wow-delay=""350ms"">
                            <div class=""thumbnail"">
                                <img src=""/img/bg-img/pa6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 26921, "\"", 26927, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""content-"">
                                <p>Radio Vibez</p>
                            </div>
                        </div>

                        <!-- Single Artist -->
                        <div class=""single-artists d-flex align-items-center wow fadeInUp"" data-wow-delay=""400ms"">
                            <div class=""thumbnail"">
                                <img src=""/img/bg-img/pa7.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 27420, "\"", 27426, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""content-"">
                                <p>Music 4u</p>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- ##### Miscellaneous Area End ##### -->
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
