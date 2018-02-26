using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class _menager : MonoBehaviour {

    public float pointa;
    public float pointb;
    public GameObject pong;
    private _pongball ball;
    public GameObject pcscore;
    private pc_score pc_scr;
    public GameObject playerscore;
    private player1_score player_score;
	// Use this for initialization
	void Start () {
        ball = pong.GetComponent<_pongball>();
        pc_scr = pcscore.GetComponent<pc_score>();
        player_score = playerscore.GetComponent<player1_score>();
	}
	
	// Update is called once per frame
	void Update () {
       pc_scr.pcpoints.text = "SCORE: " + pointb;
        player_score.playerscore.text = "SCORE: " + pointa;
	}
    public void ButtonExit()
    {
        SceneManager.LoadScene("START");
    }
    public void ButtonStart()
    {
        ball.Go();
    }
}
