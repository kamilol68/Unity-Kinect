using UnityEngine;
using System.Collections;

public class _pongball : MonoBehaviour
{
    Rigidbody r;
    public float speed;
    public GameObject _menager;
    private _menager menager;
    void Start()
    {
        speed = 10;
        menager = _menager.GetComponent<_menager>();
        r = GetComponent<Rigidbody>();
    }
    void Move()
    {
        transform.position = new Vector3(0,0,0);
        r.velocity = new Vector3(Mathf.Sign(Random.value - 0.5f),(Random.value - 0.5f) * 2, 0);
        r.velocity *= speed;
    }
    public void Go()
    {
        StartCoroutine(Wait(4,0.5f));
    }
    IEnumerator Wait(float waitTime, float timeIncrement)  // wait time 10s incremented 0.5f
    {
        float finishTime = Time.time + waitTime;
        while (Time.time < finishTime)
        {
            Debug.Log("its gr8");
            Debug.Log(finishTime - Time.time);
            yield return new WaitForSeconds(timeIncrement);

        }

        // Actual code to be executed after
        Move();
    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "LEFTWALL")
        {
            menager.pointb++;
            Move();
        }
        if (col.gameObject.name == "RIGHTWALL")
        {
            menager.pointa++;
            Move();
        }
    }
}
