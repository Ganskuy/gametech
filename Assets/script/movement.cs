using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    Rigidbody2D rb;
    float spd;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spd = 2.7f;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "pindah"){
            SceneManager.LoadScene("Scene4");
        }

        if(col.tag == "pindah2"){
            SceneManager.LoadScene("Scene5");
        }
    }


    
    void Update()
    {
        rb.velocity = new Vector2(0,0);
        if(Input.GetKey(KeyCode.D)){
            rb.velocity = new Vector2(spd,0);
        }

        if(Input.GetKey(KeyCode.A)){
            rb.velocity = new Vector2(-spd,0);
        }

        if(Input.GetKey(KeyCode.W)){
            rb.velocity = new Vector2(0,spd);
        }

        if(Input.GetKey(KeyCode.S)){
            rb.velocity = new Vector2(0,-spd);
        }

        if(Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.A)){
            rb.velocity = new Vector2(-spd,spd);
        }

        if(Input.GetKey(KeyCode.D)&&Input.GetKey(KeyCode.W)){
            rb.velocity = new Vector2(spd,spd);
        }

        if(Input.GetKey(KeyCode.D)&&Input.GetKey(KeyCode.S)){
            rb.velocity = new Vector2(spd,-spd);
        }

        if(Input.GetKey(KeyCode.S)&&Input.GetKey(KeyCode.A)){
            rb.velocity = new Vector2(-spd,-spd);
        }
    }
}
