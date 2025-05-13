using UnityEngine;

public class AIShell : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject explosion;
    //float speed = 0.0f;
    float ySpeed = 0.0f;
    float mass = 30.0f;
    float force = 4.0f;
    float drag = 1.0f;
    float gravity = -9.8f;
    float gAccel;
    float acceleration;

    void OnCollisionEnter(Collision col) {

        if (col.gameObject.tag == "tank") {
            GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
