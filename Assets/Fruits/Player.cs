using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private AudioSource jump;
    [SerializeField] private AudioSource coinCollect;
    private float x;
    // Start is called before the first frame update
    void Start()
    {
        x = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(x, 0.0f, 0.0f) * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
            jump.Play();
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Manager.coins++;
            coinCollect.Play();
        }
        else if (other.gameObject.CompareTag("Finish"))
        {
            
        }
    }
}
