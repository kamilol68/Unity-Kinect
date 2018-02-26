using UnityEngine;
using System.Collections;
using Windows.Kinect;
public class Detect : MonoBehaviour
{

    public GameObject BodyScrMenager;
    public JointType TracedJoint;
    private BodySourceManager bodymenager;
    private Body[] bodies;
    public GameObject menager;
    private Gamemenager gmenager;
    public GameObject showhand;
    private _Hand hand;
    public GameObject shand;
    private StateofHand state;


    // Use this for initialization
    void Start()
    {
        bodymenager = BodyScrMenager.GetComponent<BodySourceManager>();
        gmenager = menager.GetComponent<Gamemenager>();
        hand = showhand.GetComponent<_Hand>();
        state = shand.GetComponent<StateofHand>();

    }

    // Update is called once per frame
    void Update()
    {
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
            if (body == null)
            {
                continue;
            }
            if (body.IsTracked)
            {
               gmenager.shand = body.HandRightState;
               Debug.Log(gmenager.shand);
               hand.stateofhand.text = state.GetRPSSTATE(body.HandRightState);
               // Debug.Log("done");
               
            }

        }
    }
}
