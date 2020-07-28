using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//create the core variables it uses 
struct BestBook
{
    public string name;
    public string author;
    public float averageRating;
    public int score;
}

public class StructLearn : MonoBehaviour
{
    BestBook[] books;

    void Start()
    {
        books = new BestBook[2];//set struct array length

        //create instance of a struct with new data
        BestBook bookname1 = new BestBook();
        bookname1.name = "book name 1";
        bookname1.author = "author name 1";
        bookname1.averageRating = 3.2f;
        bookname1.score = 1034;

        books[0] = bookname1;//add book created to array


        //create instance of a struct with new data
        BestBook bookname2 = new BestBook();
        bookname2.name = "book name 2";
        bookname2.author = "author name 2";
        bookname2.averageRating = 2.6f;
        bookname2.score = 104;

        books[1] = bookname2;//add book created to array
    }

    void OnDisable()
    {
        foreach(BestBook book in books)
        {
            print(book.name);
            print(book.author);
            print(book.averageRating);
            print(book.score);
            print("--------");
        }
    }
}
