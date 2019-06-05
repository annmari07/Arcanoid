using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public AudioSource hitSound;


    public void Start()
    {
        hitSound = GetComponent<AudioSource>();
        print("kupa");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitSound.Play();
        Destroy(gameObject);
        Debug.Log(collision.gameObject.name);
       
    }

}
