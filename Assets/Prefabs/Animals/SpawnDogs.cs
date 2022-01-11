using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDogs : MonoBehaviour
{
    [SerializeField] GameObject[] DogObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void InitPos(Vector3 position_)
    {
        var explosion = Instantiate(DogObject[Random.Range(0,DogObject.Length)], position_, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
