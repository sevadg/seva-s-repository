using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int health = 100;
    int level = 1;
    int speed = 1;
    Vector3 newPosition; 

    void Start()
    {
        health = health + level;
        print(health);
    }
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
