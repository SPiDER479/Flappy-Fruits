using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject spike;
    [SerializeField] private GameObject player;
    [SerializeField] private new GameObject camera;
    [SerializeField] private Text coinCount;
    public static int coins = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = Instantiate(player, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.Euler(0, 0, 0));
        camera = Instantiate(camera, new Vector3(0.0f, 0.0f, -10.0f), Quaternion.Euler(0, 0, 0));
        player.transform.parent = transform;
        camera.transform.parent = player.transform;
        coinCount.text = coins.ToString();
        GameObject sp = Instantiate(spike, new Vector3(9.0f, 0.0f, 0.0f), Quaternion.Euler(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        coinCount.text = coins.ToString();
    }
}
