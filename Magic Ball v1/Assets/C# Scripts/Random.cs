using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomGenerate : MonoBehaviour
{
    [SerializeField] private string[] messages;
    [SerializeField] private Text messageText;


    public void StartDivinations()
    {
        messageText.text = null;
        StartCoroutine(GenerateMessagess());
    }

    IEnumerator GenerateMessagess()
    {
        yield return new WaitForSeconds(2f);
        messageText.text = messages[Random.Range(0, messages.Length)];
    }






}
