using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    // Use this for initialization
    public GameObject Gamecontroll;
    private GameControll gcontroll;
    // Use this for initialization
    void Start()
    {
        Gamecontroll = GameObject.Find("Menager");
        gcontroll = Gamecontroll.GetComponent<GameControll>();
    }
     public void StartClick()
    {
        gcontroll.NewGame();
    }
   public void EndClick()
    {
        SceneManager.LoadScene("START");
    }
}
