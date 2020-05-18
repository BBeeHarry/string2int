using System;

public class SeparateNumberClass
{
	public SeparateNumberClass()
	{


        string cell = "abc573";


        Console.WriteLine(CheckString2Int(cell));
    }
    public void CheckString2Int(string inputVal) {
        try
        {
            string result = string.Empty;
            string cell = inputVal;
            List<string> val = new List<string>();
            for (int i = 0; i < cell.Length; i++)
            {
                int a = getIndexofNumber(cell.Substring(i, 1));
                if (a > -1)
                {
                    val.Add(cell.Substring(i, 1));
                }
            }
            string separateResult = string.Join("", val);

            //Console.WriteLine(separateResult);
            result = separateResult;
        }
        catch (Exception)
        {

            throw;
        }
    }
    private int getIndexofNumber(string cell)
    {
        int a = -1, indexofNum = 10000;
        a = cell.IndexOf("0"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
        a = cell.IndexOf("1"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
        a = cell.IndexOf("2"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
        a = cell.IndexOf("3"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
        a = cell.IndexOf("4"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
        a = cell.IndexOf("5"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
        a = cell.IndexOf("6"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
        a = cell.IndexOf("7"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
        a = cell.IndexOf("8"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
        a = cell.IndexOf("9"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }

        if (indexofNum != 10000)
        { return indexofNum; }
        else
        { return -1; }


    }
}
