using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP1___Drop_Dead.Model

{   
    public class Game
    {
        public static int NUM_DICE_DROP_DEAD = 5;
        public static int NUM_DICE_FACE_DROP_DEAD = 6;
        
        private List<Player> players;
        private List<Dice> dice_set;
        private List<Round> rounds;
        
        // default c-tor
        public Game()
        {
            // Initialising Dice for game
            dice_set = new List<Dice>();
            for(int i = 0; i < NUM_DICE_DROP_DEAD; i++)
                dice_set.Add(new Dice(NUM_DICE_FACE_DROP_DEAD));
            
            players = new List<Player>();
            rounds = new List<Round>();
        }

        // getters/setters
        public List<Player> Players
        { 
            get{ return this.players; }
            set { }
        }
        public List<Dice> Dice_set
        {
            get{return this.dice_set;}
            set{this.dice_set = value;} 
        }

        public bool AddPlayer(Player p)
        {
            // checking for duplicate player
            foreach (var player in players)
            {
                if(player.Id == p.Id)
                    return false;
            }
            players.Add(p);
            return true;
        }

        public Round GetCurrentRound()
        {
            if(rounds.Count > 0)
                return rounds[rounds.Count - 1];
            else 
                return null;
        }

        // Avance le jeu de 1 lancement de dee
        public void Play()
        {
            if(rounds.Count == 0 || GetCurrentRound().Finished)
            {
                rounds.Add(new Round());
                Console.Write("\nRound #"  + rounds.Count);
            }
            
            int[] rolled = new int[GetCurrentRound().Current_player_available_nb_dice];
            Console.Write("\n" + players[GetCurrentRound().Current_player].Name + " rolled : [");

            for (int i = 0; i < GetCurrentRound().Current_player_available_nb_dice; i++)
            {
                rolled[i] = dice_set[i].Roll_dice();

                if(i < GetCurrentRound().Current_player_available_nb_dice)
                    Console.Write(rolled[i] + ",");
                else
                {
                    Console.Write(rolled[i]);
                }
            }
            Console.Write(" ]\n");
            
            Parse_dice_set(rolled, GetCurrentRound());
        } 

        // Game logic goes here !
        public void Parse_dice_set(int[] dices, Round round)
        {
            // checking for dice that are equal to 2 or 5 and flagging them for removal
            int remove_count = 0;
            foreach(int d in dices)
            {
                if(d == 2 ||d == 5)
                    remove_count++;
            }
            int id = players[GetCurrentRound().Current_player].Id;
            round.Add_player_rolls(id , dices);

            Console.Write("ROUND SCORE: " + GetCurrentRound().Calc_player_round_score(id,GetCurrentRound().Player_score_map[id].Count-1));
            Console.Write("\nTOTAL SCORE: " + GetCurrentRound().Calc_player_total_score(id));

            // applying removal to round count;
            round.Current_player_available_nb_dice = round.Current_player_available_nb_dice - remove_count;

            if(round.Current_player_available_nb_dice <= 0)
            {
                // if player has no available dice, moving to next player
                //round.Current_player = round.Current_player + 1;
                round.NextPlayer();
                round.ResetDice();

                if(round.Current_player == players.Count)
                {
                    round.TerminateRound();
                    foreach(Player p in this.players)
                    {
                        p.Game_score += GetCurrentRound().Calc_player_total_score(p.Id);
                    }
                }
            }
            
        }
    }
}
