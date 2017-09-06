using Apttus.Assignment.MovieTicket;
using System.Collections.Generic;

namespace Apttus.MovieTicket.DAL
{
    public interface IDataAccessor
    {
        List<Persons> GetMembersDetails();
    }
}