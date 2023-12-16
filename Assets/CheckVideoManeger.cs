using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CheckVideoManeger : MonoBehaviour
{
    //public VideoClip checkV;

    public VideoPlayer VideoPlayerComponent;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("ex1_SelectQScene");
        }
    }
}
