using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// TogetherScene -> DancingScene으로 이동하는 스크립트.

public class TogetherScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
    	SceneManager.LoadScene("TogetherDanceScene");
    }
}
