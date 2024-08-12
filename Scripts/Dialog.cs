using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TMP_Text textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject dialoguePanel;
    public GameObject continueButton;

    /*public GameObject firstPlayerPerson;
    public GameObject mouseLook;*/

    void Start()
    {
        StartCoroutine(Type());
        //Screen.lockCursor = false;
        /*PlayerMovement player = firstPlayerPerson<PlayerMovement>().enabled = false;
        MouseLook mouse = mouseLook<MouseLook>().enabled = false;*/

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textDisplay.text == sentences[index])
            {
                NextSentence();
            }
            else
            {
                dialoguePanel.SetActive(false);
            }
        }
        
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        //continueButton.SetActive(false); //so player don't spam the button

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            //textDisplay.text = "";
            continueButton.SetActive(false);
            //Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            dialoguePanel.SetActive(false);
        }
    }
}
