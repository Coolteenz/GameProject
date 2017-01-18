using System.Linq;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseScript : MonoBehaviour
{
 

    [SerializeField]
    GameObject PauseUI;
    

    private bool isPaused = false;


    void Start()
    {
        PauseUI.SetActive(false);
    }


    void Update()
    {
        
        if (Input.GetButtonDown("Pause"))
        {
            isPaused = !isPaused;
        }
            


        if (isPaused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1.0f;
        }

    }

    public void Continue()
    {
        isPaused = false;
    }
    

    public void switchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }



}