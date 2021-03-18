using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make_child : MonoBehaviour
{
    [SerializeField] GameObject child_asteroid;
    [SerializeField] bool tobe_instantiated;
    // Start is called before the first frame update
    public void Instantiate_Child(Transform parent_position)
    {
        if (tobe_instantiated){
            Instantiate(child_asteroid, parent_position.position, Quaternion.identity);
            Instantiate(child_asteroid, parent_position.position, Quaternion.identity);
        }
    }
}
