#pragma checksum "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b698f73281c562e7e718185111ada518c699dca1"
// <auto-generated/>
#pragma warning disable 1591
namespace T1Driver.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\_Imports.razor"
using T1Driver;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\_Imports.razor"
using T1Driver.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\Pages\Login.razor"
using T1Driver.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\Pages\Login.razor"
using T1Driver.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\Pages\Login.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\Pages\Login.razor"
using T1Driver.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<h3>Login</h3>\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "id", "logIn");
                __builder2.AddMarkupContent(5, "<div>Username </div> ");
                __builder2.OpenElement(6, "input");
                __builder2.AddAttribute(7, "type", "text");
                __builder2.AddAttribute(8, "placeholder", "username");
                __builder2.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\Pages\Login.razor"
                                                                                         username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.AddMarkupContent(12, "<div id=\"password\"> Password </div> ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "password");
                __builder2.AddAttribute(15, "placeholder", "password");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\Pages\Login.razor"
                                                                                                           password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenElement(19, "div");
                __builder2.OpenElement(20, "button");
                __builder2.AddAttribute(21, "id", "logButt");
                __builder2.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\Pages\Login.razor"
                                               PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(23, " Log in ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.OpenElement(25, "button");
                __builder2.AddAttribute(26, "id", "registerButt");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\Pages\Login.razor"
                                                    PerformRegister

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(28, " Sign Up");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "style", "color:red");
                __builder2.AddContent(32, 
#nullable restore
#line 19 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\Pages\Login.razor"
                                    message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(33, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(34, "<h3>You are signed in!</h3>\r\n        ");
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "id", "logoutButt");
                __builder2.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\Pages\Login.razor"
                                          PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(38, " Log out");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\T1Driver\T1Driver\T1Driver\Pages\Login.razor"
       
    private Driver CurrentUser;

    private string message;
    private string username;
    private string password;

    IUserServices client = new UserServices();

    public async Task PerformLogin()
    {
        message = "";
        try
        {
            client.Connect();
            Thread.Sleep(100);
            ((UserAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            message = "Login succeed!";

        }
        catch (Exception e)
        {
            message = "Username or password is incorrect!";
            Console.WriteLine(e);
        }        
    }
    
    public async Task PerformLogout()
    {
        message = "";
        username = "";
        password = "";
        try
        {
            ((UserAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            message = "Logout succeed!";
        }
        catch (Exception e)
        {
            message = e.Message;
        }
    }
    
    public async Task PerformRegister()
    {
        client.Connect();
        Thread.Sleep(100);
        client.Register(username, password);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
