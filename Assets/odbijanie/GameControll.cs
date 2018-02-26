using UnityEngine;
using System.Collections;

public class GameControll : MonoBehaviour {
    public int lives=3;
    public float points= 0;
    public float moddifier = 1;
    public int hitcnt = 0;
    public GameObject ball;
    public static GameControll current;
    public GameObject Points;
    private Points _Points;
    public GameObject Mod;
    private Mod _Mod;
    public GameObject Lives;
    private Lives _Lives;
    public GameObject Hit;
    private Hit _Hit;
    // Use this for initialization
   
    void Start () {

        current = this;
        _Hit = Hit.GetComponent<Hit>();
        _Lives = Lives.GetComponent<Lives>();
        _Mod = Mod.GetComponent<Mod>();
        _Points = Points.GetComponent<Points>();

        
	
	}
    void Update()
    {
        _Hit._hits.text = "HITS : "+hitcnt.ToString();
        _Lives._lives.text = "BALLS  : " +lives.ToString();
        _Mod.moddifier.text = "COMBO : "+ moddifier.ToString()+"x";
        _Points._points.text ="POINTS : "+ points.ToString();
    }
   public void Spawnball()
    {
        StartCoroutine(safeWaitAndBugger(5f, 0.5f));   
    }

    public void NewGame()
    {
        Debug.Log("NEW GAME1111111");
        points = 0;
        hitcnt = 0;
        moddifier = 1;
        lives = 3;
        Spawnball();
    }
    IEnumerator safeWaitAndBugger(float waitTime, float timeIncrement)  // wait time 10s incremented 0.5f
    {
        float finishTime = Time.time + waitTime;
        Debug.Log("w8 m8");
        while (Time.time < finishTime)
        {
            yield return new WaitForSeconds(timeIncrement);

        }
        Debug.Log("NEW BALL");
        Vector3 pos = new Vector3(Random.Range(-7, 7), Random.Range(0, 5), 20);
        GameObject newBall = Instantiate(ball, pos, Quaternion.identity) as GameObject;
        DetectJoints.Current.ball = newBall;
        DetectJoints.Current.reBall();

    }

}
