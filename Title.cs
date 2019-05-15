using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {
	
	// Update is called once per frame
    public void GameStart()
    {
        SceneManager.LoadScene("Testing");
    }
    public void TimeAttacker()
    {
        SceneManager.LoadScene("Kakuma");
    }
    public void ReturnToTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
