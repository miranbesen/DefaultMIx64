using MapInfo.Types;
using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultMIx64.Helpers
{
    public class MapInfoClass
    {
        public IMapInfoApplication miApp;
        public bool IsMapInfoInstalled = true;

        public MapInfoClass(IMapInfoApplication _miApp)
        {
            miApp = _miApp;
        }

        public MapInfoClass()
        { }


        public static MapInfoClass Instance
        {
            get;
            set;
        }

        public static bool MapinfoControl()
        {
            try
            {
                var a = Registry.LocalMachine.OpenSubKey("SOFTWARE").OpenSubKey("MaPInfo").OpenSubKey("MapInfo").OpenSubKey("Professional").OpenSubKey("1250");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string Eval(string str)
        {
            try
            {
                return miApp.EvalMapBasicCommand(str);
            }
            catch
            {
                return null;
            }
        }

        public void Do(string strCmd)
        {
            miApp.RunMapBasicCommand(strCmd, true, false);
        }
    }
}
