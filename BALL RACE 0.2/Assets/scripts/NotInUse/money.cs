using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour
{
    public GameObject cText;
    public GameObject coText;

    void Update()
    {
        cText.GetComponent<Text>().text += coText.GetComponent<Text>().text;
    }
}
