using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectScript : MonoBehaviour
{
    public static int selectVnum;
    public static int click;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void checkButton()
    {
        SceneManager.LoadScene("CheckScene");
    }

    public void number1Start(){
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
        SceneManager.LoadScene("CountDown");
    }

    public void number6Start()
    {
        selectVnum = 6;
        SceneManager.LoadScene("CountDown");
    }

    public void number7Start()
    {
        selectVnum = 7;
        SceneManager.LoadScene("CountDown");
    }

    public void number8Start()
    {
        selectVnum = 8;
        SceneManager.LoadScene("CountDown");
    }

    public void number9Start()
    {
        selectVnum = 9;
        SceneManager.LoadScene("CountDown");
    }
}
