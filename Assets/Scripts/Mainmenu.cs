using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("Playground");
    }   
    public void quit()
    {
        Application.Quit();
    }
    public void maninmenu() { 
        SceneManager.LoadScene("Mainmenu");
       }
   
}
