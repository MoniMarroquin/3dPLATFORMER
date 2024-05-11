using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

public class Health : MonoBehaviour
{
    [SerializeField] TMP_Text myHealth;
  
    int health;
  
    public int currentHealth
    {
        get { return health; }

        //set { currentHealth = value; myHealth.text = currentHealth.ToString(); }
    }
    public void DecreaseHealth(int amount)
    {
       // Debug.Log("yyyyyyyyyyyyyyyy");
        health -= amount;
        myHealth.text = currentHealth.ToString();

    }
}
