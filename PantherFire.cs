using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantherFire : MonoBehaviour {

    public GameObject shellPrefab;
    public float shotSpeed;
    public Transform Spawn;
    public AudioClip shotSound;
    public GameObject Tank;

    public int shotCounter;
    public Text Zandan;

    private float timeBetweenShot = 0.35f;
    private float timer;
    private int FireTimes;

    void Start()
    {
        Zandan.text = "Remain : " + shotCounter;
        FireTimes = 0;
        PlayerPrefs.SetInt("Hit", 0);
    }

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && timer > timeBetweenShot)
        {
            if(shotCounter < 1)
            {
                return;
            }
            shotCounter -= 1;
            Zandan.text = "Remain : " + shotCounter;

            timer = 0.0f;
            GameObject shot = Instantiate(shellPrefab, Spawn.position, Spawn.rotation)as GameObject;
            Rigidbody shellrb = shot.GetComponent<Rigidbody>();
            shellrb.AddForce(Spawn.forward * shotSpeed);

            Destroy(shot, 3.0f);
            AudioSource.PlayClipAtPoint(shotSound, Spawn.position);
            FireTimes += 1;
            Debug.Log(FireTimes);
            PlayerPrefs.SetInt("Hit", FireTimes);
        }

        if (Input.GetKeyDown(KeyCode.Z) && shotCounter == 0)
        {
            shotCounter = 15;
            Zandan.text = "Remain : " + shotCounter;
        }
	}
}
