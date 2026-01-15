using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Translate : MonoBehaviour
{
/*    public GameObject other0;
    public GameObject other1;
    public GameObject other2;
    public GameObject other3;
    public GameObject camera;*/



    // Start is called before the first frame update
    void Start()
    {

        Variables.i = 1;

        if (Variables.i == 0)
        {
            transform.position = new Vector3(-5456, 15, 1418);
        }
        if (Variables.i == 1)
        {
            transform.position = new Vector3(-5454, 15, 1419);
/*            other0.gameObject.SetActive(true);
            other2.gameObject.SetActive(true);
            other3.gameObject.SetActive(true);*/
        }
        if (Variables.i == 2)
        {
            transform.position = new Vector3(-5452, 15, 1419);
  /*          other0.gameObject.SetActive(true);
            other1.gameObject.SetActive(true);
            other3.gameObject.SetActive(true);*/
        }
        if (Variables.i == 3)
        {
            transform.position = new Vector3(-5450, 15, 1418);
/*            other0.gameObject.SetActive(true);
            other1.gameObject.SetActive(true);
            other2.gameObject.SetActive(true);*/
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
