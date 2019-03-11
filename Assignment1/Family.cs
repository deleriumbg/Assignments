using System.Collections.Generic;
using System.Linq;
using Assignment1.Contracts;

namespace Assignment1
{
    public class Family : IFamily
    {
        private readonly List<IPerson> _members;

        public Family()
        {
            this._members = new List<IPerson>();
        }

        public IReadOnlyCollection<IPerson> Members => this._members.AsReadOnly();

        public void AddMember(IPerson member)
        {
            this._members.Add(member);
        }

        public IPerson GetOldestMember()
        {
            return this._members
                .OrderByDescending(m => m.Age)
                .FirstOrDefault();
        }
    }
}
