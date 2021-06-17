﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightLiftScript : MonoBehaviour
{
    [SerializeField]
    Progressbox progressBox;

    public GameObject Hahmo;

    private bool idle = true;
    private bool nosto;
    private bool nosto2;
    private bool nosto3;
    private bool nosto_aloitus;
    private bool nosto_aloitus2;

    private int clickCounter = 0;

    private Animator anim;

    //XPScript.instance.AddXP(250);
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        CheckInput();
        UpdateAnimations();
    }

    private void UpdateAnimations()
    {
        anim.SetBool("nosto", nosto);
        anim.SetBool("nosto2", nosto2);
        anim.SetBool("nosto3", nosto3);
        anim.SetBool("nosto_aloitus", nosto_aloitus);
        anim.SetBool("nosto_aloitus2", nosto_aloitus2);
        anim.SetBool("idle", idle);
    }

    private void CheckInput()
    {
        if (Input.GetButtonDown("Nosto"))
        {
            NostoFunction();
            clickCounter++;
            if (clickCounter >= 12)
            {
                clickCounter = 0;
                idle = true;
            }
            else if (clickCounter <= 0)
            {
                idle = false;
            }
            //kato miten require certain amount of clicks to perform action unity
            //Miten animaatioon saa startin ja endin
        }
    }

    private void NostoFunction()
    {
        if (clickCounter <= 1)
        {
            idle = false;
            nosto_aloitus = true;
        }
        else if(clickCounter <= 2)
        {
            idle = false;
            nosto_aloitus = false;
            nosto_aloitus2 = true;
        }
        else if(clickCounter <= 6)
        {
            idle = false;
            nosto_aloitus2 = false;
            nosto = true;
        }
        else if(clickCounter <= 8)
        {
            idle = false;
            nosto = false;
            nosto2 = true;
        }
        else if(clickCounter <= 10)
        {
            nosto = false;
            idle = false;
            nosto2 = false;
            nosto3 = true;
            progressBox.UpdateProgress(0.1f);
        }
    }
}
