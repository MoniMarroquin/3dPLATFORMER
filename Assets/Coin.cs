using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    [SerializeField] Score score;
    
  

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.GetComponent<Player>() != null)
        {
            score.IncreaseScore(1);
            Destroy(gameObject);
        }
        
    }

}
 
