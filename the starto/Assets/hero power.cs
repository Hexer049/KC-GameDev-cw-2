using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class heropower : MonoBehaviour
{
    string HeroName = "sekiro";
    int HeroPower = 320;

    string VillainName = "Isshin";
    int VillainPower = 420;

    float playerspeed = 2.7f;

    // Start is called before the first frame update

    void Start()
    {
        if (HeroPower <= VillainPower)
        {
            print("Villain is superior");


        }
       
        else if (HeroPower <= VillainPower)
        {
            print("corruption is never to be spread");

        }
        
        else
        {
            print("We are equal");
        }


        print(playerspeed);
        SetSpeed(2.5f);
        print(playerspeed);




    }

    // Update is called once per frame
    void Update()
    {

    }
    void SetSpeed(float speed)
    {
        playerspeed = speed;
    }


}
