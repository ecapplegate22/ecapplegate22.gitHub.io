using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameUI : MonoBehaviour
{
    public void SceneChangeREAL()
    {
        SceneManager.LoadScene("ActuallGame");
    }

}