using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerPrefab : MonoBehaviour
{
    public GameObject component;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateComponent()
    {
        Instantiate (component, new Vector3(0, 0, 0), Quaternion.identity, this.transform);
    }

}
