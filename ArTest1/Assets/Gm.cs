using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Gm : MonoBehaviour
{
    // Start is called before the first frame update
    public DefaultTrackableEventHandler[] trackers;
    public GameObject[] prefabs;
    public Transform[] SpawnPositions;
    bool[] isInstance;
    void Start()
    {
        
        trackers = FindObjectsOfType<DefaultTrackableEventHandler>();
        SpawnPositions = new Transform[trackers.Length];
        isInstance = new bool[trackers.Length];
        for (int i = 0; i < isInstance.Length; i++)
        {
            isInstance[i] = false;
        }
    }


    
    void Update()
    {
       /* for (int i = 0; i < trackers.Length; i++)
        {
            if(trackers[i].isFound)
            {
                print("instatiated");
                if(isInstance[i]==false)
                {

                    GameObject pref = Instantiate(prefabs[i], trackers[i].gameObject.transform.position, Quaternion.identity,this.gameObject.transform);
                    
                    pref.transform.localScale = new Vector3(3f, 3f, 3f);
                    isInstance[i] = true;
                }
                
            }
        }*/
        if(Input.anyKey)
        {

        }
        
    }

}
