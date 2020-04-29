using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BinaryNode : MonoBehaviour
{
    public GameObject value;


    public BinaryNode left = null;
    public BinaryNode right = null;
    public BinaryNode(GameObject v = null)
    {
        value = v;
    }



    public void Insert(GameObject[] textPrefabs, int index, BinaryNode searchtree)
    {
        searchtree.value = textPrefabs[index];

        searchtree.Insert(textPrefabs, (2 * index) + 1, searchtree.left);
        searchtree.Insert(textPrefabs, (2 * index) + 2, searchtree.right);


    }



}


/*void insert(BinaryNode story, GameObject[] prefabs)
{
    int index = 0;
    while (isPlaying)
    {
        story.value = prefabs[index];
        story.left.Insert(prefabs, (2 * index) + 1);
        story.right.Insert(prefabs, (2 * index) + 2);
        index++;
    }

}*/






/*foreach(GameObject item in tree)
//{
//     if(searchtree.value == null)
//     {
//         searchtree.value = item;
//     }
//     else
//     {
//         searchtree.left.Insert(tree);
//         searchtree.right.Insert(tree);
//     }
//}*/



/* void NextChoice(BinaryNode jackpot, bool op1, bool op2, bool isPlaying, GameObject textPosition, Button click1, Button click2)
 {
     while (isPlaying == true)
     {
         Instantiate(jackpot.value, textPosition.transform);

         click1.onClick.AddListener(delegate
         {
             op1 = true;
         });

         click2.onClick.AddListener(delegate
         {
             op2 = true;
         });

         if (op1 == true)
         {
             jackpot = jackpot.left;
         }
         else if (op2 == true)
         {
             jackpot = jackpot.right;
         }
     }

 }*/






