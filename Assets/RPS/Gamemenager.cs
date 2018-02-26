using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class Gamemenager : MonoBehaviour {
    public string score;
    public HandState shand;
    public string pc;
    public string hand;
    public int scoreplayer;
    public int scorepc;
    public GameObject sthand;
    private StateofHand statehand;
    public GameObject roll;
    private Roll r;
    public GameObject winner;
    private Winner win;
    public GameObject player;
    private player playerhand;
    public GameObject pchand;
    private pc pcstate;
    public GameObject playerscore;
    private playerscore plscore;
    public GameObject _pcscore;
    private pcscore pcscr;
    

    // Use this for initialization
    void Start () {
        statehand = sthand.GetComponent<StateofHand>();
        r = roll.GetComponent<Roll>();
        win = winner.GetComponent<Winner>();
        playerhand = player.GetComponent<player>();
        pcstate = pchand.GetComponent<pc>();
        pcscr = _pcscore.GetComponent<pcscore>();
        plscore = playerscore.GetComponent<playerscore>();
        scorepc = 0;
        scoreplayer = 0;
    }
    public void Game()
    {
        Clean();
        hand = statehand.GetRPSSTATE(shand);
        playerhand.playerstate.text = hand;
        pc = r.Pcroll();
        pcstate.pcshandtate.text = pc;
        score = win.CheckWinner(hand, pc);
        if (score == "Player")
        {
            scoreplayer++;
        }
        if (score == "PC")
        {
            scorepc++;
        }
        plscore.playerpoints.text = "Your score : " + scoreplayer;
        pcscr.pcpoints.text = "PC score : " + scorepc; 
    }
    void Clean()
    {
        pc = null;
        hand = null;
    }
 }
