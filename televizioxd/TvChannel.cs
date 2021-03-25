using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace televizioxd {
    public class TvChannel {
        public string Name { get; }
        public string Description { get; }
        public bool IsAdult { get; }
        public bool IsPremium { get; }
        public TvChannel(string name, string description, bool isadult, bool ispremium) {
            Name = name;
            Description = description;
            IsAdult = isadult;
            IsPremium = ispremium;
        }
        public bool CanWatch(bool _CanWatchAdult, bool _HasPremium) => ((IsAdult && _CanWatchAdult) || !IsAdult) && ((IsPremium && _HasPremium) || !IsPremium);
    }
}
