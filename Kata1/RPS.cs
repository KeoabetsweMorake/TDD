using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata1
{
    public class RPS
    {
        public string play(string move1, string move2)
        {
            string result = "";

            if(move1 == "rock" && move2 == "rock")
            {
                result = "Tie";
            }
            if (move1 == "rock" && move2 == "paper")
            {
                result = "Player Losses";
            }
            if(move1 == "rock" && move2 == "scissor")
            {
                result = "Player Wins";
            }
            if(move1 == "rock" && move2 == "spock")
            {
                result = "Player Losses";
            }
            if (move1 == "paper" && move2 == "rock")
            {
                result = "Player Wins";
            }
            if (move1 == "paper" && move2 == "paper")
            {
                result = "Tie";
            }
            if(move1 == "paper" && move2 == "scissor")
            {
                result = "Player Losses";
            }
            if (move1 == "paper" && move2 == "spock")
            {
                result = "Player Wins";
            }
            if (move1 == "scissor" && move2 == "scissor")
            {
                result = "Tie";
            }
            if(move1 == "scissor" && move2 == "paper")
            {
                result = "Player Wins";
            }
            if(move1 == "scissor" && move2 == "rock")
            {
                result = "Player Losses";
            }
            if (move1 == "scissor" && move2 == "spock")
            {
                result = "Player Losses";
            }
            if (move1 == "spock" && move2 == "scissor")
            {
                result = "Player Wins";
            }
            if (move1 == "spock" && move2 == "paper")
            {
                result = "Player Losses";
            }
            if (move1 == "spock" && move2 == "rock")
            {
                result = "Player Wins";
            }
            return result;
        }
        
    }
}
