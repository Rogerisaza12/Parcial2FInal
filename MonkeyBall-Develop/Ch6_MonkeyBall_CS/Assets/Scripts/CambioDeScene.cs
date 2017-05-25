using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeScene : MonoBehaviour
{

    public void scena1()
    {
        SceneManager.LoadScene("MonkeyBall");
        Time.timeScale = 1;

    }
    public void ScenaMIA()
    {
        SceneManager.LoadScene("Alejandro Isaza");
        Time.timeScale = 1;
    }
}
