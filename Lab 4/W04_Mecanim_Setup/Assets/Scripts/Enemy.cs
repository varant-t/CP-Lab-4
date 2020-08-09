using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public float gravity;
    Animator animator;
  
  

    // Start is called before the first frame update
    void Start()
    {
  
        animator = GetComponent<Animator>();
        animator.applyRootMotion = false;

      

    }

    // Update is called once per frame
    void Update()
    {
        speed = 0;
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Projectile")
        {
            animator.SetBool("isDying", true);
 
        }

        if (collision.gameObject.tag == "Foot")
        {
            animator.SetBool("isDying", true);
        }

        if (collision.gameObject.tag == "Hand")
        {
            animator.SetBool("isDying", true);
        }

    }

    void deathAnimation()
    {
        // Killes enemy at frame 73
        Destroy(gameObject);
    }

   
}
