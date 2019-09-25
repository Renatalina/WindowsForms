using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBuilds
{
    static class ImportExport
    {
        public static string FIO { get; set; }
        public static string BORN { get; set; }
        public static string SEX { get; set; }
        public static string COUNTRY { get; set; }
        public static string CITY { get; set; }
        public static int HEIGHT { get; set; }
        public static int WEIDTH { get; set; }
        public static string HAIR { get; set; }
        public static string EYE { get; set; }
        public static string FAIND { get; set; }
        public static string WhatFaind { get; set; }
        public static void Clear()
        {
            FIO = null;
            BORN = null;
            SEX = null;
            COUNTRY = null;
            CITY = null;
            HEIGHT = 0;
            WEIDTH = 0;
            HAIR = null;
            EYE = null;
        }
    }
}
