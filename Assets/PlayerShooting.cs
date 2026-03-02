using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float fireRate = 0.3f;
    float timer;

    void Update()
    {
        timer -= Time.deltaTime;

        if (Input.GetMouseButton(0) && timer <= 0)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            timer = fireRate;
        }

        RotateToMouse();
    }

    void RotateToMouse()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - transform.position;
        transform.up = direction;
    }
}
