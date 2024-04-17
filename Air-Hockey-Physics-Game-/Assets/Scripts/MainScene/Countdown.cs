using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 3f;

    [SerializeField] TextMeshProUGUI countdownText; // Changed to TextMeshProUGUI

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
