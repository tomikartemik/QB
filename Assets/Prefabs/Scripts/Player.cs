using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] KeyCode keyThree;
    [SerializeField] Vector3 moveDirection;
    private bool upButtonDown = false;
    private bool downButtonDown = false;

    private Rigidbody rb;

    
    private void Start()
    {
       if(!PlayerPrefs.HasKey("off")) PlayerPrefs.SetInt("off", 2);


        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
        {
            rb.velocity += moveDirection;
        }
        if (Input.GetKey(keyTwo))
        {
            rb.velocity -= moveDirection;
        }
        if (upButtonDown)
        {
            rb.velocity += moveDirection;
        }
        if (downButtonDown)
        {
            rb.velocity -= moveDirection;
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(keyThree))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
    public void OnUpButtonDown()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // GetComponent<Rigidbody>().velocity += moveDirection;
        upButtonDown = true;
    }
    public void OnDownButtonDown()
    {
        downButtonDown = true;
    }
    public void OnUpButtonUp()
    {
        upButtonDown = false;
    }
    public void OnDownButtonUp()
    {
        downButtonDown = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            
            int off = PlayerPrefs.GetInt("off");
            if (SceneManager.GetActiveScene().buildIndex >= off)
            {
                PlayerPrefs.SetInt("off", off + 1);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if(this.CompareTag("cube1") && other.CompareTag("downplt"))
        {
            gameObject.transform.position = new Vector3(1.09f, 9f, -1.3f);
        }
        if (this.CompareTag("cube2") && other.CompareTag("downplt"))
        {
            gameObject.transform.position = new Vector3(0f, 9.11f, 0f);
        }
        if (this.CompareTag("cube3") && other.CompareTag("downplt"))
        {
            gameObject.transform.position = new Vector3(1.22f, 13.92f, -0.6f);
        }
        if (this.CompareTag("cube4") && other.CompareTag("downplt"))
        {
            gameObject.transform.position = new Vector3(-0.08f, 15.75f, 2.78f);
        }
    }

    public void Move(string btnName)
    {
        switch (btnName){
            case "up":
            case "left":
                rb.velocity += moveDirection;
                break;
            case "down":
            case "right":
                rb.velocity -= moveDirection;
                break;
            default:
                Debug.LogError("неверный btnName");
                break;
        }
    }
    public void OnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnClickStart()
    {
        int off = PlayerPrefs.GetInt("off");
        SceneManager.LoadScene(off);
    }
    public void OpenMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void CloseMenu()
    {
        SceneManager.LoadScene(0);
    }
        
    public void O1()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 1)
        {

            SceneManager.LoadScene(2);
        }
    }
    public void O2()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 2)
        {

            SceneManager.LoadScene(3);
        }
    }
    public void O3()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 3)
        {

            SceneManager.LoadScene(4);
        }
    }
    public void O4()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 4)
        {

            SceneManager.LoadScene(5);
        }
    }
    public void O5()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 5)
        {

            SceneManager.LoadScene(6);
        }
    }
    public void O6()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 6)
        {

            SceneManager.LoadScene(7);
        }
    }
    public void O7()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 7)
        {

            SceneManager.LoadScene(8);
        }
    }
    public void O8()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 8)
        {

            SceneManager.LoadScene(9);
        }
    }
    public void O9()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 9)
        {

            SceneManager.LoadScene(10);
        }
    }
    public void O10()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 10)
        {

            SceneManager.LoadScene(11);
        }
    }
    public void O11()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 11)
        {

            SceneManager.LoadScene(12);
        }
    }
    public void O12()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 12)
        {

            SceneManager.LoadScene(13);
        }
    }
    public void O13()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 13)
        {

            SceneManager.LoadScene(14);
        }
    }
    public void O14()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 14)
        {

            SceneManager.LoadScene(15);
        }
    }
    public void O15()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 15)
        {

            SceneManager.LoadScene(16);
        }
    }
    public void O16()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 16)
        {

            SceneManager.LoadScene(17);
        }
    }
    public void O17()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 17)
        {

            SceneManager.LoadScene(18);
        }
    }
    public void O18()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 18)
        {

            SceneManager.LoadScene(19);
        }
    }
    public void O19()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 19)
        {

            SceneManager.LoadScene(20);
        }
    }
    public void O20()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 20)
        {

            SceneManager.LoadScene(21);
        }
    }
    public void O21()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 21)
        {

            SceneManager.LoadScene(22);
        }
    }
    public void O22()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 22)
        {

            SceneManager.LoadScene(23);
        }
    }
    public void O23()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 23)
        {

            SceneManager.LoadScene(24);
        }
    }
    public void O24()
    {
        int off = PlayerPrefs.GetInt("off");
        if (off > 24)
        {

            SceneManager.LoadScene(25);
        }
    }
}