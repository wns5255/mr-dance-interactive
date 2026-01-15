using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// DetailScene -> TogetherScene으로 이동하는 스크립트.
// DetailScene -> ReplaceScene으로 이동하는 스크립트.

public class DetailScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSceneToTogether()
    {
    	SceneManager.LoadScene("TogetherScene");
    }

    public void ChangeSceneToReplace()
    {
        SceneManager.LoadScene("ReplaceScene");
    }
}
