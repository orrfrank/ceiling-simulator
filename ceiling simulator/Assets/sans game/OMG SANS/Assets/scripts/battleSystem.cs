using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class battleSystem : MonoBehaviour
{
    public Animator bpAnimation1;
    public Animator boneStorm1;
    public Animator gaster1;
    public Animator gaster2;
    public Animator gaster3;
    public Animator gaster4;
    public static float timer;
    public static bool pushedDown;
    public GameObject boneStorm;
    public GameObject gasterBlaster1;
    
   

    // Update is called once per frame
    void Update()
    {
        timerCode();
        if (timer == 5f)
        {
            attackOne();
        }
        if(timer == 7f)
        {
            boneStorm1.SetBool("start", true);
            heart.hasGravity = false;
        }
        if(timer ==  12f)
         {
            Destroy(boneStorm);
            gaster1.SetBool("start", true);
            gaster2.SetBool("start", true);
            gaster3.SetBool("start", true);
            gaster4.SetBool("start", true);

        }
        if (timer == 13f)
        {
            Destroy(boneStorm);
            gaster1.SetBool("start", false);
            gaster2.SetBool("start", false);
            gaster3.SetBool("start", false);
            gaster4.SetBool("start", false);
        }

        if (timer == 17f)
        {
            SceneManager.LoadScene("deathScene");
        }



    }

    void timerCode() 
    {
        timer = Mathf.Round(Time.time);
        Debug.Log(timer);
        bpAnimation1.SetFloat("timer", timer);
    }

    void attackOne()
    {

        heart.hasGravity = true;
        pushedDown = true;
        

    }

}
