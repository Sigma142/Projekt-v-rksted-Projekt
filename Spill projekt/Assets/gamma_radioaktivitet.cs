using TMPro;
using UnityEngine;

public class gamma_radioaktivitet : MonoBehaviour
{
    public static int piller = 0;
    [SerializeField] private TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = "Gamma piller: " + piller;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Gamma piller: " + piller;
    }
}
