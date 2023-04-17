using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    [SerializeField] private Rigidbody2D PlayerRb;

    private void Start()
    {

    }

    //CAMERA PROBLEM NEEDS PLAYER RB TO BE INTERPOLATE WHEN OFF PLATFORM AND NONE ON PLATFORM

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            PlayerRb.interpolation = RigidbodyInterpolation2D.None;
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            PlayerRb.interpolation = RigidbodyInterpolation2D.Interpolate;
            collision.gameObject.transform.SetParent(null);
        }
    }
}
