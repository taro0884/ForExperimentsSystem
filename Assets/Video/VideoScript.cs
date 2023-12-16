using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
	// �C���X�y�N�^�[��ŕύX��̓�����w��
	public VideoClip practiceV;
	public VideoClip A1;
	public VideoClip A2;
	public VideoClip A3;

	// �C���X�y�N�^�[���VideoPlayer���w��
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
