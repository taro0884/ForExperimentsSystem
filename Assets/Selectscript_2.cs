using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Selectscript_2 : MonoBehaviour
{
    public static int selectVnum;
    public static int click;

    // Start is called before the first frame update


    public void number1Start()
    {
        Debug.Log("AAAA");
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

}
