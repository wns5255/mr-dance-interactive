using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public int one = 22;
    float timer;
    int waitingTime;
    public GameObject other0;
    public GameObject other1;
    public GameObject other2;
    public GameObject other3;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        waitingTime = 25; //24초일때 원본 video4 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (waitingTime-3 > timer && timer > waitingTime-5)
        {
            text1.gameObject.SetActive(true);
        }

        if (waitingTime-2 > timer && timer > waitingTime-4)
        {
            text2.gameObject.SetActive(true);
        }
        if (waitingTime-1 > timer && timer > waitingTime-3)
        {
            text2.gameObject.SetActive(false);
            text3.gameObject.SetActive(true);
        }
        if (waitingTime > timer && timer > waitingTime-2)
        {
            text3.gameObject.SetActive(false);
            text4.gameObject.SetActive(true);
        }
        if (waitingTime+1 > timer && timer > waitingTime-1)
        {
            text1.gameObject.SetActive(false);
            text4.gameObject.SetActive(false);
        }

        if (Variables.i < 4 && timer > waitingTime) 
        {
            if (Variables.i == 0) {
                other1.gameObject.SetActive(true);
                other2.gameObject.SetActive(true);
                other3.gameObject.SetActive(true);
                camera.gameObject.SetActive(true);
                Variables.i = 5;
            }
            if (Variables.i == 1)
            {
                other0.gameObject.SetActive(true);
                other2.gameObject.SetActive(true);
                other3.gameObject.SetActive(true);
                camera.gameObject.SetActive(true);
                Variables.i = 5;
            }
            if (Variables.i == 2)
            {
                other0.gameObject.SetActive(true);
                other1.gameObject.SetActive(true);
                other3.gameObject.SetActive(true);
                camera.gameObject.SetActive(true);
                Variables.i = 5;
            }
            if (Variables.i == 3)
            {
                other0.gameObject.SetActive(true);
                other1.gameObject.SetActive(true);
                other2.gameObject.SetActive(true);
                camera.gameObject.SetActive(true);
                Variables.i = 5;
            }
            
               
        }

        if (timer > 279)
        {
            SceneManager.LoadScene("LoadingScene");
        }
    }
}
