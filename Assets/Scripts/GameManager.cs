using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static int currentLevel = 0;
    public static int unlockedLevel;


    void Start()
    {
        DontDestroyOnLoad(gameObject);

    }

    public static void CompleteLevel()
    {
        currentLevel++;
        SceneManager.LoadScene(currentLevel);
    }

    public static void RestartLevel()
    {
        SceneManager.LoadScene(currentLevel);
    }

}
