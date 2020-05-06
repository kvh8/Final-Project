using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] textPrefabs, textPosition;
    [SerializeField]
    private GameObject  welcome;
    [SerializeField]
    private Button option1, option2, start;

    // [SerializeField]
    //private BinaryNode adventure;
    private GameObject clone;
    private bool op1 = false;
    private bool op2 = false;
    private bool isPlaying = false;
    private int numberOfPrefabs;
    private int textPositionPointer;
    private BinaryNode tree;
    //private BinaryNode adventure;
    int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        resetGame();

        GameObject clone1 = Instantiate(welcome, textPosition[textPositionPointer].transform);

        start.onClick.AddListener(delegate
        {
            Destroy(clone1);
            start.gameObject.SetActive(false);
            option1.gameObject.SetActive(true);
            option2.gameObject.SetActive(true);
            //Insert(textPrefabs, index, tree);


            startGame();
        });
    }
    void startGame()
    {
        //add node to the BinaryTree
        tree.Insert(textPrefabs, index);


        //Instantiates every prefab onto a transform
        //for (int i = 0; i < numberOfPrefabs; i++)
        //{
        //    clone = Instantiate(textPrefabs[i], textPosition[textPositionPointer].transform);
        //    textPosition[textPositionPointer].SetActive(false);
        //    textPositionPointer++;
        //}

        //shows the first text option
        //textPosition[index].SetActive(true);

        //option1.onClick.AddListener(delegate
        //{
        //    textPosition[index].SetActive(false);
        //    Option1();
        //});

        //option2.onClick.AddListener(delegate
        //{
        //    textPosition[index].SetActive(false);
        //    Option2();
        //});


    }

    //void NextChoice()
    //{
    //    while(isPlaying)
    //    {

    //    }
    //}


    void Option1()
    {
        index = (2 * index) + 1;
        textPosition[index].SetActive(true);
        startGame();
    }


    void Option2()
    {
        index = (2 * index) + 2;
        textPosition[index].SetActive(true);
        startGame();
    }




    //public void Insert(GameObject[] textPrefabs, int index, BinaryNode searchtree)
    //{
    //    searchtree = new BinaryNode(textPrefabs[index]);

    //    //searchtree.value = textPrefabs[index];

    //    searchtree.Insert(textPrefabs, (2 * index) + 1, searchtree.left);
    //    searchtree.Insert(textPrefabs, (2 * index) + 2, searchtree.right);

    //}




    //public void ChangeText(bool button, GameObject text)
    //{
    //    if(button == false)
    //    {
    //        text.SetActive(true);
    //    }
    //    else
    //    {
    //        text.SetActive(false);
    //    }
    //}


    private void resetGame()
    {
        textPositionPointer = 0;
        numberOfPrefabs = textPrefabs.Length;
        option1.gameObject.SetActive(false);
        option2.gameObject.SetActive(false);
        start.gameObject.SetActive(true);
        isPlaying = true;

    }




    
}

