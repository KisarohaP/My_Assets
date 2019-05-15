using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameUI : MonoBehaviour {

    public int TargetNumber;
    private int Fr;

    private int minute;
    private float seconds;
    private float oldSeconds;
    public Text timeText;
    public Text Frag;
    
	// Use this for initialization
	void Start () {
        initialize();
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
	}
	
    private void initialize()
    {
        PlayerPrefs.SetInt("Frg", 0);
        PlayerPrefs.SetFloat("Tim", 0f);
    }

	// Update is called once per frame
	void Update () {
        Fr = PlayerPrefs.GetInt("Frg");
        if (Fr == TargetNumber)
        {
            Invoke("Spawn", 2);
            oldSeconds = seconds + (float)minute * 60;
            PlayerPrefs.SetFloat("Tim", oldSeconds);
        }
        else
        {
            Frag.text = "Target : " + Fr;
            timer();
        }

        if (Input.GetKey(KeyCode.P))
        {
           oldSeconds = seconds + (float)minute * 60;
            PlayerPrefs.SetFloat("Tim", oldSeconds);
            Spawn();
        }
	}

    private void Spawn()
    {
        SceneManager.LoadScene("Result");
    } 

    void timer()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60f)
        {
            minute++;
            seconds = seconds - 60;
        }
        if ((int)seconds != (int)oldSeconds)
        {
            timeText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
    }
}
