using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playercontroller_lowe : MonoBehaviour {

    public float speed;             
    public Text countText;          
    public Text winText;
    public GameObject splosion;

    private Rigidbody2D rb2d;       
    private int count;

    private float timer;
    private int wholetime;

    public Text CollectText;
    public Text endText;
    private object GameLoader;

    public UnityEngine.Object Explosion { get; private set; }

    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>();

       
        count = 0;

        
        winText.text = "";

        
        SetCountText();
    }

    
    void FixedUpdate()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");

        
        float moveVertical = Input.GetAxis("Vertical");

       
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

       
        rb2d.AddForce(movement * speed);

        timer = timer + Time.deltaTime;
        if (timer >= 10)
        {
            endText.text = "You Lose! :(";
            StartCoroutine(ByeAfterDelay(2));

        }
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("PickUp"))

            
            other.gameObject.SetActive(false);

        
        count = count + 1;

       
        SetCountText();
    }


    void SetCountText()
    {

        countText.text = "Count: " + count.ToString();


        if (count >= 1)

            winText.text = "You win!";
       
        StartCoroutine(ByeAfterDelay(2));
    }

    private void Instantiate()
    {
        throw new NotImplementedException();
    }

    private string ByeAfterDelay(int v)
    {
        throw new NotImplementedException();
    }
}
