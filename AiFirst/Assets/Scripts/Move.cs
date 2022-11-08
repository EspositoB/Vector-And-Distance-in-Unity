using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    [SerializeField] float moveSpeed = 2f;

    void Start() {

        //direction = goal.transform.position - transform.position;
        
        //this.transform.Translate(direction);
    }

    private void LateUpdate() 
    {
        direction = goal.transform.position - transform.position;
        this.transform.LookAt(goal.transform.position);
        if(direction.magnitude > 2)
        {
            Vector3 velocity = direction.normalized*moveSpeed*Time.deltaTime;
            this.transform.position += velocity;
        }  
    }
}
