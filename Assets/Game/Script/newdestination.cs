using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newdestination : MonoBehaviour
{

    public static newdestination n_desti = null;
    public Image destinationImage;

    public GameObject m_gameObject;
         Color c;
    // public float R, G, B;

        
    public void Awake()
    {
        n_desti = this;
    }
    void Start()
    {
        c = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        m_gameObject.GetComponent<Renderer>().material.color = c;
        destinationImage.gameObject.GetComponent<Image>().color =new Color(c.r,c.g,c.b);

        RGB();
      
        
     //   m_gameObject.GetComponent<Renderer>().material.color=new Color(Random.Range(0,1f), Random.Range(0,1f), Random.Range(0,1f));
    }

    public void RGB()
    {

        Global.R = c.r;
        Global.G = c.g;
        Global.B = c.b;
        Debug.Log(Global.R);
        Debug.Log(Global.G);
        Debug.Log(Global.B);







    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
