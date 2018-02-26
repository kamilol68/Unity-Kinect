using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Click : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    public void ClickedFrs()
    {
        SceneManager.LoadScene("OLDPONG");
    }
    public void ClickedSec()
    {
        SceneManager.LoadScene("PONG");
    }
    public void ClickedEnd()
    {
        Application.Quit();
    }
    public void ClickedThird()
    {
        SceneManager.LoadScene("RPS");
    }

}
