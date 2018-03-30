using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour {
    CanvasGroup titlePanel;

	private void Awake()
	{
        titlePanel = GameObject.Find("TitlePanel").GetComponent<CanvasGroup>();
        titlePanel.alpha = 0;
	}

	// Use this for initialization
	void Start () {
        var UIFader = GetComponent<UIFader>();
        //print(titlePanel);
        UIFader.FadeIn(0f, 1f, 2f);
        //print(UIFader.uiElement);

	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene("Scene1");
        }
	}
}
