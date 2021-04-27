using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rendCol : MonoBehaviour
{
    Color mycolor = Color.red;
    // Start is called before the first frame update
    void Start()
    {
        //  gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));

        Debug.Log(1<=5);
        colorAttached();



    }

    // Update is called once per frame
    void Update()
    {

    }

   public  void colorAttached()
    {


        //for (int i = 0; i < 6/*Global.swpanCubeNumner*/; i++)
        {

            if (Global.ColorList.Count==0)

            {
                gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));

            }
            else
            {



                gameObject.GetComponent<Renderer>().material.color = new Color(Global.ColorList[0], Global.ColorList[1], Global.ColorList[2]);
                gameObject.tag = "blue";
                Global.tempr1 += Global.ColorList[0];
                Global.tempg1 += Global.ColorList[1];
                Global.tempb1 += Global.ColorList[2];
                Debug.Log("value last" + Global.tempr1 + Global.tempg1 + Global.tempb1);
                Global.ColorList.RemoveAt(0);
                Global.ColorList.RemoveAt(0);
                Global.ColorList.RemoveAt(0);




            }
        }

        
    }




}