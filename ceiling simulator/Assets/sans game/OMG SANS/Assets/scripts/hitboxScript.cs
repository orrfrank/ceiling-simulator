using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class hitboxScript : MonoBehaviour
{
    public float health;
    public Text healthText;







    // Start is called before the first frame update
    void Start()
    {
        health = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString();

        if(health  == 0f)
        {
            SceneManager.LoadScene("deathScene");
        }
    }

    void takeDamage()
    {
        health = health - 1f;
    }




    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("enimi"))
        {
            takeDamage();
        }


    }


}
