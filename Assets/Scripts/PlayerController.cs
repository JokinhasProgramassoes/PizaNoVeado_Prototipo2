using UnityEngine;

public class PlayerController : MonoBehaviour
{
//Variaveis
    //Prefab
    public GameObject projectilePrefab;
    //Movimento do Player
    public float horizontalInput;
    public float speed = 1f;
    //Limite mapa
    public float xRange = 10;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Limite do mapa
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
    }
}
