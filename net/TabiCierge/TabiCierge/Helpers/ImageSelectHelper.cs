using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TabiCierge.Helpers
{
    public class ImageSelectHelper
    {
        public static string MatchByImage(int? image_no)
        {
            switch (image_no)
            {
                case 1: return "泉岳寺（赤穂浪士の墓）";
                case 2:return "碓氷第三橋梁";
                case 3:return "足尾銅山";
                case 4: return "東京ドームシティ ASOBono！";
                case 5:return "インスタントラーメン博物館";
                case 6:return "ワープステーション江戸";
                case 7:return "釣船茶屋 ざうお";
                case 8:return "犬吠埼";
                case 9:return "巨大迷路パラディアム";
                case 10:return "目黒寄生虫館";
                default:return "";
            }
        }
    }
}