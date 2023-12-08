using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;
using WinFormsApp2.Core;
using static WinFormsApp2.Core.IParser;

namespace WinFormsApp2.Habra.Core
{
    class HabraSettings : IParserSettings
    {
        class HabraParser : IParser<string[]>
        {
            public string[] Parse(IHtmlDocument document)
            {
                var list = new List<string>();
                var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("post__title_link"));

                foreach (var item in items)
                {
                    list.Add(item.TextContent);
                }

                return list.ToArray();
            }
        }
    }
}
