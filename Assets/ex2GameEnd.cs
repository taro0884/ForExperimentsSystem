using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ex2GameEnd : MonoBehaviour
{
    Encoding encoding;

    private TextAsset _csvfile;

    StreamWriter sw;

    string filename;

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

        CreateDirectory(Application.dataPath + "/Results/ex2/P4/");
        CreateDirectory(Application.dataPath + "/Results/ex2/P5/");
        CreateDirectory(Application.dataPath + "/Results/ex2/P6/");

        Lastmassege.text = "終了です! ";
        ATimes = ex2GameManager.AnswerTimes;

        for (var i = 0; i < ATimes.Count; i++)
        {
            Debug.Log(ex2GameManager.QuestionList[i] + " 回答時間；" + ATimes[i]);
            ATimes_string.Add(ATimes[i].ToString());
        }


        FileInfo file = null;

        if (ex2SelectScript.click == 1)
        {
            filename = "num" + StartButtonscript.Experiment_number.ToString() + "_resultEX2_P4";   //ここパターンによって書き換える
            file = new FileInfo(Application.dataPath + "/Results/ex2/P4/" + filename + ".csv");
        }
        else if (ex2SelectScript.click == 2)
        {
            filename = "num" + StartButtonscript.Experiment_number.ToString() + "_resultEX2_P5";
            file = new FileInfo(Application.dataPath + "/Results/ex2/P5/" + filename + ".csv");
        }
        else if (ex2SelectScript.click == 3)
        {
            filename = "num" + StartButtonscript.Experiment_number.ToString() + "_resultEX2_P6";
            file = new FileInfo(Application.dataPath + "/Results/ex2/P6/" + filename + ".csv");
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
                SaveData2(ATimes[i], ex2GameManager.QuestionList[i]);
                //sw.WriteLine(ATimes[i]);
            }
        }

        sw.WriteLine(ex2GameManager.click_num);

        if (ex2GameManager.until_SkipClicktimes.Count == 0)
        {
            sw.WriteLine("no skip");
        }
        else
        {
            for (int i = 0; i < ex2GameManager.until_SkipClicktimes.Count; i++)
            {
                sw.WriteLine(ex2GameManager.until_SkipClicktimes[i]);
                skipcount++;
            }
            sw.WriteLine(skipcount + "skip");
        }


        for (int i = 0; i < ex2GameManager.mousepos.Count / 2; i++)
        {
            SaveData(ex2GameManager.mousepos[i], ex2GameManager.mousepos[i + 1]);
            i++;
        }

        sw.Flush();
        sw.Close();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ex2GameManager.QuestionList.Clear();
            ex2GameManager.AnswerList.Clear();
            ATimes.Clear();
            ex2GameManager.mouseposX_List.Clear();
            ex2GameManager.mouseposY_List.Clear();
            ex2GameManager.until_SkipClicktimes.Clear();
            ex2GameManager.click_num = 0;
            SceneManager.LoadScene("ex2_SelectQScene");
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
