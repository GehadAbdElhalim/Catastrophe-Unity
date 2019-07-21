using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Networking;

public class API : MonoBehaviour
{
    public TextMeshProUGUI output;

    public void test()
    {
        output.text = "Pressed";
        StartCoroutine("GetText");
    }

    IEnumerator GetText()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("https://www.google.com"))
        {
            output.text = "do anything please";
            yield return www.SendWebRequest();

            output.text = "what happened";

            //if(www.isNetworkError || www.isHttpError)
            //{
                //Debug.Log(www.error);
            //    output.text = "whyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy";
            //}
            //else
            //{
                output.text = www.downloadHandler.text;
            //}
        }
    }
}
