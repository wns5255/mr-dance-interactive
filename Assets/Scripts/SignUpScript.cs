using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// UnityWebRequest.Get example

// Access a website and use UnityWebRequest.Get to download a page.
// Also try to download a non-existing page. Display the error.

public class SignUpScript : MonoBehaviour
{
    
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
                AccountInfoScript accountInfoScript = new AccountInfoScript();
                accountInfoScript = JsonUtility.FromJson<AccountInfoScript>(webRequest.downloadHandler.text);
                /*
                 * 
                string temp = webRequest.downloadHandler.text;
                string[] datas = temp.Split(',');
                foreach(string i in datas)
                {
                    if (i.Contains("code"))
                    {
                        AccountInfoScript.code = i.Substring(i.LastIndexOf("code") + 6);
                        Debug.Log("code " + AccountInfoScript.code);
                    }
                    else if (i.Contains("id"))
                    {
                        AccountInfoScript.id = i.Substring(i.LastIndexOf("id") + 4);
                        Debug.Log("id " + AccountInfoScript.id);
                    }
                }
                 */
                AccountInfoScript.email = null;
                AccountInfoScript.password = null;
                AccountInfoScript.name = null;
                if (accountInfoScript.code == 0) this.ChangeScene();
            }
        }
    }

        // Update is called once per frame
    void Update()
    {

    }
    public void setName(InputField text)
    {
        AccountInfoScript.name = text.text;
        Debug.Log("name " + AccountInfoScript.name);
    }
    public void setPassword(InputField text)
    {
        AccountInfoScript.password = text.text;
        Debug.Log("password " + AccountInfoScript.password);
    }
    public void setEmail(InputField text)
    {
        AccountInfoScript.email = text.text;
        Debug.Log("email " + AccountInfoScript.email);
    }

    public void onClick()
    {
        bool check = true;
        if (AccountInfoScript.name == null) check = false;
        if (AccountInfoScript.password == null) check = false;
        if (AccountInfoScript.email == null) check = false;
        if (check)
        {
            string url= "http://101.101.218.234:7777/kmi/signup/get?email=" + AccountInfoScript.email + "&password=" + AccountInfoScript.password + "&name=" + AccountInfoScript.name;
            Debug.Log("url " + url);
            StartCoroutine(GetRequest(url));
        }
       
        // A correct website page.

        // A non-existing page.
        //StartCoroutine(GetRequest("https://error.html"));
    }

    // LoginScene으로 이동.
    public void ChangeScene()
    {
        SceneManager.LoadScene("LoginScene");
    }
}