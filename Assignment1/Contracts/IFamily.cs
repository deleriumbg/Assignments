using System.Collections.Generic;

namespace Assignment1.Contracts
{
    public interface IFamily
    {
        IReadOnlyCollection<IPerson> Members { get; }

        void AddMember(IPerson member);

        IPerson GetOldestMember();
    }
}
