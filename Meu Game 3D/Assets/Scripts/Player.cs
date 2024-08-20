using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
        
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    { 
        
        Debug.Log("UPDATE"); 
      float h = Input.GetAxis("Horizontal"); // -1 esquerda, 0 nada, 1 direita
      float v = Input.GetAxis("Vertical"); // -1 pra tras, 0 nada, 1 pra frente
      Vector3 direcao = new Vector3(h, 0, v);
      rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);


      if (transform.position.y <= -10)
      {
          //Jogador caiu do mundo
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
      
      
      

    }
}
