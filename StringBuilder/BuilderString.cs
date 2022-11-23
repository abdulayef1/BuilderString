
using System.Text;

internal class BuilderString
{
    private char[] _arr;
    public int Capacity { get; set; }
    public BuilderString()
    {
        Capacity = 0;
        _arr = new char[Capacity];
    }

    public BuilderString(int capacity)
    {
        Capacity = capacity;
        _arr = new char[Capacity];
    }

    public void Append(char symbol)
    {
        if (Capacity == 0)
        {
            Capacity = 16;
            Array.Resize(ref _arr, Capacity);
        }
        if (_arr[Capacity - 1] != 0)
        {
            Capacity *= 2;
            Array.Resize(ref _arr, Capacity);
            _arr[Capacity / 2] = symbol;
            return;
        }

        for (int i = 0; i < Capacity; i++)
        {
            if (_arr[i] == 0)
            {
                _arr[i] = symbol;
                break;
            }

        }
    }
    public void Append(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            Append(str[i]);
        }
    }

    public BuilderString Replace(char oldVal, char newVal)
    {
        for (int i = 0; i < Capacity; i++)
        {
            if (_arr[i] == 0) break;
            if (_arr[i] == oldVal)
            {
                _arr[i] = newVal;
            }
        }
        return this;
    }

    public BuilderString Remove(int startIndex, int length)
    {
        BuilderString removedArr = new();
        int count=0;
        for (int i = 0; i < Capacity; i++)
        {
            if (_arr[i] == 0) break;
            
            if (i>=startIndex&&count<length)
            {
                
                count++;
            }
            else
            {
                removedArr.Append(_arr[i]);
            }
        }
        return removedArr;
    }

    public override string ToString()
    {
        string result = string.Empty;
        foreach (char item in _arr)
        {
            if (item == 0) break;
            result += item;
        }
        return result;
    }


}

