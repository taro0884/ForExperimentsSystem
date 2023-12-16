using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Answer1 : MonoBehaviour
{
    public static Answer1 instance;

    public bool active = false;

    // Start is called before the first frame update
    void Start()
    {

        //this.gameObject.SetActive(false);
        Text text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.SetActive(active);
    }
}
