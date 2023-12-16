using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ex2VideoScript : MonoBehaviour
{
	public VideoClip E2_A1;
	public VideoClip E2_A2;
	public VideoClip E2_A3;

	// インスペクター上でVideoPlayerを指定
	public VideoPlayer VideoPlayerComponent;

	void Start()
	{
		if (ex2SelectScript.selectVnum == 1)
		{
			VideoPlayerComponent.clip = E2_A1;
		}
		else if (ex2SelectScript.selectVnum == 2)
		{
			VideoPlayerComponent.clip = E2_A2;
		}
		else if (ex2SelectScript.selectVnum == 3)
		{
			VideoPlayerComponent.clip = E2_A3;
		}
	}
}
