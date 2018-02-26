using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class StateofHand : MonoBehaviour {

	// Use this for initialization
    public string GetRPSSTATE(HandState hand)
    {
        switch (hand)
       {
              case HandState.Closed:
                return "Rock";
              case HandState.Open:
                return "Paper";
              case HandState.Lasso:
                return "Scissors";
        }
        return "Undefined";
        
    }
}
