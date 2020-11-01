using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1___Drop_Dead.Model
{
    class Round
    {
        private static int ROUND_COUNT = 0;

        private int round_number = -1;
        private bool finished = false;
        private int current_player = -1;
        private int current_player_available_nb_dice = -1;
        // int == player ID
        // List<int[]> == all throw score for that player round
        private Dictionary<int, List<int[]>> player_score_map;

        public Round()
        {
            this.round_number = ++ROUND_COUNT;
            this.current_player = 0;
            this.current_player_available_nb_dice = Game.NUM_DICE_DROP_DEAD;
            this.player_score_map = new Dictionary<int, List<int[]>>();
        }

        public int Round_number
        {
            get { return this.round_number; }
            set { this.round_number = value; }
        }
        public bool Finished
        {
            get { return this.finished; }
            set { this.finished = value; }
        }
        public Dictionary<int, List<int[]>> Player_score_map
        {
            get { return this.player_score_map; }
            set { this.player_score_map = value; }
        }

        public int Current_player
        {
            get { return current_player; }
            set{ current_player = value; }
        }

        public int Current_player_available_nb_dice
        {
            get { return current_player_available_nb_dice; }
            set{ current_player_available_nb_dice = value; }
        }

        public void NextPlayer()
        {
            Current_player++;
        }

        public void ResetDice()
        {
            this.current_player_available_nb_dice = Game.NUM_DICE_DROP_DEAD;
        }

        public void TerminateRound()
        {
            this.finished = true;
        }

        public void Add_player_rolls(int player_id, int[] score)
        {
            if (player_id >= 0 && score.Length > 0){
                List<int[]> cur_scores = new List<int[]>();
                try{
                    cur_scores = player_score_map[player_id];
                }catch(Exception e){
                    //Console.WriteLine("ERROR :" + e);
                }
                cur_scores.Add(score);
                player_score_map[player_id] = cur_scores;
            }
        }

        public int Calc_player_round_score(int player_id, int round_nb)
        {
            try{
                int[] p_sc = player_score_map[player_id][round_nb];int score = 0;

                for(int i = 0; i < p_sc.Length; i++)
                {
                    if(p_sc[i] == 2 || p_sc[i] == 5)
                        return 0;
                    else
                        score += p_sc[i];
                }
                return score;

            }catch(Exception e)
            {
                Console.WriteLine("Player ID:" + player_id + " Not found !");
            }
            return 0;
        }

        public int Calc_player_total_score(int player_id)
        {
            int score = 0;
            try{
                for(int i = 0; i < player_score_map[player_id].Count; i++)
                {
                        score += Calc_player_round_score(player_id, i);
                }
            }catch(Exception e)
            {
                Console.WriteLine("Player ID:" + player_id + " Not found !");
            }
            return score;
        }
    }
}
