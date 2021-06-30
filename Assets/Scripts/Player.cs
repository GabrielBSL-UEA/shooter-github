using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject shoot;
    [SerializeField] float speedShoot = 5;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject speel = Instantiate(shoot, transform.position, Quaternion.identity);
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (Vector2)(mousePos - transform.position).normalized;
            speel.GetComponent<Rigidbody2D>().velocity = direction * speedShoot;
        }
    }
}
