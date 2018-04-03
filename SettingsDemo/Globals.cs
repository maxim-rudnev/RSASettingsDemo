using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSASettingsDemo
{
    public static class Globals
    {
        /// <summary>
        /// Относительный путь к файлу с настройками приложения. Будет находится в папке с исполняемым файлом
        /// </summary>
        public static readonly string SettingsFile = "Settings.xml";
    }
}
