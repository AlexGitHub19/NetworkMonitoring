using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoring
{
    public static class GetColor
    {
        public static string  GetColorHex(string id)
        {
            string result;
            switch (id)
            {
                case " Default":
                    result = "#2d89ef";
                    break;
                case "Black":
                    result = "#1d1d1d";
                    break;
                case "White ":
                    result = "#ffffff";
                    break;
                case "Silver":
                    result = "#1d1d1d";
                    break;
                case "Blue ":
                    result = "#2d89ef";
                    break;
                case "Green":
                    result = "#00a300";
                    break;
                case "Lime":
                    result = "#8CBF26";
                    break;
                case "Teal ":
                    result = "#00aba9";
                    break;
                case "Orange":
                    result = "#e3a21a";
                    break;
                case "Brown":
                    result = "#A05000";
                    break;
                case "Pink":
                    result = "#E671B8";
                    break;
                case "Magenta":
                    result = "#FF0097";
                    break;
                case "Purple":
                    result = "#7e3878";
                    break;
                case "Red":
                    result = "#ee1111";
                    break;
                case "Yellow":
                    result = "#ffc40d";
                    break;
                default:
                    result = "#2d89ef";
                    break;

            }
            return result;
        }
    }
}
