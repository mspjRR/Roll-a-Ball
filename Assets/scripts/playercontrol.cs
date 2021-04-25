using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playercontrol : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int count;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
       // countText.text = "count:" + count.ToString();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);
    }
    void OnTriggerEnter(Collider other)
    {
     if(other.gameObject.CompareTag("Coins"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            //countText.text = "count:" + count.ToString();
        }
    }
}
