using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wynalda
{
    public class ItemKey : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            print("asdfasdf");
            if (Inventory.main.hasKeyCrystal)
            {
                Destroy(gameObject);
            }
        }
    
        void OnMouseDown()
        {

            Inventory.main.hasKeyCrystal = true;
            print("You picked up the Crystal Key");
            Destroy(gameObject);

        }

    }
}
