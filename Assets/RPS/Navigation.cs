using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour {
    public GameObject menager;
    private Gamemenager gmenager;
    public GameObject fix;
    private Fixtext fixtext;
    
    
    
    void Start()
    {
        gmenager = menager.GetComponent<Gamemenager>();
        fixtext = fix.GetComponent<Fixtext>();
    }
    // Use this for initialization
    public void ClickStart()
    {
        StartCoroutine(Wait(10f, 0.5f)); // Timer on!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    }
    /*IEnumerator Timer()
    {
        Debug.Log("Wait start");
        yield return new WaitForSeconds(10);
        Debug.Log("Wait End");

        gmenager.Game();

    }*/
    IEnumerator Wait(float waitTime, float timeIncrement)  // wait time 10s incremented 0.5f
    {
        float finishTime = Time.time + waitTime;
        Debug.Log("w8 m8");
        while (Time.time < finishTime)
        {
            Debug.Log("its gr8");
            Debug.Log(finishTime - Time.time);
            fixtext.texttimer.text = (finishTime - Time.time).ToString("f0");
            yield return new WaitForSeconds(timeIncrement);

        }

        // Actual code to be executed after
        gmenager.Game();
    }
    public void ClickEnd()
    {
        SceneManager.LoadScene("START");        
    }
    
       
    

	
	
}
