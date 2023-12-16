using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ex3GameEnd : MonoBehaviour
{
    Encoding encoding;

    private TextAsset _csvfile;

    StreamWriter sw;
    StreamWriter sw2;

    string filename;
    string filename_mouse;

    public Text Lastmassege;
    public List<float> ATimes = new List<float>();
    private List<string> ATimes_string = new List<string>();

    public List<float> mousepos = new List<float>();

    int skipcount;

    //public float[] ATimes_string = new float[GameManager.answer_number];

    // Start is called before the first frame update
    void Start()
    {
        //_csvfile = Resources.Load("test.Q1") as TextAsset; // Resouces下のCSV読み込み
        //StringReader reader = new StringReader(_csvfile.text);

        //while (reader.Peek() != -1) // reader.Peaekが-1になるまで
        //{
        //    string line = reader.ReadLine(); // 一行ずつ読み込み
        //    ATimes_string.Add(line.Split(',')); // , 区切りでリストに追加
        //}

        CreateDirectory(Application.dataPath + "/Results/ex3/P7/");
        //CreateDirectory(Application.dataPath + "/Results/ex3/P7/mouse");
        CreateDirectory(Application.dataPath + "/Results/ex3/P8/");
        CreateDirectory(Application.dataPath + "/Results/ex3/P9/");
        CreateDirectory(Application.dataPath + "/Results/ex3/P10/");
        CreateDirectory(Application.dataPath + "/Results/ex3/P11/");
        CreateDirectory(Application.dataPath + "/Results/ex3/P12/");
        CreateDirectory(Application.dataPath + "/Results/ex3/P13/");
        CreateDirectory(Application.dataPath + "/Results/ex3/P14/");
        CreateDirectory(Application.dataPath + "/Results/ex3/P15/");


        Lastmassege.text = "終了です! ";
        ATimes = ex3GameManager.AnswerTimes;

        for (var i = 0; i < ATimes.Count; i++)
        {
            Debug.Log(ex3GameManager.QuestionList[i] + " 回答時間；" + ATimes[i]);
            ATimes_string.Add(ATimes[i].ToString());
        }


        FileInfo file = null;
        //FileInfo file2 = null;

        if (ex3SelectScript.click == 1)
        {
            filename = "num" + StartButtonscript.Experiment_number.ToString() + "_resultEX3_P7";   //ここパターンによって書き換える
            file = new FileInfo(Application.dataPath + "/Results/ex3/P7/" + filename + ".csv");

            //filename_mouse = "num" + StartButtonscript.Experiment_number.ToString() + "_resultEX3_P7_mouseposition";
            //file2 = new FileInfo(Application.dataPath + "/Results/ex3/P7/mouse/" + filename_mouse + ".csv");
        }
        else if (ex3SelectScript.click == 2)
        {
            filename = "num" + StartButtonscript.Experiment_number.ToString() + "_resultEX3_P8";
            file = new FileInfo(Application.dataPath + "/Results/ex3/P8/" + filename + ".csv");
        }
        else if (ex3SelectScript.click == 3)
        {
            filename = "num" + StartButtonscript.Experiment_number.ToString() + "_resultEX3_P9";
            file = new FileInfo(Application.dataPath + "/Results/ex3/P9/" + filename + ".csv");
        }
        else if (ex3SelectScript.click == 4)
        {
            filename = "num" + StartButtonscript.Experiment_number.ToString() + "_resultEX3_P10";   //ここパターンによって書き換える
            file = new FileInfo(Application.dataPath + "/Results/ex3/P10/" + filename + ".csv");
        }
        else if (ex3SelectScript.click == 5)
        {
            filename = "num" + StartButtonscript.Experiment_number.ToString() + "_resultEX3_P11";
            file = new FileInfo(Application.dataPath + "/Results/ex3/P11/" + filename + ".csv");
        }
        else if (ex3SelectScript.click == 6)
        {
            filename = "num" + StartButtonscript.Experiment_number.ToString() + "_resultEX3_P12";
            file = new FileInfo(Application.dataPath + "/Results/ex3/P12/" + filename + ".csv");
        }
        else if (ex3SelectScript.click == 7)
        {
            filename = "num" + StartButtonscript.Experiment_number.ToString() + "_resultEX3_P13";   //ここパターンによって書き換える
            file = new FileInfo(Application.dataPath + "/Results/ex3/P13/" + filename + ".csv");
        }
        else if (ex3SelectScript.click == 8)
        {
            filename = "num" + StartButtonscript.Experiment_number.ToString() + "_resultEX3_P14";
            file = new FileInfo(Application.dataPath + "/Results/ex3/P14/" + filename + ".csv");
        }
        else if (ex3SelectScript.click == 9)
        {
            filename = "num" + StartButtonscript.Experiment_number.ToString() + "_resultEX3_P15";
            file = new FileInfo(Application.dataPath + "/Results/ex3/P15/" + filename + ".csv");
        }
 

        sw = file.AppendText();


        if (ATimes.Count == 0)
        {
            sw.WriteLine("no answer");
        }
        else
        {
            for (int i = 0; i < ATimes_string.Count; i++)
            {
                SaveData2(ATimes[i], ex3GameManager.QuestionList[i]);
                //sw.WriteLine(ATimes[i]);
            }
        }

        //string s2 = string.Join(",", ATimes);
        //sw.WriteLine(s2);

        sw.WriteLine(ex3GameManager.click_num);


        if (ex3GameManager.until_SkipClicktimes.Count == 0)
        {
            sw.WriteLine("no skip");
        }
        else
        {
            for (int i = 0; i < ex3GameManager.until_SkipClicktimes.Count; i++)
            {
                sw.WriteLine(ex3GameManager.until_SkipClicktimes[i]);
                skipcount++;
            }
            sw.WriteLine(skipcount + "skip");
        }

        //for (int i = 0; i < ex3GameManager.mousepos.Count; i++)
        //{

        //    sw.WriteLine(ex3GameManager.mousepos[i]);
        //}

        for (int i = 0; i < ex3GameManager.mousepos.Count / 2; i++)
        {
            SaveData(ex3GameManager.mousepos[i], ex3GameManager.mousepos[i + 1]);
            i++;
        }

        //for (int i = 0; i < ex3GameManager.mouseposX_List.Count; i++)
        //{
        //    sw.Write(ex3GameManager.mouseposX_List[i]);
        //    sw.Write(ex3GameManager.mouseposY_List[i]);
        //    sw.WriteLine("");
        //}

        //sw.Flush();
        //sw.Close();


        //sw = file2.AppendText();


        sw.Flush();
        sw.Close();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ex3GameManager.QuestionList.Clear();
            ex3GameManager.AnswerList.Clear();
            ATimes.Clear();
            ex3GameManager.mouseposX_List.Clear();
            ex3GameManager.mouseposY_List.Clear();
            ex3GameManager.until_SkipClicktimes.Clear();
            ex3GameManager.click_num = 0;

            SceneManager.LoadScene("ex3_SelectQScene");
        }
    }

    public void CreateDirectory(string path)
    {
        // Determine whether the directory exists.
        if (Directory.Exists(path))
        {
            return;
        }

        // Try to create the directory.
        _ = Directory.CreateDirectory(path);
    }

    public void SaveData(float f1, float f2)
    {
        string[] s1 = { f1.ToString(), f2.ToString() };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);
    }

    public void SaveData2(float f1, string s1)
    {
        string[] s = { f1.ToString(), s1 };
        string s2 = string.Join(",", s);
        sw.WriteLine(s2);
    }
}
