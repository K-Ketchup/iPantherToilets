using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPantherToilets
{

    public class FlyoutPrefsFlyoutMenuItem
    {
        public FlyoutPrefsFlyoutMenuItem()
        {
            TargetType = typeof(FlyoutPrefsFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}