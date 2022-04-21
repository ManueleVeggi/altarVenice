using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	Animator anim;
    public float speed;

    void Start()
    {
    	anim = GetComponent<Animator>();
        speed = 1;
        anim.SetFloat("vertical", 0.0f);
        anim.SetFloat("horizontal", 0.0f); 
        anim.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.D))  
        {  
            transform.Translate(0.1f, 0f, 0f);  
            anim.SetFloat("vertical", 0f);
            anim.SetFloat("horizontal", 1.0f); 
        }  
        if (Input.GetKeyDown(KeyCode.A))  
        {  
            Vector3 position = this.transform.position;
            position.z = position.z - speed * Time.deltaTime;
            this.transform.position = position;
            anim.SetFloat("vertical", 0f);
            anim.SetFloat("horizontal", -1.0f); 
        }  
        if (Input.GetKeyDown(KeyCode.S))  
        {  
            transform.Translate(0.0f, 0f, -0.1f);  
            anim.SetFloat("vertical", 1f);
            anim.SetFloat("horizontal", 0f); 
        }  
        if (Input.GetKeyDown(KeyCode.W))  
        {  
            anim.SetFloat("vertical", 1f);
            anim.SetFloat("horizontal", 0f); 
            anim.Play("Standard Walk");
            transform.Translate(0.0f, 0f, 1.0f * Time.deltaTime * speed);
        }

        else 
        {
        anim.SetFloat("vertical", 0.0f);
        anim.SetFloat("horizontal", 0.0f); 
        anim.Play("Idle"); 
        }
    }
}
