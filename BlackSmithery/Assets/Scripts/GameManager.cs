using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int OresCount = 7;
    
    public ParticleSystem[] partSys;
    public GameObject hammerOb;
    public GameObject crucibalOb;
    public GameObject calOb;
    public GameObject forgeOb;
    public GameObject CPOb;
    public GameObject moldOb;
    public GameObject quenchOb;
    public GameObject bladePiece;
    public GameObject otherBladePiece;

    public bool paused = false;
    public GameObject PauseMenu;
    public GameObject GameOverPanel;
    public bool gameOver = false;
    public GameObject Winner;
    public bool isWon = false;
    public GameObject SwordOne;
    public GameObject SwordTwo;
    public GameObject SwordThree;
    public GameObject SwordBladeTwo;
    public GameObject SwordBladeOne;
    public GameObject SwordBladeThree;



    // Start is called before the first frame update
    void Start()
    {
        OresCount = 7;
        paused = false;
        gameOver = false;
    }

    public void BreakMold()
    {
        Destroy(moldOb);
    }



    public void SaveTwi() {
         
    }







    public void SaveGame()
    {
        Vector3 rot = new Vector3(180, 0, 0);
        SwordOne.transform.eulerAngles = rot;
        SwordTwo.transform.eulerAngles = rot;
        SwordThree.transform.eulerAngles = rot;

        //SwordOne = getga
        //if (SwordOne != null)
        //{
        //    SwordOne.GetComponent<hiltS>().Refresh();

        //}
        //if (SwordTwo != null)
        //{
        //    SwordTwo.GetComponent<hiltS>().Refresh();

        //}
        //if (SwordThree != null)
        //{
        //    SwordThree.GetComponent<hiltS>().Refresh();

        //}
        if (SwordBladeOne != null)
        {
            
            if (SwordBladeOne.tag == "Blade")
            {
                ES3.Save<int>("sw1", 1);
                //SwordBladeOne.GetComponent<buildMetal>().stateNumber = true;
                ES3.Save<int>("idOne", SwordBladeOne.GetComponent<buildMetal>().yourID);

                ES3.Save<Transform>("trans1", SwordBladeOne.GetComponent<buildMetal>().transform);
                ES3.Save<Vector3>("pt81", SwordBladeOne.GetComponent<buildMetal>().cornerEight);
                ES3.Save<Vector3>("pt91", SwordBladeOne.GetComponent<buildMetal>().cornerNine);
                ES3.Save<Vector3>("pt111", SwordBladeOne.GetComponent<buildMetal>().cornerEleven);
                ES3.Save<Vector3>("pt101", SwordBladeOne.GetComponent<buildMetal>().cornerTen);
                ES3.Save<Vector3>("pt161", SwordBladeOne.GetComponent<buildMetal>().cornerSixteen);
                ES3.Save<Vector3>("pt171", SwordBladeOne.GetComponent<buildMetal>().cornerSeventeen);
                ES3.Save<Vector3>("pt21", SwordBladeOne.GetComponent<buildMetal>().cornerTwo);
                ES3.Save<Vector3>("pt71", SwordBladeOne.GetComponent<buildMetal>().cornerSeven);
                ES3.Save<Vector3>("pt51", SwordBladeOne.GetComponent<buildMetal>().cornerFive);
                ES3.Save<Vector3>("pt01", SwordBladeOne.GetComponent<buildMetal>().cornerZero);
                ES3.Save<Vector3>("pt121", SwordBladeOne.GetComponent<buildMetal>().cornerTwelve);
                ES3.Save<Vector3>("pt151", SwordBladeOne.GetComponent<buildMetal>().cornerFifteen);
                ES3.Save<Vector3>("pt181", SwordBladeOne.GetComponent<buildMetal>().cornerEighteen);
                ES3.Save<Vector3>("pt191", SwordBladeOne.GetComponent<buildMetal>().cornerNineteen);
                ES3.Save<float>("floaty1", SwordBladeOne.GetComponent<buildMetal>().floatery);
                //ES3.Save<Vector3>("mounty1", SwordBladeOne.GetComponent<buildMetal>().mountPos);
                ES3.Save<float>("attack1", SwordBladeOne.GetComponent<buildMetal>().swordPoints);


            }
            else
            {
                ES3.Save<int>("sw1", 2);
                //SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().stateNumber = true;
                ES3.Save<int>("idOne", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().yourID);

                ES3.Save<Transform>("trans1", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().transform);
                ES3.Save<Vector3>("pt81", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEight);
                ES3.Save<Vector3>("pt91", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNine);
                ES3.Save<Vector3>("pt111", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEleven);
                ES3.Save<Vector3>("pt101", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTen);
                ES3.Save<Vector3>("pt161", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSixteen);
                ES3.Save<Vector3>("pt171", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeventeen);
                ES3.Save<Vector3>("pt21", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwo);
                ES3.Save<Vector3>("pt71", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeven);
                ES3.Save<Vector3>("pt51", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFive);
                ES3.Save<Vector3>("pt01", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerZero);
                ES3.Save<Vector3>("pt121", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwelve);
                ES3.Save<Vector3>("pt151", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFifteen);
                ES3.Save<Vector3>("pt181", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEighteen);
                ES3.Save<Vector3>("pt191", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNineteen);
                ES3.Save<float>("floaty1", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().floatery);
                ES3.Save<float>("attack1", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().swordPoints);
            }
        }
        else
        {
            ES3.Save<int>("sw1", 0);
        }

        if (SwordBladeTwo != null)
        {

            if (SwordBladeTwo.tag == "Blade")
            {
                ES3.Save<int>("sw2", 1);
                ES3.Save<int>("idTwo", SwordBladeOne.GetComponent<buildMetal>().yourID);
                ES3.Save<Transform>("trans2", SwordBladeTwo.GetComponent<buildMetal>().transform);
                ES3.Save<Vector3>("pt82", SwordBladeTwo.GetComponent<buildMetal>().cornerEight);
                ES3.Save<Vector3>("pt92", SwordBladeTwo.GetComponent<buildMetal>().cornerNine);
                ES3.Save<Vector3>("pt112", SwordBladeTwo.GetComponent<buildMetal>().cornerEleven);
                ES3.Save<Vector3>("pt102", SwordBladeTwo.GetComponent<buildMetal>().cornerTen);
                ES3.Save<Vector3>("pt162", SwordBladeTwo.GetComponent<buildMetal>().cornerSixteen);
                ES3.Save<Vector3>("pt172", SwordBladeTwo.GetComponent<buildMetal>().cornerSeventeen);
                ES3.Save<Vector3>("pt22", SwordBladeTwo.GetComponent<buildMetal>().cornerTwo);
                ES3.Save<Vector3>("pt72", SwordBladeTwo.GetComponent<buildMetal>().cornerSeven);
                ES3.Save<Vector3>("pt52", SwordBladeTwo.GetComponent<buildMetal>().cornerFive);
                ES3.Save<Vector3>("pt02", SwordBladeTwo.GetComponent<buildMetal>().cornerZero);
                ES3.Save<Vector3>("pt122", SwordBladeTwo.GetComponent<buildMetal>().cornerTwelve);
                ES3.Save<Vector3>("pt152", SwordBladeTwo.GetComponent<buildMetal>().cornerFifteen);
                ES3.Save<Vector3>("pt182", SwordBladeTwo.GetComponent<buildMetal>().cornerEighteen);
                ES3.Save<Vector3>("pt192", SwordBladeTwo.GetComponent<buildMetal>().cornerNineteen);
                ES3.Save<float>("floaty2", SwordBladeTwo.GetComponent<buildMetal>().floatery);
                //ES3.Save<Vector3>("mounty2", SwordBladeTwo.GetComponent<buildMetal>().mountPos);
                ES3.Save<float>("attack2", SwordBladeTwo.GetComponent<buildMetal>().swordPoints);
            }
            else
            {
                ES3.Save<int>("sw2", 2);
                //SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().stateNumber = true;
                ES3.Save<int>("idTwo", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().yourID);

                ES3.Save<Transform>("trans2", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().transform);
                ES3.Save<Vector3>("pt82", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEight);
                ES3.Save<Vector3>("pt92", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNine);
                ES3.Save<Vector3>("pt112", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEleven);
                ES3.Save<Vector3>("pt102", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTen);
                ES3.Save<Vector3>("pt162", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSixteen);
                ES3.Save<Vector3>("pt172", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeventeen);
                ES3.Save<Vector3>("pt22", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwo);
                ES3.Save<Vector3>("pt72", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeven);
                ES3.Save<Vector3>("pt52", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFive);
                ES3.Save<Vector3>("pt02", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerZero);
                ES3.Save<Vector3>("pt122", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwelve);
                ES3.Save<Vector3>("pt152", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFifteen);
                ES3.Save<Vector3>("pt182", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEighteen);
                ES3.Save<Vector3>("pt192", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNineteen);
                ES3.Save<float>("floaty2", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().floatery);
                ES3.Save<float>("attack2", SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().swordPoints);
            }
        }
        else
        {
            ES3.Save<int>("sw2", 0);
        }

        if (SwordBladeThree != null)
        {
            
            if (SwordBladeThree.tag == "Blade")
            {
                ES3.Save<int>("sw3", 1);
                ES3.Save<int>("idThree", SwordBladeOne.GetComponent<buildMetal>().yourID);

                ES3.Save<Transform>("trans3", SwordBladeThree.GetComponent<buildMetal>().transform);
                ES3.Save<Vector3>("pt83", SwordBladeThree.GetComponent<buildMetal>().cornerEight);
                ES3.Save<Vector3>("pt93", SwordBladeThree.GetComponent<buildMetal>().cornerNine);
                ES3.Save<Vector3>("pt113", SwordBladeThree.GetComponent<buildMetal>().cornerEleven);
                ES3.Save<Vector3>("pt103", SwordBladeThree.GetComponent<buildMetal>().cornerTen);
                ES3.Save<Vector3>("pt163", SwordBladeThree.GetComponent<buildMetal>().cornerSixteen);
                ES3.Save<Vector3>("pt173", SwordBladeThree.GetComponent<buildMetal>().cornerSeventeen);
                ES3.Save<Vector3>("pt23", SwordBladeThree.GetComponent<buildMetal>().cornerTwo);
                ES3.Save<Vector3>("pt73", SwordBladeThree.GetComponent<buildMetal>().cornerSeven);
                ES3.Save<Vector3>("pt53", SwordBladeThree.GetComponent<buildMetal>().cornerFive);
                ES3.Save<Vector3>("pt03", SwordBladeThree.GetComponent<buildMetal>().cornerZero);
                ES3.Save<Vector3>("pt123", SwordBladeThree.GetComponent<buildMetal>().cornerTwelve);
                ES3.Save<Vector3>("pt153", SwordBladeThree.GetComponent<buildMetal>().cornerFifteen);
                ES3.Save<Vector3>("pt183", SwordBladeThree.GetComponent<buildMetal>().cornerEighteen);
                ES3.Save<Vector3>("pt193", SwordBladeThree.GetComponent<buildMetal>().cornerNineteen);
                ES3.Save<float>("floaty3", SwordBladeThree.GetComponent<buildMetal>().floatery);
                //ES3.Save<Vector3>("mounty3", SwordBladeThree.GetComponent<buildMetal>().mountPos);
                ES3.Save<float>("attack3", SwordBladeThree.GetComponent<buildMetal>().swordPoints);

            }
            else
            {
                ES3.Save<int>("sw3", 2);
                //SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().stateNumber = true;
                ES3.Save<int>("idThree", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().yourID);

                ES3.Save<Transform>("trans3", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().transform);
                ES3.Save<Vector3>("pt83", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEight);
                ES3.Save<Vector3>("pt93", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNine);
                ES3.Save<Vector3>("pt113", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEleven);
                ES3.Save<Vector3>("pt103", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTen);
                ES3.Save<Vector3>("pt163", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSixteen);
                ES3.Save<Vector3>("pt173", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeventeen);
                ES3.Save<Vector3>("pt23", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwo);
                ES3.Save<Vector3>("pt73", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeven);
                ES3.Save<Vector3>("pt53", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFive);
                ES3.Save<Vector3>("pt03", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerZero);
                ES3.Save<Vector3>("pt123", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwelve);
                ES3.Save<Vector3>("pt153", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFifteen);
                ES3.Save<Vector3>("pt183", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEighteen);
                ES3.Save<Vector3>("pt193", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNineteen);
                ES3.Save<float>("floaty3", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().floatery);
                ES3.Save<float>("attack3", SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().swordPoints);
            }
        }
        else
        {
            ES3.Save<int>("sw3", 0);
        }

        ES3.Save<GameObject>("mySword1", SwordOne);
        ES3.Save<GameObject>("mySword2", SwordTwo);
        ES3.Save<GameObject>("mySword3", SwordThree);

        ES3.Save<GameObject>("myBlade1", SwordBladeOne);
        ES3.Save<GameObject>("myBlade2", SwordBladeTwo);
        ES3.Save<GameObject>("myBlade3", SwordBladeThree);


    }
    public void LoadGame()
    {
        int sw1 = ES3.Load<int>("sw1");
        int sw2 = ES3.Load<int>("sw2");
        int sw3 = ES3.Load<int>("sw3");
        if (sw1>=1)
        {
            if (SwordBladeOne == null)

            {
                //if (sw1 == 2)
                //{
                    
                        SwordBladeOne = Instantiate(bladePiece);
                //}
                //else
                //{
                //    SwordBladeOne = Instantiate(otherBladePiece);
                //}
            }
        }
        if (sw2 >= 1)
        {
            if (SwordBladeOne == null)

            {
                //if (sw2 == 2)
                //{

                    SwordBladeTwo = Instantiate(bladePiece);
                //}
                //else
                //{
                //    SwordBladeTwo = Instantiate(otherBladePiece);
                //}
            }
        }
        if (sw3 >= 1)
        {
            if (SwordBladeOne == null)

            {
                //if (sw3 == 2)
                //{

                    SwordBladeThree = Instantiate(bladePiece);
                ///}
                //else
                //{
                //    SwordBladeThree = Instantiate(otherBladePiece);
                //}
            }
        }

        try
        {
            GameObject mySword1 = ES3.Load<GameObject>("mySword1");
            
            try
            {
                GameObject mySword2 = ES3.Load<GameObject>("mySword2");
                try
                {
                    GameObject mySword3 = ES3.Load<GameObject>("mySword3");
                }
                catch
                {
                    print("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                }
            }
            catch
            {
                print("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            }
        }
        catch {
            print("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        }

        try
        {
            GameObject myBlade1 = ES3.Load<GameObject>("myBlade1");

            try
            {
                GameObject myBlade2 = ES3.Load<GameObject>("myBlade2");
                try
                {
                    GameObject myBlade3 = ES3.Load<GameObject>("myBlade3");
                }
                catch
                {
                    print("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB");
                }
            }
            catch
            {
                print("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB");
            }
        }
        catch
        {
            print("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB");
        }
        if (SwordBladeOne != null)
        {
            

            if (SwordBladeOne.tag == "Blade")
            {
                SwordBladeOne.GetComponent<buildMetal>().stateNumber = true;
                //SwordBladeOne.GetComponent<buildMetal>().stateNumber = true;
                //GameObject myBlade3 = ES3.Load<GameObject>("myBlade3");

                
                SwordBladeOne.GetComponent<buildMetal>().cornerEight = ES3.Load<Vector3>("pt81");
                SwordBladeOne.GetComponent<buildMetal>().cornerNine = ES3.Load<Vector3>("pt91");
                SwordBladeOne.GetComponent<buildMetal>().cornerEleven = ES3.Load<Vector3>("pt111");
                SwordBladeOne.GetComponent<buildMetal>().cornerTen = ES3.Load<Vector3>("pt101");
                SwordBladeOne.GetComponent<buildMetal>().cornerSixteen = ES3.Load<Vector3>("pt161");
                SwordBladeOne.GetComponent<buildMetal>().cornerSeventeen = ES3.Load<Vector3>("pt171");
                SwordBladeOne.GetComponent<buildMetal>().cornerTwo = ES3.Load<Vector3>("pt21");
                SwordBladeOne.GetComponent<buildMetal>().cornerSeven = ES3.Load<Vector3>("pt71");
                SwordBladeOne.GetComponent<buildMetal>().cornerFive = ES3.Load<Vector3>("pt51");
                SwordBladeOne.GetComponent<buildMetal>().cornerZero = ES3.Load<Vector3>("pt01");
                SwordBladeOne.GetComponent<buildMetal>().cornerTwelve = ES3.Load<Vector3>("pt121");
                SwordBladeOne.GetComponent<buildMetal>().cornerFifteen = ES3.Load<Vector3>("pt151");
                SwordBladeOne.GetComponent<buildMetal>().cornerEighteen = ES3.Load<Vector3>("pt181");
                SwordBladeOne.GetComponent<buildMetal>().cornerNineteen = ES3.Load<Vector3>("pt191");
                SwordBladeOne.GetComponent<buildMetal>().floatery = ES3.Load<float>("floaty1");
                //SwordBladeOne.GetComponent<buildMetal>().mountPos = ES3.Load<Vector3>("mounty1");
                SwordBladeOne.GetComponent<buildMetal>().mounted = true;
                SwordBladeOne.GetComponent<buildMetal>().swordPoints = ES3.Load<float>("attack1");


                Transform transOne = ES3.Load<Transform>("trans1");
                SwordBladeOne.GetComponent<buildMetal>().transform.position = transOne.position;
                //SwordBladeOne.GetComponent<buildMetal>().transform.rotation = transOne.rotation;
                int idOne = ES3.Load<int>("idOne");
                if(idOne == 1)
                {
                    
                    
                    SwordBladeOne.transform.SetParent(SwordOne.transform);
                }else if (idOne == 2)
                {
                    SwordBladeOne.transform.SetParent(SwordTwo.transform);
                }else if (idOne == 3)
                {
                    SwordBladeOne.transform.SetParent(SwordThree.transform);
                }

            }
            else
            {
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().stateNumber = true;
                //SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().stateNumber = true;

                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEight = ES3.Load<Vector3>("pt81");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNine = ES3.Load<Vector3>("pt91");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEleven = ES3.Load<Vector3>("pt111");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTen = ES3.Load<Vector3>("pt101");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSixteen = ES3.Load<Vector3>("pt161");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeventeen = ES3.Load<Vector3>("pt171");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwo = ES3.Load<Vector3>("pt21");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeven = ES3.Load<Vector3>("pt71");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFive = ES3.Load<Vector3>("pt51");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerZero = ES3.Load<Vector3>("pt01");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwelve = ES3.Load<Vector3>("pt121");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFifteen = ES3.Load<Vector3>("pt151");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEighteen = ES3.Load<Vector3>("pt181");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNineteen = ES3.Load<Vector3>("pt191");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().floatery = ES3.Load<float>("floaty1");
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().swordPoints = ES3.Load<float>("attack1");

                Transform transOne = ES3.Load<Transform>("trans1"); 
                SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().transform.position = transOne.position;
                //SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().transform.rotation = transOne.rotation;
                
            //ES3.Save<Vector3>("pt81", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEight);
                //ES3.Save<Vector3>("pt91", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNine);
                //ES3.Save<Vector3>("pt111", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEleven);
                //ES3.Save<Vector3>("pt101", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTen);
                //ES3.Save<Vector3>("pt161", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSixteen);
                //ES3.Save<Vector3>("pt171", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeventeen);
                //ES3.Save<Vector3>("pt21", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwo);
                //ES3.Save<Vector3>("pt71", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeven);
                //ES3.Save<Vector3>("pt51", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFive);
                //ES3.Save<Vector3>("pt01", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerZero);
                //ES3.Save<Vector3>("pt121", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwelve);
                //ES3.Save<Vector3>("pt151", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFifteen);
                //ES3.Save<Vector3>("pt181", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEighteen);
                //ES3.Save<Vector3>("pt191", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNineteen);
                //ES3.Save<float>("floaty1", SwordBladeOne.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().floatery);
            }
        }
        if (SwordBladeTwo != null)
        {
            if (SwordBladeTwo.tag == "Blade")
            {
                SwordBladeTwo.GetComponent<buildMetal>().stateNumber = true;

                SwordBladeTwo.GetComponent<buildMetal>().cornerEight = ES3.Load<Vector3>("pt82");
                SwordBladeTwo.GetComponent<buildMetal>().cornerNine = ES3.Load<Vector3>("pt92");
                SwordBladeTwo.GetComponent<buildMetal>().cornerEleven = ES3.Load<Vector3>("pt112");
                SwordBladeTwo.GetComponent<buildMetal>().cornerTen = ES3.Load<Vector3>("pt102");
                SwordBladeTwo.GetComponent<buildMetal>().cornerSixteen = ES3.Load<Vector3>("pt162");
                SwordBladeTwo.GetComponent<buildMetal>().cornerSeventeen = ES3.Load<Vector3>("pt172");
                SwordBladeTwo.GetComponent<buildMetal>().cornerTwo = ES3.Load<Vector3>("pt22");
                SwordBladeTwo.GetComponent<buildMetal>().cornerSeven = ES3.Load<Vector3>("pt72");
                SwordBladeTwo.GetComponent<buildMetal>().cornerFive = ES3.Load<Vector3>("pt52");
                SwordBladeTwo.GetComponent<buildMetal>().cornerZero = ES3.Load<Vector3>("pt02");
                SwordBladeTwo.GetComponent<buildMetal>().cornerTwelve = ES3.Load<Vector3>("pt122");
                SwordBladeTwo.GetComponent<buildMetal>().cornerFifteen = ES3.Load<Vector3>("pt152");
                SwordBladeTwo.GetComponent<buildMetal>().cornerEighteen = ES3.Load<Vector3>("pt182");
                SwordBladeTwo.GetComponent<buildMetal>().cornerNineteen = ES3.Load<Vector3>("pt192");
                SwordBladeTwo.GetComponent<buildMetal>().floatery = ES3.Load<float>("floaty2");
                //SwordBladeTwo.GetComponent<buildMetal>().mountPos = ES3.Load<Vector3>("mounty2");
                SwordBladeTwo.GetComponent<buildMetal>().mounted = true;
                SwordBladeTwo.GetComponent<buildMetal>().swordPoints = ES3.Load<float>("attack2");

                Transform transTwo = ES3.Load<Transform>("trans2");
                SwordBladeTwo.GetComponent<buildMetal>().transform.position = transTwo.position;
                SwordBladeTwo.GetComponent<buildMetal>().transform.rotation = transTwo.rotation;

                int idTwo = ES3.Load<int>("idOne");
                if (idTwo == 1)
                {
                    SwordBladeTwo.transform.SetParent(SwordOne.transform);
                }
                else if (idTwo == 2)
                {
                    SwordBladeTwo.transform.SetParent(SwordTwo.transform);
                }
                else if (idTwo == 3)
                {
                    SwordBladeTwo.transform.SetParent(SwordThree.transform);
                }
            }

            else
            {
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().stateNumber = true;



                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEight = ES3.Load<Vector3>("pt82");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNine = ES3.Load<Vector3>("pt92");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEleven = ES3.Load<Vector3>("pt112");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTen = ES3.Load<Vector3>("pt102");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSixteen = ES3.Load<Vector3>("pt162");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeventeen = ES3.Load<Vector3>("pt172");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwo = ES3.Load<Vector3>("pt22");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeven = ES3.Load<Vector3>("pt72");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFive = ES3.Load<Vector3>("pt52");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerZero = ES3.Load<Vector3>("pt02");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwelve = ES3.Load<Vector3>("pt122");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFifteen = ES3.Load<Vector3>("pt152");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEighteen = ES3.Load<Vector3>("pt182");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNineteen = ES3.Load<Vector3>("pt192");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().floatery = ES3.Load<float>("floaty2");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().swordPoints = ES3.Load<float>("attack2");

                Transform transTwo = ES3.Load<Transform>("trans2");
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().transform.position = transTwo.position;
                SwordBladeTwo.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().transform.rotation = transTwo.rotation;

            }
        }
        if (SwordBladeThree != null)
        {
                if (SwordBladeThree.tag == "Blade")
                {
                    SwordBladeThree.GetComponent<buildMetal>().stateNumber = true;



                    SwordBladeThree.GetComponent<buildMetal>().cornerEight = ES3.Load<Vector3>("pt83");
                    SwordBladeThree.GetComponent<buildMetal>().cornerNine = ES3.Load<Vector3>("pt93");
                    SwordBladeThree.GetComponent<buildMetal>().cornerEleven = ES3.Load<Vector3>("pt113");
                    SwordBladeThree.GetComponent<buildMetal>().cornerTen = ES3.Load<Vector3>("pt103");
                    SwordBladeThree.GetComponent<buildMetal>().cornerSixteen = ES3.Load<Vector3>("pt163");
                    SwordBladeThree.GetComponent<buildMetal>().cornerSeventeen = ES3.Load<Vector3>("pt173");
                    SwordBladeThree.GetComponent<buildMetal>().cornerTwo = ES3.Load<Vector3>("pt23");
                    SwordBladeThree.GetComponent<buildMetal>().cornerSeven = ES3.Load<Vector3>("pt73");
                    SwordBladeThree.GetComponent<buildMetal>().cornerFive = ES3.Load<Vector3>("pt53");
                    SwordBladeThree.GetComponent<buildMetal>().cornerZero = ES3.Load<Vector3>("pt03");
                    SwordBladeThree.GetComponent<buildMetal>().cornerTwelve = ES3.Load<Vector3>("pt123");
                    SwordBladeThree.GetComponent<buildMetal>().cornerFifteen = ES3.Load<Vector3>("pt153");
                    SwordBladeThree.GetComponent<buildMetal>().cornerEighteen = ES3.Load<Vector3>("pt183");
                    SwordBladeThree.GetComponent<buildMetal>().cornerNineteen = ES3.Load<Vector3>("pt193");
                    SwordBladeThree.GetComponent<buildMetal>().floatery = ES3.Load<float>("floaty3");
                    SwordBladeThree.GetComponent<buildMetal>().swordPoints = ES3.Load<float>("attack3");
                    SwordBladeThree.GetComponent<buildMetal>().mounted = true;
                    //SwordBladeThree.GetComponent<buildMetal>().mountPos = ES3.Load<Vector3>("mounty3");
                    Transform transThree = ES3.Load<Transform>("trans3");
                    SwordBladeThree.GetComponent<buildMetal>().transform.position = transThree.position;
                    SwordBladeThree.GetComponent<buildMetal>().transform.rotation = transThree.rotation;
                    int idTwo = ES3.Load<int>("idOne");
                    if (idTwo == 1)
                    {
                        SwordBladeTwo.transform.SetParent(SwordOne.transform);
                    }
                    else if (idTwo == 2)
                    {
                        SwordBladeTwo.transform.SetParent(SwordTwo.transform);
                    }
                    else if (idTwo == 3)
                    {
                        SwordBladeTwo.transform.SetParent(SwordThree.transform);

                    }
                }
                else
                {
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().stateNumber = true;



                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEight = ES3.Load<Vector3>("pt83");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNine = ES3.Load<Vector3>("pt93");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEleven = ES3.Load<Vector3>("pt113");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTen = ES3.Load<Vector3>("pt103");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSixteen = ES3.Load<Vector3>("pt163");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeventeen = ES3.Load<Vector3>("pt173");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwo = ES3.Load<Vector3>("pt23");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerSeven = ES3.Load<Vector3>("pt73");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFive = ES3.Load<Vector3>("pt53");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerZero = ES3.Load<Vector3>("pt03");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerTwelve = ES3.Load<Vector3>("pt123");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerFifteen = ES3.Load<Vector3>("pt153");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerEighteen = ES3.Load<Vector3>("pt183");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().cornerNineteen = ES3.Load<Vector3>("pt193");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().floatery = ES3.Load<float>("floaty3");


                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().swordPoints = ES3.Load<float>("attack3");

                    Transform transThree = ES3.Load<Transform>("trans3");
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().transform.position = transThree.position;
                    SwordBladeThree.GetComponent<weaponS>().bladeObject.GetComponent<buildMetal>().transform.rotation = transThree.rotation;


                }
        }
    }
    // Update is called once per frame
   // public void One()
    //{
    //    sword
    //}
    



    void Update()
    {
        if (paused)
        {

            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            if (OVRInput.GetDown(OVRInput.Button.Four) || Input.GetKeyDown(KeyCode.Y))
            {
                SceneManager.LoadScene(1);
            }
            if (OVRInput.GetDown(OVRInput.Button.Three) || Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene(0);
            }
            if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.A))
            {
                SaveGame();
                paused = false;
            }
            if (OVRInput.GetDown(OVRInput.Button.Two) || Input.GetKeyDown(KeyCode.B))
            {
                LoadGame();
                paused = false;
            }


        }
        else
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }



        if (Input.GetKeyDown(KeyCode.P) || OVRInput.GetDown(OVRInput.Button.Start))
        {
            paused = !paused;
        }
        if (OresCount <= 0)
        {
            print(OresCount);
            gameOver = true;
        }
        if (isWon)
        {
            Winner.SetActive(true);
            if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.A) || OVRInput.GetDown(OVRInput.Button.Start) || OVRInput.GetDown(OVRInput.Button.Three) || OVRInput.GetDown(OVRInput.Button.Four) || OVRInput.GetDown(OVRInput.Button.Two) || Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene(0);
            }
            if (false)
            {
                //SaveGame();
                //isWon = false;
                //Winner.SetActive(false);
                SceneManager.LoadScene(0);
            }
        }



        if (gameOver)
        {

            GameOverPanel.SetActive(true);
            Time.timeScale = 0f;
            if (OVRInput.GetDown(OVRInput.Button.Start) || OVRInput.GetDown(OVRInput.Button.Four) || Input.GetKeyDown(KeyCode.Y))
            {
                SceneManager.LoadScene(1);
            }
            if (OVRInput.GetDown(OVRInput.Button.Two) || Input.GetKeyDown(KeyCode.B))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}


