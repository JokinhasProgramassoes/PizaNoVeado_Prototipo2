
using UnityEngine;
using UnityEngine.Rendering;

public class SpawnManager : MonoBehaviour
{
//Variaveis
    public GameObject[] animalPrefabs;
    //Posição dos animais:
    private int spawnRangeX = 20;
    private int spawnPosZ = 20;
    //Invoke Reapiting:
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {
      //if(Input.GetKeyDown(KeyCode.S))
        //{
          // SpawnRandomAnimal();
        //}  
    }

    void SpawnRandomAnimal ()
    {
         //Gera o animal numa posicao aleatoria:
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);  
            //Gera um animal aleatorio:
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, 
            animalPrefabs[animalIndex].transform.rotation);
    }
}
