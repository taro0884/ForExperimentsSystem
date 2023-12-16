using System.Collections;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ex3GameManager : MonoBehaviour
{
    public float Gametime;
    public float Answertime;
    public float LimitTime;

    //public Text AnnounceText;

    public GameObject ClickButton1;
    public GameObject ClickButton2;
    public GameObject ClickButton3;
    public GameObject ClickButton4;
    public GameObject ClickButton5;

    public GameObject AnswerButton;
    public GameObject ClearButton;
    public GameObject SkipButton;


    bool SkipActive = false;
    bool ObjectActive = false;

    public Text Uptext;
    public Text kaitou;

    Text keepchangetext;

    //public Text score;
    public static int answer_number;//`正答数
    public static int Question_number; //‘問題番号

    TextAsset csvFile; // CSVファイル
    List<string[]> csvDatas = new List<string[]>(); // CSVの中身を入れるリスト;

    public static List<string> QuestionList = new List<string>(); // CSVの中身を入れるリスト;
    public static List<string> AnswerList = new List<string>(); // CSVの中身を入れるリスト;
    public static List<string> SkipTimeList = new List<string>(); // CSVの中身を入れるリスト;

    List<float> SkipTList = new List<float>();

    //public static string[] QuestionList = { "とはりやち", "まりひつな", "おなゆんき", "すわおけそ", "たむかりつ", "ちわはせあ", "んしうての", "あふせしわ", "わりつたな", "ろんうきた" };
    //public static string[] AnswerList = { "はやとちり", "ひなまつり", "ゆきおんな","おすそわけ","かたつむり","はちあわせ","してんのう","ふしあわせ","つなわたり","きんたろう" };

    public static List<float> AnswerTimes = new List<float>();

    //public float AverageAnswerTime = 0.0f;

                            public float until_SkipClicktime;
                            public static Vector2 mouseP;

                           // public static List<string> mouseppp = new List<string>(); // CSVの中身を入れるリスト;

                            public static List<float> until_SkipClicktimes = new List<float>();
                            public static List<float> mouseposX_List = new List<float>();
                            public static List<float> mouseposY_List = new List<float>();
                            public static List<float> mousepos = new List<float>();
                            public static int click_num;

    // Start is called before the first frame update
    void Start()
    {
        answer_number = 0; //`正答数
        Question_number = 0; //‘問題番号

        //ATimes.Clear();
        //for(var i = 0;i < AnswerList.Length; i++)
        //{
        // int randomindex = Random.Range(0,AnswerList.Length+1);
        //}

        SkipButton.SetActive(SkipActive);

        csvFile = Resources.Load("ex3_QA") as TextAsset; // Resouces下のCSV読み込み
        StringReader reader = new StringReader(csvFile.text);

        while (reader.Peek() != -1) // reader.Peaekが-1になるまで
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
        }

        //for(int i = 0; i < SkipTimeList.Count; i++)
        //{
        //    SkipTList.Add(float.Parse(SkipTimeList[i]));
        //    SkipTList[i] = float.Parse(SkipTimeList[i]);
        //}

        if (ex3SelectScript.click == 1)
        {
            for (var i = 1; i < csvDatas.Count; i++)
            {
                QuestionList.Add(csvDatas[i][0]);
                AnswerList.Add(csvDatas[i][1]);
                SkipTList.Add(float.Parse(csvDatas[i][2]));

                Debug.Log(csvDatas[i][1]);

                //Debug.Log(QuestionList[i] + ":" + AnswerList[i]);
            }

        }

        else if (ex3SelectScript.click == 2)
        {
            for (var i = 0; i < csvDatas.Count - 1; i++)
            {
                QuestionList.Add(csvDatas[i + 1][3]);
                AnswerList.Add(csvDatas[i + 1][4]);
                SkipTList.Add(float.Parse(csvDatas[i + 1][5]));

                //Debug.Log(QuestionList[i] + ":" + AnswerList[i]);
            }
        }

        else if (ex3SelectScript.click == 3)
        {
            for (var i = 0; i < csvDatas.Count - 1; i++)
            {
                QuestionList.Add(csvDatas[i + 1][6]);
                AnswerList.Add(csvDatas[i + 1][7]);
                SkipTList.Add(float.Parse(csvDatas[i + 1][8]));

                //Debug.Log(QuestionList[i] + ":" + AnswerList[i]);
            }
        }

        else if (ex3SelectScript.click == 4)
        {
            for (var i = 0; i < csvDatas.Count - 1; i++)
            {
                QuestionList.Add(csvDatas[i + 1][9]);
                AnswerList.Add(csvDatas[i + 1][10]);
                SkipTList.Add(float.Parse(csvDatas[i + 1][11]));

                //Debug.Log(QuestionList[i] + ":" + AnswerList[i]);
            }
        }

        else if (ex3SelectScript.click == 5)
        {
            for (var i = 0; i < csvDatas.Count - 1; i++)
            {
                QuestionList.Add(csvDatas[i + 1][12]);
                AnswerList.Add(csvDatas[i + 1][13]);
                SkipTList.Add(float.Parse(csvDatas[i + 1][14]));

                //Debug.Log(QuestionList[i] + ":" + AnswerList[i]);
            }
        }

        else if (ex3SelectScript.click == 6)
        {
            for (var i = 0; i < csvDatas.Count - 2; i++)
            {
                QuestionList.Add(csvDatas[i + 1][15]);
                AnswerList.Add(csvDatas[i + 1][16]);
                SkipTList.Add(float.Parse(csvDatas[i + 1][17]));

                //Debug.Log(QuestionList[i] + ":" + AnswerList[i]);
            }
        }

        else if (ex3SelectScript.click == 7)
        {
            for (var i = 0; i < csvDatas.Count - 2; i++)
            {
                QuestionList.Add(csvDatas[i + 1][18]);
                AnswerList.Add(csvDatas[i + 1][19]);
                SkipTList.Add(float.Parse(csvDatas[i + 1][20]));

                //Debug.Log(QuestionList[i] + ":" + AnswerList[i]);
            }
        }

        else if (ex3SelectScript.click == 8)
        {
            for (var i = 0; i < csvDatas.Count - 2; i++)
            {
                QuestionList.Add(csvDatas[i + 1][21]);
                AnswerList.Add(csvDatas[i + 1][22]);
                SkipTList.Add(float.Parse(csvDatas[i + 1][23]));

                //Debug.Log(QuestionList[i] + ":" + AnswerList[i]);
            }
        }

        else if (ex3SelectScript.click == 9)
        {
            for (var i = 0; i < csvDatas.Count - 2; i++)
            {
                QuestionList.Add(csvDatas[i + 1][24]);
                AnswerList.Add(csvDatas[i + 1][25]);
                SkipTList.Add(float.Parse(csvDatas[i + 1][26]));

                //Debug.Log(QuestionList[i] + ":" + AnswerList[i]);
            }
        }

        ClickButton1.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(0, 1);
        ClickButton2.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(1, 1);
        ClickButton3.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(2, 1);
        ClickButton4.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(3, 1);
        ClickButton5.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(4, 1);

        //for (var i = 0; i < csvDatas.Count-1; i++)
        //{
        //    QuestionList.Add(csvDatas[i+1][0]);
        //    AnswerList.Add(csvDatas[i+1][1]);

        //    //Debug.Log(QuestionList[i] + ":" + AnswerList[i]);
        //}


    }

    // Update is called once per frame
    void Update()
    {
        mouseP = Input.mousePosition;
        mousepos.Add(mouseP.x);
        mousepos.Add(mouseP.y);
        Debug.Log(mouseP);


        if (Input.GetMouseButtonDown(0))
        {
            click_num += 1 ;
        }

        Gametime += Time.deltaTime;
        Answertime += Time.deltaTime;

        if (Gametime >= LimitTime)
        {
            SceneManager.LoadScene("EndScene");
        }

        //if (Answertime / 2 >= float.Parse(SkipTimeList[Question_number]))
        if (Answertime >= SkipTList[Question_number] * 2)
        {
            SkipActive = true;
            SkipButton.SetActive(SkipActive);
                             until_SkipClicktime += Time.deltaTime;
        }
        else
        {
            SkipActive = false;
            SkipButton.SetActive(SkipActive);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            QuestionList.Clear();
            AnswerList.Clear();
            AnswerTimes.Clear();
            mouseposX_List.Clear();
            mouseposY_List.Clear();
            until_SkipClicktimes.Clear();
            click_num = 0;

            ex3SelectScript.click--;
            SceneManager.LoadScene("ex3_SelectQScene");  //書き換えいるよ
            return;
        }

    }


    public void ClickButtonMethod1()
    {
        if (kaitou.text.Length >= 5) return;

        keepchangetext = ClickButton1.GetComponentInChildren<Text>();
        string keepchangetext_str = keepchangetext.text.ToString();
        string aaa = kaitou.text.ToString() + keepchangetext_str;
        kaitou.text = aaa;
    }

    public void ClickButtonMethod2()
    {
        if (kaitou.text.Length >= 5) return;

        keepchangetext = ClickButton2.GetComponentInChildren<Text>();
        string keepchangetext_str = keepchangetext.text.ToString();
        string aaa = kaitou.text.ToString() + keepchangetext_str;
        kaitou.text = aaa;
    }

    public void ClickButtonMethod3()
    {
        if (kaitou.text.Length >= 5) return;

        keepchangetext = ClickButton3.GetComponentInChildren<Text>();
        string keepchangetext_str = keepchangetext.text.ToString();
        string aaa = kaitou.text.ToString() + keepchangetext_str;
        kaitou.text = aaa;
    }

    public void ClickButtonMethod4()
    {
        if (kaitou.text.Length >= 5) return;

        keepchangetext = ClickButton4.GetComponentInChildren<Text>();
        string keepchangetext_str = keepchangetext.text.ToString();
        string aaa = kaitou.text.ToString() + keepchangetext_str;
        kaitou.text = aaa;
    }

    public void ClickButtonMethod5()
    {
        if (kaitou.text.Length >= 5) return;

        keepchangetext = ClickButton5.GetComponentInChildren<Text>();
        string keepchangetext_str = keepchangetext.text.ToString();
        string aaa = kaitou.text.ToString() + keepchangetext_str;
        kaitou.text = aaa;
    }

    public void AnswerButtonClick()
    {
        string UserAnswer = kaitou.text.ToString();

        if (UserAnswer == AnswerList[Question_number])
        {

            AnswerTimes.Add(Answertime);

            Answertime = 0.0f;

            Debug.Log(Question_number);

            if(ex3SelectScript.click >= 6)
            {
                if (Question_number == 7)       //複雑単純によって書き換える必要あり
                {
                    Debug.Log("aaaa");
                    SceneManager.LoadScene("EndScene");
                    return;
                }
            }
            
            else if(ex3SelectScript.click < 6)
            {
                if (Question_number == 8)       //複雑単純によって書き換える必要あり
                {
                    Debug.Log("bbb");
                    SceneManager.LoadScene("EndScene");
                    return;
                }
            }


            kaitou.text = "";

            ClickButton1.GetComponentInChildren<Text>().text = "";
            ClickButton2.GetComponentInChildren<Text>().text = "";
            ClickButton3.GetComponentInChildren<Text>().text = "";
            ClickButton4.GetComponentInChildren<Text>().text = "";
            ClickButton5.GetComponentInChildren<Text>().text = "";

            StartCoroutine("Restmin");
        }
        else
        {
            StartCoroutine("Rest");
        }
    }

    private IEnumerator Rest()
    {
        kaitou.text = "";
        Uptext.text = "不正解";
        yield return new WaitForSeconds(2.0f);
        Uptext.text = "↓回答↓";
    }


    private IEnumerator Restmin()
    {
        Question_number++;
        answer_number++;

        //score.text = "正答数：" + answer_number;

        //UnActiveText(kaitou);
        //UnActiveText(score);

        //画面を真っ白に
        UnActiveObj(ClickButton1);
        UnActiveObj(ClickButton2);
        UnActiveObj(ClickButton3);
        UnActiveObj(ClickButton4);
        UnActiveObj(ClickButton5);
        UnActiveObj(AnswerButton);
        UnActiveObj(ClearButton);
        UnActiveObj(SkipButton);

        UnActiveText(Uptext);

        yield return new WaitForSeconds(3f);

        Answertime = 0.0f;

        //画面を復活
        ActiveObj(ClickButton1);
        ActiveObj(ClickButton2);
        ActiveObj(ClickButton3);
        ActiveObj(ClickButton4);
        ActiveObj(ClickButton5);
        ActiveObj(AnswerButton);
        ActiveObj(ClearButton);

        Uptext.text = "↓回答↓";


        kaitou.text = ""; //回答欄空白にする。

        ClickButton1.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(0, 1);
        ClickButton2.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(1, 1);
        ClickButton3.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(2, 1);
        ClickButton4.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(3, 1);
        ClickButton5.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(4, 1);

    }

    private IEnumerator RestminSkip()
    {
        //画面を真っ白に
        UnActiveObj(ClickButton1);
        UnActiveObj(ClickButton2);
        UnActiveObj(ClickButton3);
        UnActiveObj(ClickButton4);
        UnActiveObj(ClickButton5);
        UnActiveObj(AnswerButton);
        UnActiveObj(ClearButton);
        UnActiveObj(SkipButton);

        UnActiveText(Uptext);

        yield return new WaitForSeconds(3f);

        Answertime = 0.0f;

        //画面を復活
        ActiveObj(ClickButton1);
        ActiveObj(ClickButton2);
        ActiveObj(ClickButton3);
        ActiveObj(ClickButton4);
        ActiveObj(ClickButton5);
        ActiveObj(AnswerButton);
        ActiveObj(ClearButton);

        Uptext.text = "↓回答↓";

        kaitou.text = "";

        Question_number++;

        ClickButton1.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(0, 1);
        ClickButton2.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(1, 1);
        ClickButton3.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(2, 1);
        ClickButton4.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(3, 1);
        ClickButton5.GetComponentInChildren<Text>().text = QuestionList[Question_number].Substring(4, 1);
    }

    public void ClearButtonClick()
    {
        kaitou.text = "";
    }

    public void SkipButtonClick()
    {
        if (Answertime >= SkipTList[Question_number] * 2)
        {
            AnswerTimes.Add(-Answertime);
            Answertime = 0.0f;

            until_SkipClicktimes.Add(until_SkipClicktime);
            until_SkipClicktime = 0.0f;

            if (ex3SelectScript.click >= 6)
            {
                if (Question_number == 7)       //複雑単純によって書き換える必要あり
                {
                    Debug.Log("aaaa");
                    SceneManager.LoadScene("EndScene");
                    return;
                }
            }

            else if (ex3SelectScript.click < 6)
            {
                if (Question_number == 8)       //複雑単純によって書き換える必要あり
                {
                    Debug.Log("bbb");
                    SceneManager.LoadScene("EndScene");
                    return;
                }
            }


            kaitou.text = "";
            ClickButton1.GetComponentInChildren<Text>().text = "";
            ClickButton2.GetComponentInChildren<Text>().text = "";
            ClickButton3.GetComponentInChildren<Text>().text = "";
            ClickButton4.GetComponentInChildren<Text>().text = "";
            ClickButton5.GetComponentInChildren<Text>().text = "";


            StartCoroutine("RestminSkip");
        }
    }

    public void UnActiveObj(GameObject obj)
    {
        ObjectActive = false;
        obj.SetActive(ObjectActive);
    }

    public void UnActiveText(Text text)
    {
        text.text = "";
    }

    public void ActiveObj(GameObject obj)
    {
        ObjectActive = true;
        obj.SetActive(ObjectActive);
    }

    //public void Active(Text text)
    //{
    //    text.text = "";
    //}
}