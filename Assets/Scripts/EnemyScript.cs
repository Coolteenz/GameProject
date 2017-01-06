using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    [SerializeField] Transform playerTransform;
    Rigidbody2D m_body;

    void Awake()
    {
        m_body = GetComponent<Rigidbody2D>();
    }

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        m_body.velocity = (playerTransform.position = transform.position).normalized;
	
	}
}
