using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HazardSystem : MonoBehaviour
{
    //PlayerMovement playerMovement;
    public GameObject d_template;
    public GameObject canva;
    [SerializeField] public GameObject dialoguePanelLaptop;
    [SerializeField] public GameObject dialoguePanelCooking;

    bool player_detection = false;
    bool cooking_detection = false;
    bool laptop_detection = false;

    public TMP_Text oriObj1;
    public TMP_Text compObj1;
    public TMP_Text oriObj2;
    public TMP_Text compObj2;


    void Update()
    {
        if(laptop_detection && Input.GetKeyDown(KeyCode.F))
        {
            //canva.SetActive(true);
            //playerMovement.dialogue = true;
            oriObj1.gameObject.SetActive(false);
            compObj1.gameObject.SetActive(true);
            dialoguePanelLaptop.gameObject.SetActive(true);
            /*NewDialogue("Hi");
            NewDialogue("This is a new dialogue!");
            canva.transform.GetChild(5).gameObject.SetActive(true);*/
        }
        
        if (cooking_detection && Input.GetKeyDown(KeyCode.F))
        {
            //canva.SetActive(true);
            //playerMovement.dialogue = true;
            oriObj2.gameObject.SetActive(false);
            compObj2.gameObject.SetActive(true);
            dialoguePanelCooking.gameObject.SetActive(true);
            /*NewDialogue("Hi");
            NewDialogue("This is a new dialogue!");
            canva.transform.GetChild(5).gameObject.SetActive(true);*/
        }

        //tambah condition if all objective dh complete
    }

    /*void NewDialogue(string text)
    {
        GameObject template_clone = Instantiate(d_template, d_template.transform);
        template_clone.transform.parent = canva.transform;
        template_clone.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = text;
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player_detection = true;

        }
        if (other.CompareTag("Cooking"))
        {
            cooking_detection = true;

        }
        if (other.CompareTag("Player"))
        {
            laptop_detection = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
        cooking_detection = false;
        laptop_detection = false;
    }
}
