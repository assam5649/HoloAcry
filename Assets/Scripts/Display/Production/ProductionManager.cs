using System.Collections.Generic;
using UnityEngine;

namespace Display.Production
{
    
    public class ProductionManager : MonoBehaviour
    {
        public static Mode CurrentMode = Mode.ChangeColor;

        public static List<GameObject> selectedGameObjects = new List<GameObject>();
        public static List<GameObject> createdGameObjects = new List<GameObject>();

        public Material Default_material;
        
        // Start is called before the first frame update
        void Start()
        {
            createdGameObjects.Add(GameObject.Find("Cube"));
            
            foreach (var createdGameObject in createdGameObjects)
            {
                var outline = createdGameObject.AddComponent<Outline>();
                outline.OutlineMode = Outline.Mode.OutlineAll;
                outline.OutlineColor =Color.red;
                outline.OutlineWidth = 5f;

            }
        }

        // Update is called once per frame
        void Update()
        {
            
            if (selectedGameObjects.Count == 0)
            {
                ProductionFunction.Camera();
            }
            else
            {
            }
            
                        
            //選択されているオブジェクトにアウトラインを適用する処理
            foreach (var createdGameObject in createdGameObjects)
            {
                
                if (selectedGameObjects.Exists(x => x == createdGameObject))
                {
                    var outline = createdGameObject.GetComponent<Outline>();
                    outline.OutlineMode = Outline.Mode.OutlineAll;
                }
                else
                {
                    var outline = createdGameObject.GetComponent<Outline>();
                    outline.OutlineMode = Outline.Mode.OutlineHidden;
                }
            }
        }
    }
}
