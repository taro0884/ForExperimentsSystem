using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ex3SelectScript: MonoBehaviour
{
    public static int selectVnum;
    public static int click;

    // Start is called before the first frame update

    public void number1Start()
    {
        selectVnum = 1;
        click += 1;
        SceneManager.LoadScene("CountDown");
    }

    public void number2Start()
    {
        selectVnum = 2;
        click += 1;
        SceneManager.LoadScene("CountDown");
    }

    public void number3Start()
    {
        selectVnum = 3;
        click += 1;
        SceneManager.LoadScene("CountDown");
    }

    public void number4Start()
    {
        selectVnum = 4;
        click += 1;
        SceneManager.LoadScene("CountDown");
    }


    public void number5Start()
    {
        selectVnum = 5;
        click += 1;
        SceneManager.LoadScene("CountDown");
    }

    public void number6Start()
    {
        selectVnum = 6;
        click += 1;
        SceneManager.LoadScene("CountDown");
    }

    public void number7Start()
    {
        selectVnum = 7;
        click += 1;
        SceneManager.LoadScene("CountDown");
    }

    public void number8Start()
    {
        selectVnum = 8;
        click += 1;
        SceneManager.LoadScene("CountDown");
    }

    public void number9Start()
    {
        selectVnum = 9;
        click += 1;
        SceneManager.LoadScene("CountDown");
    }
}