using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScript : MonoBehaviour
{
	public float delayTime = 2;
 
    // Use this for initialization
    IEnumerator Start () 
    {
        yield return new WaitForSeconds( delayTime );
     
        Application.LoadLevel ("ResultScene");
    }

    public float turnSpeed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -1), turnSpeed * Time.deltaTime * 80);
    }
}
