
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
//Variaveis
    public GameObject[] animalPrefabs;
    //public int animalIndex;
    //Posição dos animais:
    private int spawnRangeX = 20;
    private int spawnPosZ = 20;
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.S))
        {
            //Gera o animal numa posicao aleatoria:
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);  
            //Gera um animal aleatorio:
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, 
            animalPrefabs[animalIndex].transform.rotation);
        }  
    }
}
