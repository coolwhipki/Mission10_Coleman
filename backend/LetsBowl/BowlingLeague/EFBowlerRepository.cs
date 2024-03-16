
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LetsBowl.BowlingLeague
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext context;
        public EFBowlerRepository(BowlerContext temp) 
        {
            context = temp;
        }

        public IEnumerable<object> GetAllBowlersWithTeams()
        {
            var joinedData = from bowler in context.Bowlers
                             join team in context.Teams on bowler.TeamID equals team.TeamID
                             where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                             select new // Anonymous object

                             {

                                 BowlerID = bowler.BowlerID,

                                 BowlerName = $"{bowler.BowlerFirstName} {(bowler.BowlerMiddleInit ?? "")} {bowler.BowlerLastName}",

                                 TeamName = team.TeamName,

                                 Address = bowler.BowlerAddress ?? "No address provided",

                                 City = bowler.BowlerCity ?? "No city provided",

                                 State = bowler.BowlerState ?? "No state provided",

                                 Zip = bowler.BowlerZip ?? "No ZIP provided",

                                 PhoneNumber = bowler.BowlerPhoneNumber ?? "No phone number provided"

                             };

            return joinedData.ToList();
        }

        
        public IEnumerable<Bowler> Bowlers => context.Bowlers;
        public IEnumerable<Team> Teams => context.Teams;


    }
}
