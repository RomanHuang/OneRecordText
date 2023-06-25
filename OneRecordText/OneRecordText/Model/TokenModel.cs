using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordText.Model
{
    public class TokenModel
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string resource { get; set; }
        public long not_before { get; set; }
        public long expires_in { get; set; }
        public long expires_on { get; set; }
    }
}
