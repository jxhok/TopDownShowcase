using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    float shootSpeed = 10f;
    [SerializeField]
    float bulletLifetime = 2.0f;
    float timer = 0;
    [SerializeField]
    float shootDelay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // 0.1666666666s if 60f/s
        //IF we press "the shoot button" (left mouse?)
        if(Input.GetButton("Fire1") && timer > shootDelay)
        {
            timer = 0;
            //fire a projectile in a stright line in the direction of the mouse
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            mousePos = mousePos - transform.position;
            mousePos.Normalize();
            //spawn in the bullet
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = mousePos * shootSpeed;
            bullet.transform.right = mousePos;
            Destroy(bullet, bulletLifetime);
            //Debug.Log(mousePos);
        }
    }
}
