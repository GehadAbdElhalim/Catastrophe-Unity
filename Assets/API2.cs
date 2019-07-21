using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class API2 : MonoBehaviour
{
    private const string URL = "www.google.com";
    public TextMeshProUGUI output;

    public void test()
    {
        WWW req = new WWW(URL);
        StartCoroutine(OnResponse(req));
    }

    IEnumerator OnResponse(WWW req)
    {
        yield return req;

        output.text = req.text;
    }
}
