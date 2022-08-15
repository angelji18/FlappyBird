using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField] float maxTimebwSpawn = 1;
    [SerializeField] float timerSinceLastSpawn = 0;
    [SerializeField] GameObject pipeGameObject;
    [SerializeField] float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timerSinceLastSpawn > maxTimebwSpawn)
        {
            GameObject newPipeGameObject = Instantiate(pipeGameObject);
            newPipeGameObject.transform.position = transform.position + new Vector3(0, Random.RandomRange(-height, height), 0);
            //since this goes on for infinity it is important to destroy the pipes at intervals ; 2nd parameter is the time before the pipe is destroyed
            Destroy(newPipeGameObject, 15);
            timerSinceLastSpawn = 0;
        }
        timerSinceLastSpawn += Time.deltaTime;
    
    }
}
