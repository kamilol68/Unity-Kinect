using UnityEngine;
using System.Collections;

public class pccontrol : MonoBehaviour {

    public float maxspeed;
    Transform trackball;
	// Use this for initialization
	void Start () {
        trackball = GameObject.Find("Ball").transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (trackball.transform.position.y > gameObject.transform.position.y)
        {
            transform.Translate(new Vector3(0, maxspeed, 0) * Time.deltaTime);
        }
        if (trackball.transform.position.y < gameObject.transform.position.y)
        {
            transform.Translate(new Vector3(0, -maxspeed, 0) * Time.deltaTime);
        }

    }
}
