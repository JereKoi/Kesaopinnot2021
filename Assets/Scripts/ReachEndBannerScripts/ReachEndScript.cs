﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReachEndScript : MonoBehaviour
{
    public GameObject ReachEndBanner;
    public GameObject changeMindButton;

    public void ContinuePlaying()
    {
        ReachEndBanner.SetActive(false);
        changeMindButton.SetActive(true);
    }

    public void StartNewGame()
    {
        PlayerPrefs.DeleteAll();
        ReachEndBanner.SetActive(false);
        changeMindButton.SetActive(false);
        Progressbox.Instance.hahmoLVL1.SetActive(true);
        Progressbox.Instance.hahmoLVL2.SetActive(false);
        Progressbox.Instance.hahmoLVL3.SetActive(false);
        WeightLiftScript.instance.FurrySunglassesT1.SetActive(false);
        WeightLiftScript.instance.FurrySunglassesT2.SetActive(false);
        WeightLiftScript.instance.FurrySunglassesT3.SetActive(false);
        WeightLiftScript.instance.KruunuT1.SetActive(false);
        WeightLiftScript.instance.KruunuT2.SetActive(false);
        WeightLiftScript.instance.KruunuT3.SetActive(false);
        WeightLiftScript.instance.SunglassesT1.SetActive(false);
        WeightLiftScript.instance.SunglassesT2.SetActive(false);
        WeightLiftScript.instance.SunglassesT3.SetActive(false);
        WeightLiftScript.instance.TreeniMyssyT1.SetActive(false);
        WeightLiftScript.instance.TreeniMyssyT2.SetActive(false);
        WeightLiftScript.instance.TreeniMyssyT3.SetActive(false);
        WeightLiftScript.instance.ViiksetT1.SetActive(false);
        WeightLiftScript.instance.ViiksetT2.SetActive(false);
        WeightLiftScript.instance.ViiksetT3.SetActive(false);
        WeightLiftScript.instance.LippisT1.SetActive(false);
        WeightLiftScript.instance.LippisT2.SetActive(false);
        WeightLiftScript.instance.LippisT3.SetActive(false);
        BackgroundSave.instance.isPurchasedBackground2 = false;
        BackgroundSave.instance.isPurchasedBackground3 = false;
        SkinCooldown.Instance.isPurchasedSkin1 = false;
        SkinCooldown.Instance.isPurchasedSkin2 = false;
        SkinCooldown.Instance.isPurchasedSkin3 = false;
        SkinCooldown.Instance.isPurchasedSkin4 = false;
        SkinCooldown.Instance.isPurchasedSkin5 = false;
        SkinCooldown.Instance.isPurchasedSkin6 = false;
        WeightLiftScript.instance.ColorChangeToWhite();
        BackgroundSave.instance.SelectBackground1();
        Progressbox.Instance.StartNewGameReset();
        StaminaIndicator.instance.currentStamina = StaminaIndicator.instance.maxStamina;
        StaminaIndicator.instance.currentStamina = 100;
        StaminaIndicator.instance.TextIndicator.text = ((int)StaminaIndicator.instance.currentStamina).ToString() + "%";
        StaminaIndicator.instance.OnApplicationQuit();
        PlayerMoney.Instance.money = 0;
        PlayerMoney.Instance.moneyText.text = PlayerMoney.Instance.money.ToString() + "$";
        PlayerMoney.Instance.moneyShopText.text = PlayerMoney.Instance.money.ToString() + "$";
        PlayerPrefs.SetInt("money", PlayerMoney.Instance.money);
    }

    public void ClickChangeMindButton()
    {
        ReachEndBanner.SetActive(true);
    }
}
