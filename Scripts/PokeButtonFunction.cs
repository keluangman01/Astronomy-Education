using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class PokeButtonFunction : MonoBehaviour
{
    public GameObject _AnswerA;
    public GameObject _ButtonA;
    public GameObject _AnswerB;
    public GameObject _ButtonB;
    public GameObject _AnswerC;
    public GameObject _ButtonC;
    public GameObject _AnswerD;
    public GameObject _ButtonD;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => PokeButtonClicked());
    }
    // Method to handle the poke button click event

    public void PokeButtonClicked()
    {
        // Deactivate all answer GameObjects
        _AnswerA.SetActive(false);
        _AnswerB.SetActive(false);
        _AnswerC.SetActive(false);
        _AnswerD.SetActive(false);

        // Check if _ButtonA is poked
        if (_ButtonA != null && _ButtonA.GetComponent<XRSimpleInteractable>().isSelected)
        {
            _AnswerA.SetActive(true);
        }

        // Check if _ButtonB is poked
        else if (_ButtonB != null && _ButtonB.GetComponent<XRSimpleInteractable>().isSelected)
        {
            _AnswerB.SetActive(true);
        }

        // Check if _ButtonC is poked
        else if (_ButtonC != null && _ButtonC.GetComponent<XRSimpleInteractable>().isSelected)
        {
            _AnswerC.SetActive(true);
        }

        // Check if _ButtonD is poked
        else if (_ButtonD != null && _ButtonD.GetComponent<XRSimpleInteractable>().isSelected)
        {
            _AnswerD.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}