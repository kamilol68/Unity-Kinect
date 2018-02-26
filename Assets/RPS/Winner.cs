using UnityEngine;
using System.Collections;

public class Winner : MonoBehaviour {

    public string winner = "";

    public string CheckWinner(string player, string pc)
    {
        if (player == "Rock")
        {
            if (pc == "Rock")
            {
                winner = "DRAW";
            }
            else if(pc == "Scissors")
            {
                winner = "Player";
            }
            else
            {
                winner = "PC";
            }
        }
        else if (player == "Scissors")
        {
            if (pc == "Rock")
            {
                winner = "PC";
            }
            else if (pc == "Scissors")
            {
                winner = "DRAW";
            }
            else
            {
                winner = "Player";
            }
        }
        else if (player == "Paper")
        {
                if (pc == "Rock")
                {
                    winner = "Player";
                }
                else if (pc == "Scissors")
                {
                    winner = "PC";
                }
                else
                {
                    winner = "DRAW";
                }
        }
        else
        {
            winner = "Error";
            Debug.Log("No Hand state");
        }

        return winner;
    }
}
