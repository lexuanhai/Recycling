#pragma checksum "F:\webisite\Recycling\project\TECH\WEBSITE\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ae056196c2482a626f9ea9b3fe5733c14e3e270"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "F:\webisite\Recycling\project\TECH\WEBSITE\Views\_ViewImports.cshtml"
using WEBSITE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\webisite\Recycling\project\TECH\WEBSITE\Views\_ViewImports.cshtml"
using WEBSITE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ae056196c2482a626f9ea9b3fe5733c14e3e270", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"566e11193e06d5b16c73522a53c4e952c0238a84", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/css/sanpham.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "popularity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "price", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "price-desc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("woocommerce-ordering"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("woocommerce-product-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://green.hap.vn/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://green.hap.vn/san-pham/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\webisite\Recycling\project\TECH\WEBSITE\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7ae056196c2482a626f9ea9b3fe5733c14e3e2708164", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<div class=""box-products"">
    <div class=""box-image-head"">
        <div class=""container"">
            <p class=""txt-text"">SẢN PHẨM</p>
        </div>
    </div>
    <div class=""box-content"">
        <div class=""container"">
            <nav class=""woocommerce-breadcrumb""><a href=""https://green.hap.vn"">Trang chủ</a>&nbsp;/&nbsp;Sản phẩm</nav>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ae056196c2482a626f9ea9b3fe5733c14e3e2709780", async() => {
                WriteLiteral("\r\n                <select name=\"orderby\" class=\"orderby\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ae056196c2482a626f9ea9b3fe5733c14e3e27010121", async() => {
                    WriteLiteral("Phổ biến nhất");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ae056196c2482a626f9ea9b3fe5733c14e3e27011372", async() => {
                    WriteLiteral("Mới nhất");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ae056196c2482a626f9ea9b3fe5733c14e3e27012705", async() => {
                    WriteLiteral("Giá thấp đến cao");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ae056196c2482a626f9ea9b3fe5733c14e3e27013959", async() => {
                    WriteLiteral("Giá cao xuống thấp");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n                <input type=\"hidden\" name=\"paged\" value=\"1\">\r\n                <input type=\"hidden\" name=\"fbclid\" value=\"IwAR2Py_aKj8B6yBk9I-I4pK_7PZO0HpzhJO8diAg4cI6wMJwXlXNma-stsdk\">\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""box-content-left-top"">
                <div class=""row"">
                    <div class=""custom-col-left custom-col-sm"">
                        <div class=""box-content-left"">
                            <div id=""woocommerce_product_search-2"" class=""widget woocommerce widget_product_search"">
                                <h3 class=""widget-title"">Tìm kiếm sản phẩm</h3>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ae056196c2482a626f9ea9b3fe5733c14e3e27017142", async() => {
                WriteLiteral(@"
                                    <label class=""screen-reader-text"" for=""woocommerce-product-search-field-0"">Tìm kiếm cho:</label>
                                    <input type=""search"" id=""woocommerce-product-search-field-0"" class=""search-field"" placeholder=""Tìm sản phẩm…""");
                BeginWriteAttribute("value", " value=\"", 1987, "\"", 1995, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"s\">\r\n                                    <button type=\"submit\" value=\"Tìm kiếm\">Tìm kiếm</button>\r\n                                    <input type=\"hidden\" name=\"post_type\" value=\"product\">\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div id=""woocommerce_price_filter-2"" class=""widget woocommerce widget_price_filter"">
                                <h3 class=""widget-title"">Lọc theo giá</h3>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ae056196c2482a626f9ea9b3fe5733c14e3e27019780", async() => {
                WriteLiteral("\r\n                                    <div class=\"price_slider_wrapper\">\r\n                                        <div class=\"price_slider ui-slider ui-slider-horizontal ui-widget ui-widget-content ui-corner-all\"");
                BeginWriteAttribute("style", " style=\"", 2764, "\"", 2772, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <input type=""range"" min=""1"" max=""100"" value=""50"">
                                            <span class=""range-max""></span>
                                        </div>
                                        <div class=""price_slider_amount"">
                                            <input type=""text"" id=""min_price"" name=""min_price"" value=""14500"" data-min=""14500"" placeholder=""Giá thấp nhất"" style=""display: none;"">
                                            <input type=""text"" id=""max_price"" name=""max_price"" value=""499000"" data-max=""499000"" placeholder=""Giá cao nhất"" style=""display: none;"">
                                            <button type=""submit"" class=""button"">Lọc</button>
                                            <div class=""price_label""");
                BeginWriteAttribute("style", " style=\"", 3593, "\"", 3601, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                Giá: <span class=""from"">14.500&nbsp;₫</span> — <span class=""to"">499.000&nbsp;₫</span>
                                            </div>
                                            <input type=""hidden"" name=""fbclid"" value=""IwAR2Py_aKj8B6yBk9I-I4pK_7PZO0HpzhJO8diAg4cI6wMJwXlXNma-stsdk"">
                                            <div class=""clear""></div>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div id=""woocommerce_product_categories-2"" class=""widget woocommerce widget_product_categories"">
                                <h3 class=""widget-title"">Danh mục sản phẩm</h3>
                                <ul class=""product-categories"">
                                    <li class=""cat-item cat-item-204""><a href=""https://green.hap.vn/danh-muc/dac-san-nghe-tinh"">Đặc sản Nghệ Tĩnh</a></li>
                                    <li class=""cat-item cat-item-205""><a href=""https://green.hap.vn/danh-muc/dac-san-tay-bac"">Đặc sản Tây Bắc</a></li>
                                    <li class=""cat-item cat-item-192""><a href=""https://green.hap.vn/danh-muc/thuc-pham-sach/gia-vi-an-toan"">Gia vị an toàn</a></li>
                                    <li class=""cat-item cat-item-26""><a href=""https://green.hap.vn/danh-muc/hat-giong-an-toan"">Hạt giống an toàn</a></li>
                                    <li class=""cat-item cat-item-50""><a href=""https://");
            WriteLiteral(@"green.hap.vn/danh-muc/hat-giong-an-toan/hat-giong-rau"">Hạt giống rau</a></li>
                                    <li class=""cat-item cat-item-27""><a href=""https://green.hap.vn/danh-muc/thuc-pham-sach"">Thực phẩm sạch</a></li>
                                    <li class=""cat-item cat-item-45""><a href=""https://green.hap.vn/danh-muc/thuc-pham-sach/rau-sach-da-nang"">Rau sạch Đà Nẵng</a></li>
                                    <li class=""cat-item cat-item-191""><a href=""https://green.hap.vn/danh-muc/thuc-pham-sach/thuc-pham-thuc-duong"">Thực phẩm thực dưỡng</a></li>
                                    <li class=""cat-item cat-item-188""><a href=""https://green.hap.vn/danh-muc/thuc-pham-sach/trai-cay-sach"">Trái cây sạch</a></li>
                                    <li class=""cat-item cat-item-189""><a href=""https://green.hap.vn/danh-muc/thuc-pham-sach/thuc-pham-kho"">Thực phẩm khô</a></li>
                                </ul>
                            </div>
                        </div>
                  ");
            WriteLiteral(@"  </div>
                    <div class=""custom-col-right"">
                        <div class=""box-content-right"">
                            <div class=""item-product"">
                                <div class=""item-content"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 6466, "\"", 6473, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""custom-box"">
                                        <div class=""thume-img"">
                                            <span class=""onsale""></span>
                                        </div>
                                        <div class=""box-text-content"">

                                            <h2 class=""woocommerce-loop-product__title"">Đường ăn kiêng, đường giảm cân (Nhập khẩu Đức)</h2>
                                            <span class=""price""><del><span class=""woocommerce-Price-amount amount"">110.000&nbsp;<span class=""woocommerce-Price-currencySymbol"">₫</span></span></del> <span class=""woocommerce-Price-amount amount giam"">85.000&nbsp;<span class=""woocommerce-Price-currencySymbol"">₫</span></span></span>
                                        </div>

                                    </a>

                                </div>

                            </div>
                            <div class=""item-product"">
                                <div clas");
            WriteLiteral("s=\"item-content\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7555, "\"", 7562, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""custom-box"">
                                        <div class=""thume-img"">
                                            <span class=""onsale""></span>
                                        </div>
                                        <div class=""box-text-content"">

                                            <h2 class=""woocommerce-loop-product__title"">Đường ăn kiêng, đường giảm cân (Nhập khẩu Đức)</h2>
                                            <span class=""price""><del><span class=""woocommerce-Price-amount amount"">110.000&nbsp;<span class=""woocommerce-Price-currencySymbol"">₫</span></span></del> <span class=""woocommerce-Price-amount amount giam"">85.000&nbsp;<span class=""woocommerce-Price-currencySymbol"">₫</span></span></span>
                                        </div>

                                    </a>

                                </div>
                            </div>
                            <div class=""item-product"">
                                <div class=");
            WriteLiteral("\"item-content\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 8642, "\"", 8649, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""custom-box"">
                                        <div class=""thume-img"">
                                            <span class=""onsale""></span>
                                        </div>
                                        <div class=""box-text-content"">

                                            <h2 class=""woocommerce-loop-product__title"">Đường ăn kiêng, đường giảm cân (Nhập khẩu Đức)</h2>
                                            <span class=""price""><del><span class=""woocommerce-Price-amount amount"">110.000&nbsp;<span class=""woocommerce-Price-currencySymbol"">₫</span></span></del> <span class=""woocommerce-Price-amount amount giam"">85.000&nbsp;<span class=""woocommerce-Price-currencySymbol"">₫</span></span></span>
                                        </div>

                                    </a>

                                </div>
                            </div>

                        </div>

                    </div>

                </div>
         ");
            WriteLiteral("   </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
