Console.Clear();

bool Contains(string input, char searchchar)
{
    for (int i = 0; i < input.Length; i++)
    {
        if(input[i] == searchchar)
        {
            return true;
        }
    }
    return false;
}

int IndexOf(string Search, char target )
{
    for (int i = 0; i < Search.Length; i++)
    {
        if(target == Search[i])
        {
            return i;
        }
    }
    return  -1;
}

int LastIndexOf(string Search, char target)
{
    int lastIndexOf = -1;
    for (int i = 0; i < Search.Length; i++)
    {
        if(target == Search[i])
        {
            lastIndexOf = i;
        }
    }
    return lastIndexOf;
}

string TrimStart(string toSearch, char target)
{
    string newString = "";
    bool continueSearch = true;
    for (int i = 0; i < toSearch.Length; i++)
    {
        if (toSearch[i] != target)
        {
            continueSearch = false;
        }

        if (continueSearch == false)
        {
            newString += toSearch[i];
        }
    }
    return newString;
}

string TrimEnd(string toSearch, char target)
{
    string newString = "";
    bool continueSearch = true;
    for (int i = 0; i < toSearch.Length; i++)
    {
        if (target != toSearch[i])
        {
            continueSearch = false;
        }

        if (continueSearch || target != toSearch[i])
        {
            newString += toSearch[i];
        }
    }
    return newString;
}

string Trim(string toSearch, char target)
{
    string newString = "";
    for (int i = 0; i < toSearch.Length; i++)
    {
        if (toSearch[i] != target)
        {
            newString += toSearch[i];
        }
    }
    return newString;
}

string SubString(string toSub, int index, int max)
{
    string newString = "";
    for (int i = index; i < toSub.Length; i++)
    {
        if (newString.Length < max)
        {
            newString += toSub[i];
        }
    }
    return newString;
}

static string Remove(string toRemove, int index, int max)
{
    int count = 0;
    string newString = "";
    for (int i = 0; i < toRemove.Length; i++)
    {
        if (i < index)
        {
            newString += toRemove[i];
        }
        else
        {
            if (count >= max)
            {
                newString += toRemove[i];
            }
            count++;
        }
    }
    return newString;
}