using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cow : MonoBehaviour
{
    public Text Apple;
    public InputField Orang;

    public void Mango()
    {
        string Kiwi = Orang.text;
        Apple.text = Kiwi;

        if (Kiwi == "Unity" )
        {
            Apple.text = " <color=Blue>[It is a keyword]</color> ]" ;
        }

        if (Kiwi == "Dota 2")
        {
            Apple.text = " <color=Blue>[It is a keyword]</color> ";
        }

        if (Kiwi == "ResidentEvil")
        {
            Apple.text = " <color=Blue>[It is a keyword]</color> ";
        }

        if (Kiwi == "Pubg")
        {
            Apple.text = " <color=Blue>[It is a keyword</color>] ";
        }

        if (Kiwi == "Valorant")
        {
            Apple.text = " <color=Blue>[It is a keyword</color>] ";
        }
    }

}