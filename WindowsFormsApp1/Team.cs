using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Team
    {
        int TeamId;
       public string Name, Abbr, Logo;
        public void SetTeamAll(int TeamId, string Name, string Abbr, string Logo)
        {
            this.TeamId = TeamId;
            this.Name = Name;
            this.Abbr = Abbr;
            this.Logo = Logo;
        }
    }
}
