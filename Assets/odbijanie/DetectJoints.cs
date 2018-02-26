using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class DetectJoints : MonoBehaviour {

    public GameObject BodyScrMenager;
    public JointType TracedJoint;
    private BodySourceManager bodymenager;
    private Body[] bodies;
    public float mod = 1f;
    public HandState hand;
    public GameObject ball;
    private ball _ball;
    public static DetectJoints Current;
            
	// Use this for initialization
	void Start () {
            Current = this;
            bodymenager = BodyScrMenager.GetComponent<BodySourceManager>();
            _ball = ball.GetComponent<ball>();

    }

    public void reBall()
    {
        _ball = ball.GetComponent<ball>();
    }

    // Update is called once per frame
    void Update () {
        if (bodymenager == null)
        {
            return;
        }
        bodies = bodymenager.GetData();
        if (bodies == null)
        {
            return;
        }
        foreach (var body in bodies)
        {
            if (body==null)
            {
                continue;
            }
            if (body.IsTracked)
            {
                Debug.Log("Handling body");
                var pos = body.Joints[TracedJoint].Position;
                gameObject.transform.position = new Vector3(pos.X * mod,pos.Y*mod);
                hand = body.HandRightState;
                if (hand == HandState.Closed)
                {
                    Debug.Log("Pulling ze ball");
                    _ball.Freeze();
                }
            }
        }
       
	}
}
