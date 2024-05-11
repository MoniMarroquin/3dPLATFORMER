using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy : MonoBehaviour
{
    public int maxhealth = 3;
    public int current;
    public int death;
    public string gameOver;
    //public int health;

    [SerializeField] Health health;
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("AHHHHHHH");
        if (other.GetComponent<Player>() != null)
        {
            maxhealth = current;
            current = current  -= 1;
            health.DecreaseHealth(-1);
            //Debug.Log(current);
            if (current < 0)
            {
                current = death; 
                if (current == death)
                {
                    SceneManager.LoadScene(gameOver); // have it go back to title, do i have to load the scene again?
                }

            }
        }
    }
    /*
    public int currentHealth
    {
        get { return health; }
        
        set { current = value; myHealth.text = currentHealth.ToString(); }
    }
    */
}
