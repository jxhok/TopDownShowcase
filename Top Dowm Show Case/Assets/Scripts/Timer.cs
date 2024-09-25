using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    float timer = 0;
    [SerializeField]
    Image TimeBar;
    [SerializeField]
    float waitTime = 120;
    [SerializeField]
    GameObject FailCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        TimeBar.fillAmount = timer / waitTime;
        if (timer > waitTime )
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                FailCanvas.GetComponent<Canvas>().enabled = true;
            }
        }
    }
    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
} 
