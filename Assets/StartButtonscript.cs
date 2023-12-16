using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonscript : MonoBehaviour
{
    public static int Experiment_number; //–¾‚¯“n‚µ—p

    public InputField InputField;
    public Text Inputtext;
    //public int textdata;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate();
        }

        InputField = InputField.GetComponent<InputField>();
        //Inputtext = InputField.GetComponent<Text>();
    }


    public void StartButtonMTG()
    {

        //Inputtext.text = InputField.text;
        Experiment_number = int.Parse(InputField.text);

        SceneManager.LoadScene("ex1_SelectQScene");
    }

    public void ex2StartButtonMTG()
    {

        //Inputtext.text = InputField.text;
        Experiment_number = int.Parse(InputField.text);

        SceneManager.LoadScene("ex2_SelectQScene");
    }

    public void ex3StartButtonMTG()
    {

        //Inputtext.text = InputField.text;
        Experiment_number = int.Parse(InputField.text);

        SceneManager.LoadScene("ex3_SelectQScene");
    }
}
