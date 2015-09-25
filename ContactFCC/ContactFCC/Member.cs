using System;
using System.Collections.Generic;
using System.Text;

namespace ContactFCC
{
    class Member
    {
        public string MemberName { get; set; }
        public string URL { get; set; }

        public Member(string name, string URL)
        {
            MemberName = name;
            this.URL = URL;
        }
      
    }
}
