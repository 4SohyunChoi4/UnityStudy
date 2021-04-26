using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    public float jumpPower;
    public int itemCount;
    public GameManagerLogic manager;
    Rigidbody rigid;
    bool isJump;
    AudioSource audio;

    void Awake()
    {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();

    }
    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        //Vector3 vector = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Jump"), Input.GetAxisRaw("Vertical"));
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
            isJump = false;
    }
    void OnTriggerEnter(Collider other)
    {
        //if (other.name == "Item")
        if (other.tag == "Item")
        {
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false);
            manager.GetItem(itemCount);
        }
        //SetActive(bool) : ������Ʈ Ȱ��ȭ �Լ�
        else if (other.tag == "Finish")
        {
            if ( itemCount == manager.totalItemCount)
            {
                //Game Clear
                SceneManager.LoadScene(manager.stage+1);
            }
            else
            {       
                //Restart 
                SceneManager.LoadScene(manager.stage);
                //���ڿ� �ڿ� ���� ������ �˾Ƽ� ���� ó���ȴ�
            }
        }
    }
}
