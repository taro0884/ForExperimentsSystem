using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
	// インスペクター上で変更後の動画を指定
	public VideoClip practiceV;
	public VideoClip A1;
	public VideoClip A2;
	public VideoClip A3;

	// インスペクター上でVideoPlayerを指定
	public VideoPlayer VideoPlayerComponent;

	void Start()
	{
        if (SelectScript.selectVnum == 1)
        {
			VideoPlayerComponent.clip = practiceV;
        }
		else if (SelectScript.selectVnum == 2)
		{
			VideoPlayerComponent.clip = A1;
		}
		else if (SelectScript.selectVnum == 3)
		{
			VideoPlayerComponent.clip = A2;
		}
		else if (SelectScript.selectVnum == 4)
        {
			VideoPlayerComponent.clip = A3;
        }
	}
}
