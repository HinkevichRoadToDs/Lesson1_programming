//Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
//заменить большими «К», а большие «С» заменить на маленькие «с».

string text = "Я думаю, – сказал князь, улыбаясь, –"  
    +"что, ежели бы вас послали вместо нашего милого Винценгероде,"  
    +"вы бы взяли приступом согласие прусского короля." 
    +"Вы так красноречивы.Вы дадите мне чаю?";

string ReplaceMethod(string text, char OldValue, char NewValue)
{
   string result = String.Empty;
    int textLength = text.Length;
   for (int index = 0;index < textLength; index++)
    {
        if (text[index] == OldValue)
        {
            result = result + $"{NewValue}";
        } 
        else
        {
            result = result + $"{text[index]}";
        }
    }
   return result;
}
 string UpdText = ReplaceMethod(text,' ','-');
 string UpdText1 = ReplaceMethod(UpdText,'к','К');
 string UpdText2 = ReplaceMethod(UpdText1,'с','С');
//for (int index = 0;index < text.Length; index++)
char char1 = UpdText2[2];
Console.Write(UpdText2);
Console.WriteLine(char1);