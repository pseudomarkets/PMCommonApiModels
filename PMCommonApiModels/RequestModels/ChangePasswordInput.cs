using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonApiModels.RequestModels
{
    public class ChangePasswordInput
    {
        public string username { get; set; }
        public string old_password { get; set; }
        public string new_password { get; set; }
    }
}
