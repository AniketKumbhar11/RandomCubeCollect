using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spwan : MonoBehaviour
{
    public static spwan objSpwan = null;

    public GameObject player;
    public float tempR;
    public float tempG;
    public float tempB;
    // Start is called before the first frame update

    private void Awake()
    {
        objSpwan = this;
    }



    void Start()
    {
     
       int x= Random.Range(1,7);

        Global.swpanCubeNumner = 6 + x;


        for (int i=0;i<Global.swpanCubeNumner;i++)
        {
            Instantiate(player,new Vector3(Random.Range(-15.0f,15.0f),0.64f, Random.Range(-10.0f, 10.0f)),Quaternion.identity);
            
        }
        cal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cal()
    {
        float tempR = Global.R / 2;
        float tempG = Global.G / 2;
        float tempB = Global.B / 2;


        float tempR1 = tempR / 2;
        float tempG1 = tempG / 2;
        float tempB1 = tempB / 2;

      //for (int i = 0; i < 2; i++)
        {
            Global.ColorList.Add(tempR);
            Global.ColorList.Add(0);
            Global.ColorList.Add(0);

            Global.ColorList.Add(0);
            Global.ColorList.Add(tempG);
            Global.ColorList.Add(0);

            Global.ColorList.Add(0);
            Global.ColorList.Add(0);
            Global.ColorList.Add(tempB);


            Global.ColorList.Add(tempR1);
            Global.ColorList.Add(tempG1);
            Global.ColorList.Add(0);

            Global.ColorList.Add(0);
            Global.ColorList.Add(tempG1);
            Global.ColorList.Add(tempB1);

            Global.ColorList.Add(tempR1);
            Global.ColorList.Add(0);
            Global.ColorList.Add(tempB1);
        }

        //Global.ColorList.Add(0);
        //Global.ColorList.Add(tempG);
        //Global.ColorList.Add(0);

        //Global.ColorList.Add(0);
        //Global.ColorList.Add(0);
        //Global.ColorList.Add(tempB);



        //Global.ColorList.Add(0);
        //Global.ColorList.Add(newdestination.n_desti.c.g / 2);
        //Global.ColorList.Add(newdestination.n_desti.c.g/ 2);

        //Global.ColorList.Add(0);
        //Global.ColorList.Add(0);
        //Global.ColorList.Add(newdestination.n_desti.c.b / 2);
        //foreach(float R in Global.ColorListR)
        //{
        //    Debug.Log("value of R"+R);
        //}
        //foreach (float G in Global.ColorListG)
        //{
        //    Debug.Log("value of G" + G);
        //}
        //foreach (float B in Global.ColorListB)
        //{
        //    Debug.Log("value of B" + B);
        //}
    }





}
