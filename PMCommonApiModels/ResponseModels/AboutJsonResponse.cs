using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonApiModels.ResponseModels
{
    public class AboutJsonResponse
    {
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public string ServerId { get; set; }
        public string Environment { get; set; }
        public bool DataSyncEnabled { get; set; }
        public string Copyright { get; set; }
    }
}
