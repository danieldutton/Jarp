using System.Collections.Generic;

namespace ProjectX.Tests
{
    public static class Mother
    {        
        public static Dictionary<string, string> GetSimpleKeyWordMap()
        {
            var dic = new Dictionary<string, string>
                          {
                              {"boolean", "bool"},
                              {"const", "static"},
                              {"inherits", ":"},
                              {"test", "testy"},
                              {"bum", "bumchum"}
                          };

            return dic;
        }

        public static Dictionary<string, string> GetNullValueKeyWordMap()
        {
            var kwordMap = new Dictionary<string, string>
                          {
                              {"boolean", "bool"},
                              {null, null},
                              {"inherits", ":"},
                              {"test", "testy"},
                              {"bum", "bumchum"}
                          };

            return kwordMap;
        }
 

    }
}
