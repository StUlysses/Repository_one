#pragma checksum "D:\WorkSpace\WePoem\WePoem\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "832b820799d0d01d2e64d368905d6bf8dcf8d2d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"832b820799d0d01d2e64d368905d6bf8dcf8d2d0", @"/Views/User/Index.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/User/IndexFcn.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\WorkSpace\WePoem\WePoem\Views\User\Index.cshtml"
  
    ViewData["Title"] = "设置";
    Layout = "~/Views/Shared/PCBack.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "832b820799d0d01d2e64d368905d6bf8dcf8d2d03522", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""container"" style=""width:100%;height:100%;position:relative;text-align:center;"">
    <div style=""width:100%;height:5%;"">
        <span style=""position:absolute;left:0px;top:0px"">
            <input type=""button"" value=""返回"" class=""btn btn-primary"" onclick=""window.location.href='/Poem/Index'"" />
        </span>
        <span");
            BeginWriteAttribute("style", " style=\"", 503, "\"", 596, 2);
            WriteAttributeValue("", 511, "position:absolute;right:0px;top:0px;", 511, 36, true);
#nullable restore
#line 12 "D:\WorkSpace\WePoem\WePoem\Views\User\Index.cshtml"
WriteAttributeValue("", 547, ViewBag.UserID == "null" ? "display:none" : "", 547, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <input type=""button"" value=""退出"" class=""btn btn-primary"" onclick=""window.location.href='/User/Logout'"" />
        </span>
    </div>
    <div style=""text-align:center;width:80%;height:60%;border-radius:15px;margin:auto;background-color:whitesmoke"">
        <br />
        <!--导航:登录·注册·修改-->
        <div>
            <ul class=""nav nav-tabs justify-content-center"">
                <li class=""nav-item""><a onclick=""ClickLink(this)"" href=""#"" class=""nav-link active"">登录</a></li>
                <li class=""nav-item""><a onclick=""ClickLink(this)"" href=""#"" class=""nav-link"">注册</a></li>
                <li class=""nav-item""><a onclick=""ClickLink(this)"" href=""#""");
            BeginWriteAttribute("class", " class=\"", 1276, "\"", 1338, 2);
            WriteAttributeValue("", 1284, "nav-link", 1284, 8, true);
#nullable restore
#line 23 "D:\WorkSpace\WePoem\WePoem\Views\User\Index.cshtml"
WriteAttributeValue(" ", 1292, ViewBag.UserID == "null" ? "disabled" : "", 1293, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">修改密码</a></li>
            </ul>
        </div>
        <br /><br />
        <!--登录-->
        <div id=""LoginDiv"">
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"">用户名</span>
                </div>
                <input type=""text"" id=""LoginUserName"" class=""form-control""/>
            </div>
            <br />
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"">密码</span>
                </div>
                <input type=""password"" id=""LoginPassword"" class=""form-control"" />
                <div class=""input-group-prepend"">
                    <input type=""button"" class=""input-group-text"" value=""登录"" onclick=""LoginAction()"" />
                </div>
            </div>
        </div>
        <!--注册-->
        <div id=""RegisterDiv"" style=""display:none"">
            <div class=""input-group"">
                <div c");
            WriteLiteral(@"lass=""input-group-prepend"">
                    <span class=""input-group-text"">用户名</span>
                </div>
                <input type=""text"" id=""RegisterUserName"" class=""form-control""/>
            </div>
            <br />
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"">密码</span>
                </div>
                <input type=""password"" id=""RegisterPassword"" class=""form-control""/>
                <div class=""input-group-prepend"">
                    <input type=""button"" class=""input-group-text"" value=""注册"" onclick=""RegisterUser()"" />
                </div>
            </div>
        </div>
        <!--修改-->
        <div id=""EditDiv"" style=""display:none"">
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"">用户名</span>
                </div>
                <input id=""InfoUserName"" type=""text"" class=""form");
            WriteLiteral(@"-control""/>
            </div>
            <br />
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"">密码</span>
                </div>
                <input id=""InfoPassword"" type=""text"" class=""form-control""/>
            </div>
            <br />
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"">确认密码</span>
                </div>
                <input id=""InfoRePassword"" type=""text"" class=""form-control""/>
                <div class=""input-group-prepend"">
                    <input type=""button"" class=""input-group-text"" onclick=""EditUserInfo()"" value=""保存"" />
                </div>
            </div>
        </div>

    </div>
    <div>

    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "832b820799d0d01d2e64d368905d6bf8dcf8d2d09638", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
