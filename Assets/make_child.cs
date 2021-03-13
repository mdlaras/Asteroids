using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make_child : MonoBehaviour
{
    [SerializeField] GameObject child_asteroid;
    [SerializeField] bool instantiate;
    // Start is called before the first frame update
    public void instantiate_child(Transform parent_position)
    {
        if (instantiate){
            Instantiate(child_asteroid, parent_position.position, Quaternion.identity);
            Instantiate(child_asteroid, parent_position.position, Quaternion.identity);
        }
    }
}
