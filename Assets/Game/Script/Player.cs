using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public GameObject swpancube;

    public Slider slidebar;
    private Rigidbody rb;
    float speed=200f;
    Color c;
    Color temp = new Color(0, 0, 0);
    Color temp1 = new Color(0, 0, 0);

   public  bool hitflag=false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float V = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 vel = rb.velocity;
        vel.x = h;
        vel.z = V; 
        rb.velocity = vel;
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "blue")
        {
            hitflag = true;
            c = collision.gameObject.GetComponent<Renderer>().material.GetColor("_Color");
            temp = c + temp;
            temp1 = c;

            slidebar.value += 1 / 6f;
            collision.transform.localPosition += new Vector3(0.9f, 0.9f, 0.9f);


            if (slidebar.value != 0.0 && slidebar.value <= 0.5)
            {

                slidebar.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = new Color(0, 1, 0);
            }
            else if (slidebar.value <= 0.5 && slidebar.value >= 1.0)
            {
                slidebar.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = new Color(1, 0, 0);

            }
            else
            {

            }
           // temp = temp1 - temp;
            GetComponent<Renderer>().material.color = temp; //C sharp
            Debug.Log(c);
            Destroy(collision.collider.gameObject,0.1f);
            // str = true;
        }

        hitflag = false;

        if (collision.gameObject.tag == "Untagged")


        {
            Debug.Log("Wrong");
            slidebar.value -= 1 / 6f;
            Destroy(collision.collider.gameObject, 0.1f);

        }






    }
}
