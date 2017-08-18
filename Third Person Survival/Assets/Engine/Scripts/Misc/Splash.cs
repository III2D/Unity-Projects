using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Splash : MonoBehaviour {

    public Text SplashText;

    void Start ()
    {
        StartCoroutine(i_Splash());
	}
	
	void Update ()
    {
		
	}

    IEnumerator i_Splash()
    {
        yield return new WaitForSeconds(1);
        SplashText.text = "<size=25>THIS IS A</size><size=50> DEVELOPMENT BUILD </size><size=25>EXPECT BUGS AND MISSING FEATURES</size>" + "\n\n\n\n" + "<size=15>-- VERSION: 0.0001A --</size>".ToString();
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("scn_Development");
    }
}
