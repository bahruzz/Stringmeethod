
//int[] arr = { 1, 23, 4, 5 };
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

//int[] arr = { 1, 23, 4, 5 };
//arr[1] = 100;

//string name = "Test";
//string newName = name + "salam";

//using System.Text;

//StringBuilder str=new StringBuilder("Salam");
//str.Append("Sagol");

//int age = 100;
//Console.WriteLine(age.ToString().GetType());

//string surname = "test";
//Console.WriteLine(surname.Length);

//string str1 = "salam";
//string str2 = " necesiz?";
//string result = string.Concat(str1, str2);
//Console.WriteLine(result);

//string result = "";
//string result2=String.Empty;
//var result3 = result2 + "salam";


//string text = string.Empty;
//if (string.IsNullOrEmpty(text))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("fill");
//}


//string text = "s";
//if (string.IsNullOrEmpty(text))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("fill");
//}

//string text = "    ";
//if (string.IsNullOrWhiteSpace(text))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("fill");
//}

//string text = "Azerbaycan";
//Console.WriteLine(text.ToUpper());
//Console.WriteLine(text.ToLower()); ;

//string str1 = "Apple";
//string str2 = "apple";
//Console.WriteLine(str1==str2);


//string str1 = "Apple";
//string str2 = "apple";
//Console.WriteLine(str1.ToLower() == str2.ToLower());

//string str1 = "   Apple";
//string str2 = "apple";
//Console.WriteLine(str1.Trim().ToLower() == str2.Trim().ToLower());


//string str1 = "   Apple";
//string str2 = "apple";
//Console.WriteLine(str1.Trim().ToLower().Equals(str2.Trim().ToLower()));

//string str1 = "   Apple";
//string str2 = "apple";
//Console.WriteLine(Checkstr(str1).Equals(Checkstr(str2)));

//string Checkstr(string str)
//{
//    return str.Trim().ToLower();
//}

//string str = "This is the \"Salam\" class.";
//Console.WriteLine(str);

//string authors = "Mahesh Chand,Henry He,Chris Love,Raj Benival,Praveen Kumar";
//string[] authorlist=authors.Split(',');
//Console.WriteLine(authors);
//foreach (var item in authorlist)
//{
//    Console.WriteLine(item);
//}

//string authors = "Mahesh - Chand,Henry - He,Chris - Love,Raj Benival,Praveen Kumar";
//string[] authorlist = authors.Split('-');

//foreach (var item in authorlist)
//{
//    Console.WriteLine(item);
////}

//string text = "Salam Azerbaycan";
//Console.WriteLine(text.Replace("Salam", "Sagol"));


//string text = "Salam Azerbaycan";
//string result = text.Substring(0, 5 )+ "...";
//Console.WriteLine(result);


//string text = "Salam Azerbaycan";
//Console.WriteLine(text.Contains("Az"));

//bool CheckCharInStr(string text,char letter)
//{
//    return text.Trim().Contains(letter);
//}
//Console.WriteLine(CheckCharInStr("Baku",'B'));


//bool CheckCharInStr(string text, string letter)
//{
//    return text.Trim().ToLower().Contains(letter.Trim().ToLower());
//}
//Console.WriteLine("Add text");
//string text = Console.ReadLine();
//Console.WriteLine("Add search text");
//string searchtext=Console.ReadLine();
//if(CheckCharInStr(text, searchtext))
//{
//    Console.WriteLine("Found");

//}
//else
//{
//    Console.WriteLine("Not found");
//}

//bool CheckCharInStr(string text, string letter)
//{
//     return CheckStr(text).Contains(CheckStr(letter));

//}
//string CheckStr(string str)
//{
//    return str.Trim().ToLower();
//}
//Console.WriteLine("Add text");
//string text = Console.ReadLine();
//Console.WriteLine("Add search text");
//string searchtext = Console.ReadLine();
//if (CheckCharInStr(text, searchtext))
//{
//    Console.WriteLine("Found");

//}
//else
//{
//    Console.WriteLine("Not found");
//}



//bool Search(string text, string letter)
//{
//    return CheckStr(text).Contains(CheckStr(letter));

//}
//string CheckStr(string str)
//{
//    return str.Trim().ToLower();
//}

//void Startsearch()
//{
//    Console.WriteLine("Add text");
//    string text = Console.ReadLine();
//    Console.WriteLine("Add search text");
//    string searchtext = Console.ReadLine();
//    if (Search(text, searchtext))
//    {
//        Console.WriteLine("Found");

//    }
//    else
//    {
//        Console.WriteLine("Not found");
//    }
//}

//Startsearch();

//Parametr olaraq string qebul eden metod yazmalisiz. 
//    Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin.
//    (Cavid gelirse , ekranda divaC gorsensin).

//String NameChange(string text)
//{
//    string result = "";
//    for (var i = text.Length - 1; i >= 0; i--)
//    {
//        result += text[i];
//    }
//    return result;
//}

//Console.WriteLine(NameChange("Azerbaycan"));