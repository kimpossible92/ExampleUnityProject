using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    [SerializeField] List<AnimalController> controllers = new List<AnimalController>();
    [SerializeField]protected AnimalController animalController;
    [SerializeField] GameObject Rabbits;
    private bool isgameOver = false;
    private Vector3[] positions_ = { new Vector3(11.46f, -1.90734f, -11.91f), new Vector3(8.3f, -1.90734f, -11.91f), new Vector3(4.46f, -1.90734f, -11.91f) };
    public AnimalController controller()
    {
        return animalController;
    }
    // Start is called before the first frame update
    void Start()
    {
        SetController();
    }
    public void SetController()
    {
        controllers = new List<AnimalController>();
        foreach (var _controller in FindObjectsOfType<AnimalController>())
        {
            if(_controller!=null)controllers.Add(_controller);
        }
        animalController = controllers[Random.Range(0, controllers.Count)];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        if(GUI.Button(new Rect(15, 10, 50, 20), "Bomb"))
        {
            animalController.InitExplosion();
        }
        if (animalController == null)
        {
            if (GUI.Button(new Rect(75, 10, 50, 20), "Reset"))
            {
                foreach (var dc_ in FindObjectsOfType<DogController>())
                {
                    dc_.transform.position = dc_.StartPosition;
                }
                for (int i = 0; i < positions_.Length; i++)
                {
                    Instantiate(Rabbits, positions_[i], Quaternion.identity);
                }
                SetController();
            }
        }
    }
}
