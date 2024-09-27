using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestSpawn : MonoBehaviour
{
    [SerializeField]
     float timer = 0;
    [SerializeField]
    float spawnTime = 120;
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    Image TimeBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        TimeBar.fillAmount = timer / spawnTime;
        if (timer > spawnTime)
        {
            timer = 0;
            GameObject Chest = Instantiate(prefab, transform.position, Quaternion.identity);
            Destroy(Chest, spawnTime);
        }
    }
}
