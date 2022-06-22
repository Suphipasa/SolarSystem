using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uzayturn : MonoBehaviour
{
    public GameObject world;
    public int angle = 0;
    public int counter;
    public int goToSceneAtIndex;
    void Start()
    {
        angle = 0;
        counter = 0;
    }

    void Update()
    {
        //transform.Rotate(new Vector3(world.transform.position.x, world.transform.position.y, angle));
        world.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, angle);

        if (counter >= 5 || counter <= -5)
        {
            SceneManager.LoadScene(goToSceneAtIndex);
        }
    }

    public void IncreaseAngle()
    {
        angle -= 72;
        counter--;
    }
    public void DecreaseAngle()
    {
        angle += 72;
        counter++;
    }
}
