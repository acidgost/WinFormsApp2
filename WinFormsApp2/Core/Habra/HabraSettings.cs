using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;
using WinFormsApp2.Core;

namespace WinFormsApp2.Habra.Core
{
    class HabraSettings : IParserSettings
    {
        public HabraSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl { get; set; } = "https://habrahabr.ru";

        public string Prefix { get; set; } = "page{CurrentId}";

        public int StartPoint { get; set; }

        public int EndPoint { get; set; }
    }
}
