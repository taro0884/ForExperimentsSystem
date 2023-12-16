using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class ex3VideoScript : MonoBehaviour
{
	public VideoClip E3_var1_ave1;
	public VideoClip E3_var1_ave4;
	public VideoClip E3_var1_ave7;
	public VideoClip E3_var3_ave1;
	public VideoClip E3_var3_ave4;
	public VideoClip E3_var3_ave7;
	public VideoClip E3_var5_ave1;
	public VideoClip E3_var5_ave4;
	public VideoClip E3_var5_ave7;

	// インスペクター上でVideoPlayerを指定
	public VideoPlayer VideoPlayerComponent;

	void Start()
	{
		if (ex3SelectScript.selectVnum == 1)
		{
			VideoPlayerComponent.clip = E3_var1_ave1;
		}
		else if (ex3SelectScript.selectVnum == 2)
		{
			VideoPlayerComponent.clip = E3_var1_ave4;
		}
		else if (ex3SelectScript.selectVnum == 3)
		{
			VideoPlayerComponent.clip = E3_var1_ave7;
		}

		else if (ex3SelectScript.selectVnum == 4)
		{
			VideoPlayerComponent.clip = E3_var3_ave1;
		}
		else if (ex3SelectScript.selectVnum == 5)
		{
			VideoPlayerComponent.clip = E3_var3_ave4;
		}
		else if (ex3SelectScript.selectVnum == 6)
		{
			VideoPlayerComponent.clip = E3_var3_ave7;
		}

		else if (ex3SelectScript.selectVnum == 7)
		{
			VideoPlayerComponent.clip = E3_var5_ave1;
		}
		else if (ex3SelectScript.selectVnum == 8)
		{
			VideoPlayerComponent.clip = E3_var5_ave4;
		}
		else if (ex3SelectScript.selectVnum == 9)
		{
			VideoPlayerComponent.clip = E3_var5_ave7;
		}
	}
}
