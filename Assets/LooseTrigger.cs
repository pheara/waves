﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LooseTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("You lost!!!");

        //in the future more abstract!
        //SceneManager.LoadScene("waves");
        //Application.LoadLevel(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    void OnTriggerStay2D(Collider2D other)
    {
    }

    void OnTriggerExit2D(Collider2D other)
    {
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
