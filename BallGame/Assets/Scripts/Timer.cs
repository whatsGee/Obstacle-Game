using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float currentTime;
    public bool countDown;
    //public bool ActivateTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(ActivateTimer)
        {
        currentTime = countDown ? currentTime = Time.deltaTime: currentTime += Time.deltaTime;
        }
        */
        currentTime = countDown ? currentTime = Time.deltaTime: currentTime += Time.deltaTime;
        SetTimerText();
    }

    /*
    void OnTriggerExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ActivateTimer = true;
        }
    }
    */

    private void SetTimerText()
    {
        timerText.text = currentTime.ToString("0.00");
    }
}
