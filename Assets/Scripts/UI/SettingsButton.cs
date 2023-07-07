using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButton : MonoBehaviour
{
    public void Click()
    {
        PlayerPrefs.SetString("currentSceneName", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Settings");
    }
}
