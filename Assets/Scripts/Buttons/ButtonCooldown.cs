﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class ButtonCooldown : MonoBehaviour
{
    [SerializeField]
    Button myButton;
    [SerializeField]
    float cooldownDuration = 10f;

    private AdsManager ads;


    private void Start()
    {
        if (StaminaIndicator.instance.currentStamina < 5)
        {
            myButton.interactable = true;
        }
        //else
        //{
        //    StartCoroutine(Cooldown());
        //}
    }

    void Awake()
    {
        // Get a reference to your button
        myButton = GetComponent<Button>();
        

        if (myButton != null)
        {
            // Listen to its onClick event
            myButton.onClick.AddListener(OnButtonClick);
        }
    }

    public void PlayRewardedAd()
    {
        if (Advertisement.IsReady("Rewarded_Android"))
        {
            Advertisement.Show("Rewarded_Android");
        }
        else
        {
            return;
        }
    }

    // This method is called whenever myButton is pressed
    void OnButtonClick()
    {
        PlayRewardedAd();
        //StartCoroutine(Cooldown());
    }

    // Coroutine that will deactivate and reactivate the button 
    IEnumerator Cooldown()
    {
        // Deactivate myButton
        myButton.interactable = false;
        // Wait for cooldown duration
        yield return new WaitForSeconds(cooldownDuration);
        // Reactivate myButton
        myButton.interactable = true;
    }
}
