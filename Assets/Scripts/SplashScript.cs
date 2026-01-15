using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// 맨 처음에 나오는 화면.
// SplashScene -> LoginScene로 이동하는 스크립트.

public class SplashScript : MonoBehaviour
{
    public float delayTime = 2;
 
    // Use this for initialization
    IEnumerator Start () 
    {
        yield return new WaitForSeconds( delayTime );
     
        Application.LoadLevel ("LoginScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
