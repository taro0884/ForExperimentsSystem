using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ex2CountDown : MonoBehaviour
{
	// Start is called before the first frame update
	public Text timerText;

	public float totalTime;
	int seconds;

	// Use this for initialization
	void Start()
	{
		Debug.Log(ex2SelectScript.selectVnum);
		Debug.Log(ex2SelectScript.click);
	}

	// Update is called once per frame
	void Update()
	{
		totalTime -= Time.deltaTime;
		seconds = (int)totalTime;
		//timerText.text = seconds.ToString();

		if (seconds == 0)
		{
			SceneManager.LoadScene("SampleScene");
		}
		else
		{
			timerText.text = seconds.ToString();
		}
	}
}
