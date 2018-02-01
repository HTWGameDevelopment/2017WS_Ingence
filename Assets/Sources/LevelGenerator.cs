using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public static int levelPart;
    public static string levelnumber;

    public Transform player;
    public Transform block;
    public Transform diamond;
    public Camera kamera;
    public Transform deathzone;
    public Light lightd;
    public Transform key;
    public Transform padlock;
    public Transform flag;
    public Transform portal;
    public Transform blockGetsInvisible;
    public int diamonds = 0;

    public const string sblock = "#";
    public const string sdiamond = "*";
    public const string sstart = "-";
    public const string sclear = ".";
    public const string scamera = "c";
    public const string sdeathzone = "d";
    public const string slight = "l";
    public const string skey = "k";
    public const string spadlock = "x";
    public const string sflag = "e";
    public const string sportal = "p";
    public const string sbginvisible = "i";



    public void Start()
    {
        setLevelPart(1);
        generateLevel();
    }

    public void generateLevel()
    {
        string[][] matrix = readFile("./Assets/Sources/Level" + levelnumber + "/Level" + levelnumber + "-" + levelPart + ".txt");

        // create planes based on matrix
        for (int y = -13; (y + 13) * (-1) < matrix.Length; y--)
        {
            for (int x = -3; x + 3 < matrix[(y + 13) * (-1)].Length; x++)
            {
                switch (matrix[(y + 13) * (-1)][x + 3])
                {
                    case sstart:
                        Instantiate(player, new Vector3(x, y, -54), Quaternion.identity);
                        break;
                    case sblock:
                        Instantiate(block, new Vector3(x, y, -55), Quaternion.identity);
                        break;
                    case sdiamond:
                        Instantiate(diamond, new Vector3(x, y, -55), Quaternion.identity);
                        diamonds++;
                        break;
                    case scamera:
                        Instantiate(kamera, new Vector3(x, y, -56), Quaternion.identity);
                        break;
                    case sdeathzone:
                        Instantiate(deathzone, new Vector3(x, y, -55), Quaternion.identity);
                        break;
                    case slight:
                        Instantiate(lightd, new Vector3(x, y, -55), Quaternion.identity);
                        break;
                    case skey:
                        Instantiate(key, new Vector3(x, y, -55), Quaternion.identity);
                        break;
                    case spadlock:
                        Instantiate(padlock, new Vector3(x, y, -55), Quaternion.identity);
                        break;
                    case sflag:
                        Instantiate(flag, new Vector3(x, y, -55), Quaternion.identity);
                        break;
                    case sportal:
                        Instantiate(portal, new Vector3(x, y, -55), Quaternion.identity);
                        break;
                    case sbginvisible:
                        Instantiate(blockGetsInvisible, new Vector3(x, y, -55), Quaternion.identity);
                        break;
                    case sclear:
                        break;

                }
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

    }

    static string[][] readFile(string file)
    {
        string text = System.IO.File.ReadAllText(file);
        string[] lines = Regex.Split(text, "\r\n");
        int rows = lines.Length;


        string[][] levelBase = new string[rows][];
        for (int i = 0; i < lines.Length; i++)
        {
            string[] stringsOfLine = Regex.Split(lines[i], " ");
            levelBase[i] = stringsOfLine;
        }
        return levelBase;
    }

    public static void setLevelPart(int part)
    {
        levelPart = part;
    }
}
