using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoccerStats
{
    public class RootObject
    {
        public Player[] Players { get; set; }
    }

    public class Player
    {
        public long Assists { get; set; }
        public long BigChancesCreated { get; set; }
        public long Blocks { get; set; }
        public long? ChanceOfPlayingNextRound { get; set; }
        public long? ChanceOfPlayingThisRound { get; set; }
        public long CleanSheets { get; set; }
        public long Clearances { get; set; }
        public long Code { get; set; }
        public long CostChangeEvent { get; set; }
        public long CostChangeEventFall { get; set; }
        public long CostChangeStart { get; set; }
        public long CostChangeStartFall { get; set; }
        public long Crosses { get; set; }
        public long DreamteamCount { get; set; }
        public long ElementType { get; set; }
        public string EpNext { get; set; }
        public string EpThis { get; set; }
        public long ErrorsLeadingToGoal { get; set; }
        public long EventPoints { get; set; }
        public string FirstName { get; set; }
        public string Form { get; set; }
        public long GoalsConceded { get; set; }
        public long GoalsScored { get; set; }
        public long Id { get; set; }
        public bool InDreamteam { get; set; }
        public long Interceptions { get; set; }
        public long KeyPasses { get; set; }
        public long LoanedIn { get; set; }
        public long LoanedOut { get; set; }
        public long LoansIn { get; set; }
        public long LoansOut { get; set; }
        public long Minutes { get; set; }
        public string News { get; set; }
        public long NowCost { get; set; }
        public long OwnGoalEarned { get; set; }
        public long OwnGoals { get; set; }
        public long PassCompletion { get; set; }
        public long PenaltiesConceded { get; set; }
        public long PenaltiesEarned { get; set; }
        public long PenaltiesMissed { get; set; }
        public long PenaltiesSaved { get; set; }
        public Uri Photo { get; set; }
        public string PointsPerGame { get; set; }
        public Position Position { get; set; }
        public long Recoveries { get; set; }
        public long RedCards { get; set; }
        public long Saves { get; set; }
        public string SecondName { get; set; }
        public string SelectedByPercent { get; set; }
        public long Shots { get; set; }
        public bool Special { get; set; }
        public Status Status { get; set; }
        public long Tackles { get; set; }
        public long Team { get; set; }
        public TeamName TeamName { get; set; }
        public long TotalPoints { get; set; }
        public long TransfersIn { get; set; }
        public long TransfersInEvent { get; set; }
        public long TransfersOut { get; set; }
        public long TransfersOutEvent { get; set; }
        public string ValueForm { get; set; }
        public string ValueSeason { get; set; }
        public long WasFouled { get; set; }
        public string WebName { get; set; }
        public long YellowCards { get; set; }
    }

}
    public enum Position { Defender, Forward, Goalkeeper, Midfielder };

    public enum Status { A, D, I, N, S, U };

    public enum TeamName { ChicagoFire, ColoradoRapids, ColumbusCrewSc, DCUnited, FcDallas, HoustonDynamo, LaGalaxy, MontrealImpact, NewEnglandRevolution, NewYorkCityFc, NewYorkRedBulls, OrlandoCitySc, PhiladelphiaUnion, PortlandTimbers, RealSaltLake, SanJoseEarthquakes, SeattleSoundersFc, SportingKansasCity, TorontoFc, VancouverWhitecaps };
