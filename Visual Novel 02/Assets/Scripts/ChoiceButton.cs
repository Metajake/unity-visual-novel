﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class ChoiceButton : MonoBehaviour {

    public string option;
    public DialogueManager box;

    public void SetText(string newText){
        this.GetComponentInChildren<Text>().text = newText;
    }

    public void SetOption(string newOption){
        this.option = newOption;
    }

    public void ParseOption(){
        string command = option.Split(',')[0];
        print(command);
        string commandModifier = option.Split(',')[1];
        box.playerTalking = false;
        if(command == "line"){
            box.lineNum = int.Parse(commandModifier);
            box.ShowDialogue();
        }else if(command == "scene"){
            //Application.LoadLevel("Scene" + commandModifier);
            EditorSceneManager.LoadScene("Scene" + commandModifier);
        }
    }
	
}
