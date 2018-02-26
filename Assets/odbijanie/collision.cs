using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

 
    public GameObject Gamecontroll;
    private GameControll gcontroll;
	// Use this for initialization
	void Start () {
        Gamecontroll = GameObject.Find("Menager");
        gcontroll = Gamecontroll.GetComponent<GameControll>();
        Debug.Log(gcontroll.lives);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        // wall of death
        if (col.gameObject.tag == "Ball")
        {
            gcontroll.lives = gcontroll.lives - 1;
            
            gcontroll.hitcnt = 0;
            gcontroll.moddifier = 1;
            Debug.Log(gcontroll.lives);
            Destroy(col.gameObject);
            if (gcontroll.lives < 1)
            {
                Debug.Log("game over ");
            }
            else
            {
                gcontroll.Spawnball();
            }
           
        }
    }

}
