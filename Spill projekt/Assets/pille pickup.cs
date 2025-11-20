using TMPro;
using UnityEngine;

public class pillepickup : MonoBehaviour
{
    public float lunge = 0f;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private LayerMask mask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, lunge, mask))
        {
           Debug.Log(hit.collider.name);
            if (hit.collider.CompareTag("Pills"))
            {
                text.text = "Tryk E for at samle pille op";
                if (Input.GetKeyDown(KeyCode.E))
                {
                    gamma_radioaktivitet.piller += 1;
                    Destroy(hit.transform.gameObject);
                }
            }
            else
            {
                Debug.Log("ikke piller");
                text.text = "";
            }
        }
        else
        {
            Debug.Log("ingen hit");
            text.text = "";
        }
    }
}
