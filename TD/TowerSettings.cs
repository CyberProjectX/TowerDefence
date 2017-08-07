using System.Collections.Generic;

namespace TD
{
    public class TowerSettings : TowerStats
    {
        public IEnumerable<AuraInfo> Auras
        {
            get;
            set;
        }
    }
}