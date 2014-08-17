using System;
using System.Collections.Generic;
using System.Text;

namespace NumReader
{
    public class num2uystring
    {
        public static string numstr2str(string numstr)
        {
            if (numstr.Length > 18) return "خانە سانى ئون سەككىزدىن يۇقىرى بولمىسۇن";
            if (numstr == "0") return "نۆل";
            string strstr = "";
            for (int i = 0; i < numstr.Length; i++)
            {
                char digit = numstr[i];
                if ((numstr.Length - i) % 3 == 0 || (numstr.Length - i) % 3 == 1)
                {
                    switch (digit)
                    {
                        case '1':
                            strstr = strstr + "بىر ";
                            break;
                        case '2':
                            strstr = strstr + "ئىككى ";
                            break;
                        case '3':
                            strstr = strstr + "ئۈچ ";
                            break;
                        case '4':
                            strstr = strstr + "تۆت ";
                            break;
                        case '5':
                            strstr = strstr + "بەش ";
                            break;
                        case '6':
                            strstr = strstr + "ئالتە ";
                            break;
                        case '7':
                            strstr = strstr + "يەتتە ";
                            break;
                        case '8':
                            strstr = strstr + "سەككىز ";
                            break;
                        case '9':
                            strstr = strstr + "توققۇز ";
                            break;
                        case '0':
                            break;
                        default:
                            return "ساندىن باشقا ھەرپ بەلگىلەرنى كىرگۈزمەڭ!";
                    }
                }
                if ((numstr.Length - i) % 3 == 2)
                {
                    switch (digit)
                    {
                        case '1':
                            strstr = strstr + "ئون ";
                            break;
                        case '2':
                            strstr = strstr + "يىگىرمە ";
                            break;
                        case '3':
                            strstr = strstr + "ئوتتۇز ";
                            break;
                        case '4':
                            strstr = strstr + "قىرىق ";
                            break;
                        case '5':
                            strstr = strstr + "ئەللىك ";
                            break;
                        case '6':
                            strstr = strstr + "ئاتمىش ";
                            break;
                        case '7':
                            strstr = strstr + "يەتمىش ";
                            break;
                        case '8':
                            strstr = strstr + "سەكسەن ";
                            break;
                        case '9':
                            strstr = strstr + "توقسان ";
                            break;
                        case '0':
                            break;
                        default:
                            return "ساندىن باشقا ھەرپ بەلگىلەرنى كىرگۈزمەڭ!";

                    }
                }
                if ((numstr.Length - i) % 3 == 0 && numstr[i] != '0')
                {
                    strstr = strstr + "يۈز ";
                }
                if ((numstr.Length - i) / 16 == 1 && (numstr.Length - i) % 16 == 0)
                {
                    if (numstr[numstr.Length - 16] == '0' && numstr[numstr.Length - 17] == '0' && numstr[numstr.Length - 18] == '0') continue;
                    else strstr = strstr + "تىرلىيارد ";
                }
                if ((numstr.Length - i) / 13 == 1 && (numstr.Length - i) % 13 == 0)
                {
                    if (numstr[numstr.Length - 13] == '0' && numstr[numstr.Length - 14] == '0' && numstr[numstr.Length - 15] == '0') continue;
                    else strstr = strstr + "تىرلىيۇن ";
                }
                if ((numstr.Length - i) / 10 == 1 && (numstr.Length - i) % 10 == 0)
                {
                    if (numstr[numstr.Length - 10] == '0' && numstr[numstr.Length - 11] == '0' && numstr[numstr.Length - 12] == '0') continue;
                    else strstr = strstr + "مىلىيارد ";
                }
                if ((numstr.Length - i) / 7 == 1 && (numstr.Length - i) % 7 == 0)
                {
                    if (numstr[numstr.Length - 7] == '0' && numstr[numstr.Length - 8] == '0' && numstr[numstr.Length - 9] == '0') continue;
                    else strstr = strstr + "مىلىيۇن ";
                }
                if ((numstr.Length - i) / 4 == 1 && (numstr.Length - i) % 4 == 0)
                {
                    if (numstr[numstr.Length - 4] == '0' && numstr[numstr.Length - 5] == '0' && numstr[numstr.Length - 6] == '0') continue;
                    else strstr = strstr + "مىڭ ";
                }
            }
            return strstr;
        }
    }
}
