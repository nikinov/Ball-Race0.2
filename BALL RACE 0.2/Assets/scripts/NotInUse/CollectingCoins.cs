using UnityEngine;
using UnityEngine.UI;

public class CollectingCoins : MonoBehaviour
{
	static public int gold;

    static public int addAmount = 1;

    public GameObject coins;

    public AudioSource au;

    private void Update()
    {
        coins.GetComponent<Text>().text = gold.ToString("0");
    }

    void OnTriggerEnter(Collider obj)
	{
		if (obj.gameObject.tag == "Player")
		{
            gold += addAmount;
            Destroy(gameObject);
            au.Play();
            Debug.Log("coin collected");
        }
	}
}
