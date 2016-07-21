﻿// This code automatically generated by TableCodeGen
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ReciepCSVReader: MonoBehaviour
{
    public TextAsset file;
    private int cntIngredient;

    private string reciep;
    private List<string> reciepList=new List<string>();
    

    public int CntIngredient
    {
        set { cntIngredient = value; }
        get { return cntIngredient; }
    }

    public List<string> ReciepList
    {
        get { return reciepList; }
    }

    public string Reciep
    {
        get { return reciep; }
        set { reciep = value; }
    }

   /* void Awake()
    {
        // Do not destroy this game object:
        DontDestroyOnLoad(this);

    }*/
    void Start()
    {
        Load(file);
        reciep = PlayerPrefs.GetString("ChoosedReciep");
        cntIngredient = PlayerPrefs.GetInt("IngredientsCount");
        reciepList.Add(FindAll_Ingredient1(reciep).ToString());
        Debug.Log(FindAll_Ingredient1(reciep).ToString());
        reciepList.Add(FindAll_Ingredient2(reciep).ToString());
        reciepList.Add(FindAll_Ingredient3(reciep).ToString());
        reciepList.Add(FindAll_Ingredient4(reciep).ToString());
        reciepList.Add(FindAll_Ingredient5(reciep).ToString());
        reciepList.Add(FindAll_Ingredient6(reciep).ToString());
        reciepList.Add(FindAll_Ingredient7(reciep).ToString());
        reciepList.Add(FindAll_Ingredient8(reciep).ToString());
        reciepList.Add(FindAll_Ingredient9(reciep).ToString());
        reciepList.Add(FindAll_Ingredient10(reciep).ToString());
        reciepList.Add(FindAll_Ingredient11(reciep).ToString());
        reciepList.Add(FindAll_Ingredient12(reciep).ToString());

        for (int i=cntIngredient; i<reciepList.Count;i++)
        {
            reciepList.RemoveAt(i);
        }
    }


    public class Row
    {
        public string Reciep;
        public string Ingredient1;
        public string Ingredient2;
        public string Ingredient3;
        public string Ingredient4;
        public string Ingredient5;
        public string Ingredient6;
        public string Ingredient7;
        public string Ingredient8;
        public string Ingredient9;
        public string Ingredient10;
        public string Ingredient11;
        public string Ingredient12;

    }

    List<Row> rowList = new List<Row>();
    bool isLoaded = false;

    public bool IsLoaded()
    {
        return isLoaded;
    }

    public List<Row> GetRowList()
    {
        return rowList;
    }

    public void Load(TextAsset csv)
    {
        rowList.Clear();
        string[][] grid = CsvParser2.Parse(csv.text);
        for (int i = 1; i < grid.Length; i++)
        {
            Row row = new Row();
            row.Reciep = grid[i][0];
            row.Ingredient1 = grid[i][1];
            row.Ingredient2 = grid[i][2];
            row.Ingredient3 = grid[i][3];
            row.Ingredient4 = grid[i][4];
            row.Ingredient5 = grid[i][5];
            row.Ingredient6 = grid[i][6];
            row.Ingredient7 = grid[i][7];
            row.Ingredient8 = grid[i][8];
            row.Ingredient9 = grid[i][9];
            row.Ingredient10 = grid[i][10];
            row.Ingredient11 = grid[i][11];
            row.Ingredient12 = grid[i][12];

            rowList.Add(row);
        }
        isLoaded = true;
    }

    public int NumRows()
    {
        return rowList.Count;
    }

    public Row GetAt(int i)
    {
        if (rowList.Count <= i)
            return null;
        return rowList[i];
    }

    public Row Find_Reciep(string find)
    {
        return rowList.Find(x => x.Reciep == find);
    }
    public List<Row> FindAll_Reciep(string find)
    {
        return rowList.FindAll(x => x.Reciep == find);
    }
    public Row Find_Ingredient1(string find)
    {
        return rowList.Find(x => x.Ingredient1 == find);
    }
    public List<Row> FindAll_Ingredient1(string find)
    {
        return rowList.FindAll(x => x.Ingredient1 == find);
    }
    public Row Find_Ingredient2(string find)
    {
        return rowList.Find(x => x.Ingredient2 == find);
    }
    public List<Row> FindAll_Ingredient2(string find)
    {
        return rowList.FindAll(x => x.Ingredient2 == find);
    }
    public Row Find_Ingredient3(string find)
    {
        return rowList.Find(x => x.Ingredient3 == find);
    }
    public List<Row> FindAll_Ingredient3(string find)
    {
        return rowList.FindAll(x => x.Ingredient3 == find);
    }
    public Row Find_Ingredient4(string find)
    {
        return rowList.Find(x => x.Ingredient4 == find);
    }
    public List<Row> FindAll_Ingredient4(string find)
    {
        return rowList.FindAll(x => x.Ingredient4 == find);
    }
    public Row Find_Ingredient5(string find)
    {
        return rowList.Find(x => x.Ingredient5 == find);
    }
    public List<Row> FindAll_Ingredient5(string find)
    {
        return rowList.FindAll(x => x.Ingredient5 == find);
    }
    public Row Find_Ingredient6(string find)
    {
        return rowList.Find(x => x.Ingredient6 == find);
    }
    public List<Row> FindAll_Ingredient6(string find)
    {
        return rowList.FindAll(x => x.Ingredient6 == find);
    }
    public Row Find_Ingredient7(string find)
    {
        return rowList.Find(x => x.Ingredient7 == find);
    }
    public List<Row> FindAll_Ingredient7(string find)
    {
        return rowList.FindAll(x => x.Ingredient7 == find);
    }
    public Row Find_Ingredient8(string find)
    {
        return rowList.Find(x => x.Ingredient8 == find);
    }
    public List<Row> FindAll_Ingredient8(string find)
    {
        return rowList.FindAll(x => x.Ingredient8 == find);
    }
    public Row Find_Ingredient9(string find)
    {
        return rowList.Find(x => x.Ingredient9 == find);
    }
    public List<Row> FindAll_Ingredient9(string find)
    {
        return rowList.FindAll(x => x.Ingredient9 == find);
    }
    public Row Find_Ingredient10(string find)
    {
        return rowList.Find(x => x.Ingredient10 == find);
    }
    public List<Row> FindAll_Ingredient10(string find)
    {
        return rowList.FindAll(x => x.Ingredient10 == find);
    }
    public Row Find_Ingredient11(string find)
    {
        return rowList.Find(x => x.Ingredient11 == find);
    }
    public List<Row> FindAll_Ingredient11(string find)
    {
        return rowList.FindAll(x => x.Ingredient11 == find);
    }
    public Row Find_Ingredient12(string find)
    {
        return rowList.Find(x => x.Ingredient12 == find);
    }
    public List<Row> FindAll_Ingredient12(string find)
    {
        return rowList.FindAll(x => x.Ingredient12 == find);
    }

}