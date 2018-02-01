using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalNumber : MonoBehaviour {

    public static int PNumber = 0;

    public int GetPNumber()
    {
        return PNumber;
    }

    public static void SetPNumber(int i)
    {
        PNumber = i;
    }

}
