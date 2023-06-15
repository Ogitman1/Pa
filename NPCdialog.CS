using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCdialog : MonoBehaviour
{
    // Criacao de variaveis
    public string[] dialogueNpc;
    public int dialogueIndex;

    public GameObject dialoguePanel;
    public Text dialogueText;

    public Text nameNPC;
    public Image imageNPC;
    public Sprite spriteNPC;

    public bool readytoSpeak;
    public bool startDialogue;

    void Start()
    {
        dialoguePanel.SetActive(false);
    }

    //O que acontece caso o jogador entre ou saia do campo de espaco do NPC
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Box2"))
        {
            readytoSpeak = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Box2"))
        {
            readytoSpeak = false;
        }
    }
    // Update is called once per frame


    void Update()
    {
        if (Input.GetButtonDown("Fire1") && readytoSpeak)
        {
            if (!startDialogue)
            {
                FindObjectOfType<Mov>().SPEED = 0f;
                StartDialogue();
            }
        }
    }
    void StartDialogue()
    {
        nameNPC.text = "Marcos";
        imageNPC.sprite = spriteNPC;
        startDialogue = true;
        dialogueIndex = 0;
        dialoguePanel.SetActive(true);
    }
}
