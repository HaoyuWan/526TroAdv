using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireBasePost : MonoBehaviour
{
    // Start is called before the first frame update

    public RestClientMessager myRestClienMessager;
    
    void Start()
    {
        myRestClienMessager = GetComponent<RestClientMessager>();
        Post();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Post all the messages to Firebase in this one method;
    public void Post(){
        //myRestClienMessager.Post("test1", "test2", 1);

        // sending all the level time total for a user.
        myRestClienMessager.Post("Time", PlayerPrefs.GetFloat("Zone1", 0) + "", 1);
        myRestClienMessager.Post("Time", PlayerPrefs.GetFloat("Zone2", 0) + "", 2);
        myRestClienMessager.Post("Time", PlayerPrefs.GetFloat("Zone3", 0) + "", 3);
        myRestClienMessager.Post("Time", PlayerPrefs.GetFloat("Zone4", 0) + "", 4);

        myRestClienMessager.Post("Damage", PlayerPrefs.GetInt("Damage1", 0) + "", 1);
        myRestClienMessager.Post("Damage", PlayerPrefs.GetInt("Damage2", 0) + "", 2);
        myRestClienMessager.Post("Damage", PlayerPrefs.GetInt("Damage3", 0) + "", 3);
        myRestClienMessager.Post("Damage", PlayerPrefs.GetInt("Damage4", 0) + "", 4);
        
        myRestClienMessager.Post("Death", PlayerPrefs.GetInt("Death1", 0) + "", 1);
        myRestClienMessager.Post("Death", PlayerPrefs.GetInt("Death2", 0) + "", 2);
        myRestClienMessager.Post("Death", PlayerPrefs.GetInt("Death3", 0) + "", 3);
        myRestClienMessager.Post("Death", PlayerPrefs.GetInt("Death4", 0) + "", 4);

        myRestClienMessager.Post("Enemy", PlayerPrefs.GetInt("Enemy1", 0) + "", 1);
        myRestClienMessager.Post("Enemy", PlayerPrefs.GetInt("Enemy2", 0) + "", 2);
        myRestClienMessager.Post("Enemy", PlayerPrefs.GetInt("Enemy3", 0) + "", 3);
        myRestClienMessager.Post("Enemy", PlayerPrefs.GetInt("Enemy4", 0) + "", 4);

        myRestClienMessager.Post("Spike", PlayerPrefs.GetInt("Spike1", 0) + "", 1);
        myRestClienMessager.Post("Spike", PlayerPrefs.GetInt("Spike2", 0) + "", 2);
        myRestClienMessager.Post("Spike", PlayerPrefs.GetInt("Spike3", 0) + "", 3);
        myRestClienMessager.Post("Spike", PlayerPrefs.GetInt("Spike4", 0) + "", 4);
        
        myRestClienMessager.Post("Acid", PlayerPrefs.GetInt("Acid1", 0) + "", 1);
        myRestClienMessager.Post("Acid", PlayerPrefs.GetInt("Acid2", 0) + "", 2);
        myRestClienMessager.Post("Acid", PlayerPrefs.GetInt("Acid3", 0) + "", 3);
        myRestClienMessager.Post("Acid", PlayerPrefs.GetInt("Acid4", 0) + "", 4);

         myRestClienMessager.Post("MeleeHit", PlayerPrefs.GetInt("MeleeHit1", 0) + "", 1);
        myRestClienMessager.Post("MeleeHit", PlayerPrefs.GetInt("MeleeHit2", 0) + "", 2);
        myRestClienMessager.Post("MeleeHit", PlayerPrefs.GetInt("MeleeHit3", 0) + "", 3);
        myRestClienMessager.Post("MeleeHit", PlayerPrefs.GetInt("MeleeHit4", 0) + "", 4);
        
        myRestClienMessager.Post("MeleeNoHit", PlayerPrefs.GetInt("MeleeNoHit1", 0) + "", 1);
        myRestClienMessager.Post("MeleeNoHit", PlayerPrefs.GetInt("MeleeNoHit2", 0) + "", 2);
        myRestClienMessager.Post("MeleeNoHit", PlayerPrefs.GetInt("MeleeNoHit3", 0) + "", 3);
        myRestClienMessager.Post("MeleeNoHit", PlayerPrefs.GetInt("MeleeNoHit4", 0) + "", 4);

         myRestClienMessager.Post("BulletHit", PlayerPrefs.GetInt("BulletHit1", 0) + "", 1);
        myRestClienMessager.Post("BulletHit", PlayerPrefs.GetInt("BulletHit2", 0) + "", 2);
        myRestClienMessager.Post("BulletHit", PlayerPrefs.GetInt("BulletHit3", 0) + "", 3);
        myRestClienMessager.Post("BulletHit", PlayerPrefs.GetInt("BulletHit4", 0) + "", 4);
        
        myRestClienMessager.Post("BulletNoHit", PlayerPrefs.GetInt("BulletNoHit1", 0) + "", 1);
        myRestClienMessager.Post("BulletNoHit", PlayerPrefs.GetInt("BulletNoHit2", 0) + "", 2);
        myRestClienMessager.Post("BulletNoHit", PlayerPrefs.GetInt("BulletNoHit3", 0) + "", 3);
        myRestClienMessager.Post("BulletNoHit", PlayerPrefs.GetInt("BulletNoHit4", 0) + "", 4);

        myRestClienMessager.Post("FinishTime", "", 0);




    }
}
