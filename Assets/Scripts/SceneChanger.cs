using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class SceneChanger : MonoBehaviour
{
    string GooglePlayID = "3726059";
    string AppleStoreID = "3726058";
    bool testMode = false;

    private void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            Advertisement.Initialize(GooglePlayID, testMode);
        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            Advertisement.Initialize(AppleStoreID, testMode);
        }
    }
    public void ChangeScene(string name)
    {
        if (Advertisement.IsReady() && name != "OptionsScene" && name != "MainMenu" && name != "TutorialScene")
        {
            Advertisement.Show();
        }

        if (!Advertisement.isShowing)
        {
            SceneManager.LoadScene(name);
        }
    }
}
