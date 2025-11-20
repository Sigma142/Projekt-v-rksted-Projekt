using UnityEngine;

public class pillepickup : MonoBehaviour
{
    public float lunge = 0f;
    [SerializeField] private LayerMask mask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, lunge , mask))
        {
            if (hit.collider.CompareTag("Pills"))
            {

                if (Input.GetKeyDown(KeyCode.E))
                {
                    gamma_radioaktivitet.piller += 1;
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}
