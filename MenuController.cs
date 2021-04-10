using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
     public void quit()
    {
    	Application.Quit();
    }
    public void play()
    {
    SceneManager.LoadScene ("Game");
}
public void menu()
{
	SceneManager.LoadScene("Menu");
}
}
