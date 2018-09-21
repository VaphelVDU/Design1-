//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.SceneManagement;

//public class Damage : MonoBehaviour
//{
//    [SerializeField] Transform spawnPoint;
//    public int playerHealth = 3;
//    public int damageAmount = 1;
//    public int seconds = 2;

//    void Start()
//    {

//    }

//    void Update()
//    {
//        PlayerLife();
//    }
//    public void TakingDamage(int damageAmount)
//    {
//        health = health - damageAmount;
//        Print("Character damaged");
//    }
//    void PlayerLife()
//    {
//        if (health <= 0 && respawning == false)
//        {
//            respawning = true;
//            print("now dead");
//            StartCoroutine(Respawn());
//        }
//    }
//    public IEnumerator Respawn()
//    {
//        Print("started respawn");
//        yield return new WaitForSeconds(seconds);
//        Print("respawning");


//        transform.position = spawnPoint.position;
//        //switchCamScript.Reset();

//        playerHealth = 1;
//        respawning = false;
//    }
//}


