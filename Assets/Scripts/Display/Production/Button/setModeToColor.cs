using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class setModeToColor : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        
        public void ChangeColor()
        {
            ProductionManager.CurrentMode = Mode.ChangeColor;
        }
        
    }
}