using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.XR;
//using Vuforia;
public class PositionTracker : MonoBehaviour
{
    // Start is called before the first frame update
    
    //La camera est le centre du monde
    //Elle ne bouge pas, cest le monde qui bouge autours
    void Start()
    {
        
        
    }
    public int id;
    public GameObject Effect;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            if (id == 1)
            {
                this.transform.position = this.transform.position + new Vector3(0.01f, 0f, 0f);
            }
            if (id == 2)
            {
                this.transform.position = this.transform.position + new Vector3(-0.01f, 0f, 0f);
            }
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(Effect, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
