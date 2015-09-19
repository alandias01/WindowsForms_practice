using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.IO;


namespace WindowsForms_practice.HK
{
    public partial class HKForm : Form
    {
        StringBuilder txt_Log = new StringBuilder();

        private Stack<string> _appNames = new Stack<string>();
        private Dictionary<string, string> _logData = new Dictionary<string, string>();

        public HKForm()
        {
            InitializeComponent();
            
            //GetP();
        }

        



        public void test()
        {
            //http://www.youtube.com/watch?v=v9r-MpFMkGA
        }

        
        public void GetP()
        {
            Thread.Sleep(3000);
            Process p = Process.GetProcessById(APIs.GetWindowProcessID(APIs.getforegroundWindow()));

            string _appName = p.ProcessName;
            string _appltitle = APIs.ActiveApplTitle().Trim().Replace("\0", "");
            string _thisapplication = _appltitle + "######" + _appName;
 
        }

        private void Logger(string txt)
        {
            
            txt_Log.AppendLine(txt);
            

            try
            {
                Process p = Process.GetProcessById(APIs.GetWindowProcessID(APIs.getforegroundWindow()));
                string _appName = p.ProcessName;
                string _appltitle = APIs.ActiveApplTitle().Trim().Replace("\0", "");
                string _thisapplication = _appltitle + "######" + _appName;
                if (!_appNames.Contains(_thisapplication))
                {
                    _appNames.Push(_thisapplication);
                    _logData.Add(_thisapplication, "");
                }
                var en = _logData.GetEnumerator();
                while (en.MoveNext())
                {
                    var pair = en.Current;
                    if (pair.Key.ToString() == _thisapplication)
                    {
                        string prlogdata = pair.Value.ToString();
                        _logData.Remove(_thisapplication);
                        _logData.Add(_thisapplication, prlogdata + " " + txt);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ":" + ex.StackTrace);
                throw;
            }
        }

        
    }
}
