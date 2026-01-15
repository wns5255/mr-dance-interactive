using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// LoginScene -> MainScene으로 이동하는 스크립트.

public class LoginScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }
    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                string temp = webRequest.downloadHandler.text;
                AccountInfoScript accountInfoScript = new AccountInfoScript();
                accountInfoScript = JsonUtility.FromJson<AccountInfoScript>(webRequest.downloadHandler.text);
                if (accountInfoScript.code == 100)
                {

                    SSTools.ShowMessage("id missing \n please signIn", SSTools.Position.bottom, SSTools.Time.twoSecond);
                }
                else if (accountInfoScript.code == 101)
                {

                    SSTools.ShowMessage("invaild password", SSTools.Position.bottom, SSTools.Time.twoSecond);
                }
                else
                {
              
                    SceneManager.LoadScene("MainScene");
                }

                Debug.Log("temp " + temp);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void setLoginEmail(InputField text)
    {
        AccountInfoScript.email = text.text;
        Debug.Log("temp " + AccountInfoScript.email);
    }
    public void setLoginPassword(InputField text)
    {
        AccountInfoScript.password = text.text;
        Debug.Log("temp " + AccountInfoScript.password);
    }
    
    public void ChangeSceneToMain()
    {
        if(!string.IsNullOrEmpty(AccountInfoScript.email) && !string.IsNullOrEmpty(AccountInfoScript.password))
        {
            string url = "http://101.101.218.234:7777/kmi/signin/get?email=" + AccountInfoScript.email + "&password=" + AccountInfoScript.password;
            StartCoroutine(GetRequest(url));
        }
        AccountInfoScript.email = null;
        AccountInfoScript.password = null;
        //SceneManager.LoadScene("MainScene");  
    }
    
    /*
    public void ChangeSceneToMain()
    {
        SceneManager.LoadScene("MainScene");
    }
     */

    public void ChangeSceneToSignUp()
    {
        SceneManager.LoadScene("SignUpScene");
    }
}