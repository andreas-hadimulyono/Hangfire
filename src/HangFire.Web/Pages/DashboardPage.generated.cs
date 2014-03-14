﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    
    #line 2 "..\..\Pages\DashboardPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Pages\DashboardPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 6 "..\..\Pages\DashboardPage.cshtml"
    using HangFire.Storage;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\DashboardPage.cshtml"
    using Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Pages\DashboardPage.cshtml"
    using ServiceStack.Text;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class DashboardPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");








            
            #line 8 "..\..\Pages\DashboardPage.cshtml"
  
    Layout = new LayoutPage { Title = "Dashboard" };
    IDictionary<DateTime, long> succeeded = null;
    IDictionary<DateTime, long> failed = null;

    var period = Request.QueryString["period"]?? "day";

    using (var monitor = JobStorage.Current.GetMonitoringApi())
    {
        if ("week".Equals(period, StringComparison.OrdinalIgnoreCase))
        {
            succeeded = monitor.SucceededByDatesCount();
            failed = monitor.FailedByDatesCount();
        }
        else if ("day".Equals(period, StringComparison.OrdinalIgnoreCase))
        {
            succeeded = monitor.HourlySucceededJobs();
            failed = monitor.HourlyFailedJobs();
        }
    }


            
            #line default
            #line hidden
WriteLiteral("\r\n<h3>Realtime graph</h3>\r\n<div id=\"realtimeGraph\"></div>\r\n\r\n<h3>\r\n    <div class" +
"=\"btn-group pull-right\" style=\"margin-top: 2px;\">\r\n        <a href=\"?period=day\"" +
" class=\"btn btn-sm btn-default ");


            
            #line 35 "..\..\Pages\DashboardPage.cshtml"
                                                        Write("day".Equals(period, StringComparison.OrdinalIgnoreCase) ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            Day\r\n        </a>\r\n        <a href=\"?period=week\" class=\"btn btn-" +
"sm btn-default ");


            
            #line 38 "..\..\Pages\DashboardPage.cshtml"
                                                         Write("week".Equals(period, StringComparison.OrdinalIgnoreCase) ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">Week</a>\r\n    </div>\r\n    History graph\r\n</h3>\r\n\r\n");


            
            #line 43 "..\..\Pages\DashboardPage.cshtml"
 if (succeeded != null && failed != null)
{
    using (JsConfig.With(dateHandler: JsonDateHandler.ISO8601))
    {

            
            #line default
            #line hidden
WriteLiteral("    <div id=\"historyGraph\" \r\n          data-succeeded=\"");


            
            #line 48 "..\..\Pages\DashboardPage.cshtml"
                     Write(JsonSerializer.SerializeToString(succeeded));

            
            #line default
            #line hidden
WriteLiteral("\" \r\n          data-failed=\"");


            
            #line 49 "..\..\Pages\DashboardPage.cshtml"
                  Write(JsonSerializer.SerializeToString(failed));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    </div>\r\n");


            
            #line 51 "..\..\Pages\DashboardPage.cshtml"
    }
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
