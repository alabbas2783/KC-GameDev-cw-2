using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string heroName = "monky de lofy";
    int heroPower = 200;

    string villainName = "zoro";
    int villairPower = 165;

    float Playerspeed = 5.5f;
    // Start is called before the first frame update
    void Start()
    {
        if (heroPower > villairPower)
        {

            print("monky de lofy : I am The stroger");

        }
        else if (heroPower < villairPower)
        {
            print("zoro : I am The stroger");
        }

        print(Playerspeed);
        function(2.5f);
        print(Playerspeed);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void function(float speed)
    {

        Playerspeed = speed;




    }











}
