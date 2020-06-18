using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        Vector3 clampedposition = transform.position;
        clampedposition.y = Mathf.Clamp(clampedposition.y, -4f, 4f);
        transform.position = clampedposition;

      

    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(1);
        }
    }
}
