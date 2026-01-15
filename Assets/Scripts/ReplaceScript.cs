using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Variables
{
    public static int i = 4;
}


// ReplaceScene -> ResultScene으로 이동하는 스크립트.

public class ReplaceScript : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
    	SceneManager.LoadScene("ReplaceDanceScene");
    }

    public void PanelControl0()
    {
        Variables.i = 0;
    }

    public void PanelControl1()
    {
        Variables.i = 1;
    }

    public void PanelControl2()
    {
        Variables.i = 2;
    }

    public void PanelControl3()
    {
        Variables.i = 3;
    }
}
