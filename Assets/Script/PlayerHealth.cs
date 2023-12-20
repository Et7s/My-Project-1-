using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        menu.SetActive(false);
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            menu.SetActive(true);
            Destroy(gameObject);
            
        }
    }
}
