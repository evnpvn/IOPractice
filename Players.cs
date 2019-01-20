using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SoccerStats
{
    public class RootObject
    {
        public Player[] Players { get; set; }
    }
    
    public class Player
    {
        [J("assists")]                      public long Assists { get; set; }                  
        [J("big_chances_created")]          public long BigChancesCreated { get; set; }        
        [J("blocks")]                       public long Blocks { get; set; }                   
        [J("chance_of_playing_next_round")] public long? ChanceOfPlayingNextRound { get; set; }
        [J("chance_of_playing_this_round")] public long? ChanceOfPlayingThisRound { get; set; }
        [J("clean_sheets")]                 public long CleanSheets { get; set; }              
        [J("clearances")]                   public long Clearances { get; set; }               
        [J("code")]                         public long Code { get; set; }                     
        [J("cost_change_event")]            public long CostChangeEvent { get; set; }          
        [J("cost_change_event_fall")]       public long CostChangeEventFall { get; set; }      
        [J("cost_change_start")]            public long CostChangeStart { get; set; }          
        [J("cost_change_start_fall")]       public long CostChangeStartFall { get; set; }      
        [J("crosses")]                      public long Crosses { get; set; }                  
        [J("dreamteam_count")]              public long DreamteamCount { get; set; }           
        [J("element_type")]                 public long ElementType { get; set; }              
        [J("ep_next")]                      public string EpNext { get; set; }                 
        [J("ep_this")]                      public string EpThis { get; set; }                 
        [J("errors_leading_to_goal")]       public long ErrorsLeadingToGoal { get; set; }      
        [J("event_points")]                 public long EventPoints { get; set; }              
        [J("first_name")]                   public string FirstName { get; set; }              
        [J("form")]                         public string Form { get; set; }                   
        [J("goals_conceded")]               public long GoalsConceded { get; set; }            
        [J("goals_scored")]                 public long GoalsScored { get; set; }              
        [J("id")]                           public long Id { get; set; }                       
        [J("in_dreamteam")]                 public bool InDreamteam { get; set; }              
        [J("interceptions")]                public long Interceptions { get; set; }            
        [J("key_passes")]                   public long KeyPasses { get; set; }                
        [J("loaned_in")]                    public long LoanedIn { get; set; }                 
        [J("loaned_out")]                   public long LoanedOut { get; set; }                
        [J("loans_in")]                     public long LoansIn { get; set; }                  
        [J("loans_out")]                    public long LoansOut { get; set; }                 
        [J("minutes")]                      public long Minutes { get; set; }                  
        [J("news")]                         public string News { get; set; }                   
        [J("now_cost")]                     public long NowCost { get; set; }                  
        [J("own_goal_earned")]              public long OwnGoalEarned { get; set; }            
        [J("own_goals")]                    public long OwnGoals { get; set; }                 
        [J("pass_completion")]              public long PassCompletion { get; set; }           
        [J("penalties_conceded")]           public long PenaltiesConceded { get; set; }        
        [J("penalties_earned")]             public long PenaltiesEarned { get; set; }          
        [J("penalties_missed")]             public long PenaltiesMissed { get; set; }          
        [J("penalties_saved")]              public long PenaltiesSaved { get; set; }           
        [J("photo")]                        public Uri Photo { get; set; }                     
        [J("points_per_game")]              public double PointsPerGame { get; set; }          
        [J("position")]                     public Position Position { get; set; }             
        [J("recoveries")]                   public long Recoveries { get; set; }               
        [J("red_cards")]                    public long RedCards { get; set; }                 
        [J("saves")]                        public long Saves { get; set; }                    
        [J("second_name")]                  public string SecondName { get; set; }             
        [J("selected_by_percent")]          public string SelectedByPercent { get; set; }      
        [J("shots")]                        public long Shots { get; set; }                    
        [J("special")]                      public bool Special { get; set; }                  
        [J("status")]                       public Status Status { get; set; }                 
        [J("tackles")]                      public long Tackles { get; set; }                  
        [J("team")]                         public long Team { get; set; }                             
        [J("total_points")]                 public long TotalPoints { get; set; }              
        [J("transfers_in")]                 public long TransfersIn { get; set; }              
        [J("transfers_in_event")]           public long TransfersInEvent { get; set; }         
        [J("transfers_out")]                public long TransfersOut { get; set; }             
        [J("transfers_out_event")]          public long TransfersOutEvent { get; set; }        
        [J("value_form")]                   public string ValueForm { get; set; }              
        [J("value_season")]                 public string ValueSeason { get; set; }            
        [J("was_fouled")]                   public long WasFouled { get; set; }                
        [J("web_name")]                     public string WebName { get; set; }                
        [J("yellow_cards")]                 public long YellowCards { get; set; }              
    }
    
    public enum Position { Defender, Forward, Goalkeeper, Midfielder };

    public enum Status { A, D, I, N, S, U };

    public enum TeamName { ChicagoFire, ColoradoRapids, ColumbusCrewSc, DCUnited, FcDallas, HoustonDynamo, LaGalaxy, MontrealImpact, NewEnglandRevolution, NewYorkCityFc, NewYorkRedBulls, OrlandoCitySc, PhiladelphiaUnion, PortlandTimbers, RealSaltLake, SanJoseEarthquakes, SeattleSoundersFc, SportingKansasCity, TorontoFc, VancouverWhitecaps };
 
}