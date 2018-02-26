using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class _Player1_move : MonoBehaviour {


    public GameObject BodyScrMenager;
    public JointType TracedJoint;
    private BodySourceManager bodymenager;
    private Body[] bodies;
    void Start () {
        bodymenager = BodyScrMenager.GetComponent<BodySourceManager>();
	
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
            if (body == null)
            {
                continue;
            }
            if (body.IsTracked)
            {
               
                var pos = body.Joints[TracedJoint].Position;
                gameObject.transform.position = new Vector3(-8, pos.Y * 15);
               
            }
        }

    }
}
