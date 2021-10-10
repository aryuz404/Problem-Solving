using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void OpenProblem1()
    {
        SceneManager.LoadScene("Problem1");
    }

    public void OpenProblem2()
    {
        SceneManager.LoadScene("Problem2");
    }

    public void OpenProblem3()
    {
        SceneManager.LoadScene("Problem3");
    }

    public void OpenProblem4()
    {
        SceneManager.LoadScene("Problem4");
    }

    public void OpenProblem5()
    {
        SceneManager.LoadScene("Problem5");
    }

    public void OpenProblem6()
    {
        SceneManager.LoadScene("Problem6");
    }

    public void OpenProblem7()
    {
        SceneManager.LoadScene("Problem7");
    }

    public void OpenProblem8()
    {
        SceneManager.LoadScene("Problem8");
    }

    public void OpenProblem9()
    {
        SceneManager.LoadScene("Problem9");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Problem10");
    }
}//class
