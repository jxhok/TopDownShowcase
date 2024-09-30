using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject HUD;
    [SerializeField]
    GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void start()
    {
        Time.timeScale = 1;
        HUD.GetComponent<Canvas>().enabled = true;
        Menu.GetComponent<Canvas>().enabled = false;
    }

}
