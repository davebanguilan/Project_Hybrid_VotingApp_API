using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingApp
{
    public interface IVotesServices
    {
        List<Vote> GetVotes();
        Vote GetVote(int id);
        Vote CreateVote(Vote vote);
        void DeleteVote(Vote vote);
        Vote EditVote(Vote vote);
    }
}
