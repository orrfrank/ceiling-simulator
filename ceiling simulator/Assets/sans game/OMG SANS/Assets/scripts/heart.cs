using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heart : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public Rigidbody2D rb;
    Vector2 move;
    public static bool hasGravity;
    public SpriteRenderer sr;
    public Sprite redSprite;
    public Sprite blueSprite;
    


    void Start()
    {
        hasGravity = false;
        

    }

    



    void Update()
    {
      move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        

        
    }


   





    void FixedUpdate()
    {
        if (hasGravity)
        {
            isBlue();
        }
        else
        {

            isRed();
        }

        if(battleSystem.pushedDown)
        {
            battleSystem.pushedDown = false;
            rb.velocity = new Vector2(0f, -10f);
            
            

        }
            
        
       



    }


    void isBlue()
    {
    rb.AddForce(move * speed * Time.deltaTime);
    rb.gravityScale = 1f;
        speed = 0.08f;
sr.sprite = blueSprite;

    } 



    void isRed()
    {
    rb.velocity = move * speed;
    rb.gravityScale = 0f;
    speed = 3f;
    sr.sprite = redSprite;
    }


   

    
}
