using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    float health = 10;
    [SerializeField]
    string levelToLoad;
    float maxHealth;
    [SerializeField]
    Image healthBar;
    [SerializeField]
    GameObject FailCanvas;
    [SerializeField]
    float healthTick = 1;
    [SerializeField]
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
        healthBar.fillAmount = health / maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //we want to take damage IF the player hits the enemy capsule
        //bool key = true;
        if (collision.gameObject.tag == "Enemy")
        {
            //health = health - 1;
            health -= 1;
            healthBar.fillAmount = health / maxHealth;
            //health--;
            if (health <= 0)
            {
                Time.timeScale = 0;
                FailCanvas.GetComponent<Canvas>().enabled = true;
                //SceneManager.LoadScene("Win");

            }
        } 
       }
    private void OnCollisionStay2D(Collision2D collision) 
    {
        timer += Time.deltaTime;
        if (collision.gameObject.tag == "Enemy" && timer > healthTick)
        {
            timer = 0;
            health -= 1;
            healthBar.fillAmount = health / maxHealth;
            if (health <= 0)
            {
                Time.timeScale = 0;
                FailCanvas.GetComponent<Canvas>().enabled = true;
                //SceneManager.LoadScene("Win");

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 1;
            healthBar.fillAmount = health / maxHealth;
            if (health <= 0)
            {
                Time.timeScale = 0;
                FailCanvas.GetComponent<Canvas>().enabled = true;
                //SceneManager.LoadScene("Win");

            }
        }
    }
}  
