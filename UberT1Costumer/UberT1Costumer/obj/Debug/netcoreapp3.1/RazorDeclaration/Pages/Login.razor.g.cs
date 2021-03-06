// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UberT1Costumer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\_Imports.razor"
using UberT1Costumer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\_Imports.razor"
using UberT1Costumer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\Pages\Login.razor"
using UberT1Costumer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\Pages\Login.razor"
using UberT1Costumer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\Pages\Login.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\Pages\Login.razor"
using UberT1Costumer.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Lokkaze\Desktop\uni\SEP3\code\UberT1Costumer\UberT1Costumer\Pages\Login.razor"
       
    private Costumer CurrentUser;

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
