using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScene1 : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene("Level1");
    }
}
