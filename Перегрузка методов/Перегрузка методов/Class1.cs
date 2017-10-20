using System;

public static class Dot
{
    public static String Dots(this String st) // метод расширения. в класс string добавили новый метод Dots
    {
        st = st + '.'; 
        return st;
    }
}
