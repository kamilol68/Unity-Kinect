using UnityEngine;
using System.Collections;

public class Roll : MonoBehaviour {
    string pc = " ";
    int r;
    public string Pcroll()
    {
       r= Random.Range(0, 2);
        if (r==0)
        {
            pc = "Scissors";
        }
        else if (r == 1)
        {
            pc = "Rock";
        }
        else
        {
            pc = "Paper";
        }
        return pc;
    }
}
