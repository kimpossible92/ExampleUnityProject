using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadStomp : MonoBehaviour
{
    public Aoe aoeStompAttack;
    private IEnumerator GoToTargetAndStomp(Vector3 destination)
    {
        while (Vector3.Distance(transform.position, destination) > aoeStompAttack.Range)
        {
            //agent.destination = destination;
            yield return null;
        }
        //agent.isStopped = true;
        //_animator.SetTrigger("Stomp");
    }
    public void Stomp()
    {
        aoeStompAttack.Fire(gameObject, gameObject.transform.position, LayerMask.NameToLayer("PlayerSpells"));
    }
    public void EmptyStomp()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        DogController dogController = collision.gameObject.GetComponent<DogController>();
        if (dogController != null)
        {
            GetComponent<SpawnDogs>().InitPos(dogController.StartPosition);
            Destroy(dogController.gameObject);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
