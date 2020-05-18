using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyCollisionBall : MonoBehaviour {

    private Rigidbody rb;
    private int count;
    public GameObject spawner;
    public Slider healthBar;
    public TextMeshProUGUI healthValue;

    void Start() {
        spawner = GameObject.Find("respawn");
        spawner.GetComponent<Respawn>().destroyed = false;
        rb = GetComponent<Rigidbody>();
        count = 0;
        healthBar = GameObject.FindGameObjectWithTag("healthBar").GetComponent<Slider>();
        healthValue = GameObject.FindGameObjectWithTag("healthCounter").GetComponent<TextMeshProUGUI>();
        updateBar();
    }

    void Update() {
        if (Input.GetKey("enter")) {
            Debug.Log("simom");
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("coin")) {
            Destroy(collision.gameObject);
            count += 1;
            updateBar();
        } else if (collision.gameObject.CompareTag("lava") && count<3) {
            spawner.GetComponent<Respawn>().destroyed = true;
            Destroy(gameObject);
        } else if (collision.gameObject.CompareTag("enemy")) {
            Destroy(gameObject);
        }
    }

    private void updateBar() {
        if (healthBar) {
            healthBar.value = count;
            healthValue.text = count.ToString() + "/3";
        }
    }
}
