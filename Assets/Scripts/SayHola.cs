using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SayHola : MonoBehaviour
{
    private TextMeshProUGUI holaText;

    private void Awake()
    {
        holaText = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        holaText.text = $"Hola, {PersistentData.sharedInstance.userName}.";
    }
}
