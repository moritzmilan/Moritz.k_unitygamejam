using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerlimit;

   
 

    [Header("Component")]

   


    [Header("Timer_Settings")]
    public float currentTime;
    public bool coundup;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = coundup ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        if (hasLimit && ((coundup && currentTime <= timerlimit) || (!coundup && currentTime >= timerlimit)))
        {

            currentTime = timerlimit;
            setTimertext();
            timerText.color = Color.red;
            enabled = false;


        }

        setTimertext();


        timerText.text = currentTime.ToString("0.0");


    } 

    private void setTimertext() 
    {

       
    
    }

   

    
    
    
    }

