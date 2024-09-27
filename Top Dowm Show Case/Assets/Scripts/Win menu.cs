using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winmenu : MonoBehaviour
{
    [SerializeField]
    GameObject chestCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chest")
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                chestCanvas.GetComponent<Canvas>().enabled = true;
            }
        }
    }
    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Continue()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level2");

    }
    public void Reset()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }
}
