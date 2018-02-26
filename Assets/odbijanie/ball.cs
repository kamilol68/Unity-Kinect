using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class ball : MonoBehaviour {

    GameObject Gamecontroll;
    private GameControll gcontroll;
     // Use this for initialization
    void Start () {

        Gamecontroll = GameObject.Find("Menager");
       
        if (Gamecontroll == null)
        {
            Debug.Log("gamecontroll is null");
        }
        else
        {
            // gcontroll = Gamecontroll.GetComponent<GameControll>();
            gcontroll = GameControll.current;
        }

        Pull();
       
    }
 
    float Randomspeed()
    {
        float val = Random.Range(400, 800);
        return val;
    }
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("coll");
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("player");
            Debug.Log(gcontroll.hitcnt);
            gcontroll.hitcnt++;
            Debug.Log(gcontroll.hitcnt);
            switch (gcontroll.hitcnt)
            {
                case  5:
                    gcontroll.moddifier = 1.5f;
                    break;
                case 10:
                    gcontroll.moddifier = 2.0f;
                    break;
                case 15:
                    gcontroll.moddifier = 2.5f;
                    break;
            }
           
            gcontroll.points = gcontroll.points + (10 * gcontroll.moddifier);
        }
        if (col.gameObject.tag=="Target")
        {
            gcontroll.points = gcontroll.points + (20 * gcontroll.moddifier);
            Debug.Log("TARCZA");
        }
       
    }
    public void Pull()
    {
        Debug.Log("pull");
        GetComponent<Rigidbody>().AddForce(-Vector3.forward * Randomspeed());
    }

    public void Freeze()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        Pull();
    }
  
}
