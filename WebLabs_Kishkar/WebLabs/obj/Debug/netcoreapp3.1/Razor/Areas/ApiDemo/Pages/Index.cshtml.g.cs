#pragma checksum "D:\Новый_шаг\WebLabs_55-master\WebLabs_55-master\WebLabs\Areas\ApiDemo\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a17cac5885c05c3fcbfc0b5d62ed6b569b1a53a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebLabs.Areas.ApiDemo.Pages.Areas_ApiDemo_Pages_Index), @"mvc.1.0.razor-page", @"/Areas/ApiDemo/Pages/Index.cshtml")]
namespace WebLabs.Areas.ApiDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a17cac5885c05c3fcbfc0b5d62ed6b569b1a53a1", @"/Areas/ApiDemo/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f147587388474c54bd7afbd038ef4ea3b49a551e", @"/Areas/ApiDemo/Pages/_ViewImports.cshtml")]
    public class Areas_ApiDemo_Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \n");
            WriteLiteral("<table class=\"table table-striped table-sm\" id=\"list\">\n</table>\n<div class=\"lead\" id=\"info\"></div>\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script>\nvar url = \"");
#line 11 "D:\Новый_шаг\WebLabs_55-master\WebLabs_55-master\WebLabs\Areas\ApiDemo\Pages\Index.cshtml"
      Write(Url.Action("GetDishes", "Dishes"));

#line default
#line hidden
                WriteLiteral(@""";
$(document).ready(function () {
// послать запрос
$.getJSON(url, function (data) {
// найти таблицу по id
var table = $(""#list"");
// сформировать строку для каждого полученного объекта
$.each(data, function (num, value) {
createRow(num+1, value).appendTo(table);
})
});
})
// Функция формирования одной строки таблицы
// index - порядковый номер
// data - объект данных
function createRow(index, data) {
// создать строку таблицы
var row = $(""<tr>"");
// добавть колонку с порядковым номером
row.append(""<td>"" + index + ""</td>"");
// добавить колонку с названием
row.append(""<td>"" + data.dishName + ""</td>"");
// создать кнопку
var button = $(""<button>"")
.addClass(""btn btn-success"") // стиль кнопки
.click(data.dishId, showDetails) // подписка на событие click
.text(""Подробно""); // надпись
// создать колонку с кнопкой
var td = $(""<td>"").append(button);
// добавить в строку таблицы
row.append(td);
return row;
}
//Функция выода информации о выбранном объекте
function showDetails(e) {
// Послать запрос
$.getJSON(url + ""/");
                WriteLiteral(@""" + e.data, function (data) {
// строка информации об объекте
var details = data.dishName + "": ""
+ data.description + "" - ""
+ data.calories + "" калорий"";
$(""#info"") // Найти блок для информации
.empty() // очистить содержимое
.text(details); // записать новый текст
})
}
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_ApiDemo_Pages_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_ApiDemo_Pages_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_ApiDemo_Pages_Index>)PageContext?.ViewData;
        public Areas_ApiDemo_Pages_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
